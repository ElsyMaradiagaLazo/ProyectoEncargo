using Microsoft.AspNetCore.Components;
using Modelo;
using ProyectoEncargos.Interfaces;

namespace ProyectoEncargos.Pages.Usuarios
{
    partial class Usuarios
    {
        [Inject] private IUsuarioServicio _usuarioServicio { get; set; }

        private IEnumerable<Usuario> usuariosLista { get; set; }

        protected override async Task OnInitializedAsync()
        {
            usuariosLista = await _usuarioServicio.GetLista();
        }
    }
}
