using System.ComponentModel.DataAnnotations;

namespace BankingSystem.Models
{
    public class User
    {
        public User(
            string firstName,  
            string lastName, 
            string otherNames, 
            string email, 
            string password
            )
        {
            FirstName = firstName; 
            LastName = lastName;
            OtherNames = otherNames;
            Email = email;
            Password = password;
        }

        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string OtherNames { get; set; } = string.Empty;
        [Key]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
