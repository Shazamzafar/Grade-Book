// Name:        Shazam Zafar
// Class:       C#
// Date:        4/10/2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestScoreLookupandUpdateZafar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //structure array
        struct Students
        {
            public string name;
            public int midterm;
            public int final;
        }

        Students[] allStudents = new Students[10];

        //amount of students
        int arrayIndex = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader studentReader = File.OpenText("Grades.txt");
                string[] splitStudent = new string[3];
                string eachStudent = "";

                while (!studentReader.EndOfStream)
                {
                    eachStudent = studentReader.ReadLine();
                    splitStudent = eachStudent.Split(',');
                    allStudents[arrayIndex].name = splitStudent[0];
                    allStudents[arrayIndex].midterm = int.Parse(splitStudent[1]);
                    allStudents[arrayIndex].final = int.Parse(splitStudent[2]);
                    //increase arrayIndex
                    arrayIndex++;
                }

                //close
                studentReader.Close();

                for (int x = 0; x < 10; x++)
                {
                    StudentNumComboBox.Items.Add(allStudents[x].name);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //write students to file
                StreamWriter studentWriter = File.CreateText("Grades.txt");
                for (int x = 0; x < 10; x++)
                {
                    studentWriter.Write(allStudents[x].name + ",");
                    studentWriter.Write(allStudents[x].midterm + ",");
                    studentWriter.WriteLine(allStudents[x].final);
                }
                //close writer
                studentWriter.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplaySelectedBtn_Click(object sender, EventArgs e)
        {
            if (AverageAllTestsRadioButton.Checked)
            {
                //accumulator
                decimal total = 0;
                //variable to hold average
                decimal average;
                //amount of scores for 10 students = 20 scores(10midterm/10finals)
                int totalscores = 20;

                //get all midterm and final scores for each student
                for (int x = 0; x < 10; x++)
                {
                    total += allStudents[x].midterm;
                    total += allStudents[x].final;
                }

                //get the average
                average = total / totalscores;

                //display average
                MessageBox.Show("The Average of all tests is: " + average.ToString("F"));
            }

            if (AverageMidtermRadioButton.Checked)
            {
                //accumulator
                decimal total = 0;
                //variable to hold average
                decimal average;
                //amount of scores for 10 students = 10 scores(10midterm)
                int totalscores = 10;

                //get all midterm scores for each student
                for (int x = 0; x < 10; x++)
                {
                    total += allStudents[x].midterm;
                }

                //get the average
                average = total / totalscores;

                //display average
                MessageBox.Show("The Average of Midterm scores is: " + average.ToString("F"));
            }

            if (AverageFinalRadioButton.Checked)
            {
                //accumulator
                decimal total = 0;
                //variable to hold average
                decimal average;
                //amount of scores for 10 students = 10 scores(10finals)
                int totalscores = 10;

                //get all final scores for each student
                for (int x = 0; x < 10; x++)
                {
                    total += allStudents[x].final;
                }

                //get the average
                average = total / totalscores;

                //display average
                MessageBox.Show("The Average of Final scores is: " + average.ToString("F"));
            }
        }
        private void DisplayFinalAndMidtermBtn_Click(object sender, EventArgs e)
        {
            if (StudentNumComboBox.SelectedIndex != -1)
            {
                int studentMidterm = 0;
                int studentFinal = 0;
                //goes through the array to find the selected students midterm and final score
                for (int x = 0; x < 10; x++)
                {
                    if (StudentNumComboBox.SelectedIndex == x)
                    {
                        studentMidterm = allStudents[x].midterm;
                        studentFinal = allStudents[x].final;
                    }
                }

                //display midterm and final into the labels
                MidtermDisplayLabel.Text = studentMidterm.ToString();
                FinalDisplayLabel.Text = studentFinal.ToString();
            }
            else
            {
                MessageBox.Show("Please select a student number");
            }
        }
        private void UpdateMidtermBtn_Click(object sender, EventArgs e)
        {
            if (StudentNumComboBox.SelectedIndex != -1)
            {
                int row = StudentNumComboBox.SelectedIndex;
                int Score;
                bool scoreValid;
                scoreValid = int.TryParse(UpdateMidtermTextbox.Text, out Score);

                //call data validation
                bool AllIsGood;
                AllIsGood = CheckScores(scoreValid, Score);
                if (AllIsGood)
                {
                    for (int x = 0; x < 10; x++)
                    {
                        if (StudentNumComboBox.SelectedIndex == x)
                        {
                            allStudents[x].midterm = Score;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a student number");
                }
            }
        }
      
        private void UpdateFinalBtn_Click(object sender, EventArgs e)
        {
            if (StudentNumComboBox.SelectedIndex != -1)
            {
                int row = StudentNumComboBox.SelectedIndex;
                int Score;
                bool scoreValid;
                scoreValid = int.TryParse(UpdateFinalTextbox.Text, out Score);

                //call data validation
                bool AllIsGood;
                AllIsGood = CheckScores(scoreValid, Score);
                if (AllIsGood)
                {
                    for (int x = 0; x < 10; x++)
                    {
                        if (StudentNumComboBox.SelectedIndex == x)
                        {
                            allStudents[x].final = Score;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a student number");
                }
            }
        }

        //validation method
        private bool CheckScores(bool scoreValid, int Score)
        {
            if (scoreValid = false || Score < 0 || Score > 100)
            {
                MessageBox.Show("Score must be between 0 - 100");
                return false;
            }
            //return true if score is valid and score is an int between 0 - 100
            return true;
        }

       
    }
}
    
