using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entCategory
    {
        public int Id_Cat { get; set; }
        public String Codigo_Cat { get; set; }
        public String Nombre_Cat { get; set; }
        public String Descripcion_Cat { get; set; }
        public int UsuarioCreacion_Cat { get; set; }
        public int UsuarioUpdate_Cat { get; set; }
        public int Estado_Catategoria { get; set; }
     }
}
