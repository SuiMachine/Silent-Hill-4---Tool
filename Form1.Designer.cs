namespace FovChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LB_Running = new System.Windows.Forms.Label();
            this.C_EnableHack = new System.Windows.Forms.CheckBox();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.C_AutoCalculate = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.T_Aspect = new System.Windows.Forms.TextBox();
            this.B_setAspect = new System.Windows.Forms.Button();
            this.T_ResY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.T_ResX = new System.Windows.Forms.TextBox();
            this.B_setRes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.T_InputFOV = new System.Windows.Forms.TextBox();
            this.B_setFOV = new System.Windows.Forms.Button();
            this.DeveloperButton = new System.Windows.Forms.PictureBox();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.InputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeveloperButton)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LB_Running
            // 
            this.LB_Running.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LB_Running.Dock = System.Windows.Forms.DockStyle.Top;
            this.LB_Running.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Running.ForeColor = System.Drawing.Color.Red;
            this.LB_Running.Location = new System.Drawing.Point(0, 0);
            this.LB_Running.Name = "LB_Running";
            this.LB_Running.Size = new System.Drawing.Size(302, 24);
            this.LB_Running.TabIndex = 1;
            this.LB_Running.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // C_EnableHack
            // 
            this.C_EnableHack.AutoSize = true;
            this.C_EnableHack.Location = new System.Drawing.Point(14, 124);
            this.C_EnableHack.Name = "C_EnableHack";
            this.C_EnableHack.Size = new System.Drawing.Size(59, 17);
            this.C_EnableHack.TabIndex = 39;
            this.C_EnableHack.Text = "Enable";
            this.C_EnableHack.UseVisualStyleBackColor = true;
            this.C_EnableHack.CheckedChanged += new System.EventHandler(this.C_EnableHack_CheckedChanged);
            // 
            // InputPanel
            // 
            this.InputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPanel.Controls.Add(this.C_AutoCalculate);
            this.InputPanel.Controls.Add(this.label5);
            this.InputPanel.Controls.Add(this.T_Aspect);
            this.InputPanel.Controls.Add(this.B_setAspect);
            this.InputPanel.Controls.Add(this.T_ResY);
            this.InputPanel.Controls.Add(this.label4);
            this.InputPanel.Controls.Add(this.label3);
            this.InputPanel.Controls.Add(this.T_ResX);
            this.InputPanel.Controls.Add(this.B_setRes);
            this.InputPanel.Controls.Add(this.label1);
            this.InputPanel.Controls.Add(this.T_InputFOV);
            this.InputPanel.Controls.Add(this.B_setFOV);
            this.InputPanel.Controls.Add(this.DeveloperButton);
            this.InputPanel.Controls.Add(this.linkLabel);
            this.InputPanel.Controls.Add(this.C_EnableHack);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InputPanel.Location = new System.Drawing.Point(0, 24);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(302, 195);
            this.InputPanel.TabIndex = 41;
            // 
            // C_AutoCalculate
            // 
            this.C_AutoCalculate.AutoSize = true;
            this.C_AutoCalculate.Location = new System.Drawing.Point(14, 100);
            this.C_AutoCalculate.Name = "C_AutoCalculate";
            this.C_AutoCalculate.Size = new System.Drawing.Size(152, 17);
            this.C_AutoCalculate.TabIndex = 56;
            this.C_AutoCalculate.Text = "Auto-calculate aspect ratio";
            this.C_AutoCalculate.UseVisualStyleBackColor = true;
            this.C_AutoCalculate.CheckedChanged += new System.EventHandler(this.C_AutoCalculate_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 70);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 54;
            this.label5.Text = "Aspect ratio*";
            // 
            // T_Aspect
            // 
            this.T_Aspect.Location = new System.Drawing.Point(91, 70);
            this.T_Aspect.Name = "T_Aspect";
            this.T_Aspect.Size = new System.Drawing.Size(136, 20);
            this.T_Aspect.TabIndex = 53;
            this.T_Aspect.Text = "0.59";
            this.T_Aspect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // B_setAspect
            // 
            this.B_setAspect.Location = new System.Drawing.Point(237, 68);
            this.B_setAspect.Name = "B_setAspect";
            this.B_setAspect.Size = new System.Drawing.Size(44, 23);
            this.B_setAspect.TabIndex = 55;
            this.B_setAspect.Text = "Set";
            this.B_setAspect.UseVisualStyleBackColor = true;
            this.B_setAspect.Click += new System.EventHandler(this.B_setAspect_Click);
            // 
            // T_ResY
            // 
            this.T_ResY.Location = new System.Drawing.Point(173, 11);
            this.T_ResY.Name = "T_ResY";
            this.T_ResY.Size = new System.Drawing.Size(58, 20);
            this.T_ResY.TabIndex = 52;
            this.T_ResY.Text = "720";
            this.T_ResY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 11);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label4.Size = new System.Drawing.Size(12, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = "Resolution:";
            // 
            // T_ResX
            // 
            this.T_ResX.Location = new System.Drawing.Point(91, 10);
            this.T_ResX.Name = "T_ResX";
            this.T_ResX.Size = new System.Drawing.Size(58, 20);
            this.T_ResX.TabIndex = 48;
            this.T_ResX.Text = "1280";
            this.T_ResX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // B_setRes
            // 
            this.B_setRes.Location = new System.Drawing.Point(237, 8);
            this.B_setRes.Name = "B_setRes";
            this.B_setRes.Size = new System.Drawing.Size(44, 23);
            this.B_setRes.TabIndex = 50;
            this.B_setRes.Text = "Set";
            this.B_setRes.UseVisualStyleBackColor = true;
            this.B_setRes.Click += new System.EventHandler(this.B_setRes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "FOV value*";
            // 
            // T_InputFOV
            // 
            this.T_InputFOV.Location = new System.Drawing.Point(91, 41);
            this.T_InputFOV.Name = "T_InputFOV";
            this.T_InputFOV.Size = new System.Drawing.Size(136, 20);
            this.T_InputFOV.TabIndex = 45;
            this.T_InputFOV.Text = "0.75";
            this.T_InputFOV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // B_setFOV
            // 
            this.B_setFOV.Location = new System.Drawing.Point(237, 39);
            this.B_setFOV.Name = "B_setFOV";
            this.B_setFOV.Size = new System.Drawing.Size(44, 23);
            this.B_setFOV.TabIndex = 47;
            this.B_setFOV.Text = "Set";
            this.B_setFOV.UseVisualStyleBackColor = true;
            this.B_setFOV.Click += new System.EventHandler(this.B_setFOV_Click);
            // 
            // DeveloperButton
            // 
            this.DeveloperButton.Image = global::FovChanger.Properties.Resources.donatebutton;
            this.DeveloperButton.Location = new System.Drawing.Point(156, 157);
            this.DeveloperButton.Name = "DeveloperButton";
            this.DeveloperButton.Size = new System.Drawing.Size(74, 21);
            this.DeveloperButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DeveloperButton.TabIndex = 44;
            this.DeveloperButton.TabStop = false;
            this.DeveloperButton.Click += new System.EventHandler(this.DeveloperButton_Click);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(20, 161);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(84, 13);
            this.linkLabel.TabIndex = 43;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "PC Gaming Wiki";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 218);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.LB_Running);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Silent Hill 4 Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeveloperButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LB_Running;
        private System.Windows.Forms.CheckBox C_EnableHack;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.PictureBox DeveloperButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox T_Aspect;
        private System.Windows.Forms.Button B_setAspect;
        private System.Windows.Forms.TextBox T_ResY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox T_ResX;
        private System.Windows.Forms.Button B_setRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox T_InputFOV;
        private System.Windows.Forms.Button B_setFOV;
        private System.Windows.Forms.CheckBox C_AutoCalculate;
    }
}

