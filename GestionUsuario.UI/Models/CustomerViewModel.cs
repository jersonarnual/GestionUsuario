using System;
using System.ComponentModel.DataAnnotations;

namespace GestionUsuario.UI.Models
{
    public class CustomerViewModel
    {
        public Guid Id { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string FirstName { get; set; }
        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string LastName { get; set; }
        [Display(Name = "Numero de Documento")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Document { get; set; }
        [Display(Name = "Correo Electronico")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Email { get; set; }
        [Display(Name = "Edad")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Age { get; set; }
        public bool State { get; set; }
        public Guid TypeDocumentId { get; set; }
        public Guid GenderId { get; set; }
    }
}
