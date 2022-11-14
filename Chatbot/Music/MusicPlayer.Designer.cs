namespace Chatbot.Music
{
    partial class MusicPlayer
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
            this.nowPlayingBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.loopButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(151, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Music Player";
            // 
            // nowPlayingBox
            // 
            this.nowPlayingBox.Location = new System.Drawing.Point(14, 112);
            this.nowPlayingBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nowPlayingBox.Multiline = true;
            this.nowPlayingBox.Name = "nowPlayingBox";
            this.nowPlayingBox.ReadOnly = true;
            this.nowPlayingBox.Size = new System.Drawing.Size(545, 104);
            this.nowPlayingBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Now Playing";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(131, 225);
            this.playButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(70, 60);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(210, 225);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(70, 60);
            this.pauseButton.TabIndex = 4;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(287, 225);
            this.stopButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(70, 60);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // loopButton
            // 
            this.loopButton.Location = new System.Drawing.Point(363, 225);
            this.loopButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loopButton.Name = "loopButton";
            this.loopButton.Size = new System.Drawing.Size(70, 60);
            this.loopButton.TabIndex = 6;
            this.loopButton.Text = "Loop";
            this.loopButton.UseVisualStyleBackColor = true;
            this.loopButton.Click += new System.EventHandler(this.loopButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(441, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "V1.0 BETA";
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 355);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loopButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nowPlayingBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MusicPlayer";
            this.Text = "MusicPlayer";
            this.Load += new System.EventHandler(this.MusicPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox nowPlayingBox;
        private Label label2;
        private Button playButton;
        private Button pauseButton;
        private Button stopButton;
        private Button loopButton;
        private Label label3;
    }
}