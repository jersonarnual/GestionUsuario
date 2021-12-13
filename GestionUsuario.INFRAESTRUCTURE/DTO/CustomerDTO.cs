using System;

namespace GestionUsuario.INFRAESTRUCTURE.DTO
{
    public class CustomerDTO
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public bool State { get; set; }
        public Guid GenderId { get; set; }
        public Guid TypeDocumentId { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
