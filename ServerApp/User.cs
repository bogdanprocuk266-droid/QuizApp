using System;
using System.Collections.Generic;

namespace ServerApp
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Quiz> Quizzes { get; set; }
    }

    public class Quiz
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Question> Questions { get; set; }
        public List<LeaderboardRecord> LeaderboardRecords { get; set; }
    }

    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public string CorrectAnswer { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
    }

    public class LeaderboardRecord
    {
        public int Id { get; set; }
        public string QuizTitle { get; set; }
        public string PlayerName { get; set; }
        public int Score { get; set; }
        public DateTime PlayedAt { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
    }
}
