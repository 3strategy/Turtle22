﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.TurtleLib;

namespace Turtle22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Turtle t1 = new Turtle();

            //t1.MoveBackward(200);
            t1.SetDelay(200);
            t1.TailDown();

            t1.MoveForward(50);
            t1.TurnRight(90);
            t1.MoveForward(100);
            t1.TurnLeft(90);

            t1.MoveForward(50);
            t1.TurnRight(90);
            t1.MoveForward(100);
            t1.TurnLeft(90);
        }
    }
}
