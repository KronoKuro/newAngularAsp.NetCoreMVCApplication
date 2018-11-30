﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieReviewSpa.Data;

namespace MovieReviewSpa.Data.Migrations
{
    [DbContext(typeof(MovieReviewDbContext))]
    [Migration("20181126095446_change_in_modle")]
    partial class change_in_modle
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieReviewSpa.Model.Movie", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DirectorName");

                    b.Property<string>("MovieName");

                    b.Property<string>("ReleaseYear");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MovieReviewSpa.Model.MovieReview", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MovieId");

                    b.Property<string>("ReviewComments");

                    b.Property<string>("ReviewName");

                    b.Property<int>("ReviewerRating");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieReviews");
                });

            modelBuilder.Entity("MovieReviewSpa.Model.MovieReview", b =>
                {
                    b.HasOne("MovieReviewSpa.Model.Movie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieId");
                });
#pragma warning restore 612, 618
        }
    }
}
