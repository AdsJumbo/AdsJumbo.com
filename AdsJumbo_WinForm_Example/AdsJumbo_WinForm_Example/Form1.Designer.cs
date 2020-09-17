namespace AdsJumbo_WinForm_Example
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
            this.bannerAds1 = new AdsJumboWinForm.BannerAds();
            this.bannerAds2 = new AdsJumboWinForm.BannerAds();
            this.bannerAds3 = new AdsJumboWinForm.BannerAds();
            this.interstitialAd1 = new AdsJumboWinForm.InterstitialAd();
            this.SuspendLayout();
            // 
            // bannerAds1
            // 
            this.bannerAds1.ApplicationId = null;
            this.bannerAds1.BackColor = System.Drawing.Color.White;
            this.bannerAds1.HeightAd = 0;
            this.bannerAds1.Location = new System.Drawing.Point(30, 13);
            this.bannerAds1.Margin = new System.Windows.Forms.Padding(4);
            this.bannerAds1.Name = "bannerAds1";
            this.bannerAds1.Size = new System.Drawing.Size(728, 90);
            this.bannerAds1.TabIndex = 0;
            this.bannerAds1.WidthAd = 0;
            // 
            // bannerAds2
            // 
            this.bannerAds2.ApplicationId = null;
            this.bannerAds2.BackColor = System.Drawing.Color.White;
            this.bannerAds2.HeightAd = 0;
            this.bannerAds2.Location = new System.Drawing.Point(30, 124);
            this.bannerAds2.Margin = new System.Windows.Forms.Padding(4);
            this.bannerAds2.Name = "bannerAds2";
            this.bannerAds2.Size = new System.Drawing.Size(160, 600);
            this.bannerAds2.TabIndex = 1;
            this.bannerAds2.WidthAd = 0;
            // 
            // bannerAds3
            // 
            this.bannerAds3.ApplicationId = null;
            this.bannerAds3.BackColor = System.Drawing.Color.White;
            this.bannerAds3.HeightAd = 0;
            this.bannerAds3.Location = new System.Drawing.Point(353, 124);
            this.bannerAds3.Margin = new System.Windows.Forms.Padding(4);
            this.bannerAds3.Name = "bannerAds3";
            this.bannerAds3.Size = new System.Drawing.Size(300, 250);
            this.bannerAds3.TabIndex = 2;
            this.bannerAds3.WidthAd = 0;
            // 
            // interstitialAd1
            // 
            this.interstitialAd1.ApplicationId = null;
            this.interstitialAd1.BackColor = System.Drawing.Color.Black;
            this.interstitialAd1.Location = new System.Drawing.Point(1020, 12);
            this.interstitialAd1.Name = "interstitialAd1";
            this.interstitialAd1.Size = new System.Drawing.Size(50, 50);
            this.interstitialAd1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1082, 743);
            this.Controls.Add(this.interstitialAd1);
            this.Controls.Add(this.bannerAds3);
            this.Controls.Add(this.bannerAds2);
            this.Controls.Add(this.bannerAds1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private AdsJumboWinForm.BannerAds bannerAds1;
        private AdsJumboWinForm.BannerAds bannerAds2;
        private AdsJumboWinForm.BannerAds bannerAds3;
        private AdsJumboWinForm.InterstitialAd interstitialAd1;
    }
}

