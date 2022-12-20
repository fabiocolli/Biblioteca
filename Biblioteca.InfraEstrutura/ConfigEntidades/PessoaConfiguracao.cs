using Bibliteca.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.Infra.Dados.ConfigEntidades
{
    public class PessoaConfiguracao: EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfiguracao()
        {
            HasKey(p => p.Id);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.SobreNome)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Nascimento)
                .IsRequired();
            
            Property(p => p.Email)
                .IsRequired();
        }
    }
}
