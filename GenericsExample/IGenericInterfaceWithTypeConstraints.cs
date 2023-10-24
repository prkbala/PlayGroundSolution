using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample;

internal interface IGenericInterfaceWithTypeConstraints<in TInterface, out TAnother> 
    where TInterface : ISomeInterface 
    where TAnother : IAnotherInterface
{
    void Handle(TInterface inSome);
    TAnother HandleWithReturn(TInterface inSome, string inStr);
}