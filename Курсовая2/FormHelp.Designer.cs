namespace Курсовая2
{
    partial class FormHelp
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
            this.labelHelpText = new System.Windows.Forms.Label();
            this.maskedTextBoxHelp = new System.Windows.Forms.MaskedTextBox();
            this.buttonCloseError1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHelpText
            // 
            this.labelHelpText.BackColor = System.Drawing.Color.DarkGray;
            this.labelHelpText.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelpText.Location = new System.Drawing.Point(8, 0);
            this.labelHelpText.Name = "labelHelpText";
            this.labelHelpText.Size = new System.Drawing.Size(230, 75);
            this.labelHelpText.TabIndex = 5;
            this.labelHelpText.Text = "HelpText";
            this.labelHelpText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxHelp
            // 
            this.maskedTextBoxHelp.BackColor = System.Drawing.Color.DarkGray;
            this.maskedTextBoxHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxHelp.Location = new System.Drawing.Point(73, 67);
            this.maskedTextBoxHelp.Mask = "00000000000000000";
            this.maskedTextBoxHelp.MinimumSize = new System.Drawing.Size(100, 30);
            this.maskedTextBoxHelp.Name = "maskedTextBoxHelp";
            this.maskedTextBoxHelp.Size = new System.Drawing.Size(100, 30);
            this.maskedTextBoxHelp.TabIndex = 6;
            this.maskedTextBoxHelp.ValidatingType = typeof(int);
            // 
            // buttonCloseError1
            // 
            this.buttonCloseError1.BackColor = System.Drawing.Color.DimGray;
            this.buttonCloseError1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseError1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCloseError1.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.buttonCloseError1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCloseError1.Location = new System.Drawing.Point(63, 103);
            this.buttonCloseError1.Name = "buttonCloseError1";
            this.buttonCloseError1.Size = new System.Drawing.Size(125, 35);
            this.buttonCloseError1.TabIndex = 7;
            this.buttonCloseError1.Text = "ОК";
            this.buttonCloseError1.UseVisualStyleBackColor = false;
            this.buttonCloseError1.Click += new System.EventHandler(this.buttonCloseError1_Click);
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.buttonCloseError1);
            this.Controls.Add(this.maskedTextBoxHelp);
            this.Controls.Add(this.labelHelpText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormHelp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHelpText;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHelp;
        private System.Windows.Forms.Button buttonCloseError1;
    }
}