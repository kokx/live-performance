namespace CSharpSerialConnection
{
    partial class UserInterface
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ver3 = new System.Windows.Forms.RadioButton();
            this.ver2 = new System.Windows.Forms.RadioButton();
            this.ver1 = new System.Windows.Forms.RadioButton();
            this.ver0 = new System.Windows.Forms.RadioButton();
            this.control = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.statusTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(174, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 256);
            this.textBox1.TabIndex = 1;
            // 
            // ver3
            // 
            this.ver3.AutoSize = true;
            this.ver3.Enabled = false;
            this.ver3.Location = new System.Drawing.Point(12, 12);
            this.ver3.Name = "ver3";
            this.ver3.Size = new System.Drawing.Size(89, 17);
            this.ver3.TabIndex = 3;
            this.ver3.TabStop = true;
            this.ver3.Text = "3e verdieping";
            this.ver3.UseVisualStyleBackColor = true;
            // 
            // ver2
            // 
            this.ver2.AutoSize = true;
            this.ver2.Enabled = false;
            this.ver2.Location = new System.Drawing.Point(12, 35);
            this.ver2.Name = "ver2";
            this.ver2.Size = new System.Drawing.Size(89, 17);
            this.ver2.TabIndex = 4;
            this.ver2.Text = "2e verdieping";
            this.ver2.UseVisualStyleBackColor = true;
            // 
            // ver1
            // 
            this.ver1.AutoSize = true;
            this.ver1.Enabled = false;
            this.ver1.Location = new System.Drawing.Point(12, 58);
            this.ver1.Name = "ver1";
            this.ver1.Size = new System.Drawing.Size(89, 17);
            this.ver1.TabIndex = 5;
            this.ver1.Text = "1e verdieping";
            this.ver1.UseVisualStyleBackColor = true;
            // 
            // ver0
            // 
            this.ver0.AutoSize = true;
            this.ver0.Checked = true;
            this.ver0.Enabled = false;
            this.ver0.Location = new System.Drawing.Point(12, 81);
            this.ver0.Name = "ver0";
            this.ver0.Size = new System.Drawing.Size(94, 17);
            this.ver0.TabIndex = 6;
            this.ver0.TabStop = true;
            this.ver0.Text = "Begane Grond";
            this.ver0.UseVisualStyleBackColor = true;
            // 
            // control
            // 
            this.control.AutoSize = true;
            this.control.Location = new System.Drawing.Point(12, 143);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(127, 17);
            this.control.TabIndex = 7;
            this.control.Text = "The Devil has control";
            this.control.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusTimer
            // 
            this.statusTimer.Tick += new System.EventHandler(this.statusTimer_Tick);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 284);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.control);
            this.Controls.Add(this.ver0);
            this.Controls.Add(this.ver1);
            this.Controls.Add(this.ver2);
            this.Controls.Add(this.ver3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "UserInterface";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton ver3;
        private System.Windows.Forms.RadioButton ver2;
        private System.Windows.Forms.RadioButton ver1;
        private System.Windows.Forms.RadioButton ver0;
        private System.Windows.Forms.CheckBox control;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer statusTimer;
    }
}

