using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Home
    {
        
        public Guid HomeId { get; set; }
        public string HomeType { get; set; }
        public bool IsNeighbour {get; set; }
        
        
    }
}
