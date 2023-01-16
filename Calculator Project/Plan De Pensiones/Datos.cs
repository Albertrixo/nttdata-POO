using Calculator_Project.Pan_De_Pensiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Project.Plan_De_Pensiones
{
    public class Datos
    {
        public static void DimeTusDatos()
        {
            PdP planAportaciones = new PdP();

            Console.WriteLine("Base imponible? ");
            planAportaciones.Base = float.Parse(Console.ReadLine());
            Console.WriteLine("COmo persona física, cual e tu aportación?");
            planAportaciones.PlandePensionesPersonal = float.Parse(Console.ReadLine());
            Console.WriteLine("Aportación a tu plan de pensiones de empresa?");
            planAportaciones.PlandePensionesEmpresa = float.Parse(Console.ReadLine());
            Console.WriteLine("Invierte usted en España o en Andorra??");
            planAportaciones.Pais = Console.ReadLine();
            ComprobarPais(planAportaciones);
        }

        public static void ComprobarPais(PdP planAportaciones)
        {
            while (!planAportaciones.Pais.Equals("España") && !planAportaciones.Pais.Equals("Andorra"))
            {
                Console.WriteLine("El país introducido no es valido, introduzca un país valido");
                Console.WriteLine("¿Usted invierte el dinero de los planes de pensiones en España o en Andorra?");
                planAportaciones.Pais = Console.ReadLine();
            }
            if (planAportaciones.Pais.Equals("España"))
            {
                Console.WriteLine("Te has desgravado " + Operaciones.SoyEspañol(planAportaciones) + "€ al invertir en los planes de pensiones en España.");
            }
            else
            {
                Console.WriteLine("Te has desgravado " + Operaciones.SoyAndorrano(planAportaciones) + "€ al invertir en los planes de pensiones en Andorra.");
            }
        }
    }
}
