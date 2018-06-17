using System;

public class Student
{
    public int roll;
    public string grade;
    public string name;

    public void display()
    {
        Console.WriteLine(name);
    }
    public void Add()
    {
        Console.WriteLine(2 + 3);
    }

    public void addparam(int a,int b,string q)
    {
        Console.WriteLine(a + b);
        Console.WriteLine(q);
    }

    public string makemomo(int masu,int pyaz,int pitho)
    {
        return "Momo is ready. it is made using " + masu + " kg of masu" + pyaz + " kg of pyaz" + pitho + " kg of pitho";
    }

    public int getachar()
    {
        return 5;
    }
}
