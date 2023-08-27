namespace LA_ILA_1500_Autorennspiel
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.Roadtrack2 = new System.Windows.Forms.PictureBox();
            this.Roadtrack = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Roadtrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Roadtrack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.Roadtrack2);
            this.panel1.Controls.Add(this.Roadtrack);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 381);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AI1
            // 
            this.AI1.Image = global::LA_ILA_1500_Autorennspiel.Properties.Resources.Audi_1_png;
            this.AI1.Location = new System.Drawing.Point(27, 40);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(74, 74);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI1.TabIndex = 8;
            this.AI1.TabStop = false;
            this.AI1.Tag = "carLeft";
            // 
            // AI2
            // 
            this.AI2.Image = global::LA_ILA_1500_Autorennspiel.Properties.Resources.Police_1_png;
            this.AI2.Location = new System.Drawing.Point(268, 40);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(74, 74);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI2.TabIndex = 6;
            this.AI2.TabStop = false;
            this.AI2.Tag = "carRight";
            this.AI2.Click += new System.EventHandler(this.AI2_Click);
            // 
            // player
            // 
            this.player.Image = global::LA_ILA_1500_Autorennspiel.Properties.Resources.Black_viper_2_;
            this.player.Location = new System.Drawing.Point(123, 294);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(74, 74);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // Roadtrack2
            // 
            this.Roadtrack2.Image = global::LA_ILA_1500_Autorennspiel.Properties.Resources.Roadtrack_1_png;
            this.Roadtrack2.Location = new System.Drawing.Point(0, 0);
            this.Roadtrack2.Name = "Roadtrack2";
            this.Roadtrack2.Size = new System.Drawing.Size(378, 381);
            this.Roadtrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Roadtrack2.TabIndex = 4;
            this.Roadtrack2.TabStop = false;
            this.Roadtrack2.Click += new System.EventHandler(this.Roadtrack2_Click);
            // 
            // Roadtrack
            // 
            this.Roadtrack.Image = global::LA_ILA_1500_Autorennspiel.Properties.Resources.Roadtrack_1_png;
            this.Roadtrack.Location = new System.Drawing.Point(0, -519);
            this.Roadtrack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Roadtrack.Name = "Roadtrack";
            this.Roadtrack.Size = new System.Drawing.Size(323, 381);
            this.Roadtrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Roadtrack.TabIndex = 2;
            this.Roadtrack.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(113, 405);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(71, 26);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "label1";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(374, 438);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Roadtrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Roadtrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Roadtrack;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox Roadtrack2;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblScore;
    }
}