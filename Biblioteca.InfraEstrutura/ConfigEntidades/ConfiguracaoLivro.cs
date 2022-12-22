using Bibliteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
