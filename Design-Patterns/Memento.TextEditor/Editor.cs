namespace Memento.TextEditor;

public class Editor
{
    private readonly LinkedList<TextArea.Memento> history;
    private readonly TextArea textArea;

    public Editor()
    {
        textArea = new ();
        history = new ();
    }

    public void Write(string text)
    {
        textArea.Text += text + "\n";
        history.AddLast(textArea.TakeSnapshot()); 
    }

    // Undo the last change
    public void Undo()
    {
        if (history.Count > 0)
        {
            history.RemoveLast();
            var lastMemento = history.Last.Value;

            textArea.RestoreSnapshot(lastMemento);
        }
        else
        {
            Console.WriteLine("Editor: No more states to undo.");
        }
    }

    public string GetText()
    {
        return textArea.Text;
    }
}

