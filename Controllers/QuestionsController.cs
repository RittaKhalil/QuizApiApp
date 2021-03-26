using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Models;

namespace Controllers
{
    [Produces("application/json")]
    [Route("api/questions")]
    [EnableCors("AllowOrigin")]  
    public class QuestionsController
    {
        Questions[] questions = new Questions[]
        {
            new Questions {Id = 1, Description = "how are you ?", Type = "TrueFalse" },
            new Questions {Id = 2, Description = "hahahhahaha?", Type = "SingleAnswer" },
            new Questions {Id = 3, Description = "blalblablballab?", Type = "MultipleAnswer" },
            new Questions {Id = 4, Description = "sdahdkajddas?", Type = "TrueFalse" }
        };

        [HttpGet]
        public IEnumerable<Questions> ListAllQuestions()
        {
            return questions;
        }

        [HttpGet("id/{id}")]
        public IEnumerable<Questions> ListQuestionsById(int id)
        {
            IEnumerable<Questions> retVal =
               from g in questions
               where g.Id.Equals(id)
               select g;

            return retVal;

        }
    }
}