using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beans
{
    public class Position
    {
        private int row = -1;
        private int column = -1;

        public static Position Empty
        {
            get
            {
                return new Position(-1, -1);
            }
        }

        public int Row
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
            }
        }

        public int Column
        {
            get
            {
                return column;
            }
            set
            {
                column = value;
            }
        }

        public int Y
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
            }
        }

        public int X
        {
            get
            {
                return column;
            }
            set
            {
                column = value;
            }
        }

        public Position()
        {
        }

        public Position(int r, int c)
        {
            row = r;
            column = c;
        }

        public Position(Position pos)
        {
            row = pos.row;
            column = pos.column;
        }
    }
}
