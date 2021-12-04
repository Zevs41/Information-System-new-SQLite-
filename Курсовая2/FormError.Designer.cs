namespace Курсовая2
{
    partial class FormError
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
        public void InitializeComponent()
        {
            this.buttonCloseError1 = new System.Windows.Forms.Button();
            this.labelError1 = new System.Windows.Forms.Label();
            this.labelError1Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCloseError1
            // 
            this.buttonCloseError1.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCloseError1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseError1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCloseError1.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.buttonCloseError1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCloseError1.Location = new System.Drawing.Point(62, 110);
            this.buttonCloseError1.Name = "buttonCloseError1";
            this.buttonCloseError1.Size = new System.Drawing.Size(125, 35);
            this.buttonCloseError1.TabIndex = 2;
            this.buttonCloseError1.Text = "ОК";
            this.buttonCloseError1.UseVisualStyleBackColor = false;
            this.buttonCloseError1.Click += new System.EventHandler(this.buttonCloseError1_Click);
            // 
            // labelError1
            // 
            this.labelError1.BackColor = System.Drawing.Color.DarkGray;
            this.labelError1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelError1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelError1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError1.Location = new System.Drawing.Point(1, 1);
            this.labelError1.Name = "labelError1";
            this.labelError1.Size = new System.Drawing.Size(248, 30);
            this.labelError1.TabIndex = 3;
            this.labelError1.Text = "Error number";
            this.labelError1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelError1Text
            // 
            this.labelError1Text.BackColor = System.Drawing.Color.DimGray;
            this.labelError1Text.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError1Text.Location = new System.Drawing.Point(10, 30);
            this.labelError1Text.Name = "labelError1Text";
            this.labelError1Text.Size = new System.Drawing.Size(230, 75);
            this.labelError1Text.TabIndex = 4;
            this.labelError1Text.Text = "ErrorText";
            this.labelError1Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.labelError1Text);
            this.Controls.Add(this.labelError1);
            this.Controls.Add(this.buttonCloseError1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormError1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseError1;
        private System.Windows.Forms.Label labelError1;
        private System.Windows.Forms.Label labelError1Text;
    }
}