using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TestWebAPI.models;

namespace TestWebAPI.Data
{
  public class DataContext : DbContext
  {  
     public DataContext(DbContextOptions<DataContext> options) : base (options) { }        
        public DbSet<Pessoa> Pessoa { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Pessoa>()
                .HasData(new List<Pessoa>(){
                    new Pessoa(1, "106.723.510-80", "Jonas", "Montero", "Brasileiro", "18300-530", "São Paulo", "Capão Bonito", "Avenida Santos Dumont.", "Jonas@gmail.com", "3175-6848"),

                    new Pessoa(2, "198.454.220-63", "Kaique", "Fagundes", "Português", "88355-660", "Santa Catarina", "Brusque", "Rua Domingos Altair de Melo", "Kaique@protonmail.com", "3137-4428"),

                    new Pessoa(3, "922.696.940-07", "Sylas", "Lancaster", "Inglês", "68926-162", "Amapá", "Santana", "Rua D 14", "Sylas@protonmail.com", "2776-5574"),

                    new Pessoa(4, "268.320.060-98", "Isaya", "Otomano", "Inglês", "69303-037", "Roraima", "Boa Vista", "Rua Amajari", "Isaya@hotmail.com", "3836-3348"),

                    new Pessoa(5, "161.443.780-73", "Marlon", "Silva", "Brasileiro", "35302-405", "Minas Gerais", "Caratinga", "Rua Rubens Gomes", "Marlon@hotmail.com", "3071-0045"),
                });                      
        }
  }
}