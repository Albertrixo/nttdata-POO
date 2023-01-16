using Calculator_Project.Pan_De_Pensiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Project.Plan_De_Pensiones
{
    public class Operaciones
    {
        public static float SoyEspañol(PdP plan)
        {
            var totalDesgravado = 0.0F;
            if (plan.Base >= 0f && plan.Base < 12450f)
            {
                totalDesgravado = (plan.PlandePensionesPersonal + plan.PlandePensionesEmpresa) * 0.19f;
            }
            else if (plan.Base >= 12450f && plan.Base < 20200f)
            {
                totalDesgravado = (plan.PlandePensionesPersonal + plan.PlandePensionesEmpresa) * 0.24f;
            }
            else if (plan.Base >= 20200f && plan.Base < 35200f)
            {
                totalDesgravado = (plan.PlandePensionesPersonal + plan.PlandePensionesEmpresa) * 0.30f;
            }
            else if (plan.Base >= 35200f && plan.Base < 60000f)
            {
                totalDesgravado = (plan.PlandePensionesPersonal + plan.PlandePensionesEmpresa) * 0.37f;
            }
            else if (plan.Base >= 60000f && plan.Base < 300000f)
            {
                totalDesgravado = (plan.PlandePensionesPersonal + plan.PlandePensionesEmpresa) * 0.45f;
            }
            else if (plan.Base >= 300000f)
            {
                totalDesgravado = (plan.PlandePensionesPersonal + plan.PlandePensionesEmpresa) * 0.47f;
            }
            return totalDesgravado;
        }

        public static float SoyAndorrano(PdP plan)
        {
            var totalDesgravado = 0.0f;
            if (plan.Base >= 0f && plan.Base < 24000f)
            {
                totalDesgravado = 0f;
            }
            else if (plan.Base >= 24000f && plan.Base < 40000f)
            {
                totalDesgravado = (plan.PlandePensionesPersonal + plan.PlandePensionesEmpresa) * 0.05f;
            }
            else if (plan.Base >= 40000f)
            {
                totalDesgravado = (plan.PlandePensionesPersonal + plan.PlandePensionesEmpresa) * 0.10f;
            }
            return totalDesgravado;
        }
    }
}
