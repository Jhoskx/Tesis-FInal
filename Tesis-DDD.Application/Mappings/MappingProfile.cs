using Api_DDD.Domain;
using AutoMapper;
using Tesis_DDD.Application.Features.UseCase.Queries;
using Tesis_DDD.Application.Models.ViewModels;

namespace Tesis_DDD.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            var @types = new Dictionary<Type, Type>
            {
                { typeof(Project), typeof(ProjectVm) },
                { typeof(Resource), typeof(ResourceVm) },
                { typeof(useCase), typeof(UseCaseVm) },
           
            };

           

            //CreateMap<Quotation, QuotationVm>()
            //    .ForMember(dest => dest.QuotationId, opts => opts.MapFrom(src => src.Id))
            //    .ForMember(dest => dest.IdentificationTypeName, opts => opts.MapFrom(src => src.IdentificationType.Value))
            //    .ForMember(dest => dest.DepartmentName, opts => opts.MapFrom(src => src.Department.Value))
            //    .ForMember(dest => dest.MunicipalityName, opts => opts.MapFrom(src => src.Municipality.Value))
            //    .ForMember(dest => dest.MachineryTypeName, opts => opts.MapFrom(src => src.MachineryType.Name))
            //    .ForMember(dest => dest.PowerName, opts => opts.MapFrom(src => src.Power.Name))
            //    .ForMember(dest => dest.PowerName, opts => opts.MapFrom(src => src.Campus.Name));

            RegisterQueryMapings(@types);
            RegisterCommandMapings(@types);
        }

        private void RegisterQueryMapings(Dictionary<Type, Type> @types)
        {
            foreach (var @type in @types)
                CreateMap(@type.Key, type.Value);
        }

        private void RegisterCommandMapings(Dictionary<Type, Type> @types)
        {
            foreach (var @type in @types)
                CreateMap(@type.Value, type.Key);
        }
    }
}
