using System.Threading.Tasks;
using System.Linq;
using TestWebAPI.models;
using Microsoft.EntityFrameworkCore;

namespace TestWebAPI.Data
{
  public class Repository : IRepository
  {
    private readonly DataContext _context;

    public Repository(DataContext context)
    {
      _context = context;
    }
    public void Add<T>(T entity) where T : class
    {
      _context.Add(entity);
    }
    public void Update<T>(T entity) where T : class
    {
      _context.Update(entity);
    }
    public void Delete<T>(T entity) where T : class
    {
      _context.Remove(entity);
    }
    public async Task<bool> SaveChangesAsync()
    {
      return (await _context.SaveChangesAsync()) > 0;
    }

    public async Task<Pessoa[]> GetAllPessoasAsync(bool includeFuncionario = true)
    {
      IQueryable<Pessoa> query = _context.Pessoa;

      query = query.AsNoTracking()
                   .OrderBy(Pessoa => Pessoa.Id);

      return await query.ToArrayAsync();
    }
        public async Task<Pessoa> GetPessoaAsyncById(int IdPessoa, bool includeFuncionario = true)
    {
      IQueryable<Pessoa> query = _context.Pessoa;

      query = query.AsNoTracking()
                   .OrderBy(Pessoa => Pessoa.Id)
                   .Where(Pessoa => Pessoa.Id == IdPessoa);
      return await query.FirstOrDefaultAsync();
    }
  }
}
