namespace Newapp.Models
{
    public class Employee
    {
        public string EmpID { get; set; }
        public string EmpName { get; set; }
        public int Age { get; set; }
        public string Luong { get; set; }
        public void Nhapthongtin()
        {
            System.Console.Write("EmpID = ");
            EmpID = Console.ReadLine();
            System.Console.Write("EmpName = ");
            EmpName = Console.ReadLine();
            System.Console.Write("Age = ");
            Age = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("Luong = ");
            Luong = Console.ReadLine();
        }
        public void Hienthi()
        {
            System.Console.WriteLine("{0} - {1} - {2}tuoi - {3}VND",EmpID, EmpName, Age, Luong);
        }
    }
}