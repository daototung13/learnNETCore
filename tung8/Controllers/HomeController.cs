using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tung8.data;
using tung8.Models;


namespace tung8.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(FirstAppDemoDbContext  context)
        {
            _context = context;
        }
        private FirstAppDemoDbContext _context { get; set; }

        public ViewResult Index()
        {
            var model = new HomePageViewModel();
            /*var Employees = new Employee { Name = "tung" };*/
            using (var context = new FirstAppDemoDbContext())
            {
                SQLEmployeeData sqlData = new SQLEmployeeData(_context);
                /*sqlData.Add(Employees);*/
                model.Employees = sqlData.GetAll();
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            using (var context = new FirstAppDemoDbContext())
            {
                SQLEmployeeData sqlData = new SQLEmployeeData(_context);
                var employee = sqlData.Get(id);
                if (employee == null)
                {
                    return RedirectToAction("Index");
                }
                return View(employee);
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var context = new FirstAppDemoDbContext())
            {
                SQLEmployeeData sqlData = new SQLEmployeeData(_context);
                var employee = sqlData.Get(id);

                if (employee == null)
                {
                    return RedirectToAction("Index");
                }
                return View(employee);
            }
        }

        [HttpPost]
        public IActionResult Edit(int id, EmployeeEditViewModel input)
        {
            using (var context = new FirstAppDemoDbContext())
            {
                SQLEmployeeData sqlData = new SQLEmployeeData(_context);
            var employee = sqlData.Get(id);
            if (employee != null && ModelState.IsValid)
            {
                employee.Name = input.Name;
                _context.SaveChanges();
                return RedirectToAction("Details", new { id = employee.ID });
            }
            return View(employee);
            }
                
        }
    }

    public class SQLEmployeeData
    {
        private FirstAppDemoDbContext _context { get; set; }
        public SQLEmployeeData(FirstAppDemoDbContext context)
        {
            _context = context;
        }
        public void Add(Employee emp)
        {
            _context.Add(emp);
            _context.SaveChanges();
        }
        public Employee Get(int ID)
        {
            return _context.Employees.FirstOrDefault(e => e.ID == ID);
        }
        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList<Employee>();
        }

    }

    public class HomePageViewModel { 
      public IEnumerable<Employee> Employees { get; set; } 
   }
    public class EmployeeEditViewModel {
      [Required, MaxLength(80)]
      public string Name { get; set; }
   }
   
}
