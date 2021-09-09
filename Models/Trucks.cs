using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDTesteMeta.Models
{
    public class Trucks
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int TruckId { get; set; }

        [Required]
        public string TrukModel { get; set; }

        [Required]
        public string TrukModelYear { get; set; }

        [Required]
        public string TrukManufacturingYear { get; set; }


    }
}
