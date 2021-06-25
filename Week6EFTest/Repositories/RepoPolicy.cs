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
    public class RepoPolicy:IRepository<Policy>
    {
        public Policy Create(Policy item)
        {
            using (var ctx = new InsuranceContext())
            {
                if (item != null)
                {
                    try
                    {
                        ctx.Entry<Policy>(item).State = EntityState.Added;
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

        public ICollection<Policy> GetAll()
        {
            using (var ctx = new InsuranceContext())
            {
                return ctx.Policies.ToList();
            }
        }


    }
}
