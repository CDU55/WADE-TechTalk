#pragma checksum "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbf16c091b4915fc7bfad390e57f0084db0f8794"
// <auto-generated/>
#pragma warning disable 1591
namespace WADE_TechTalkDemo.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatThemeProvider>(0);
            __builder.AddAttribute(1, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MatBlazor.MatTheme>(
#nullable restore
#line 2 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Pages\Index.razor"
                          indexTheme

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "mat-layout-grid");
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "mat-layout-grid-inner");
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "mat-layout-grid-cell mat-layout-grid-cell-span-12");
                __builder2.AddMarkupContent(12, "\r\n                ");
                __Blazor.WADE_TechTalkDemo.Pages.Index.TypeInference.CreateMatTable_0(__builder2, 13, 14, 
#nullable restore
#line 6 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Pages\Index.razor"
                                  items

#line default
#line hidden
#nullable disable
                , 15, 
#nullable restore
#line 6 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Pages\Index.razor"
                                                  true

#line default
#line hidden
#nullable disable
                , 16, "mat-elevation-z5", 17, 
#nullable restore
#line 6 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Pages\Index.razor"
                                                                                                   true

#line default
#line hidden
#nullable disable
                , 18, (__builder3) => {
                    __builder3.AddMarkupContent(19, "\r\n                        ");
                    __builder3.OpenComponent<MatBlazor.MatSortHeaderRow>(20);
                    __builder3.AddAttribute(21, "SortChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MatBlazor.MatSortChangedEvent>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MatBlazor.MatSortChangedEvent>(this, 
#nullable restore
#line 8 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Pages\Index.razor"
                                                        SortData

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(23, "\r\n                            ");
                        __builder4.OpenComponent<MatBlazor.MatSortHeader>(24);
                        __builder4.AddAttribute(25, "Style", "width: 75%");
                        __builder4.AddAttribute(26, "SortId", "PrefLabelEng");
                        __builder4.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(28, "ENG");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(29, "\r\n                            ");
                        __builder4.OpenComponent<MatBlazor.MatSortHeader>(30);
                        __builder4.AddAttribute(31, "Style", "width: 75%");
                        __builder4.AddAttribute(32, "SortId", "PrefLabelDe");
                        __builder4.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(34, "DE");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(35, "\r\n                            ");
                        __builder4.OpenComponent<MatBlazor.MatSortHeader>(36);
                        __builder4.AddAttribute(37, "SortId", "Resource");
                        __builder4.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(39, "Resource");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(40, "\r\n                            ");
                        __builder4.OpenComponent<MatBlazor.MatSortHeader>(41);
                        __builder4.AddAttribute(42, "SortId", "");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(43, "\r\n                        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\r\n                    ");
                }
                , 45, (context) => (__builder3) => {
                    __builder3.AddMarkupContent(46, "\r\n                        ");
                    __builder3.OpenElement(47, "td");
                    __builder3.AddContent(48, 
#nullable restore
#line 16 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Pages\Index.razor"
                             context.PrefLabelEng

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(49, "\r\n                        ");
                    __builder3.OpenElement(50, "td");
                    __builder3.AddContent(51, 
#nullable restore
#line 17 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Pages\Index.razor"
                             context.PrefLabelDe

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(52, "\r\n                        ");
                    __builder3.OpenElement(53, "td");
                    __builder3.OpenElement(54, "a");
                    __builder3.AddAttribute(55, "href", 
#nullable restore
#line 18 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Pages\Index.razor"
                                      context.Uri

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(56, "target", "_blank");
                    __builder3.AddContent(57, 
#nullable restore
#line 18 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Pages\Index.razor"
                                                                    context.Uri

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\r\n                        ");
                    __builder3.OpenElement(59, "td");
                    __builder3.OpenComponent<MatBlazor.MatButton>(60);
                    __builder3.AddAttribute(61, "Style", "text-align: center");
                    __builder3.AddAttribute(62, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Pages\Index.razor"
                                                                         MatIconNames.Play_arrow

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(63, "Label", "Details");
                    __builder3.AddAttribute(64, "Class", "btn btn-success");
                    __builder3.AddAttribute(65, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Pages\Index.razor"
                                                                                                                                                   ()=>GoToDetails(context.Uri)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(66, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Pages\Index.razor"
                                                                                                                                                                                         true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "\r\n                    ");
                }
                );
                __builder2.AddMarkupContent(68, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\claud\Desktop\Master\Anul2\Web\WADE-TechTalk\WADE-TechTalkDemo\WADE-TechTalkDemo\Pages\Index.razor"
 
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
namespace __Blazor.WADE_TechTalkDemo.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTable_0<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, System.Object __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg5)
        {
        __builder.OpenComponent<global::MatBlazor.MatTable<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Striped", __arg1);
        __builder.AddAttribute(__seq2, "class", __arg2);
        __builder.AddAttribute(__seq3, "UseSortHeaderRow", __arg3);
        __builder.AddAttribute(__seq4, "MatTableHeader", __arg4);
        __builder.AddAttribute(__seq5, "MatTableRow", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
