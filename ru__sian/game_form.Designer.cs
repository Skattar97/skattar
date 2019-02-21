namespace ru__sian
{
    partial class game_form
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
            this.Loded_btn = new System.Windows.Forms.Button();
            this.Spined_btn = new System.Windows.Forms.Button();
            this.Shooter_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click Load Button To Play";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Loded_btn
            // 
            this.Loded_btn.Location = new System.Drawing.Point(49, 150);
            this.Loded_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Loded_btn.Name = "Loded_btn";
            this.Loded_btn.Size = new System.Drawing.Size(100, 28);
            this.Loded_btn.TabIndex = 1;
            this.Loded_btn.Text = "Load";
            this.Loded_btn.UseVisualStyleBackColor = true;
            this.Loded_btn.Click += new System.EventHandler(this.Loded_btn_Click);
            // 
            // Spined_btn
            // 
            this.Spined_btn.Location = new System.Drawing.Point(49, 229);
            this.Spined_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Spined_btn.Name = "Spined_btn";
            this.Spined_btn.Size = new System.Drawing.Size(100, 28);
            this.Spined_btn.TabIndex = 2;
            this.Spined_btn.Text = "Spin";
            this.Spined_btn.UseVisualStyleBackColor = true;
            this.Spined_btn.Click += new System.EventHandler(this.Spined_btn_Click);
            // 
            // Shooter_btn
            // 
            this.Shooter_btn.Location = new System.Drawing.Point(49, 309);
            this.Shooter_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Shooter_btn.Name = "Shooter_btn";
            this.Shooter_btn.Size = new System.Drawing.Size(100, 28);
            this.Shooter_btn.TabIndex = 3;
            this.Shooter_btn.Text = "Shoot";
            this.Shooter_btn.UseVisualStyleBackColor = true;
            this.Shooter_btn.Click += new System.EventHandler(this.Shooter_btn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(49, 391);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 4;
            this.button4.Text = "Retry";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.retry_Click);
            // 
            // pbox
            // 
            this.pbox.Location = new System.Drawing.Point(248, 150);
            this.pbox.Margin = new System.Windows.Forms.Padding(4);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(697, 297);
            this.pbox.TabIndex = 6;
            this.pbox.TabStop = false;
            this.pbox.Click += new System.EventHandler(this.pbox_Click);
            // 
            // game_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ru__sian.Properties.Resources._1_cIQiMyyFIzsoZi5M4LbH_g;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pbox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Shooter_btn);
            this.Controls.Add(this.Spined_btn);
            this.Controls.Add(this.Loded_btn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "game_form";
            this.Text = "game_form";
            this.Load += new System.EventHandler(this.game_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Loded_btn;
        private System.Windows.Forms.Button Spined_btn;
        private System.Windows.Forms.Button Shooter_btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pbox;
    }
}