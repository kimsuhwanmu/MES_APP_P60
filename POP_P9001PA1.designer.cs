namespace MES_APP_P90
{
    partial class POP_P9001PA1
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
            this.windowsForm1 = new TGSControl.WindowsForm();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.opn_ITEM_CD = new TGSControl.TOpenPopup();
            this.tLabel1 = new TGSControl.TLabel();
            this.SuspendLayout();
            // 
            // windowsForm1
            // 
            this.windowsForm1.BorderColor = System.Drawing.Color.DarkOrange;
            this.windowsForm1.Caption = "작업표준서";
            this.windowsForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowsForm1.Location = new System.Drawing.Point(0, 0);
            this.windowsForm1.Margin = new System.Windows.Forms.Padding(0);
            this.windowsForm1.Name = "windowsForm1";
            this.windowsForm1.Size = new System.Drawing.Size(1001, 700);
            this.windowsForm1.TabIndex = 4;
            this.windowsForm1.CloseClick += new System.EventHandler(this.windowsForm1_CloseClick);
            this.windowsForm1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.windowsForm1_MouseDoubleClick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(6, 51);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(988, 643);
            this.webBrowser1.TabIndex = 5;
            // 
            // opn_ITEM_CD
            // 
            this.opn_ITEM_CD.BackColor = System.Drawing.SystemColors.Window;
            this.opn_ITEM_CD.BorderBackColor = System.Drawing.SystemColors.Window;
            this.opn_ITEM_CD.BorderBottom = true;
            this.opn_ITEM_CD.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.opn_ITEM_CD.BorderLeft = true;
            this.opn_ITEM_CD.BorderNameBackColor = System.Drawing.SystemColors.Window;
            this.opn_ITEM_CD.BorderRight = true;
            this.opn_ITEM_CD.BorderTop = true;
            this.opn_ITEM_CD.Caption = "";
            this.opn_ITEM_CD.DefaultPopup = "";
            this.opn_ITEM_CD.FontSize = 14.25F;
            this.opn_ITEM_CD.FontStyle = System.Drawing.FontStyle.Regular;
            this.opn_ITEM_CD.Location = new System.Drawing.Point(349, 11);
            this.opn_ITEM_CD.Name = "opn_ITEM_CD";
            this.opn_ITEM_CD.Size = new System.Drawing.Size(462, 33);
            this.opn_ITEM_CD.TabIndex = 6;
            this.opn_ITEM_CD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.opn_ITEM_CD.TextColor = System.Drawing.SystemColors.ControlText;
            this.opn_ITEM_CD.TextNameColor = System.Drawing.SystemColors.ControlText;
            this.opn_ITEM_CD.Value = "";
            this.opn_ITEM_CD.ValueName = "";
            this.opn_ITEM_CD.ValueName_Visuble = true;
            this.opn_ITEM_CD.OpenPopup += new System.EventHandler(this.opn_ITEM_CD_OpenPopup);
            // 
            // tLabel1
            // 
            this.tLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.tLabel1.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.tLabel1.BorderBottom = true;
            this.tLabel1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tLabel1.BorderLeft = true;
            this.tLabel1.BorderRight = true;
            this.tLabel1.BorderTop = true;
            this.tLabel1.Caption = "품번";
            this.tLabel1.FontSize = 14.25F;
            this.tLabel1.FontStyle = System.Drawing.FontStyle.Regular;
            this.tLabel1.Location = new System.Drawing.Point(244, 11);
            this.tLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.tLabel1.Name = "tLabel1";
            this.tLabel1.Size = new System.Drawing.Size(100, 31);
            this.tLabel1.TabIndex = 7;
            this.tLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tLabel1.Value = "품번";
            // 
            // POP_P1005P1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 700);
            this.Controls.Add(this.tLabel1);
            this.Controls.Add(this.opn_ITEM_CD);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.windowsForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POP_P1005P1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "POP_P1005P1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.POP_P1005P1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private TGSControl.WindowsForm windowsForm1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private TGSControl.TOpenPopup opn_ITEM_CD;
        private TGSControl.TLabel tLabel1;
    }
}