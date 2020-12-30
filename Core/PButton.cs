using System;
using Microsoft.JSInterop;

namespace Proteus.Core
{
    public class PButton:HTMLComponent
    {
        private DotNetObjectReference<PButton> objRefFromJS;
        public event Action<PButton> OnClick;
        public PButton(string text) : base(MakeHTML(text))
        {
            objRefFromJS = DotNetObjectReference.Create(this);
            ProteusContext.JSInvokeVoid("Proteus.attachOnClick",
                _domElement,objRefFromJS,"OnClickReceiver");
        }

        private static string MakeHTML(string text)
        {
            return "<button>" + text + "</button>";
        }

        [JSInvokable]
        public void OnClickReceiver()
        {
           OnClick?.Invoke(this);
        }
    }
}