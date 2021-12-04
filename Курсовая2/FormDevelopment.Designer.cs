namespace Курсовая2
{
    partial class FormDevelopment
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
            this.dataGridViewDevelopment = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevelopment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDevelopment
            // 
            this.dataGridViewDevelopment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDevelopment.Location = new System.Drawing.Point(12, 48);
            this.dataGridViewDevelopment.Name = "dataGridViewDevelopment";
            this.dataGridViewDevelopment.Size = new System.Drawing.Size(444, 340);
            this.dataGridViewDevelopment.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DimGray;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(543, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 30);
            this.buttonExit.TabIndex = 18;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.BackColor = System.Drawing.Color.DimGray;
            this.buttonBackToMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackToMainMenu.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(75, 30);
            this.buttonBackToMainMenu.TabIndex = 20;
            this.buttonBackToMainMenu.Text = "Back";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = false;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // FormDevelopment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(630, 400);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridViewDevelopment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDevelopment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDevelopment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevelopment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDevelopment;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonBackToMainMenu;
    }
}