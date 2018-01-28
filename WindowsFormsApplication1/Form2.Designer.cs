namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txfAddCategory = new System.Windows.Forms.TextBox();
            this.cbRemove = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbÄndraKat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(180, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Lägg till";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // txfAddCategory
            // 
            this.txfAddCategory.Location = new System.Drawing.Point(12, 27);
            this.txfAddCategory.Name = "txfAddCategory";
            this.txfAddCategory.Size = new System.Drawing.Size(100, 20);
            this.txfAddCategory.TabIndex = 1;
            // 
            // cbRemove
            // 
            this.cbRemove.FormattingEnabled = true;
            this.cbRemove.Location = new System.Drawing.Point(11, 84);
            this.cbRemove.Name = "cbRemove";
            this.cbRemove.Size = new System.Drawing.Size(101, 21);
            this.cbRemove.TabIndex = 3;
            this.cbRemove.Text = "Välj kategori";
            this.cbRemove.SelectedIndexChanged += new System.EventHandler(this.cbRemove_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(180, 81);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 24);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Ta bort";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbÄndraKat
            // 
            this.tbÄndraKat.Location = new System.Drawing.Point(11, 156);
            this.tbÄndraKat.Name = "tbÄndraKat";
            this.tbÄndraKat.Size = new System.Drawing.Size(100, 20);
            this.tbÄndraKat.TabIndex = 5;
            this.tbÄndraKat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbÄndraKat_MouseClick);
            this.tbÄndraKat.TextChanged += new System.EventHandler(this.tbÄndraKat_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ändra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(8, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "För att ändra namn välj kategori ovan ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "För att ta bort välj kategori ur listan!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Skriv namn för ny kategori här!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 205);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbÄndraKat);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.cbRemove);
            this.Controls.Add(this.txfAddCategory);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form2";
            this.Text = "Välj tidsintervall";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txfAddCategory;
        private System.Windows.Forms.ComboBox cbRemove;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbÄndraKat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}