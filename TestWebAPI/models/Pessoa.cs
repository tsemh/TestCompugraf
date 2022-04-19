using System.Collections.Generic;

namespace TestWebAPI.models
{
  public class Pessoa
  {
    public Pessoa() {  }

    public Pessoa(int id, string cpf, string nome, string sobrenome, string nacionalidade, string cep, string estado, string cidade, string logradouro, string email, string telefone)
    {
      this.Id = id;
      this.CPF = cpf;
      this.Nome = nome;
      this.Sobrenome = sobrenome;
      this.Nacionalidade = nacionalidade;
      this.CEP = cep;
      this.Estado = estado;
      this.Cidade = cidade;
      this.Logradouro = logradouro;
      this.Email = email;
      this.Telefone = telefone;
    }
      public int Id { get; set; } 
      public string CPF { get; set; } 
      public string Nome { get; set; }
      public string Sobrenome { get; set; }
      public string Nacionalidade { get; set; }
      public string CEP { get; set; }
      public string Estado { get; set; }
      public string Cidade { get; set; }
      public string Logradouro { get; set; }
      public string Email { get; set; }
      public string Telefone { get; set; }

  }
}
