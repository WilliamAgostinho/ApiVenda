using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgramacaoIV.Venda.Api.Entidades;

namespace ProgramacaoIV.Venda.Api.Map;

public sealed class VendedorMap : AbstractEntidadeMap<Vendedor>
{
    public override void Configure(EntityTypeBuilder<Vendedor> builder)
    {
        base.Configure(builder);

        builder.ToTable("VENDEDOR");

        builder.Property(x => x.vendedor_id).HasColumnName("VENDEDOR_ID").HasMaxLength(100).IsRequired();
        builder.Property(x => x.nome).HasColumnName("NOME").HasMaxLength(100).IsRequired();
        builder.Property(x => x.email).HasColumnName("EMAIL").HasMaxLength(200).IsRequired(false);
        builder.Property(x => x.is_ativo).HasColumnName("IS_ATIVO").HasMaxLength(1).IsRequired();
        builder.Property(x => x.dt_criacao).HasColumnName("DT_CADASTRO").HasColumnType("datetime").IsRequired();
        builder.Property(x => x.dt_criacao).HasColumnName("DT_ATUALIZACAO").HasColumnType("datetime").IsRequired();
    }
}