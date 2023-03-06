

using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
      public List<Professor> Professores = new List<Professor> {
        new Professor(){
          Id = 1,
          Nome = "Samuel",
        },
        new Professor(){
          Id = 2,
          Nome = "Tiago",
        },
        new Professor(){
          Id = 3,
          Nome = "Wagner",
        },
      }; 
      public ProfessorController() {}
      
      [HttpGet]
      public IActionResult Get()
      {
        return Ok(Professores);
      }
      
    }
}