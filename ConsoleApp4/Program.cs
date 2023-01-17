namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Color c = (Color)(new Random()).Next(0, 4);

            switch (c)
            {
                case Color.RG:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.WriteLine("Punane + roheline = kollane");
                    break;
                case Color.RB:
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Clear();
                    Console.WriteLine("Punane + sinine = lilla");
                    break;
                case Color.GB:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    Console.WriteLine("Roheline + sinine = helesinine");
                    break;
                case Color.RGB:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("Kõik kolm kokku annavad valge");
                    break;
                

                default:
                    break;
            }
        }
        public enum Color
        {
            RG,
            RB,
            GB,
            RGB
         }
      }
    }
 ;