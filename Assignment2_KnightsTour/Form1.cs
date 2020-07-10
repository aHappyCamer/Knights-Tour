using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Assignment2_KnightsTour
{
    public partial class Form1 : Form
    {
        private Calculation c = new Calculation();
        private Board r = new Randomize();
        private Board h = new Heuristic();
        public int inputRow;
        public int inputColumn;
        public int requestRuns;
        public string choice;

        // Custom TextWriter class
        TextBoxWriter newWriter = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            txtResults.Text = String.Empty;
            stdDevOut.Text = String.Empty;
            avgOut.Text = String.Empty;
            txtPrintOutput.Text = String.Empty;

            // row input verification
            if (!rowCb.Text.All(char.IsDigit))
            {
                MessageBox.Show("Row input was not numeric. Row is now set to the default of 0");
            }
            else if (rowCb.Text.Equals(""))
            {
                Convert.ToInt32(rowCb.Text = "0");
            }
            else if (Convert.ToInt32(rowCb.Text) < 0 || Convert.ToInt32(rowCb.Text) > 7)
            {
                MessageBox.Show("Row input is outside grid. Row is now set to the default of 0");
            }
            else
            {
                inputRow = Convert.ToInt32(rowCb.Text);
            }
            //column input verification
            if (!columnCb.Text.All(char.IsDigit))
                MessageBox.Show("Column input is not numeric. Column is now set to the default of 0");
            else if (columnCb.Text.Equals(""))
            {
                Convert.ToInt32(columnCb.Text = "0");
            }
            else if (Convert.ToInt32(columnCb.Text) < 0 || Convert.ToInt32(columnCb.Text) > 7)
            {
                MessageBox.Show("Column input is outside grid. Column is now set to the default of 0");
            }
            else
            {
                inputColumn = Convert.ToInt32(columnCb.Text);
            }

            // Number of runs verification
            if (runsTb.Text.Equals("") || (runsTb.Text == "0"))
            {
                MessageBox.Show("Number of runs must be filled and >= 1, number of runs is now set to the default of 1");
                requestRuns = Convert.ToInt32(runsTb.Text = "1");
            }
            else if (!runsTb.Text.All(char.IsDigit))
            {
                MessageBox.Show("Input must be an integer");
            }
            else
                requestRuns = Convert.ToInt32(runsTb.Text);


            if (strategyLb.Text == "Non-Intelligent")
            {
                choice = "NonIntelligentMethod";
                selectStrategy(r);
            }
            else if (strategyLb.Text == "Accessibility Heuristic")
            {
                choice = "HeuristicsMethod";
                selectStrategy(h);
            }
            else
            {
                MessageBox.Show("Please select a strategy to run!");
            }
        }

        private void selectStrategy(Board s)
        {
            var listOfRuns = s.PlayGame(inputRow, inputColumn, requestRuns);
            if (requestRuns > 1)
            {
                c.StoreAveragesPerRun(listOfRuns);
                avgOut.Text = Convert.ToString(c.CalculateAverage(listOfRuns));
                stdDevOut.Text = Convert.ToString(c.CalculateStdDev());
            }
            
            txtPrintOutput.Text = s.Output;
            Refresh();
            printFile();
        }

        private void printFile()
        {
            using (StreamWriter writer = new StreamWriter("PhuongCam" + choice + ".txt"))
            {
                writer.WriteLine(txtPrintOutput.Text);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Instantiate the writer
            newWriter = new TextBoxWriter(txtResults);
            // Redirect the out Console stream
            Console.SetOut(newWriter);
        }

    }

 }

