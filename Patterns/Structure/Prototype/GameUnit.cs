public abstract class GameUnit: IPrototype<GameUnit>
{ 
    public int Health { get; set; } 
    public int Attack { get; set; } 
    public int Defense { get; set; }

        public virtual void LoadResources()
        {
            Console.WriteLine("Loading resources...");
        }
        public abstract GameUnit Clone();
} 