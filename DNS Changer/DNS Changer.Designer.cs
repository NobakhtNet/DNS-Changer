namespace DNS_Changer
{
    partial class DNS_Changer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DNS_Changer));
            this.lblText = new System.Windows.Forms.Label();
            this.panel = new CustomPanel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblAlt = new System.Windows.Forms.Label();
            this.boxIP2 = new CustomControls.RJControls.CustomTextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.boxIP1 = new CustomControls.RJControls.CustomTextBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("Century Gothic", 18.25F, System.Drawing.FontStyle.Bold);
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(35, 0);
            this.lblText.Margin = new System.Windows.Forms.Padding(0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(284, 45);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "DNS Changer";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.panel.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.panel.BorderRadius = 15;
            this.panel.BorderSize = 1;
            this.panel.Controls.Add(this.btnStop);
            this.panel.Controls.Add(this.btnConnect);
            this.panel.Controls.Add(this.lblAlt);
            this.panel.Controls.Add(this.boxIP2);
            this.panel.Controls.Add(this.lblIP);
            this.panel.Controls.Add(this.lblStatus);
            this.panel.Controls.Add(this.lblPre);
            this.panel.Controls.Add(this.boxIP1);
            this.panel.Location = new System.Drawing.Point(35, 45);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(304, 421);
            this.panel.TabIndex = 3;
            this.panel.UnderlinedStyle = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(86)))), ((int)(((byte)(91)))));
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(161, 346);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(115, 42);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(32, 346);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(0);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(117, 42);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblAlt
            // 
            this.lblAlt.AutoSize = true;
            this.lblAlt.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.lblAlt.Location = new System.Drawing.Point(28, 206);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(182, 21);
            this.lblAlt.TabIndex = 1;
            this.lblAlt.Text = "Alternate DNS Server :";
            // 
            // boxIP2
            // 
            this.boxIP2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.boxIP2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(108)))), ((int)(((byte)(188)))));
            this.boxIP2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(201)))), ((int)(((byte)(136)))));
            this.boxIP2.BorderRadius = 10;
            this.boxIP2.BorderSize = 1;
            this.boxIP2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxIP2.ForeColor = System.Drawing.Color.White;
            this.boxIP2.Location = new System.Drawing.Point(28, 232);
            this.boxIP2.Margin = new System.Windows.Forms.Padding(4);
            this.boxIP2.Multiline = false;
            this.boxIP2.Name = "boxIP2";
            this.boxIP2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.boxIP2.PasswordChar = false;
            this.boxIP2.PlaceholderColor = System.Drawing.Color.Gray;
            this.boxIP2.PlaceholderText = "Example: 1.0.0.1";
            this.boxIP2.Size = new System.Drawing.Size(248, 38);
            this.boxIP2.TabIndex = 0;
            this.boxIP2.Texts = "";
            this.boxIP2.UnderlinedStyle = false;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblIP.Location = new System.Drawing.Point(148, 64);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(0, 20);
            this.lblIP.TabIndex = 1;
            this.lblIP.Click += new System.EventHandler(this.lblIP_Click);
            this.lblIP.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.lblIP.MouseHover += new System.EventHandler(this.lblIP_MouseHover);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblStatus.Location = new System.Drawing.Point(3, 17);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(308, 56);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Not Set";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.lblPre.Location = new System.Drawing.Point(28, 113);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(176, 21);
            this.lblPre.TabIndex = 1;
            this.lblPre.Text = "Preferred DNS Server :";
            // 
            // boxIP1
            // 
            this.boxIP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.boxIP1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(108)))), ((int)(((byte)(188)))));
            this.boxIP1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(201)))), ((int)(((byte)(136)))));
            this.boxIP1.BorderRadius = 10;
            this.boxIP1.BorderSize = 1;
            this.boxIP1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxIP1.ForeColor = System.Drawing.Color.White;
            this.boxIP1.Location = new System.Drawing.Point(28, 139);
            this.boxIP1.Margin = new System.Windows.Forms.Padding(4);
            this.boxIP1.Multiline = false;
            this.boxIP1.Name = "boxIP1";
            this.boxIP1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.boxIP1.PasswordChar = false;
            this.boxIP1.PlaceholderColor = System.Drawing.Color.Gray;
            this.boxIP1.PlaceholderText = "Example: 1.1.1.1";
            this.boxIP1.Size = new System.Drawing.Size(248, 38);
            this.boxIP1.TabIndex = 0;
            this.boxIP1.Texts = "";
            this.boxIP1.UnderlinedStyle = false;
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(83)))), ((int)(((byte)(112)))));
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(261, 5);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(35, 35);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // DNS_Changer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(374, 501);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblText);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DNS_Changer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DNS Changer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DNS_Changer_FormClosing);
            this.Load += new System.EventHandler(this.DNS_Changer_Load);
            this.Shown += new System.EventHandler(this.DNS_Changer_Shown);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private CustomControls.RJControls.CustomTextBox boxIP1;
        private System.Windows.Forms.Label lblAlt;
        private CustomControls.RJControls.CustomTextBox boxIP2;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnConnect;
        private CustomPanel panel;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Button btnInfo;
    }
}