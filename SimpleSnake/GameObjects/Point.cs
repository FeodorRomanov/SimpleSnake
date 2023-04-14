﻿namespace SimpleSnake.GameObjects
{
    using System;

    public class Point
    {
        public Point(int leftX, int topY)
        {
            this.LeftX = leftX;
            this.TopY = topY;
        }





        public int LeftX { get; set; }   //LeftX is the starting point of the point vertical (-)

        public int TopY { get; set; }    //TopY is the starting point of the point horizontal (|)

        public void Draw(char symbol)
        {
            Console.SetCursorPosition(this.LeftX, this.TopY);
            Console.Write(symbol);
        }

        public void Draw(int leftX, int topY, char symbol)
        {
            Console.SetCursorPosition(leftX, topY);
            Console.Write(symbol);
        }
    }
}
