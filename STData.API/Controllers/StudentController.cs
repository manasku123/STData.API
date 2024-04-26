using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentData.Business.Business;
using IActionResult = StudentData.Business.Business.IActionResult;

namespace STData.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentBusiness _studentBusiness;
        public StudentController(IStudentBusiness StudentBusiness)
        {
            _studentBusiness = StudentBusiness;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _studentBusiness.GetList();

            if (!result.Any())
                return (IActionResult)BadRequest();

            return (IActionResult)Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromHeader] Guid id)
        {
            var result = await _studentBusiness.GetById(id);

            if (result == null)
                return (IActionResult)BadRequest();

            return (IActionResult)Ok(result);
        }
    }
}
    

