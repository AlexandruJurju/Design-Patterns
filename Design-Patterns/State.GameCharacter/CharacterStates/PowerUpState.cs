namespace State.GameCharacter.CharacterStates;

public class PowerUpState : ICharacterState
{
    private int _powerUpDuration = 10;

    public void HandleDamage(Character character, int damage)
    {
        character.ModifyHealth(-(damage / 2));
    }

    public void HandlePowerUpCollection(Character character)
    {
        _powerUpDuration = 10;
    }

    public void HandleUpdate(Character character)
    {
        _powerUpDuration--;

        if (_powerUpDuration == 0)
        {
            character.SetPowerUp(false);

            character.SetState(new NormalState());
        }
    }
}