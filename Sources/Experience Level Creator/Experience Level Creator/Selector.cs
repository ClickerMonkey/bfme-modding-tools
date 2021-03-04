using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Experience_Level_Creator
{
    public partial class Selector : UserControl
    {
        public Selector()
        {
            InitializeComponent();
        }
        public String KeyWord
        {
            set
            {
                KW = value;
            }
            get
            {
                return KW;
            }
        }
        private String KW;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstObjects.SelectedIndex != -1)
                if (lstObjects.Items.Count != 0)
                    lstObjects.Items.RemoveAt(lstObjects.SelectedIndex);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SearchFile SF;
            SF = new SearchFile(KeyWord);
            SF.Show();
            SF.FormClosed += new FormClosedEventHandler(SF_FormClosed);
        }
        void SF_FormClosed(object sender, FormClosedEventArgs e)
        {
            SearchFile SF = (SearchFile)sender;
            if (SF.Selected != null)
                lstObjects.Items.Add(SF.Selected);
        }
    }
}
