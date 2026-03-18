using System.ComponentModel.DataAnnotations;

namespace Refresher.Models
{
    public class DeviceType
    {
        [Key]
        public int Id { get; set; }   

        public string Name { get; set; }
    }
}
