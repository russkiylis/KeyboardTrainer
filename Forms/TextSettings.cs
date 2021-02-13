using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace KeyboardTraining
{
    public partial class TextSettings : Form
    {
        public TextSettings()
        {
            InitializeComponent();
            tabControl1.SelectedIndex = 1;
        }

        //Checking values
        private void TextSettings_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = Properties.Settings.Default.Timer;

            numericUpDown2.Value = Properties.Settings.Default.TextSize;

            if (Properties.Settings.Default.Language == "en-US")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }

            if (Properties.Settings.Default.TextLanguage == "en-US")
            {
                radioButton7.Checked = true;
            }
            else
            {
                radioButton8.Checked = true;
            }

            if (Properties.Settings.Default.TextDifficulty == "Common")
            {
                radioButton9.Checked = true;
            }
            else
            {
                radioButton10.Checked = true;
            }

            switch (Properties.Settings.Default.Mode)
            {
                case "Text":
                    radioButton3.Checked = true;
                    break;
                case "Words":
                    radioButton4.Checked = true;
                    break;
                case "Letters":
                    radioButton5.Checked = true;
                    break;
                case "Numbers":
                    radioButton6.Checked = true;
                    break;
            }

            if (Properties.Settings.Default.IsRegisterEnabled == true)
            {
                checkBox2.Checked = true;
            }
        }

        //Default, Cancel, Apply, Text folder
        #region Buttons 
        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Application.Restart();
        } // Restore to Defaults

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            Close();
        } // Cancel

        private void button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Application.Restart();
        } // Apply

        private void button4_Click(object sender, EventArgs e)
        {
            string root = Directory.GetCurrentDirectory();
            root = root + "\\Texts";
            Process.Start(root);
        } // Text Folder
        #endregion

        //Values in 1 tab
        #region Values_1
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Timer = (int)numericUpDown1.Value;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Properties.Settings.Default.Language = "en-US";
            }

            if (radioButton2.Checked == true)
            {
                Properties.Settings.Default.Language = "ru";
            }
        }

        private void ModeChange()
        {
            if (radioButton3.Checked == true)
            {
                Properties.Settings.Default.Mode = "Text";
            }

            if (radioButton4.Checked == true)
            {
                Properties.Settings.Default.Mode = "Words";
            }

            if (radioButton5.Checked == true)
            {
                Properties.Settings.Default.Mode = "Letters";
            }

            if (radioButton6.Checked == true)
            {
                Properties.Settings.Default.Mode = "Numbers";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ModeChange();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ModeChange();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ModeChange();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            ModeChange();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IsRegisterEnabled = checkBox2.Checked;
        }

        #endregion

        //Values in 2 tab
        #region Values_2
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                Properties.Settings.Default.TextLanguage = "en-US";
            }

            if (radioButton8.Checked == true)
            {
                Properties.Settings.Default.TextLanguage = "ru";
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TextSize = (int)numericUpDown2.Value;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                Properties.Settings.Default.TextDifficulty = "Common";
            }

            if (radioButton10.Checked == true)
            {
                Properties.Settings.Default.TextDifficulty = "Uncommon";
            }
        }
        #endregion
    }
}
