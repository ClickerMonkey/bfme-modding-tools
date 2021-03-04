namespace Experience_Level_Creator
{
    partial class SearchFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.lstObject = new System.Windows.Forms.ListBox();
            this.txtObject = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(41, 221);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Ok";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstObject
            // 
            this.lstObject.FormattingEnabled = true;
            this.lstObject.Location = new System.Drawing.Point(12, 55);
            this.lstObject.Name = "lstObject";
            this.lstObject.Size = new System.Drawing.Size(171, 134);
            this.lstObject.TabIndex = 1;
            this.lstObject.SelectedIndexChanged += new System.EventHandler(this.lstObject_SelectedIndexChanged);
            // 
            // txtObject
            // 
            this.txtObject.Location = new System.Drawing.Point(12, 195);
            this.txtObject.Name = "txtObject";
            this.txtObject.ReadOnly = true;
            this.txtObject.Size = new System.Drawing.Size(171, 20);
            this.txtObject.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(41, 13);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(117, 36);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // OFD
            // 
            this.OFD.Filter = "All Files |*.*";
            // 
            // SearchFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 255);
            this.ControlBox = false;
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtObject);
            this.Controls.Add(this.lstObject);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchFile";
            this.Text = "SearchFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstObject;
        private System.Windows.Forms.TextBox txtObject;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}