using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4.Models
{
    class Lab4Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<WorkoutEquipment> WorkoutEquipment { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<WorkoutExercise> WorkoutExercises { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Lab4DB;Trusted_Connection=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<WorkoutEquipment>(entity =>
            {
                entity.HasKey(e => new { e.WorkoutId, e.EquipmentId });

                entity.HasOne(d => d.Workout)
                    .WithMany(p => p.WorkoutEquipment)
                    .HasForeignKey(d => d.WorkoutId)
                    .HasConstraintName("FK_WorkoutEquipment_Workout");

                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.WorkoutEquipment)
                    .HasForeignKey(d => d.EquipmentId)
                    .HasConstraintName("FK_WorkoutEquipment_Equipment");
            });

            modelBuilder.Entity<WorkoutExercise>(entity =>
            {
                entity.HasKey(e => new { e.WorkoutId, e.ExerciseId });

                entity.HasOne(d => d.Workout)
                    .WithMany(p => p.WorkoutExercises)
                    .HasForeignKey(d => d.WorkoutId)
                    .HasConstraintName("FK_WorkoutExercise_Workout");

                entity.HasOne(d => d.Exercise)
                    .WithMany(p => p.WorkoutExercises)
                    .HasForeignKey(d => d.ExerciseId)
                    .HasConstraintName("FK_WorkoutExercise_Exercise");
            });

            modelBuilder.Entity<Exercise>()
                .Property(ex => ex.Name)
                .IsRequired();

            modelBuilder.Entity<Equipment>()
                .Property(eq => eq.Name)
                .IsRequired();

            modelBuilder.Entity<Workout>()
                .Property(w => w.Name)
                .IsRequired();

            modelBuilder.Entity<WorkoutExercise>()
                .Property(we => we.Strain)
                .HasDefaultValue(5);
        }
    }
}
