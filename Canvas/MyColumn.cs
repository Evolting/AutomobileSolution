using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    public class MyColumn
    {
        Point top;
        Point bottom;

        public Point Top { get => top; set => top = value; }
        public Point Bottom { get => bottom; set => bottom = value; }
    }
}
