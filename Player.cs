namespace pac_man
{
    enum Directions { UP, DOWN, LEFT, RIGHT }
    internal class Player
    {
        private GameField field;
        private (int x, int y) Pos = (1,1);
        public Directions CurrentDirection { get; private set; }

        public Player(GameField field)
        {
            this.field = field;
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
                case Directions.UP: newPos.y--; break;
                case Directions.DOWN: newPos.y++; break;
                case Directions.LEFT: newPos.x--; break;
                case Directions.RIGHT: newPos.x++; break;
            }

            // special cases
            if (newPos == (28,14)) newPos = (0,14);
            if (newPos == (-1, 14)) newPos = (27, 14);

            // TODO make call better
            if (field.ValidPosition(newPos)) Pos = newPos;

            return Pos;
        }
    }
}
