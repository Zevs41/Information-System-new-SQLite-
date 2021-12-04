namespace Курсовая2
{
    partial class FormSuccess
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
            this.labelSuccess = new System.Windows.Forms.Label();
            this.buttonCloseSuccesful = new System.Windows.Forms.Button();
            this.labelSuccessText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSuccess
            // 
            this.labelSuccess.BackColor = System.Drawing.Color.DarkGray;
            this.labelSuccess.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuccess.Location = new System.Drawing.Point(1, 1);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(248, 27);
            this.labelSuccess.TabIndex = 0;
            this.labelSuccess.Text = "Success!";
            this.labelSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCloseSuccesful
            // 
            this.buttonCloseSuccesful.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCloseSuccesful.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseSuccesful.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCloseSuccesful.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.buttonCloseSuccesful.Location = new System.Drawing.Point(62, 110);
            this.buttonCloseSuccesful.Name = "buttonCloseSuccesful";
            this.buttonCloseSuccesful.Size = new System.Drawing.Size(125, 35);
            this.buttonCloseSuccesful.TabIndex = 1;
            this.buttonCloseSuccesful.Text = "ОК";
            this.buttonCloseSuccesful.UseVisualStyleBackColor = false;
            this.buttonCloseSuccesful.Click += new System.EventHandler(this.buttonCloseSuccesful_Click);
            // 
            // labelSuccessText
            // 
            this.labelSuccessText.BackColor = System.Drawing.Color.DimGray;
            this.labelSuccessText.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuccessText.Location = new System.Drawing.Point(10, 30);
            this.labelSuccessText.Name = "labelSuccessText";
            this.labelSuccessText.Size = new System.Drawing.Size(230, 75);
            this.labelSuccessText.TabIndex = 5;
            this.labelSuccessText.Text = "SuccesText";
            this.labelSuccessText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.labelSuccessText);
            this.Controls.Add(this.buttonCloseSuccesful);
            this.Controls.Add(this.labelSuccess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSuccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormSuccess_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSuccess;
        private System.Windows.Forms.Button buttonCloseSuccesful;
        private System.Windows.Forms.Label labelSuccessText;
    }
}