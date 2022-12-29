namespace Benjamin_Phiri_DDOOCP
{
    partial class AddItem
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
            this.cmdAddI = new System.Windows.Forms.Button();
            this.txtAppl = new System.Windows.Forms.TextBox();
            this.txtPU = new System.Windows.Forms.TextBox();
            this.txtTU = new System.Windows.Forms.TextBox();
            this.txtRFM = new System.Windows.Forms.TextBox();
            this.lblAppl = new System.Windows.Forms.Label();
            this.lblPU = new System.Windows.Forms.Label();
            this.lblTU = new System.Windows.Forms.Label();
            this.lblRFM = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDesc = new System.Windows.Forms.Label();
            this.cmdSI = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(545, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Item";
            // 
            // cmdAddI
            // 
            this.cmdAddI.BackColor = System.Drawing.Color.LightSalmon;
            this.cmdAddI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdAddI.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddI.Location = new System.Drawing.Point(189, 532);
            this.cmdAddI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdAddI.Name = "cmdAddI";
            this.cmdAddI.Size = new System.Drawing.Size(127, 63);
            this.cmdAddI.TabIndex = 2;
            this.cmdAddI.Text = "Add Item";
            this.cmdAddI.UseVisualStyleBackColor = false;
            this.cmdAddI.Click += new System.EventHandler(this.cmdAddI_Click);
            // 
            // txtAppl
            // 
            this.txtAppl.Location = new System.Drawing.Point(229, 322);
            this.txtAppl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAppl.Name = "txtAppl";
            this.txtAppl.Size = new System.Drawing.Size(199, 22);
            this.txtAppl.TabIndex = 3;
            // 
            // txtPU
            // 
            this.txtPU.Location = new System.Drawing.Point(229, 375);
            this.txtPU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPU.Name = "txtPU";
            this.txtPU.Size = new System.Drawing.Size(199, 22);
            this.txtPU.TabIndex = 4;
            // 
            // txtTU
            // 
            this.txtTU.Location = new System.Drawing.Point(229, 428);
            this.txtTU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTU.Name = "txtTU";
            this.txtTU.Size = new System.Drawing.Size(199, 22);
            this.txtTU.TabIndex = 5;
            // 
            // txtRFM
            // 
            this.txtRFM.Location = new System.Drawing.Point(229, 478);
            this.txtRFM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRFM.Name = "txtRFM";
            this.txtRFM.Size = new System.Drawing.Size(199, 22);
            this.txtRFM.TabIndex = 6;
            // 
            // lblAppl
            // 
            this.lblAppl.AutoSize = true;
            this.lblAppl.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppl.Location = new System.Drawing.Point(56, 320);
            this.lblAppl.Name = "lblAppl";
            this.lblAppl.Size = new System.Drawing.Size(153, 25);
            this.lblAppl.TabIndex = 8;
            this.lblAppl.Text = "Appliance Name";
            // 
            // lblPU
            // 
            this.lblPU.AutoSize = true;
            this.lblPU.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPU.Location = new System.Drawing.Point(56, 372);
            this.lblPU.Name = "lblPU";
            this.lblPU.Size = new System.Drawing.Size(123, 25);
            this.lblPU.TabIndex = 9;
            this.lblPU.Text = "Power Usage";
            this.lblPU.Click += new System.EventHandler(this.lblPU_Click);
            // 
            // lblTU
            // 
            this.lblTU.AutoSize = true;
            this.lblTU.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTU.Location = new System.Drawing.Point(56, 425);
            this.lblTU.Name = "lblTU";
            this.lblTU.Size = new System.Drawing.Size(128, 25);
            this.lblTU.TabIndex = 10;
            this.lblTU.Text = "Typical Usage";
            // 
            // lblRFM
            // 
            this.lblRFM.AutoSize = true;
            this.lblRFM.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFM.Location = new System.Drawing.Point(56, 478);
            this.lblRFM.Name = "lblRFM";
            this.lblRFM.Size = new System.Drawing.Size(153, 25);
            this.lblRFM.TabIndex = 11;
            this.lblRFM.Text = "Rent Fee/month";
            this.lblRFM.Click += new System.EventHandler(this.label6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(627, 202);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(764, 297);
            this.dataGridView1.TabIndex = 12;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(921, 137);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(187, 25);
            this.lblDesc.TabIndex = 13;
            this.lblDesc.Text = "Show Updated Table";
            // 
            // cmdSI
            // 
            this.cmdSI.BackColor = System.Drawing.Color.LightSalmon;
            this.cmdSI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdSI.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSI.Location = new System.Drawing.Point(940, 532);
            this.cmdSI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdSI.Name = "cmdSI";
            this.cmdSI.Size = new System.Drawing.Size(135, 63);
            this.cmdSI.TabIndex = 14;
            this.cmdSI.Text = "Show Items";
            this.cmdSI.UseVisualStyleBackColor = false;
            this.cmdSI.Click += new System.EventHandler(this.cmdSI_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(514, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Add new items that are available for the customers to rent.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "*   ApplianceID is automatically generated";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Benjamin_Phiri_DDOOCP.Properties.Resources.back_logo_removebg_preview;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 25);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Benjamin_Phiri_DDOOCP.Properties.Resources.RenThings__2__removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = global::Benjamin_Phiri_DDOOCP.Properties.Resources.RenThings_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(768, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1447, 677);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmdSI);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblRFM);
            this.Controls.Add(this.lblTU);
            this.Controls.Add(this.lblPU);
            this.Controls.Add(this.lblAppl);
            this.Controls.Add(this.txtRFM);
            this.Controls.Add(this.txtTU);
            this.Controls.Add(this.txtPU);
            this.Controls.Add(this.txtAppl);
            this.Controls.Add(this.cmdAddI);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAddI;
        private System.Windows.Forms.TextBox txtAppl;
        private System.Windows.Forms.TextBox txtPU;
        private System.Windows.Forms.TextBox txtTU;
        private System.Windows.Forms.TextBox txtRFM;
        private System.Windows.Forms.Label lblAppl;
        private System.Windows.Forms.Label lblPU;
        private System.Windows.Forms.Label lblTU;
        private System.Windows.Forms.Label lblRFM;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button cmdSI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}