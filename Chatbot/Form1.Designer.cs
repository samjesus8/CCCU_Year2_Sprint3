namespace Chatbot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxUserInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxBotOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxUserInput
            // 
            this.richTextBoxUserInput.Location = new System.Drawing.Point(76, 39);
            this.richTextBoxUserInput.Name = "richTextBoxUserInput";
            this.richTextBoxUserInput.Size = new System.Drawing.Size(355, 98);
            this.richTextBoxUserInput.TabIndex = 0;
            this.richTextBoxUserInput.Text = "";
            // 
            // richTextBoxBotOutput
            // 
            this.richTextBoxBotOutput.Location = new System.Drawing.Point(76, 230);
            this.richTextBoxBotOutput.Name = "richTextBoxBotOutput";
            this.richTextBoxBotOutput.Size = new System.Drawing.Size(355, 98);
            this.richTextBoxBotOutput.TabIndex = 1;
            this.richTextBoxBotOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(504, 452);
            this.Controls.Add(this.richTextBoxBotOutput);
            this.Controls.Add(this.richTextBoxUserInput);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Chatty";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBoxUserInput;
        private RichTextBox richTextBoxBotOutput;
    }
}