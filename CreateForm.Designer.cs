namespace AuthentificationZI
{
    partial class CreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxP1 = new System.Windows.Forms.TextBox();
            this.textBoxP2 = new System.Windows.Forms.TextBox();
            this.backbutton = new System.Windows.Forms.Button();
            this.buttondone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.differentpasslabel = new System.Windows.Forms.Label();
            this.buttonShowPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(82, 139);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(289, 27);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.Text = "defaultlogin";
            // 
            // textBoxP1
            // 
            this.textBoxP1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxP1.Location = new System.Drawing.Point(82, 230);
            this.textBoxP1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxP1.Name = "textBoxP1";
            this.textBoxP1.PasswordChar = '*';
            this.textBoxP1.Size = new System.Drawing.Size(289, 27);
            this.textBoxP1.TabIndex = 1;
            this.textBoxP1.Text = "123";
            // 
            // textBoxP2
            // 
            this.textBoxP2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxP2.Location = new System.Drawing.Point(82, 322);
            this.textBoxP2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxP2.Name = "textBoxP2";
            this.textBoxP2.PasswordChar = '*';
            this.textBoxP2.Size = new System.Drawing.Size(289, 27);
            this.textBoxP2.TabIndex = 2;
            this.textBoxP2.Text = "123";
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.SystemColors.Control;
            this.backbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbutton.Location = new System.Drawing.Point(16, 18);
            this.backbutton.Margin = new System.Windows.Forms.Padding(4);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(100, 34);
            this.backbutton.TabIndex = 3;
            this.backbutton.Text = "🡨Назад";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // buttondone
            // 
            this.buttondone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(50)))));
            this.buttondone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttondone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttondone.Location = new System.Drawing.Point(128, 393);
            this.buttondone.Margin = new System.Windows.Forms.Padding(4);
            this.buttondone.Name = "buttondone";
            this.buttondone.Size = new System.Drawing.Size(192, 86);
            this.buttondone.TabIndex = 4;
            this.buttondone.Text = "Готово";
            this.buttondone.UseVisualStyleBackColor = false;
            this.buttondone.Click += new System.EventHandler(this.buttondone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(82, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(82, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Повторите пароль";
            // 
            // differentpasslabel
            // 
            this.differentpasslabel.AutoSize = true;
            this.differentpasslabel.ForeColor = System.Drawing.Color.Red;
            this.differentpasslabel.Location = new System.Drawing.Point(86, 357);
            this.differentpasslabel.Name = "differentpasslabel";
            this.differentpasslabel.Size = new System.Drawing.Size(172, 19);
            this.differentpasslabel.TabIndex = 6;
            this.differentpasslabel.Text = "*Пароли не совпадают!";
            this.differentpasslabel.Visible = false;
            // 
            // buttonShowPass
            // 
            this.buttonShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonShowPass.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowPass.Image")));
            this.buttonShowPass.Location = new System.Drawing.Point(378, 230);
            this.buttonShowPass.Name = "buttonShowPass";
            this.buttonShowPass.Size = new System.Drawing.Size(37, 27);
            this.buttonShowPass.TabIndex = 7;
            this.buttonShowPass.UseVisualStyleBackColor = true;
            this.buttonShowPass.Click += new System.EventHandler(this.buttonShowPass_Click);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 522);
            this.Controls.Add(this.buttonShowPass);
            this.Controls.Add(this.differentpasslabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttondone);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.textBoxP2);
            this.Controls.Add(this.textBoxP1);
            this.Controls.Add(this.textBoxLogin);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateForm";
            this.Text = "CreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxP1;
        private System.Windows.Forms.TextBox textBoxP2;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button buttondone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label differentpasslabel;
        private System.Windows.Forms.Button buttonShowPass;
    }
}