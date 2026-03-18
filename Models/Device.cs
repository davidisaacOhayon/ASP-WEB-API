using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Refresher.Models
{
    public class Device
    {
        [Key]
        public string Id { get; set; }  

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [ForeignKey("DeviceTypeId")]
        public DeviceType Type { get; set; }


    }
}
