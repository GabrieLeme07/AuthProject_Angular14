﻿using System.ComponentModel.DataAnnotations;

namespace Auth.API.DTO;

public class LoginRequest
{
    [Required]
    public string? Username { get; set; }
    [Required]
    public string? Password { get; set; }
}