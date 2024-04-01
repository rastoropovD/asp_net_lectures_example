using System.ComponentModel.DataAnnotations;
using asp_net_lectures_example.Resources;

namespace asp_net_lectures_example.Models;

public class CreateUserViewModel
{
    [MinLength(3)]
    [MaxLength(10)]
    [Required(ErrorMessageResourceName = "UserNameRequired", ErrorMessageResourceType = typeof(SharedResource))]
    [Display(Name = "UserName", ResourceType = typeof(SharedResource))]
    public string UserName { get; init; }
    
    [Required]
    [Display(Name = "Email", ResourceType = typeof(SharedResource))]
    public string Email { get; init; }
    
    [Required]
    [Display(Name = "Password", ResourceType = typeof(SharedResource))]
    public string Password { get; init; }
}