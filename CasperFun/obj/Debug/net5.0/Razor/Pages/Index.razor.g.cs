#pragma checksum "/Users/room/Development/blazor/CasperFun/CasperFun/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aea72a5b16b8af074436e1a3f23a1e91dea5351f"
// <auto-generated/>
#pragma warning disable 1591
namespace CasperFun.Pages
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
#nullable restore
#line 17 "/Users/room/Development/blazor/CasperFun/CasperFun/_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Welcome to Casper Fun</h1>\n\n");
            __builder.OpenComponent<MudBlazor.MudText>(1);
            __builder.AddAttribute(2, "Class", "mb-8");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "Build on Casper.");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
            __builder.AddAttribute(7, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(8, "<h1>Hello</h1>");
            }
            ));
            __builder.AddAttribute(9, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "<h1>You\'re not signin</h1>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
