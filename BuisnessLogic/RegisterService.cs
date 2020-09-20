using CinemaProject.DataLayer.Models;
using CinemaProject.DataLayer.UOW.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.BuisnessLogic
{
    public class RegisterService
    {
        private readonly IUnitOfWork _db;
        public RegisterService(IUnitOfWork db)
        {
            _db = db;
        }
        private async Task<bool> isFree(string login)
        {
            var res = await _db.Users.FindByConditionAsync(x => x.Login == login);
            return res.Count == 0;
        }
        public async Task<bool> RegisterUser(string login, string password, string email)
        {
            if (!await isFree(login)) return false;
            else
            {
                await _db.Users.CreateAsync(new User() { Login = login, Password = password, Email = email, isAdmin = false });
                await _db.SaveAsync();
                return true;
            }
        }
    }
}
