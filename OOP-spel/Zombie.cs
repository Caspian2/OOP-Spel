class Zombie : Enemy
{
    public Zombie() : base(20)
    {
        
    }     

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount / 2);
        Console.WriteLine("Zombie was hit");
    }

    public override int ded(int amount)
    {
        return base.ded(amount);
    }

    public override int DoDamage(int amount)
    {
        return base.DoDamage(amount);
        
    }
}
