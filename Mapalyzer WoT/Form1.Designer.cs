namespace Mapalyzer_WoT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_reset_stats = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_select_folder = new System.Windows.Forms.Button();
            this.panel_table = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MapIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.MapName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Battles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfMaps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vistaFolderBrowserDialog1 = new Ookii.Dialogs.WinForms.VistaFolderBrowserDialog();
            this.panel_menu.SuspendLayout();
            this.panel_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_reset_stats
            // 
            this.button_reset_stats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_reset_stats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_reset_stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_reset_stats.Location = new System.Drawing.Point(713, 3);
            this.button_reset_stats.Name = "button_reset_stats";
            this.button_reset_stats.Size = new System.Drawing.Size(78, 97);
            this.button_reset_stats.TabIndex = 0;
            this.button_reset_stats.Text = "Reset Stats";
            this.button_reset_stats.UseVisualStyleBackColor = true;
            this.button_reset_stats.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.Location = new System.Drawing.Point(8, 29);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(106, 37);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "label1";
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.SystemColors.Control;
            this.panel_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu.Controls.Add(this.lbl1);
            this.panel_menu.Controls.Add(this.button_select_folder);
            this.panel_menu.Controls.Add(this.button_reset_stats);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(794, 103);
            this.panel_menu.TabIndex = 2;
            // 
            // button_select_folder
            // 
            this.button_select_folder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_select_folder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_select_folder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_select_folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_select_folder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_select_folder.Location = new System.Drawing.Point(629, 3);
            this.button_select_folder.Name = "button_select_folder";
            this.button_select_folder.Size = new System.Drawing.Size(78, 97);
            this.button_select_folder.TabIndex = 1;
            this.button_select_folder.Text = "Select Folder";
            this.button_select_folder.UseVisualStyleBackColor = false;
            this.button_select_folder.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel_table
            // 
            this.panel_table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_table.AutoScroll = true;
            this.panel_table.AutoSize = true;
            this.panel_table.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_table.Controls.Add(this.dataGridView1);
            this.panel_table.Controls.Add(this.listBox1);
            this.panel_table.Location = new System.Drawing.Point(12, 130);
            this.panel_table.Name = "panel_table";
            this.panel_table.Size = new System.Drawing.Size(770, 430);
            this.panel_table.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MapIcon,
            this.MapName,
            this.Battles,
            this.NumberOfMaps});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 200;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(768, 428);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MapIcon
            // 
            this.MapIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MapIcon.HeaderText = "Map Icon";
            this.MapIcon.Name = "MapIcon";
            this.MapIcon.ReadOnly = true;
            this.MapIcon.Width = 52;
            // 
            // MapName
            // 
            this.MapName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MapName.DefaultCellStyle = dataGridViewCellStyle1;
            this.MapName.HeaderText = "Map Name";
            this.MapName.Name = "MapName";
            this.MapName.ReadOnly = true;
            this.MapName.Width = 78;
            // 
            // Battles
            // 
            this.Battles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Battles.DefaultCellStyle = dataGridViewCellStyle2;
            this.Battles.HeaderText = "Number of battles";
            this.Battles.Name = "Battles";
            this.Battles.ReadOnly = true;
            this.Battles.Width = 78;
            // 
            // NumberOfMaps
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumberOfMaps.DefaultCellStyle = dataGridViewCellStyle3;
            this.NumberOfMaps.HeaderText = "% of battles";
            this.NumberOfMaps.Name = "NumberOfMaps";
            this.NumberOfMaps.ReadOnly = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(744, 290);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "2021 RA1G.eu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 570);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mapalyzer 0.0.5a";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // vistaFolderBrowserDialog1
            // 
            this.vistaFolderBrowserDialog1.Description = "Select your World of Tanks replays folder. Typical path would be: C:\\ProgramFiles" +
    "\\World_of_Tanks_EU\\replays";
            this.vistaFolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.ProgramFilesX86;
            this.vistaFolderBrowserDialog1.ShowNewFolderButton = false;
            this.vistaFolderBrowserDialog1.UseDescriptionForTitle = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_table);
            this.Controls.Add(this.panel_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(810, 622);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapalyzer WoT";
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_reset_stats;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_table;
        private System.Windows.Forms.Button button_select_folder;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewImageColumn MapIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MapName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Battles;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfMaps;
        private Ookii.Dialogs.WinForms.VistaFolderBrowserDialog vistaFolderBrowserDialog1;
    }
}

