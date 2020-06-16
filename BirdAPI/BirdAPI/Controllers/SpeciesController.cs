using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Contracts;
using Repository.Models;

namespace BirdAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeciesController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;

        public SpeciesController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var birds = _repoWrapper.Species.GetAllSpecies();
            return Ok(birds);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var bird = _repoWrapper.Species.GetById(id);
            return Ok(bird);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Species value)
        {
            _repoWrapper.Species.AddSpecies(value);
            _repoWrapper.Save();
            return Ok();
        }

        [HttpPut]
        public IActionResult Put([FromBody] Species value)
        {
            _repoWrapper.Species.UpdateSpecies(value);
            _repoWrapper.Save();
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Species value)
        {
            _repoWrapper.Species.DeleteSpecies(value);
            _repoWrapper.Save();
            return Ok();
        }
    }
}