using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Modelo;
using ProyectoEncargos.Interfaces;

namespace ProyectoEncargos.Pages.Envios
{
    partial class NuevoEnvio
    {
        [Inject] private IEnvioServicio usuarioServicio { get; set; }
        [Inject] private NavigationManager navigationManager { get; set; }
        [Inject] SweetAlertService Swal { get; set; }

        private Envio ship = new Envio();

        protected async Task Guardar()
        {
            if (string.IsNullOrEmpty(ship.CodigoEnvio) || string.IsNullOrEmpty(ship.Remitente) || string.IsNullOrEmpty(ship.Descripcion))
            {
                return;
            }

            bool inserto = await usuarioServicio.Nuevo(ship);
            if (inserto)
            {
                await Swal.FireAsync("Felicidades!", "Se ha realizado su orden de envio.", SweetAlertIcon.Success);
            }
            else
            {
                await Swal.FireAsync("Error!!", "No se pudo realizar su orden.", SweetAlertIcon.Error);
            }
            navigationManager.NavigateTo("/Envios");

        }

        protected async Task Cancelar()
        {
            navigationManager.NavigateTo("/Envios");
        }
    }
}

