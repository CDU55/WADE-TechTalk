#pragma checksum "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3c90c5c2836664bf2857b9d8f00ce7c6a69a28c"
// <auto-generated/>
#pragma warning disable 1591
namespace WADE_TechTalkDemo.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\_Imports.razor"
using WADE_TechTalkDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\_Imports.razor"
using WADE_TechTalkDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<WADE_TechTalkDemo.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "content px-4");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddContent(12, 
#nullable restore
#line 10 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
