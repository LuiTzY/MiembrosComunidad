using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiembrosDeLaComunidad
{
    public class Empleado : MiembrosComunidad.MiembroComunidad
    {
        public int empleadoID { get { return empleadoID; } set { } }
        public string empleadoName { get { return empleadoName; } set { } }
    }
}
