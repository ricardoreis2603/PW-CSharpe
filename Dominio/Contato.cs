using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Contato : EntidadeBase
    {
        [Display(Name = "Telefone" )]
        public string NumeroTelefone { get; set; }
        public string NumeroTelefoneResidencial { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
    }
}
