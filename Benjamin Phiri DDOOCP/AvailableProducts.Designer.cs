namespace Benjamin_Phiri_DDOOCP
{
    partial class AvailableProducts
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
            this.lblAV_Desc = new System.Windows.Forms.Label();
            this.cmdShowP = new System.Windows.Forms.Button();
            this.lblavailableP = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAV_Desc
            // 
            this.lblAV_Desc.AutoSize = true;
            this.lblAV_Desc.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAV_Desc.Location = new System.Drawing.Point(47, 110);
            this.lblAV_Desc.Name = "lblAV_Desc";
            this.lblAV_Desc.Size = new System.Drawing.Size(394, 25);
            this.lblAV_Desc.TabIndex = 7;
            this.lblAV_Desc.Text = "List of all products that are available for rent";
            // 
            // cmdShowP
            // 
            this.cmdShowP.BackColor = System.Drawing.Color.LightSalmon;
            this.cmdShowP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdShowP.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdShowP.Location = new System.Drawing.Point(127, 485);
            this.cmdShowP.Name = "cmdShowP";
            this.cmdShowP.Size = new System.Drawing.Size(187, 70);
            this.cmdShowP.TabIndex = 6;
            this.cmdShowP.Text = "Show Products";
            this.cmdShowP.UseVisualStyleBackColor = false;
            this.cmdShowP.Click += new System.EventHandler(this.cmdShowP_Click);
            // 
            // lblavailableP
            // 
            this.lblavailableP.AutoSize = true;
            this.lblavailableP.Font = new System.Drawing.Font("Franklin Gothic Demi", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavailableP.Location = new System.Drawing.Point(162, 36);
            this.lblavailableP.Name = "lblavailableP";
            this.lblavailableP.Size = new System.Drawing.Size(522, 50);
            this.lblavailableP.TabIndex = 5;
            this.lblavailableP.Text = "Products Available for rent";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(127, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(703, 281);
            this.dataGridView1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Benjamin_Phiri_DDOOCP.Properties.Resources.RenThings__2__removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = global::Benjamin_Phiri_DDOOCP.Properties.Resources.RenThings_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(740, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Benjamin_Phiri_DDOOCP.Properties.Resources.image_removebg_preview;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(856, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 64);
            this.button2.TabIndex = 17;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Benjamin_Phiri_DDOOCP.Properties.Resources.back_logo_removebg_preview;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 25);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AvailableProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(953, 580);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAV_Desc);
            this.Controls.Add(this.cmdShowP);
            this.Controls.Add(this.lblavailableP);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "AvailableProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AvailableProducts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAV_Desc;
        private System.Windows.Forms.Button cmdShowP;
        private System.Windows.Forms.Label lblavailableP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}