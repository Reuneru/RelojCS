using System;
using TextToAsciiArt;

namespace RelojCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //variales principales
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromSeconds(1);

            //contador
            var timer = new System.Threading.Timer((e) =>
            {
                Console.Clear();
                string HoraMinuto = DateTime.Now.ToString("HH  mm");
                IArtWriter writer = new ArtWriter();
                var settings = new ArtSetting{
                    ConsoleSpeed = 0,
                };
                var data = writer.WriteString(HoraMinuto, settings);
                Console.WriteLine(string.Format("{0," + Console.WindowHeight / 2 + "}", data));
                
            }, null, startTimeSpan, periodTimeSpan);

            //para que no termine el proceso
            while(Console.ReadKey().Key != ConsoleKey.Enter) {}
            
        }
    }
}
