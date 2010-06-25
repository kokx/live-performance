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
            this.ver3 = new System.Windows.Forms.RadioButton();
            this.ver2 = new System.Windows.Forms.RadioButton();
            this.ver1 = new System.Windows.Forms.RadioButton();
            this.ver0 = new System.Windows.Forms.RadioButton();
            this.control = new System.Windows.Forms.CheckBox();
            this.statusTimer = new System.Windows.Forms.Timer(this.components);
            this.height = new System.Windows.Forms.NumericUpDown();
            this.verdieping = new System.Windows.Forms.NumericUpDown();
            this.motor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdieping)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ver3
            // 
            this.ver3.AutoSize = true;
            this.ver3.Enabled = false;
            this.ver3.Location = new System.Drawing.Point(12, 12);
            this.ver3.Name = "ver3";
            this.ver3.Size = new System.Drawing.Size(89, 17);
            this.ver3.TabIndex = 3;
            this.ver3.Text = "3e verdieping";
            this.ver3.UseVisualStyleBackColor = true;
            this.ver3.CheckedChanged += new System.EventHandler(this.ver3_CheckedChanged);
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
            this.ver2.CheckedChanged += new System.EventHandler(this.ver2_CheckedChanged);
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
            this.ver1.CheckedChanged += new System.EventHandler(this.ver1_CheckedChanged);
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
            this.ver0.CheckedChanged += new System.EventHandler(this.ver0_CheckedChanged);
            // 
            // control
            // 
            this.control.AutoSize = true;
            this.control.Location = new System.Drawing.Point(12, 104);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(127, 17);
            this.control.TabIndex = 7;
            this.control.Text = "The Devil has control";
            this.control.UseVisualStyleBackColor = true;
            this.control.CheckedChanged += new System.EventHandler(this.control_CheckedChanged);
            // 
            // statusTimer
            // 
            this.statusTimer.Tick += new System.EventHandler(this.statusTimer_Tick);
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(12, 140);
            this.height.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(75, 20);
            this.height.TabIndex = 8;
            // 
            // verdieping
            // 
            this.verdieping.Location = new System.Drawing.Point(96, 140);
            this.verdieping.Name = "verdieping";
            this.verdieping.Size = new System.Drawing.Size(43, 20);
            this.verdieping.TabIndex = 9;
            // 
            // motor
            // 
            this.motor.AutoSize = true;
            this.motor.Location = new System.Drawing.Point(12, 167);
            this.motor.Name = "motor";
            this.motor.Size = new System.Drawing.Size(0, 13);
            this.motor.TabIndex = 10;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 284);
            this.Controls.Add(this.motor);
            this.Controls.Add(this.verdieping);
            this.Controls.Add(this.height);
            this.Controls.Add(this.control);
            this.Controls.Add(this.ver0);
            this.Controls.Add(this.ver1);
            this.Controls.Add(this.ver2);
            this.Controls.Add(this.ver3);
            this.Controls.Add(this.button1);
            this.Name = "UserInterface";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdieping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton ver3;
        private System.Windows.Forms.RadioButton ver2;
        private System.Windows.Forms.RadioButton ver1;
        private System.Windows.Forms.RadioButton ver0;
        private System.Windows.Forms.CheckBox control;
        private System.Windows.Forms.Timer statusTimer;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.NumericUpDown verdieping;
        private System.Windows.Forms.Label motor;
    }
}

