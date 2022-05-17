﻿using System.ComponentModel.DataAnnotations;

namespace BaseEcommerce.WebUI.Models
{
    public class SignInInput
    {
        [Required]
        [Display(Name = "Email adresiniz")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Şifreniz")]
        public string Password { get; set; }
        [Display(Name = "Beni hatırla")]
        public bool IsRemember { get; set; }
    }
}
