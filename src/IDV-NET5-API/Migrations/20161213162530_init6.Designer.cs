using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using IDV_NET5_API.Models;

namespace IDVNET5API.Migrations
{
    [DbContext(typeof(APIdbContext))]
    [Migration("20161213162530_init6")]
    partial class init6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IDV_NET5_API.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DateOfPost");

                    b.Property<string>("Text");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("IDV_NET5_API.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CommentId");

                    b.Property<string>("Description");

                    b.Property<string>("Link");

                    b.Property<string>("Quality");

                    b.Property<string>("Title");

                    b.Property<string>("Version");

                    b.Property<float>("sizeFile");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("IDV_NET5_API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Firstname");

                    b.Property<string>("Lastname");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("IDV_NET5_API.Models.Comment", b =>
                {
                    b.HasOne("IDV_NET5_API.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("IDV_NET5_API.Models.Movie", b =>
                {
                    b.HasOne("IDV_NET5_API.Models.Comment", "Comment")
                        .WithMany()
                        .HasForeignKey("CommentId");
                });
        }
    }
}
