using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinematics.Data
{
    public interface IReanalysisReader
    {
        Single[,,,] ReadReanalysis(int value);
    }
}
