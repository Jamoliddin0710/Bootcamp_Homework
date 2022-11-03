using System.ComponentModel.DataAnnotations;

namespace Autarization.Model
{
    public class UserDto
    {
        [Required] 
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
