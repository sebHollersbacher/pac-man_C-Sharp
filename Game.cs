namespace pac_man
{
    class Game
    {
        private Player Player;
        private GameField Field;
        public Game()
        {
            Field = new GameField();
            Player = new Player(Field.ValidPosition);
        }

        public void Update()
        {
            (int x,int y) newPos = Player.Update();
            Field.Redraw();
            Field.UpdatePlayerPos(newPos);
        }

        public void HandleKeyInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.W: Player.UpdateDirection(Directions.UP); break;
                case ConsoleKey.A: Player.UpdateDirection(Directions.LEFT); break;
                case ConsoleKey.S: Player.UpdateDirection(Directions.DOWN); break;
                case ConsoleKey.D: Player.UpdateDirection(Directions.RIGHT); break;
            }
        }
    }
}
