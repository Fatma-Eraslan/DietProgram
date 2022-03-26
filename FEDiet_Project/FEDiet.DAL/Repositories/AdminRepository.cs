﻿using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL.Repositories
{
    internal class AdminRepository
    {
        FEDietDbContext FEDietDbContext;
        public AdminRepository()
        {
            FEDietDbContext = new FEDietDbContext();    
        }
        
        //Edit meals
        public int AddMeal(Meal meal) 
        {
            FEDietDbContext.Meals.Add(meal);
          return  FEDietDbContext.SaveChanges();
        }
        public int UpdateMeal(Meal meal)
        {
            Meal meal1 = FEDietDbContext.Meals.Find(meal.MealID);
            meal1.MealName = meal.MealName;
            return FEDietDbContext.SaveChanges();   
        }
        public int DeleteMeal(Meal meal)
        {
            Meal meal1 = FEDietDbContext.Meals.Find(meal.MealID);
            FEDietDbContext.Meals.Remove(meal1);
            return FEDietDbContext.SaveChanges();   
        }

        //Edit foods
        public int AddFood(Food food)
        {
            FEDietDbContext.Foods.Add(food);
            return FEDietDbContext.SaveChanges();
        }
        public int UpdateFood(Food food)
        {
            Food food1 = FEDietDbContext.Foods.Find(food.FoodID);
            food1.FoodName = food.FoodName;
            food1.Calorie = food.Calorie;
            food1.Neutrition = food.Neutrition;
            food1.CarbRate = food.CarbRate;
            food1.FatRate = food.FatRate;   
            food1.ProteinRate = food.ProteinRate;   
            return FEDietDbContext.SaveChanges();
        }
        public int DeleteFood(Food food)
        {
            Food food1 = FEDietDbContext.Foods.Find(food.FoodID);
            FEDietDbContext.Foods.Remove(food1);
            return FEDietDbContext.SaveChanges();
        }

        //Edit Goals
        public int AddGoal(Goal goal)
        {
            FEDietDbContext.Goals.Add(goal);
            return FEDietDbContext.SaveChanges();
        }
        public int UpdateGoal(Goal goal)
        {
            Goal goal1 = FEDietDbContext.Goals.Find(goal.GoalID);
            goal1.Name = goal1.Name;
            return FEDietDbContext.SaveChanges();
        }
        public int DeleteGoal(Goal goal)
        {
            Goal goal1 = FEDietDbContext.Goals.Find(goal.GoalID);
            FEDietDbContext.Goals.Remove(goal1);
            return FEDietDbContext.SaveChanges();
        }

        //Edit Activity
        public int AddActivity(Activity activity)
        {
            FEDietDbContext.Activities.Add(activity);
            return FEDietDbContext.SaveChanges();
        }
        public int UpdateActivity(Activity activity)
        {
            Activity activity1 = FEDietDbContext.Activities.Find(activity.ActivityID);
            activity1.ActivityName = activity1.ActivityName;
            return FEDietDbContext.SaveChanges();
        }
        public int DeleteActivity(Activity activity)
        {
            Activity activity1 = FEDietDbContext.Activities.Find(activity.ActivityID);
            FEDietDbContext.Activities.Remove(activity1);
            return FEDietDbContext.SaveChanges();
        }








    }
}
