using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DictionaryApi.Model;
using DictionaryApi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DictionaryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordController : ControllerBase
    {
        private readonly IRepository<Word> _wordRepository;
        public WordController(IRepository<Word> wordRepository) => _wordRepository = wordRepository;
        [HttpGet]
        public ActionResult<IEnumerable<Word>> Get()
        {
            return _wordRepository.getAll().Include(w => w.WordType).Include(w=>w.Meanings).ToList();
        }
    }
}