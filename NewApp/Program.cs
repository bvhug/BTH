﻿﻿using System.Collections;
using NewApp.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList fruitList = new ArrayList();
        int n;
        do
        {
            try
            {
                System.Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                n = 0;
            }
        } while (n < 1);
        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine($"[{i}]");
            Fruit frt = new Fruit();
            frt.EnterData();
            fruitList.Add(frt);
        }

        

        System.Console.WriteLine("----------------------------------");
        foreach(Fruit frt in fruitList)
        {
            frt.DisplayData();
        }


        System.Console.WriteLine("------------------------------------");

        string Fruitname  = null;
        System.Console.WriteLine($"Nhap ten Fruit can sua: {Fruitname}");
        Fruitname = Console.ReadLine();

        for(int i = 0; i < fruitList.Count; i++)
        {   
            Fruit frt = (Fruit) fruitList[i];

            if ( frt.FruitName == Fruitname){

                frt.EnterData();
                break;

            }else
            {
                System.Console.WriteLine("Khong co thong tin!");
                break;
            }

        }

        System.Console.WriteLine("---------------------------");

        foreach(Fruit frt in fruitList)
        {
            frt.DisplayData();
        }

        System.Console.WriteLine("----------------------------");
        System.Console.WriteLine("Nhap ten Fruit can xoa: ");
        Fruitname = Console.ReadLine();
        
        for(int i=0; i < fruitList.Count; i++ )
        {
            Fruit frt = (Fruit) fruitList[i];
            if(frt.FruitName == Fruitname)
            {
                fruitList.RemoveAt(i);
                System.Console.WriteLine($"da xoa Fruit co ten la: {Fruitname}");
                break;
            }
        }
    //BuiVietHuNG-1921050280

        System.Console.WriteLine("----------------------------");


         foreach(Fruit frt in fruitList)
        {
            
            frt.DisplayData();
        }

    }
}