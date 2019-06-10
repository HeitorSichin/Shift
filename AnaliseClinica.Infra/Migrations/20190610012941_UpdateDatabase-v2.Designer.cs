﻿// <auto-generated />
using System;
using AnaliseClinica.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnaliseClinica.Infra.Migrations
{
    [DbContext(typeof(AnaliseClinicaContext))]
    [Migration("20190610012941_UpdateDatabase-v2")]
    partial class UpdateDatabasev2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AnaliseClinica.Domain.Entities.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("char(2)")
                        .HasMaxLength(2);

                    b.HasKey("Id");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("AnaliseClinica.Domain.Entities.Convenio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Convenio");
                });

            modelBuilder.Entity("AnaliseClinica.Domain.Entities.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("CidadeId");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("AnaliseClinica.Domain.Entities.Especialidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Especialidade");
                });

            modelBuilder.Entity("AnaliseClinica.Domain.Entities.Exame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("MaterialBiologico")
                        .IsRequired()
                        .HasColumnType("varchar(300)")
                        .HasMaxLength(300);

                    b.Property<int>("Prazo")
                        .HasColumnType("int");

                    b.Property<int?>("SetorId");

                    b.HasKey("Id");

                    b.HasIndex("SetorId");

                    b.ToTable("Exame");
                });

            modelBuilder.Entity("AnaliseClinica.Domain.Entities.ExamePreco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ConvenioId");

                    b.Property<int?>("ExameId");

                    b.Property<decimal>("Preco")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("ConvenioId");

                    b.HasIndex("ExameId");

                    b.ToTable("ExamePreco");
                });

            modelBuilder.Entity("AnaliseClinica.Domain.Entities.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EspecialidadeId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("EspecialidadeId");

                    b.ToTable("Medico");
                });

            modelBuilder.Entity("AnaliseClinica.Domain.Entities.OrdemServico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ConvenioId");

                    b.Property<DateTime>("Data")
                        .HasColumnType("date");

                    b.Property<int?>("MedicoId");

                    b.Property<int?>("PacienteId");

                    b.Property<int?>("PostoColetaId");

                    b.HasKey("Id");

                    b.HasIndex("ConvenioId");

                    b.HasIndex("MedicoId");

                    b.HasIndex("PacienteId");

                    b.HasIndex("PostoColetaId");

                    b.ToTable("OrdemServico");
                });

            modelBuilder.Entity("AnaliseClinica.Domain.Entities.OrdemServicoExame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EntregaResultado")
                        .HasColumnType("datetime");

                    b.Property<int?>("ExameId");

                    b.Property<int?>("OrdemServicoId");

                    b.Property<decimal>("Preco")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("ExameId");

                    b.HasIndex("OrdemServicoId");

                    b.ToTable("OrdemServicoExame");
                });

            modelBuilder.Entity("AnaliseClinica.Domain.Entities.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EnderecoId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("char(1)")
                        .HasMaxLength(2);

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("AnaliseClinica.Domain.Entities.PostoColeta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("EnderecoId");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("PostoColeta");
                });

            modelBuilder.Entity("AnaliseClinica.Domain.Entities.Setor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Setor");
                });

            modelBuilder.Entity("AnaliseClinica.Domain.Entities.Endereco", b =>
                {
                    b.HasOne("AnaliseClinica.Domain.Entities.Cidade", "Cidade")
                        .WithMany("Enderecos")
                        .HasForeignKey("CidadeId");
                });

            modelBuilder.Entity("AnaliseClinica.Domain.Entities.Exame", b =>
                {
                    b.HasOne("AnaliseClinica.Domain.Entities.Setor", "Setor")
                        .WithMany("Exames")
                        .HasForeignKey("SetorId");
                });

            modelBuilder.Entity("AnaliseClinica.Domain.Entities.ExamePreco", b =>
                {
                    b.HasOne("AnaliseClinica.Domain.Entities.Convenio", "Convenio")
                        .WithMany("ExamePrecos")
                        .HasForeignKey("ConvenioId");

                    b.HasOne("AnaliseClinica.Domain.Entities.Exame", "Exame")
                        .WithMany("ExamePrecos")
                        .HasForeignKey("ExameId");
                });

            modelBuilder.Entity("AnaliseClinica.Domain.Entities.Medico", b =>
                {
                    b.HasOne("AnaliseClinica.Domain.Entities.Especialidade", "Especialidade")
                        .WithMany("Medicos")
                        .HasForeignKey("EspecialidadeId");
                });

            modelBuilder.Entity("AnaliseClinica.Domain.Entities.OrdemServico", b =>
                {
                    b.HasOne("AnaliseClinica.Domain.Entities.Convenio", "Convenio")
                        .WithMany("OrdemServicos")
                        .HasForeignKey("ConvenioId");

                    b.HasOne("AnaliseClinica.Domain.Entities.Medico", "Medico")
                        .WithMany("OrdemServicos")
                        .HasForeignKey("MedicoId");

                    b.HasOne("AnaliseClinica.Domain.Entities.Paciente", "Paciente")
                        .WithMany("OrdemServicos")
                        .HasForeignKey("PacienteId");

                    b.HasOne("AnaliseClinica.Domain.Entities.PostoColeta", "PostoColeta")
                        .WithMany("OrdemServicos")
                        .HasForeignKey("PostoColetaId");
                });

            modelBuilder.Entity("AnaliseClinica.Domain.Entities.OrdemServicoExame", b =>
                {
                    b.HasOne("AnaliseClinica.Domain.Entities.Exame", "Exame")
                        .WithMany("OrdemServicoExames")
                        .HasForeignKey("ExameId");

                    b.HasOne("AnaliseClinica.Domain.Entities.OrdemServico", "OrdemServico")
                        .WithMany("OrdemServicoExames")
                        .HasForeignKey("OrdemServicoId");
                });

            modelBuilder.Entity("AnaliseClinica.Domain.Entities.Paciente", b =>
                {
                    b.HasOne("AnaliseClinica.Domain.Entities.Endereco", "Endereco")
                        .WithMany("Pacientes")
                        .HasForeignKey("EnderecoId");
                });

            modelBuilder.Entity("AnaliseClinica.Domain.Entities.PostoColeta", b =>
                {
                    b.HasOne("AnaliseClinica.Domain.Entities.Endereco", "Endereco")
                        .WithMany("PostoColetas")
                        .HasForeignKey("EnderecoId");
                });
#pragma warning restore 612, 618
        }
    }
}
