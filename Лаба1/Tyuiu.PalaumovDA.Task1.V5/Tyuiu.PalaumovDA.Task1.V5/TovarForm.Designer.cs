namespace Tyuiu.PalaumovDA.Task1.V5
{
    partial class TovarFormPalaumovDA
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
            this.dataGridViewTovarPalaumovDA = new System.Windows.Forms.DataGridView();
            this.textBoxProductNamePalaumovDA = new System.Windows.Forms.TextBox();
            this.buttonSearchProductPalaumovDA = new System.Windows.Forms.Button();
            this.buttonAllPalaumovDA = new System.Windows.Forms.Button();
            this.labelPoiskPalaumovDA = new System.Windows.Forms.Label();
            this.buttonClosePalaumovDA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTovarPalaumovDA)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTovarPalaumovDA
            // 
            this.dataGridViewTovarPalaumovDA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewTovarPalaumovDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTovarPalaumovDA.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTovarPalaumovDA.Name = "dataGridViewTovarPalaumovDA";
            this.dataGridViewTovarPalaumovDA.RowHeadersWidth = 51;
            this.dataGridViewTovarPalaumovDA.RowTemplate.Height = 24;
            this.dataGridViewTovarPalaumovDA.Size = new System.Drawing.Size(735, 421);
            this.dataGridViewTovarPalaumovDA.TabIndex = 0;
            // 
            // textBoxProductNamePalaumovDA
            // 
            this.textBoxProductNamePalaumovDA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxProductNamePalaumovDA.Location = new System.Drawing.Point(771, 184);
            this.textBoxProductNamePalaumovDA.Name = "textBoxProductNamePalaumovDA";
            this.textBoxProductNamePalaumovDA.Size = new System.Drawing.Size(160, 22);
            this.textBoxProductNamePalaumovDA.TabIndex = 1;
            // 
            // buttonSearchProductPalaumovDA
            // 
            this.buttonSearchProductPalaumovDA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSearchProductPalaumovDA.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchProductPalaumovDA.Location = new System.Drawing.Point(771, 227);
            this.buttonSearchProductPalaumovDA.Name = "buttonSearchProductPalaumovDA";
            this.buttonSearchProductPalaumovDA.Size = new System.Drawing.Size(160, 71);
            this.buttonSearchProductPalaumovDA.TabIndex = 2;
            this.buttonSearchProductPalaumovDA.Text = "Поиск";
            this.buttonSearchProductPalaumovDA.UseVisualStyleBackColor = true;
            this.buttonSearchProductPalaumovDA.Click += new System.EventHandler(this.buttonSearchProductPalaumovDA_Click);
            // 
            // buttonAllPalaumovDA
            // 
            this.buttonAllPalaumovDA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAllPalaumovDA.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAllPalaumovDA.Location = new System.Drawing.Point(771, 38);
            this.buttonAllPalaumovDA.Name = "buttonAllPalaumovDA";
            this.buttonAllPalaumovDA.Size = new System.Drawing.Size(160, 71);
            this.buttonAllPalaumovDA.TabIndex = 3;
            this.buttonAllPalaumovDA.Text = "Показать все";
            this.buttonAllPalaumovDA.UseVisualStyleBackColor = true;
            this.buttonAllPalaumovDA.Click += new System.EventHandler(this.buttonAllPalaumovDA_Click);
            // 
            // labelPoiskPalaumovDA
            // 
            this.labelPoiskPalaumovDA.AutoSize = true;
            this.labelPoiskPalaumovDA.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoiskPalaumovDA.Location = new System.Drawing.Point(760, 136);
            this.labelPoiskPalaumovDA.Name = "labelPoiskPalaumovDA";
            this.labelPoiskPalaumovDA.Size = new System.Drawing.Size(179, 33);
            this.labelPoiskPalaumovDA.TabIndex = 4;
            this.labelPoiskPalaumovDA.Text = "Найти товары";
            // 
            // buttonClosePalaumovDA
            // 
            this.buttonClosePalaumovDA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonClosePalaumovDA.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClosePalaumovDA.Location = new System.Drawing.Point(771, 335);
            this.buttonClosePalaumovDA.Name = "buttonClosePalaumovDA";
            this.buttonClosePalaumovDA.Size = new System.Drawing.Size(160, 71);
            this.buttonClosePalaumovDA.TabIndex = 5;
            this.buttonClosePalaumovDA.Text = "Закрыть";
            this.buttonClosePalaumovDA.UseVisualStyleBackColor = true;
            this.buttonClosePalaumovDA.Click += new System.EventHandler(this.buttonClosePalaumovDA_Click);
            // 
            // TovarFormPalaumovDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 459);
            this.Controls.Add(this.buttonClosePalaumovDA);
            this.Controls.Add(this.labelPoiskPalaumovDA);
            this.Controls.Add(this.buttonAllPalaumovDA);
            this.Controls.Add(this.buttonSearchProductPalaumovDA);
            this.Controls.Add(this.textBoxProductNamePalaumovDA);
            this.Controls.Add(this.dataGridViewTovarPalaumovDA);
            this.Name = "TovarFormPalaumovDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.TovarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTovarPalaumovDA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTovarPalaumovDA;
        private System.Windows.Forms.TextBox textBoxProductNamePalaumovDA;
        private System.Windows.Forms.Button buttonSearchProductPalaumovDA;
        private System.Windows.Forms.Button buttonAllPalaumovDA;
        private System.Windows.Forms.Label labelPoiskPalaumovDA;
        private System.Windows.Forms.Button buttonClosePalaumovDA;
    }
}