namespace pac_man
{
    class Game
    {
        private Player Player;
        private GameField Field;
        private int Score = 0;
        public Game()
        {
            Field = new GameField();
            Player = new Player(Field.ValidPosition);
        }

        public void Update()
        {
            (int x,int y) newPos = Player.Update();
            if (Field.ConsumeToken(newPos))
            {
                Score += 10;
            }
            Field.Redraw();
            Field.UpdatePlayerPos(newPos);
            PrintScore();
        }

        public void HandleKeyInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.W: Player.UpdateDirection(Directions.UP); break;
                case ConsoleKey.A: Player.UpdateDirection(Directions.LEFT); break;
                case ConsoleKey.S: Player.UpdateDirection(Directions.DOWN); break;
                case ConsoleKey.D: Player.UpdateDirection(Directions.RIGHT); break;
                case ConsoleKey.UpArrow: Player.UpdateDirection(Directions.UP); break;
                case ConsoleKey.LeftArrow: Player.UpdateDirection(Directions.LEFT); break;
                case ConsoleKey.DownArrow: Player.UpdateDirection(Directions.DOWN); break;
                case ConsoleKey.RightArrow: Player.UpdateDirection(Directions.RIGHT); break;
            }
        }

        private void PrintScore()
        {
            Console.SetCursorPosition(3, 1);
            Console.Write("Score: ");
            Console.Write(Score);
            Console.SetCursorPosition(0, 3);
        }
    }
}
