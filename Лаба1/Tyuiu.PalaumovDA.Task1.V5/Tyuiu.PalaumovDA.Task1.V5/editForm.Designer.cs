namespace Tyuiu.PalaumovDA.Task1.V5
{
    partial class editFormPalaumovDA
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
            this.buttonOpenPalaumovDA = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewEditPalaumovDA = new System.Windows.Forms.DataGridView();
            this.buttonSavePalaumovDA = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonCloselPalaumovDA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditPalaumovDA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenPalaumovDA
            // 
            this.buttonOpenPalaumovDA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonOpenPalaumovDA.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenPalaumovDA.Location = new System.Drawing.Point(631, 60);
            this.buttonOpenPalaumovDA.Name = "buttonOpenPalaumovDA";
            this.buttonOpenPalaumovDA.Size = new System.Drawing.Size(157, 76);
            this.buttonOpenPalaumovDA.TabIndex = 0;
            this.buttonOpenPalaumovDA.Text = "Открыть";
            this.buttonOpenPalaumovDA.UseVisualStyleBackColor = true;
            this.buttonOpenPalaumovDA.Click += new System.EventHandler(this.buttonOpenPalaumovDA_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridViewEditPalaumovDA
            // 
            this.dataGridViewEditPalaumovDA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewEditPalaumovDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEditPalaumovDA.Location = new System.Drawing.Point(12, 27);
            this.dataGridViewEditPalaumovDA.Name = "dataGridViewEditPalaumovDA";
            this.dataGridViewEditPalaumovDA.RowHeadersWidth = 51;
            this.dataGridViewEditPalaumovDA.RowTemplate.Height = 24;
            this.dataGridViewEditPalaumovDA.Size = new System.Drawing.Size(597, 381);
            this.dataGridViewEditPalaumovDA.TabIndex = 1;
            // 
            // buttonSavePalaumovDA
            // 
            this.buttonSavePalaumovDA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSavePalaumovDA.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSavePalaumovDA.Location = new System.Drawing.Point(631, 167);
            this.buttonSavePalaumovDA.Name = "buttonSavePalaumovDA";
            this.buttonSavePalaumovDA.Size = new System.Drawing.Size(157, 76);
            this.buttonSavePalaumovDA.TabIndex = 2;
            this.buttonSavePalaumovDA.Text = "Сохранить";
            this.buttonSavePalaumovDA.UseVisualStyleBackColor = true;
            this.buttonSavePalaumovDA.Click += new System.EventHandler(this.buttonSavePalaumovDA_Click);
            // 
            // buttonCloselPalaumovDA
            // 
            this.buttonCloselPalaumovDA.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloselPalaumovDA.Location = new System.Drawing.Point(631, 270);
            this.buttonCloselPalaumovDA.Name = "buttonCloselPalaumovDA";
            this.buttonCloselPalaumovDA.Size = new System.Drawing.Size(157, 76);
            this.buttonCloselPalaumovDA.TabIndex = 3;
            this.buttonCloselPalaumovDA.Text = "Закрыть";
            this.buttonCloselPalaumovDA.UseVisualStyleBackColor = true;
            this.buttonCloselPalaumovDA.Click += new System.EventHandler(this.buttonCloselPalaumovDA_Click);
            // 
            // editFormPalaumovDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCloselPalaumovDA);
            this.Controls.Add(this.buttonSavePalaumovDA);
            this.Controls.Add(this.dataGridViewEditPalaumovDA);
            this.Controls.Add(this.buttonOpenPalaumovDA);
            this.Name = "editFormPalaumovDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Админ";
            this.Load += new System.EventHandler(this.editFormPalaumovDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditPalaumovDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenPalaumovDA;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridViewEditPalaumovDA;
        private System.Windows.Forms.Button buttonSavePalaumovDA;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonCloselPalaumovDA;
    }
}