using zad5.Models;

namespace zad5.Database;

public class Data
{
    public static List<Animal> Animals = new List<Animal>(
        new Animal(1,"Reksio","Pies",10,"brown"),
        new Animal(2,"Filemot","Kot",5,"white"),
        new Animal(3,"Bonifacy","Kot",5,"black"),
        new Animal(4,"Bogus","Niedzwiedz",100,"brown")
    );
}