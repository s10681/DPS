using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DPS.Model
{
    public class Kontrahent
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nazwa kontrahenta jest wymagana!")]
        [StringLength(50)]
        public string Nazwa { get; set; }

        [Required(ErrorMessage = "NIP kontrahenta jest wymagany!")]
        [StringLength(10), MinLength(10)]
        public string Nip { get; set; }

        [ForeignKey("TypKontrahenta")]
        public int IdTypKontrahenta { get; set; }
        public virtual TypKontrahenta TypKontrahenta { get; set; }

        [StringLength(500)]
        public string OpisFirmy { get; set; }

        public bool CzyAktywny { get; set; } = true;

    }
}
