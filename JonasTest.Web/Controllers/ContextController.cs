﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;

using JonasTest.Data.Model;
using JonasTest.Web.Config;

namespace JonasTest.Web.Controllers
{
		
	public class ContextController : Controller
	{
			protected ScoreCardContext _context;
			protected ILogger _logger;
			protected int MaxResultTake;
			private IMemoryCache _cache;
		

		public ContextController(ScoreCardContext context,  ILoggerFactory logFactory, IMemoryCache memoryCache, IOptions<ApiSettings> options)
			
			{
				_context = context;
				_logger = logFactory.CreateLogger<ContextController>();
				_cache = memoryCache;
				MaxResultTake  = options.Value.MaxTake;
			}

			public override void OnActionExecuted(ActionExecutedContext asyncResult)
			{
				base.OnActionExecuted(asyncResult);

				if (HasModifiedEntity())
					try
					{
						_context.SaveChanges();
					}
					catch (Exception ex)
					{
						RejectChanges();

						//log
						_logger.LogError(ex.Message, ex);
						throw;
					}
			}

		protected T GetCacheValue<T>(string cachekey)
		{
			T cacheEntry = default(T);
			// Look for cache key.
			if (_cache.TryGetValue<T>(cachekey, out cacheEntry))
				return cacheEntry;
			return  default(T);
		}

		protected void AddCacheValue<T>(string cachekey, T cacheEntry)
		{
			// Set cache options.
			var cacheEntryOptions = new MemoryCacheEntryOptions()
				// Keep in cache for this time, reset time if accessed.
				.SetSlidingExpiration(TimeSpan.FromSeconds(30));

			// Save data in cache.!
			_cache.Set<T>(cachekey, cacheEntry);
		}

		protected void RemoveCacheValue(string cachekey)
		{ 
			// Save data in cache.
			_cache.Remove(cachekey);
		}

		protected void RejectChanges()
			{
				foreach (var entry in _context.ChangeTracker.Entries())
				{
					switch (entry.State)
					{
						case EntityState.Modified:
						case EntityState.Deleted:
							entry.State = EntityState.Modified; //Revert changes made to deleted entity.
							entry.State = EntityState.Unchanged;
							break;
						case EntityState.Added:
							entry.State = EntityState.Detached;
							break;
					}
				}
			}

		protected bool HasModifiedEntity()
			{
				return _context.ChangeTracker.Entries()
					.Any(e =>
					   e.State == EntityState.Modified
					|| e.State == EntityState.Deleted
					|| e.State == EntityState.Added);

			}

		protected void SaveEntityContext()
			{
				try
				{
					_context.SaveChanges();
				}
				catch (Exception ex)
				{
					var str = ex.Message;
					throw;
				}
			}
	}
}
