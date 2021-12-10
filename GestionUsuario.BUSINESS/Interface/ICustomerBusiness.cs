using GestionUsuario.INFRAESTRUCTURE.DTO;
using System;
using System.Collections.Generic;

namespace GestionUsuario.Business.Interface
{
    public interface ICustomerBusiness
    {
        List<CustomerDTO> GetAll();
        CustomerDTO GetById(Guid id);
        bool Insert(CustomerDTO entity);
        bool Update(CustomerDTO entity);
        bool Delete(Guid entity);
        List<GenderDTO> GetAllGender();
        List<TypeDocumentDTO> GetAllTypeDocument();
    }
}
