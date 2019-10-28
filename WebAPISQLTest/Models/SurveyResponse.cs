using System;
using System.Collections.Generic;

namespace WebAPISQLTest.Models
{
    public partial class SurveyResponse
    {
        public int SurveyResponseId { get; set; }
        public int? SurveyId { get; set; }
        public int? QuestionId { get; set; }
        public string Choice { get; set; }
        public int? UserResponseId { get; set; }
    }
}
