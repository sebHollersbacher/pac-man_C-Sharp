namespace pac_man
{
    class Game
    {
        private Player player;
        private GameField field;
        public void Start()
        {
            field = new GameField();
            player = new Player(field);
        }

        public void Update()
        {
            (int x,int y) newPos = player.Update();
            field.Redraw();
            field.UpdatePlayerPos(newPos);
        }

        public void HandleKeyInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.W: player.UpdateDirection(Directions.UP); break;
                case ConsoleKey.A: player.UpdateDirection(Directions.LEFT); break;
                case ConsoleKey.S: player.UpdateDirection(Directions.DOWN); break;
                case ConsoleKey.D: player.UpdateDirection(Directions.RIGHT); break;
            }
        }
    }
}
