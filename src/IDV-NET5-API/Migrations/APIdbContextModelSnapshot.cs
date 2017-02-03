using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using IDV_NET5_API.Models;

namespace IDVNET5API.Migrations
{
    [DbContext(typeof(APIdbContext))]
    partial class APIdbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IDV_NET5_API.Models.Entity.Asso_movie_version", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MoviesId");

                    b.Property<int>("VersionId");

                    b.HasKey("Id");

                    b.HasIndex("MoviesId");

                    b.HasIndex("VersionId");

                    b.ToTable("Asso_movie_version");
                });

            modelBuilder.Entity("IDV_NET5_API.Models.Entity.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DateOfPost");

                    b.Property<string>("Text");

                    b.Property<int>("VersionId");

                    b.HasKey("Id");

                    b.HasIndex("VersionId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("IDV_NET5_API.Models.Entity.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Actor_principal");

                    b.Property<string>("Description");

                    b.Property<int>("Rating");

                    b.Property<string>("Realisator");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("IDV_NET5_API.Models.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConfirmPassword");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("IDV_NET5_API.Models.Entity.Version", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Download_link");

                    b.Property<string>("Edition");

                    b.Property<string>("Language");

                    b.Property<string>("Quality");

                    b.Property<DateTime>("created_at");

                    b.HasKey("Id");

                    b.ToTable("Version");
                });

            modelBuilder.Entity("IDV_NET5_API.Models.Entity.Asso_movie_version", b =>
                {
                    b.HasOne("IDV_NET5_API.Models.Entity.Movie", "Movies")
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IDV_NET5_API.Models.Entity.Version", "Version")
                        .WithMany()
                        .HasForeignKey("VersionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IDV_NET5_API.Models.Entity.Comment", b =>
                {
                    b.HasOne("IDV_NET5_API.Models.Entity.Version", "Versions")
                        .WithMany("Comments")
                        .HasForeignKey("VersionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
