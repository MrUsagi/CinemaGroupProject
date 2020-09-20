using CinemaProject.DataLayer.UOW.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProject.BuisnessLogic
{
    public class LoginService
    {
        private readonly IUnitOfWork _db;
        public LoginService(IUnitOfWork db)
        {
            _db = db;
        }
        private async Task<bool> IsLogin(string login, string pswd)
        {
            var res = await _db.Users.FindByConditionAsync(x => x.Login == login && x.Password == pswd);
            return res.Count>0;
        }

        public async Task<bool> Login(string login, string pswd)
        {
            if (await IsLogin(login, pswd))
            {
                var user = await _db.Users.FindByConditionAsync(x => x.Login == login && x.Password == pswd);
                UserControler.User = user.FirstOrDefault();
                return true;
            }
            else return false;
        }
    }
}
