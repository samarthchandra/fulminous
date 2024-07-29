namespace Ass_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Person, string> personEmails = new Dictionary<Person, string>();

            var person1 = new Person("Chandra", "Gupta");
            var person2 = new Person("Ayushi", "Milan");
            var person3 = new Person("Sankalp", "Sisodiya");

            personEmails[person1] = "chandragupt13@gmail.com";
            personEmails[person2] = "ayushi138@gmail.com";
            personEmails[person3] = "sankalp123@gmail.com";

            Console.WriteLine("Person Emails:");
            foreach (var entry in personEmails)
            {
                Console.WriteLine($"{entry.Key.FirstName} {entry.Key.LastName}: {entry.Value}");
            }

            personEmails[person3] = "sankalpsisodiya1@gmail.com";
            Console.WriteLine("\nUpdated Emails:");
            foreach (var entry in personEmails)
            {
                Console.WriteLine($"{entry.Key.FirstName} {entry.Key.LastName}: {entry.Value}");
            }

            personEmails.Remove(person2);
            Console.WriteLine("\nAfter Removing Ayushi Milan:");
            foreach (var entry in personEmails)
            {
                Console.WriteLine($"{entry.Key.FirstName} {entry.Key.LastName}: {entry.Value}");
            }
        }
    }
}