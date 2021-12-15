namespace Курсовая2
{
    partial class FormRoles
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
            this.dataGridViewRoles = new System.Windows.Forms.DataGridView();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelAccessLevel = new System.Windows.Forms.Label();
            this.labelGmail = new System.Windows.Forms.Label();
            this.textBoxAccessLevel = new System.Windows.Forms.TextBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxGmail = new System.Windows.Forms.TextBox();
            this.labelRegistrationDate = new System.Windows.Forms.Label();
            this.textBoxReistrationDate = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRoles
            // 
            this.dataGridViewRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoles.Location = new System.Drawing.Point(16, 48);
            this.dataGridViewRoles.Name = "dataGridViewRoles";
            this.dataGridViewRoles.Size = new System.Drawing.Size(881, 390);
            this.dataGridViewRoles.TabIndex = 0;
            this.dataGridViewRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoles_CellClick);
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.BackColor = System.Drawing.Color.DimGray;
            this.buttonBackToMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackToMainMenu.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(95, 30);
            this.buttonBackToMainMenu.TabIndex = 1;
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
            this.buttonExit.Location = new System.Drawing.Point(944, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 30);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(487, 467);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 16);
            this.labelName.TabIndex = 45;
            this.labelName.Text = "Name";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(373, 467);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(58, 16);
            this.labelSurname.TabIndex = 44;
            this.labelSurname.Text = "Surname";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(265, 467);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(63, 16);
            this.labelPass.TabIndex = 43;
            this.labelPass.Text = "Password";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(169, 467);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(39, 16);
            this.labelLogin.TabIndex = 42;
            this.labelLogin.Text = "Login";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(73, 467);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(20, 16);
            this.labelID.TabIndex = 41;
            this.labelID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(34, 444);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(458, 444);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 12;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(352, 444);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 11;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(246, 444);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass.TabIndex = 10;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(140, 444);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 9;
            // 
            // labelAccessLevel
            // 
            this.labelAccessLevel.AutoSize = true;
            this.labelAccessLevel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccessLevel.Location = new System.Drawing.Point(679, 467);
            this.labelAccessLevel.Name = "labelAccessLevel";
            this.labelAccessLevel.Size = new System.Drawing.Size(83, 16);
            this.labelAccessLevel.TabIndex = 49;
            this.labelAccessLevel.Text = "Access Level";
            // 
            // labelGmail
            // 
            this.labelGmail.AutoSize = true;
            this.labelGmail.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGmail.Location = new System.Drawing.Point(591, 467);
            this.labelGmail.Name = "labelGmail";
            this.labelGmail.Size = new System.Drawing.Size(41, 16);
            this.labelGmail.TabIndex = 48;
            this.labelGmail.Text = "Gmail";
            // 
            // textBoxAccessLevel
            // 
            this.textBoxAccessLevel.Location = new System.Drawing.Point(670, 444);
            this.textBoxAccessLevel.Name = "textBoxAccessLevel";
            this.textBoxAccessLevel.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccessLevel.TabIndex = 14;
            // 
            // buttonUp
            // 
            this.buttonUp.BackColor = System.Drawing.Color.DimGray;
            this.buttonUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUp.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.buttonUp.Location = new System.Drawing.Point(944, 307);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(75, 30);
            this.buttonUp.TabIndex = 7;
            this.buttonUp.Text = "Update";
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.DimGray;
            this.buttonFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFind.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.buttonFind.Location = new System.Drawing.Point(944, 271);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 30);
            this.buttonFind.TabIndex = 6;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DimGray;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.buttonDelete.Location = new System.Drawing.Point(944, 235);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 30);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.DimGray;
            this.buttonChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChange.Font = new System.Drawing.Font("Rockwell", 12F);
            this.buttonChange.Location = new System.Drawing.Point(944, 199);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 30);
            this.buttonChange.TabIndex = 4;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DimGray;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(944, 163);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 30);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.DimGray;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("Rockwell", 8F);
            this.buttonClear.Location = new System.Drawing.Point(944, 444);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 20);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxGmail
            // 
            this.textBoxGmail.Location = new System.Drawing.Point(564, 444);
            this.textBoxGmail.Name = "textBoxGmail";
            this.textBoxGmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxGmail.TabIndex = 13;
            // 
            // labelRegistrationDate
            // 
            this.labelRegistrationDate.AutoSize = true;
            this.labelRegistrationDate.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrationDate.Location = new System.Drawing.Point(778, 467);
            this.labelRegistrationDate.Name = "labelRegistrationDate";
            this.labelRegistrationDate.Size = new System.Drawing.Size(105, 16);
            this.labelRegistrationDate.TabIndex = 51;
            this.labelRegistrationDate.Text = "Registration date";
            // 
            // textBoxReistrationDate
            // 
            this.textBoxReistrationDate.Location = new System.Drawing.Point(781, 444);
            this.textBoxReistrationDate.Mask = "00/00/0000";
            this.textBoxReistrationDate.Name = "textBoxReistrationDate";
            this.textBoxReistrationDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxReistrationDate.TabIndex = 61;
            this.textBoxReistrationDate.ValidatingType = typeof(System.DateTime);
            // 
            // FormRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1031, 519);
            this.Controls.Add(this.textBoxReistrationDate);
            this.Controls.Add(this.labelRegistrationDate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelAccessLevel);
            this.Controls.Add(this.labelGmail);
            this.Controls.Add(this.textBoxAccessLevel);
            this.Controls.Add(this.textBoxGmail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.dataGridViewRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRoles;
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelAccessLevel;
        private System.Windows.Forms.Label labelGmail;
        private System.Windows.Forms.TextBox textBoxAccessLevel;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxGmail;
        private System.Windows.Forms.Label labelRegistrationDate;
        private System.Windows.Forms.MaskedTextBox textBoxReistrationDate;
    }
}