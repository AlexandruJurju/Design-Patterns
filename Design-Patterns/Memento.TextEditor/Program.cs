using Memento.TextEditor;

Editor editor = new();

editor.Write("Hello world");
editor.Write("First sentence");
editor.Write("Second sentence");

Console.WriteLine(editor.GetText());
Console.WriteLine();

editor.Undo();

Console.WriteLine(editor.GetText());
