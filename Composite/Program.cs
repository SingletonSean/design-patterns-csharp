using Composite.Models;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioTimeline timeline = new AudioTimeline(TimeSpan.Zero, TimeSpan.FromSeconds(10));
            timeline.Title = "Main Timeline";
            timeline.AddCut(TimeSpan.FromSeconds(2));
            timeline.AddCut(TimeSpan.FromSeconds(4));
            timeline.AddCut(TimeSpan.FromSeconds(5));

            foreach (string line in timeline.ToOutputLines())
            {
                Console.WriteLine(line);
            }
        }
    }
}
