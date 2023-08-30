using Lægeklinik.Codes;
using Lægeklinik.Interface;

namespace Lægeklinik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tilføjer Læger til listen
            Læge øjenlæge = new Læge("Peter","Hansen", 11111111, "Øjenlæge");
            Læge radiologi = new Læge("Martin", "Jensen", 22222222, "Radiologi");
            Læge kirurgi = new Læge("Thomas", "Olsen",33333333, "Kirurgi");
            Læge onkologi = new Læge("Ole", "Nielsen", 44444444, "Onkologi");

            Læge tandlæge = new Læge("Peter", "Parker", 55555555, "TandLæge");

            // Patienter
            //Patient 1
            Console.Write("Patient Fornavn: ");
            string? fornavn = Console.ReadLine();

            Console.Write("Patient Efternavn: ");
            string? efternavn = Console.ReadLine();

            Console.Write("Patien Tlf.nr.: ");
            int tlfnr = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nLæger: øjenlæge, radiologi, kirurgi, onkologi, tandlæge");

            Console.Write("Tildelt læge: ");
            string? tildeltlæge = Console.ReadLine();

            Læge valgtLæge;

            switch (tildeltlæge.ToLower())
            {
                case "øjenlæge":
                    valgtLæge = øjenlæge;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nPatient Registreret!\n");
                    Console.ResetColor();
                    break;
                case "radiologi":
                    valgtLæge = radiologi;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nPatient Registreret!\n");
                    Console.ResetColor();
                    break;
                case "kirurgi":
                    valgtLæge = kirurgi;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nPatient Registreret!\n");
                    Console.ResetColor();
                    break;
                case "onkologi":
                    valgtLæge = onkologi;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nPatient Registreret!\n");
                    Console.ResetColor();
                    break;
                case "tandlæge":
                    valgtLæge = tandlæge;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nPatient Registreret!\n");
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine("Ugyldigt lægenavn.");
                    return;
            }

            Patient patient = new Patient(fornavn, efternavn, tlfnr);
            patient.TildelLæge(øjenlæge);
            patient.TildelLæge(radiologi);
            patient.TildelLæge(valgtLæge);


            // DISPLAY
            Console.WriteLine($"Patient Fornavn: {patient.ForNavn} \nPatient Efternavn: {patient.EfterNavn} \nTlf: {patient.TlfNr}\n");
            
            Console.WriteLine("Patients tildelte læger:");
            foreach (Læge læge in patient.TildelteLæger)
            {
                Console.WriteLine($"{læge.ForNavn} {læge.EfterNavn}  - {læge.TlfNr} - {læge.Specialitet}");
            }
        }
    }
}