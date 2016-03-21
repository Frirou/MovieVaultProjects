using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieVault.Data.Models;

namespace MovieVault.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private cinedbContext dataContext;
        public cinedbContext DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new cinedbContext();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }
}
