using AutoMapper;

namespace SGM.ApplicationServices.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMAppings()
        {
            return new MapperConfiguration(x =>
            {
                x.AddProfile(new DomainViewModel());
                x.AddProfile(new ViewModelToDomain());
            });
        }
    }
}