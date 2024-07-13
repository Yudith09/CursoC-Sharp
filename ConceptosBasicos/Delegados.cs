namespace ConceptosBasicos
{
    public class Delegados
    {
        private static int CompareLength(string left, string right) 
            =>
      left.Length.CompareTo(right.Length);

        public delegate void Action();
        public delegate void Action<in T>(T argument);
        public delegate void Action<in T1, in T2>(T1 argument1, T2 argument2);

        public delegate TResult Func<out TResult>();
        public delegate TResult Func<in T1, out TResult>(T1 arg);
        public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);

        public delegate bool Predicate<in T>(T argument);

        public class CustomGenericAttribute<T> : Attribute { }

        public class Person { }
        public class Employee : Person { }

        class Program
        {
            static Employee FindByTitle(String title)
            {               
                return new Employee();
            }

            static void Test()
            {
                Func<String, Employee> findEmployee = FindByTitle;               
                Func<String, Person> findPerson = FindByTitle;              
                findPerson = findEmployee;

            }

            static void AddToContacts(Person person)
            {
                // This method adds a Person object  
                // to a contact list.  
            }

            static void Testa()
            {
                Action<Person> addPersonToContacts = AddToContacts;               
                Action<Employee> addEmployeeToContacts = AddToContacts;                
                addEmployeeToContacts = addPersonToContacts;
            }

            IEnumerable<String> strings = new List<String>();
        }

        Action<string,string> action = (string title, string text) => Console.WriteLine(title+text);
    }
}
