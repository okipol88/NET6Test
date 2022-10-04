using ClassLibrary1;
using System;
using System.Threading.Tasks;

namespace NET5Test
{
  internal class Program
  {
    static async Task Main(string[] args)
    {
      var c = new Class1();
      Console.WriteLine($"Hello World! from NET 6.0 + {c.GetType().FullName}");

      while (true)
      {
        await Task.Delay(100);

        if (Console.KeyAvailable)
        {
          break;
        }
      }

      Console.WriteLine("Press enter to exit...");
      Console.ReadLine();
    }
  }
}