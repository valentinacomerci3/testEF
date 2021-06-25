using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6EFTest.Models;

namespace Week6EFTest.Repositories
{
    public interface IRepositoryClient : IRepository<Client>
    {
        public Client GetByNumero(int numero);
        public bool AddPolicy(int num, Policy policy);
    }
}
