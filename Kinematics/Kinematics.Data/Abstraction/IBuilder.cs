using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinematics.Data.Abstraction
{
    public interface IBuilder
    {
        void Build();
        void Save();
    }
}
