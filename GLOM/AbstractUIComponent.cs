﻿using GLOM.Geometry;

namespace GLOM
{
    public abstract class AbstractUIComponent:UINode
    {
        public Matrix Transformation { get; protected set; }
        public virtual Size PreferredSize { get; protected set; }
        public virtual Size MinSize { get; protected set; }
        public virtual Size Size { get; protected set; }
        
        public virtual void Layout(Point position, Size space)
        {
            Transformation = Transformation.AtPosition(position);
            Size = space;
        }

        public void Render(Matrix parentMatrix)
        {
            Matrix currentXform = parentMatrix.Multiply(Transformation);
            RenderLocal(currentXform);
        }

        public abstract void RenderLocal(Matrix localXform);
    }
}