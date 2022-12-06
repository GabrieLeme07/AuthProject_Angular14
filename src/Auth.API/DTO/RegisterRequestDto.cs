using Auth.API.Validations;
using System.ComponentModel.DataAnnotations;

namespace Auth.API.DTO;

public class RegisterRequest
{
    [MinLength(ConstsValidation.UsernameMinLength,
        ErrorMessage = ConstsValidation.UsernameLengthValidationError)]
    public string? UserName { get; set; }

    [EmailAddress(ErrorMessage = ConstsValidation.EmailValidationError)]
    public string? Email { get; set; }

    [RegularExpression(ConstsValidation.PasswordRegex,
        ErrorMessage = ConstsValidation.PasswordValidationError)]
    public string? Password { get; set; }
}