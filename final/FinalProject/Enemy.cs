abstract class Enemy
{
    private string _eName;
    private int _eMaxHP;
    private int _eCurrentHP;
    private bool _eIsAlive;
    public string _EName => _eName;
    public int _EMaxHP => _eMaxHP;
    public int _ECurrentHP => _eCurrentHP;

    public Enemy(string eName, int eMaxHP)
    {
        _eName = eName;
        _eMaxHP = eMaxHP;
        _eCurrentHP = _eMaxHP;
        _eIsAlive = true;
    }

    public abstract void EnAttack(Character target);

    public void EnTakeDamage(int amount)
    {
        _eCurrentHP -= amount;
        Console.WriteLine($"{_eName} takes {amount} damage.");
        if (_eCurrentHP <= 0)
        {
            _eIsAlive = false;
        }
    }

    public bool IsEnemyAlive()
    {
        return _eIsAlive;
    }
}