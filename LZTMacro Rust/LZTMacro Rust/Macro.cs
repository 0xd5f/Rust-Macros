using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;


namespace LZTMacro_Rust
{
    public partial class Macro : Form
    {
        public static bool activ = false;
        public static bool minmax = false;
        public static bool test1 = false;

        public static int min = 0;
        public static int max = 1;
        public static int smooth = 1;
        public static double sense = 1.0;
        public static int fov = 90;
        public static string weapon;
        public static string attachment;
        public static string scope;
        public Macro()
        {
            InitializeComponent();
        }

        private void Macro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void logInCheckBox1_CheckedChanged(object sender)
        {
            if (logInCheckBox1.Checked)
            {
                activ = true;
            }
            else
            {
                activ = false;
            }
        }

        private void logInCheckBox2_CheckedChanged(object sender)
        {
            if (logInCheckBox2.Checked)
            {
                minmax = true;
            }
            else
            {
                minmax = false;
            }
        }

        private void logInCheckBox3_CheckedChanged(object sender)
        {
            if (logInCheckBox3.Checked)
            {
                test1 = true;
            }
            else
            {
                test1 = false;
            }
        }

        private void logInTrackBar1_ValueChanged()
        { 
            smooth = logInTrackBar1.Value;
            
        }

        private void logInNormalTextBox1_TextChanged(object sender, EventArgs e)
        {
           
            //sense = Convert.ToDouble(logInNormalTextBox1.Text);
            
        }

        private void logInComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            weapon = (string)logInComboBox1.SelectedItem;
 
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            sense = Convert.ToDouble(numericUpDown1.Value);
        }

        private void logInNumeric2_MouseCaptureChanged(object sender, EventArgs e)
        {
            fov = Convert.ToInt32(logInNumeric2.Value);
        }

        private void logInComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            attachment = (string)logInComboBox3.SelectedItem;
        }

        private void logInComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            scope = (string)logInComboBox4.SelectedItem;
        }

        private void logInTrackBar2_ValueChanged()
        {
            min = logInTrackBar2.Value;
        }

        private void logInTrackBar3_ValueChanged()
        {
            max = logInTrackBar3.Value;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://lolz.guru/members/3438371/");
        }
    }
}
