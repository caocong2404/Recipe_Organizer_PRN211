using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Services.Models
{
    public partial class Recipe_Organizer_PRN211Context : DbContext
    {
        public Recipe_Organizer_PRN211Context()
        {
        }

        public Recipe_Organizer_PRN211Context(DbContextOptions<Recipe_Organizer_PRN211Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Day> Days { get; set; } = null!;
        public virtual DbSet<Feedback> Feedbacks { get; set; } = null!;
        public virtual DbSet<MealPlanning> MealPlannings { get; set; } = null!;
        public virtual DbSet<Recipe> Recipes { get; set; } = null!;
        public virtual DbSet<Session> Sessions { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:RecipeOrganizerDB"];
            return strConn;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.ParentCategoryId).HasColumnName("parent_category_id");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.HasMany(d => d.Recipes)
                    .WithMany(p => p.Categories)
                    .UsingEntity<Dictionary<string, object>>(
                        "RecipeHasCategory",
                        l => l.HasOne<Recipe>().WithMany().HasForeignKey("RecipeId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Recipe_has_Categories_Recipe"),
                        r => r.HasOne<Category>().WithMany().HasForeignKey("CategoryId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Recipe_has_Categories_Category"),
                        j =>
                        {
                            j.HasKey("CategoryId", "RecipeId");

                            j.ToTable("Recipe_has_Categories");

                            j.IndexerProperty<int>("CategoryId").HasColumnName("category_id");

                            j.IndexerProperty<int>("RecipeId").HasColumnName("recipe_id");
                        });
            });

            modelBuilder.Entity<Day>(entity =>
            {
                entity.ToTable("Day");

                entity.Property(e => e.DayId).HasColumnName("day_id");

                entity.Property(e => e.DayOfWeek)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("day_of_week");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Days)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Day_MealPlanning");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("Feedback");

                entity.Property(e => e.FeedbackId).HasColumnName("feedback_id");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_User");
            });

            modelBuilder.Entity<MealPlanning>(entity =>
            {
                entity.HasKey(e => e.PlanId);

                entity.ToTable("MealPlanning");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.WeekStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("week_start_date");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MealPlannings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MealPlanning_User");
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.ToTable("Recipe");

                entity.Property(e => e.RecipeId).HasColumnName("recipe_id");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Ingredient)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ingredient");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RecipesNavigation)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recipe_User");

                entity.HasMany(d => d.Users)
                    .WithMany(p => p.Recipes)
                    .UsingEntity<Dictionary<string, object>>(
                        "Collection",
                        l => l.HasOne<User>().WithMany().HasForeignKey("UserId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Collection_User"),
                        r => r.HasOne<Recipe>().WithMany().HasForeignKey("RecipeId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Collection_Recipe"),
                        j =>
                        {
                            j.HasKey("RecipeId", "UserId");

                            j.ToTable("Collection");

                            j.IndexerProperty<int>("RecipeId").HasColumnName("recipe_id");

                            j.IndexerProperty<int>("UserId").HasColumnName("user_id");
                        });
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.ToTable("Session");

                entity.Property(e => e.SessionId).HasColumnName("session_id");

                entity.Property(e => e.DayId).HasColumnName("day_id");

                entity.Property(e => e.SessionName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("session_name");

                entity.HasOne(d => d.Day)
                    .WithMany(p => p.Sessions)
                    .HasForeignKey(d => d.DayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Session_Day");

                entity.HasMany(d => d.Recipes)
                    .WithMany(p => p.Sessions)
                    .UsingEntity<Dictionary<string, object>>(
                        "SessionHasRecipe",
                        l => l.HasOne<Recipe>().WithMany().HasForeignKey("RecipeId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Session_has_Recipe_Recipe"),
                        r => r.HasOne<Session>().WithMany().HasForeignKey("SessionId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Session_has_Recipe_Session"),
                        j =>
                        {
                            j.HasKey("SessionId", "RecipeId");

                            j.ToTable("Session_has_Recipe");

                            j.IndexerProperty<int>("SessionId").HasColumnName("session_id");

                            j.IndexerProperty<int>("RecipeId").HasColumnName("recipe_id");
                        });
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Avater)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("avater");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("role");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
