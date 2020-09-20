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
            context.Films.Add(new Film()
            {
                Name = "Джентельмены",
                Rating = 7,
                ImageURL = "https://upload.wikimedia.org/wikipedia/ru/c/c1/%D0%94%D0%B6%D0%B5%D0%BD%D1%82%D0%BB%D1%8C%D0%BC%D0%B5%D0%BD%D1%8B.jpg"
            });

            context.SaveChanges();
        }
    }
}

