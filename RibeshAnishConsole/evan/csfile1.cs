
using System;


class encap
{
    private string name;
    private int age;

    public void setage(int age)
    {
        if(age<1||age>150)
        {
            Console.WriteLine("invalid age");
        }
        else
        {
            this.age = age;
        }
    }

    public void setname(string name)
    {
        if(name=="")
        {
            Console.WriteLine("invalid name");
        }

        else
        {
            this.name = name;
        }
    }

    public void getname()
    {
           
    }
} 