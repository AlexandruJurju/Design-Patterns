namespace Memento.Dometrain.TextBox;

public class TextHistory
{
    private readonly Stack<TextBox.TextState> _undoStack = [];
    private readonly Stack<TextBox.TextState> _redoStack = [];

    public void Backup(TextBox.TextState textState)
    {
        _undoStack.Push(textState);
        _redoStack.Clear();
    }

    public void Undo(TextBox textBox)
    {
        _redoStack.Push(_undoStack.Pop());
        textBox.Restore(_undoStack.Peek());
    }
}