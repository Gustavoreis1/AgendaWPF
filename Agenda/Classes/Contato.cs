using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Classes
{
    public class Contato
    {
        public String Nome { get; set; }
        [Required(ErrorMessage = "O campo Nome é requerido!!")]
        [MaxLength(100, ErrorMessage = "O campo Nome recebe no máximo 100 caracteres")]
        [Display(Name = "Nome")]
        public String Sobrenome { get; set; }
        [Required(ErrorMessage = "O campo Sobrenome é requerido!!")]
        [MaxLength(100, ErrorMessage = "O campo Sobrenome recebe no máximo 100 caracteres")]
        [Display(Name = "Sobrenome")]
        public DateTime Nasc { get; set; }
        public String Telefone { get; set; }
        [Required(ErrorMessage = "O campo Telefone é requerido!!")]
        [MaxLength(20, ErrorMessage = "O campo Telefone recebe no máximo 20 caracteres")]
        [Display(Name = "Telefone")]
        public IList<Compromisso> Compromissos { get; set; }
    }
}
