namespace pac_man
{
    class Game
    {
        private Player player;
        private GameField field;
        public void Start()
        {
            player = new Player();
            field = new GameField();
        }

        public void Update()
        {
            field.Redraw();
        }

        public void HandleKeyInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.W: player.CurrentDirection = Directions.UP; break;
                case ConsoleKey.A: player.CurrentDirection = Directions.LEFT; break;
                case ConsoleKey.S: player.CurrentDirection = Directions.DOWN; break;
                case ConsoleKey.D: player.CurrentDirection = Directions.RIGHT; break;
            }
        }
    }
}
