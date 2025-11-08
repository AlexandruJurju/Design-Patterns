namespace Memento.Dometrain.TextBox;

public class TextBox
{
   public string Text { get;  set; } = "";

   public TextState Save()
   {
      return new (Text);
   }

   public void Restore(TextState textState)
   {
      Text = textState.GetText();
   }

   public class TextState
   {
      private readonly string _text;

      internal TextState(string text)
      {
         _text = text;
      }

      internal string GetText()
      {
         return _text;
      }
   }
}