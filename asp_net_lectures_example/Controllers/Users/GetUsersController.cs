using asp_net_lectures_example.Models;
using DataAccess.MockDb;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_lectures_example.Controllers.Users;

public sealed class GetUsersController : Controller
{
    [HttpGet]
    public IActionResult UsersList()
    {
        // emulate db query and BL calling
        IEnumerable<UserViewModel> model =
            MockDb.Users.Select(p => new UserViewModel(p.Key, p.Value.UserName, p.Value.Email));
        
        
        return View("Users/UsersList", model);
    }
}