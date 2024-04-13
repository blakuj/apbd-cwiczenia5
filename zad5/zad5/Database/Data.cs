using zad5.Models;

namespace zad5.Database;

public class Data
{
    public static List<Animal> AnimalsDB = new List<Animal>
    {
        new Animal(1, "Reksio", "Pies", 10, "brown"),
        new Animal(2, "Filemot", "Kot", 5, "white"),
        new Animal(3, "Bonifacy", "Kot", 5, "black"),
        new Animal(4, "Bogus", "Niedzwiedz", 100, "brown")
    };
    
    public static List<Visit> VisitsDB = new List<Visit>
    {
      new Visit("2011",AnimalsDB[0],"Wymiana Opon",100),
      new Visit("2002",AnimalsDB[1],"Wymiana Oleju",299),
      new Visit("2003",AnimalsDB[1],"Wymiana Zawieszenia",1299),
      new Visit("2005",AnimalsDB[3],"Lakierowanie Drzwi",500)
    };
}