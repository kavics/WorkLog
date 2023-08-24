using System.Diagnostics;
using System.Globalization;
using System.Text;
// ReSharper disable LocalizableElement

namespace WorkLog;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private bool _isControlKeyActive;
    private void workLogTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.ControlKey)
            _isControlKeyActive = true;
        e.Handled = false;
    }

    private void workLogTextBox_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.ControlKey)
            _isControlKeyActive = false;
        else if (e.KeyCode == Keys.F5)
        {
            InsertNewRecord();
            e.Handled = true;
        }
    }

    private void workLogTextBox_DoubleClick(object sender, EventArgs e)
    {
        var text = workLogTextBox.Text;
        var s0 = workLogTextBox.SelectionStart;
        var s1 = s0 + workLogTextBox.SelectionLength - 1;
        if (s1 <= s0)
            return;

        while (s1 > 0 && (text[s1] == '\t' && text[s1] == '\r' && text[s1] == '\n'))
            s1--;
        while (s0 > 0 && text[s0 - 1] != '\t' && text[s0 - 1] != '\r' && text[s0 - 1] != '\n')
            s0--;
        while (s1 < text.Length - 1 && text[s1] != '\t' && text[s1] != '\r' && text[s1] != '\n')
            s1++;
        workLogTextBox.SelectionStart = s0;
        workLogTextBox.SelectionLength = s1 - s0;
        var selectedText = workLogTextBox.SelectedText;

        if (_isControlKeyActive &&
            (selectedText.StartsWith("http://", StringComparison.InvariantCultureIgnoreCase) ||
             selectedText.StartsWith("https://", StringComparison.InvariantCultureIgnoreCase)))
        {
            var url = selectedText;
            //url = url.Replace("&", "^&");
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }

    private void workLogTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == '\u0013') // ctrl+s
        {
            Save();
            e.Handled = true;
        }
    }

    private string GetDataFilePath()
    {
        var baseDir = AppDomain.CurrentDomain.BaseDirectory;
        return Path.Combine(baseDir, "data\\worklog.txt");
    }

    private bool _loading;
    private void Form1_Load(object sender, EventArgs e)
    {
        _loading = true;
        var dataFile = GetDataFilePath();
        if (!File.Exists(dataFile))
        {
            var parentDir = Path.GetDirectoryName(dataFile);
            if (parentDir == null)
            {
                MessageBox.Show("System error", this.Text, MessageBoxButtons.OK);
                Close();
            }
            else
            {
                if (!Directory.Exists(parentDir))
                    Directory.CreateDirectory(parentDir);

                using var writer = new StreamWriter(dataFile);
                var now = DateTime.Now;
                writer.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss\tCREATED"));
                writer.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss\t-"));
                writer.WriteLine("----");
            }
        }
        using var reader = new StreamReader(dataFile);
        var text = reader.ReadToEnd();
        workLogTextBox.Text = text;
        workLogTextBox.SelectionStart = workLogTextBox.Text.Length;
        workLogTextBox.SelectionLength = 0;
        _loading = false;
    }

    private bool _needToSave;
    private void workLogTextBox_TextChanged(object sender, EventArgs e)
    {
        if (_loading)
            return;
        if (this.Text.EndsWith("*"))
            return;
        this.Text += " *";
        _needToSave = true;
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (_needToSave)
        {
            switch (MessageBox.Show("Data is changed.\r\nDo you want to save changes?", this.Text, MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    Save();
                    break;
            }
        }
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        Save();
    }

    private void Save()
    {
        var dataFile = GetDataFilePath();

        using var writer = new StreamWriter(dataFile, Encoding.UTF8, new FileStreamOptions
        {
            Access = FileAccess.Write,
            Mode = FileMode.Create
        });

        writer.Write(workLogTextBox.Text);

        if (this.Text.EndsWith("*"))
            this.Text = this.Text.Substring(0, this.Text.Length - 1).TrimEnd();

        _needToSave = false;
    }

    private void calcButton_Click(object sender, EventArgs e)
    {
        var result = new Calculator().CalculateDay(workLogTextBox.Text);
        var summaryText = GetSummaryText(result);

        var summaryForm = new SummaryForm(summaryText);
        var dialogResult = summaryForm.ShowDialog();
        if (dialogResult != DialogResult.Yes)
            return;

        EnsureNewLineAtTheEnd();
        workLogTextBox.AppendText(summaryText);

        workLogTextBox.SelectionStart = workLogTextBox.Text.Length;
        workLogTextBox.SelectionLength = 0;
    }

    private void EnsureNewLineAtTheEnd()
    {
        if (workLogTextBox.Text.Substring(workLogTextBox.Text.Length - 2) != "\r\n")
            workLogTextBox.AppendText("\r\n");
        workLogTextBox.SelectionStart = workLogTextBox.Text.Length;
        workLogTextBox.SelectionLength = 0;
    }

    private string GetSummaryText(Summary result)
    {
        var backup = CultureInfo.CurrentCulture;
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
        try
        {
            var totalTime = result.TotalTime;
            var totalTime2 = TimeSpan.FromTicks(totalTime.Ticks + totalTime.Ticks / 5);
            var totalHours = totalTime.TotalHours;
            var totalHours2 = totalTime2.TotalHours;

            using var writer = new StringWriter(CultureInfo.InvariantCulture);
            writer.WriteLine("\t==========================================================================");
            if (result.StartDate == result.EndDate)
                writer.WriteLine($"\tSUMMARY Period: {result.StartDate:yyyy-MM-dd}");
            else
                writer.WriteLine($"\tSUMMARY Period: {result.StartDate:yyyy-MM-dd} - {result.EndDate:yyyy-MM-dd}");
            writer.WriteLine("\t--------------------------------------------------------------------------");
            writer.WriteLine($"\tTotal time\tTotal time+\tHours\tHours+\tTask");
            writer.WriteLine("\t--------------------------------------------------------------------------");
            foreach (var entry in result.Entries)
            {
                var time = entry.TotalTime;
                var time2 = TimeSpan.FromTicks(time.Ticks + time.Ticks / 5);
                var hours = time.TotalHours;
                var hours2 = time2.TotalHours;

                var text = entry.Data == null ? $"{entry.Title}" : $"{entry.Title}\t{entry.Data}";
                writer.WriteLine($"\t{time:d\\.hh\\:mm\\:ss}\t{time2:d\\.hh\\:mm\\:ss}\t{hours:F1}\t{hours2:F1}\t{text}");
            }
            writer.WriteLine("\t--------------------------------------------------------------------------");
            writer.WriteLine($"\t{totalTime:d\\.hh\\:mm\\:ss}\t{totalTime2:d\\.hh\\:mm\\:ss}\t{totalHours:F1}\t{totalHours2:F1}");

            writer.WriteLine("\t==========================================================================");
            return writer.GetStringBuilder().ToString();
        }
        finally
        {
            CultureInfo.CurrentCulture = backup;
        }
    }

    private void newTaskButton_Click(object sender, EventArgs e)
    {
        InsertNewRecord();
    }

    private void restartTaskButton_Click(object sender, EventArgs e)
    {
        var text = workLogTextBox.Text;
        var s0 = workLogTextBox.SelectionStart;
        var s1 = s0;
        while (s0 > 0 && text[s0 - 1] != '\r' && text[s0 - 1] != '\n')
            s0--;
        while (s1 < text.Length - 1 && text[s1] != '\r' && text[s1] != '\n')
            s1++;
        //workLogTextBox.SelectionStart = s0;
        //workLogTextBox.SelectionLength = s1 - s0;
        var line = text.Substring(s0, s1 - s0);
        if (!WorkLogEntry.TryParse(line, out var existingEntry) || existingEntry.IsStopping)
        {
            MessageBox.Show("Select a valid task", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }
        InsertNewRecord();
        var entryText = existingEntry.Data == null
            ? $"{existingEntry.Title}"
            : $"{existingEntry.Title}\t{existingEntry.Data}";

        workLogTextBox.AppendText(entryText);
        workLogTextBox.AppendText("\r\n");
    }

    private void stopTaskButton_Click(object sender, EventArgs e)
    {
        InsertNewRecord();
        workLogTextBox.AppendText("\r\n");
        workLogTextBox.Focus();
    }

    private void InsertNewRecord()
    {
        EnsureNewLineAtTheEnd();
        workLogTextBox.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss\t"));
        workLogTextBox.Focus();
    }
}