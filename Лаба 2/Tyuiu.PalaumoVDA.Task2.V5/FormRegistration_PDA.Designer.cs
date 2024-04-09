namespace Tyuiu.PalaumoVDA.Task2.V5
{
    partial class FormRegistration_PDA
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogin_PDA = new System.Windows.Forms.Label();
            this.labelPass_PDA = new System.Windows.Forms.Label();
            this.labelPassPass_PDA = new System.Windows.Forms.Label();
            this.textBoxLogin_PDA = new System.Windows.Forms.TextBox();
            this.textBoxPass_PDA = new System.Windows.Forms.TextBox();
            this.textBoxPassPass_PDA = new System.Windows.Forms.TextBox();
            this.buttonRigistration_PDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(137, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // labelLogin_PDA
            // 
            this.labelLogin_PDA.AutoSize = true;
            this.labelLogin_PDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin_PDA.Location = new System.Drawing.Point(48, 108);
            this.labelLogin_PDA.Name = "labelLogin_PDA";
            this.labelLogin_PDA.Size = new System.Drawing.Size(88, 29);
            this.labelLogin_PDA.TabIndex = 1;
            this.labelLogin_PDA.Text = "Логин:";
            // 
            // labelPass_PDA
            // 
            this.labelPass_PDA.AutoSize = true;
            this.labelPass_PDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass_PDA.Location = new System.Drawing.Point(48, 182);
            this.labelPass_PDA.Name = "labelPass_PDA";
            this.labelPass_PDA.Size = new System.Drawing.Size(102, 29);
            this.labelPass_PDA.TabIndex = 2;
            this.labelPass_PDA.Text = "Пароль:";
            // 
            // labelPassPass_PDA
            // 
            this.labelPassPass_PDA.AutoSize = true;
            this.labelPassPass_PDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassPass_PDA.Location = new System.Drawing.Point(48, 265);
            this.labelPassPass_PDA.Name = "labelPassPass_PDA";
            this.labelPassPass_PDA.Size = new System.Drawing.Size(292, 29);
            this.labelPassPass_PDA.TabIndex = 3;
            this.labelPassPass_PDA.Text = "Подтверждение пароля:";
            // 
            // textBoxLogin_PDA
            // 
            this.textBoxLogin_PDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin_PDA.Location = new System.Drawing.Point(53, 140);
            this.textBoxLogin_PDA.Name = "textBoxLogin_PDA";
            this.textBoxLogin_PDA.Size = new System.Drawing.Size(315, 34);
            this.textBoxLogin_PDA.TabIndex = 4;
            // 
            // textBoxPass_PDA
            // 
            this.textBoxPass_PDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass_PDA.Location = new System.Drawing.Point(53, 214);
            this.textBoxPass_PDA.Name = "textBoxPass_PDA";
            this.textBoxPass_PDA.Size = new System.Drawing.Size(315, 34);
            this.textBoxPass_PDA.TabIndex = 5;
            // 
            // textBoxPassPass_PDA
            // 
            this.textBoxPassPass_PDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassPass_PDA.Location = new System.Drawing.Point(53, 306);
            this.textBoxPassPass_PDA.Name = "textBoxPassPass_PDA";
            this.textBoxPassPass_PDA.Size = new System.Drawing.Size(315, 34);
            this.textBoxPassPass_PDA.TabIndex = 6;
            // 
            // buttonRigistration_PDA
            // 
            this.buttonRigistration_PDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRigistration_PDA.Location = new System.Drawing.Point(69, 372);
            this.buttonRigistration_PDA.Name = "buttonRigistration_PDA";
            this.buttonRigistration_PDA.Size = new System.Drawing.Size(271, 90);
            this.buttonRigistration_PDA.TabIndex = 7;
            this.buttonRigistration_PDA.Text = "Зарегистрироваться";
            this.buttonRigistration_PDA.UseVisualStyleBackColor = true;
            this.buttonRigistration_PDA.Click += new System.EventHandler(this.buttonRigistration_PDA_Click);
            // 
            // FormRegistration_PDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 498);
            this.Controls.Add(this.buttonRigistration_PDA);
            this.Controls.Add(this.textBoxPassPass_PDA);
            this.Controls.Add(this.textBoxPass_PDA);
            this.Controls.Add(this.textBoxLogin_PDA);
            this.Controls.Add(this.labelPassPass_PDA);
            this.Controls.Add(this.labelPass_PDA);
            this.Controls.Add(this.labelLogin_PDA);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistration_PDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.FormRegistration_PDA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLogin_PDA;
        private System.Windows.Forms.Label labelPass_PDA;
        private System.Windows.Forms.Label labelPassPass_PDA;
        private System.Windows.Forms.TextBox textBoxLogin_PDA;
        private System.Windows.Forms.TextBox textBoxPass_PDA;
        private System.Windows.Forms.TextBox textBoxPassPass_PDA;
        private System.Windows.Forms.Button buttonRigistration_PDA;
    }
}