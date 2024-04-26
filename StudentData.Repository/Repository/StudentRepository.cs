using Microsoft.EntityFrameworkCore;
using StudentData.Entity.Models;
using StudentData.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData.Repository.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentMasterContext _dbContext;

        public StudentRepository(StudentMasterContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Student>> GetList()
        {
            List<Student> studentlist = new();
            try
            {
                studentlist = await _dbContext.Set<Student>().ToListAsync();
                return studentlist;
            }
            catch (Exception ex)
            {
                return studentlist;
            }
        }

        public async Task<Student> GetById(Guid id)
        {
            Student student = new();
            try
            {
                student = await _dbContext.Set<Student>().AsNoTracking()
                                           .Include(x => x.SheetMasters)
                                           .FirstOrDefaultAsync(e => e.StudentId == id);
                return student;
            }
            catch (Exception ex)
            {
                return student;
           }
        }

        Task IStudentRepository.GetList()
        {
            throw new NotImplementedException();
        }
    }
}

    