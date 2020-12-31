using System.Collections.Generic;
using GLOM;
using GLOM.Geometry;
using Microsoft.JSInterop;

namespace Proteus.Core
{
    public class HTMLComponent:AbstractUIComponent
    {
        internal IJSObjectReference _domElement;
        internal Dictionary<string, string> _styleSettings = new Dictionary<string, string>();

        public HTMLComponent(string html)
        {
            _domElement = ProteusContext.JSInvoke<IJSObjectReference>(
                "Proteus.htmlToElement", html);
            float[] sza= ProteusContext.JSInvoke<float[]>(
                "Proteus.getElementSize", _domElement);
            Size size = new Size(sza[0], sza[1]);
            ProteusContext.Log(html);
            ProteusContext.Log("html size=" + size.ToString());
            NaturalSize = size;
            MinSize = NaturalSize;
     
        }
        
               
        public override void RenderLocal(Matrix localXform)
        {
            ProteusContext.Log("Render matrix=" + localXform.ToString());
            Point origin = localXform.TransformPoint(Point.Zero);
            //ProteusContext.JSInvokeVoid(
            //    "Proteus.setElementLayout",_domElement,origin.X,
            //    origin.Y,Size.Width,Size.Height);
            _styleSettings["position"] = "fixed";
            _styleSettings["left"] = origin.X + "px";
            _styleSettings["top"] = origin.Y + "px";
            _styleSettings["width"] = Size.Width+"px";
            _styleSettings["height"] = Size.Height + "px";
            ProteusContext.JSInvokeVoid(
                "Proteus.resetStyle",_domElement,_styleSettings);
        }
    }
}