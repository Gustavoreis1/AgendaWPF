﻿using System;
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
        [Display(Name = "Titulo")]

        public String Local { get; set; }
        [MaxLength(500, ErrorMessage = "O campo Local recebe no máximo 500 caracteres")]
        [Display(Name = "Local")]

        public DateTime Inicio { get; set; }
        [Required(ErrorMessage = "O campo Data de Inicio é requerido!!")]

        public DateTime Fim { get; set; }

        public IList<Contato> Participantes { get; set; }
    }
}
