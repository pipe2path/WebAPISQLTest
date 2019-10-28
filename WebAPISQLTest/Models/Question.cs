using System;
using System.Collections.Generic;

namespace WebAPISQLTest.Models
{
    public partial class Question
    {
        public int QuestionId { get; set; }
        public int? SurveyId { get; set; }
        public int? DisplayOrder { get; set; }
        public string QuestionDesc { get; set; }
        public string QuestionType { get; set; }
        public string Choices { get; set; }
    }
}
