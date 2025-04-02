﻿using Org.BouncyCastle.Asn1.Ocsp;

namespace ProgramacaoIV.Venda.Api.Entidades;

public sealed class Transacao : AbstractEntity
{
    public Cliente Cliente { get; private set; }
    public ICollection<ItemTransacao> Itens { get; private set; } = new List<ItemTransacao>();
    public decimal Total => Itens.Sum(x => x.Total);

    public Vendedor Vendedor { get; set; } //Referencia a tabela Vendedor
    public int id_vendodor { get; set; } = 0; //Chave estrangeira do campo id da tabela vendedor

    /// <summary>
    /// To EF Core
    /// </summary>
    private Transacao() : base() { }

    public Transacao(Cliente cliente) => Cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));

    public void AdicionarItem(ItemTransacao item)
    {        
        Itens.Add(item);
        AtualizarDataAtualizacao();
    }

    public void RemoverItem(ItemTransacao item)
    {
        ArgumentNullException.ThrowIfNull(item, nameof(item));

        Itens.Remove(item);
        AtualizarDataAtualizacao();
    }
}