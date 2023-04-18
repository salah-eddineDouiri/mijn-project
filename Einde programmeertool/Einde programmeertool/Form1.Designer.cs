
namespace Einde_programmeertool
{
    partial class frmEinde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEinde));
            this.gbx1 = new System.Windows.Forms.GroupBox();
            this.rdbWhile = new System.Windows.Forms.RadioButton();
            this.rdbFor = new System.Windows.Forms.RadioButton();
            this.gbx2 = new System.Windows.Forms.GroupBox();
            this.txtBegin = new System.Windows.Forms.TextBox();
            this.lblBeginWaarde = new System.Windows.Forms.Label();
            this.lblGelijkAan = new System.Windows.Forms.Label();
            this.rdbGelijkAan = new System.Windows.Forms.RadioButton();
            this.gbx3 = new System.Windows.Forms.GroupBox();
            this.rdbKleiner = new System.Windows.Forms.RadioButton();
            this.lblKleiner = new System.Windows.Forms.Label();
            this.txtEinde = new System.Windows.Forms.TextBox();
            this.lblEindwaarde = new System.Windows.Forms.Label();
            this.lblGroter = new System.Windows.Forms.Label();
            this.rdbGroter = new System.Windows.Forms.RadioButton();
            this.gbx4 = new System.Windows.Forms.GroupBox();
            this.rdbMin = new System.Windows.Forms.RadioButton();
            this.txtStap = new System.Windows.Forms.TextBox();
            this.lblStapgrootte = new System.Windows.Forms.Label();
            this.lblRekenkundig = new System.Windows.Forms.Label();
            this.rdbPlus = new System.Windows.Forms.RadioButton();
            this.btnAdvies = new System.Windows.Forms.Button();
            this.lbxAdvies = new System.Windows.Forms.ListBox();
            this.gbx1.SuspendLayout();
            this.gbx2.SuspendLayout();
            this.gbx3.SuspendLayout();
            this.gbx4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx1
            // 
            this.gbx1.BackColor = System.Drawing.Color.Transparent;
            this.gbx1.Controls.Add(this.rdbWhile);
            this.gbx1.Controls.Add(this.rdbFor);
            this.gbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.gbx1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbx1.Location = new System.Drawing.Point(12, 3);
            this.gbx1.Name = "gbx1";
            this.gbx1.Size = new System.Drawing.Size(292, 78);
            this.gbx1.TabIndex = 0;
            this.gbx1.TabStop = false;
            this.gbx1.Text = "1. Keuze for of while lus";
            // 
            // rdbWhile
            // 
            this.rdbWhile.AutoSize = true;
            this.rdbWhile.Location = new System.Drawing.Point(109, 45);
            this.rdbWhile.Name = "rdbWhile";
            this.rdbWhile.Size = new System.Drawing.Size(78, 24);
            this.rdbWhile.TabIndex = 1;
            this.rdbWhile.TabStop = true;
            this.rdbWhile.Text = "While";
            this.rdbWhile.UseVisualStyleBackColor = true;
            // 
            // rdbFor
            // 
            this.rdbFor.AutoSize = true;
            this.rdbFor.Location = new System.Drawing.Point(20, 45);
            this.rdbFor.Name = "rdbFor";
            this.rdbFor.Size = new System.Drawing.Size(61, 24);
            this.rdbFor.TabIndex = 0;
            this.rdbFor.TabStop = true;
            this.rdbFor.Text = "For";
            this.rdbFor.UseVisualStyleBackColor = true;
            // 
            // gbx2
            // 
            this.gbx2.BackColor = System.Drawing.Color.Transparent;
            this.gbx2.Controls.Add(this.txtBegin);
            this.gbx2.Controls.Add(this.lblBeginWaarde);
            this.gbx2.Controls.Add(this.lblGelijkAan);
            this.gbx2.Controls.Add(this.rdbGelijkAan);
            this.gbx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbx2.Location = new System.Drawing.Point(12, 87);
            this.gbx2.Name = "gbx2";
            this.gbx2.Size = new System.Drawing.Size(292, 125);
            this.gbx2.TabIndex = 1;
            this.gbx2.TabStop = false;
            this.gbx2.Text = "2. Beginwaarde bepalen";
            // 
            // txtBegin
            // 
            this.txtBegin.Location = new System.Drawing.Point(203, 86);
            this.txtBegin.Multiline = true;
            this.txtBegin.Name = "txtBegin";
            this.txtBegin.Size = new System.Drawing.Size(80, 26);
            this.txtBegin.TabIndex = 5;
            // 
            // lblBeginWaarde
            // 
            this.lblBeginWaarde.AutoSize = true;
            this.lblBeginWaarde.Location = new System.Drawing.Point(6, 89);
            this.lblBeginWaarde.Name = "lblBeginWaarde";
            this.lblBeginWaarde.Size = new System.Drawing.Size(191, 20);
            this.lblBeginWaarde.TabIndex = 4;
            this.lblBeginWaarde.Text = "Geef beginwaarde aan";
            // 
            // lblGelijkAan
            // 
            this.lblGelijkAan.AutoSize = true;
            this.lblGelijkAan.Location = new System.Drawing.Point(16, 46);
            this.lblGelijkAan.Name = "lblGelijkAan";
            this.lblGelijkAan.Size = new System.Drawing.Size(89, 20);
            this.lblGelijkAan.TabIndex = 3;
            this.lblGelijkAan.Text = "Gelijk aan";
            // 
            // rdbGelijkAan
            // 
            this.rdbGelijkAan.AutoSize = true;
            this.rdbGelijkAan.Location = new System.Drawing.Point(118, 46);
            this.rdbGelijkAan.Name = "rdbGelijkAan";
            this.rdbGelijkAan.Size = new System.Drawing.Size(44, 24);
            this.rdbGelijkAan.TabIndex = 2;
            this.rdbGelijkAan.TabStop = true;
            this.rdbGelijkAan.Text = "=";
            this.rdbGelijkAan.UseVisualStyleBackColor = true;
            // 
            // gbx3
            // 
            this.gbx3.BackColor = System.Drawing.Color.Transparent;
            this.gbx3.Controls.Add(this.rdbKleiner);
            this.gbx3.Controls.Add(this.lblKleiner);
            this.gbx3.Controls.Add(this.txtEinde);
            this.gbx3.Controls.Add(this.lblEindwaarde);
            this.gbx3.Controls.Add(this.lblGroter);
            this.gbx3.Controls.Add(this.rdbGroter);
            this.gbx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.gbx3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbx3.Location = new System.Drawing.Point(12, 218);
            this.gbx3.Name = "gbx3";
            this.gbx3.Size = new System.Drawing.Size(292, 142);
            this.gbx3.TabIndex = 2;
            this.gbx3.TabStop = false;
            this.gbx3.Text = "3. Eindwaarde bepalen";
            // 
            // rdbKleiner
            // 
            this.rdbKleiner.AutoSize = true;
            this.rdbKleiner.Location = new System.Drawing.Point(118, 69);
            this.rdbKleiner.Name = "rdbKleiner";
            this.rdbKleiner.Size = new System.Drawing.Size(44, 24);
            this.rdbKleiner.TabIndex = 7;
            this.rdbKleiner.TabStop = true;
            this.rdbKleiner.Text = "<";
            this.rdbKleiner.UseVisualStyleBackColor = true;
            // 
            // lblKleiner
            // 
            this.lblKleiner.AutoSize = true;
            this.lblKleiner.Location = new System.Drawing.Point(16, 69);
            this.lblKleiner.Name = "lblKleiner";
            this.lblKleiner.Size = new System.Drawing.Size(99, 20);
            this.lblKleiner.TabIndex = 6;
            this.lblKleiner.Text = "Kleiner dan";
            // 
            // txtEinde
            // 
            this.txtEinde.Location = new System.Drawing.Point(183, 102);
            this.txtEinde.Multiline = true;
            this.txtEinde.Name = "txtEinde";
            this.txtEinde.Size = new System.Drawing.Size(100, 26);
            this.txtEinde.TabIndex = 5;
            // 
            // lblEindwaarde
            // 
            this.lblEindwaarde.AutoSize = true;
            this.lblEindwaarde.Location = new System.Drawing.Point(6, 105);
            this.lblEindwaarde.Name = "lblEindwaarde";
            this.lblEindwaarde.Size = new System.Drawing.Size(181, 20);
            this.lblEindwaarde.TabIndex = 4;
            this.lblEindwaarde.Text = "Geef eindwaarde aan";
            // 
            // lblGroter
            // 
            this.lblGroter.AutoSize = true;
            this.lblGroter.Location = new System.Drawing.Point(16, 33);
            this.lblGroter.Name = "lblGroter";
            this.lblGroter.Size = new System.Drawing.Size(96, 20);
            this.lblGroter.TabIndex = 3;
            this.lblGroter.Text = "Groter dan";
            // 
            // rdbGroter
            // 
            this.rdbGroter.AutoSize = true;
            this.rdbGroter.Location = new System.Drawing.Point(118, 33);
            this.rdbGroter.Name = "rdbGroter";
            this.rdbGroter.Size = new System.Drawing.Size(44, 24);
            this.rdbGroter.TabIndex = 2;
            this.rdbGroter.TabStop = true;
            this.rdbGroter.Text = ">";
            this.rdbGroter.UseVisualStyleBackColor = true;
            // 
            // gbx4
            // 
            this.gbx4.BackColor = System.Drawing.Color.Transparent;
            this.gbx4.Controls.Add(this.rdbMin);
            this.gbx4.Controls.Add(this.txtStap);
            this.gbx4.Controls.Add(this.lblStapgrootte);
            this.gbx4.Controls.Add(this.lblRekenkundig);
            this.gbx4.Controls.Add(this.rdbPlus);
            this.gbx4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.gbx4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbx4.Location = new System.Drawing.Point(12, 366);
            this.gbx4.Name = "gbx4";
            this.gbx4.Size = new System.Drawing.Size(292, 109);
            this.gbx4.TabIndex = 3;
            this.gbx4.TabStop = false;
            this.gbx4.Text = "4.Stapgrotte bepalen";
            // 
            // rdbMin
            // 
            this.rdbMin.AutoSize = true;
            this.rdbMin.Location = new System.Drawing.Point(183, 34);
            this.rdbMin.Name = "rdbMin";
            this.rdbMin.Size = new System.Drawing.Size(40, 24);
            this.rdbMin.TabIndex = 6;
            this.rdbMin.TabStop = true;
            this.rdbMin.Text = "-";
            this.rdbMin.UseVisualStyleBackColor = true;
            // 
            // txtStap
            // 
            this.txtStap.Location = new System.Drawing.Point(183, 80);
            this.txtStap.Multiline = true;
            this.txtStap.Name = "txtStap";
            this.txtStap.Size = new System.Drawing.Size(100, 26);
            this.txtStap.TabIndex = 5;
            // 
            // lblStapgrootte
            // 
            this.lblStapgrootte.AutoSize = true;
            this.lblStapgrootte.Location = new System.Drawing.Point(17, 80);
            this.lblStapgrootte.Name = "lblStapgrootte";
            this.lblStapgrootte.Size = new System.Drawing.Size(147, 20);
            this.lblStapgrootte.TabIndex = 4;
            this.lblStapgrootte.Text = "Geef stapgrootte";
            // 
            // lblRekenkundig
            // 
            this.lblRekenkundig.AutoSize = true;
            this.lblRekenkundig.Location = new System.Drawing.Point(17, 36);
            this.lblRekenkundig.Name = "lblRekenkundig";
            this.lblRekenkundig.Size = new System.Drawing.Size(107, 20);
            this.lblRekenkundig.TabIndex = 3;
            this.lblRekenkundig.Text = "rekenkundig";
            // 
            // rdbPlus
            // 
            this.rdbPlus.AutoSize = true;
            this.rdbPlus.Location = new System.Drawing.Point(127, 34);
            this.rdbPlus.Name = "rdbPlus";
            this.rdbPlus.Size = new System.Drawing.Size(44, 24);
            this.rdbPlus.TabIndex = 2;
            this.rdbPlus.TabStop = true;
            this.rdbPlus.Text = "+";
            this.rdbPlus.UseVisualStyleBackColor = true;
            // 
            // btnAdvies
            // 
            this.btnAdvies.Location = new System.Drawing.Point(344, 26);
            this.btnAdvies.Name = "btnAdvies";
            this.btnAdvies.Size = new System.Drawing.Size(408, 55);
            this.btnAdvies.TabIndex = 4;
            this.btnAdvies.Text = "Geef advies";
            this.btnAdvies.UseVisualStyleBackColor = true;
            this.btnAdvies.Click += new System.EventHandler(this.btnAdvies_Click);
            // 
            // lbxAdvies
            // 
            this.lbxAdvies.FormattingEnabled = true;
            this.lbxAdvies.ItemHeight = 20;
            this.lbxAdvies.Location = new System.Drawing.Point(344, 102);
            this.lbxAdvies.Name = "lbxAdvies";
            this.lbxAdvies.Size = new System.Drawing.Size(408, 364);
            this.lbxAdvies.TabIndex = 5;
            // 
            // frmEinde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(801, 482);
            this.Controls.Add(this.lbxAdvies);
            this.Controls.Add(this.btnAdvies);
            this.Controls.Add(this.gbx4);
            this.Controls.Add(this.gbx3);
            this.Controls.Add(this.gbx2);
            this.Controls.Add(this.gbx1);
            this.Name = "frmEinde";
            this.Text = "programmeertool project";
            this.gbx1.ResumeLayout(false);
            this.gbx1.PerformLayout();
            this.gbx2.ResumeLayout(false);
            this.gbx2.PerformLayout();
            this.gbx3.ResumeLayout(false);
            this.gbx3.PerformLayout();
            this.gbx4.ResumeLayout(false);
            this.gbx4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx1;
        private System.Windows.Forms.RadioButton rdbWhile;
        private System.Windows.Forms.RadioButton rdbFor;
        private System.Windows.Forms.GroupBox gbx2;
        private System.Windows.Forms.TextBox txtBegin;
        private System.Windows.Forms.Label lblBeginWaarde;
        private System.Windows.Forms.Label lblGelijkAan;
        private System.Windows.Forms.RadioButton rdbGelijkAan;
        private System.Windows.Forms.GroupBox gbx3;
        private System.Windows.Forms.RadioButton rdbKleiner;
        private System.Windows.Forms.Label lblKleiner;
        private System.Windows.Forms.TextBox txtEinde;
        private System.Windows.Forms.Label lblEindwaarde;
        private System.Windows.Forms.Label lblGroter;
        private System.Windows.Forms.RadioButton rdbGroter;
        private System.Windows.Forms.GroupBox gbx4;
        private System.Windows.Forms.RadioButton rdbMin;
        private System.Windows.Forms.TextBox txtStap;
        private System.Windows.Forms.Label lblStapgrootte;
        private System.Windows.Forms.Label lblRekenkundig;
        private System.Windows.Forms.RadioButton rdbPlus;
        private System.Windows.Forms.Button btnAdvies;
        private System.Windows.Forms.ListBox lbxAdvies;
    }
}

