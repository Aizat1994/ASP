using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
        public string JobPlace { get; set; }
        public string SkinCollor { get; set; }

        [ForeignKey("HomeId")]
        public Home? Home { get; set; }



    }
}
