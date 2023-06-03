using Microsoft.JSInterop;

namespace PPAI_IVR.Models
{
    public class PasooJSaC_
    {
        private readonly IJSRuntime _jsRuntime;

        public PasooJSaC_()
        {
        }

        public async Task<string> ObtenerOpcionSeleccionada()
        {
            string opcionSeleccionada = await _jsRuntime.InvokeAsync<string>("eval", "document.getElementById('miSelect').value");
            return opcionSeleccionada;
        }
    }
}
