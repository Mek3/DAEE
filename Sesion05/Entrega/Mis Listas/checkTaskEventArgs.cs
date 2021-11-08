using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mis_Listas
{
    public class checkTaskEventArgs
    {
        public int list { get; set; }
        public int task { get; set; }
        public checkTaskEventArgs(int l, int t) : base()
        {
            list = l;
            task = t;
        }
    }
}
