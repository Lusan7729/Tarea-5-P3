#pragma checksum "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\Shared\SurveyPrompt.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76f8e6e4b6e1285cb35addde05d069a0a6edd69d"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea_5.Shared
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\_Imports.razor"
using Tarea_5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\_Imports.razor"
using Tarea_5.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\_Imports.razor"
using Tarea_5.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\_Imports.razor"
using System.Diagnostics.CodeAnalysis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    public partial class SurveyPrompt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 2 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\Shared\SurveyPrompt.razor"
       
    // Demonstrates how a parent component can supply parameters
    [Parameter]
    public string Title { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
