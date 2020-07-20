#pragma checksum "C:\Blazor\BlazorApp\Pages\Functions.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b60f5711b520f76b6c679f4d6ed691fccdc027e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Blazor\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Blazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Blazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Blazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Blazor\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Blazor\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Blazor\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/functions")]
    public partial class Functions : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Azure Function Data</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from Azure Functions.</p>\r\n\r\n");
            __builder.OpenElement(2, "p");
            __builder.AddContent(3, "Status: ");
            __builder.AddContent(4, 
#nullable restore
#line 8 "C:\Blazor\BlazorApp\Pages\Functions.razor"
            message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
#nullable restore
#line 10 "C:\Blazor\BlazorApp\Pages\Functions.razor"
 if (message == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.AddMarkupContent(7, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "C:\Blazor\BlazorApp\Pages\Functions.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "   ");
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, "The message is: ");
            __builder.AddContent(11, 
#nullable restore
#line 16 "C:\Blazor\BlazorApp\Pages\Functions.razor"
                       message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 17 "C:\Blazor\BlazorApp\Pages\Functions.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Blazor\BlazorApp\Pages\Functions.razor"
            

    string message;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            message = await Http.GetStringAsync("https://furmfunctions.azurewebsites.net/api/HttpTrigger");
          
        }
        catch (HttpRequestException ex)
        {
            string strresult = ex.ToString();
            Console.WriteLine(ex.ToString());
        
        }


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
