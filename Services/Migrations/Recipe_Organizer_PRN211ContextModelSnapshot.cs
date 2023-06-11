﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Services.Models;

#nullable disable

namespace Services.Migrations
{
    [DbContext(typeof(Recipe_Organizer_PRN211Context))]
    partial class Recipe_Organizer_PRN211ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Collection", b =>
                {
                    b.Property<int>("RecipeId")
                        .HasColumnType("int")
                        .HasColumnName("recipe_id");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("RecipeId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Collection", (string)null);
                });

            modelBuilder.Entity("RecipeHasCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int")
                        .HasColumnName("recipe_id");

                    b.HasKey("CategoryId", "RecipeId");

                    b.HasIndex("RecipeId");

                    b.ToTable("Recipe_has_Categories", (string)null);
                });

            modelBuilder.Entity("Services.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("description");

                    b.Property<int>("ParentCategoryId")
                        .HasColumnType("int")
                        .HasColumnName("parent_category_id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("title");

                    b.HasKey("CategoryId");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("Services.Models.Day", b =>
                {
                    b.Property<int>("DayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("day_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DayId"), 1L, 1);

                    b.Property<string>("DayOfWeek")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("day_of_week");

                    b.Property<int>("PlanId")
                        .HasColumnType("int")
                        .HasColumnName("plan_id");

                    b.HasKey("DayId");

                    b.HasIndex("PlanId");

                    b.ToTable("Day", (string)null);
                });

            modelBuilder.Entity("Services.Models.Feedback", b =>
                {
                    b.Property<int>("FeedbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("feedback_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeedbackId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime")
                        .HasColumnName("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("description");

                    b.Property<int?>("Rating")
                        .HasColumnType("int")
                        .HasColumnName("rating");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("title");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("FeedbackId");

                    b.HasIndex("UserId");

                    b.ToTable("Feedback", (string)null);
                });

            modelBuilder.Entity("Services.Models.MealPlanning", b =>
                {
                    b.Property<int>("PlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("plan_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlanId"), 1L, 1);

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<DateTime>("WeekStartDate")
                        .HasColumnType("datetime")
                        .HasColumnName("week_start_date");

                    b.HasKey("PlanId");

                    b.HasIndex("UserId");

                    b.ToTable("MealPlanning", (string)null);
                });

            modelBuilder.Entity("Services.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("recipe_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime")
                        .HasColumnName("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("description");

                    b.Property<string>("Ingredient")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("ingredient");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("title");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("RecipeId");

                    b.HasIndex("UserId");

                    b.ToTable("Recipe", (string)null);
                });

            modelBuilder.Entity("Services.Models.Session", b =>
                {
                    b.Property<int>("SessionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("session_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SessionId"), 1L, 1);

                    b.Property<int>("DayId")
                        .HasColumnType("int")
                        .HasColumnName("day_id");

                    b.Property<string>("SessionName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("session_name");

                    b.HasKey("SessionId");

                    b.HasIndex("DayId");

                    b.ToTable("Session", (string)null);
                });

            modelBuilder.Entity("Services.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Avatar")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("avater");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime")
                        .HasColumnName("birthday");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("password");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("role");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("status");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("username");

                    b.HasKey("UserId");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("SessionHasRecipe", b =>
                {
                    b.Property<int>("SessionId")
                        .HasColumnType("int")
                        .HasColumnName("session_id");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int")
                        .HasColumnName("recipe_id");

                    b.HasKey("SessionId", "RecipeId");

                    b.HasIndex("RecipeId");

                    b.ToTable("Session_has_Recipe", (string)null);
                });

            modelBuilder.Entity("Collection", b =>
                {
                    b.HasOne("Services.Models.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .IsRequired()
                        .HasConstraintName("FK_Collection_Recipe");

                    b.HasOne("Services.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Collection_User");
                });

            modelBuilder.Entity("RecipeHasCategory", b =>
                {
                    b.HasOne("Services.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("FK_Recipe_has_Categories_Category");

                    b.HasOne("Services.Models.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .IsRequired()
                        .HasConstraintName("FK_Recipe_has_Categories_Recipe");
                });

            modelBuilder.Entity("Services.Models.Day", b =>
                {
                    b.HasOne("Services.Models.MealPlanning", "Plan")
                        .WithMany("Days")
                        .HasForeignKey("PlanId")
                        .IsRequired()
                        .HasConstraintName("FK_Day_MealPlanning");

                    b.Navigation("Plan");
                });

            modelBuilder.Entity("Services.Models.Feedback", b =>
                {
                    b.HasOne("Services.Models.User", "User")
                        .WithMany("Feedbacks")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Feedback_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Services.Models.MealPlanning", b =>
                {
                    b.HasOne("Services.Models.User", "User")
                        .WithMany("MealPlannings")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_MealPlanning_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Services.Models.Recipe", b =>
                {
                    b.HasOne("Services.Models.User", "User")
                        .WithMany("RecipesNavigation")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Recipe_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Services.Models.Session", b =>
                {
                    b.HasOne("Services.Models.Day", "Day")
                        .WithMany("Sessions")
                        .HasForeignKey("DayId")
                        .IsRequired()
                        .HasConstraintName("FK_Session_Day");

                    b.Navigation("Day");
                });

            modelBuilder.Entity("SessionHasRecipe", b =>
                {
                    b.HasOne("Services.Models.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .IsRequired()
                        .HasConstraintName("FK_Session_has_Recipe_Recipe");

                    b.HasOne("Services.Models.Session", null)
                        .WithMany()
                        .HasForeignKey("SessionId")
                        .IsRequired()
                        .HasConstraintName("FK_Session_has_Recipe_Session");
                });

            modelBuilder.Entity("Services.Models.Day", b =>
                {
                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("Services.Models.MealPlanning", b =>
                {
                    b.Navigation("Days");
                });

            modelBuilder.Entity("Services.Models.User", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("MealPlannings");

                    b.Navigation("RecipesNavigation");
                });
#pragma warning restore 612, 618
        }
    }
}
