internal class Program
{
    private static void Main(string[] args)
    {
        Pupil pupil = new Pupil();
        ExcelentPupil excelentPupil = new ExcelentPupil();
        GoodPupil goodPupil = new GoodPupil();
        BadPupil badPupil = new BadPupil();
        ClassRoom classRoom = new ClassRoom(pupil, excelentPupil, goodPupil, badPupil);
        classRoom.Display();
    }
}
class ClassRoom
{
    private Pupil p1;
    private Pupil p2;
    private Pupil p3;
    private Pupil p4;

    public ClassRoom(Pupil p1, Pupil p2)
    {
        this.p1 = p1;
        this.p2 = p2;
    }

    public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
    {
        this.p1 = p1;
        this.p2 = p2;
        this.p3 = p3;
    }
    public ClassRoom(Pupil p1, Pupil p2, Pupil p3,Pupil p4)
    {
        this.p1 = p1;
        this.p2 = p2;
        this.p3 = p3;
        this.p4 = p4;
    }

    public void Display()
    {
        Console.WriteLine("\nStudent 1:");
        p1.Study();
        p1.Read();
        p1.Write();
        p1.Relax();

        Console.WriteLine("\nStudent 2:");
        p2.Study();
        p2.Read();
        p2.Write();
        p2.Relax();
        
        Console.WriteLine("\nStudent 3:");
        p3.Study();
        p3.Read();
        p3.Write();
        p3.Relax();

        Console.WriteLine("\nStudent 4:");
        p4.Study();
        p4.Read();
        p4.Write();
        p4.Relax();
    }
}
class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Studying...");
    }
    public virtual void Read()
    {
        Console.WriteLine("Reading...");
    }
    public virtual void Write()
    {
        Console.WriteLine("Writing...");
    }
    public virtual void Relax()
    {
        Console.WriteLine("Relaxing...");
    }
}

class ExcelentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Excellent studying");
    }
    public override void Read()
    {
        Console.WriteLine("Excellent reading");
    }
    public override void Write()
    {
        Console.WriteLine("Excellent writing");
    }
    public override void Relax()
    {
        Console.WriteLine("Excellent relaxing");
    }
}
class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Good studying");
    }
    public override void Read()
    {
        Console.WriteLine("Good reading");
    }
    public override void Write()
    {
        Console.WriteLine("Good writing");
    }
    public override void Relax()
    {
        Console.WriteLine("Good relaxing");
    }
}
class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Bad studying");
    }
    public override void Read()
    {
        Console.WriteLine("Bad reading");
    }
    public override void Write()
    {
        Console.WriteLine("Bad writing");
    }
    public override void Relax()
    {
        Console.WriteLine("Bad relaxing");
    }
}