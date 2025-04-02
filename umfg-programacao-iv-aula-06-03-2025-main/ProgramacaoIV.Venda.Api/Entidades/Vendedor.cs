using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace ProgramacaoIV.Venda.Api.Entidades;

public sealed class Vendedor : AbstractEntity
{
    public int vendedor_id { get; set; } = 0;
    public string nome { get; set; } = string.Empty;
    public string email { get; set; } = string.Empty;
    public bool is_ativo { get; set; } = false;
    public DateTime dt_criacao { get; set; } = DateTime.Now;
    public DateTime dt_atualizacao { get; set; } = DateTime.Now;

    /// <summary>
    /// To EF Core
    /// </summary>
    private Vendedor() : base() { }

    public Vendedor(int id, string nome, string email, bool is_ativo, DateTime dt_criacao, DateTime dt_atualizacao)
    {
        vendedor_id = vendedor_id;
        nome = nome;
        email = email;
        is_ativo = is_ativo;
        dt_criacao = dt_criacao;
        dt_atualizacao = dt_atualizacao;

    }
}