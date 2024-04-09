namespace Tyuiu.PalaumovDA.Task1.V5
{
    partial class adminFormPalaumovDA
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
            this.textBoxLoginPalaumovDA = new System.Windows.Forms.TextBox();
            this.textBoxParolPAlaumovDA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLogPalaumovDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLoginPalaumovDA
            // 
            this.textBoxLoginPalaumovDA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxLoginPalaumovDA.Location = new System.Drawing.Point(152, 62);
            this.textBoxLoginPalaumovDA.Name = "textBoxLoginPalaumovDA";
            this.textBoxLoginPalaumovDA.Size = new System.Drawing.Size(174, 22);
            this.textBoxLoginPalaumovDA.TabIndex = 0;
            // 
            // textBoxParolPAlaumovDA
            // 
            this.textBoxParolPAlaumovDA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxParolPAlaumovDA.Location = new System.Drawing.Point(152, 118);
            this.textBoxParolPAlaumovDA.Name = "textBoxParolPAlaumovDA";
            this.textBoxParolPAlaumovDA.Size = new System.Drawing.Size(174, 22);
            this.textBoxParolPAlaumovDA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(159, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Авторизация";
            // 
            // buttonLogPalaumovDA
            // 
            this.buttonLogPalaumovDA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLogPalaumovDA.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogPalaumovDA.Location = new System.Drawing.Point(170, 166);
            this.buttonLogPalaumovDA.Name = "buttonLogPalaumovDA";
            this.buttonLogPalaumovDA.Size = new System.Drawing.Size(137, 48);
            this.buttonLogPalaumovDA.TabIndex = 5;
            this.buttonLogPalaumovDA.Text = "Войти";
            this.buttonLogPalaumovDA.UseVisualStyleBackColor = true;
            this.buttonLogPalaumovDA.Click += new System.EventHandler(this.buttonLogPalaumovDA_Click);
            // 
            // adminFormPalaumovDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 236);
            this.Controls.Add(this.buttonLogPalaumovDA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxParolPAlaumovDA);
            this.Controls.Add(this.textBoxLoginPalaumovDA);
            this.Name = "adminFormPalaumovDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLoginPalaumovDA;
        private System.Windows.Forms.TextBox textBoxParolPAlaumovDA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLogPalaumovDA;
    }
}