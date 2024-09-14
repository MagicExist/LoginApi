using LoginApi.DTO;
using LoginApi.Entities;
using LoginApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace LoginApi.Repositories
{
    public class ValidateUser : IValidateUserRepository
    {
        private readonly LoginContext _ctx;
        public ValidateUser(LoginContext ctx) 
        {
            _ctx = ctx;
        }
        public async Task<bool> VerifyUser(Users user)
        {
            var response =  await _ctx.Users.FirstOrDefaultAsync(u => u.UserName == user.UserName && u.Password == user.Password);
            if (response == null) 
            {
                return false;
            }
            return true;
        }
    }
}
