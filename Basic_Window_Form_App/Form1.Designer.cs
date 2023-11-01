namespace Basic_Window_Form_App
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
            this.green = new System.Windows.Forms.Button();
            this.yellow = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(164, 226);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(94, 68);
            this.green.TabIndex = 0;
            this.green.Text = "Green";
            this.green.UseVisualStyleBackColor = true;
            this.green.Click += new System.EventHandler(this.button1_Click);
            // 
            // yellow
            // 
            this.yellow.Location = new System.Drawing.Point(337, 226);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(94, 68);
            this.yellow.TabIndex = 1;
            this.yellow.Text = "Yellow";
            this.yellow.UseVisualStyleBackColor = true;
            this.yellow.Click += new System.EventHandler(this.button2_Click);
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(501, 226);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(94, 68);
            this.red.TabIndex = 2;
            this.red.Text = "Red";
            this.red.UseVisualStyleBackColor = true;
            this.red.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(625, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.red);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.green);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button green;
        private System.Windows.Forms.Button yellow;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

