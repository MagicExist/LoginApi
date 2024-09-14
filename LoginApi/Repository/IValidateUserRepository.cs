using LoginApi.Entities;

namespace LoginApi.Repository
{
    public interface IValidateUserRepository
    {
        public Task<bool> VerifyUser(Users user);
    }
}
