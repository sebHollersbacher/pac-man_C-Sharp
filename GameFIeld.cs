﻿namespace pac_man
{
    internal class GameField
    {
        private const int Offset = 3;

        private readonly char[][] StartField = {
            ['▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒'],
            ['▒','·','·','·','·','·','·','·','·','·','·','·','·','▒','▒','·','·','·','·','·','·','·','·','·','·','·','·','▒'],
            ['▒','·','▒','▒','▒','▒','·','▒','▒','▒','▒','▒','·','▒','▒','·','▒','▒','▒','▒','▒','·','▒','▒','▒','▒','·','▒'],
            ['▒','·','▒','▒','▒','▒','·','▒','▒','▒','▒','▒','·','▒','▒','·','▒','▒','▒','▒','▒','·','▒','▒','▒','▒','·','▒'],
            ['▒','·','▒','▒','▒','▒','·','▒','▒','▒','▒','▒','·','▒','▒','·','▒','▒','▒','▒','▒','·','▒','▒','▒','▒','·','▒'],
            ['▒','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','▒'],
            ['▒','·','▒','▒','▒','▒','·','▒','▒','·','▒','▒','▒','▒','▒','▒','▒','▒','·','▒','▒','·','▒','▒','▒','▒','·','▒'],
            ['▒','·','▒','▒','▒','▒','·','▒','▒','·','▒','▒','▒','▒','▒','▒','▒','▒','·','▒','▒','·','▒','▒','▒','▒','·','▒'],
            ['▒','·','·','·','·','·','·','▒','▒','·','·','·','·','▒','▒','·','·','·','·','▒','▒','·','·','·','·','·','·','▒'],
            ['▒','▒','▒','▒','▒','▒','·','▒','▒','▒','▒','▒',' ','▒','▒',' ','▒','▒','▒','▒','▒','·','▒','▒','▒','▒','▒','▒'],
            [' ',' ',' ',' ',' ','▒','·','▒','▒','▒','▒','▒',' ','▒','▒',' ','▒','▒','▒','▒','▒','·','▒',' ',' ',' ',' ',' '],
            [' ',' ',' ',' ',' ','▒','·','▒','▒',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','▒','▒','·','▒',' ',' ',' ',' ',' '],
            [' ',' ',' ',' ',' ','▒','·','▒','▒',' ','▒','▒','▒',' ',' ','▒','▒','▒',' ','▒','▒','·','▒',' ',' ',' ',' ',' '],
            ['▒','▒','▒','▒','▒','▒','·','▒','▒',' ','▒',' ',' ',' ',' ',' ',' ','▒',' ','▒','▒','·','▒','▒','▒','▒','▒','▒'],
            [' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','▒',' ',' ',' ',' ',' ',' ','▒',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '],
            ['▒','▒','▒','▒','▒','▒','·','▒','▒',' ','▒',' ',' ',' ',' ',' ',' ','▒',' ','▒','▒','·','▒','▒','▒','▒','▒','▒'],
            [' ',' ',' ',' ',' ','▒','·','▒','▒',' ','▒','▒','▒','▒','▒','▒','▒','▒',' ','▒','▒','·','▒',' ',' ',' ',' ',' '],
            [' ',' ',' ',' ',' ','▒','·','▒','▒',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','▒','▒','·','▒',' ',' ',' ',' ',' '],
            ['▒','▒','▒','▒','▒','▒','·','▒','▒',' ','▒','▒','▒','▒','▒','▒','▒','▒',' ','▒','▒','·','▒','▒','▒','▒','▒','▒'],
            ['▒','·','·','·','·','·','·','·','·','·','·','·','·','▒','▒','·','·','·','·','·','·','·','·','·','·','·','·','▒'],
            ['▒','·','▒','▒','▒','▒','·','▒','▒','▒','▒','▒','·','▒','▒','·','▒','▒','▒','▒','▒','·','▒','▒','▒','▒','·','▒'],
            ['▒','·','▒','▒','▒','▒','·','▒','▒','▒','▒','▒','·','▒','▒','·','▒','▒','▒','▒','▒','·','▒','▒','▒','▒','·','▒'],
            ['▒','·','·','·','▒','▒','·','·','·','·','·','·','·',' ',' ','·','·','·','·','·','·','·','▒','▒','·','·','·','▒'],
            ['▒','▒','▒','·','▒','▒','·','▒','▒','·','▒','▒','▒','▒','▒','▒','▒','▒','·','▒','▒','·','▒','▒','·','▒','▒','▒'],
            ['▒','▒','▒','·','▒','▒','·','▒','▒','·','▒','▒','▒','▒','▒','▒','▒','▒','·','▒','▒','·','▒','▒','·','▒','▒','▒'],
            ['▒','·','·','·','·','·','·','▒','▒','·','·','·','·','▒','▒','·','·','·','·','▒','▒','·','·','·','·','·','·','▒'],
            ['▒','·','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','·','▒','▒','·','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','·','▒'],
            ['▒','·','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','·','▒','▒','·','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','·','▒'],
            ['▒','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','·','▒'],
            ['▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒','▒']
        };

        public int Width { get; }
        public int Height { get; }

        private char[][] Field;

        public GameField()
        {
            Field = StartField;
            Height = Field.GetLength(0);
            Width = Field[0].GetLength(0);
        }

        public void UpdateCharacterPos((int x, int y) newPos, char Character)
        {
            Console.SetCursorPosition(newPos.y, newPos.x + Offset);
            Console.Write(Character);
            Console.SetCursorPosition(0, 0);
        }

        public bool ValidPosition((int x, int y) pos)
        {
            if (pos.x < 0 || Height <= pos.x) return false;
            if (pos.y < 0 || Width <= pos.y) return false;

            char c = Field[pos.x][pos.y];
            return c is ' ' or '·';
        }

        public bool ConsumeToken((int x, int y) pos)
        {
            if (pos.x < 0 || Height <= pos.x) return false;
            if (pos.y < 0 || Width <= pos.y) return false;

            char c = Field[pos.x][pos.y];
            if (c == '·') { Field[pos.x][pos.y] = ' '; return true; }
            return false;
        }

        public void Redraw()
        {
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(0, i + Offset);
                Console.Write(Field[i]);
                Console.SetCursorPosition(0, 0);
            }
        }
    }
}
