//using StructureMap;
using AutoMapper;
using StudentData.Entity.Models;
using StudentData.ViewModels.ViewModels;

namespace StudentData.Repository.Common
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Student, StudentModel>().ForMember(dest => dest.StudentSheet, opt => opt.MapFrom(src => src.SheetMasters));
            CreateMap<Student, StudentModel>().ForMember(dest => dest.StudentSheet, opt => opt.MapFrom(src => src.SheetMasters)).ReverseMap();

            CreateMap<SheetMaster, SheetModel>();
            CreateMap<SheetMaster, SheetModel>().ReverseMap();
        }

    //    private object CreateMap<T1, T2>()
      //  {
        //    throw new NotImplementedException();
       // }
    }
}
