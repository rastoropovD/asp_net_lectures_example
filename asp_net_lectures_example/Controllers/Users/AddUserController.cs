using System.Linq;
using asp_net_lectures_example.Models;
using asp_net_lectures_example.Resources;
using DataAccess.Entities;
using DataAccess.MockDb;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Localization;

namespace asp_net_lectures_example.Controllers.Users;

public sealed class AddUserController : Controller
{
    [HttpGet]
    public IActionResult CreateUser()
    {
        return View("Users/CreateUser");
    }

    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult CreateUser(CreateUserViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View("Users/CreateUser");
        }
        
        int newId = MockDb.Users.Max(p => p.Key) + 1;
        MockDb.Users.Add(newId, new UserEntity(newId, model.UserName, model.Email, model.Password));
        return RedirectToAction("UsersList", "GetUsers");
    }
}