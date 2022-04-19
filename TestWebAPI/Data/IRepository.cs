using System.Threading.Tasks;
using TestWebAPI.models;

namespace TestWebAPI.Data
{
   public interface IRepository 
   {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();     
        Task<Pessoa[]> GetAllPessoasAsync(bool includeFuncionario = true);
        Task<Pessoa> GetPessoaAsyncById(int IdPessoa,  bool includeFuncionario = true);

   }
}