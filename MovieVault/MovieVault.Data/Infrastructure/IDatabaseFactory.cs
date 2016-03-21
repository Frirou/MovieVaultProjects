using MovieVault.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieVault.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        cinedbContext DataContext { get; }
    }
}
