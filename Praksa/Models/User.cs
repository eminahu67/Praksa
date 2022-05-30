using System.Collections.Generic;
namespace Praksa.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte [] PassworddHash { get; set; }
        public byte [] PasswordSalt { get; set; }

        public List<Character> Characters { get; set;}


    }
}
