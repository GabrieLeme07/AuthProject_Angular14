using Auth.API.Validations;
using System.ComponentModel.DataAnnotations;

namespace Auth.API.DTO;

public class LoginRequest
{
    [MinLength(ConstsValidation.UsernameMinLength,
        ErrorMessage = ConstsValidation.UsernameLengthValidationError)]
    public string? Username { get; set; }

    [RegularExpression(ConstsValidation.PasswordRegex,
        ErrorMessage = ConstsValidation.PasswordValidationError)]
    public string? Password { get; set; }
}