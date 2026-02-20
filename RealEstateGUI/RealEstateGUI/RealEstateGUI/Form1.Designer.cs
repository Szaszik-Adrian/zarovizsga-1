namespace RealEstateGUI
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
            this.lbSellers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSellerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSellerPhone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAdsCount = new System.Windows.Forms.Label();
            this.btnLoadAds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSellers
            // 
            this.lbSellers.FormattingEnabled = true;
            this.lbSellers.Location = new System.Drawing.Point(11, 11);
            this.lbSellers.Name = "lbSellers";
            this.lbSellers.Size = new System.Drawing.Size(281, 355);
            this.lbSellers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eladó neve:";
            // 
            // lblSellerName
            // 
            this.lblSellerName.AutoSize = true;
            this.lblSellerName.Location = new System.Drawing.Point(546, 124);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(0, 13);
            this.lblSellerName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eladó telefonszáma:";
            // 
            // lblSellerPhone
            // 
            this.lblSellerPhone.AutoSize = true;
            this.lblSellerPhone.Location = new System.Drawing.Point(554, 284);
            this.lblSellerPhone.Name = "lblSellerPhone";
            this.lblSellerPhone.Size = new System.Drawing.Size(0, 13);
            this.lblSellerPhone.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hirdetések száma:";
            // 
            // lblAdsCount
            // 
            this.lblAdsCount.AutoSize = true;
            this.lblAdsCount.Location = new System.Drawing.Point(496, 159);
            this.lblAdsCount.Name = "lblAdsCount";
            this.lblAdsCount.Size = new System.Drawing.Size(13, 13);
            this.lblAdsCount.TabIndex = 6;
            this.lblAdsCount.Text = "0";
            // 
            // btnLoadAds
            // 
            this.btnLoadAds.Location = new System.Drawing.Point(430, 97);
            this.btnLoadAds.Name = "btnLoadAds";
            this.btnLoadAds.Size = new System.Drawing.Size(187, 24);
            this.btnLoadAds.TabIndex = 7;
            this.btnLoadAds.Text = "Hirdetések betöltése";
            this.btnLoadAds.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadAds);
            this.Controls.Add(this.lblAdsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSellerPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSellerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSellers);
            this.Name = "Form1";
            this.Text = "ingatlanok";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSellers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSellerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSellerPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAdsCount;
        private System.Windows.Forms.Button btnLoadAds;
    }
}

