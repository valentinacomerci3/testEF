using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6EFTest.Context;
using Week6EFTest.Models;

namespace Week6EFTest.Repositories
{
    public class RepoClient : IRepositoryClient
    {
        public bool AddPolicy(int num, Policy policy)
        {
            bool esito = false;
            using (var ctx = new InsuranceContext())
            {
                try
                {
                    var client = ctx.Clients.Include(p => p.Policies)
                        .FirstOrDefault(n => n.CF == num);
                    client.Policies.Add(policy);
                    policy.Client = client;
                    ctx.SaveChanges();
                    esito = true;
                }
                catch (Exception ec)
                {
                    return esito;
                }
            }
            return esito;
        }

        public Client Create(Client item)
        {
            using (var ctx = new InsuranceContext())
            {
                if (item != null)
                {
                    try
                    {
                        ctx.Entry<Client>(item).State = EntityState.Added;
                       
                        ctx.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }

                }
            }
            return item;
        }

        public ICollection<Client> GetAll()
        {
            using (var ctx = new InsuranceContext())
            {
                return ctx.Clients.ToList();
            }
        }

        public Client GetByNumero(int numero)
        {
            using (var ctx = new InsuranceContext())
            {
                if (numero < 0)
                {
                    return null;
                }
                return ctx.Clients.Include(p => p.Policies)
                                  .FirstOrDefault(n => n.CF == numero);
            }
        }
    }
}
