int period = int.Parse(Console.ReadLine());


int treatedPatient = 0;
int untreatedPatients = 0;
int countOfDoctors = 7;

for (int day = 1; day <= period; day++)
{
    int currentPatient =int.Parse(Console.ReadLine());
    if ((day % 3 == 0) && (untreatedPatients > treatedPatient))
    { 
    countOfDoctors++;
    }
    if (currentPatient > countOfDoctors)
    {
        treatedPatient += countOfDoctors;
        untreatedPatients += currentPatient - countOfDoctors;
    }
    else
    {
        treatedPatient += currentPatient;
    }
}
Console.WriteLine($"Treated patients {treatedPatient}");
Console.WriteLine($"Untreated patients {untreatedPatients}");
