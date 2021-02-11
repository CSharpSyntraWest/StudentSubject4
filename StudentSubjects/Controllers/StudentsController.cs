using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSubjects.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public StudentsController(IRepositoryManager repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = _repository.Student.GetAllStudents(false);//query is sneller wanneer trackchanges af staat
            return Ok(students); //status OK = code 200       
        }


    }
}
