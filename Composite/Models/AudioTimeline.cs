using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Models
{
    public class AudioTimeline : IAudioTimeline
    {
        private readonly List<TimeSpan> _cuts;

        public string Title { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public IEnumerable<TimeSpan> Cuts => _cuts;

        public AudioTimeline(TimeSpan startTime, TimeSpan endTime)
        {
            StartTime = startTime;
            EndTime = endTime;

            _cuts = new List<TimeSpan>();
        }

        public void AddCut(TimeSpan cut)
        {
            _cuts.Add(cut);
        }

        public IEnumerable<string> ToOutputLines()
        {
            List<string> lines = new List<string>();

            lines.Add($"TITLE: {Title}");
            lines.Add($"START TIME: {StartTime}");
            lines.Add($"END TIME: {EndTime}");
            lines.Add("CUTS:");
            _cuts.ForEach(t => lines.Add(t.ToString()));

            return lines;
        }
    }
}
