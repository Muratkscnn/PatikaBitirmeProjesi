﻿using Business.Abstract;
using DataAccess.Abstract;
using Models.Document;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CreditCardManager : ICreditCardService
    {
        private readonly ICrediCartRepository _repository;

        public CreditCardManager(ICrediCartRepository repository)
        {
            _repository = repository;
        }

        public void Add(CreditCard model)
        {
            _repository.Add(model);
        }

        public void Update(CreditCard model)
        {
            _repository.Update(model);
        }

        public void Delete(ObjectId id)
        {
            _repository.Delete(id);
        }

        public CreditCard Get(ObjectId id)
        {
            return _repository.Get(x => x.Id == id);
        }

        public IEnumerable<CreditCard> GetAll()
        {
            return _repository.GetAll();
        }

        public void TestExceptionFilter()
        {
            throw new Exception("Test");
        }
    }
}
