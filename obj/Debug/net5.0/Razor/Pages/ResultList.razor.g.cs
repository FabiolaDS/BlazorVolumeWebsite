#pragma checksum "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\Pages\ResultList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "335f7a47d157f2077cf1eea79b33a87f5c6ea71f"
// <auto-generated/>
#pragma warning disable 1591
namespace VolumeWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\_Imports.razor"
using VolumeWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\_Imports.razor"
using VolumeWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\Pages\ResultList.razor"
using VolumeWeb.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/resultList")]
    public partial class ResultList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ResultList</h3>");
#nullable restore
#line 5 "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\Pages\ResultList.razor"
  if (_results == null)
 {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p> loading ...</p>");
#nullable restore
#line 8 "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\Pages\ResultList.razor"
 }

 else
 {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.OpenElement(3, "tbody");
#nullable restore
#line 14 "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\Pages\ResultList.razor"
          foreach (var result in _results)
         {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "tr");
            __builder.OpenElement(5, "td");
            __builder.AddContent(6, 
#nullable restore
#line 17 "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\Pages\ResultList.razor"
                      result.Type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n                 \r\n                 ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 19 "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\Pages\ResultList.razor"
                      result.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                 ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 20 "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\Pages\ResultList.razor"
                      result.Radius

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                 ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 21 "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\Pages\ResultList.razor"
                      result.Volume

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\Pages\ResultList.razor"
         }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\Pages\ResultList.razor"
 }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Privat\Desktop\DNP1\DNP1exam285055\VolumeWeb\Pages\ResultList.razor"
       

    private List<VolumeResult> _results;

    protected override async Task OnInitializedAsync()
    {
        _results = await _service.GetAllAsync();
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CalculatorService _service { get; set; }
    }
}
#pragma warning restore 1591
