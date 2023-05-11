class Skeleton : Enemy
{
    public Skeleton() : base(20)
    {
        
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
        Console.WriteLine("Skeleton was hit");
    }

    public override int DoDamage(int amount)
    {
        return base.DoDamage(amount * 2);
    }
}
