abstract class Enemy
{
    private int currHP;


    public int Health
    {
        get { return currHP; }
    }

    public Enemy(int hp)
    {
        currHP = hp;
    }
    public virtual void TakeDamage(int amount)
    {
        currHP -= amount;
    }

    public virtual int DoDamage(int amount)
    {
        return amount;
    }  

    public  virtual int ded(int amount)
    {
       return amount;
    }
}
