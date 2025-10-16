namespace State.GameCharacter.CharacterStates;

public class InjuredState : ICharacterState
{
    public void HandleDamage(Character character, int damage)
    {
        character.ModifyHealth(-(damage * 2));
    }

    public void HandlePowerUpCollection(Character character)
    {
        character.ModifyHealth(50);
        character.SetState(new NormalState());
    }

    public void HandleUpdate(Character character)
    {
        character.ModifyHealth(2);

        if (character.Health >= 30) character.SetState(new NormalState());
    }
}