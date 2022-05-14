public class Program
{
    public static void Main(string[] args ) 
    {
        Console.WriteLine("g");
      
   
        int no = readno();

        for(int i = 1; i <= no; i++)
        {
            for (int k = i; k < no; k++)
            {
                Console.Write(" ");

            }
            for (int j = 1; j < 2 * i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();            
        }

        // for(int i = 0; i < no; i++)
      //  {
      //     for(int j = no; j > i; j--)
          //  {
       //         Console.Write("*");
          //  }
         //  Console.WriteLine("");
      //  }
        
        //for (int i = 0; i <= no; i++)
        //{
        //    for (int j = 0; j < i; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine("");
            
        //}
    }

    public static int readno()
    {
        int no;
        Console.WriteLine("Enter a number");
        try
        {
            no = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {

            Console.WriteLine("plesa");
            no = readno();
        }
        return no;
    }
}