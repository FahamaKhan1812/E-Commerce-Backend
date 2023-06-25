using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers;
public class BuggyController : BaseAPiCotroller
{
	private readonly StoreContext _storeContext;

	public BuggyController(StoreContext storeContext)
	{
		_storeContext = storeContext;
	}

    [HttpGet("notfound")]
	public ActionResult GetNotFound()
	{
		var thing = _storeContext.Products.Find(4444);
		if(thing == null)
		{
			return NotFound();
		}
		return Ok(thing);
	}

}
