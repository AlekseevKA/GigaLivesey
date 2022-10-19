
namespace WindowsFormsApp1
{
    partial class GigaForm3
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.musicOff = new System.Windows.Forms.Button();
            this.musicOn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreLabel.Location = new System.Drawing.Point(1045, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(40, 42);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "0";
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuBtn.ForeColor = System.Drawing.Color.Coral;
            this.MenuBtn.Location = new System.Drawing.Point(979, 414);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(106, 42);
            this.MenuBtn.TabIndex = 12;
            this.MenuBtn.Text = "Main Menu";
            this.MenuBtn.UseVisualStyleBackColor = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // musicOff
            // 
            this.musicOff.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.musicOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musicOff.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicOff.ForeColor = System.Drawing.Color.White;
            this.musicOff.Location = new System.Drawing.Point(978, 320);
            this.musicOff.Name = "musicOff";
            this.musicOff.Size = new System.Drawing.Size(107, 52);
            this.musicOff.TabIndex = 11;
            this.musicOff.Text = "Music Off";
            this.musicOff.UseVisualStyleBackColor = false;
            this.musicOff.Click += new System.EventHandler(this.musicOff_Click);
            // 
            // musicOn
            // 
            this.musicOn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.musicOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musicOn.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicOn.ForeColor = System.Drawing.Color.LightYellow;
            this.musicOn.Location = new System.Drawing.Point(978, 267);
            this.musicOn.Name = "musicOn";
            this.musicOn.Size = new System.Drawing.Size(107, 47);
            this.musicOn.TabIndex = 10;
            this.musicOn.Text = "Music On";
            this.musicOn.UseVisualStyleBackColor = false;
            this.musicOn.Click += new System.EventHandler(this.musicOn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.ForeColor = System.Drawing.Color.Coral;
            this.exitBtn.Location = new System.Drawing.Point(979, 462);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(106, 42);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "Выйти из игры";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // GigaForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 524);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.musicOff);
            this.Controls.Add(this.musicOn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.scoreLabel);
            this.Name = "GigaForm3";
            this.Text = "GigaForm3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Button musicOff;
        private System.Windows.Forms.Button musicOn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}