using GestionUsuario.Data.Models.Config;
using System;

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
        public Guid GenderId { get; set; }
        public Guid TypeDocumentId { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual TypeDocument TypeDocument { get; set; }
    }
}
