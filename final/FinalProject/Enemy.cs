abstract class Enemy
{
    private string _eName;
    private int _eMaxHP;
    private int _eCurrentHP;
    private bool _eIsAlive;
    private int _givenXP;
    // All of these public variables are so that other parts of the program can still display these values
    // to the user, but still keeps the value protected, and uneditable without having direct access to it.
    public string _EName => _eName;
    public int _EMaxHP => _eMaxHP;
    public int _ECurrentHP => _eCurrentHP;
    public int _GivenXP => _givenXP;
    

    public Enemy(string eName, int eMaxHP, int givenXP)
    {
        _eName = eName;
        _eMaxHP = eMaxHP;
        _eCurrentHP = _eMaxHP;
        _givenXP = givenXP;
        _eIsAlive = true;
    }

    // This is the enemy's attack, which is different for both the common enemies and the boss, so it's overridden.
    public abstract void EnAttack(Character target);

    // This is called whenever the enemy is attacked, making them take damage.
    public void EnTakeDamage(int amount)
    {
        _eCurrentHP -= amount;
        // This checks if the enemy has taken too much damage, and if so, sets _eIsAlive to false, so that they are dead.
        if (_eCurrentHP <= 0)
        {
            _eIsAlive = false;
        }
    }

    // This checks if the enemy is alive, so that other parts of the program can use that.
    public bool IsEnemyAlive()
    {
        return _eIsAlive;
    }
}