namespace TCryptor
{
    partial class Form1
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.activateBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.inputFileBtn = new System.Windows.Forms.Button();
            this.outputFileBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.eActivateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(88, 12);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(220, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Location:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output:";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(88, 39);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(220, 20);
            this.outputTextBox.TabIndex = 3;
            // 
            // activateBtn
            // 
            this.activateBtn.Location = new System.Drawing.Point(7, 70);
            this.activateBtn.Name = "activateBtn";
            this.activateBtn.Size = new System.Drawing.Size(338, 23);
            this.activateBtn.TabIndex = 4;
            this.activateBtn.Text = "Decrypt";
            this.activateBtn.UseVisualStyleBackColor = true;
            this.activateBtn.Click += new System.EventHandler(this.activateBtn_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // inputFileBtn
            // 
            this.inputFileBtn.Location = new System.Drawing.Point(317, 9);
            this.inputFileBtn.Name = "inputFileBtn";
            this.inputFileBtn.Size = new System.Drawing.Size(28, 23);
            this.inputFileBtn.TabIndex = 5;
            this.inputFileBtn.Text = "...";
            this.inputFileBtn.UseVisualStyleBackColor = true;
            this.inputFileBtn.Click += new System.EventHandler(this.inputFileBtn_Click);
            // 
            // outputFileBtn
            // 
            this.outputFileBtn.Location = new System.Drawing.Point(317, 39);
            this.outputFileBtn.Name = "outputFileBtn";
            this.outputFileBtn.Size = new System.Drawing.Size(28, 23);
            this.outputFileBtn.TabIndex = 6;
            this.outputFileBtn.Text = "...";
            this.outputFileBtn.UseVisualStyleBackColor = true;
            this.outputFileBtn.Click += new System.EventHandler(this.outputFileBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.InitialDirectory = "C:\\";
            // 
            // eActivateBtn
            // 
            this.eActivateBtn.Location = new System.Drawing.Point(7, 98);
            this.eActivateBtn.Name = "eActivateBtn";
            this.eActivateBtn.Size = new System.Drawing.Size(338, 23);
            this.eActivateBtn.TabIndex = 7;
            this.eActivateBtn.Text = "Encrypt";
            this.eActivateBtn.UseVisualStyleBackColor = true;
            this.eActivateBtn.Click += new System.EventHandler(this.eActivateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 129);
            this.Controls.Add(this.eActivateBtn);
            this.Controls.Add(this.outputFileBtn);
            this.Controls.Add(this.inputFileBtn);
            this.Controls.Add(this.activateBtn);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TCryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button activateBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button inputFileBtn;
        private System.Windows.Forms.Button outputFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button eActivateBtn;

    }
}

