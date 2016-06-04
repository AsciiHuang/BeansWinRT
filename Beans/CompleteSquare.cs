using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beans
{
    public enum SquareContent
    {
        Empty,
        Monster,
        Hero,
        Wall
    };

    public class CompleteSquare
    {
        SquareContent _contentCode = SquareContent.Empty;
        public SquareContent ContentCode
        {
            get { return _contentCode; }
            set { _contentCode = value; }
        }

        int _distanceSteps = 10000;
        public int DistanceSteps
        {
            get { return _distanceSteps; }
            set { _distanceSteps = value; }
        }

        bool _isPath = false;
        public bool IsPath
        {
            get { return _isPath; }
            set { _isPath = value; }
        }
    }
}
