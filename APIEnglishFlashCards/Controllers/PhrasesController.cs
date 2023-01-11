using APIEnglishFlashCards.Repositories;
using FlashCards.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIEnglishFlashCards.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhrasesController : ControllerBase
    {
        private readonly IPhrasesRepository _repository;
        public PhrasesController(IPhrasesRepository repository)
        {
            _repository= repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var listPhrases = _repository.GetAll();
            return Ok(listPhrases);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            var phrase = _repository.Get(id);
            if (phrase == null)
                return NotFound("Not found");
          
            return Ok(phrase);
        }

        [HttpPost]
        public IActionResult AddNewPhrase([FromBody] Phrases phrase) 
        { 
            _repository.AddPhrase(phrase);
            return Ok(phrase);
        }
    }
}
