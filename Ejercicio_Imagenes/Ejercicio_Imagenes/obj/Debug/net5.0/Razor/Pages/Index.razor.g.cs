#pragma checksum "C:\Users\imartinez\source\ejemplos\net5\Ejercicio_Imagenes\Ejercicio_Imagenes\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "537ecf58f584e5cdbdd6fe2bf228e08af18e1da1"
// <auto-generated/>
#pragma warning disable 1591
namespace Ejercicio_Imagenes.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\imartinez\source\ejemplos\net5\Ejercicio_Imagenes\Ejercicio_Imagenes\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\imartinez\source\ejemplos\net5\Ejercicio_Imagenes\Ejercicio_Imagenes\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\imartinez\source\ejemplos\net5\Ejercicio_Imagenes\Ejercicio_Imagenes\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\imartinez\source\ejemplos\net5\Ejercicio_Imagenes\Ejercicio_Imagenes\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\imartinez\source\ejemplos\net5\Ejercicio_Imagenes\Ejercicio_Imagenes\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\imartinez\source\ejemplos\net5\Ejercicio_Imagenes\Ejercicio_Imagenes\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\imartinez\source\ejemplos\net5\Ejercicio_Imagenes\Ejercicio_Imagenes\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\imartinez\source\ejemplos\net5\Ejercicio_Imagenes\Ejercicio_Imagenes\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\imartinez\source\ejemplos\net5\Ejercicio_Imagenes\Ejercicio_Imagenes\_Imports.razor"
using Ejercicio_Imagenes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\imartinez\source\ejemplos\net5\Ejercicio_Imagenes\Ejercicio_Imagenes\_Imports.razor"
using Ejercicio_Imagenes.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Ejercicio de im??genes!</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<label for=\"txtImg\">Url de la im??gen:</label>\r\n");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\imartinez\source\ejemplos\net5\Ejercicio_Imagenes\Ejercicio_Imagenes\Pages\Index.razor"
              UrlImagen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UrlImagen = __value, UrlImagen));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n<br>\r\n");
            __builder.OpenComponent<Ejercicio_Imagenes.Shared.Img>(6);
            __builder.AddAttribute(7, "UrlImagen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\imartinez\source\ejemplos\net5\Ejercicio_Imagenes\Ejercicio_Imagenes\Pages\Index.razor"
                 UrlImagen

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\imartinez\source\ejemplos\net5\Ejercicio_Imagenes\Ejercicio_Imagenes\Pages\Index.razor"
      
    public string UrlImagen { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
