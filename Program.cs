


using Constructor;
public class Program
{
    public static void Main()
    {
 

        Employee emp1 = new Employee();     //Call To Parameterless Consturctor
        emp1.PutData();

        Employee emp2 = new Employee(11,"Vijay",11000);     //Call To Parameterized Consturctor
        emp2.PutData();

        Employee emp3 = new Employee(12,"Amit",12000);
        emp3.PutData();

        Employee emp2Copy = new Employee(emp2);      //Call To Copy Consturctor
        emp2Copy.PutData();

    }
}