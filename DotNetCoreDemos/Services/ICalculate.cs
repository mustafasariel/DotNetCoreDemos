using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreDemos.Services
{
    public interface ICalculate
    {
         string Calculate(decimal price);
    }
}
