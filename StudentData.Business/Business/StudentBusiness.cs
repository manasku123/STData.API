using AutoMapper;
using StudentData.Repository.Contract;
using StudentData.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData.Business.Business
{
    public class StudentBusiness : IStudentBusiness
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;
        public StudentBusiness(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<List<StudentModel>> GetList()
        {
            List<StudentModel> studentList = new();

            var result = await _studentRepository.GetList();

            studentList = _mapper.Map<List<StudentModel>>(result);
            return studentList;
        }

        public async Task<StudentModel> GetById(Guid id)
        {
            StudentModel studentData = new();

            var result = await _studentRepository.GetById(id);

            studentData = _mapper.Map<StudentModel>(result);
            return studentData;
        }
    }
}