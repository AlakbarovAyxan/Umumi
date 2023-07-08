#region kalkulyator
internal class Program
{
    private static void Main(string[] args)
    {
        double reqem1 = Convert.ToInt32(Console.ReadLine());
        string isare = Console.ReadLine();
        double reqem2 = Convert.ToInt32(Console.ReadLine());
        double netice = 0;
        
        //Console.Write(isare);
        //Console.WriteLine(reqem2);
        //Console.Write("=");
        for (int i = 0; i < 1; i++)
        {
            if (isare[0] == '+')
            {
                netice = reqem1 + reqem2;
            }
            else if (isare[0] == '-')
            {
                netice = reqem1 - reqem2;
            }
            else if (isare[0] == '*')
            {
                netice = reqem1 * reqem2;
            }
            else if (isare[0] == '/')
            {
                netice = reqem1 / reqem2;
            }
            else
            {
                Console.WriteLine("duzgun isare secmediz");
                return;
            }
        }
        Console.Write(reqem1+isare+reqem2+"=");
        Console.Write(netice);
    }
}
#endregion