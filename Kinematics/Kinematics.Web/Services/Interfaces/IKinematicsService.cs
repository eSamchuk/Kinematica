﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Kinematics.Web.Services
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IKinematicsService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IKinematicsService
    {
        [OperationContract]
        void DoWork();
    }
}
