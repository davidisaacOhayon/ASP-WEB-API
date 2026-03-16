using System.ComponentModel.DataAnnotations;

namespace Refresher.Models
{
    public class Device
    {

        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public DeviceType Type { get; set; }


    }
}
