public class Program
{
    public static void Main(string[] args ) 
    {
        Console.WriteLine("enter the type of pattern you want\n1.Left handed right angle triangle\n2.Right handed right angle triangle\n3.Isosless triangle");


        int type = patterntype();
        int number = readno();

        string ptrn = "*";



         ptrn = patternletter();

        if(type==1)
        {
            leftHanded(ptrn, number);
           
        }
        else if(type==2)
        {
          
            rightHanded(ptrn, number);
        }
        else
        {
            isoseless(ptrn, number);

        }
       

        // for(int i = 0; i < no; i++)
      //  {
      //     for(int j = no; j > i; j--)
          //  {
       //         Console.Write("*");
          //  }
         //  Console.WriteLine("");
      //  }
        
        
    }
   
    public static void rightHanded(string ptrn,int number)
    {

        for (int i = 0; i <= number; i++)
        {
            for (int j = number; j >i; j--)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < i; j++)
            {
                if (ptrn == "42")
                {
                    Console.Write("*");
                 
                }
                else
                {
                    Console.Write(i);
                }


            }
            Console.WriteLine();


        }
    }
    public static void leftHanded(string ptrn, int number)
    {
        for (int i = 0; i <= number; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (ptrn == "*")
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(i);
                }
            }
            Console.WriteLine("");

        }
    }
    public static void isoseless(string ptrn, int number)
    {
        for (int i = 1; i <= number; i++)
        {
            for (int k = i; k < number; k++)
            {
                Console.Write(" ");

            }
            for (int j = 1; j < 2 * i; j++)
            {
                if (ptrn == "*")
                { Console.Write("*"); }
                else { 
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();
        }
    }
    public static int patterntype()
    {
       
            int type;
        try
        {
            type = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("please enter the sl.no 1,2or3");
            type= patterntype();
        }
        return type;
    }
    public static string patternletter()
    {
        string ptrn;
        do
        {
            Console.WriteLine("star pattern(*) or number pattern(1)");
            ptrn = Convert.ToString(Console.ReadLine());
          //  Console.WriteLine(ptrn);
        } 
        while (IsAllowedChar());

        return ptrn;
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

            Console.WriteLine("please enter a number");
            no = readno();
        }
        return no;
    }

    public static bool IsAllowedChar(string ptrn)
    {
        return ptrn != "*" && ptrn != "1";
    }
    

    }
}