using System;
using System.Collections.Generic;
using System.Text;

namespace SomaticStore.Core.Interfaces
{
    interface IStore<T> : IEquatable<IStore<T>>
    {
        string Key { get; }
        T Value { get; set; }

        DateTime Created { get; }
        DateTime Updated { get; set; }
        DateTime Accessed { get; set; }
    }
}
