namespace Memento.Dometrain.Conceptual;

public class Originator
{
   private string _state = "";

   public void SetState(string state)
   {
      _state = state;
   }

   public string GetState()
   {
      return _state;
   }

   public Memento CreateMemento()
   {
      return new (_state);
   }

   public void RestoreMemento(Memento memento)
   {
      _state = memento.GetState();
   }

   public class Memento
   {
      private readonly string _state;

      internal Memento(string state)
      {
         _state = state;
      }

      internal string GetState()
      {
         return _state;
      }
   }
}