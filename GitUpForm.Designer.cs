
namespace GitUp
{
    partial class GitUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GitUpForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.IcoBox = new System.Windows.Forms.PictureBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.MinimizeLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.QuickOptionsPanel = new System.Windows.Forms.Panel();
            this.ArgOneInputTextBox = new System.Windows.Forms.RichTextBox();
            this.ArgTwoInputTextBox = new System.Windows.Forms.RichTextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.ArgTwoLabel = new System.Windows.Forms.Label();
            this.ArgTwoComboBox = new System.Windows.Forms.ComboBox();
            this.ArgOneLabel = new System.Windows.Forms.Label();
            this.ArgOneComboBox = new System.Windows.Forms.ComboBox();
            this.QuickLabel = new System.Windows.Forms.Label();
            this.InputOneLabel = new System.Windows.Forms.Label();
            this.CommandLabel = new System.Windows.Forms.Label();
            this.CommandComboBox = new System.Windows.Forms.ComboBox();
            this.FilePanel = new System.Windows.Forms.Panel();
            this.CommandFileComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FileOneLabel = new System.Windows.Forms.Label();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.LogsTextBox = new System.Windows.Forms.RichTextBox();
            this.LogsLabel = new System.Windows.Forms.Label();
            this.ReloadListsButton = new System.Windows.Forms.Button();
            this.ExecuteFileButton = new System.Windows.Forms.Button();
            this.ExecuteQuickCMDButton = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcoBox)).BeginInit();
            this.QuickOptionsPanel.SuspendLayout();
            this.FilePanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.HeaderPanel.Controls.Add(this.IcoBox);
            this.HeaderPanel.Controls.Add(this.HeaderLabel);
            this.HeaderPanel.Controls.Add(this.MinimizeLabel);
            this.HeaderPanel.Controls.Add(this.ExitLabel);
            this.HeaderPanel.Location = new System.Drawing.Point(-2, -1);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(807, 44);
            this.HeaderPanel.TabIndex = 0;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            // 
            // IcoBox
            // 
            this.IcoBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IcoBox.BackgroundImage")));
            this.IcoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IcoBox.Image = ((System.Drawing.Image)(resources.GetObject("IcoBox.Image")));
            this.IcoBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("IcoBox.InitialImage")));
            this.IcoBox.Location = new System.Drawing.Point(0, -4);
            this.IcoBox.Name = "IcoBox";
            this.IcoBox.Size = new System.Drawing.Size(45, 54);
            this.IcoBox.TabIndex = 3;
            this.IcoBox.TabStop = false;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.Location = new System.Drawing.Point(46, 10);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(74, 25);
            this.HeaderLabel.TabIndex = 2;
            this.HeaderLabel.Text = "Git-Up";
            this.HeaderLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderLabel_MouseDown);
            // 
            // MinimizeLabel
            // 
            this.MinimizeLabel.AutoSize = true;
            this.MinimizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeLabel.ForeColor = System.Drawing.Color.White;
            this.MinimizeLabel.Location = new System.Drawing.Point(741, 7);
            this.MinimizeLabel.Name = "MinimizeLabel";
            this.MinimizeLabel.Size = new System.Drawing.Size(20, 25);
            this.MinimizeLabel.TabIndex = 1;
            this.MinimizeLabel.Text = "-";
            this.MinimizeLabel.Click += new System.EventHandler(this.MinimizeLabel_Click);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.Color.White;
            this.ExitLabel.Location = new System.Drawing.Point(770, 10);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(27, 25);
            this.ExitLabel.TabIndex = 0;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // QuickOptionsPanel
            // 
            this.QuickOptionsPanel.BackColor = System.Drawing.Color.Teal;
            this.QuickOptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuickOptionsPanel.Controls.Add(this.ArgOneInputTextBox);
            this.QuickOptionsPanel.Controls.Add(this.ArgTwoInputTextBox);
            this.QuickOptionsPanel.Controls.Add(this.InputLabel);
            this.QuickOptionsPanel.Controls.Add(this.ArgTwoLabel);
            this.QuickOptionsPanel.Controls.Add(this.ArgTwoComboBox);
            this.QuickOptionsPanel.Controls.Add(this.ArgOneLabel);
            this.QuickOptionsPanel.Controls.Add(this.ArgOneComboBox);
            this.QuickOptionsPanel.Controls.Add(this.QuickLabel);
            this.QuickOptionsPanel.Controls.Add(this.InputOneLabel);
            this.QuickOptionsPanel.Controls.Add(this.CommandLabel);
            this.QuickOptionsPanel.Controls.Add(this.CommandComboBox);
            this.QuickOptionsPanel.Location = new System.Drawing.Point(17, 66);
            this.QuickOptionsPanel.Name = "QuickOptionsPanel";
            this.QuickOptionsPanel.Size = new System.Drawing.Size(244, 364);
            this.QuickOptionsPanel.TabIndex = 3;
            // 
            // ArgOneInputTextBox
            // 
            this.ArgOneInputTextBox.Location = new System.Drawing.Point(119, 176);
            this.ArgOneInputTextBox.Name = "ArgOneInputTextBox";
            this.ArgOneInputTextBox.Size = new System.Drawing.Size(109, 34);
            this.ArgOneInputTextBox.TabIndex = 17;
            this.ArgOneInputTextBox.Text = "";
            // 
            // ArgTwoInputTextBox
            // 
            this.ArgTwoInputTextBox.Location = new System.Drawing.Point(119, 308);
            this.ArgTwoInputTextBox.Name = "ArgTwoInputTextBox";
            this.ArgTwoInputTextBox.Size = new System.Drawing.Size(109, 34);
            this.ArgTwoInputTextBox.TabIndex = 16;
            this.ArgTwoInputTextBox.Text = "";
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.ForeColor = System.Drawing.Color.White;
            this.InputLabel.Location = new System.Drawing.Point(6, 308);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(78, 25);
            this.InputLabel.TabIndex = 15;
            this.InputLabel.Text = "Input 2";
            // 
            // ArgTwoLabel
            // 
            this.ArgTwoLabel.AutoSize = true;
            this.ArgTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArgTwoLabel.ForeColor = System.Drawing.Color.White;
            this.ArgTwoLabel.Location = new System.Drawing.Point(5, 265);
            this.ArgTwoLabel.Name = "ArgTwoLabel";
            this.ArgTwoLabel.Size = new System.Drawing.Size(64, 25);
            this.ArgTwoLabel.TabIndex = 11;
            this.ArgTwoLabel.Text = "Arg 2";
            // 
            // ArgTwoComboBox
            // 
            this.ArgTwoComboBox.FormattingEnabled = true;
            this.ArgTwoComboBox.Location = new System.Drawing.Point(119, 265);
            this.ArgTwoComboBox.Name = "ArgTwoComboBox";
            this.ArgTwoComboBox.Size = new System.Drawing.Size(109, 28);
            this.ArgTwoComboBox.TabIndex = 10;
            // 
            // ArgOneLabel
            // 
            this.ArgOneLabel.AutoSize = true;
            this.ArgOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArgOneLabel.ForeColor = System.Drawing.Color.White;
            this.ArgOneLabel.Location = new System.Drawing.Point(6, 134);
            this.ArgOneLabel.Name = "ArgOneLabel";
            this.ArgOneLabel.Size = new System.Drawing.Size(58, 25);
            this.ArgOneLabel.TabIndex = 9;
            this.ArgOneLabel.Text = "Arg1";
            // 
            // ArgOneComboBox
            // 
            this.ArgOneComboBox.FormattingEnabled = true;
            this.ArgOneComboBox.Location = new System.Drawing.Point(120, 134);
            this.ArgOneComboBox.Name = "ArgOneComboBox";
            this.ArgOneComboBox.Size = new System.Drawing.Size(109, 28);
            this.ArgOneComboBox.TabIndex = 8;
            // 
            // QuickLabel
            // 
            this.QuickLabel.AutoSize = true;
            this.QuickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuickLabel.ForeColor = System.Drawing.Color.White;
            this.QuickLabel.Location = new System.Drawing.Point(33, 11);
            this.QuickLabel.Name = "QuickLabel";
            this.QuickLabel.Size = new System.Drawing.Size(183, 25);
            this.QuickLabel.TabIndex = 3;
            this.QuickLabel.Text = "Quick Commands";
            // 
            // InputOneLabel
            // 
            this.InputOneLabel.AutoSize = true;
            this.InputOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOneLabel.ForeColor = System.Drawing.Color.White;
            this.InputOneLabel.Location = new System.Drawing.Point(5, 176);
            this.InputOneLabel.Name = "InputOneLabel";
            this.InputOneLabel.Size = new System.Drawing.Size(78, 25);
            this.InputOneLabel.TabIndex = 5;
            this.InputOneLabel.Text = "Input 1";
            // 
            // CommandLabel
            // 
            this.CommandLabel.AutoSize = true;
            this.CommandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandLabel.ForeColor = System.Drawing.Color.White;
            this.CommandLabel.Location = new System.Drawing.Point(5, 48);
            this.CommandLabel.Name = "CommandLabel";
            this.CommandLabel.Size = new System.Drawing.Size(110, 25);
            this.CommandLabel.TabIndex = 3;
            this.CommandLabel.Text = "Command";
            // 
            // CommandComboBox
            // 
            this.CommandComboBox.FormattingEnabled = true;
            this.CommandComboBox.Location = new System.Drawing.Point(119, 48);
            this.CommandComboBox.Name = "CommandComboBox";
            this.CommandComboBox.Size = new System.Drawing.Size(109, 28);
            this.CommandComboBox.TabIndex = 0;
            // 
            // FilePanel
            // 
            this.FilePanel.BackColor = System.Drawing.Color.Teal;
            this.FilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilePanel.Controls.Add(this.CommandFileComboBox);
            this.FilePanel.Controls.Add(this.label1);
            this.FilePanel.Controls.Add(this.FileOneLabel);
            this.FilePanel.Location = new System.Drawing.Point(276, 66);
            this.FilePanel.Name = "FilePanel";
            this.FilePanel.Size = new System.Drawing.Size(244, 92);
            this.FilePanel.TabIndex = 8;
            // 
            // CommandFileComboBox
            // 
            this.CommandFileComboBox.FormattingEnabled = true;
            this.CommandFileComboBox.Location = new System.Drawing.Point(70, 48);
            this.CommandFileComboBox.Name = "CommandFileComboBox";
            this.CommandFileComboBox.Size = new System.Drawing.Size(162, 28);
            this.CommandFileComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Commands";
            // 
            // FileOneLabel
            // 
            this.FileOneLabel.AutoSize = true;
            this.FileOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileOneLabel.ForeColor = System.Drawing.Color.White;
            this.FileOneLabel.Location = new System.Drawing.Point(5, 48);
            this.FileOneLabel.Name = "FileOneLabel";
            this.FileOneLabel.Size = new System.Drawing.Size(61, 25);
            this.FileOneLabel.TabIndex = 3;
            this.FileOneLabel.Text = "CMD";
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.Teal;
            this.SettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SettingsPanel.Controls.Add(this.LogsTextBox);
            this.SettingsPanel.Controls.Add(this.LogsLabel);
            this.SettingsPanel.Location = new System.Drawing.Point(535, 66);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(244, 364);
            this.SettingsPanel.TabIndex = 9;
            // 
            // LogsTextBox
            // 
            this.LogsTextBox.BackColor = System.Drawing.Color.Teal;
            this.LogsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogsTextBox.ForeColor = System.Drawing.Color.White;
            this.LogsTextBox.Location = new System.Drawing.Point(3, 39);
            this.LogsTextBox.Name = "LogsTextBox";
            this.LogsTextBox.ReadOnly = true;
            this.LogsTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.LogsTextBox.Size = new System.Drawing.Size(236, 320);
            this.LogsTextBox.TabIndex = 18;
            this.LogsTextBox.Text = "";
            // 
            // LogsLabel
            // 
            this.LogsLabel.AutoSize = true;
            this.LogsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogsLabel.ForeColor = System.Drawing.Color.White;
            this.LogsLabel.Location = new System.Drawing.Point(95, 11);
            this.LogsLabel.Name = "LogsLabel";
            this.LogsLabel.Size = new System.Drawing.Size(59, 25);
            this.LogsLabel.TabIndex = 3;
            this.LogsLabel.Text = "Logs";
            // 
            // ReloadListsButton
            // 
            this.ReloadListsButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ReloadListsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadListsButton.ForeColor = System.Drawing.Color.White;
            this.ReloadListsButton.Location = new System.Drawing.Point(276, 178);
            this.ReloadListsButton.Name = "ReloadListsButton";
            this.ReloadListsButton.Size = new System.Drawing.Size(244, 38);
            this.ReloadListsButton.TabIndex = 10;
            this.ReloadListsButton.Text = "Reload List";
            this.ReloadListsButton.UseVisualStyleBackColor = false;
            this.ReloadListsButton.Click += new System.EventHandler(this.ReloadListsButton_Click);
            // 
            // ExecuteFileButton
            // 
            this.ExecuteFileButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ExecuteFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteFileButton.ForeColor = System.Drawing.Color.White;
            this.ExecuteFileButton.Location = new System.Drawing.Point(276, 231);
            this.ExecuteFileButton.Name = "ExecuteFileButton";
            this.ExecuteFileButton.Size = new System.Drawing.Size(244, 38);
            this.ExecuteFileButton.TabIndex = 11;
            this.ExecuteFileButton.Text = "Execute CMD";
            this.ExecuteFileButton.UseVisualStyleBackColor = false;
            this.ExecuteFileButton.Click += new System.EventHandler(this.ExecuteFileButton_Click);
            // 
            // ExecuteQuickCMDButton
            // 
            this.ExecuteQuickCMDButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ExecuteQuickCMDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteQuickCMDButton.ForeColor = System.Drawing.Color.White;
            this.ExecuteQuickCMDButton.Location = new System.Drawing.Point(276, 285);
            this.ExecuteQuickCMDButton.Name = "ExecuteQuickCMDButton";
            this.ExecuteQuickCMDButton.Size = new System.Drawing.Size(244, 38);
            this.ExecuteQuickCMDButton.TabIndex = 12;
            this.ExecuteQuickCMDButton.Text = "Execute Quick CMD";
            this.ExecuteQuickCMDButton.UseVisualStyleBackColor = false;
            this.ExecuteQuickCMDButton.Click += new System.EventHandler(this.ExecuteQuickCMDButton_Click);
            // 
            // GitUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ExecuteQuickCMDButton);
            this.Controls.Add(this.ExecuteFileButton);
            this.Controls.Add(this.ReloadListsButton);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.FilePanel);
            this.Controls.Add(this.QuickOptionsPanel);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GitUpForm";
            this.Text = "GitUp";
            this.Load += new System.EventHandler(this.GitUpForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcoBox)).EndInit();
            this.QuickOptionsPanel.ResumeLayout(false);
            this.QuickOptionsPanel.PerformLayout();
            this.FilePanel.ResumeLayout(false);
            this.FilePanel.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label MinimizeLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Panel QuickOptionsPanel;
        private System.Windows.Forms.RichTextBox ArgOneInputTextBox;
        private System.Windows.Forms.RichTextBox ArgTwoInputTextBox;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label ArgTwoLabel;
        private System.Windows.Forms.ComboBox ArgTwoComboBox;
        private System.Windows.Forms.Label ArgOneLabel;
        private System.Windows.Forms.ComboBox ArgOneComboBox;
        private System.Windows.Forms.Label QuickLabel;
        private System.Windows.Forms.Label InputOneLabel;
        private System.Windows.Forms.Label CommandLabel;
        private System.Windows.Forms.ComboBox CommandComboBox;
        private System.Windows.Forms.Panel FilePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FileOneLabel;
        private System.Windows.Forms.ComboBox CommandFileComboBox;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Label LogsLabel;
        private System.Windows.Forms.Button ReloadListsButton;
        private System.Windows.Forms.Button ExecuteFileButton;
        private System.Windows.Forms.RichTextBox LogsTextBox;
        private System.Windows.Forms.PictureBox IcoBox;
        private System.Windows.Forms.Button ExecuteQuickCMDButton;
    }
}

