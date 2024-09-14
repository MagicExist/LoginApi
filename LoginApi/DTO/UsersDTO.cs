using System.ComponentModel.DataAnnotations;

namespace LoginApi.DTO
{
    public class UsersDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
