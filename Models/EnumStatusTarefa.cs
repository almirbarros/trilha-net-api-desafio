using System.ComponentModel;

namespace TrilhaApiDesafio.Models
{
    public enum EnumStatusTarefa
    {
        [Description("To Do")]
        Fazer,
        [Description("Doing")]
        Fazendo,
        [Description("Done")]
        Finalizado
    }
}