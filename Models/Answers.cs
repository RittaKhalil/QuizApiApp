using System;

namespace Models
{
    public class Answers
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Description { get; set; }
        public Boolean IsCorrect { get; set; }
        public int Order { get; set; }
    }
}