using System; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApplication.Models.Responses;
using TestApplication.Services;

namespace TestApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrolmentsController : ControllerBase
    {
        private readonly IEnrolmentService _enrolmentService;
        private readonly IMapper _mapper;

        public EnrolmentsController(IEnrolmentService enrolmentService, IMapper mapper)
        {
            _enrolmentService = enrolmentService;
            _mapper = mapper;
        }


        [HttpGet]
        public List<Enrolment> Get()
        {
            var enrolments = _enrolmentService.GetEnrolments();

            return _mapper.Map<List<Enrolment>>(enrolments); 
        }

        [HttpPost]
        public void Post()
        {

        }

        [HttpGet("{id}")]
        public void Get(int id)
        {

        }

        [HttpPut("{id}")]
        public void Put(int id)
        {

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}