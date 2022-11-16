namespace HW_2;

public interface Chair
{
    bool HasLegs();
    void SitOn();
}

public class VictorianChair : Chair
{
    public bool HasLegs() =>
        true;

    public void SitOn() =>
        Console.WriteLine("Sit on victorian chair...");
}
public class ModernChair : Chair
{
    public bool HasLegs() =>
        false;

    public void SitOn() =>
        Console.WriteLine("Sit on modern chair...");
}



public interface CoffeeTable
{
    bool HasLegs();
    void SitOn();
}

public class VictorianCoffeeTable : CoffeeTable
{
    public bool HasLegs() =>
        true;

    public void SitOn() =>
        Console.WriteLine("You can't sit on victorian coffee table...");
}
public class ModernCoffeeTable : CoffeeTable
{
    public bool HasLegs() =>
        true;

    public void SitOn() =>
        Console.WriteLine("You can't sit on modern coffee table...");
}



public interface Sofa
{
    bool HasLegs();
    void SitOn();
}

public class VictorianSofa : Sofa
{
    public bool HasLegs() =>
        true;

    public void SitOn() =>
        Console.WriteLine("Sit on victorian sofa...");
}
public class ModernSofa : Sofa
{
    public bool HasLegs() =>
        false;

    public void SitOn() =>
        Console.WriteLine("Sit on modern sofa...");
}





public interface FurnitureFactory
{
    Chair CreateChair();
    CoffeeTable CreateCoffeeTable();
    Sofa CreateSofa();
}

public class VictorianFurnitureFactory : FurnitureFactory
{
    public Chair CreateChair() =>
        new VictorianChair();

    public CoffeeTable CreateCoffeeTable() =>
        new VictorianCoffeeTable();

    public Sofa CreateSofa() =>
        new VictorianSofa();
}
public class ModernFurnitureFactory : FurnitureFactory
{
    public Chair CreateChair() =>
        new ModernChair();

    public CoffeeTable CreateCoffeeTable() =>
        new ModernCoffeeTable();

    public Sofa CreateSofa() =>
        new ModernSofa();
}