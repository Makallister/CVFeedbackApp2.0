﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVFeedbackApp
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();

            //creates instance of DBConnection and calls LoadAllGTTiles
            DBConnection connectionInstance = DBConnection.getDatabaseConection();
            List<string> AllGTTitles = connectionInstance.LoadAllGTTiles();
            
            for (int i = 0; i < AllGTTitles.Count; i++)
            {
                this.GTNameListBox.Items.Add(AllGTTitles[i]);
            }
            
        }

        private void LoadSelectedTemplate_Click(object sender, EventArgs e)
        {
            NameandEmailForm Form = new NameandEmailForm();
            Form.ShowDialog();
            this.Close();
        }
    }
}
