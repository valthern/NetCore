#pragma checksum "C:\Users\imartinez\source\ejemplos\net5\Ejercicio_Imagenes\Ejercicio_Imagenes\Shared\Img.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dab6eda340d0e3d26855a5ee0d9774687c8d6c3d"
// <auto-generated/>
#pragma warning disable 1591
namespace Ejercicio_Imagenes.Shared
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
    public partial class Img : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\imartinez\source\ejemplos\net5\Ejercicio_Imagenes\Ejercicio_Imagenes\Shared\Img.razor"
 if (string.IsNullOrWhiteSpace(UrlImagen))
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<img src=\"interrogacion.gif\">");
#nullable restore
#line 4 "C:\Users\imartinez\source\ejemplos\net5\Ejercicio_Imagenes\Ejercicio_Imagenes\Shared\Img.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "img");
            __builder.AddAttribute(2, "src", 
#nullable restore
#line 7 "C:\Users\imartinez\source\ejemplos\net5\Ejercicio_Imagenes\Ejercicio_Imagenes\Shared\Img.razor"
               UrlImagen

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 8 "C:\Users\imartinez\source\ejemplos\net5\Ejercicio_Imagenes\Ejercicio_Imagenes\Shared\Img.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\imartinez\source\ejemplos\net5\Ejercicio_Imagenes\Ejercicio_Imagenes\Shared\Img.razor"
       
    [Parameter] public string UrlImagen { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
