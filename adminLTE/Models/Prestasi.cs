using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace adminLTE.Models
{
    public class Prestasi
    {
        [Key]
        public int PrestasiID { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        public string Nama { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string NamaPrestasi{ get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Tahun { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Kegiatan { get; set; }
    }
}