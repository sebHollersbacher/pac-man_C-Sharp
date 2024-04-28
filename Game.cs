namespace pac_man
{
    class Game
    {
        private Player player;
        private GameField field;
        public void Start()
        {
            Console.WriteLine("Start");
            player = new Player();
            field = new GameField();
            field.Print();
        }

        public void Update()
        {
            Console.Clear();
            field.Print();
        }

        public void HandleKeyInput(ConsoleKey key)
        {
            player.CurrentDirection = key switch
            {
                ConsoleKey.W => Directions.UP,
                ConsoleKey.A => Directions.LEFT,
                ConsoleKey.S => Directions.DOWN,
                ConsoleKey.D => Directions.RIGHT,
            };

        }
    }
}
