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
    // All of these public variables are so that other parts of the program can still display these values
    // to the user, but still keeps the value protected, and uneditable without having direct access to it.
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

    // This function raises the users level, increasing their HP and FP, and setting their current stats to their max.
    public virtual void LevelUP()
    {
        _level++;
        _maxHP += 10;
        _currentHP = _maxHP;
        _maxFP += 5;
        _currentFP = _maxFP;
        Console.WriteLine($"{_name} leveled up to {_level}!");
    }

    // This is a simple way to scale the XP needed to level up.
    public int XPToNextLevel()
    {
        return 100 * _level;
    }

    // This is called whenever the player defeats an enemy, giving them the XP the enemy is assigned.
    public void GainXP(int amount)
    {
        _currentXP += amount;
        // This is a while loop and not an if statement, 
        // because it could be possible for the player to level up more than once at a time.
        while (_currentXP >= XPToNextLevel())
        {
            _currentXP -= XPToNextLevel();
            LevelUP();
        }
    }

    // This is called whenever the player takes damage, reducing their current HP.
    public void TakeDamage(int amount)
    {
        _currentHP -= amount;
        // This checks if the character has taken too much damage, and if so, sets _isAlive to false, so that they are dead.
        if (_currentHP <= 0)
        {
            _isAlive = false;
        }
    }

    // This is used to heal the player. So far it's only used in the warrior's special attack.
    public void Heal(int amount)
    {
        _currentHP += amount;
        // This if statement stops the player from somehow having more HP than their max.
        if (_currentHP > _maxHP)
        {
            _currentHP = _maxHP;
        }
    }

    // This function uses the players FP to use a skill, and checks if they have enough to do so.
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

    // This is not called since I have no idea where to use it, but I thought it could be useful.
    public void RegainFP(int amount)
    {
        _currentFP += amount;
        // This also makes it so that a player can't somehow gain more FP than their max.
        if (_currentFP > _maxFP)
        {
            _currentFP = _maxFP;
        }
    }
    
    // This checks if the character is alive, so that other parts of the program can use that.
    public bool IsCharacterAlive()
    {
        return _isAlive;
    }

    // This is the basic attack, which is overridden in all the classes, so that
    // each class has a different amount of damage they do.
    public abstract void Attack(Enemy target);

    // This function is overridden in all the classes.
    public abstract void SpAttack(Enemy target);
}