using Microsoft.AspNetCore.Mvc;
using CarbonTrackerMVC.Data;
using CarbonTrackerMVC.Models;
using CarbonTrackerMVC.Services;

namespace CarbonTrackerMVC.Controllers
{
    public class MealController : Controller
    {
        private readonly AppDbContext _context;

        public MealController(AppDbContext context)
        {
            _context = context;
        }

        // ---------------- ADD MEAL ----------------
        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(string food, double quantity)
        {
            double emission = (quantity / 1000) * EmissionData.FoodEmissions[food];

            _context.Meals.Add(new Meal
            {
                Food = food,
                Quantity = quantity,
                Emission = Math.Round(emission, 2),
                Date = DateTime.Today
            });

            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        // ---------------- DASHBOARD ----------------
        public IActionResult Dashboard()
        {
            var today = DateTime.Today;

            var meals = _context.Meals
                .Where(m => m.Date == today)
                .ToList();

            return View(meals);
        }

        // ---------------- EDIT MEAL ----------------
        public IActionResult Edit(int id)
        {
            var meal = _context.Meals.Find(id);
            return View(meal);
        }

        [HttpPost]
        public IActionResult Edit(Meal meal)
        {
            double emission =
                (meal.Quantity / 1000) * EmissionData.FoodEmissions[meal.Food];

            meal.Emission = Math.Round(emission, 2);
            meal.Date = DateTime.Today;

            _context.Meals.Update(meal);
            _context.SaveChanges();

            return RedirectToAction("Dashboard");
        }

        // ---------------- DELETE ----------------
        public IActionResult Delete(int id)
        {
            var meal = _context.Meals.Find(id);
            if (meal != null)
            {
                _context.Meals.Remove(meal);
                _context.SaveChanges();
            }
            return RedirectToAction("Dashboard");
        }
    }
}
