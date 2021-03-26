using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorMessage
{
    public class Error
    {
        public string Message { get; private set; }

        public event EventHandler<ErrorEventArgs> ErrorOccured;

        public Error(string errorMsg) => Message = errorMsg;

        public void OnErrorOccured(int counter) => 
            ErrorOccured?.Invoke(this, new ErrorEventArgs(counter));
    }
}
