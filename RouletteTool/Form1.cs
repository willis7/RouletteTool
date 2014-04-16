using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RouletteTool
{
    public partial class frmMain : Form
    {
        Globals globals = new Globals();
        public frmMain()
        {
            InitializeComponent();
        }

        // This runs when the form first loads
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Take the list of items in strategyList.txt and add them to the combobox
            try
            {
                StreamReader sr = new StreamReader(@"I:\My documents\Programming\RouletteTool\RouletteTool\Assets\strategyList.txt");
                string line = sr.ReadLine();

                while (line != null)
                {
                    cbStrategy.Items.Add(line);
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }

        private void btnWin_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // Terminate the application
            Application.Exit();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            txtStrategy.Text = cbStrategy.SelectedItem.ToString();
            //globals.StrategyIndex. = cbStrategy.SelectedIndex;
        }
    }
}
