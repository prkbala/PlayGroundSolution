using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class SomeType : ISomeInterface
    {
        public IAnotherInterface DoSomething(string strValue)
        {
            Console.WriteLine(strValue);
            return new AnotherType();
        }
    }
}
