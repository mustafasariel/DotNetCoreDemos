using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreDemos.Services
{
    public class KDV18 : ICalculate
    {
        public string Calculate(decimal price)
        {
            decimal d = price + price * 18/100;
            return d.ToString();
        }
    }
}
