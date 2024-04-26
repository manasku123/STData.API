using StudentData.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData.Repository.Contract
{
    public interface IStudentRepository
    {
        Task<Student> GetById(Guid id);
        Task GetList();
    }
}
