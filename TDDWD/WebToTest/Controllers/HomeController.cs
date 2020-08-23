﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebToTest.Models;

namespace WebToTest.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController()]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        // GET: api/Person
        [HttpGet]
        public IEnumerable<Person> GetPersons()
        {
            return _personService.AllPersons();
        }
        // GET: api/Person/5
        [HttpGet("{id}")]
        public ActionResult<Person> GetPerson(int id)
        {
            var todoItem = _personService.FindPerson(id);
            if (todoItem == null)
            {
                return NotFound();
            }
            return todoItem;
        }
    }
}
