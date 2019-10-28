using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPISQLTest.Interfaces;
using WebAPISQLTest.Models;

namespace WebAPISQLTest.Data
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly DB_A4DADD_surveyContext _context = null;

        public QuestionRepository(DB_A4DADD_surveyContext context)
        {
            _context = context;
        }

        public async Task<List<Question>> GetQuestions()
        {
            try
            {
                return await _context.Question.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Question> GetQuestionById(int id)
        {
            return await _context.Question.FirstOrDefaultAsync(q => q.QuestionId == id);
        }
    }
}
