
namespace OS_Kurs_FIFO
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FramesLabel = new System.Windows.Forms.Label();
            this.FrameCount = new System.Windows.Forms.NumericUpDown();
            this.YourDateTextbox = new System.Windows.Forms.TextBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.RealTimeTextbox = new System.Windows.Forms.RichTextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SpeedTrackbar = new System.Windows.Forms.TrackBar();
            this.StopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentDropLabel = new System.Windows.Forms.Label();
            this.CurrentAddLabel = new System.Windows.Forms.Label();
            this.AllDropsLabel = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ManualInputTextbox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FifoTextbox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.dragControl1 = new OS_Kurs_FIFO.DragControl();
            ((System.ComponentModel.ISupportInitialize)(this.FrameCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackbar)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.MinimizeButton.BackgroundImage = global::OS_Kurs_FIFO.Properties.Resources._2;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(720, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(29, 25);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.ExitButton.BackgroundImage = global::OS_Kurs_FIFO.Properties.Resources._1;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(753, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(29, 25);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FramesLabel
            // 
            this.FramesLabel.AutoSize = true;
            this.FramesLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FramesLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.FramesLabel.Location = new System.Drawing.Point(12, 44);
            this.FramesLabel.Name = "FramesLabel";
            this.FramesLabel.Size = new System.Drawing.Size(168, 18);
            this.FramesLabel.TabIndex = 29;
            this.FramesLabel.Text = "Number of Frames";
            // 
            // FrameCount
            // 
            this.FrameCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FrameCount.Location = new System.Drawing.Point(15, 65);
            this.FrameCount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.FrameCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FrameCount.Name = "FrameCount";
            this.FrameCount.Size = new System.Drawing.Size(184, 26);
            this.FrameCount.TabIndex = 28;
            this.FrameCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // YourDateTextbox
            // 
            this.YourDateTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.YourDateTextbox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YourDateTextbox.Location = new System.Drawing.Point(6, 21);
            this.YourDateTextbox.Multiline = true;
            this.YourDateTextbox.Name = "YourDateTextbox";
            this.YourDateTextbox.ReadOnly = true;
            this.YourDateTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.YourDateTextbox.Size = new System.Drawing.Size(455, 51);
            this.YourDateTextbox.TabIndex = 26;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // RealTimeTextbox
            // 
            this.RealTimeTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
            this.RealTimeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RealTimeTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RealTimeTextbox.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RealTimeTextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.RealTimeTextbox.Location = new System.Drawing.Point(6, 25);
            this.RealTimeTextbox.Multiline = false;
            this.RealTimeTextbox.Name = "RealTimeTextbox";
            this.RealTimeTextbox.ReadOnly = true;
            this.RealTimeTextbox.ShortcutsEnabled = false;
            this.RealTimeTextbox.Size = new System.Drawing.Size(345, 44);
            this.RealTimeTextbox.TabIndex = 35;
            this.RealTimeTextbox.Text = "";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // SpeedTrackbar
            // 
            this.SpeedTrackbar.Location = new System.Drawing.Point(74, 169);
            this.SpeedTrackbar.Name = "SpeedTrackbar";
            this.SpeedTrackbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SpeedTrackbar.Size = new System.Drawing.Size(153, 45);
            this.SpeedTrackbar.TabIndex = 36;
            // 
            // StopButton
            // 
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StopButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopButton.Location = new System.Drawing.Point(7, 77);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(287, 51);
            this.StopButton.TabIndex = 37;
            this.StopButton.Text = "Stop Simulation";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Choose Speed of Simulation";
            // 
            // CurrentDropLabel
            // 
            this.CurrentDropLabel.AutoSize = true;
            this.CurrentDropLabel.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentDropLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrentDropLabel.Location = new System.Drawing.Point(54, 31);
            this.CurrentDropLabel.Name = "CurrentDropLabel";
            this.CurrentDropLabel.Size = new System.Drawing.Size(29, 30);
            this.CurrentDropLabel.TabIndex = 43;
            this.CurrentDropLabel.Text = "-";
            // 
            // CurrentAddLabel
            // 
            this.CurrentAddLabel.AutoSize = true;
            this.CurrentAddLabel.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentAddLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrentAddLabel.Location = new System.Drawing.Point(173, 31);
            this.CurrentAddLabel.Name = "CurrentAddLabel";
            this.CurrentAddLabel.Size = new System.Drawing.Size(29, 30);
            this.CurrentAddLabel.TabIndex = 44;
            this.CurrentAddLabel.Text = "-";
            // 
            // AllDropsLabel
            // 
            this.AllDropsLabel.AutoSize = true;
            this.AllDropsLabel.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllDropsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AllDropsLabel.Location = new System.Drawing.Point(313, 31);
            this.AllDropsLabel.Name = "AllDropsLabel";
            this.AllDropsLabel.Size = new System.Drawing.Size(29, 30);
            this.AllDropsLabel.TabIndex = 45;
            this.AllDropsLabel.Text = "-";
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.MenuStrip.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(798, 26);
            this.MenuStrip.TabIndex = 46;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFromFileToolStripMenuItem,
            this.saveToFileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFromFileToolStripMenuItem
            // 
            this.openFromFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.openFromFileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.openFromFileToolStripMenuItem.Name = "openFromFileToolStripMenuItem";
            this.openFromFileToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.openFromFileToolStripMenuItem.Text = "Open from file";
            this.openFromFileToolStripMenuItem.Click += new System.EventHandler(this.openFromFileToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.saveToFileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.saveToFileToolStripMenuItem.Text = "Save to file";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Controls.Add(this.StopButton);
            this.groupBox1.Controls.Add(this.SpeedTrackbar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(487, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 235);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control panel";
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StartButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(7, 25);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(287, 51);
            this.StartButton.TabIndex = 39;
            this.StartButton.Text = "Start Simulation";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NextButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(623, 25);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(145, 44);
            this.NextButton.TabIndex = 40;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ManualInputTextbox
            // 
            this.ManualInputTextbox.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManualInputTextbox.Location = new System.Drawing.Point(6, 25);
            this.ManualInputTextbox.Multiline = true;
            this.ManualInputTextbox.Name = "ManualInputTextbox";
            this.ManualInputTextbox.Size = new System.Drawing.Size(461, 44);
            this.ManualInputTextbox.TabIndex = 50;
            this.ManualInputTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // ResetButton
            // 
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ResetButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetButton.Location = new System.Drawing.Point(482, 25);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(142, 44);
            this.ResetButton.TabIndex = 51;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ManualInputTextbox);
            this.groupBox2.Controls.Add(this.ResetButton);
            this.groupBox2.Controls.Add(this.NextButton);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 78);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter element and press \"Next\" or \"Start Simulation\"";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.YourDateTextbox);
            this.groupBox3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(12, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 78);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Your data";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FifoTextbox);
            this.groupBox4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(12, 280);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(467, 151);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Result";
            // 
            // FifoTextbox
            // 
            this.FifoTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FifoTextbox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FifoTextbox.Location = new System.Drawing.Point(6, 25);
            this.FifoTextbox.Multiline = true;
            this.FifoTextbox.Name = "FifoTextbox";
            this.FifoTextbox.ReadOnly = true;
            this.FifoTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FifoTextbox.Size = new System.Drawing.Size(455, 119);
            this.FifoTextbox.TabIndex = 28;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RealTimeTextbox);
            this.groupBox5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Location = new System.Drawing.Point(12, 445);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(357, 83);
            this.groupBox5.TabIndex = 55;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Current Frame";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CurrentDropLabel);
            this.groupBox6.Controls.Add(this.CurrentAddLabel);
            this.groupBox6.Controls.Add(this.AllDropsLabel);
            this.groupBox6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Location = new System.Drawing.Point(375, 445);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(412, 83);
            this.groupBox6.TabIndex = 56;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Current Drop|Current Add|Count of Drops";
            // 
            // dragControl1
            // 
            this.dragControl1.selectControl = this.MenuStrip;
            // 
            // MainForm
            // 
            this.AcceptButton = this.NextButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(798, 536);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.FramesLabel);
            this.Controls.Add(this.FrameCount);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fifo Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.FrameCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackbar)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FramesLabel;
        private System.Windows.Forms.NumericUpDown FrameCount;
        private System.Windows.Forms.TextBox YourDateTextbox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.RichTextBox RealTimeTextbox;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.TrackBar SpeedTrackbar;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentDropLabel;
        private System.Windows.Forms.Label CurrentAddLabel;
        private System.Windows.Forms.Label AllDropsLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox ManualInputTextbox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox FifoTextbox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private DragControl dragControl1;
    }
}

