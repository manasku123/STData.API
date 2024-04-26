
using StudentData.ViewModels.ViewModels;

namespace StudentData.Business.Business
{
    public interface IStudentBusiness
    {
        Task<List<StudentModel>> GetList();
        Task<StudentModel> GetById(Guid id);//Task GetList();
    }
}