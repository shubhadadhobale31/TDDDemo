using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDDemo
{
    public interface ICalc
    {
        int Add(int a, int b);
        int Sub(int a, int b);
    }
    public class Calc : ICalc
    {
        public int Add(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                throw new InvalidOperationException();
            }
            return a - b;
        }

        public int Sub(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
