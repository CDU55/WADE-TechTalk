#pragma checksum "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2202d6d47d7f7179ba57f26c58d2f37b9353290d"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatThemeProvider>(0);
            __builder.AddAttribute(1, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MatBlazor.MatTheme>(
#nullable restore
#line 1 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Shared\NavMenu.razor"
                          indexTheme

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n\r\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "top-row pl-4 navbar navbar-dark");
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.AddMarkupContent(7, "<a class=\"navbar-brand\" href>WADE-TechTalkDemo</a>\r\n        ");
                __builder2.OpenElement(8, "button");
                __builder2.AddAttribute(9, "class", "navbar-toggler");
                __builder2.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Shared\NavMenu.razor"
                                                 ToggleNavMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(11, "\r\n            <span class=\"navbar-toggler-icon\"></span>\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n\r\n    ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", 
#nullable restore
#line 10 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Shared\NavMenu.razor"
                 NavMenuCssClass

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Shared\NavMenu.razor"
                                            ToggleNavMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenElement(18, "ul");
                __builder2.AddAttribute(19, "class", "nav flex-column");
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.OpenElement(21, "li");
                __builder2.AddAttribute(22, "class", "nav-item px-3");
                __builder2.AddMarkupContent(23, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
                __builder2.AddAttribute(25, "class", "nav-link");
                __builder2.AddAttribute(26, "href", "");
                __builder2.AddAttribute(27, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 13 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Shared\NavMenu.razor"
                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(29, "\r\n                    <span class=\"oi oi-home\" aria-hidden=\"true\"></span> All\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Shared\NavMenu.razor"
           
        private bool collapseNavMenu = true;

        private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }
        MatTheme indexTheme = new MatTheme()
        {
            Primary = "#00897b",
            Secondary = "#283593",
        };
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591