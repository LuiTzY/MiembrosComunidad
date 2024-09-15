using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiembrosDeLaComunidad
{
    public class Docente : MiembrosDeLaComunidad.Empleado
    {
        public int DocenteID { get { return DocenteID; } set { } }
        public string DocenteName { get { return DocenteName;} set { } }
    }
}
