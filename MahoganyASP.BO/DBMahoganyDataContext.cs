using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace MahoganyASP.BO
{
    public partial class DBMahoganyDataContext
    {
        public DBMahoganyDataContext() :
            base(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString, mappingSource)
        {
            OnCreated();
        }
    }
}
