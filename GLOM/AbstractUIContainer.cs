using System;
using System.Collections.Generic;
using GLOM.Geometry;

namespace GLOM
{
    public abstract class AbstractUIContainer<TInfo>:AbstractUIComponent
    {
        public List<Tuple<UINode, TInfo>> Children = new List<Tuple<UINode, TInfo>>();
        public bool ExpandChildenHorizontally { get; set; }
        public bool ExpandChildrenVertically { get; set; }

        public virtual void Add(UINode child, TInfo layoutInfo = default(TInfo))
        {
            Children.Add(new Tuple<UINode, TInfo>(child,layoutInfo));
        }

        public virtual void Remove(UINode child)
        {
            foreach (var tuple in Children)
            {
                if (tuple.Item1 == child)
                {
                    Children.Remove(tuple);
                    return;
                }
            }
        }
        
        public override void RenderLocal(Matrix localXform)
        {
            foreach (var tuple in Children)
            {
                tuple.Item1.Render(localXform);
            }
        }
    }
}