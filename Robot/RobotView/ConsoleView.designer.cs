namespace RobotView
{
    partial class ConsoleView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.ledview1 = new RobotView.LEDView();
            this.ledView2 = new RobotView.LEDView();
            this.ledView3 = new RobotView.LEDView();
            this.ledView4 = new RobotView.LEDView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            // 
            // ledview1
            // 
            this.ledview1.Location = new System.Drawing.Point(61, 55);
            this.ledview1.Name = "ledview1";
            this.ledview1.Size = new System.Drawing.Size(20, 20);
            this.ledview1.TabIndex = 1;
            // 
            // ledView2
            // 
            this.ledView2.Location = new System.Drawing.Point(96, 55);
            this.ledView2.Name = "ledView2";
            this.ledView2.Size = new System.Drawing.Size(20, 20);
            this.ledView2.TabIndex = 2;
            // 
            // ledView3
            // 
            this.ledView3.Location = new System.Drawing.Point(173, 55);
            this.ledView3.Name = "ledView3";
            this.ledView3.Size = new System.Drawing.Size(20, 20);
            this.ledView3.TabIndex = 4;
            // 
            // ledView4
            // 
            this.ledView4.Location = new System.Drawing.Point(138, 55);
            this.ledView4.Name = "ledView4";
            this.ledView4.Size = new System.Drawing.Size(20, 20);
            this.ledView4.TabIndex = 3;
            // 
            // ConsoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.ledView3);
            this.Controls.Add(this.ledView4);
            this.Controls.Add(this.ledView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ledview1);
            this.Name = "ConsoleView";
            this.Size = new System.Drawing.Size(599, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private LEDView ledview1;
        private LEDView ledView2;
        private LEDView ledView3;
        private LEDView ledView4;
    }
}
