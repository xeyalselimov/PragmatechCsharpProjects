﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NoTech.Models;
using NoTech.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NoTech.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyContext myContext;

        public HomeController(MyContext myContext)
        {
            this.myContext = myContext;
        }

        public async Task<IActionResult> Index()
        {
            var vM = new ALLVM
            {
                homes = await myContext.Homes.ToListAsync(),
                features = await myContext.Features.ToListAsync(),
                abouts = await myContext.Abouts.ToListAsync(),
                servicesTitles = await myContext.ServicesTitles.ToListAsync(),
                servicesBoxes = await myContext.ServicesBoxes.ToListAsync(),
                testimonials = await myContext.Testimonials.ToListAsync(),
                projectBoxes = await myContext.ProjectBoxes.ToListAsync(),
                projectAbouts = await myContext.ProjectAbouts.ToListAsync(),
                counters = await myContext.Counters.ToListAsync(),
                helpings=await myContext.Helpings.ToListAsync(),
                blogs=await myContext.Blogs.ToListAsync(),
                layouts=await myContext.Layouts.ToListAsync(),
                contacts = await myContext.Contacts.ToListAsync(),


                //counters = await myContext.Counters.Skip(take * (page - 1)).Take(take).ToListAsync(),
                //Pagination = new PaginationModel(await myContext.Counters.CountAsync(), take, page)
            };

            return View(vM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Contact contact)
        {
            if (contact == null) return View(contact);

            if (!ModelState.IsValid) return View(contact);

            await myContext.Contacts.AddAsync(contact);
            await myContext.SaveChangesAsync();

            return Redirect("/");

        }


            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
