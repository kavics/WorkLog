using System.Diagnostics;

namespace WorkLog;

[DebuggerDisplay("{ToString()}")]
internal class WorkLogEntry
{
    public DateTime Time { get; set; }
    public string? Title { get; set; }
    public string? Data { get; set; }
    public bool IsStopping { get; set; }

    public static readonly WorkLogEntry Empty = new WorkLogEntry{ Time = DateTime.MinValue};
    public static bool TryParse(string? line, out WorkLogEntry entry)
    {
        entry = Empty;
        if(line == null)
            return false;

        var items = line.Split('\t');
        if (!DateTime.TryParse(items[0], out var time))
            return false;

        entry = new WorkLogEntry {Time = time};
        if (items.Length > 1)
            entry.Title = items[1];
        if (items.Length > 2)
            entry.Data = string.Join("\t", items.Skip(2));

        if (entry.Title == null)
        {
            entry.IsStopping = true;
        }
        else
        {
            var t = entry.Title.Trim().ToLowerInvariant();
            if (t == string.Empty || t == "stop" || t == "-")
                entry.IsStopping = true;
        }
        return true;
    }

    public override string ToString()
    {
        var title = IsStopping ? "[STOP]" : Title;
        return Data == null 
            ? $"{Time:yyyy-MM-dd HH:mm:ss} - {title}" 
            : $"{Time:yyyy-MM-dd HH:mm:ss} - {title} | {Data}";
    }
}