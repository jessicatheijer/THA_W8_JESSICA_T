namespace THA_W8_JESSICA_T
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMatchDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Players = new System.Windows.Forms.ComboBox();
            this.comboBox_Teams = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.dataGridView_away = new System.Windows.Forms.DataGridView();
            this.dataGridView_home = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_MatchDetails = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_away)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MatchDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerDataToolStripMenuItem,
            this.showMatchDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerDataToolStripMenuItem
            // 
            this.playerDataToolStripMenuItem.Name = "playerDataToolStripMenuItem";
            this.playerDataToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.playerDataToolStripMenuItem.Text = "Player Data";
            this.playerDataToolStripMenuItem.Click += new System.EventHandler(this.playerDataToolStripMenuItem_Click);
            // 
            // showMatchDetailsToolStripMenuItem
            // 
            this.showMatchDetailsToolStripMenuItem.Name = "showMatchDetailsToolStripMenuItem";
            this.showMatchDetailsToolStripMenuItem.Size = new System.Drawing.Size(184, 29);
            this.showMatchDetailsToolStripMenuItem.Text = "Show Match Details";
            this.showMatchDetailsToolStripMenuItem.Click += new System.EventHandler(this.showMatchDetailsToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Team";
            // 
            // comboBox_Players
            // 
            this.comboBox_Players.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Players.FormattingEnabled = true;
            this.comboBox_Players.Location = new System.Drawing.Point(32, 135);
            this.comboBox_Players.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_Players.Name = "comboBox_Players";
            this.comboBox_Players.Size = new System.Drawing.Size(213, 28);
            this.comboBox_Players.TabIndex = 1;
            this.comboBox_Players.SelectedIndexChanged += new System.EventHandler(this.comboBox_Players_SelectedIndexChanged);
            // 
            // comboBox_Teams
            // 
            this.comboBox_Teams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Teams.FormattingEnabled = true;
            this.comboBox_Teams.Location = new System.Drawing.Point(32, 57);
            this.comboBox_Teams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_Teams.Name = "comboBox_Teams";
            this.comboBox_Teams.Size = new System.Drawing.Size(211, 28);
            this.comboBox_Teams.TabIndex = 0;
            this.comboBox_Teams.SelectedIndexChanged += new System.EventHandler(this.comboBox_Teams_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dataGridView_MatchDetails);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dataGridView_home);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button_Search);
            this.panel1.Controls.Add(this.dataGridView_away);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox_Players);
            this.panel1.Controls.Add(this.comboBox_Teams);
            this.panel1.Location = new System.Drawing.Point(22, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 592);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(32, 197);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(172, 52);
            this.button_Search.TabIndex = 4;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // dataGridView_away
            // 
            this.dataGridView_away.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_away.ColumnHeadersHeight = 34;
            this.dataGridView_away.Location = new System.Drawing.Point(731, 46);
            this.dataGridView_away.Name = "dataGridView_away";
            this.dataGridView_away.RowHeadersVisible = false;
            this.dataGridView_away.RowHeadersWidth = 62;
            this.dataGridView_away.Size = new System.Drawing.Size(403, 264);
            this.dataGridView_away.TabIndex = 0;
            this.dataGridView_away.Visible = false;
            // 
            // dataGridView_home
            // 
            this.dataGridView_home.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_home.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_home.Location = new System.Drawing.Point(305, 46);
            this.dataGridView_home.Name = "dataGridView_home";
            this.dataGridView_home.RowHeadersVisible = false;
            this.dataGridView_home.RowHeadersWidth = 62;
            this.dataGridView_home.RowTemplate.Height = 28;
            this.dataGridView_home.Size = new System.Drawing.Size(403, 264);
            this.dataGridView_home.TabIndex = 6;
            this.dataGridView_home.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Team Home Players";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(727, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Team Away Players";
            this.label5.Visible = false;
            // 
            // dataGridView_MatchDetails
            // 
            this.dataGridView_MatchDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_MatchDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MatchDetails.Location = new System.Drawing.Point(305, 374);
            this.dataGridView_MatchDetails.Name = "dataGridView_MatchDetails";
            this.dataGridView_MatchDetails.RowHeadersVisible = false;
            this.dataGridView_MatchDetails.RowHeadersWidth = 62;
            this.dataGridView_MatchDetails.RowTemplate.Height = 28;
            this.dataGridView_MatchDetails.Size = new System.Drawing.Size(829, 186);
            this.dataGridView_MatchDetails.TabIndex = 9;
            this.dataGridView_MatchDetails.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Match Details";
            this.label6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_away)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MatchDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMatchDetailsToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Players;
        private System.Windows.Forms.ComboBox comboBox_Teams;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_away;
        private System.Windows.Forms.DataGridView dataGridView_home;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_MatchDetails;
    }
}

