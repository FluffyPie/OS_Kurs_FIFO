using System.Drawing.Drawing2D;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using FifoLib;

namespace OS_Kurs_FIFO
{
    public partial class MainForm : Form
    {
        public static GraphicsPath RoundedRect(Rectangle baseRect, int radius)
        {
            var diameter = radius * 2;
            var sz = new Size(diameter, diameter);
            var arc = new Rectangle(baseRect.Location, sz);
            var path = new GraphicsPath();

            path.AddArc(arc, 180, 90);

            arc.X = baseRect.Right - diameter;
            path.AddArc(arc, 270, 90);

            arc.Y = baseRect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            arc.X = baseRect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
        public MainForm()
        {
            InitializeComponent();
            this.Region = new Region(RoundedRect(new Rectangle(0, 0, this.Width, this.Height), 15));
        }


        int FaultFIFO = 0;
        string[] FIFOElems = null;
        string FileText;
        Queue<int> numbers = new Queue<int>();
        Queue<int> listnumbers = new Queue<int>();
        int Dequeued, Added, Droped;
        int counter = 0, countofnumbers, numberofelems;
        

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (YourDateTextbox.Text == string.Empty)
                {
                    YourDateTextbox.Text += "Your data: ";
                }
                if (ManualInputTextbox.Text != string.Empty && ManualInputTextbox.Text.Length < 5)
                {
                    YourDateTextbox.Text += ManualInputTextbox.Text + " ";
                    FileText += ManualInputTextbox.Text + ' ';
                    ManualInputTextbox.Text = string.Empty;
                    numberofelems++;
                    StartButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Enter correct element!");
                    StartButton.Enabled = false;
                }
                
            }
            catch
            {
                MessageBox.Show("Enter correct element!");
                StartButton.Enabled = false;
            }
     
            
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 )
                e.Handled = true;
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            SaveFileDialog.InitialDirectory = @"C:\";
            SaveFileDialog.DefaultExt = "txt";
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {   
                string Filename = SaveFileDialog.FileName;
                System.IO.File.WriteAllText(Filename, FifoTextbox.Text);
                MessageBox.Show("Succsess"); 
            }
            else
            {
                MessageBox.Show("Canceled");
            }
        }

        private void openFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NextButton.Enabled = false;
            FaultFIFO = 0;
            FifoTextbox.Text = string.Empty;
            RealTimeTextbox.Text = string.Empty;
            ResetButton.Enabled = false;
            listnumbers.Clear();
            numbers.Clear();
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {

                string Filename = OpenFileDialog.FileName;
                try
                {
                    using (var Stream = new StreamReader(Filename, Encoding.UTF8))
                    {
                        FileText = Stream.ReadToEnd();
                        numberofelems = FileText.Length;
                        YourDateTextbox.Text = "Your file:" + Environment.NewLine + FileText + Environment.NewLine;
                        StartProcess();
                       
                    }
                }
                catch
                {
                    MessageBox.Show("Incorrect data");
                    Reset();
                }

            }
            else
            {
                MessageBox.Show("Unable to read file");
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ResetButton.Enabled = false;
            NextButton.Enabled = false; 
            FileText = FileText.Remove(FileText.Length - 1);
            StartProcess();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The program is written for educational purposes" + Environment.NewLine + "Saint-Petersburg State Institute of Technology" + Environment.NewLine + "Bogdan Kluev" + Environment.NewLine + "2020", "About");
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            StartButton.Enabled = false;
            ResetButton.Enabled = true;
            FrameCount.Enabled = true;
            SpeedTrackbar.Enabled = true;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm Form = new HelpForm();
            this.Hide();
            Form.ShowDialog();
            this.Show();
            
        }

        void Reset()
        {
            FileText = string.Empty;
            listnumbers.Clear();
            numbers.Clear();
            StartButton.Enabled = false;
            NextButton.Enabled = true;
            YourDateTextbox.Text = string.Empty;
            FifoTextbox.Text = string.Empty;
            CurrentAddLabel.Text = string.Empty;
            CurrentDropLabel.Text = string.Empty;
            AllDropsLabel.Text = string.Empty;
            FaultFIFO = 0;
            RealTimeTextbox.Text = string.Empty;
            FaultFIFO = 0;
            numberofelems = 0;
            Dequeued = 0;
            Droped = 0;
            Added = 0;
        }
        void StartProcess()
        {
            try
            {
                FIFOElems = new string[numberofelems];
                FIFOElems = FileText.Split(' ');
                for (int i = 0; i < FIFOElems.Length; i++)
                {
                    numbers.Enqueue(Convert.ToInt32(FIFOElems[i]));
                }
                countofnumbers = numbers.Count;
                for (int i = 0; i < FrameCount.Value; i++)
                {
                    Dequeued = numbers.Dequeue();
                    listnumbers.Enqueue(Dequeued);
                    RealTimeTextbox.Text += Dequeued + " ";
                    FifoTextbox.Text += Dequeued + " ";
                }
                FifoTextbox.Text += Environment.NewLine;
                if (SpeedTrackbar.Value != 0)
                    Timer.Interval = SpeedTrackbar.Value * 250;
                else Timer.Interval = 1;
                counter = 0;
                Timer.Start();
            }
            catch {
                ResetButton.Enabled = true;
                MessageBox.Show("Incorrect data");
                Reset();
            }

        }

        void Test()
        {

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            FrameCount.Enabled = false;
            SpeedTrackbar.Enabled = false;
            counter++;
            try
            {
                if (counter < countofnumbers)
                {
                    Dequeued = numbers.Dequeue();
                    if (listnumbers.Contains(Dequeued))
                    {
                        FifoTextbox.Text += "No pagefaults found" + Environment.NewLine;
                    }
                    else
                    {
                        try
                        {
                            Dequeued = FifoLibClass.FifoFunc(out Droped, listnumbers, out Added, Dequeued);
                            FifoTextbox.Text += "Droped: " + Droped + " Added: " + Added + Environment.NewLine;
                            RealTimeTextbox.Text = string.Empty;
                            for (int i = 0; i < FrameCount.Value; i++)
                            {
                                Dequeued = listnumbers.Dequeue();
                                RealTimeTextbox.Text += Dequeued + " ";
                                FifoTextbox.Text += Dequeued + " ";
                                listnumbers.Enqueue(Dequeued);
                            }
                            FifoTextbox.Text += Environment.NewLine;
                            AllDropsLabel.Text = (++FaultFIFO).ToString();
                            CurrentDropLabel.Text = Droped.ToString();
                            CurrentAddLabel.Text = Added.ToString();
                        }
                        catch
                        {
                            MessageBox.Show("FIFOLIB.DLL NOT FOUNDED!");
                            Application.Exit();
                        }

                    }
                }
                else
                {
                    FrameCount.Enabled = true;
                    ResetButton.Enabled = true;
                    SpeedTrackbar.Enabled = true;
                    StartButton.Enabled = false;
                    Timer.Stop();
                }
            }
            catch
            {
                StartButton.Enabled = false;
                SpeedTrackbar.Enabled = true;
                FrameCount.Enabled = true;
                ResetButton.Enabled = true;
                Timer.Stop();  
            }
        }
    }
}
