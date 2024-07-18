using System;

abstract class Apparatus
{
    protected string _apparatusName;
    protected int _crew;
    protected string _assignment;

    public Apparatus(string name, int crewSize)
    {
        _name = name;
        _crew = crewSize;
    }
    public virtual void SetAssignment()
    {
    }
}

public class Engine : Apparatus
{
    private string _officer;
    private string _engineer;
    private string _firefighter1;
    private string _firefighter2;
    private string _firefighter3;
    private string _firefighter4;

    public Engine(string name, int crewSize string officer, string engineer, 
    string firefighter1 = null, string firefighter2 = null, string firefighter3 = null, 
    string firefighter4 = null) : base()
    {
        _officer = officer;
        _engineer = _engineer;
        _firefighter1 = firefighter1;
        _firefighter2 = firefighter2;
        _firefighter3 = firefighter3;
        _firefighter4 = firefighter4;
    }
    public override void SetAssignment()
    {
        Console.WriteLine("Possible assignments are as follows: ");
        Console.WriteLine("1. Suppression ");
        Console.WriteLine("2. Rescue ");
        Console.WriteLine("3. RIT ");
        Console.WriteLine("4. Staging ");
        Console.WriteLine("5. Nurse Engine ");
        Console.WriteLine("6. Other ");
        Console.Write("What was the assignment of this apparatus? ");
        int assigned = int.Parse(Console.ReadLine());
        if (assigned == 1)
        {
            _assignment = "Suppression";
        }
        // etc
    }
}
public class WaterTender : Apparatus
{
    private string _engineer;
    private string _secondRider;
    public WaterTender(string name, int crewSize, string engineer, string secondRider = null) : base()
    {
        _engineer = _engineer;
        _secondRider = secondRider;
    }
    public override void SetAssignment()
    {
        Console.WriteLine("Possible assignments are as follows: ");
        Console.WriteLine("1. Suppression ");
        Console.WriteLine("2. Water shuttle ");
        Console.WriteLine("3. Nurse tender ");
        Console.WriteLine("4. Staging ");
        Console.WriteLine("5. Other ");
        Console.Write("What was the assignment of this apparatus? ");
        int assigned = int.Parse(Console.ReadLine());
        if (assigned == 1)
        {
            _assignment = "Suppression";
        }
        // etc
    }
}