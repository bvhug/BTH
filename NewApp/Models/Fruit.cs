namespace NewApp.Models
 {
 public class Fruit {
        public string FruitName {get;set;}
        public int weight {get; set;}
       

        
       public void EnterData()
       {
        System.Console.Write("Fruitname = ");
        FruitName = Console.ReadLine();
        System.Console.Write("weight = ");    
        //BuiVietHung-1921050280
        try{
            weight = Convert.ToInt16(Console.ReadLine());
        } catch(Exception e)
        {
            weight = 0;
        }

    }
    public void DisplayData()
    {
        System.Console.WriteLine("{0} + {1} " , FruitName, weight);
    }
}
 }