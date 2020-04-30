using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TeatrUI
{
    class TeatrUIEventHandler
    {
        public static Action<Form> SetMainContent{ get; set; }
        public static Action<Form> SetSideContent{ get; set; }
        public static Action GoBack { get; set; }
        public static Action ClearMainContent { get; set; }

        public static List<Form> SideHistory = new List<Form>();
        public static List<Form> ContentHistory = new List<Form>();

    }
}
