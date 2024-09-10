using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE
{
    public partial class Form1 : Form
    {
        gameEngine GameEngine;
        public Form1()
        {
            InitializeComponent();
            GameEngine = new gameEngine(10);
            UpdateDisplay();
        }
        public void UpdateDisplay()
        {
            lblDisplay.Text= GameEngine.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
