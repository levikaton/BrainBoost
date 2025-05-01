using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Quizgame
{
    public partial class ScoreForm : Form
    {
        // Handles access to the database
        private readonly ScoreDataAccess _dataAccess = new ScoreDataAccess();
        // Displays score data
        private DataGridView scoresDataGridView;

        public ScoreForm()
        {
            InitializeComponent();
            InitializeCustomDataGridView();  // Set up visual layout
            LoadScores();  // Load score data into the grid
        }

        // Creates and styles the DataGridView
        private void InitializeCustomDataGridView()
        {
            scoresDataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None
            };

            // Style headers
            scoresDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            scoresDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            scoresDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            scoresDataGridView.EnableHeadersVisualStyles = false;

            // Style rows
            scoresDataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            scoresDataGridView.DefaultCellStyle.BackColor = Color.White;
            scoresDataGridView.DefaultCellStyle.ForeColor = Color.Black;
            scoresDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            this.Controls.Add(scoresDataGridView);
        }

        // Loads score data from the database into the DataGridView
        private void LoadScores()
        {
            var scores = _dataAccess.GetAllScores();

            var dataTable = new DataTable();
            dataTable.Columns.Add("Username");
            dataTable.Columns.Add("Score");
            dataTable.Columns.Add("Date Taken");

            foreach (var score in scores)
            {
                string formattedScore = $"{score.Score}/{score.TotalQuestions} pts";
                dataTable.Rows.Add(score.Username, formattedScore, score.DateTaken.ToString("g"));
            }

            scoresDataGridView.DataSource = dataTable;
        }
    }
}