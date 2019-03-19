using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

using JonasTest.Data.Model;

namespace JonasTest.Web.Controllers
{
		
	public class ContextController : Controller
	{
			protected ScoreCardContext _context;
			protected ILogger _logger;
			//protected IRepository _userRepository;
			//private IMemoryCache _cache;


		public ContextController(ScoreCardContext context,  ILoggerFactory logFactory)
			
			{
				_context = context;
				//_userFacade = new UserFacade(context);
				//_userRepository = userRepo;
				_logger = logFactory.CreateLogger<ContextController>();
				//_cache = memoryCache;
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
