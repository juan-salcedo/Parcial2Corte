// <auto-generated />
using DALL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DALL.Migrations
{
    [DbContext(typeof(context))]
    [Migration("20211027015155_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.Afiliado", b =>
                {
                    b.Property<string>("CodigoAfiliado")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EstadoAfiliado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaAfilacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaNacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodigoAfiliado");

                    b.ToTable("afiliados");
                });

            modelBuilder.Entity("Entity.LiquidacionIndividual", b =>
                {
                    b.Property<int>("CodigoLiquidacionIndividual")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoAfiliado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodigoLiquidacionMensual")
                        .HasColumnType("int");

                    b.Property<int>("DiaAfiliacion")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorLiquidacion")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CodigoLiquidacionIndividual");

                    b.ToTable("liquidacionIndividuals");
                });

            modelBuilder.Entity("Entity.LiquidacionMensual", b =>
                {
                    b.Property<int>("CodigoLiquidacionMensual")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Anioliquidar")
                        .HasColumnType("int");

                    b.Property<string>("IdAfiliado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MesLiquidar")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CodigoLiquidacionMensual");

                    b.ToTable("liquidacionMensual");
                });
#pragma warning restore 612, 618
        }
    }
}
