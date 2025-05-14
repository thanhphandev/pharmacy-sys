using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Views.MainForm
{
    public interface IMainView
    {
        event EventHandler LogOut;
        void ShowLoginPage();
    }
}
