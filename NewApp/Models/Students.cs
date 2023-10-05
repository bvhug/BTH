 namespace NewApp.Models
 {
 public class Students  {
        public string Name {get;set;}
        public string Address {get; set;}
        public int StudentID {get; set;}
        public void NhapThongTin()
        {
            System.Console.WriteLine("Ho va Ten");
            Name = Console.ReadLine();
            System.Console.WriteLine("Dia Chi");
            Address = Console.ReadLine();
            System.Console.Write("ID = ");
            try{
                StudentID = Convert.ToInt16(Console.ReadLine());
            } catch(Exception e)
            {
                StudentID =0;
            }
            
        }

        public void HienThi()
         {
             System.Console.WriteLine("{0}-{1}-{2}", Name, Address, StudentID);
         }
 }

 }    
 //1921050280
 //Bui Viet Hung