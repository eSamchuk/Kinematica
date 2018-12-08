using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Model.Enums
{
    public enum DataTypes : byte
    {
        [Description("Температура")]
        Temperature,
        [Description("Середня температура")]
        TemperatureAvg,
        [Description("Тиск")]
        Pressure,
        [Description("Середній тиск")]
        PressureAvg,
        [Description("Геопотенціал")]
        GeopotentialHeight,
        [Description("Геопотенціал")]
        GeopotentialHeightAvg
    }
}
