using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Prueba_BlazorInvocarJSDesdeCSharp.Pages
{
    public partial class Index
    {
        bool confirmar;

        async Task EjecutarConfirm()
        {
            var confirmar = await js.InvokeAsync<bool>("confirm", "¿Quieres confirmarlo?");

            if (confirmar)
            {
                
            }
        }

        void Clickear()
        {
            Console.WriteLine("Me han ClicleaOH!!!");
        }
    }
}
