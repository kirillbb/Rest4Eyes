namespace Rest4Eyes
{
    partial class SettingsForm
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

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                Hide();
        }


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rEST4EYESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.howOffenRestTextBox = new System.Windows.Forms.TextBox();
            this.howLongRestTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.hideButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "REST4EYES";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEST4EYESToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 104);
            // 
            // rEST4EYESToolStripMenuItem
            // 
            this.rEST4EYESToolStripMenuItem.Enabled = false;
            this.rEST4EYESToolStripMenuItem.Name = "rEST4EYESToolStripMenuItem";
            this.rEST4EYESToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.rEST4EYESToolStripMenuItem.Text = "REST4EYES 👁";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.settingsToolStripMenuItem.Text = "Настройки";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.closeToolStripMenuItem.Text = "Закрыть";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.DarkCyan;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveButton.Location = new System.Drawing.Point(0, 206);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(743, 66);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Сохранить и свернуть";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(406, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "минут на";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(641, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "минут";
            // 
            // howOffenRestTextBox
            // 
            this.howOffenRestTextBox.Location = new System.Drawing.Point(249, 88);
            this.howOffenRestTextBox.Name = "howOffenRestTextBox";
            this.howOffenRestTextBox.Size = new System.Drawing.Size(151, 27);
            this.howOffenRestTextBox.TabIndex = 9;
            this.howOffenRestTextBox.Text = "30";
            // 
            // howLongRestTextBox
            // 
            this.howLongRestTextBox.Location = new System.Drawing.Point(484, 88);
            this.howLongRestTextBox.Name = "howLongRestTextBox";
            this.howLongRestTextBox.Size = new System.Drawing.Size(151, 27);
            this.howLongRestTextBox.TabIndex = 10;
            this.howLongRestTextBox.Text = "5";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(41, 90);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(202, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Делать перерыв каждые";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countLabel.Location = new System.Drawing.Point(41, 133);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(248, 20);
            this.countLabel.TabIndex = 12;
            this.countLabel.Text = "Ближайший отдых через........минут";
            this.countLabel.Visible = false;
            // 
            // hideButton
            // 
            this.hideButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.hideButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hideButton.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hideButton.Location = new System.Drawing.Point(585, 0);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(50, 30);
            this.hideButton.TabIndex = 13;
            this.hideButton.Text = "___";
            this.hideButton.UseVisualStyleBackColor = false;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Location = new System.Drawing.Point(630, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(113, 30);
            this.closeButton.TabIndex = 14;
            this.closeButton.Text = "✖";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(240, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "👁 REST4EYES - Settings";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(742, 272);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.howLongRestTextBox);
            this.Controls.Add(this.howOffenRestTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.checkBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NotifyIcon notifyIcon1;
        private Button SaveButton;
        private Label label1;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private TextBox howOffenRestTextBox;
        private TextBox howLongRestTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private CheckBox checkBox1;
        private Label countLabel;
        private Button hideButton;
        private Button closeButton;
        private Label label3;
        private ToolStripMenuItem rEST4EYESToolStripMenuItem;
    }
}