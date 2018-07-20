using SampleBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleBlog.Areas.Admin.ViewModels
{
    public class UsersIndex
    {
        public IEnumerable<User> Users { get; set; }
    }
}