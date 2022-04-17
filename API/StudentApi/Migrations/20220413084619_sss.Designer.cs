﻿// <auto-generated />
using BeginProject.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeginProject.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20220413084619_sss")]
    partial class sss
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BeginProject.Data.Entities.Classroom", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Classrooms");
                });

            modelBuilder.Entity("BeginProject.Data.Entities.Group", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("BeginProject.Data.Entities.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GroupID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("BeginProject.Data.Entities.StudentClassroom", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("ClassroomID")
                        .HasColumnType("int");

                    b.HasKey("StudentID", "ClassroomID");

                    b.HasIndex("ClassroomID");

                    b.ToTable("StudentClassrooms");
                });

            modelBuilder.Entity("BeginProject.Data.Entities.StudentTeacher", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.HasKey("StudentID", "TeacherID");

                    b.HasIndex("TeacherID");

                    b.ToTable("StudentTeachers");
                });

            modelBuilder.Entity("BeginProject.Data.Entities.Teacher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("BeginProject.Data.Entities.Student", b =>
                {
                    b.HasOne("BeginProject.Data.Entities.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("BeginProject.Data.Entities.StudentClassroom", b =>
                {
                    b.HasOne("BeginProject.Data.Entities.Classroom", "Classroom")
                        .WithMany("StudentClassrooms")
                        .HasForeignKey("ClassroomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeginProject.Data.Entities.Student", "Student")
                        .WithMany("StudentClassrooms")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classroom");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("BeginProject.Data.Entities.StudentTeacher", b =>
                {
                    b.HasOne("BeginProject.Data.Entities.Student", "Student")
                        .WithMany("StudentTeachers")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeginProject.Data.Entities.Teacher", "Teacher")
                        .WithMany("StudentTeachers")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("BeginProject.Data.Entities.Classroom", b =>
                {
                    b.Navigation("StudentClassrooms");
                });

            modelBuilder.Entity("BeginProject.Data.Entities.Group", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("BeginProject.Data.Entities.Student", b =>
                {
                    b.Navigation("StudentClassrooms");

                    b.Navigation("StudentTeachers");
                });

            modelBuilder.Entity("BeginProject.Data.Entities.Teacher", b =>
                {
                    b.Navigation("StudentTeachers");
                });
#pragma warning restore 612, 618
        }
    }
}