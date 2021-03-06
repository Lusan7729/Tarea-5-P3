#pragma checksum "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\Pages\Consulta 8.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e56510a5aee06f991a91cb38164b4259510c2d18"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea_5.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Consulta8")]
    public partial class Consulta_8 : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<header><div class=""alert alert-secondary mt-4"" role=""alert""><center><b>Mostrar los suplidores y la cantidad de productos que suplen. Mostrarlos de mayor a menor, mostrando el codigo de suplidor, nombre y cantidad de productos que este suple.</b></center></div></header>

");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-bordered table-hover");
            __builder.AddAttribute(5, "id", "example");
            __builder.AddMarkupContent(6, "<thead class=\"thead-dark\"><tr><th>Código del Suplidor</th>\r\n                <th>Nombre</th>\r\n                <th>Cantidad de productos</th></tr></thead>\r\n        ");
            __builder.OpenElement(7, "tbody");
#nullable restore
#line 23 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\Pages\Consulta 8.razor"
             foreach (var Suppliers in db.Products
           .Where(p => !p.SupplierIds.Contains(";"))
           .Join(db.Suppliers, p => p.SupplierIds, s => s.Id.ToString(), (p, s) => new { Products = p, Suppliers = s })
           .AsEnumerable()
           .GroupBy(p => p.Products.SupplierIds)
           .Select(p => new
           {
               Code = p.Key,
               Name = $"{p.First().Suppliers.FirstName} {p.First().Suppliers.LastName}",
               Count = p.Count()
           })
           .OrderByDescending(p => p.Count)
           )
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "tr");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 38 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\Pages\Consulta 8.razor"
                         Suppliers.Code

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 39 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\Pages\Consulta 8.razor"
                         Suppliers.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 40 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\Pages\Consulta 8.razor"
                         Suppliers.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\Pages\Consulta 8.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Lusan\Desktop\ITLA QUINTO CUATRIMESTRE\Programación 3 - Amadis Suarez\Tarea 5\Pages\Consulta 8.razor"
      
    northwindContext db = new northwindContext();

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");
    }
    void IDisposable.Dispose()
    {
        JSRuntime.InvokeAsync<object>("TestDataTablesRemove", "#example");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
