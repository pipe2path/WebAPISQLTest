using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPISQLTest.Interfaces;
using WebAPISQLTest.Models;

namespace WebAPISQLTest.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private IQuestionRepository _questionRepository;

        public QuestionController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        [Route("api/questions")]
        public async Task<List<Question>> Get()
        {
            return await _questionRepository.GetQuestions();
        }

        [Route("api/question")]
        public async Task<Question> GetQuestionById(int id)
        {
            if (id <= 0)
                return null;
            else
            {
                return await _questionRepository.GetQuestionById(id);
            }
        }
    }
}