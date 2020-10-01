using System;

namespace gissatalförsök9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var num = rnd.Next(0,100);
            Console.WriteLine("Gissa ett tala mellan 1 och 100");

            var gissningar = 0; 

            while (true)
            {
                int tal;
                bool success = Int32.TryParse(Console.ReadLine(), out tal);

                if (success)

                {
                    gissningar++;
                    if (tal > num)
                    {
                        Console.WriteLine("Talet är mindre, Gissa igen");
                    }
                    else if (tal < num)
                    {
                        Console.WriteLine("Talet är större, Gissa igen");
                    }
                    else if (tal == num)
                    {
                        var svar = "";
                        while (true)
                        {
                        Console.WriteLine($"Du gissade rätt fan va du är bra!! Du gissade {gissningar} gånger bättre kan du vill du spela igen? JA/NEJ");
                        svar = Console.ReadLine();
                            if (svar.Equals("JA") || svar.Equals("NEJ"))
                            {
                                break;
                            }
                        }
                        
                        if (svar.Equals("NEJ"))
                        {
                           break;
                        }
                        else if (svar.Equals("JA"))
                        {
                            gissningar = 0;
                            num = rnd.Next(0, 100);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Du får endast gissa heltal kompis");
                }
                

            }
        }
    }
}
