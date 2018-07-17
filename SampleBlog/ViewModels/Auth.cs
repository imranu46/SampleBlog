﻿
using System.ComponentModel.DataAnnotations;

namespace SampleBlog.ViewModels
{
    public class AuthLogin
    {
        [Required]
        public string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }


        public string Abc123 { get; set; }
    }
}