namespace Proteus.Core
{
    public struct Insets
    {
        public float Top;
        public float Right;
        public float Bottom;
        public float Left;

        public Insets(float top, float right, float bottom, float left)
        {
            Top = top;
            Right = right;
            Bottom = bottom;
            Left = left;
        }
    }
    public class PWindow:HTMLComponent
    {
        
        public PWindow(string borderImageURL, Insets insets) : base(MakeHTML())
        {
            _styleSettings["border-image"] = "url('" + borderImageURL + "')";
            _styleSettings["border-image-slice"] =
                insets.Top.ToString() + " " + insets.Right.ToString() + " " +
                insets.Bottom.ToString() + " " + insets.Left.ToString();
            
        }

        private static string MakeHTML()
        {
            return "<dialog open></dialog>";
        }
    }
}