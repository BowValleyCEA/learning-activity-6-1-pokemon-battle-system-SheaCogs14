class Pokemon
{
    public string Name { get; set; }
    public int currentHealth;
    public int maxHealth;
    public int baseDamage;

    public Pokemon(string currentName, int aCurrentHealth, int aMaxHealth = 12, int aBaseDamage = 3)
    {
        Name = currentName;
        currentHealth = aMaxHealth;
        maxHealth = aMaxHealth;
        baseDamage = aBaseDamage;

    }

    internal virtual void ReciveAttack(Pokemon target)
    {
        int damage = baseDamage;
        target.currentHealth -= damage;

        Console.WriteLine($"{target.Name} has taken {damage} damage!");
    }

    internal virtual void Attack(int attackAmount)
    {
        currentHealth -= attackAmount;
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
    }

    internal virtual void BaseHeal(int healAmount)
    {
        currentHealth += healAmount;
        if (currentHealth > 12)
        {
            currentHealth = 12;
        }

        Console.WriteLine(currentHealth + " is your current health");
    }
}
