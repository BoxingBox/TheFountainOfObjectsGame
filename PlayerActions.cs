using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFountainOfObjects 
{
    internal class PlayerActions : EnvironmentActions
    {
        public int _XCoordinate;
        public int _YCoordinate;

        public PlayerActions(int xCoordinate, int yCoordinate, int XMaxSize, int YMaxSize):base(0,2, XMaxSize, YMaxSize)
        {
            _XCoordinate = xCoordinate;
            _YCoordinate = yCoordinate;

        }



        public int moveUp(int _XCoordinate, int _YCoordinate)
        {
            _YCoordinate = _YCoordinate + 1;
            return _YCoordinate;


        }
        public int moveLeft(int _XCoordinate, int _YCoordinate)
        {
            _XCoordinate = _XCoordinate - 1;
            return _XCoordinate;
        }
        public int moveRight(int _XCoordinate, int _YCoordinate)
        {
            _XCoordinate = _XCoordinate + 1;
            return _XCoordinate;
        }
        public int moveDown(int _XCoordinate, int _YCoordinate)
        {
            _YCoordinate = _YCoordinate - 1;
            return _YCoordinate;

        }


    }
}
