// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
