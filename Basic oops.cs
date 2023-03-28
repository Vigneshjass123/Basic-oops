using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool debug = false;
            person obj = new person();
            obj.greet();
            student obj1 = new student();
            obj1.set_age(21);
            obj1.greet();
            obj1.showAge();
            teacher obj3 = new teacher();
            obj3.set_age(32);
            obj3.greet();
            obj3.explain();

            if(debug)
                Console.ReadLine();
        }
    }
}
class person
{
    protected int age;
    public void greet()
    {
        Console.WriteLine("Hello");

    }
    public void set_age(int n)
    {
        age = n;
    }

}
class student:person
{
    public void showAge()
    {
        Console.WriteLine(age);
    }

}
class teacher:person
{
    private string subject;
    public void explain()
    {
        Console.WriteLine(" Explain Begins");
    }
    public void set_age(int n)
    {
        Console.WriteLine(n);
    }
     
}
