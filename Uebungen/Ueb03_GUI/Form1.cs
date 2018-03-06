﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ueb03_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateUI(); 
        }

        private void UpdateUI()
        {
            checkbox_neg.Checked = numericUpDown.Value < 0;
            textBoxValue.Text = Math.Abs(numericUpDown.Value).ToString(); 
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            numericUpDown.Value = 0;                 
        }

        private void CheckBoxClicck(object sender, EventArgs e)
        {

        }

        private void numbericUpDownValueChanged(object sender, EventArgs e)
        {
            UpdateUI(); 
        }
    }
}
