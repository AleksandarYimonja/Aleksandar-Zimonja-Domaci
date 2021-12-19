
namespace Ekranska_forma
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
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtIme = new System.Windows.Forms.TextBox();
            this.TxtPrezime = new System.Windows.Forms.TextBox();
            this.TxtJMBG = new System.Windows.Forms.TextBox();
            this.TxtAdresa = new System.Windows.Forms.TextBox();
            this.TxtImejl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChng = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(141, 56);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 20);
            this.TxtID.TabIndex = 0;
            // 
            // TxtIme
            // 
            this.TxtIme.Location = new System.Drawing.Point(141, 82);
            this.TxtIme.Name = "TxtIme";
            this.TxtIme.Size = new System.Drawing.Size(100, 20);
            this.TxtIme.TabIndex = 1;
            // 
            // TxtPrezime
            // 
            this.TxtPrezime.Location = new System.Drawing.Point(141, 108);
            this.TxtPrezime.Name = "TxtPrezime";
            this.TxtPrezime.Size = new System.Drawing.Size(100, 20);
            this.TxtPrezime.TabIndex = 2;
            // 
            // TxtJMBG
            // 
            this.TxtJMBG.Location = new System.Drawing.Point(141, 134);
            this.TxtJMBG.Name = "TxtJMBG";
            this.TxtJMBG.Size = new System.Drawing.Size(100, 20);
            this.TxtJMBG.TabIndex = 3;
            // 
            // TxtAdresa
            // 
            this.TxtAdresa.Location = new System.Drawing.Point(141, 160);
            this.TxtAdresa.Name = "TxtAdresa";
            this.TxtAdresa.Size = new System.Drawing.Size(100, 20);
            this.TxtAdresa.TabIndex = 4;
            // 
            // TxtImejl
            // 
            this.TxtImejl.Location = new System.Drawing.Point(141, 186);
            this.TxtImejl.Name = "TxtImejl";
            this.TxtImejl.Size = new System.Drawing.Size(100, 20);
            this.TxtImejl.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "JMBG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adresa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "E-mail:";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(247, 241);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(166, 241);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 13;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(328, 241);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 14;
            this.btnEnd.Text = ">>";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(85, 241);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 15;
            this.btnHome.Text = "<<";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(85, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChng
            // 
            this.btnChng.Location = new System.Drawing.Point(166, 270);
            this.btnChng.Name = "btnChng";
            this.btnChng.Size = new System.Drawing.Size(75, 23);
            this.btnChng.TabIndex = 17;
            this.btnChng.Text = "Izmeni";
            this.btnChng.UseVisualStyleBackColor = true;
            this.btnChng.Click += new System.EventHandler(this.btnChng_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(247, 270);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 18;
            this.btnDel.Text = "Brisi";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnChng);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtImejl);
            this.Controls.Add(this.TxtAdresa);
            this.Controls.Add(this.TxtJMBG);
            this.Controls.Add(this.TxtPrezime);
            this.Controls.Add(this.TxtIme);
            this.Controls.Add(this.TxtID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtIme;
        private System.Windows.Forms.TextBox TxtPrezime;
        private System.Windows.Forms.TextBox TxtJMBG;
        private System.Windows.Forms.TextBox TxtAdresa;
        private System.Windows.Forms.TextBox TxtImejl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChng;
        private System.Windows.Forms.Button btnDel;
    }
}

