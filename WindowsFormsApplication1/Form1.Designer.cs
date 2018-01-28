namespace CSharpProject
{
    partial class lbEpisodeInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lbEpisodeInfo));
            this.cbChooseKat = new System.Windows.Forms.ComboBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lbPodcast = new System.Windows.Forms.ListBox();
            this.txbUrl = new System.Windows.Forms.TextBox();
            this.btnAddPod = new System.Windows.Forms.Button();
            this.btnHantera = new System.Windows.Forms.Button();
            this.lbEpisod = new System.Windows.Forms.ListBox();
            this.cbKat = new System.Windows.Forms.ComboBox();
            this.lbEInfo = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.Rb1h = new System.Windows.Forms.RadioButton();
            this.Rb1Day = new System.Windows.Forms.RadioButton();
            this.Rb1Week = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // cbChooseKat
            // 
            this.cbChooseKat.FormattingEnabled = true;
            this.cbChooseKat.Location = new System.Drawing.Point(28, 12);
            this.cbChooseKat.Name = "cbChooseKat";
            this.cbChooseKat.Size = new System.Drawing.Size(89, 21);
            this.cbChooseKat.TabIndex = 0;
            this.cbChooseKat.Text = "Välj kategori";
            this.cbChooseKat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbChooseKat_MouseClick_2);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(696, 89);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(81, 23);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "Lägg till";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // lbPodcast
            // 
            this.lbPodcast.FormattingEnabled = true;
            this.lbPodcast.Location = new System.Drawing.Point(28, 64);
            this.lbPodcast.Name = "lbPodcast";
            this.lbPodcast.Size = new System.Drawing.Size(126, 277);
            this.lbPodcast.TabIndex = 2;
            this.lbPodcast.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.lbPodcast.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.lbPodcast.SelectedValueChanged += new System.EventHandler(this.lbPodcast_SelectedValueChanged);
            // 
            // txbUrl
            // 
            this.txbUrl.Location = new System.Drawing.Point(588, 64);
            this.txbUrl.Name = "txbUrl";
            this.txbUrl.Size = new System.Drawing.Size(189, 20);
            this.txbUrl.TabIndex = 4;
            // 
            // btnAddPod
            // 
            this.btnAddPod.Location = new System.Drawing.Point(135, 12);
            this.btnAddPod.Name = "btnAddPod";
            this.btnAddPod.Size = new System.Drawing.Size(80, 21);
            this.btnAddPod.TabIndex = 5;
            this.btnAddPod.Text = "Lägg till";
            this.btnAddPod.UseVisualStyleBackColor = true;
            this.btnAddPod.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHantera
            // 
            this.btnHantera.Location = new System.Drawing.Point(723, 12);
            this.btnHantera.Name = "btnHantera";
            this.btnHantera.Size = new System.Drawing.Size(63, 26);
            this.btnHantera.TabIndex = 10;
            this.btnHantera.Text = "Öppna";
            this.btnHantera.UseVisualStyleBackColor = true;
            this.btnHantera.Click += new System.EventHandler(this.btnHantera_Click);
            // 
            // lbEpisod
            // 
            this.lbEpisod.FormattingEnabled = true;
            this.lbEpisod.Location = new System.Drawing.Point(160, 64);
            this.lbEpisod.Name = "lbEpisod";
            this.lbEpisod.Size = new System.Drawing.Size(142, 277);
            this.lbEpisod.TabIndex = 8;
            this.lbEpisod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbEpisod_MouseClick);
            this.lbEpisod.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // cbKat
            // 
            this.cbKat.FormattingEnabled = true;
            this.cbKat.Location = new System.Drawing.Point(592, 89);
            this.cbKat.Name = "cbKat";
            this.cbKat.Size = new System.Drawing.Size(93, 21);
            this.cbKat.TabIndex = 12;
            this.cbKat.Text = "Välj Kategori";
            this.cbKat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbKat_MouseClick_1);
            // 
            // lbEInfo
            // 
            this.lbEInfo.Location = new System.Drawing.Point(325, 89);
            this.lbEInfo.Multiline = true;
            this.lbEInfo.Name = "lbEInfo";
            this.lbEInfo.Size = new System.Drawing.Size(246, 172);
            this.lbEInfo.TabIndex = 13;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(325, 63);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.ReadOnly = true;
            this.tbTitle.Size = new System.Drawing.Size(246, 20);
            this.tbTitle.TabIndex = 14;
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(325, 267);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(245, 50);
            this.Player.TabIndex = 15;
            this.Player.Enter += new System.EventHandler(this.Player_Enter);
            // 
            // Rb1h
            // 
            this.Rb1h.AutoSize = true;
            this.Rb1h.Location = new System.Drawing.Point(601, 138);
            this.Rb1h.Name = "Rb1h";
            this.Rb1h.Size = new System.Drawing.Size(61, 17);
            this.Rb1h.TabIndex = 17;
            this.Rb1h.TabStop = true;
            this.Rb1h.Text = "1 timme";
            this.Rb1h.UseVisualStyleBackColor = true;
            // 
            // Rb1Day
            // 
            this.Rb1Day.AutoSize = true;
            this.Rb1Day.Location = new System.Drawing.Point(601, 162);
            this.Rb1Day.Name = "Rb1Day";
            this.Rb1Day.Size = new System.Drawing.Size(52, 17);
            this.Rb1Day.TabIndex = 18;
            this.Rb1Day.TabStop = true;
            this.Rb1Day.Text = "1 dag";
            this.Rb1Day.UseVisualStyleBackColor = true;
            this.Rb1Day.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Rb1Week
            // 
            this.Rb1Week.AutoSize = true;
            this.Rb1Week.Location = new System.Drawing.Point(601, 186);
            this.Rb1Week.Name = "Rb1Week";
            this.Rb1Week.Size = new System.Drawing.Size(64, 17);
            this.Rb1Week.TabIndex = 19;
            this.Rb1Week.TabStop = true;
            this.Rb1Week.Text = "1 vecka";
            this.Rb1Week.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Välj updateringsintervall";
            // 
            // btnRemoveP
            // 
            this.btnRemoveP.Location = new System.Drawing.Point(28, 348);
            this.btnRemoveP.Name = "btnRemoveP";
            this.btnRemoveP.Size = new System.Drawing.Size(126, 23);
            this.btnRemoveP.TabIndex = 21;
            this.btnRemoveP.Text = "Ta bort vald podcast";
            this.btnRemoveP.UseVisualStyleBackColor = true;
            this.btnRemoveP.Click += new System.EventHandler(this.btnRemoveP_Click);
            // 
            // lbEpisodeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 470);
            this.Controls.Add(this.btnRemoveP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rb1Week);
            this.Controls.Add(this.Rb1Day);
            this.Controls.Add(this.Rb1h);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lbEInfo);
            this.Controls.Add(this.cbKat);
            this.Controls.Add(this.btnHantera);
            this.Controls.Add(this.lbEpisod);
            this.Controls.Add(this.btnAddPod);
            this.Controls.Add(this.txbUrl);
            this.Controls.Add(this.lbPodcast);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.cbChooseKat);
            this.Name = "lbEpisodeInfo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbChooseKat;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.ListBox lbPodcast;
        private System.Windows.Forms.TextBox txbUrl;
        private System.Windows.Forms.Button btnAddPod;
        private System.Windows.Forms.Button btnHantera;
        private System.Windows.Forms.ListBox lbEpisod;
        private System.Windows.Forms.ComboBox cbKat;
        private System.Windows.Forms.TextBox lbEInfo;
        private System.Windows.Forms.TextBox tbTitle;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.RadioButton Rb1h;
        private System.Windows.Forms.RadioButton Rb1Day;
        private System.Windows.Forms.RadioButton Rb1Week;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveP;
    }
}