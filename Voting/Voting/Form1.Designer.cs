namespace Voting
{
    partial class MainWindow
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
            this.debugTextBox = new System.Windows.Forms.RichTextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_VoterID = new System.Windows.Forms.TextBox();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_VoterID = new System.Windows.Forms.Label();
            this.button_Submit = new System.Windows.Forms.Button();
            this.button_Decode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // debugTextBox
            // 
            this.debugTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debugTextBox.Location = new System.Drawing.Point(15, 81);
            this.debugTextBox.Name = "debugTextBox";
            this.debugTextBox.Size = new System.Drawing.Size(436, 73);
            this.debugTextBox.TabIndex = 0;
            this.debugTextBox.Text = "";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_FirstName.Location = new System.Drawing.Point(79, 3);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(291, 20);
            this.textBox_FirstName.TabIndex = 1;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_LastName.Location = new System.Drawing.Point(79, 29);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(291, 20);
            this.textBox_LastName.TabIndex = 2;
            // 
            // textBox_VoterID
            // 
            this.textBox_VoterID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_VoterID.Location = new System.Drawing.Point(79, 55);
            this.textBox_VoterID.Name = "textBox_VoterID";
            this.textBox_VoterID.Size = new System.Drawing.Size(291, 20);
            this.textBox_VoterID.TabIndex = 3;
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(12, 9);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(63, 13);
            this.label_FirstName.TabIndex = 4;
            this.label_FirstName.Text = "First Name: ";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(12, 32);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(61, 13);
            this.label_LastName.TabIndex = 5;
            this.label_LastName.Text = "Last Name:";
            // 
            // label_VoterID
            // 
            this.label_VoterID.AutoSize = true;
            this.label_VoterID.Location = new System.Drawing.Point(24, 58);
            this.label_VoterID.Name = "label_VoterID";
            this.label_VoterID.Size = new System.Drawing.Size(49, 13);
            this.label_VoterID.TabIndex = 6;
            this.label_VoterID.Text = "Voter ID:";
            // 
            // button_Submit
            // 
            this.button_Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Submit.Location = new System.Drawing.Point(376, 27);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(75, 23);
            this.button_Submit.TabIndex = 7;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // button_Decode
            // 
            this.button_Decode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Decode.Location = new System.Drawing.Point(376, 52);
            this.button_Decode.Name = "button_Decode";
            this.button_Decode.Size = new System.Drawing.Size(75, 23);
            this.button_Decode.TabIndex = 8;
            this.button_Decode.Text = "Decode";
            this.button_Decode.UseVisualStyleBackColor = true;
            this.button_Decode.Click += new System.EventHandler(this.button_Decode_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 165);
            this.Controls.Add(this.button_Decode);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.label_VoterID);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.textBox_VoterID);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.debugTextBox);
            this.Name = "MainWindow";
            this.Text = "Voter Registrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox debugTextBox;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_VoterID;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_VoterID;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Button button_Decode;
    }
}

