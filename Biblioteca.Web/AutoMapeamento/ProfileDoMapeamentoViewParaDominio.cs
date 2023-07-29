using AutoMapper;
using Biblioteca.Web.ViewModels;
using Bibliteca.Dominio.Entidades;

namespace Biblioteca.Web.AutoMapeamento
{
    public class ProfileDoMapeamentoViewParaDominio : Profile
    {
        public ProfileDoMapeamentoViewParaDominio()
        {
            CreateMap<LivroViewModel, Livro>();
            CreateMap<PessoaViewModel, Pessoa>();
            CreateMap<ItemEmprestadoViewModel, ItemEmprestado>();
        }
        public override string ProfileName => "ProfileDoMapeamentoDominioParaView";

    }
}
