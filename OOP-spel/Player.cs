class Player
{   
    private int currHP;

    private int points;

    public int Point
    {
        get { return points; }
    }

    public int Health
    {
        get { return currHP; }
    }

    public Player(int hp, int point)
    {
        currHP = hp;
        points = point;
    }   
    
    public void TakeDamage(int amount)
    {
        currHP -= amount;
    }

    public int DoDamage(int amount)
    {
        return amount;
    }

    public int GainPoint(int amount)
    {
        return points += amount;
    }
}
