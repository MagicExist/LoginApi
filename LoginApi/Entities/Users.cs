using System.ComponentModel.DataAnnotations;

namespace LoginApi.Entities
{
    public class Users 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
