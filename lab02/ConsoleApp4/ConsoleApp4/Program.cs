using System;

class Classroom
{
    Pupil[] pupils;

    public Classroom(params Pupil[] pupils)
    {
        this.pupils = pupils;
    }

    public void info()
    {
        foreach (Pupil p in pupils)
        {
            p.informat();
        }
    }
}

class Pupil
{
    public void informat()
    {
        Study();
        Read();
        Write();
        Relax();
    }
    public virtual void Study()
    {

    }
    public virtual void Read()
    {

    }
    public virtual void Write()
    {

    }
    public virtual void Relax()
    {

    }
}

class ExcellentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Cool student");
    }
    public override void Read()
    {
        Console.WriteLine("I like reading");
    }
    public override void Write()
    {
        Console.WriteLine("I can write pretty well");
    }
    public override void Relax()
    {
        Console.WriteLine("Chill and relax");
    }
}

class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Cool student");
    }
    public override void Read()
    {
        Console.WriteLine("I like reading, but not all of them");
    }
    public override void Write()
    {
        Console.WriteLine("I can't write very well");
    }
    public override void Relax()
    {
        Console.WriteLine("Just chilling");
    }
}

class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Bad student");
    }
    public override void Read()
    {
        Console.WriteLine("I don't like to read");
    }
    public override void Write()
    {
        Console.WriteLine("I can't write");
    }
    public override void Relax()
    {
        Console.WriteLine("Just work");
    }
}


class vehicle
{
    private string koord;
    private long price;
    private int speed;
    private int godvipuska;

    public vehicle(string aa, long a, int b, int rr)
    {
        this.koord = aa;
        price = a;
        speed = b;
        godvipuska = rr;
    }

    public virtual void napechat()
    {
        Console.WriteLine($"Coordinates {koord}");
        Console.WriteLine($"Price {price}");
        Console.WriteLine($"Speed and year of release {speed} {godvipuska}");
    }
}

class Car : vehicle
{
    private string marka;
    public Car(string aa, long a, int b, int rr, string bb):base(aa, a, b, rr)
    {
        this.marka = aa;
    }

    public override void napechat()
    {
        base.napechat();
        Console.WriteLine($"Marka {marka}");
    }
}

class Plane : vehicle
{
    private int visota;
    private int kolvopas;
    public Plane(string aa, long a, int b, int rr, int bb, int kolvopse) : base(aa, a, b, rr)
    {
        visota = bb;
        kolvopas = kolvopse;
    }

    public override void napechat()
    {
        base.napechat();
        Console.WriteLine($"High {visota} number of passengers {kolvopas}");
    }
}

class Ship : vehicle
{
    private int kolvopasee;
    private string PortPrip;
    public Ship(string aa, long a, int b, int rr, int kolvposi, string pppprrrr) : base(aa, a, b, rr)
    {
        kolvopasee = kolvposi;
        PortPrip = pppprrrr;
    }

    public override void napechat()
    {
        base.napechat();
        Console.WriteLine($"Number of passengers {kolvopasee} home port {PortPrip}");
    }
}

class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Редактирование документа доступно в версии Pro");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Pro");
    }
}

class ProDocumentWorker : DocumentWorker
{
    public override void OpenDocument()
    {
        base.OpenDocument();
    }

    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }
public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранён в старом формате, сохранение в остальных форматах доступно в версии Expert");
    }
}

class ExpertDocumentWorker : DocumentWorker
{
    public override void OpenDocument()
    {
        base.OpenDocument();
    }

    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранён в новом формате");
    }
}

class Program
{
    public static void Main()
    {
        ExcellentPupil pupl = new ExcellentPupil();
        ExcellentPupil pupl22 = new ExcellentPupil();
        GoodPupil pupl28 = new GoodPupil();
        ExcellentPupil pupl38 = new ExcellentPupil();
        Pupil[] puplsaer = new Pupil[] { pupl, pupl22, pupl28, pupl38 };
        Classroom classerio = new Classroom(pupl, pupl22, pupl28, pupl38);
        classerio.info();

        Car aaaa = new Car("Car", 100000000, 202, 1998, "Red");
        aaaa.napechat();
        Plane eeee = new Plane("Plane", 10000000000, 2020, 1998, 4000, 212);
        eeee.napechat();
        Ship rrrr = new Ship("Ship", 10000000000, 2020, 1998, 212, "Blue");
        rrrr.napechat();

















        Console.WriteLine("Enter the access key:");
        string aeae;
        aeae = Console.ReadLine();
        DocumentWorker erer = new();
        if(aeae == "1111")
        {
            erer = new ProDocumentWorker();
        }
        else if(aeae == "0000")
        {
            erer = new ExpertDocumentWorker();

        }
        else
        {
            erer = new DocumentWorker();
        }
        erer.OpenDocument();
        erer.EditDocument();
        erer.SaveDocument();
    }
}