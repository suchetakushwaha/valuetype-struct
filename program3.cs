using System; 
namespace Value_type
{
    struct Employee // strunct is value type we use it when we don't want to be modified it. it is store in Stack memory 
     {
       public int Salary;
       public int age;

    } 
    class Program 
    {
      static void Main(string[] args)
      {
          Employee e = new Employee();
          e.Salary = 10000;
          e.age = 25;
          Employee e1 = e;
          Employee e2 = e;
          e.age = 27;
          System.Console.WriteLine(e1.age);
          System.Console.WriteLine(e2.age);
      }
    }
}


