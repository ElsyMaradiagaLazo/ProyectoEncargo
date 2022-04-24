using Microsoft.AspNetCore.Components;
using Modelo;
using ProyectoEncargos.Interfaces;

namespace ProyectoEncargos.Pages.Envios
{
    partial class Envios
    {
        [Inject] private IEnvioServicio _envioServicio { get; set; }

        private IEnumerable<Envio> envioLista { get; set; }

        protected override async Task OnInitializedAsync()
        {
            envioLista = await _envioServicio.GetLista();
        }
    }
}
