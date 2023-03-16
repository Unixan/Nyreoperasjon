namespace Objektorientering
{
    internal class Patient
    {
        public string Name { get; private set; }
        public string Age { get; private set; }
        public string BloodType { get; private set; }
        public int HealthyKidneys { get; set; }

        public Patient(string name, string age, string bloodtype, int healthyKidneys)
        {
            Name = name;
            Age = age;
            BloodType = bloodtype;
            HealthyKidneys = healthyKidneys;
        }

        public void ChangeKidney()
        {
            if (HealthyKidneys == 2)
            {
                HealthyKidneys--;
            }
            else if (HealthyKidneys == 0)
            {
                HealthyKidneys++;
            }
            else Console.WriteLine("Kan ikke utføre operasjonen!");
        }

    }
}

