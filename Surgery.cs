using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektorientering
{
    internal class Surgery
    {
        public static void performSurgery(Patient healthy, Patient sick)
        {
            if (healthy.HealthyKidneys != 2)
            {
                Console.WriteLine("Operasjonen kan ikke gjennomføres!");
            }

            else if (sick.HealthyKidneys > 0)
            {
                Console.WriteLine("Operasjonen er ikke nødvendig!");
            }
            else
            {
                healthy.ChangeKidney();
                sick.ChangeKidney();
            }
        }
    }
}
