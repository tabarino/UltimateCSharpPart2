using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public class Canvas
    {
        public void DrawShapes(List<PolyShape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
