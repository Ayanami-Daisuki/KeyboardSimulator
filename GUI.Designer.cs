using System.Windows.Forms;

namespace KeyboardSimulator
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.SimulateMode = new System.Windows.Forms.CheckBox();
            this.Stop = new System.Windows.Forms.Button();
            this.DelayTime = new System.Windows.Forms.TextBox();
            this.Delay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Input.Font = new System.Drawing.Font("Consolas", 12F);
            this.Input.Location = new System.Drawing.Point(12, 12);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(760, 351);
            this.Input.TabIndex = 0;
            this.Input.Text = "";
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Start
            // 
            this.Start.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Start.Location = new System.Drawing.Point(346, 369);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 30);
            this.Start.TabIndex = 1;
            this.Start.Text = "粘贴！";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Help
            // 
            this.Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Help.Location = new System.Drawing.Point(672, 369);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(100, 30);
            this.Help.TabIndex = 2;
            this.Help.Text = "如何使用？";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // SimulateMode
            // 
            this.SimulateMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SimulateMode.AutoSize = true;
            this.SimulateMode.Location = new System.Drawing.Point(12, 378);
            this.SimulateMode.Name = "SimulateMode";
            this.SimulateMode.Size = new System.Drawing.Size(123, 21);
            this.SimulateMode.TabIndex = 3;
            this.SimulateMode.Text = "模拟手工输入延迟";
            this.SimulateMode.UseVisualStyleBackColor = true;
            // 
            // Stop
            // 
            this.Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop.Location = new System.Drawing.Point(566, 369);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(100, 30);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "中断粘贴";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // DelayTime
            // 
            this.DelayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DelayTime.Location = new System.Drawing.Point(206, 376);
            this.DelayTime.Name = "DelayTime";
            this.DelayTime.Size = new System.Drawing.Size(60, 23);
            this.DelayTime.TabIndex = 5;
            this.DelayTime.TextChanged += new System.EventHandler(this.DelayTime_TextChanged);
            // 
            // Delay
            // 
            this.Delay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delay.AutoSize = true;
            this.Delay.Location = new System.Drawing.Point(141, 379);
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(68, 17);
            this.Delay.TabIndex = 6;
            this.Delay.Text = "粘贴延时：";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ms";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delay);
            this.Controls.Add(this.DelayTime);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.SimulateMode);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Input);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI";
            this.Text = "键盘模拟器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox Input;
        private Button Start;
        private Button Help;
        private CheckBox SimulateMode;
        private Button Stop;
        private TextBox DelayTime;
        private Label Delay;
        private Label label1;
    }
}