using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorMessage
{
    public class ErrorEventArgs
    {
        public int Counter { get; private set; }

        public ErrorEventArgs(int counter) => Counter = counter;
    }
}
