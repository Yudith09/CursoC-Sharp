using System.Runtime.Versioning;

namespace ConceptosBasicos;

public class MiembrosExpresion
{
    public string fname { get; set; }
    public string lname { get; set; }

    public MiembrosExpresion(string fname, string lname)
    {
        this.fname = fname;
        this.lname = lname;
    }

    public MiembrosExpresion() { }

    public override string ToString() => $"{fname} {lname}".Trim();
    public void DisplayName() => Console.WriteLine(ToString());

    List<string> list = new List<string> { "ff", "ff", "ttt" };

    List<MiembrosExpresion> miembros = new List<MiembrosExpresion>
    {
        new MiembrosExpresion{fname= "fname", lname="lname"},

    };
}
