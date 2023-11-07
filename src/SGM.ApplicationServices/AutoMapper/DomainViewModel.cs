using AutoMapper;
using SGM.ApplicationServices.ViewModels;
using SGM.Domain.Entities;

namespace SGM.ApplicationServices.AutoMapper
{
    public class DomainViewModel : Profile
    {
        public DomainViewModel()
        {
            CreateMap<Cliente, CLienteViewModel>();
        }
    }
}