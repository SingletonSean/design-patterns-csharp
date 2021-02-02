using System;
using System.Collections.Generic;

namespace Composite.Models
{
    public interface IAudioTimeline
    {
        TimeSpan StartTime { get; }
        TimeSpan EndTime { get; }
        IEnumerable<TimeSpan> Cuts { get; }

        IEnumerable<string> ToOutputLines();
    }
}