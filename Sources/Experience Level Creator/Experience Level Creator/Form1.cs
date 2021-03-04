using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Experience_Level_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private enum Style
        {
            SHADOW_ALPHA_DECAL = 0
        }
        private struct SelectionDecal
        {
            String Texture;
            String Texture2;
            Style Style;
            int OpacityMin;
            int OpacityMax;
            int MinRadius;
            int MaxRadius;
            int MaxSelectedUnits;
        }
        private struct ExperienceLevel
        {
            ArrayList TargetNames;
            ArrayList AttributeModifiers;
            ArrayList LevelUpFx;
            ArrayList Upgrades;
            ArrayList LevelUpOCL;
            String RequiredExperience;
            int ExperienceAward;
            int ExperienceAwardOwnGuysDie;
            int Rank;
            SelectionDecal SelectionDecal;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}