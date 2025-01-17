using State.GameCharacter.CharacterStates;

namespace State.GameCharacter;

public class Character
{
    private ICharacterState _characterState = new NormalState();
    public int Health { get; private set; } = 100;
    public bool HasPowerUp { get; private set; }

    public void SetState(ICharacterState characterState)
    {
        _characterState = characterState;
    }

    public void TakeDamage(int damage)
    {
        _characterState.HandleDamage(this, damage);
    }

    public void CollectPowerUp()
    {
        _characterState.HandlePowerUpCollection(this);
    }

    public void Update()
    {
        _characterState.HandleUpdate(this);
    }

    public void ModifyHealth(int amount)
    {
        Health = Math.Clamp(Health + amount, 0, 100);
    }

    public void SetPowerUp(bool hasPowerUp)
    {
        HasPowerUp = hasPowerUp;
    }
}