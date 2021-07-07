using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Models.Common
{
    public class File
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string DocumentName { get; set; }

        [Required]
        [MaxLength(1000)]
        public string URL { get; set; }

        [Required]
        [MaxLength(250)]
        public string Descrtiption { get; set; }
    }
}
