using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPISQLTest.Models;

namespace WebAPISQLTest.Interfaces
{
    public interface IQuestionRepository
    {
        Task<List<Question>> GetQuestions();
        Task<Question> GetQuestionById(int id);
    }
}
