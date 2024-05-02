namespace pac_man
{
    internal class Enemy : Character
    {
        public Enemy(Func<(int, int), bool> validatePosition) : base(validatePosition)
        {
            Pos = (15, 14);
        }

        protected void HandleAdditional()
        {
        }
    }
}
