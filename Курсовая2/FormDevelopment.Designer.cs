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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxDeveloper = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelDeveloper = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevelopment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDevelopment
            // 
            this.dataGridViewDevelopment.AllowUserToAddRows = false;
            this.dataGridViewDevelopment.AllowUserToDeleteRows = false;
            this.dataGridViewDevelopment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDevelopment.Location = new System.Drawing.Point(12, 48);
            this.dataGridViewDevelopment.Name = "dataGridViewDevelopment";
            this.dataGridViewDevelopment.ReadOnly = true;
            this.dataGridViewDevelopment.Size = new System.Drawing.Size(574, 340);
            this.dataGridViewDevelopment.TabIndex = 0;
            this.dataGridViewDevelopment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDevelopment_CellClick);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DimGray;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(606, 12);
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
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DimGray;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(606, 114);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 30);
            this.buttonAdd.TabIndex = 21;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(136, 394);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 22;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(242, 394);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(100, 20);
            this.textBoxType.TabIndex = 23;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(348, 394);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(100, 20);
            this.textBoxStatus.TabIndex = 24;
            // 
            // textBoxDeveloper
            // 
            this.textBoxDeveloper.Location = new System.Drawing.Point(454, 394);
            this.textBoxDeveloper.Name = "textBoxDeveloper";
            this.textBoxDeveloper.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeveloper.TabIndex = 25;
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.DimGray;
            this.buttonChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChange.Font = new System.Drawing.Font("Rockwell", 12F);
            this.buttonChange.Location = new System.Drawing.Point(606, 150);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 30);
            this.buttonChange.TabIndex = 26;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DimGray;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.buttonDelete.Location = new System.Drawing.Point(606, 186);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 30);
            this.buttonDelete.TabIndex = 27;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.DimGray;
            this.buttonFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFind.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.buttonFind.Location = new System.Drawing.Point(606, 222);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 30);
            this.buttonFind.TabIndex = 28;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(30, 394);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 29;
            // 
            // buttonUp
            // 
            this.buttonUp.BackColor = System.Drawing.Color.DimGray;
            this.buttonUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUp.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.buttonUp.Location = new System.Drawing.Point(606, 258);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(75, 30);
            this.buttonUp.TabIndex = 30;
            this.buttonUp.Text = "Update";
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(69, 417);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(20, 16);
            this.labelID.TabIndex = 31;
            this.labelID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(165, 417);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 16);
            this.labelName.TabIndex = 32;
            this.labelName.Text = "Name";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(272, 417);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(36, 16);
            this.labelType.TabIndex = 33;
            this.labelType.Text = "Type";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(377, 417);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(42, 16);
            this.labelStatus.TabIndex = 34;
            this.labelStatus.Text = "Status";
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeveloper.Location = new System.Drawing.Point(459, 417);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(91, 16);
            this.labelDeveloper.TabIndex = 35;
            this.labelDeveloper.Text = "The Developer";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.DimGray;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("Rockwell", 8F);
            this.buttonClear.Location = new System.Drawing.Point(606, 394);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 20);
            this.buttonClear.TabIndex = 36;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormDevelopment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(693, 467);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelDeveloper);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.textBoxDeveloper);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonAdd);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDevelopment;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxDeveloper;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelDeveloper;
        private System.Windows.Forms.Button buttonClear;
    }
}