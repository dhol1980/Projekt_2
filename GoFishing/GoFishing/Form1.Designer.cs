namespace GoFishing
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
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.listHand = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textProgres = new System.Windows.Forms.TextBox();
            this.textBooks = new System.Windows.Forms.TextBox();
            this.buttonAsk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(12, 42);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(178, 22);
            this.textName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(249, 42);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(166, 29);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Rozpocznij grę!";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // listHand
            // 
            this.listHand.FormattingEnabled = true;
            this.listHand.ItemHeight = 16;
            this.listHand.Location = new System.Drawing.Point(459, 42);
            this.listHand.Name = "listHand";
            this.listHand.Size = new System.Drawing.Size(232, 484);
            this.listHand.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ręka";
            // 
            // textProgres
            // 
            this.textProgres.Location = new System.Drawing.Point(12, 103);
            this.textProgres.Multiline = true;
            this.textProgres.Name = "textProgres";
            this.textProgres.ReadOnly = true;
            this.textProgres.Size = new System.Drawing.Size(403, 283);
            this.textProgres.TabIndex = 5;
            // 
            // textBooks
            // 
            this.textBooks.BackColor = System.Drawing.SystemColors.Control;
            this.textBooks.Location = new System.Drawing.Point(12, 421);
            this.textBooks.Multiline = true;
            this.textBooks.Name = "textBooks";
            this.textBooks.Size = new System.Drawing.Size(403, 165);
            this.textBooks.TabIndex = 6;
            // 
            // buttonAsk
            // 
            this.buttonAsk.Enabled = false;
            this.buttonAsk.Location = new System.Drawing.Point(459, 560);
            this.buttonAsk.Name = "buttonAsk";
            this.buttonAsk.Size = new System.Drawing.Size(232, 26);
            this.buttonAsk.TabIndex = 7;
            this.buttonAsk.Text = "Zarządaj karty";
            this.buttonAsk.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Postępty gry";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Grupy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 616);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAsk);
            this.Controls.Add(this.textBooks);
            this.Controls.Add(this.textProgres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listHand);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Idź na ryby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ListBox listHand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textProgres;
        private System.Windows.Forms.TextBox textBooks;
        private System.Windows.Forms.Button buttonAsk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

