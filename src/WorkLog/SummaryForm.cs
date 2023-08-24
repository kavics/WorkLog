namespace WorkLog;

public partial class SummaryForm : Form
{
    public SummaryForm(string summary)
    {
        InitializeComponent();

        textBox1.Text = summary;
        textBox1.SelectionStart = textBox1.Text.Length;
        textBox1.SelectionLength = 0;

    }

    private void DropButton_Click(object sender, EventArgs e)
    {
        Drop();
    }

    private void KeepButton_Click(object sender, EventArgs e)
    {
        Keep();
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == '\r') // ENTER
            Keep();

        if (e.KeyChar == '\u001B') // ESC
            Drop();
    }

    private void Drop()
    {
        DialogResult = DialogResult.No;
        Close();
    }
    private void Keep()
    {
        DialogResult = DialogResult.Yes;
        Close();
    }
}