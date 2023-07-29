using AutoMapper;
using Biblioteca.Web.ViewModels;
using Bibliteca.Dominio.Entidades;

namespace Biblioteca.Web.AutoMapeamento
{
    public class ProfileDoMapeamentoDominioParaView : Profile
    {
        public ProfileDoMapeamentoDominioParaView()
        {
            CreateMap<Livro, LivroViewModel>();
            CreateMap<Pessoa, PessoaViewModel>();
            CreateMap<ItemEmprestado, ItemEmprestadoViewModel>();
        }
        public override string ProfileName => "ProfileDoMapeamentoViewParaDominio";

    }
}
