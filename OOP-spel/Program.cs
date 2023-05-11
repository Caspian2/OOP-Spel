    class Program
{   
    enum state
    {
        Battle,
        MainMenu,
        City,
        Ded
    }
    static void Main(string[] args)
    {
        Player Gunnar = new Player(100, 0);

        StreamWriter pont = new StreamWriter("Points.txt");

        List<Enemy> enemys = new List<Enemy>();
        Enemy Zam = new Zombie();
        Enemy Bone = new Skeleton();
        enemys.Add(Zam);
        enemys.Add(Bone);
        
       
        state states = state.MainMenu;

        Console.WriteLine("Press e to begin battle");

        string battle = Console.ReadLine();

        if(battle == "e")
        {
            states = state.Battle;
        }
        switch (states)
        {   
            case state.Battle:
                while(Gunnar.Health > 0 && enemys.Count != 0)
                {   
                    //Player turn
                    Console.WriteLine("--Player make move---");
                    Console.WriteLine("Press a to attack" + enemys[0]);
                    Console.WriteLine("Press h to see hp");

                    string choice = Console.ReadLine();

                    if(choice == "a")
                    {
                        enemys[0].TakeDamage(Gunnar.DoDamage(10));
                        Console.WriteLine("Target: " + enemys[0].Health);                        
                    } 
                    else if(choice == "h")
                    {
                        Console.WriteLine("YOur hp: " + Gunnar.Health + "hp");
                    }

                    for(int i = 0; i < enemys.Count; i++)
                    { 
                        if(enemys[0].Health <= 0)
                        {
                            Gunnar.GainPoint(enemys[0].ded(1));
                            enemys.RemoveAt(0);
                            Console.WriteLine("You got a point!");
                           
                        }
                     
                        else if(enemys.Count > 0)
                        {
                            Console.WriteLine("Enemy turn");
                            Console.WriteLine("Enemy Attacked");

                            Gunnar.TakeDamage(enemys[i].DoDamage(5));                           
                        }  
                    }  

                    if(enemys.Count == 0)
                    {
                        Console.WriteLine("YOu won");
                         try{
                                pont.WriteLine("Points " + Gunnar.Point);
                                pont.Close();
                            }
                            catch
                            {
                                Console.WriteLine("Fel med fil");
                            }
                        Console.WriteLine("Check file for you points");
                        
                    }

                    
                }
                break;
        }
            
        
    }
}