using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample;

internal interface IGenericInterface
{
    void Handle<TSome>();
    void Handle<TSome>(TSome s) where TSome : ISomeInterface;
    TAnother HandleWithReturn<TAnother, TSome>(TSome s) 
        where TSome : ISomeInterface 
        where TAnother : IAnotherInterface;
}