using System;
using System.Xml.Linq;

class Pupil
{

    protected string Name;
    public Pupil(string name)
    {
        Name = name;
    }
    public virtual void Study()
    {
        Console.WriteLine(Name + " Учиться");
    }

    public virtual void Read()
    {
        Console.WriteLine(Name + " читает");
    }

    public virtual void Write()
    {
        Console.WriteLine(Name + " пишет");
    }

    public virtual void Relax()
    {
        Console.WriteLine(Name + " отдыхает");
    }
}

class ExcelentPupil : Pupil
{
    public ExcelentPupil(string name) : base(name) { }
    public override void Study()
    {
        Console.WriteLine("Excelent pupil " + Name + " много учиться");
    }

    public override void Read()
    {
        Console.WriteLine("Excelent pupil " + Name + " читает много книг");
    }

    public override void Write()
    {
        Console.WriteLine("Excelent pupil " + Name + " пишет много сочинений");
    }

    public override void Relax()
    {
        Console.WriteLine("Excelent pupil " + Name + " не отдыхает");
    }
}

class GoodPupil : Pupil
{
    public GoodPupil(string name) : base(name) { }
    public override void Study()
    {
        Console.WriteLine("Good pupil " + Name + " учиться хорошо");
    }

    public override void Read()
    {
        Console.WriteLine("Good pupil " + Name + " читает иногда");
    }

    public override void Write()
    {
        Console.WriteLine("Good pupil " + Name + " пишет достаточно сочинений");
    }

    public override void Relax()
    {
        Console.WriteLine("Good pupil " + Name + " отдыхает после школы");
    }
}

class BadPupil : Pupil
{
    public BadPupil(string name) : base(name) { }
    public override void Study()
    {
        Console.WriteLine("Bad pupil " + Name + " не достаточно учиться");
    }

    public override void Read()
    {
        Console.WriteLine("Bad pupil " + Name + " не читает книг");
    }

    public override void Write()
    {
        Console.WriteLine("Bad pupil " + Name + " не пишет сочинений");
    }

    public override void Relax()
    {
        Console.WriteLine("Bad pupil " + Name + " много отдыхает");
    }
}

class ClassRoom
{
    private Pupil[] pupils;

    public ClassRoom(params Pupil[] pupils)
    {
        this.pupils = pupils;
    }

    public void Study()
    {
        foreach (Pupil pupil in pupils)
        {
            pupil.Study();
        }
    }

    public void Read()
    {
        foreach (Pupil pupil in pupils)
        {
            pupil.Read();
        }
    }

    public void Write()
    {
        foreach (Pupil pupil in pupils)
        {
            pupil.Write();
        }
    }

    public void Relax()
    {
        foreach (Pupil pupil in pupils)
        {
            pupil.Relax();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        

        Pupil pupil1 = new ExcelentPupil("Маша");
        Pupil pupil2 = new GoodPupil("Богдан");
        Pupil pupil3 = new BadPupil("Арман");
        Pupil pupil4 = new ExcelentPupil("Фёдор");

        ClassRoom classRoom1 = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
        classRoom1.Study();
        classRoom1.Read();
        classRoom1.Write();
        classRoom1.Relax();

        Console.WriteLine("   ");

        

        Pupil pupil5 = new GoodPupil("Вася");
        Pupil pupil6 = new BadPupil("Лёша");

        ClassRoom classRoom2 = new ClassRoom(pupil5, pupil6);
        classRoom2.Study();
        classRoom2.Read();
        classRoom2.Write();
        classRoom2.Relax();

        
    }
}