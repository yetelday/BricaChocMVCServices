using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BricachocDal.Configuration;

namespace CreationBase
{
    class Program
    {
        static void Main(string[] args)
        {

            Database.SetInitializer(new BricachocInitializer());
            using (var context = new BricachocContext())
            {
                context.Database.Initialize(false);
            }
        }
    }
}
