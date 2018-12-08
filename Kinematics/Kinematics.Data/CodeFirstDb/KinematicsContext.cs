using Kinematics.Data.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinematics.Data.CodeFirstDb
{
    public class KinematicsContext : DbContext
    {
        public KinematicsContext()
        {

        }


        public DbSet<Center> Centers { get; set; }


    }
}
