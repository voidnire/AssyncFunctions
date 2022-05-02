using System;
using System.Threading.Tasks;

namespace AssyncFunctions
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Write something!\n");
            Console.ReadLine();

            await Wait(5);

            Console.WriteLine("5 seconds have passed .\n");
            Console.WriteLine("the end. press enter to exit.");
            Console.ReadLine();
        }

        static async Task Wait(int time) 
        {
            Console.Write("Waiting . . .   ");
            await Task.Delay(TimeSpan.FromSeconds(time));
            Console.Write("End of wait.\n");
        }
    }
}
