﻿namespace comparacoes_com_hash.Entities
{
    struct Point // tipo valor
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y) : this() 
        { 
            X = x; 
            Y = y; 
        }
    }
}
