using Homework.Model;

internal class Program
{
   
    private static void Main(string[] args)
    {
        List<Games> list = new List<Games>();

        Games FPS = new Games();
        Games RPG = new Games();
        Games MMORPG = new Games(); 

        FPS.Name = "Valorant";
        FPS.Price = 0;

        RPG.Name = "Skyrim";
        RPG.Price = 60;

        MMORPG.Name = "Lost Ark";
        MMORPG.Price = 60;

        list.Add( FPS );
        list.Add( RPG );
        list.Add( MMORPG );

        foreach (Games Game in list) 
        {
            Console.WriteLine(Game.Name);

            Game.introduceself();   

        }      

    }
}



