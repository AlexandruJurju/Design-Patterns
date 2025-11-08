using Memento.Dometrain.TextBox;

TextBox textBox = new();
TextHistory textHistory = new();

textBox.Text = ("State1");
textHistory.Backup(textBox.Save());
textBox.Text =("State2");
textHistory.Backup(textBox.Save());

textHistory.Undo(textBox);
Console.WriteLine(textBox.Text);
textHistory.Undo(textBox);
Console.WriteLine(textBox.Text);
