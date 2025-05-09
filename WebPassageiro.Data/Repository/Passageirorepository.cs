using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPassageiro.Data.Context;
using WebPassageiro.Data.Repository.Interface;
using WebPassageiro.Dominio.Dominio;

namespace WebPassageiro.Data.Repository
{
    public class PassageiroRepository : IPassageiroRepository
    {
        private readonly DbContexto _db;

        public PassageiroRepository(DbContexto db)
        {
            _db = db;
        }

        public void AdicionarPassageiro(Passageiro passageiro)
        {
            _db.Add(passageiro);
            _db.SaveChanges();
        }
    }
}
