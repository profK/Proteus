using GLOM;
using GLOM.Geometry;
using Microsoft.JSInterop;

namespace Proteus
{
    public class HTMLComponent:AbstractUIComponent
    {
        private IJSObjectReference _domElement;

        public HTMLComponent(string html)
        {
            _domElement = ProteusContext.JSInvoke<IJSObjectReference>(
                "Proteus.htmlToElement", html);
            float[] sz= ProteusContext.JSInvoke<float[]>(
                "Proteus.getElementSize", _domElement);
            PreferredSize = new Size(sz[0], sz[1]);
            MinSize = PreferredSize;
        }
        
       
        public override void RenderLocal(Matrix localXform)
        {
            Point origin = localXform.TransformPoint(Point.Zero);
            ProteusContext.JSInvokeVoid(
                "Proteus.setElementLayout",_domElement,origin.X,
                origin.Y,Size.Width,Size.Height);
        }
    }
}