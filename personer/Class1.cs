namespace OOP003
{
    internal class StartUp
    {
        public List<Person> People = new();
        public StartUp()
        {
            while (true)
            {
                
                Person p = CreatePerson();
                
                People.Add(p);
               
                foreach (Person person in People)
                {
                    Console.WriteLine($"Name: {person.Name}");
                }
            }
        }

        private Person CreatePerson()
        {
           
            Person person = new();
            GetName(person);
            Console.WriteLine("Hi " + person.Name);
            GetDoB(person);
            Console.WriteLine($"Du er født: {person.DoB} og er {person.Age} år gammel.");
            GetEmail(person);
            Console.WriteLine("Din email er: " + person.Email);
            GetPassword(person);
            Console.WriteLine("Dit password er: " + person.Password);
            return person;
        }

        private void GetName(Person person)
        {
            do
            {
                Console.Write("Indtast navn: ");
                person.Name = Console.ReadLine();
            }
            while (person.Name == null);
        }
        private void GetDoB(Person person)
        {
            do
            {
                Console.Write("Indtast fødselsdato (dd/mm/åååå: ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime dt)) person.DoB = dt;
                else person.DoB = null;
            }
            while (person.DoB == null);
        }
        private void GetEmail(Person person)
        {
            do
            {
                Console.Write("Indtast email: ");
                person.Email = Console.ReadLine();
            }
            while (person.Email == null);
        }
        private void GetPassword(Person person)
        {
            do
            {
                Console.Write("Indtast password: ");
                person.Password = Console.ReadLine();
            }
            while (person.Password == null);
        }
    }
}