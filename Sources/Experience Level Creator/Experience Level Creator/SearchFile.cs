using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Experience_Level_Creator
{
    public partial class SearchFile : Form
    {
        public SearchFile(String KeyWord)
        {
            InitializeComponent();
            this.OFD.FileOk += new CancelEventHandler(OFD_FileOk);
            this.KeyWord = KeyWord;
        }
        private String KeyWord;
        public String Selected;
        private void OFD_FileOk(object sender, CancelEventArgs e)
        {
            LoadFile(OFD.FileName);
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OFD.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lstObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtObject.Text = (String)lstObject.SelectedItem;
            Selected = txtObject.Text;
        }
        private void LoadFile(String FilePath)
        {
            if (File.Exists(FilePath) == false)
                throw new Exception("File Doesnt Exist");
            StreamReader SR = File.OpenText(FilePath);
            String Line;
            lstObject.Items.Clear();
            while (SR.Peek() != -1)
            {
                Line = SR.ReadLine();
                if (Line.ToLower().StartsWith(KeyWord.ToLower()))
                        lstObject.Items.Add(Line.Substring(KeyWord.Length + 1));
            }
            SR.Close();
        }
    }
}