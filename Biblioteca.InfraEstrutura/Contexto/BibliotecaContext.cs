using Biblioteca.Infra.Dados.ConfigEntidades;
using Bibliteca.Dominio.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Biblioteca.Infra.Dados.Contexto
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext() : base("Data Source=FABIO_COLLI\\SQLEXPRESS01;Initial Catalog=Biblioteca;Integrated Security=True")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ConfiguracaoPessoa());
            modelBuilder.Configurations.Add(new ConfiguracaoLivro());
            modelBuilder.Configurations.Add(new ConfiguracaoItenEmprestado());
        }

        public override int SaveChanges()
        {
            foreach (var entrada in ChangeTracker.Entries().Where(entrada => entrada.Entity.GetType().GetProperty("DtCadastro") != null))
            {
                if (entrada.State == EntityState.Added)
                {
                    entrada.Property("DtCadastro").CurrentValue = DateTime.Now;
                }

                if (entrada.State == EntityState.Modified)
                {
                    entrada.Property("DtCadastro").IsModified = false;
                }
            }

            return base.SaveChanges();
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<ItemEmprestado> ItenEmprestados { get;set; }
    }
}
