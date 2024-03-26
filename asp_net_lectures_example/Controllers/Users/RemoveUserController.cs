using DataAccess.MockDb;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_lectures_example.Controllers.Users;

public sealed class RemoveUserController : Controller
{
    public IActionResult Delete([FromRoute]int id)
    {
        // emulate bl + db request
        MockDb.Users.Remove(id);
        return RedirectToAction("UsersList", "GetUsers");
    }
}