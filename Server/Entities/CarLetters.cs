using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Entities
{
    public class CarLetter
    {
        [Required]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Region { get; set; }
        [Required, MaxLength(100)]
        public string Code { get; set; }
    }
}
