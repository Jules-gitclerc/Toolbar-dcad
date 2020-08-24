using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DcadToolBar
{
    public class LaunchMacroEventArgs : EventArgs
    {
        public CabinModel? Model { get; set; }

        public MaterialType? Type { get; set; }

        public LaunchMacroEventArgs(CabinModel? model, MaterialType? material)
        {
            Model = model;
            Type = material;
        }
    }
}
