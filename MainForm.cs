using KeyboardTraining.Forms;
using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace KeyboardTraining
{
    public partial class MainForm : Form
    {
        private bool IfStarted;
        private int TimeLeft;
        private string Result;
        private string Typed;
        private double Missclicks;
        private int SessionMissclicks;
        private int MaxSpeed;
        private double Speed;
        private double AverageSpeed;
        private int AllSpeeds;
        private int SessionCounter;
        private double CharCounter, AllCharCounter;
        private double MissclickPercentage;
        private double AverageMissclickPercentage;

        public MainForm()
        {
            if (Properties.Settings.Default.Language == "en-US")
            {
                Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("ru");
            }

            InitializeComponent();
            StartLogo startLogo = new StartLogo();

            startLogo.ShowDialog();
            startLogo.Dispose();

            TimeLeft = Properties.Settings.Default.Timer;

            label7.Text = Properties.Settings.Default.TextLanguage;
            label8.Text = Properties.Settings.Default.Mode;
            label10.Text = Properties.Settings.Default.IsRegisterEnabled.ToString();
            label12.Text = Properties.Settings.Default.TextSize.ToString();

            label3.Text = $"{Properties.Settings.Default.Timer / 60}:{Properties.Settings.Default.Timer % 60}";
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram aboutProgram = new AboutProgram();
            aboutProgram.ShowDialog();
            aboutProgram.Dispose();
        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Author Author = new Author();
            Author.ShowDialog();
            Author.Dispose();
        }

        private void mainSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainSettings mainSettings = new MainSettings();
            mainSettings.ShowDialog();
            mainSettings.Dispose();
        }

        private void textSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextSettings textSettings = new TextSettings();
            textSettings.ShowDialog();
            textSettings.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainSettings mainSettings = new MainSettings();
            mainSettings.ShowDialog();
            mainSettings.Dispose();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Missclicks = 0;
            CharCounter = 0;

            label13.Text = "none";
            label17.Text = "none";
            label19.Text = "none";


            Graphics Graph;
            Font font = new Font("Sans Serif", Properties.Settings.Default.TextSize);
            Graph = splitContainer1.Panel1.CreateGraphics();

            //x=1 y=30

            TrainingProcess trainingProcess = new TrainingProcess();
            Result = trainingProcess.GetText();

            if (Properties.Settings.Default.IsRegisterEnabled == false)
            {
                Result = Result.ToLower();
            }

            Graph.DrawString(Result, font, Brushes.Black, 1, 30);

            if (Result == "File not found!" || Result == "file not found!")
            {
                trainingProcess.Timer(3);
                Application.Exit();
            }

            button3.Enabled = false;
            button4.Enabled = true;
            IfStarted = true;
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IfStarted == false)
            {
                return;
            }

            try
            {
                char FirstChar = Result.First<char>();

                button3.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button4.Enabled = true;
                button5.Enabled = true;
                menuStrip1.Enabled = false;
                button5.Visible = true;
                button6.Visible = false;

                label9.Text = e.KeyChar.ToString();

                Graphics Graph;
                Graphics Graph2;

                Font font = new Font("Sans Serif", Properties.Settings.Default.TextSize);
                Graph = splitContainer1.Panel1.CreateGraphics();
                Graph2 = splitContainer1.Panel2.CreateGraphics();

                Graph.Clear(BackColor);
                Graph2.Clear(BackColor);


                timer2.Enabled = true;

                if (e.KeyChar == FirstChar)
                {
                    Typed += e.KeyChar;
                    if (TextRenderer.MeasureText(Typed, font).Width > 620)
                    {
                        Typed = Typed.Remove(0, 1);
                    }

                    Result = Result.Remove(0, 1);

                    Graph.Clear(BackColor);
                    Graph2.Clear(BackColor);

                    Graph.DrawString(Result, font, Brushes.Black, 1, 30);
                    Graph2.DrawString(Typed, font, Brushes.Black, 1, 30);


                }
                else
                {
                    ++Missclicks;
                    Graph.DrawString(Result, font, Brushes.Black, 1, 30);
                    Graph2.DrawString(Typed, font, Brushes.Black, 1, 30);
                }


                ++CharCounter;
            }
            catch (InvalidOperationException)
            {
                End();
                SessionStats();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            --TimeLeft;
            label3.Text = $"{TimeLeft / 60}:{TimeLeft % 60}";

            if (TimeLeft == 0)
            {
                End();
                SessionStats();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            button6.Visible = false;

            timer2.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            button6.Visible = true;

            timer2.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            End();
            label16.Text = "none";

            label17.Text = "none";

            label19.Text = "none";

            label13.Text = "none";
        }

        private void End()
        {
            Graphics Graph;
            Graphics Graph2;

            Graph = splitContainer1.Panel1.CreateGraphics();
            Graph2 = splitContainer1.Panel2.CreateGraphics();

            Graph.Clear(BackColor);
            Graph2.Clear(BackColor);

            timer2.Enabled = false;
            IfStarted = false;

            button3.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
            menuStrip1.Enabled = true;

            label3.Text = $"{Properties.Settings.Default.Timer / 60}:{Properties.Settings.Default.Timer % 60}";


            Typed = null;

            MissclickPercentage = Missclicks / CharCounter * 100;
            MissclickPercentage = Math.Round(MissclickPercentage, 1);

            try
            {
                Speed = 60 / (Properties.Settings.Default.Timer - TimeLeft) * CharCounter;
                TimeLeft = Properties.Settings.Default.Timer;
            }
            catch (DivideByZeroException)
            {
                Speed = 0;
            }

            label16.Text = Speed.ToString();

            label17.Text = MissclickPercentage.ToString();

            label19.Text = CharCounter.ToString();

            label13.Text = Missclicks.ToString();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                Graphics Graph;
                Font font = new Font("Sans Serif", Properties.Settings.Default.TextSize);
                Graph = splitContainer1.Panel1.CreateGraphics();
                Graph.DrawString(Result, font, Brushes.Black, 1, 30);
            }
        }


        private void globalStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GStatistics gStatistics = new GStatistics();
            gStatistics.ShowDialog();
            gStatistics.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GStatistics gStatistics = new GStatistics();
            gStatistics.ShowDialog();
            gStatistics.Dispose();
        }


        private void SessionStats()
        {
            SessionMissclicks += (int)Missclicks;
            label21.Text = SessionMissclicks.ToString();

            if (Speed > MaxSpeed)
            {
                MaxSpeed = (int)Speed;
            }

            label23.Text = MaxSpeed.ToString();

            ++SessionCounter;

            AllSpeeds += (int)Speed;
            AverageSpeed = AllSpeeds / SessionCounter;
            label25.Text = AverageSpeed.ToString();

            AllCharCounter += CharCounter;
            AverageMissclickPercentage = SessionMissclicks / AllCharCounter * 100;
            AverageMissclickPercentage = Math.Round(AverageMissclickPercentage, 1);
            label27.Text = AverageMissclickPercentage.ToString();

            Properties.Settings.Default.TotalMissclicks += SessionMissclicks;
            if (MaxSpeed > Properties.Settings.Default.MaxSpeed)
            {
                Properties.Settings.Default.MaxSpeed = MaxSpeed;
            }
            ++Properties.Settings.Default.TotalSessions;
            Properties.Settings.Default.AllSpeed += AllSpeeds;
            Properties.Settings.Default.AverageSpeed = Properties.Settings.Default.AllSpeed / Properties.Settings.Default.TotalSessions;
            Properties.Settings.Default.AverageSpeed = Math.Round(Properties.Settings.Default.AverageSpeed);
            Properties.Settings.Default.CharsTyped += AllCharCounter;
            Properties.Settings.Default.AverageMissclicks = Properties.Settings.Default.TotalMissclicks / Properties.Settings.Default.CharsTyped * 100;
            Properties.Settings.Default.AverageMissclicks = Math.Round(Properties.Settings.Default.AverageMissclicks);

            Properties.Settings.Default.Save();
        }
    }
}
