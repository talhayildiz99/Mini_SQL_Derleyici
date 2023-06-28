namespace Mini_SQL_Derleyici
{
    partial class Form1
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
            this.DgvCikti = new System.Windows.Forms.DataGridView();
            this.BtnCalistir = new System.Windows.Forms.Button();
            this.RTxtSorgu = new System.Windows.Forms.RichTextBox();
            this.BtnBilgi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCikti)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCikti
            // 
            this.DgvCikti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCikti.Location = new System.Drawing.Point(1, 290);
            this.DgvCikti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvCikti.Name = "DgvCikti";
            this.DgvCikti.RowHeadersWidth = 51;
            this.DgvCikti.RowTemplate.Height = 24;
            this.DgvCikti.Size = new System.Drawing.Size(1212, 398);
            this.DgvCikti.TabIndex = 0;
            // 
            // BtnCalistir
            // 
            this.BtnCalistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnCalistir.ForeColor = System.Drawing.Color.White;
            this.BtnCalistir.Location = new System.Drawing.Point(970, -1);
            this.BtnCalistir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCalistir.Name = "BtnCalistir";
            this.BtnCalistir.Size = new System.Drawing.Size(244, 150);
            this.BtnCalistir.TabIndex = 1;
            this.BtnCalistir.Text = "Çalıştır";
            this.BtnCalistir.UseVisualStyleBackColor = false;
            // 
            // RTxtSorgu
            // 
            this.RTxtSorgu.BackColor = System.Drawing.SystemColors.Info;
            this.RTxtSorgu.Location = new System.Drawing.Point(1, -1);
            this.RTxtSorgu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RTxtSorgu.Name = "RTxtSorgu";
            this.RTxtSorgu.Size = new System.Drawing.Size(970, 292);
            this.RTxtSorgu.TabIndex = 2;
            this.RTxtSorgu.Text = "";
            // 
            // BtnBilgi
            // 
            this.BtnBilgi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBilgi.ForeColor = System.Drawing.Color.White;
            this.BtnBilgi.Location = new System.Drawing.Point(970, 141);
            this.BtnBilgi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBilgi.Name = "BtnBilgi";
            this.BtnBilgi.Size = new System.Drawing.Size(244, 150);
            this.BtnBilgi.TabIndex = 3;
            this.BtnBilgi.Text = "SQL Hakkında";
            this.BtnBilgi.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 690);
            this.Controls.Add(this.BtnBilgi);
            this.Controls.Add(this.RTxtSorgu);
            this.Controls.Add(this.BtnCalistir);
            this.Controls.Add(this.DgvCikti);
            this.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCikti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCikti;
        private System.Windows.Forms.Button BtnCalistir;
        private System.Windows.Forms.RichTextBox RTxtSorgu;
        private System.Windows.Forms.Button BtnBilgi;
    }
}

