using Bibliteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infra.Dados.ConfigEntidades
{
    internal class ConfiguracaoItenEmprestado : EntityTypeConfiguration<ItemEmprestado>
    {
        public ConfiguracaoItenEmprestado()
        {
            HasKey(ie => new { ie.IdPessoa, ie.IdLivro });

            Property(ie => ie.DtEmprestimo).IsRequired();

            HasRequired(ie => ie.Livro)
                .WithMany()
                .HasForeignKey(ie => ie.IdLivro);

            HasRequired(ie => ie.Pessoa)
                .WithMany()
                .HasForeignKey(ie => ie.IdPessoa);
        }
    }
}
