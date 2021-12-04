namespace Курсовая2
{
    partial class FormEntance
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAuthorization = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAuthorization
            // 
            this.buttonAuthorization.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAuthorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAuthorization.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAuthorization.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAuthorization.Location = new System.Drawing.Point(120, 95);
            this.buttonAuthorization.Name = "buttonAuthorization";
            this.buttonAuthorization.Size = new System.Drawing.Size(150, 50);
            this.buttonAuthorization.TabIndex = 0;
            this.buttonAuthorization.Text = "Authorization";
            this.buttonAuthorization.UseVisualStyleBackColor = false;
            this.buttonAuthorization.Click += new System.EventHandler(this.buttonAuthorization_Click);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.BackColor = System.Drawing.Color.DarkGray;
            this.buttonRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegistration.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistration.Location = new System.Drawing.Point(120, 151);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(150, 50);
            this.buttonRegistration.TabIndex = 1;
            this.buttonRegistration.Text = "Registration";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // labelNameOrganization
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 36);
            this.label1.Name = "labelNameOrganization";
            this.label1.Size = new System.Drawing.Size(180, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "ImmortaL";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DarkGray;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(320, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 30);
            this.buttonExit.TabIndex = 16;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormEntance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.buttonAuthorization);
            this.Name = "FormEntance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entance";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }

        #endregion

        private System.Windows.Forms.Button buttonAuthorization;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
    }
}

