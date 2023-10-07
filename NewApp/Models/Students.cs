namespace NewApp.Models
 {
 public class Students  {
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
 

    public void EnterData()
    {
        System.Console.Write("fullname = ");
        FullName = Console.ReadLine();
        System.Console.Write("Address = ");
        Address = Console.ReadLine();
        System.Console.Write("Age= ");
        //BuiVietHung-1921050280
        try{
            Age = Convert.ToInt16(Console.ReadLine());
        } catch(Exception e)
        {
            Age = 0;
        }

    }

    public void Display()
    {
        System.Console.WriteLine("{0} + {1} + {2}" , FullName, Address, Age);
    }
    }
 }
