public class Program
{
    public static void Main(string[] args ) 
    {
        Console.WriteLine("asdfg");
      
   
        int no = readno();
        
        for (int i = 0; i < no; i++)
        {
            for (int j = 0; j < no; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            
        }
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