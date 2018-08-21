using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumbersGenerator
{
    public partial class Form1 : Form
    {
        bool isCalculationRunning;
        Thread calculationsThread;
        int timeCounter;
        long previousPrime = 2;
        long lastPrime = 2;
        int cycle = 0;
        long cycleTime;
        long calculationTime;
        FileManager fileManager = new FileManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void PathSelectionButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                fileManager.SetPath(fbd.SelectedPath);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (isCalculationRunning)
            {
                calculationsThread.Abort();
                startButton.Text = "Uruchom obliczenia";
                timer.Enabled = false;
                timeCounter = 0;
                lastPrime = previousPrime;
            }
            else
            {
                startButton.Text = "Zatrzymaj obliczenia";
                timer.Enabled = true;
            }

            isCalculationRunning = !isCalculationRunning;
        }

        private void ShowLastCycleDataButton_Click(object sender, EventArgs e)
        {
            LastCycleDataTextBox.Text = fileManager.ReadLastCycle();         
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeCounter == 0)
            {
                calculationsThread = new Thread(() => ContinousPrimeSearching());
                calculationsThread.Start();
                cycle++;
            }

            timeCounter++;

            if (timeCounter == 6)
            {
                calculationsThread.Abort();
                timeCounter = 0;

                if (lastPrime != previousPrime)
                {
                    previousPrime = lastPrime;
                    fileManager.Add(previousPrime, cycle, cycleTime, calculationTime);
                    showLastCycleDataButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Nie odnaleziono nowej liczby pierwszej w trakcie cyklu! Przerwano obliczanie.", 
                        "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    isCalculationRunning = false;
                    startButton.Enabled = false;
                    timer.Enabled = false;
                    calculationsThread.Abort();
                }
            }
        }

        private void ContinousPrimeSearching()
        {
            Stopwatch calculationsCycleWatch = Stopwatch.StartNew();
            while (true)
            {
                PrimeNumber newPrimeNumber = PrimeCalculation.NextPrime(lastPrime);
                cycleTime = calculationsCycleWatch.ElapsedMilliseconds;

                lastPrime = newPrimeNumber.Number;
                calculationTime = newPrimeNumber.CalculationTime;
            }
        }

    }
}
