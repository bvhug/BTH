namespace NewApp.Models
 {
 public class Fruit {
        public string FruitName {get;set;}
        public int weight {get; set;}
       public void EnterData()
       {
        System.Console.Write("Fruit name = ");
        FruitName = Console.ReadLine();
        System.Console.Write("weight = ");
        try{
            weight = Convert.ToInt16(Console.ReadLine());
        } catch(Exception e)
        {
            weight = 0;
        }

    }
    public void Display()
    {namespace NewApp.Models
 {
 public class Fruit {
        public string FruitName {get;set;}
        public string Information {get; set;}
       

       
        public int ThanhTien ( int CanNang)
        {
            int TTien = CanNang *2;
            return TTien;
        }
 }
 }
        System.Console.WriteLine("{0} + {1} " , FruitName, weight);
    }
}
 }
