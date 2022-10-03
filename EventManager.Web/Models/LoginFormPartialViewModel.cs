using System.ComponentModel.DataAnnotations;

namespace EventManager.Web.Models;

public class LoginFormPartialViewModel
{
    [Required]
    [DataType(DataType.EmailAddress)]
    public string Email { get; }
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; }
}