using Bibliteca.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.Infra.Dados.ConfigEntidades
{
    public class ConfiguracaoLivro : EntityTypeConfiguration<Livro>
    {
        public ConfiguracaoLivro()
        {
            HasKey(l => l.Id);

            Property(l => l.Titulo)
                .HasMaxLength(255)
                .IsRequired();

            Property(l => l.NomeAutor)
                .HasMaxLength(255)
                .IsRequired();

            Property(l => l.AnoLancamento)
                .IsRequired();
        }
    }
}
