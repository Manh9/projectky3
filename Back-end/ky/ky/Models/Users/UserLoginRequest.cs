﻿using System.ComponentModel.DataAnnotations;

namespace ky.Models.Users
{
    public class UserLoginRequest
    {
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, MinLength(6)]
        public string Password { get; set; } = string.Empty;
    }
}
