namespace State.GameCharacter.CharacterStates;

public interface ICharacterState
{
    void HandleDamage(Character character, int damage);
    void HandlePowerUpCollection(Character character);
    void HandleUpdate(Character character);
}