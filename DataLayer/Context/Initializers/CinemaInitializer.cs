using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaProject.DataLayer.Context.Initializers
{
    public static class CinemaInitializer
    {
        public static void Initialize(CinemaContext context)
        {
            context.Database.EnsureCreated();
            if (context.Users.Any()) return;
            context.Users.Add(new User() { });

            context.SaveChanges();
        }
    }
}
}
