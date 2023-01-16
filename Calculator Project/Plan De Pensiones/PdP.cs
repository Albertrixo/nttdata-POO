using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Project.Pan_De_Pensiones
{
    public class PdP
    {
        public float Base { get; set; }
        public float PlandePensionesEmpresa { get; set; }
        public float PlandePensionesPersonal { get; set; }
        public string Pais { get; set; }

        //Constructor
        public PdP (float BaseIM, float Empresa, float Personal)
        {
            Base = BaseIM;
            PlandePensionesEmpresa = Empresa;
            PlandePensionesPersonal = Personal;
            
        }

        //constructor vacío.

        public PdP() { }
    }
}
