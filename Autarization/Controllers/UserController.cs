using Autarization.Context;
using Autarization.Filters;
using Autarization.Model;
using Autarization.ProblemSolution;
using Autarization.Service;
using Microsoft.AspNetCore.Mvc;

namespace Autarization.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : Controller
{
    private readonly Solution _solution;
    private readonly UserDbContext _context;
   
    public UserController(UserDbContext context , Solution solution)
    {
        _solution = solution;
        _context = context;
    }

    [HttpPost]
    public IActionResult Register(UserDto userdto)
    {
        var key = Guid.NewGuid().ToString("N");
        var user = new User()
        {
            Key = key,
            Password = userdto.Password,
            Name = userdto.Name,
        };
      _context.Users.Add(user);
        _context.SaveChanges();
        return Ok(key);
    }
   
   [TypeFilter(typeof(FilterAttribute))]
    [HttpGet("problem")]
    public IActionResult Problem(long n , int k)
    {
     /*  if(!HttpContext.Request.Headers.ContainsKey("Key"))
         return NotFound();
        */
        var result = _solution.SongachaUchlar(n, k);
        return Ok(result);
    }

}



