namespace State.GameCharacter.CharacterStates;

public class NormalState : ICharacterState
{
    public void HandleDamage(Character character, int damage)
    {
        character.ModifyHealth(-damage);

        if (character.Health < 30)
        {
            character.SetState(new InjuredState());
        }
    }

    public void HandlePowerUpCollection(Character character)
    {
        character.SetPowerUp(true);

        character.SetState(new PowerUpState());
    }

    public void HandleUpdate(Character character)
    {
        // does nothing
    }
}