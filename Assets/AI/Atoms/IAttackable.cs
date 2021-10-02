
public interface IAttacker
{
    void Attack();
}

public interface IAttackable
{
    void ReceiveAttack(IAttacker attacker);
}