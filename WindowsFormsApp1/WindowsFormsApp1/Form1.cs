﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodSalesDBDataSet.FoodSales' table. You can move, or remove it, as needed.
            this.foodSalesTableAdapter.Fill(this.foodSalesDBDataSet.FoodSales);

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
        }
    }
}