using DataAccess.MongoBase;
using Microsoft.Extensions.Configuration;
using Models.Document;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mongo
{
    public class CreditCartRepository : DocumentRepository<CreditCard>, Abstract.ICrediCartRepository
    {
        private const string CollectionName = "CreditCard";

        public CreditCartRepository(MongoClient client, IConfiguration configuration) : base(client, configuration, CollectionName)
        {

        }
    }
}
