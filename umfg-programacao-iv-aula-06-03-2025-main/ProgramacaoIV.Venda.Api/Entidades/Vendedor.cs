using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace ProgramacaoIV.Venda.Api.Entidades;

public sealed class Vendedor : AbstractEntity
{
   
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// To EF Core
    /// </summary>
    public Vendedor() : base() { }

    public Vendedor(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }
}