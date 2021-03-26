using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Models;

namespace Controllers
{
    [Produces("application/json")]
    [Route("api/answers")]
    [EnableCors("AllowOrigin")]  
    public class AnswersController
    {
        Answers[] answers = new Answers[]
        {
            new Answers {Id = 1, QuestionId = 1, Description = "good", IsCorrect = false, Order = 1 },
            new Answers {Id = 2, QuestionId = 1, Description = "fine", IsCorrect = true, Order = 2 },
            new Answers {Id = 3, QuestionId = 1, Description = "great",IsCorrect = false, Order = 3 },
            new Answers {Id = 4, QuestionId = 1, Description = "bad",  IsCorrect = false, Order = 4 }
        };

        [HttpGet]
        public IEnumerable<Answers> ListAllAnswers()
        {
            return answers;
        }

        [HttpGet("q_id/{q_id}")]
        public IEnumerable<Answers> ListAnswersByQuestionId(int q_id)
        {
            IEnumerable<Answers> retVal =
               from g in answers
               where g.QuestionId.Equals(q_id)
               select g;

            return retVal;

        }
    }
}