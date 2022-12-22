using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Web.ViewModels
{
    public class PessoaViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencher o nome!")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencher o sobrenome!")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "Preencher o E-mail!")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um e-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Preencha a data de nascimento")]
        [DataType(DataType. Date)]
        [DisplayName("Data de Nascimento")]
        public DateTime Nascimento { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DtCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual IEnumerable<ItemEmprestadoViewModel> ItemEmprestados { get; set; } = new List<ItemEmprestadoViewModel>();
    }
}
