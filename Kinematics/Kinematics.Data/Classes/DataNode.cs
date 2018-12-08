using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace Model.Classes
{
    [AddINotifyPropertyChangedInterface]
    public class DataNode
    {
        public int X { get; set; }

        public int Y { get; set; }

        public double Fi { get; set; }

        public double Lambda { get; set; }
    }
}
