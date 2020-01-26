namespace WindowsFormsApp18
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
            this.components = new System.ComponentModel.Container();
            this.next = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.prev = new System.Windows.Forms.Button();
            this.model = new System.Windows.Forms.Label();
            this.vendor = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.ForeColor = System.Drawing.Color.MediumBlue;
            this.next.Location = new System.Drawing.Point(684, 341);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(62, 55);
            this.next.TabIndex = 0;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.button1_Click);
            // 
            // prev
            // 
            this.prev.BackColor = System.Drawing.Color.Transparent;
            this.prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev.ForeColor = System.Drawing.Color.MediumBlue;
            this.prev.Location = new System.Drawing.Point(616, 341);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(62, 55);
            this.prev.TabIndex = 1;
            this.prev.Text = "Prev";
            this.prev.UseVisualStyleBackColor = false;
            this.prev.Click += new System.EventHandler(this.button2_Click);
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Location = new System.Drawing.Point(430, 40);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(10, 13);
            this.model.TabIndex = 3;
            this.model.Text = " ";
            // 
            // vendor
            // 
            this.vendor.AutoSize = true;
            this.vendor.Location = new System.Drawing.Point(430, 66);
            this.vendor.Name = "vendor";
            this.vendor.Size = new System.Drawing.Size(10, 13);
            this.vendor.TabIndex = 4;
            this.vendor.Text = " ";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(430, 91);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(10, 13);
            this.year.TabIndex = 5;
            this.year.Text = " ";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(430, 117);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(10, 13);
            this.color.TabIndex = 6;
            this.color.Text = " ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.color);
            this.Controls.Add(this.year);
            this.Controls.Add(this.vendor);
            this.Controls.Add(this.model);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.Label vendor;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

