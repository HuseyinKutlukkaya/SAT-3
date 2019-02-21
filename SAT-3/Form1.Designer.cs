namespace SAT_3
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
            this.tb_denklem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_aciklama = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_ck = new System.Windows.Forms.Label();
            this.BTNCOZ = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_denklem
            // 
            this.tb_denklem.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_denklem.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_denklem.Location = new System.Drawing.Point(0, 0);
            this.tb_denklem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_denklem.Name = "tb_denklem";
            this.tb_denklem.Size = new System.Drawing.Size(1532, 40);
            this.tb_denklem.TabIndex = 4;
            this.tb_denklem.Text = "(b+a+c\').(a\'+b\'+d)";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lbl_aciklama);
            this.panel1.Location = new System.Drawing.Point(21, 243);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 491);
            this.panel1.TabIndex = 6;
            // 
            // lbl_aciklama
            // 
            this.lbl_aciklama.AutoSize = true;
            this.lbl_aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aciklama.Location = new System.Drawing.Point(3, 12);
            this.lbl_aciklama.Name = "lbl_aciklama";
            this.lbl_aciklama.Size = new System.Drawing.Size(0, 29);
            this.lbl_aciklama.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(967, 243);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(540, 491);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_ck
            // 
            this.lbl_ck.AutoSize = true;
            this.lbl_ck.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ck.Location = new System.Drawing.Point(15, 100);
            this.lbl_ck.Name = "lbl_ck";
            this.lbl_ck.Size = new System.Drawing.Size(0, 36);
            this.lbl_ck.TabIndex = 7;
            // 
            // BTNCOZ
            // 
            this.BTNCOZ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTNCOZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNCOZ.Location = new System.Drawing.Point(1348, 87);
            this.BTNCOZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNCOZ.Name = "BTNCOZ";
            this.BTNCOZ.Size = new System.Drawing.Size(147, 55);
            this.BTNCOZ.TabIndex = 8;
            this.BTNCOZ.Text = "ÇÖZ";
            this.BTNCOZ.UseVisualStyleBackColor = true;
            this.BTNCOZ.Click += new System.EventHandler(this.BTNCOZ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 766);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNCOZ);
            this.Controls.Add(this.lbl_ck);
            this.Controls.Add(this.tb_denklem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

  
        private System.Windows.Forms.TextBox tb_denklem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_aciklama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_ck;
        private System.Windows.Forms.Button BTNCOZ;
    }
}

