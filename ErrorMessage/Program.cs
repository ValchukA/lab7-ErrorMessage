using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorMessage
{
    class Program
    {
        static void Main()
        {
            Error error = new Error("AAAAA!!!");

            error.ErrorOccured += (sender, e) =>
            {
                if (e.Counter > 0)
                {
                    MessageBox.Show(((Error)sender).Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    error.OnErrorOccured(e.Counter - 1);
                }
            };

            error.OnErrorOccured(5);
        }
    }
}
