

using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno> {
        new Aluno(){
          Id = 1,
          Nome = "Samuel",
          Sobrenome = "Coelho",
          Telefone = "31996422397",
        },
        new Aluno(){
          Id = 2,
          Nome = "Tiago",
          Sobrenome = "Brito",
          Telefone = "3195898568",
        },
        new Aluno(){
          Id = 3,
          Nome = "Wagner",
          Sobrenome = "Antunes",
          Telefone = "31998745685",
        },
      }; 
      public AlunoController() {}
      
      [HttpGet]
      public IActionResult Get()
      {
        return Ok(Alunos);
      }
       
      // Api/Aluno/id
      // ("{id:int}") para diferenciar o HttpGet caso tenha que buscar por outro tipo além de string!
      // ("byId") também funciona > A rota fica Api/Aluno/byId?id=1
      [HttpGet("{id:int}")]
      public IActionResult GetById(int id)
      {
        var aluno = Alunos.FirstOrDefault(a => a.Id == id);
        if(aluno == null){
            return BadRequest("Aluno não encontrado!");
        } else {
            return Ok(aluno);
        }        
      }

      // Api/Aluno/nome
      // Padrão de HTTPGET é string!
      // [HttpGet("{nome}")]
      // A rota fica Api/Aluno/byName?nome=Samuel&sobrenome=Coelho
      [HttpGet("ByName")]
      public IActionResult GetByName(string nome, string sobrenome)
      {
        var aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome));
        if(aluno == null){
            return BadRequest("Aluno não encontrado!");
        } else {
            return Ok(aluno);
        }        
      }

      [HttpPost]
      public IActionResult Post(Aluno aluno)
      {    
        return Ok(aluno);          
      }

      [HttpPut("{id}")]
      public IActionResult Put(int id, Aluno aluno)
      {      
        return Ok(aluno);       
      }

      [HttpPatch("{id}")]
      public IActionResult Patch(int id, Aluno aluno)
      {      
        return Ok(aluno);       
      }
      
      [HttpPut("{id}")]
      public IActionResult Delete(int id)
      {      
        return Ok();       
      }
    }
}