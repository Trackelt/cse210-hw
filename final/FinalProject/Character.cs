abstract class Character
{
    private string _name;
    private int _level;
    private int _currentXP;
    private int _maxHP;
    private int _currentHP;
    private int _maxFP;
    private int _currentFP;
    private bool _isAlive;
    public string _Name => _name;
    public int _Level => _level;
    public int _CurrentXP => _currentXP;
    public int _MaxHP => _maxHP;
    public int _CurrentHP => _currentHP;
    public int _MaxFP => _maxFP;
    public int _CurrentFP => _currentFP;

    public Character(string name, int baseHP, int baseFP)
    {
        _name = name;
        _level = 1;
        _currentXP = 0;
        _maxHP = baseHP;
        _currentHP = _maxHP;
        _maxFP = baseFP;
        _currentFP = _maxFP;
        _isAlive = true;
    }

    public virtual void LevelUP()
    {
        _level++;
        _maxHP += 10;
        _currentHP = _maxHP;
        _maxFP += 5;
        _currentFP = _maxFP;
        Console.WriteLine($"{_name} leveled up to {_level}!");
    }
    public int XPToNextLevel()
    {
        return 100 * _level;
    }

    public void GainXP(int amount)
    {
        _currentXP += amount;
        while (_currentXP >= XPToNextLevel())
        {
            _currentXP -= XPToNextLevel();
            LevelUP();
        }
    }

    public void TakeDamage(int amount)
    {
        _currentHP -= amount;
        if (_currentHP <= 0)
        {
            _isAlive = false;
        }
    }
    public void Heal(int amount)
    {
        _currentHP += amount;
        if (_currentHP > _maxHP)
        {
            _currentHP = _maxHP;
        }
    }
    public bool UseFP(int amount)
    {
        if (_currentFP >= amount)
        {
            _currentFP -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }
    public void RegainFP(int amount)
    {
        _currentFP += amount;
        if (_currentFP > _maxFP)
        {
            _currentFP = _maxFP;
        }
    }
    public bool IsCharacterAlive()
    {
        return _isAlive;
    }
    public abstract void Attack(Enemy target);
    public abstract void SpAttack(Enemy target);
}