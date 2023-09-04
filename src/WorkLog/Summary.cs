using System.Diagnostics;

namespace WorkLog;

[DebuggerDisplay("{ToString()}")]
internal class SummaryEntry
{
    public TimeSpan TotalTime { get; set; }
    public double TotalHours => TotalTime.TotalHours;
    public string? Title { get; set; }
    public string? Data { get; set; }

    public override string ToString()
    {
        var text = Data == null ? $"{Title}" : $"{Title} | {Data}";
        return $"{TotalTime:d\\.hh\\:mm\\:ss} - {TotalHours:F1} - {text}";
    }
}

internal class Summary
{
    public static Summary Zero { get; } = new Summary {TotalTime = TimeSpan.Zero};

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public TimeSpan TotalTime { get; set; }
    public SummaryEntry[] Entries { get; set; } = Array.Empty<SummaryEntry>();
}