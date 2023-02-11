using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StateNationalParkApi.Models;

namespace StateNationalParkApi.Controllers.V1
{
  [ApiController]
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiVersion("1.0")]
  public class ParksController : ControllerBase
  {
    private readonly StateNationalParkApiContext _db;
    public ParksController (StateNationalParkApiContext db)
    {
      _db = db;
    }

    // GET api/parks
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string parkName, string parkState, string stateOrNational)
    {
      IQueryable<Park> query = _db.Parks.AsQueryable();

      if (

  }
}