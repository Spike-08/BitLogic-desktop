using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace BitLogic_App_Escritorio
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Correo { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public int Visitas { get; set; }
        public DateTime? UltimaVisita { get; set; }

        public string Categoria
        {
            get
            {
                if (Visitas < 10)
                {
                    return "Novel";
                }
                else if (Visitas < 20)
                {
                    return "Intermedio";
                }
                else
                {
                    return "Experto";
                }
            }
        }
 
      
    }
    }

