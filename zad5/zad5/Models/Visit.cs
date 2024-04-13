namespace zad5.Models;

public class Visit
{
    public String dataWizyty { get; set; }
    public Animal zwierze { get; set; }
    public String opisWizyty { get; set; }
    public int cena { get; set; }

    public Visit(string dataWizyty, Animal zwierze, string opisWizyty, int cena)
    {
        this.dataWizyty = dataWizyty;
        this.zwierze = zwierze;
        this.opisWizyty = opisWizyty;
        this.cena = cena;
    }
}