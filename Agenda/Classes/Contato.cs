using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Classes
{
    [Table("Contatos")]
    public class Contato
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é requerido!!")]
        [MaxLength(100, ErrorMessage = "O campo Nome recebe no máximo 100 caracteres")]
        [MinLength(3, ErrorMessage = "O campo Nome recebe no Minimo 3 caracteres")]
        [Display(Name = "Nome")]
        public String Nome { get; set; }
        
        [Required(ErrorMessage = "O campo Sobrenome é requerido!!")]
        [MaxLength(100, ErrorMessage = "O campo Sobrenome recebe no máximo 100 caracteres")]
        [MinLength(2, ErrorMessage = "O campo Nome recebe no Minimo 2 caracteres")]
        [Display(Name = "Sobrenome")]
        public String Sobrenome { get; set; }
        
        public DateTime Nasc { get; set; }

        [Required(ErrorMessage = "O campo Telefone é requerido!!")]
        [MaxLength(20, ErrorMessage = "O campo Telefone recebe no máximo 20 caracteres")]
        [Display(Name = "Telefone")]
        public String Telefone { get; set; }
        

        public IList<Compromisso> Compromissos { get; set; }

        
    }
}
