namespace pac_man
{
    enum Directions { UP, DOWN, LEFT, RIGHT }
    internal class Player
    {
        private const int TELEPORT_ROW = 14;

        private (int x, int y) Pos = (1,1);
        private readonly Func<(int, int), bool> ValidatePosition;
        public Directions CurrentDirection { get; private set; }

        public Player(Func<(int, int), bool> validatePosition)
        {
            ValidatePosition = validatePosition;
        }

        public void UpdateDirection(Directions directions)
        {
            CurrentDirection = directions;
            // TODO check if direction is valid
        }

        public (int,int) Update()
        {
            (int x, int y) newPos = Pos;
            switch (CurrentDirection)
            {
                case Directions.UP: newPos.x--; break;
                case Directions.DOWN: newPos.x++; break;
                case Directions.LEFT: newPos.y--; break;
                case Directions.RIGHT: newPos.y++; break;
            }

            // special cases
            if (newPos == (TELEPORT_ROW, 28)) newPos = (TELEPORT_ROW, 0);
            if (newPos == (TELEPORT_ROW, -1)) newPos = (TELEPORT_ROW, 27);

            if (ValidatePosition.Invoke(newPos)) Pos = newPos;

            return Pos;
        }
    }
}
