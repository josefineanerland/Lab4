using System;
using System.Collections.Generic;
using System.Text;

namespace ITHS_DB_Lab4
{
    class AddData
    {
        public static void AddUsers()
        {
            using (var context = new Models.Lab4Context())
            {
                Models.User user1 = new Models.User();
                user1.Firstname = "Josefine";
                user1.Lastname = "Anerland";
                Models.User user2 = new Models.User();
                user2.Firstname = "Lukas";
                user2.Lastname = "Lindahl";
                Models.User user3 = new Models.User();
                user3.Firstname = "Malin";
                user3.Lastname = "Alm";
                Models.User user4 = new Models.User();
                user4.Firstname = "Robert";
                user4.Lastname = "Alm";

                context.Add(user1);
                context.Add(user2);
                context.Add(user3);
                context.Add(user4);

                context.SaveChanges();
            }
        }
        public static void AddExercises()
        {
            using (var context = new Models.Lab4Context())
            {
                Models.Exercise ex1 = new Models.Exercise();
                ex1.Name = "Cykling";
                Models.Exercise ex2 = new Models.Exercise();
                ex2.Name = "Löpning";
                Models.Exercise ex3 = new Models.Exercise();
                ex3.Name = "Rodd";
                Models.Exercise ex4 = new Models.Exercise();
                ex4.Name = "Trappa";
                Models.Exercise ex5 = new Models.Exercise();
                ex5.Name = "Crosstrainer";
                Models.Exercise ex6 = new Models.Exercise();
                ex6.Name = "Bänkpress";

                context.Add(ex1);
                context.Add(ex2);
                context.Add(ex3);
                context.Add(ex4);
                context.Add(ex5);
                context.Add(ex6);

                context.SaveChanges();
            }

        }
        public static void AddEquipment()
        {
            using (var context = new Models.Lab4Context())
            {
                Models.Equipment eq1 = new Models.Equipment();
                eq1.Name = "Cykel";
                Models.Equipment eq2 = new Models.Equipment();
                eq2.Name = "Löpband";
                Models.Equipment eq3 = new Models.Equipment();
                eq3.Name = "Roddmaskin";
                Models.Equipment eq4 = new Models.Equipment();
                eq4.Name = "Trappmaskin";
                Models.Equipment eq5 = new Models.Equipment();
                eq5.Name = "Crosstrainer";
                Models.Equipment eq6 = new Models.Equipment();
                eq6.Name = "Bänkpress";

                context.Add(eq1);
                context.Add(eq2);
                context.Add(eq3);
                context.Add(eq4);
                context.Add(eq5);
                context.Add(eq6);

                context.SaveChanges();
            }

        }
        public static void AddWorkouts()
        {
            using (var context = new Models.Lab4Context())
            {
                Models.Workout w1 = new Models.Workout();
                w1.UserId = 1;
                w1.Name = "Cykling 2019-10-10";
                w1.Description = "5km cykling";
                w1.Time = TimeSpan.FromMinutes(20);
                w1.Type = "Kondition";

                Models.Workout w2 = new Models.Workout();
                w2.UserId = 2;
                w2.Name = "Löpning 2019-10-12";
                w2.Description = "Löpträning på löpband";
                w2.Time = TimeSpan.FromMinutes(60);
                w2.Type = "Kondition";

                Models.Workout w3 = new Models.Workout();
                w3.UserId = 3;
                w3.Name = "Rodd och styrketräning 2019-10-14";
                w3.Description = "Roddmaskin och styrketräning ben och rumpa";
                w3.Time = TimeSpan.FromMinutes(100);
                w3.Type = "Styrketräning";

                Models.Workout w4 = new Models.Workout();
                w4.UserId = 4;
                w4.Name = "Trappmaskin, crosstrainer och styrketräning 2019-10-16";
                w4.Description = "Trappmaskin, crosstraining och styrketräning armar";
                w4.Time = TimeSpan.FromMinutes(15);
                w4.Type = "Kondition";

                Models.Workout w5 = new Models.Workout();
                w5.UserId = 1;
                w5.Name = "Crosstrainer 2019-10-16";
                w5.Description = "Crosstraining";
                w5.Time = TimeSpan.FromMinutes(40);
                w5.Type = "Kondition";

                Models.Workout w6 = new Models.Workout();
                w6.UserId = 2;
                w6.Name = "Styrketräning och rodd 2019-10-18";
                w6.Description = "Armar och mage samt rodd";
                w6.Time = TimeSpan.FromMinutes(90);
                w6.Type = "Styrketräning";

                Models.Workout w7 = new Models.Workout();
                w7.UserId = 3;
                w7.Name = "Löpning 2019-10-20";
                w7.Description = "Löpning på band";
                w7.Time = TimeSpan.FromMinutes(50);
                w7.Type = "Kondition";

                Models.Workout w8 = new Models.Workout();
                w8.UserId = 4;
                w8.Name = "Cykling 2019-10-22";
                w8.Description = "Cyklade 10km";
                w8.Time = TimeSpan.FromMinutes(50);
                w8.Type = "Kondition";

                Models.Workout w9 = new Models.Workout();
                w9.UserId = 1;
                w9.Name = "Löpning 2019-10-24";
                w9.Description = "Löpning på löpband";
                w9.Time = TimeSpan.FromMinutes(30);
                w9.Type = "Kondition";

                Models.Workout w10 = new Models.Workout();
                w10.UserId = 2;
                w10.Name = "Rodd 2019-11-01";
                w10.Description = "Roddmaskin";
                w10.Time = TimeSpan.FromMinutes(35);
                w10.Type = "Kondition";

                Models.Workout w11 = new Models.Workout();
                w11.UserId = 3;
                w11.Name = "Crosstrainer 2019-11-04";
                w11.Description = "Crosstraining";
                w11.Time = TimeSpan.FromMinutes(40);
                w11.Type = "Kondition";

                Models.Workout w12 = new Models.Workout();
                w12.UserId = 4;
                w12.Name = "Löpning och cykkling 2019-11-05";
                w12.Description = "Sprang på löpband och cyklade";
                w12.Time = TimeSpan.FromMinutes(60);
                w12.Type = "Kondition";

                context.Add(w1);
                context.Add(w2);
                context.Add(w3);
                context.Add(w4);
                context.Add(w5);
                context.Add(w6);
                context.Add(w7);
                context.Add(w8);
                context.Add(w9);
                context.Add(w10);
                context.Add(w11);
                context.Add(w12);

                context.SaveChanges();
            }
        }
        public static void AddWorkoutEquipment()
        {
            using (var context = new Models.Lab4Context())
            {
                Models.WorkoutEquipment we1 = new Models.WorkoutEquipment();
                we1.WorkoutId = 1;
                we1.EquipmentId = 1;

                Models.WorkoutEquipment we2 = new Models.WorkoutEquipment();
                we2.WorkoutId = 2;
                we2.EquipmentId = 2;

                Models.WorkoutEquipment we3 = new Models.WorkoutEquipment();
                we3.WorkoutId = 3;
                we3.EquipmentId = 3;

                Models.WorkoutEquipment we4 = new Models.WorkoutEquipment();
                we4.WorkoutId = 4;
                we4.EquipmentId = 3;

                Models.WorkoutEquipment we5 = new Models.WorkoutEquipment();
                we5.WorkoutId = 4;
                we5.EquipmentId = 4;

                Models.WorkoutEquipment we6 = new Models.WorkoutEquipment();
                we6.WorkoutId = 5;
                we6.EquipmentId = 5;

                Models.WorkoutEquipment we7 = new Models.WorkoutEquipment();
                we7.WorkoutId = 6;
                we7.EquipmentId = 3;

                Models.WorkoutEquipment we8 = new Models.WorkoutEquipment();
                we8.WorkoutId = 7;
                we8.EquipmentId = 2;

                Models.WorkoutEquipment we9 = new Models.WorkoutEquipment();
                we9.WorkoutId = 8;
                we9.EquipmentId = 1;

                Models.WorkoutEquipment we10 = new Models.WorkoutEquipment();
                we10.WorkoutId = 9;
                we10.EquipmentId = 2;

                Models.WorkoutEquipment we11 = new Models.WorkoutEquipment();
                we11.WorkoutId = 10;
                we11.EquipmentId = 3;

                Models.WorkoutEquipment we12 = new Models.WorkoutEquipment();
                we12.WorkoutId = 11;
                we12.EquipmentId = 5;

                Models.WorkoutEquipment we13 = new Models.WorkoutEquipment();
                we13.WorkoutId = 12;
                we13.EquipmentId = 2;

                Models.WorkoutEquipment we14 = new Models.WorkoutEquipment();
                we14.WorkoutId = 12;
                we14.EquipmentId = 1;



                context.Add(we1);
                context.Add(we2);
                context.Add(we3);
                context.Add(we4);
                context.Add(we5);
                context.Add(we6);
                context.Add(we7);
                context.Add(we8);
                context.Add(we9);
                context.Add(we10);
                context.Add(we11);
                context.Add(we12);
                context.Add(we13);
                context.Add(we14);

                context.SaveChanges();
            }
        }
        public static void AddWorkoutExercise()
        {
            using (var context = new Models.Lab4Context())
            {
                Models.WorkoutExercise we1 = new Models.WorkoutExercise();
                we1.WorkoutId = 1;
                we1.ExerciseId = 1;
                we1.Strain = 6;

                Models.WorkoutExercise we2 = new Models.WorkoutExercise();
                we2.WorkoutId = 2;
                we2.ExerciseId = 2;
                we2.Strain = 9;

                Models.WorkoutExercise we3 = new Models.WorkoutExercise();
                we3.WorkoutId = 3;
                we3.ExerciseId = 3;
                we3.Reps = 40;

                Models.WorkoutExercise we4 = new Models.WorkoutExercise();
                we4.WorkoutId = 4;
                we4.ExerciseId = 3;

                Models.WorkoutExercise we5 = new Models.WorkoutExercise();
                we5.WorkoutId = 4;
                we5.ExerciseId = 4;
                we5.Reps = 30;

                Models.WorkoutExercise we6 = new Models.WorkoutExercise();
                we6.WorkoutId = 5;
                we6.ExerciseId = 5;
                we6.Strain = 8;

                Models.WorkoutExercise we7 = new Models.WorkoutExercise();
                we7.WorkoutId = 6;
                we7.ExerciseId = 3;
                we7.Strain = 4;

                Models.WorkoutExercise we8 = new Models.WorkoutExercise();
                we8.WorkoutId = 6;
                we8.ExerciseId = 4;
                we8.Reps = 40;

                Models.WorkoutExercise we9 = new Models.WorkoutExercise();
                we9.WorkoutId = 7;
                we9.ExerciseId = 2;
                we9.Strain = 9;

                Models.WorkoutExercise we10 = new Models.WorkoutExercise();
                we10.WorkoutId = 8;
                we10.ExerciseId = 1;

                Models.WorkoutExercise we11 = new Models.WorkoutExercise();
                we11.WorkoutId = 9;
                we11.ExerciseId = 2;

                Models.WorkoutExercise we12 = new Models.WorkoutExercise();
                we12.WorkoutId = 10;
                we12.ExerciseId = 3;
                we12.Reps = 30;
                we12.Strain = 10;

                Models.WorkoutExercise we13 = new Models.WorkoutExercise();
                we13.WorkoutId = 11;
                we13.ExerciseId = 5;

                Models.WorkoutExercise we14 = new Models.WorkoutExercise();
                we14.WorkoutId = 12;
                we14.ExerciseId = 2;

                Models.WorkoutExercise we15 = new Models.WorkoutExercise();
                we15.WorkoutId = 12;
                we15.ExerciseId = 5;

                context.Add(we1);
                context.Add(we2);
                context.Add(we3);
                context.Add(we4);
                context.Add(we5);
                context.Add(we6);
                context.Add(we7);
                context.Add(we8);
                context.Add(we9);
                context.Add(we10);
                context.Add(we12);
                context.Add(we12);
                context.Add(we13);
                context.Add(we14);
                context.Add(we15);

                context.SaveChanges();
            }
        }

    }
}

