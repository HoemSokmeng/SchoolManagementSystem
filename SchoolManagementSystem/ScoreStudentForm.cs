using SchoolManagementSystem.Entities;
using SchoolManagementSystem.Features;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class ScoreStudentForm : Form
    {
        CalculateScore calculateScore;
        public ScoreStudentForm(CalculateScore calculateScore)
        {
            InitializeComponent();
            this.calculateScore = calculateScore;
            LoadToGrid();
            // LoadToGrid(true);

            //Disable Update Button
            updateScoreStudentButton.Enabled = false;
            saveScoreStudentButton.Enabled = false;
            deleteScoreStudentButton.Enabled = false;
        }


        private void addScoreStudentButton_Click(object sender, EventArgs e)
        {
            idScoreStudentTextBox.Clear();
            nameScoreStudentTextBox.Clear();
            pythonTextBox.Clear();
            javaTextBox.Clear();
            cshapTextBox.Clear();
            bigDataTextBox.Clear();
            englishTextBox.Clear();
            idScoreStudentTextBox.Focus();
            saveScoreStudentButton.Enabled = true;

        }

        private void saveScoreStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                var Sstd = new ScoreStudent()
                {
                    Id = idScoreStudentTextBox.Text.Trim(),
                    Name = nameScoreStudentTextBox.Text.Trim(),
                    Python = Double.Parse(pythonTextBox.Text.Trim()),
                    Java = Double.Parse(javaTextBox.Text.Trim()),
                    CShap = Double.Parse(cshapTextBox.Text.Trim()),
                    BigData = Double.Parse(bigDataTextBox.Text.Trim()),
                    English = Double.Parse(englishTextBox.Text.Trim()),
                };

                Double Python = Double.Parse(pythonTextBox.Text.Trim());
                Double Java = Double.Parse(javaTextBox.Text.Trim());
                Double Cshap = Double.Parse(javaTextBox.Text.Trim());
                Double BigData = Double.Parse(bigDataTextBox.Text.Trim());
                Double Enlish = Double.Parse(englishTextBox.Text.Trim());

                Sstd.Total = Python + Java + Cshap + BigData + Enlish;
                Sstd.Average = Sstd.Total / 5;

                Sstd.Grade = $"{Sstd.Average switch
                {
                    >= 90 => Sstd.Grade = "A",
                    >= 80 => Sstd.Grade = "B",
                    >= 70 => Sstd.Grade = "C",
                    >= 60 => Sstd.Grade = "D",
                    >= 50 => Sstd.Grade = "E",
                    _ => Sstd.Grade = "F",
                }}";

                string lTotal = Sstd.Total.ToString();
                string lAverage = Sstd.Average.ToString();
                string lGrage = Sstd.Grade.ToString();
                totalLabel.Text = lTotal;
                lableAverage.Text = lAverage;
                gradeLabel.Text = lGrage;
                calculateScore.AddScoreStudent(Sstd);
                LoadToGrid();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addScoreStudentButton.Enabled = true;
                saveScoreStudentButton.Enabled = false;
                updateScoreStudentButton.Enabled = false;
                deleteScoreStudentButton.Enabled = false;
            }

        }

        private void updateScoreStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                calculateScore.UpdateScoreStudent(idScoreStudentTextBox.Text, pythonTextBox.Text, javaTextBox.Text,
                    cshapTextBox.Text, bigDataTextBox.Text, englishTextBox.Text);
                LoadToGrid();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addScoreStudentButton.Enabled = true;
                saveScoreStudentButton.Enabled = true;
                updateScoreStudentButton.Enabled = false;
                deleteScoreStudentButton.Enabled = false;
            }
        }
        private void LoadToGrid()
        {
            scoreStudentDataGridView.DataSource = calculateScore.GetAllScoreStudent();
            scoreStudentDataGridView.Refresh(); //show lastest data
        }
        private void LoadToGrid(bool isSimpleVersion)
        {
            scoreStudentDataGridView.DataSource = calculateScore.GetAllScoreStudent(isSimpleVersion);
            scoreStudentDataGridView.Refresh(); //show lastest data
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure wish to quit?", "Exit ScoreStudentForm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void scoreStudentDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (scoreStudentDataGridView.SelectedRows != null && scoreStudentDataGridView.SelectedRows.Count > 0)
            {
                idScoreStudentTextBox.Text = scoreStudentDataGridView.SelectedCells[0].Value.ToString();
                nameScoreStudentTextBox.Text = scoreStudentDataGridView.SelectedCells[1].Value.ToString();
                pythonTextBox.Text = scoreStudentDataGridView.SelectedCells[2].Value.ToString();
                javaTextBox.Text = scoreStudentDataGridView.SelectedCells[3].Value.ToString();
                cshapTextBox.Text = scoreStudentDataGridView.SelectedCells[4].Value.ToString();
                bigDataTextBox.Text = scoreStudentDataGridView.SelectedCells[5].Value.ToString();
                englishTextBox.Text = scoreStudentDataGridView.SelectedCells[6].Value.ToString();
                totalLabel.Text = scoreStudentDataGridView.SelectedCells[7].Value.ToString();
                lableAverage.Text = scoreStudentDataGridView.SelectedCells[8].Value.ToString();
                gradeLabel.Text = scoreStudentDataGridView.SelectedCells[9].Value.ToString();
                addScoreStudentButton.Enabled = false;
                saveScoreStudentButton.Enabled = false;
                updateScoreStudentButton.Enabled = true;
                deleteScoreStudentButton.Enabled = true;
            }

        }

        private void deleteScoreStudentButton_Click(object sender, EventArgs e)
        {
            calculateScore.DeleteScoreStudent(idScoreStudentTextBox.Text, nameScoreStudentTextBox.Text, pythonTextBox.Text,
                javaTextBox.Text, cshapTextBox.Text, bigDataTextBox.Text, englishTextBox.Text, totalLabel.Text,
                lableAverage.Text, gradeLabel.Text);
            LoadToGrid();
            addScoreStudentButton.Enabled = true;
            saveScoreStudentButton.Enabled = false;
            updateScoreStudentButton.Enabled = false;
            deleteScoreStudentButton.Enabled = false;
        }
    }
}
