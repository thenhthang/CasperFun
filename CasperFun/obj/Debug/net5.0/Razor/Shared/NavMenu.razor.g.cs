#pragma checksum "/Users/room/Development/blazor/CasperFun/CasperFun/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3b88cb1d9772885fd3b3b852549aaa61e764944"
// <auto-generated/>
#pragma warning disable 1591
namespace CasperFun.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/room/Development/blazor/CasperFun/CasperFun/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/room/Development/blazor/CasperFun/CasperFun/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/room/Development/blazor/CasperFun/CasperFun/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/room/Development/blazor/CasperFun/CasperFun/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/room/Development/blazor/CasperFun/CasperFun/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/room/Development/blazor/CasperFun/CasperFun/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/room/Development/blazor/CasperFun/CasperFun/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/room/Development/blazor/CasperFun/CasperFun/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/room/Development/blazor/CasperFun/CasperFun/_Imports.razor"
using CasperFun;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/room/Development/blazor/CasperFun/CasperFun/_Imports.razor"
using CasperFun.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/room/Development/blazor/CasperFun/CasperFun/_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/room/Development/blazor/CasperFun/CasperFun/_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/room/Development/blazor/CasperFun/CasperFun/_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/room/Development/blazor/CasperFun/CasperFun/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/room/Development/blazor/CasperFun/CasperFun/_Imports.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/room/Development/blazor/CasperFun/CasperFun/_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudNavMenu>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudNavLink>(2);
                __builder2.AddAttribute(3, "Href", "/dashboard");
                __builder2.AddAttribute(4, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 2 "/Users/room/Development/blazor/CasperFun/CasperFun/Shared/NavMenu.razor"
                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 2 "/Users/room/Development/blazor/CasperFun/CasperFun/Shared/NavMenu.razor"
                                                                  Icons.Material.Filled.Dashboard

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(7, "Dashboard");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(9);
                __builder2.AddAttribute(10, "Href", "/wallet");
                __builder2.AddAttribute(11, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 3 "/Users/room/Development/blazor/CasperFun/CasperFun/Shared/NavMenu.razor"
                                      NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "/Users/room/Development/blazor/CasperFun/CasperFun/Shared/NavMenu.razor"
                                                                  Icons.Material.Filled.Money

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(14, "My Wallet");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(16);
                __builder2.AddAttribute(17, "Href", "/invest");
                __builder2.AddAttribute(18, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 4 "/Users/room/Development/blazor/CasperFun/CasperFun/Shared/NavMenu.razor"
                                      NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "/Users/room/Development/blazor/CasperFun/CasperFun/Shared/NavMenu.razor"
                                                                  Icons.Material.Filled.LibraryAdd

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(21, "Invest");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(23);
                __builder2.AddAttribute(24, "Href", "/mintinglap");
                __builder2.AddAttribute(25, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 5 "/Users/room/Development/blazor/CasperFun/CasperFun/Shared/NavMenu.razor"
                                          NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "/Users/room/Development/blazor/CasperFun/CasperFun/Shared/NavMenu.razor"
                                                                      Icons.Material.Filled.DeveloperBoard

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(28, "Minting Lap");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591