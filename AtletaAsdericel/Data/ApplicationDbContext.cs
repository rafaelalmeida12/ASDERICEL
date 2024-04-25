using AtletaAsdericel.Models;
using Microsoft.EntityFrameworkCore;

namespace AtletaAsdericel.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
         : base(options)
        {
        }

        public DbSet<Associado> Associado { get; set; }
        public DbSet<Dirigente> Dirigente { get; set; }
        public DbSet<Atleta> Atleta { get; set; }
        public DbSet<Modalidade> Modalidades { get; set; }
        public DbSet<Escola> Escolas { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Prova> Provas { get; set; }
        public DbSet<Responsavel> Responsavel { get; set; }
        public DbSet<Evento> Evento { get; set; }

        //public DbSet<ModalidadeAtleta> ModalidadesAtletas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cidade>().HasData(
                new Cidade { Id = 1, Nome = "Porto Velho" },
                new Cidade { Id = 2, Nome = "Ariquemes" },
                new Cidade { Id = 3, Nome = "Guajará-Mirim" },
                new Cidade { Id = 4, Nome = "Ariquemes" },
                new Cidade { Id = 5, Nome = "Ji-Parana" },
                new Cidade { Id = 6, Nome = "Rolim Moura" }
                );

            modelBuilder.Entity<Estado>().HasData(
               new Estado { Id = 1, Nome = "Acre", Sigla = "AC" },
               new Estado { Id = 2, Nome = "Alagoas", Sigla = "AL" },
               new Estado { Id = 3, Nome = "Amapá", Sigla = "AP" },
               new Estado { Id = 4, Nome = "Amazonas", Sigla = "AM" },
               new Estado { Id = 5, Nome = "Bahia", Sigla = "BA" },
               new Estado { Id = 6, Nome = "Ceará", Sigla = "CE" },
               new Estado { Id = 7, Nome = "Distrito Federal", Sigla = "DF" },
               new Estado { Id = 8, Nome = "Espírito Santo", Sigla = "ES" },
               new Estado { Id = 9, Nome = "Goiás", Sigla = "GO" },
               new Estado { Id = 10, Nome = "Maranhão", Sigla = "MA" },
               new Estado { Id = 11, Nome = "Mato Grosso", Sigla = "MT" },
               new Estado { Id = 12, Nome = "Mato Grosso do Sul", Sigla = "MS" },
               new Estado { Id = 13, Nome = "Minas Gerais", Sigla = "MG" },
               new Estado { Id = 14, Nome = "Pará", Sigla = "PA" },
               new Estado { Id = 15, Nome = "Paraíba", Sigla = "PB" },
               new Estado { Id = 16, Nome = "Paraná", Sigla = "PR" },
               new Estado { Id = 17, Nome = "Pernambuco", Sigla = "PE" },
               new Estado { Id = 18, Nome = "Piauí", Sigla = "PI" },
               new Estado { Id = 19, Nome = "Rio de Janeiro", Sigla = "RJ" },
               new Estado { Id = 20, Nome = "Rio Grande do Norte", Sigla = "RN" },
               new Estado { Id = 21, Nome = "Rio Grande do Sul", Sigla = "RS" },
               new Estado { Id = 22, Nome = "Rondônia", Sigla = "RO" },
               new Estado { Id = 23, Nome = "Roraima", Sigla = "RR" },
               new Estado { Id = 24, Nome = "Santa Catarina", Sigla = "SC" },
               new Estado { Id = 25, Nome = "São Paulo", Sigla = "SP" },
               new Estado { Id = 26, Nome = "Sergipe", Sigla = "SE" },
               new Estado { Id = 27, Nome = "Tocantins", Sigla = "TO" }
           );

            base.OnModelCreating(modelBuilder);
        }
        public void EnsureSeedData()
        {
            if (!Cidades.Any())
            {
                // Adicione as cidades de Rondônia aqui
                var cidadesRondonia = new List<Cidade>
            {
                new Cidade { Nome = "Porto Velho" },
                new Cidade { Nome = "Ariquemes" },
                // Adicione mais cidades conforme necessário
            };

                Cidades.AddRange(cidadesRondonia);
                SaveChanges();
            }

        }
    }
}
