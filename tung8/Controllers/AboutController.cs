﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace tung8.Controllers
{
    [Route("[controller]")]
    public class AboutController : Controller
    {
        [Route("")]
        public string Phone()
        {
            return "+49-333-3333333";
        }
        [Route("[action]")]
        public string Country()
        {
            return "Germany";
        }
    }
}