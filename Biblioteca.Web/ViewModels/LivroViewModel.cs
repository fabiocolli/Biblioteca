using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Web.ViewModels
{
    public class LivroViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencher o Título!")]
        [MaxLength(255, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(10, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Título do Livro")]
        public string Titulo { get; set; }

        [Required(ErrorMessage ="Preecnha o ano de lançamento")]
        [DisplayName("Ano de Lançamento")]
        public int AnoLancamento { get; set; }

        [Required(ErrorMessage = "Preencher o Nome do Autor!")]
        [MaxLength(255, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(10, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Nome do Autor")]
        public string NomeAutor { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DtCadastro { get; set; }
        public virtual IEnumerable<ItemEmprestadoViewModel> ItemEmprestado { get; set; } = new List<ItemEmprestadoViewModel>();

    }
}
