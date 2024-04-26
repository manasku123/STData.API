using StudentData.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData.Business.Contract
{
    public interface IStudentBusiness
    {
        Task<List<StudentModel>> GetList();
        Task<StudentModel> GetById(Guid id);
    }
}
