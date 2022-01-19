using GestionEmploye.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GestionEmploye.Common
{
    //[Table(nameof(Employe))]
    public class Employe
    {
       // [Key]
        public int Id { get; set; }

        //[Required, MaxLength(255)]
        public string Prenom { get; set; }

        //[Required, MaxLength(255)]
        public string Nom { get; set; }

        //[Required]
        public DateTimeOffset DateEmbauche { get; set; }

        //[Required]
        public bool EstPiloteDeLigne { get; set; }

       // [ForeignKey("Role"), Required]
        public int RoleId { get; set; }

        public Role Role { get; set; }

    }
}
