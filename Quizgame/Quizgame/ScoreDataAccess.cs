using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Quizgame
{
    public class ScoreDataAccess
    {
        private readonly string _connectionString;

        public ScoreDataAccess()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["QuizgameDBConnectionString"].ConnectionString;
        }

        public void SaveScore(string username, int score, int totalQuestions)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var query = "INSERT INTO Scores (Username, Score, TotalQuestions, DateTaken) VALUES (@username, @score, @total, @date)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@score", score);
                    cmd.Parameters.AddWithValue("@total", totalQuestions);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<(string Username, int Score, int TotalQuestions, DateTime DateTaken)> GetAllScores()
        {
            var results = new List<(string, int, int, DateTime)>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var query = "SELECT Username, Score, TotalQuestions, DateTaken FROM Scores ORDER BY DateTaken DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string username = reader.GetString(0);
                        int score = Convert.ToInt32(reader[1]);
                        int total = Convert.ToInt32(reader[2]);
                        DateTime dateTaken = reader.GetDateTime(3);
                        results.Add((username, score, total, dateTaken));
                    }
                }
            }

            return results;
        }
    }
}