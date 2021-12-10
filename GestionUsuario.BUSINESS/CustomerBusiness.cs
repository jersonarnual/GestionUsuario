using GestionUsuario.Business.Interface;
using GestionUsuario.Data.Interface;
using GestionUsuario.DATA.Models;
using GestionUsuario.INFRAESTRUCTURE.DTO;
using System;
using System.Collections.Generic;

namespace GestionUsuario.Business
{
    public class CustomerBusiness : ICustomerBusiness
    {
        #region Members
        private readonly IDefaultRepository<Customer> _repository;
        private readonly IDefaultRepository<Gender> _genderRepository;
        private readonly IDefaultRepository<TypeDocument> _typeDocumentRepository;
        #endregion

        #region Ctor
        public CustomerBusiness(IDefaultRepository<Customer> repository,
                                IDefaultRepository<Gender> genderRepository,
                                IDefaultRepository<TypeDocument> typeDocumentRepository)
        {
            _repository = repository;
            _genderRepository = genderRepository;
            _typeDocumentRepository = typeDocumentRepository;
        }
        #endregion

        #region Methods
        public bool Delete(Guid id)
        {
            var item = _repository.GetById(id);
            if (item != null)
                return _repository.Delete(item);
            return false;
        }

        public List<CustomerDTO> GetAll()
        {
            var lista = new List<CustomerDTO>();
            var items = _repository.GetAll();
            if (items != null)
            {
                foreach (var item in items)
                {
                    lista.Add(ConvertToDTO(item));
                }
            }
            return lista;
        }


        public CustomerDTO GetById(Guid id)
        {
            return ConvertToDTO(_repository.GetById(id));
        }

        public bool Insert(CustomerDTO entity)
        {
            return _repository.Insert(ConvertToModel(entity));
        }

        public bool Update(CustomerDTO entity)
        {
            var itemExists = _repository.GetById(entity.Id);
            if (itemExists != null)
            {
                itemExists.FirstName = entity.FirstName;
                itemExists.LastName = entity.LastName;
                itemExists.Document = entity.Document;
                itemExists.Email = entity.Email;
                itemExists.Age = entity.Age;
                itemExists.State = entity.State;
                itemExists.UpdateTime = entity.UpdateTime;
                itemExists.GenderId = entity.GenderId;
                itemExists.TypeDocumentId = entity.TypeDocumentId;
                return _repository.Update(itemExists);
            }
            return false;
        }

        public List<GenderDTO> GetAllGender()
        {
            var lista = new List<GenderDTO>();
            var items = _genderRepository.GetAll();
            if (items != null)
            {
                foreach (var item in items)
                {
                    lista.Add(ConvertGenderToDTO(item));
                }
            }
            return lista;
        }

        public List<TypeDocumentDTO> GetAllTypeDocument()
        {
            var lista = new List<TypeDocumentDTO>();
            var items = _typeDocumentRepository.GetAll();
            if (items != null)
            {
                foreach (var item in items)
                {
                    lista.Add(ConvertTypeDocumentToDTO(item));
                }
            }
            return lista;
        }
        #endregion

        #region Private methods
        private static Customer ConvertToModel(CustomerDTO model)
        {
            if (model != null)
                return new Customer()
                {
                    UpdateBy = model.UpdateBy,
                    CreateBy = model.CreateBy,
                    UpdateTime = model.UpdateTime,
                    CreateTime = model.CreateTime,
                    Id = model.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Document = model.Document,
                    Email = model.Email,
                    Age = model.Age,
                    State = model.State,
                    GenderId = model.GenderId,
                    TypeDocumentId = model.TypeDocumentId
                };
            return null;
        }

        private static CustomerDTO ConvertToDTO(Customer model)
        {
            if (model != null)
                return new CustomerDTO()
                {
                    UpdateBy = model.UpdateBy,
                    CreateBy = model.CreateBy,
                    UpdateTime = model.UpdateTime,
                    CreateTime = model.CreateTime,
                    Id = model.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Document = model.Document,
                    Email = model.Email,
                    Age = model.Age,
                    State = model.State,
                    GenderId = model.GenderId,
                    TypeDocumentId = model.TypeDocumentId
                };
            return null;
        }

        private static GenderDTO ConvertGenderToDTO(Gender model)
        {
            if (model != null)
                return new GenderDTO()
                {
                    Id = model.Id,
                    Name = model.Name
                };
            return null;
        }

        private static TypeDocumentDTO ConvertTypeDocumentToDTO(TypeDocument model)
        {
            if (model != null)
                return new TypeDocumentDTO()
                {
                    Id = model.Id,
                    Name = model.Name
                };
            return null;
        }
        #endregion
    }
}
