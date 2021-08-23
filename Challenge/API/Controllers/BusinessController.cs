using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Business;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class BusinessController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Commerce>>> GetBusiness()
        {
            return await Mediator.Send(new List.Query());
        }

        // [HttpGet("{id}/{name}/{cuit}")]
        // public async Task<ActionResult<Commerce>> GetABusiness(string id, string name, string cuit)
        // {
        //     return await Mediator.Send(new Details.Query{Id = id, Name = name, CUIT = cuit});
        // } 
        [HttpGet("{filter}")]
        public async Task<ActionResult<List<Commerce>>> GetByFilterBusiness(string filter)
        {
            return await Mediator.Send(new Details.Query { Filter = filter });
        }
    }
}