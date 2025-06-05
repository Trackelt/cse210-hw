
class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bob", "Lemhi", 34);
        Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceMan = new PoliceMan("Officer", "Jenny", 22, "Taser");
        //Console.WriteLine(myPoliceMan.GetPersonInformation());
        Console.WriteLine(myPoliceMan.GetPoliceManInformation());

        Doctor myDoctor = new Doctor("Nurse", "Joy", 24, "Scalpel");
        Console.WriteLine(myDoctor.GetDoctorInformation());
        
    }
}