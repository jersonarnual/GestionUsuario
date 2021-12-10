using GestionUsuario.Data.Models.Config;
using System;
using System.Collections.Generic;

namespace GestionUsuario.DATA.Models
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public bool State { get; set; }
        public int GenderId { get; set; }
        public int TypeDocumentId { get; set; }
        public virtual ICollection<Gender> Gender { get; set; }
        public virtual ICollection<TypeDocument> TypeDocument { get; set; }
    }
}
