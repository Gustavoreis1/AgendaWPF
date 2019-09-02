using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Classes
{
    public class Compromisso
    {
        public String Titulo { get; set; }
        [Required(ErrorMessage = "O campo Titulo é requerido!!")]
        [MaxLength(200, ErrorMessage = "O campo Titulo recebe no máximo 200 caracteres")]
        [Display(Name = "Sobrenome")]
        public String Local { get; set; }
        [Required(ErrorMessage = "O campo Local é requerido!!")]
        [MaxLength(100, ErrorMessage = "O campo Sobrenome recebe no máximo 100 caracteres")]
        [Display(Name = "Sobrenome")]
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public IList<Contato> Participantes { get; set; }
    }
}
