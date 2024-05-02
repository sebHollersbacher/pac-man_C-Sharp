namespace pac_man
{
    class Game
    {
        private Player Player;
        private Enemy Enemy;
        private GameField Field;
        private int Score = 0;
        public Game()
        {
            Field = new GameField();
            Player = new Player(Field.ValidPosition);
            Enemy = new Enemy(Field.ValidPosition);
        }

        public void Update()
        {
            (int x,int y) newPlayerPos = Player.Update();
            if (Field.ConsumeToken(newPlayerPos))
            {
                Score += 10;
            }

            (int x, int y) newEnemyPos = Enemy.Update();

            Field.Redraw();
            Field.UpdateCharacterPos(newPlayerPos, 'O');
            Field.UpdateCharacterPos(newEnemyPos, 'E');
            PrintScore();
        }
        public void KeyPressed(ConsoleKey key)
        { 
            Player.HandleKeyInput(key);
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
