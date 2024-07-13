using static ConceptosBasicos.MiembrosFuncionales;

namespace ConceptosBasicos
{
    public class Eventos
    {
        class EventExample
        {
            static int s_changeCount;

            static void ListChanged(object sender, EventArgs e)
            {
                s_changeCount++;
            }

            public static void Usage()
            {
                var names = new MyList<string>();
                names.Changed += new EventHandler(ListChanged);
                names.Add("Liz");
                names.Add("Martha");
                names.Add("Beth");
                Console.WriteLine(s_changeCount); // "3"
            }
        }
    }
}
