using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploye.Common.Model
{
    //[Table(nameof(Role))]
    public class Role
    {
        [Key]
        public int IdRole { get; set; }

        //[Required, MaxLength(255)]
        public string Nom { get; set; }

        public ICollection<Employe> Employes { get; set; }
    }
}
