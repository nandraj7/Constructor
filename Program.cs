


using Constructor;
public class Program
{
    public static void Main()
    {
        Doctor doctor1 = new Doctor();
        doctor1.ShowData();
        Doctor doctor2 = new Doctor(21,"Neel","BAMS");
        doctor2.ShowData();
        Doctor doctor3 = new Doctor(22,"Nitin","MD");
        doctor3.ShowData();
        Doctor doctor4 = new Doctor(23,"Mukesh","BDS");
        doctor4.ShowData();
        Doctor doctor5 = new Doctor(30,"Mahesh","MBBS");
        doctor5.ShowData();

        Doctor newdoctor = new Doctor(doctor5);
        newdoctor.ShowData();

        //Employee emp1 = new Employee();     //Call To Parameterless Consturctor
        //emp1.PutData();

        //Employee emp2 = new Employee(11,"Vijay",11000);     //Call To Parameterized Consturctor
        //emp2.PutData();

        //Employee emp3 = new Employee(12,"Amit",12000);
        //emp3.PutData();

        //Employee emp2Copy = new Employee(emp2);      //Call To Copy Consturctor
        //emp2Copy.PutData();




    }
}