namespace Tyuiu.PalaumoVDA.Task2.V5
{
    partial class FormLoginPalaumovDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginPalaumovDA));
            this.textBoxLoginPalaumovDA = new System.Windows.Forms.TextBox();
            this.labelAvtPalaumovDA = new System.Windows.Forms.Label();
            this.labellogPalaumovDA = new System.Windows.Forms.Label();
            this.labelpassPalaumovDA = new System.Windows.Forms.Label();
            this.textBoxpassPalaumovDA = new System.Windows.Forms.TextBox();
            this.buttonloginPalaumovDA = new System.Windows.Forms.Button();
            this.labelSignin_PDA = new System.Windows.Forms.Label();
            this.buttonRegistr_PDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLoginPalaumovDA
            // 
            this.textBoxLoginPalaumovDA.Location = new System.Drawing.Point(90, 149);
            this.textBoxLoginPalaumovDA.Name = "textBoxLoginPalaumovDA";
            this.textBoxLoginPalaumovDA.Size = new System.Drawing.Size(233, 22);
            this.textBoxLoginPalaumovDA.TabIndex = 1;
            // 
            // labelAvtPalaumovDA
            // 
            this.labelAvtPalaumovDA.AutoSize = true;
            this.labelAvtPalaumovDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAvtPalaumovDA.Location = new System.Drawing.Point(73, 45);
            this.labelAvtPalaumovDA.Name = "labelAvtPalaumovDA";
            this.labelAvtPalaumovDA.Size = new System.Drawing.Size(269, 38);
            this.labelAvtPalaumovDA.TabIndex = 2;
            this.labelAvtPalaumovDA.Text = "АВТОРИЗАЦИЯ";
            // 
            // labellogPalaumovDA
            // 
            this.labellogPalaumovDA.AutoSize = true;
            this.labellogPalaumovDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labellogPalaumovDA.Location = new System.Drawing.Point(158, 107);
            this.labellogPalaumovDA.Name = "labellogPalaumovDA";
            this.labellogPalaumovDA.Size = new System.Drawing.Size(105, 29);
            this.labellogPalaumovDA.TabIndex = 3;
            this.labellogPalaumovDA.Text = "ЛОГИН:";
            // 
            // labelpassPalaumovDA
            // 
            this.labelpassPalaumovDA.AutoSize = true;
            this.labelpassPalaumovDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelpassPalaumovDA.Location = new System.Drawing.Point(152, 194);
            this.labelpassPalaumovDA.Name = "labelpassPalaumovDA";
            this.labelpassPalaumovDA.Size = new System.Drawing.Size(119, 29);
            this.labelpassPalaumovDA.TabIndex = 4;
            this.labelpassPalaumovDA.Text = "ПАРОЛЬ:";
            // 
            // textBoxpassPalaumovDA
            // 
            this.textBoxpassPalaumovDA.Location = new System.Drawing.Point(90, 238);
            this.textBoxpassPalaumovDA.Name = "textBoxpassPalaumovDA";
            this.textBoxpassPalaumovDA.PasswordChar = '*';
            this.textBoxpassPalaumovDA.Size = new System.Drawing.Size(233, 22);
            this.textBoxpassPalaumovDA.TabIndex = 5;
            // 
            // buttonloginPalaumovDA
            // 
            this.buttonloginPalaumovDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonloginPalaumovDA.Location = new System.Drawing.Point(115, 292);
            this.buttonloginPalaumovDA.Name = "buttonloginPalaumovDA";
            this.buttonloginPalaumovDA.Size = new System.Drawing.Size(190, 56);
            this.buttonloginPalaumovDA.TabIndex = 6;
            this.buttonloginPalaumovDA.Text = "ВОЙТИ";
            this.buttonloginPalaumovDA.UseVisualStyleBackColor = true;
            this.buttonloginPalaumovDA.Click += new System.EventHandler(this.buttonloginPalaumovDA_Click);
            // 
            // labelSignin_PDA
            // 
            this.labelSignin_PDA.AutoSize = true;
            this.labelSignin_PDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSignin_PDA.Location = new System.Drawing.Point(122, 366);
            this.labelSignin_PDA.Name = "labelSignin_PDA";
            this.labelSignin_PDA.Size = new System.Drawing.Size(173, 29);
            this.labelSignin_PDA.TabIndex = 7;
            this.labelSignin_PDA.Text = "Нет аккаунта?";
            // 
            // buttonRegistr_PDA
            // 
            this.buttonRegistr_PDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistr_PDA.Location = new System.Drawing.Point(115, 416);
            this.buttonRegistr_PDA.Name = "buttonRegistr_PDA";
            this.buttonRegistr_PDA.Size = new System.Drawing.Size(190, 56);
            this.buttonRegistr_PDA.TabIndex = 8;
            this.buttonRegistr_PDA.Text = "Регистрация";
            this.buttonRegistr_PDA.UseVisualStyleBackColor = true;
            this.buttonRegistr_PDA.Click += new System.EventHandler(this.buttonRegistr_PDA_Click);
            // 
            // FormLoginPalaumovDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(431, 498);
            this.Controls.Add(this.buttonRegistr_PDA);
            this.Controls.Add(this.labelSignin_PDA);
            this.Controls.Add(this.buttonloginPalaumovDA);
            this.Controls.Add(this.textBoxpassPalaumovDA);
            this.Controls.Add(this.labelpassPalaumovDA);
            this.Controls.Add(this.labellogPalaumovDA);
            this.Controls.Add(this.labelAvtPalaumovDA);
            this.Controls.Add(this.textBoxLoginPalaumovDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLoginPalaumovDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авиапассажирские перевозки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxLoginPalaumovDA;
        private System.Windows.Forms.Label labelAvtPalaumovDA;
        private System.Windows.Forms.Label labellogPalaumovDA;
        private System.Windows.Forms.Label labelpassPalaumovDA;
        private System.Windows.Forms.TextBox textBoxpassPalaumovDA;
        private System.Windows.Forms.Button buttonloginPalaumovDA;
        private System.Windows.Forms.Label labelSignin_PDA;
        private System.Windows.Forms.Button buttonRegistr_PDA;
    }
}

