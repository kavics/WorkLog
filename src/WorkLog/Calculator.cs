namespace WorkLog;

internal class Calculator
{
    public Summary CalculateDay(string text)
    {
        var entries = Parse(text);
        var lastDayEntries = SelectLastDayEntries(entries);
        return Summarize(lastDayEntries.ToArray());
    }
    public Summary CalculateTotal(string text)
    {
        var entries = Parse(text);
        return Summarize(entries.ToArray());
    }
    public Summary CalculateWorkHours(string text)
    {
        throw new NotImplementedException();
    }

    private IEnumerable<WorkLogEntry> Parse(string text)
    {
        var entries = new List<WorkLogEntry>();
        using var reader = new StringReader(text);
        string? line;
        while((line = reader.ReadLine())!=null)
            if(WorkLogEntry.TryParse(line, out var entry))
                entries.Add(entry);
        return entries;
    }

    private IEnumerable<WorkLogEntry> SelectLastDayEntries(IEnumerable<WorkLogEntry> entries)
    {
        var workLogEntries = entries as WorkLogEntry[] ?? entries.ToArray();
        var today = workLogEntries.Last().Time.Date;
        var yesterday = today.AddDays(-1).Date;
        var lastYesterdayEntry =
            workLogEntries.LastOrDefault(x => x.Time.Date == yesterday);
        var todayEntries =
            workLogEntries.Where(x => x.Time.Date == today).ToList();
        if(lastYesterdayEntry != null && !lastYesterdayEntry.IsStopping)
            todayEntries.Insert(0, new WorkLogEntry
            {
                Time = today,
                Title= lastYesterdayEntry.Title,
                Data = lastYesterdayEntry.Data
            });
        if(!(todayEntries.LastOrDefault()?.IsStopping ?? true))
            todayEntries.Insert(0, new WorkLogEntry {Time = today.AddDays(1).Date, IsStopping = true});
        return todayEntries;
    }

    private Summary Summarize(WorkLogEntry[] entries)
    {
        // 0	"2023-08-02 02:00:11 - Akármi"
        // 1	"2023-08-02 02:05:35 - 6045 Sample case studies | https:/...
        // 2	"2023-08-02 02:10:04 - [STOP]"
        // 3	"2023-08-02 02:17:20 - 6045 Sample case studies | https:/...
        // 4	"2023-08-02 02:20:04 - [STOP]"
        // 5	"2023-08-02 20:29:30 - Akármi2 | wqer\tyxcv"
        // 6	"2023-08-02 20:39:30 - Akármi"
        // 7	"2023-08-02 20:49:04 - [STOP]"

        var aggregation = new List<SummaryEntry>();
        WorkLogEntry? lastEntry = null;
        foreach (var entry in entries)
        {
            if (entry.IsStopping)
            {
                if (lastEntry?.IsStopping ?? true)
                    continue;
                Stop(entry, lastEntry, aggregation);
                lastEntry = entry;
            }
            else
            {
                if (lastEntry != null && !lastEntry.IsStopping)
                    Stop(entry, lastEntry, aggregation);
                lastEntry = entry;
            }
        }

        return new Summary
        {
            StartDate = entries.First().Time.Date,
            EndDate = entries.Last().Time.Date,
            Entries = aggregation.OrderBy(e => e.Title).ToArray(),
            TotalTime = TimeSpan.FromTicks(aggregation.Sum(x => x.TotalTime.Ticks))
        };
    }

    private void Stop(WorkLogEntry entry, WorkLogEntry lastEntry, List<SummaryEntry> aggregation)
    {
        var duration = entry.Time - lastEntry.Time;
        var existingSumEntry = aggregation
            .FirstOrDefault(x => x.Title == lastEntry.Title && x.Data == lastEntry.Data);
        if (existingSumEntry != null)
        {
            existingSumEntry.TotalTime += duration;
        }
        else
        {
            aggregation.Add(new SummaryEntry
            {
                TotalTime = duration,
                Title = lastEntry.Title,
                Data = lastEntry.Data
            });
        }
    }
}