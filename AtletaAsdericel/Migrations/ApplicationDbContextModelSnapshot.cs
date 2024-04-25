﻿// <auto-generated />
using System;
using AtletaAsdericel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AtletaAsdericel.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AtletaAsdericel.Models.Associado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Apelido")
                        .HasColumnType("text");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DataExpedicao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("integer");

                    b.Property<int>("Ensino")
                        .HasColumnType("integer");

                    b.Property<int?>("EquipeId")
                        .HasColumnType("integer");

                    b.Property<int>("EstadoCivil")
                        .HasColumnType("integer");

                    b.Property<string>("Mae")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NomeSocial")
                        .HasColumnType("text");

                    b.Property<string>("NumeroSUS")
                        .HasColumnType("text");

                    b.Property<string>("OrgaoEmissor")
                        .HasColumnType("text");

                    b.Property<string>("Pai")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Passaporte")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Profissao")
                        .HasColumnType("text");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Sexo")
                        .HasColumnType("integer");

                    b.Property<string>("TipoDocumento")
                        .HasColumnType("text");

                    b.Property<int>("TipoSanguineo")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("EquipeId");

                    b.ToTable("Associado");
                });

            modelBuilder.Entity("AtletaAsdericel.Models.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cidades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Porto Velho"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Ariquemes"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Guajará-Mirim"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Ariquemes"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Ji-Parana"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Rolim Moura"
                        });
                });

            modelBuilder.Entity("AtletaAsdericel.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Localidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("AtletaAsdericel.Models.Equipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("EventoId")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ResultadoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.HasIndex("ResultadoId");

                    b.ToTable("Equipe");
                });

            modelBuilder.Entity("AtletaAsdericel.Models.Escola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("INEP")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Escolas");
                });

            modelBuilder.Entity("AtletaAsdericel.Models.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Estados");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Acre",
                            Sigla = "AC"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Alagoas",
                            Sigla = "AL"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Amapá",
                            Sigla = "AP"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Amazonas",
                            Sigla = "AM"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Bahia",
                            Sigla = "BA"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Ceará",
                            Sigla = "CE"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Distrito Federal",
                            Sigla = "DF"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "Espírito Santo",
                            Sigla = "ES"
                        },
                        new
                        {
                            Id = 9,
                            Nome = "Goiás",
                            Sigla = "GO"
                        },
                        new
                        {
                            Id = 10,
                            Nome = "Maranhão",
                            Sigla = "MA"
                        },
                        new
                        {
                            Id = 11,
                            Nome = "Mato Grosso",
                            Sigla = "MT"
                        },
                        new
                        {
                            Id = 12,
                            Nome = "Mato Grosso do Sul",
                            Sigla = "MS"
                        },
                        new
                        {
                            Id = 13,
                            Nome = "Minas Gerais",
                            Sigla = "MG"
                        },
                        new
                        {
                            Id = 14,
                            Nome = "Pará",
                            Sigla = "PA"
                        },
                        new
                        {
                            Id = 15,
                            Nome = "Paraíba",
                            Sigla = "PB"
                        },
                        new
                        {
                            Id = 16,
                            Nome = "Paraná",
                            Sigla = "PR"
                        },
                        new
                        {
                            Id = 17,
                            Nome = "Pernambuco",
                            Sigla = "PE"
                        },
                        new
                        {
                            Id = 18,
                            Nome = "Piauí",
                            Sigla = "PI"
                        },
                        new
                        {
                            Id = 19,
                            Nome = "Rio de Janeiro",
                            Sigla = "RJ"
                        },
                        new
                        {
                            Id = 20,
                            Nome = "Rio Grande do Norte",
                            Sigla = "RN"
                        },
                        new
                        {
                            Id = 21,
                            Nome = "Rio Grande do Sul",
                            Sigla = "RS"
                        },
                        new
                        {
                            Id = 22,
                            Nome = "Rondônia",
                            Sigla = "RO"
                        },
                        new
                        {
                            Id = 23,
                            Nome = "Roraima",
                            Sigla = "RR"
                        },
                        new
                        {
                            Id = 24,
                            Nome = "Santa Catarina",
                            Sigla = "SC"
                        },
                        new
                        {
                            Id = 25,
                            Nome = "São Paulo",
                            Sigla = "SP"
                        },
                        new
                        {
                            Id = 26,
                            Nome = "Sergipe",
                            Sigla = "SE"
                        },
                        new
                        {
                            Id = 27,
                            Nome = "Tocantins",
                            Sigla = "TO"
                        });
                });

            modelBuilder.Entity("AtletaAsdericel.Models.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DataTermino")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Edicao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Promocao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Evento");
                });

            modelBuilder.Entity("AtletaAsdericel.Models.Modalidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Categoria")
                        .HasColumnType("integer");

                    b.Property<int>("ModalidadePai")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Sexo")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Modalidades");
                });

            modelBuilder.Entity("AtletaAsdericel.Models.Prova", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ModalidadeId")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TipoProva")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ModalidadeId");

                    b.ToTable("Provas");
                });

            modelBuilder.Entity("AtletaAsdericel.Models.Responsavel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Parentesco")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Responsavel");
                });

            modelBuilder.Entity("AtletaAsdericel.Models.Resultado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Classificacao")
                        .HasColumnType("integer");

                    b.Property<int>("Gols")
                        .HasColumnType("integer");

                    b.Property<int>("Pontos")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Resultado");
                });

            modelBuilder.Entity("AtletaAsdericel.Models.Associado", b =>
                {
                    b.HasOne("AtletaAsdericel.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AtletaAsdericel.Models.Equipe", null)
                        .WithMany("Associados")
                        .HasForeignKey("EquipeId");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("AtletaAsdericel.Models.Equipe", b =>
                {
                    b.HasOne("AtletaAsdericel.Models.Evento", null)
                        .WithMany("Equipes")
                        .HasForeignKey("EventoId");

                    b.HasOne("AtletaAsdericel.Models.Resultado", "Resultado")
                        .WithMany()
                        .HasForeignKey("ResultadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resultado");
                });

            modelBuilder.Entity("AtletaAsdericel.Models.Prova", b =>
                {
                    b.HasOne("AtletaAsdericel.Models.Modalidade", "Modalidade")
                        .WithMany("Provas")
                        .HasForeignKey("ModalidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Modalidade");
                });

            modelBuilder.Entity("AtletaAsdericel.Models.Equipe", b =>
                {
                    b.Navigation("Associados");
                });

            modelBuilder.Entity("AtletaAsdericel.Models.Evento", b =>
                {
                    b.Navigation("Equipes");
                });

            modelBuilder.Entity("AtletaAsdericel.Models.Modalidade", b =>
                {
                    b.Navigation("Provas");
                });
#pragma warning restore 612, 618
        }
    }
}
