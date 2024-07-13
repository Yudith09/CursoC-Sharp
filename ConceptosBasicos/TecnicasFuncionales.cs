using System.Text;

namespace ConceptosBasicos
{
    public class TecnicasFuncionales
    {
        public string PerformOperation(string command) =>
        command switch
        {
            "SystemTest" => "RunDiagnostics",
            "Start" => "StartSystem",
            "Stop" => "StopSystem",
            "Reset" => "ResetToReady",
            _ => throw new ArgumentException("Invalid string value for command", nameof(command)),
        };

        //Descarte 

        public class Person
        {
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }
            public string State { get; set; }

            public Person(string fname, string mname, string lname,
                          string cityName, string stateName)
            {
                FirstName = fname;
                MiddleName = mname;
                LastName = lname;
                City = cityName;
                State = stateName;
            }

            public void Deconstruct(out string fname, out string lname,
                           out string city, out string state)
            {
                fname = FirstName;
                lname = LastName;
                city = City;
                state = State;
            }

            class Example
            {
                public static void Main()
                {
                    var p = new Person("John", "Quincy", "Adams", "Boston", "MA");

                    // Deconstruct the person object.
                    // var (fName, _, city, _) = p;
                    // Console.WriteLine($"Hello {fName} of {city}!");
                    // The example displays the following output:
                    //      Hello John of Boston!
                }
            }

            //Desconstruir Tuplas 

            private static (string, int, double) QueryCityData(string name)
            {
                if (name == "New York City")
                    return (name, 8175133, 468.48);

                return ("", 0, 0);
            }
            public static void Main()
            {
                (string city, int population, double area) = QueryCityData("New York City");

                var (citys, populations, areas) = QueryCityData("New York City");

                var phrase = "lalalalalalalalalalalalalalalalalalalalalalalalalalalalalala";
                var manyPhrases = new StringBuilder();
                for (var i = 0; i < 10000; i++)
                {
                    manyPhrases.Append(phrase);
                }
            }
           
        }
    }
}
