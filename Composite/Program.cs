using Composite.Models;
using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioTimeline timeline1 = new AudioTimeline(TimeSpan.Zero, TimeSpan.FromSeconds(10));
            timeline1.Title = "Main Timeline 1";
            timeline1.AddCut(TimeSpan.FromSeconds(2));
            timeline1.AddCut(TimeSpan.FromSeconds(4));
            timeline1.AddCut(TimeSpan.FromSeconds(5));

            AudioTimeline timeline2 = new AudioTimeline(TimeSpan.Zero, TimeSpan.FromSeconds(20));
            timeline2.Title = "Main Timeline 2";
            timeline2.AddCut(TimeSpan.FromSeconds(12));
            timeline2.AddCut(TimeSpan.FromSeconds(14));
            timeline2.AddCut(TimeSpan.FromSeconds(15));

            AudioTimeline timeline3 = new AudioTimeline(TimeSpan.Zero, TimeSpan.FromSeconds(30));
            timeline3.Title = "Main Timeline 3";
            timeline3.AddCut(TimeSpan.FromSeconds(20));
            timeline3.AddCut(TimeSpan.FromSeconds(24));
            timeline3.AddCut(TimeSpan.FromSeconds(25));

            AudioTimeline timeline4 = new AudioTimeline(TimeSpan.Zero, TimeSpan.FromSeconds(40));
            timeline4.Title = "Main Timeline 4";
            timeline4.AddCut(TimeSpan.FromSeconds(30));
            timeline4.AddCut(TimeSpan.FromSeconds(34));
            timeline4.AddCut(TimeSpan.FromSeconds(35));

            CompositeAudioTimeline compositeTimeline1 = new CompositeAudioTimeline();

            compositeTimeline1.Add(timeline1);
            compositeTimeline1.Add(timeline2);

            CompositeAudioTimeline compositeTimeline2 = new CompositeAudioTimeline();

            compositeTimeline2.Title = "Main Composite Timeline";
            compositeTimeline2.Add(timeline3);
            compositeTimeline2.Add(timeline4);
            compositeTimeline2.Add(compositeTimeline1);

            PrintTimeline(compositeTimeline2);

            PrintTimeline(timeline1);
        }

        private static void PrintTimeline(IAudioTimeline timeline)
        {
            foreach (string line in timeline.ToOutputLines())
            {
                Console.WriteLine(line);
            }
        }
    }
}
