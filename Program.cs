namespace Objektorientering
{
    internal class Program
    {
        static void Main()
        {
            var patient1 = new Patient("Bernt", "32", "O", 0);
            var patient2 = new Patient("Kåre", "34", "A", 2);
            Console.WriteLine($"{patient1.Name} har {patient1.HealthyKidneys} friske nyrer, mens {patient2.Name} har {patient2.HealthyKidneys} friske nyrer før operasjon");
            Surgery.performSurgery(patient2, patient1);
            Console.WriteLine($"{patient1.Name} har nå {patient1.HealthyKidneys} frisk nyre, mens {patient2.Name} har {patient2.HealthyKidneys}!");

        }

       

    }



}