using System;
using Microsoft.AspNetCore.Mvc;
using TestWebAPI.Data;
using System.Threading.Tasks;
using TestWebAPI.models;

namespace TestWebAPI.controllers
{
    [ApiController]
    [Route("api/[controller]")]

  public class PessoaController : ControllerBase
  {

    private readonly IRepository _repo;
    public PessoaController(IRepository repo)
    {
      _repo = repo;
    }

    [HttpGet()]
    public async Task<IActionResult> Get() 
    {
      try
      {
        var result = await _repo.GetAllPessoasAsync(true);
        return Ok(result);
      }
      catch(Exception ex)
      {
        return BadRequest($"Erro: {ex.Message}");
      }
    }

        [HttpPost]
    public async Task<IActionResult> post(Pessoa model)
    {
      try
      {
        _repo.Add(model);
        if(await _repo.SaveChangesAsync())
        {
          return Ok(model);
        }
      }catch (Exception ex)
      {
        return BadRequest($"Erro: {ex.Message}");
      }
      return BadRequest();
    }
        [HttpPut("{IdPessoa}")]
    public async Task<IActionResult> put(int IdPessoa, Pessoa model)
    {
      try
      {
        var Pessoa = await _repo.GetPessoaAsyncById(IdPessoa, false);
        if(Pessoa == null) return NotFound("Pessoa não encontrado");

        _repo.Update(model);
        
        if(await _repo.SaveChangesAsync())
        {
          return Ok(model);
        }
      }catch (Exception ex)
      {
        return BadRequest($"Erro: {ex.Message}");
      }
      return BadRequest();
    }

        [HttpDelete("{IdPessoa}")]
    public async Task<IActionResult> delete(int IdPessoa)
    {
      try
      {
        var Pessoa = await _repo.GetPessoaAsyncById(IdPessoa);
        if(Pessoa == null) return NotFound();

        _repo.Delete(Pessoa);

        if(await _repo.SaveChangesAsync())
        {
          return Ok(new { message = "Pessoa Deletado" });
        }
      }catch (Exception ex)
      {
        return BadRequest($"Erro: {ex.Message}");
      }
      return BadRequest();
    }

  }
}