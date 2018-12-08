using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Model.Enums
{
    public enum DataLevels : byte
    {
        [Description("Земля")]
        Ground,
        [Description("АТ850")]
        H850,
        [Description("АТ700")]
        H700,
        [Description("АТ500")]
        H500,
        [Description("АТ400")]
        H400,
        [Description("АТ200")]
        H200
    }

    public struct DataLevel
    {
        public string LavelName { get; set; }
        public string LavelIndex { get; set; }
    }

}
