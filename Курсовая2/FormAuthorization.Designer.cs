namespace Курсовая2
{
    partial class FormAuthorization
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonAuthorization = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.dataGridViewCheck = new System.Windows.Forms.DataGridView();
            this.buttonBackToEntance = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelBackground = new System.Windows.Forms.Label();
            this.buttonViewPass = new System.Windows.Forms.Button();
            this.labelPictureOrg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.Silver;
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLogin.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(141, 78);
            this.textBoxLogin.MinimumSize = new System.Drawing.Size(200, 50);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(200, 50);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.Silver;
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPass.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(141, 134);
            this.textBoxPass.MinimumSize = new System.Drawing.Size(200, 50);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(200, 50);
            this.textBoxPass.TabIndex = 1;
            // 
            // buttonAuthorization
            // 
            this.buttonAuthorization.BackColor = System.Drawing.Color.DimGray;
            this.buttonAuthorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAuthorization.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAuthorization.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAuthorization.Location = new System.Drawing.Point(121, 190);
            this.buttonAuthorization.Name = "buttonAuthorization";
            this.buttonAuthorization.Size = new System.Drawing.Size(150, 50);
            this.buttonAuthorization.TabIndex = 2;
            this.buttonAuthorization.Text = "Authorization";
            this.buttonAuthorization.UseVisualStyleBackColor = false;
            this.buttonAuthorization.Click += new System.EventHandler(this.buttonAuthorization_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(26, 89);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(83, 31);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Login";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(4, 144);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(131, 31);
            this.labelPass.TabIndex = 4;
            this.labelPass.Text = "Password";
            // 
            // dataGridViewCheck
            // 
            this.dataGridViewCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheck.Location = new System.Drawing.Point(367, 200);
            this.dataGridViewCheck.Name = "dataGridViewCheck";
            this.dataGridViewCheck.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewCheck.TabIndex = 5;
            this.dataGridViewCheck.Visible = false;
            // 
            // buttonBackToEntance
            // 
            this.buttonBackToEntance.BackColor = System.Drawing.Color.DimGray;
            this.buttonBackToEntance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackToEntance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackToEntance.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToEntance.Location = new System.Drawing.Point(1, 1);
            this.buttonBackToEntance.Name = "buttonBackToEntance";
            this.buttonBackToEntance.Size = new System.Drawing.Size(75, 30);
            this.buttonBackToEntance.TabIndex = 6;
            this.buttonBackToEntance.Text = "Back";
            this.buttonBackToEntance.UseVisualStyleBackColor = false;
            this.buttonBackToEntance.Click += new System.EventHandler(this.buttonBackToEntance_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DimGray;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(324, 1);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 30);
            this.buttonExit.TabIndex = 16;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelBackground
            // 
            this.labelBackground.BackColor = System.Drawing.Color.Gray;
            this.labelBackground.Enabled = false;
            this.labelBackground.Location = new System.Drawing.Point(1, 1);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(398, 35);
            this.labelBackground.TabIndex = 17;
            // 
            // buttonViewPass
            // 
            this.buttonViewPass.BackColor = System.Drawing.Color.Gray;
            this.buttonViewPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonViewPass.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonViewPass.Location = new System.Drawing.Point(347, 134);
            this.buttonViewPass.Name = "buttonViewPass";
            this.buttonViewPass.Size = new System.Drawing.Size(50, 50);
            this.buttonViewPass.TabIndex = 18;
            this.buttonViewPass.Text = "d";
            this.buttonViewPass.UseVisualStyleBackColor = false;
            this.buttonViewPass.Click += new System.EventHandler(this.buttonViewPass_Click);
            // 
            // labelPictureOrg
            // 
            this.labelPictureOrg.BackColor = System.Drawing.Color.DarkGray;
            this.labelPictureOrg.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelPictureOrg.Location = new System.Drawing.Point(347, 81);
            this.labelPictureOrg.Name = "labelPictureOrg";
            this.labelPictureOrg.Size = new System.Drawing.Size(50, 50);
            this.labelPictureOrg.TabIndex = 19;
            this.labelPictureOrg.Text = "m";
            this.labelPictureOrg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.labelPictureOrg);
            this.Controls.Add(this.buttonViewPass);
            this.Controls.Add(this.labelBackground);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBackToEntance);
            this.Controls.Add(this.dataGridViewCheck);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonAuthorization);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAuthorization_FormClosing);
            this.Load += new System.EventHandler(this.FormAuthorization_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonAuthorization;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.DataGridView dataGridViewCheck;
        private System.Windows.Forms.Button buttonBackToEntance;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.Button buttonViewPass;
        private System.Windows.Forms.Label labelPictureOrg;
    }
}