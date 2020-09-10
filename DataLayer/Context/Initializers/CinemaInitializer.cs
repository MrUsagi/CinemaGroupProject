using CinemaProject.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaProject.DataLayer.Context.Initializers
{
    public static class CinemaInitializer
    {
        public static void Initialize(CinemaContext context)
        {
            context.Database.EnsureCreated();
            if (context.Users.Any()) return;
            context.Users.Add(new User() { 
                Login = "root",
                Password = "root",
                isAdmin = true
            });

            context.SaveChanges();
        }
    }
}

