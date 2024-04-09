using System.Collections.Generic;
using System.Linq;
using asp_net_lectures_example.Models;
using DataAccess.MockDb;
using DataAccess.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_lectures_example.Controllers.Users;

public sealed class GetUsersController : Controller
{
    private readonly IUsersRepository _usersRepository;

    public GetUsersController(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    [HttpGet]
    public ViewResult UsersList()
    {
        // emulate db query and BL calling
        IEnumerable<UserViewModel> model =
            _usersRepository.GetUsers().Select(p => new UserViewModel(p.Id, p.UserName, p.Email));
        // IEnumerable<UserViewModel> model =
        //     MockDb.Users.Select(p => new UserViewModel(p.Key, p.Value.UserName, p.Value.Email));
        //
        
        return View("Users/UsersList", model);
    }
}