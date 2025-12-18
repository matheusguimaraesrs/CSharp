using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocial_Enum.Entities
{
    internal class Comentarios
    {
        public string Txt { get; set; }

        public Comentarios() { }

        public Comentarios(string txt)
        {
            Txt = txt;
        }
    }
}
