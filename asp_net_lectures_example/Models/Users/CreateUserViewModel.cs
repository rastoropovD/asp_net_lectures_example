using System.ComponentModel.DataAnnotations;

namespace asp_net_lectures_example.Models;

public class CreateUserViewModel
{
    [MinLength(3)]
    [MaxLength(10)]
    [Required]
    public string UserName { get; init; }
    
    [Required]
    public string Email { get; init; }
    
    [Required]
    public string Password { get; init; }
}