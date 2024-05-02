namespace pac_man
{
    internal class Player(Func<(int, int), bool> validatePosition) : Character(validatePosition)
    {
        public void HandleKeyInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.W: UpdateDirection(Directions.UP); break;
                case ConsoleKey.A: UpdateDirection(Directions.LEFT); break;
                case ConsoleKey.S: UpdateDirection(Directions.DOWN); break;
                case ConsoleKey.D: UpdateDirection(Directions.RIGHT); break;
                case ConsoleKey.UpArrow: UpdateDirection(Directions.UP); break;
                case ConsoleKey.LeftArrow: UpdateDirection(Directions.LEFT); break;
                case ConsoleKey.DownArrow: UpdateDirection(Directions.DOWN); break;
                case ConsoleKey.RightArrow: UpdateDirection(Directions.RIGHT); break;
            }
        }
    }
}
