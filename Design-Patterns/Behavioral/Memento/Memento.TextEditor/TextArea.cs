namespace Memento.TextEditor;

public class TextArea
{
    public string Text { get; set; }

    public Memento TakeSnapshot()
    {
        return new Memento(Text);
    }

    public void RestoreSnapshot(Memento memento)
    {
        Text = memento.Text;
    }

    public class Memento(string text)
    {
        public string Text { get; set; } = text;
    }
}