// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Proteus
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jeffp\OneDrive\Documents\Workspaces\Proteus\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jeffp\OneDrive\Documents\Workspaces\Proteus\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jeffp\OneDrive\Documents\Workspaces\Proteus\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jeffp\OneDrive\Documents\Workspaces\Proteus\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jeffp\OneDrive\Documents\Workspaces\Proteus\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jeffp\OneDrive\Documents\Workspaces\Proteus\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jeffp\OneDrive\Documents\Workspaces\Proteus\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jeffp\OneDrive\Documents\Workspaces\Proteus\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jeffp\OneDrive\Documents\Workspaces\Proteus\_Imports.razor"
using Proteus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\jeffp\OneDrive\Documents\Workspaces\Proteus\App.razor"
using System.Drawing.Drawing2D;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jeffp\OneDrive\Documents\Workspaces\Proteus\App.razor"
using System.Numerics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jeffp\OneDrive\Documents\Workspaces\Proteus\App.razor"
using System.Security.Cryptography;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jeffp\OneDrive\Documents\Workspaces\Proteus\App.razor"
using Proteus.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jeffp\OneDrive\Documents\Workspaces\Proteus\App.razor"
using GLOM.Geometry;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\jeffp\OneDrive\Documents\Workspaces\Proteus\App.razor"
       

    protected override void OnInitialized()
    {
        ProteusContext.SetRuntime(jsRuntime);
        PLabel label1 = new PLabel("One");
        PLabel label2 = new PLabel("TwoTwoTwo");
        label2.BackgroundColor = 0x00000FFFF;
        PLabel label3= new PLabel("Three");
        PButton buttontest = new PButton("click me");
        PVerticalLayout hl =
            new PVerticalLayout();
        hl.Add(label1);
        hl.Add(label2);
        hl.Add(label3);
        hl.Add(buttontest);
        buttontest.OnClick += button => { ProteusContext.Log("Clicked "+button.ToString()); };
        hl.Layout( new Point(0, 0), new Size(1024, 800));
        hl.Render(new Matrix(Matrix4x4.Identity));
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSInProcessRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
