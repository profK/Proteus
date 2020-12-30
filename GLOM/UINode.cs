using GLOM.Geometry;

namespace GLOM
{
    public interface UINode
    {
        Matrix Transformation { get; }
        Size PreferredSize { get; }
        Size MinSize { get; }
        Size Size { get;  }

        public void Layout(Point position, Size space);

        public void Render(Matrix parentMatrix);
    }
}