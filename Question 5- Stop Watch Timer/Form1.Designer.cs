namespace Question_5__Stop_Watch_Timer
{
    partial class StopWatch
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
            this.watchLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.formtimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // watchLabel
            // 
            this.watchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchLabel.Location = new System.Drawing.Point(2, 25);
            this.watchLabel.Name = "watchLabel";
            this.watchLabel.Size = new System.Drawing.Size(795, 161);
            this.watchLabel.TabIndex = 0;
            this.watchLabel.Text = "00.00.00";
            this.watchLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Aqua;
            this.startButton.Location = new System.Drawing.Point(12, 347);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(215, 91);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Aqua;
            this.ResetButton.Location = new System.Drawing.Point(559, 347);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(215, 91);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Aqua;
            this.stopButton.Location = new System.Drawing.Point(268, 347);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(215, 91);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // formtimer
            // 
            this.formtimer.Interval = 10;
            this.formtimer.Tick += new System.EventHandler(this.formtimer_Tick);
            // 
            // StopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.watchLabel);
            this.Name = "StopWatch";
            this.Text = "StopWatch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label watchLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer formtimer;
    }
}

