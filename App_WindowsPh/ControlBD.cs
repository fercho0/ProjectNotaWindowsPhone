using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_WindowsPh
{
    public class ControlBD
    {
        SQL todabd = new SQL();
        public ObservableCollection<notas> Retornanotas() {
            return todabd.Visualizanotass();
        }
    }
}
