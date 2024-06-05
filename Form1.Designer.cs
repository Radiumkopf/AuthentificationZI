namespace AuthentificationZI
{
    partial class Form1
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
            this.entirebutton = new System.Windows.Forms.Button();
            this.newAccButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entirebutton
            // 
            this.entirebutton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entirebutton.Location = new System.Drawing.Point(85, 135);
            this.entirebutton.Name = "entirebutton";
            this.entirebutton.Size = new System.Drawing.Size(141, 58);
            this.entirebutton.TabIndex = 0;
            this.entirebutton.Text = "Войти";
            this.entirebutton.UseVisualStyleBackColor = true;
            // 
            // newAccButton
            // 
            this.newAccButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.newAccButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newAccButton.Location = new System.Drawing.Point(85, 228);
            this.newAccButton.Name = "newAccButton";
            this.newAccButton.Size = new System.Drawing.Size(141, 69);
            this.newAccButton.TabIndex = 1;
            this.newAccButton.Text = "Создать аккаунт";
            this.newAccButton.UseVisualStyleBackColor = false;
            this.newAccButton.Click += new System.EventHandler(this.newAccButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 450);
            this.Controls.Add(this.newAccButton);
            this.Controls.Add(this.entirebutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button entirebutton;
        private System.Windows.Forms.Button newAccButton;
    }
}

