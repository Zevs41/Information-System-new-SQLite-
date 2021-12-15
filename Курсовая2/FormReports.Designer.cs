namespace Курсовая2
{
    partial class FormReports
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
            this.labelReports = new System.Windows.Forms.Label();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDevelopment = new System.Windows.Forms.Button();
            this.buttonNumberOfUsers = new System.Windows.Forms.Button();
            this.buttonNumberPerMomnth = new System.Windows.Forms.Button();
            this.dataGridViewReports = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).BeginInit();
            this.SuspendLayout();
            // 
            // labelReports
            // 
            this.labelReports.BackColor = System.Drawing.Color.Gray;
            this.labelReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReports.Location = new System.Drawing.Point(0, 0);
            this.labelReports.Name = "labelReports";
            this.labelReports.Size = new System.Drawing.Size(450, 50);
            this.labelReports.TabIndex = 0;
            this.labelReports.Text = "Reports";
            this.labelReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.BackColor = System.Drawing.Color.DimGray;
            this.buttonBackToMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackToMainMenu.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(10, 10);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(95, 30);
            this.buttonBackToMainMenu.TabIndex = 20;
            this.buttonBackToMainMenu.Text = "Back";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = false;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DimGray;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(365, 10);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 30);
            this.buttonExit.TabIndex = 21;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDevelopment
            // 
            this.buttonDevelopment.BackColor = System.Drawing.Color.DimGray;
            this.buttonDevelopment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDevelopment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDevelopment.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDevelopment.Location = new System.Drawing.Point(28, 107);
            this.buttonDevelopment.Name = "buttonDevelopment";
            this.buttonDevelopment.Size = new System.Drawing.Size(125, 50);
            this.buttonDevelopment.TabIndex = 22;
            this.buttonDevelopment.Text = "Monthly proceeds";
            this.buttonDevelopment.UseVisualStyleBackColor = false;
            this.buttonDevelopment.Click += new System.EventHandler(this.buttonDevelopment_Click);
            // 
            // buttonNumberOfUsers
            // 
            this.buttonNumberOfUsers.BackColor = System.Drawing.Color.DimGray;
            this.buttonNumberOfUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNumberOfUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNumberOfUsers.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumberOfUsers.Location = new System.Drawing.Point(159, 107);
            this.buttonNumberOfUsers.Name = "buttonNumberOfUsers";
            this.buttonNumberOfUsers.Size = new System.Drawing.Size(125, 50);
            this.buttonNumberOfUsers.TabIndex = 23;
            this.buttonNumberOfUsers.Text = "Number of users";
            this.buttonNumberOfUsers.UseVisualStyleBackColor = false;
            this.buttonNumberOfUsers.Click += new System.EventHandler(this.buttonNumberOfUsers_Click);
            // 
            // buttonNumberPerMomnth
            // 
            this.buttonNumberPerMomnth.BackColor = System.Drawing.Color.DimGray;
            this.buttonNumberPerMomnth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNumberPerMomnth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNumberPerMomnth.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumberPerMomnth.Location = new System.Drawing.Point(290, 107);
            this.buttonNumberPerMomnth.Name = "buttonNumberPerMomnth";
            this.buttonNumberPerMomnth.Size = new System.Drawing.Size(125, 50);
            this.buttonNumberPerMomnth.TabIndex = 24;
            this.buttonNumberPerMomnth.Text = "Number of users per month";
            this.buttonNumberPerMomnth.UseVisualStyleBackColor = false;
            this.buttonNumberPerMomnth.Click += new System.EventHandler(this.buttonNumberPerMomnth_Click);
            // 
            // dataGridViewReports
            // 
            this.dataGridViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReports.Location = new System.Drawing.Point(106, 181);
            this.dataGridViewReports.Name = "dataGridViewReports";
            this.dataGridViewReports.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewReports.TabIndex = 25;
            this.dataGridViewReports.Visible = false;
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(450, 214);
            this.Controls.Add(this.dataGridViewReports);
            this.Controls.Add(this.buttonNumberPerMomnth);
            this.Controls.Add(this.buttonNumberOfUsers);
            this.Controls.Add(this.buttonDevelopment);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.labelReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelReports;
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDevelopment;
        private System.Windows.Forms.Button buttonNumberOfUsers;
        private System.Windows.Forms.Button buttonNumberPerMomnth;
        private System.Windows.Forms.DataGridView dataGridViewReports;
    }
}