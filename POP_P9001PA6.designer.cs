namespace MES_APP_P90
{
    partial class POP_P9001PA6
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
            this.opn_PRODT_ORDER_NO = new TGSControl.TOpenPopup();
            this.tLabel1 = new TGSControl.TLabel();
            this.SuspendLayout();
            // 
            // windowsForm1
            // 
            this.windowsForm1.BorderColor = System.Drawing.Color.DarkOrange;
            this.windowsForm1.BorderWidth = 5;
            this.windowsForm1.Caption = "작업지시서";
            this.windowsForm1.Close_Visible = true;
            this.windowsForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowsForm1.Font = new System.Drawing.Font("맑은 고딕", 22F, System.Drawing.FontStyle.Bold);
            this.windowsForm1.ForeColor = System.Drawing.Color.White;
            this.windowsForm1.Location = new System.Drawing.Point(0, 0);
            this.windowsForm1.Margin = new System.Windows.Forms.Padding(0);
            this.windowsForm1.Name = "windowsForm1";
            this.windowsForm1.Size = new System.Drawing.Size(1001, 700);
            this.windowsForm1.TabIndex = 4;
            this.windowsForm1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.windowsForm1.Title_Height = 50;
            this.windowsForm1.Title_Icon = null;
            this.windowsForm1.Title_Visible = true;
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
            // opn_PRODT_ORDER_NO
            // 
            this.opn_PRODT_ORDER_NO.BackColor = System.Drawing.SystemColors.Window;
            this.opn_PRODT_ORDER_NO.BorderBackColor = System.Drawing.SystemColors.Window;
            this.opn_PRODT_ORDER_NO.BorderBottom = true;
            this.opn_PRODT_ORDER_NO.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.opn_PRODT_ORDER_NO.BorderLeft = true;
            this.opn_PRODT_ORDER_NO.BorderNameBackColor = System.Drawing.SystemColors.Window;
            this.opn_PRODT_ORDER_NO.BorderRight = true;
            this.opn_PRODT_ORDER_NO.BorderTop = true;
            this.opn_PRODT_ORDER_NO.Caption = "";
            this.opn_PRODT_ORDER_NO.CommonCD = "";
            this.opn_PRODT_ORDER_NO.DefaultPopup = "";
            this.opn_PRODT_ORDER_NO.FontSize = 13F;
            this.opn_PRODT_ORDER_NO.FontStyle = System.Drawing.FontStyle.Regular;
            this.opn_PRODT_ORDER_NO.Location = new System.Drawing.Point(349, 11);
            this.opn_PRODT_ORDER_NO.Name = "opn_PRODT_ORDER_NO";
            this.opn_PRODT_ORDER_NO.PasswordChar = '\0';
            this.opn_PRODT_ORDER_NO.ReadOnly = false;
            this.opn_PRODT_ORDER_NO.Required = false;
            this.opn_PRODT_ORDER_NO.SelectedText = "";
            this.opn_PRODT_ORDER_NO.SelectionLength = 0;
            this.opn_PRODT_ORDER_NO.SelectionStart = 0;
            this.opn_PRODT_ORDER_NO.Size = new System.Drawing.Size(462, 33);
            this.opn_PRODT_ORDER_NO.TabIndex = 6;
            this.opn_PRODT_ORDER_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.opn_PRODT_ORDER_NO.TextColor = System.Drawing.SystemColors.ControlText;
            this.opn_PRODT_ORDER_NO.TextNameColor = System.Drawing.SystemColors.ControlText;
            this.opn_PRODT_ORDER_NO.TScale = 1F;
            this.opn_PRODT_ORDER_NO.Value = "";
            this.opn_PRODT_ORDER_NO.Value_Visible = true;
            this.opn_PRODT_ORDER_NO.ValueName = "";
            this.opn_PRODT_ORDER_NO.ValueName_Visible = true;
            this.opn_PRODT_ORDER_NO.ValueName_Visuble = true;
            this.opn_PRODT_ORDER_NO.Visible = false;
            this.opn_PRODT_ORDER_NO.OpenPopup += new System.EventHandler(this.opn_ITEM_CD_OpenPopup);
            // 
            // tLabel1
            // 
            this.tLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.tLabel1.Base_FontSize = 13F;
            this.tLabel1.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.tLabel1.BorderBottom = true;
            this.tLabel1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tLabel1.BorderLeft = true;
            this.tLabel1.BorderRight = true;
            this.tLabel1.BorderTop = true;
            this.tLabel1.Caption = "제조오더번호";
            this.tLabel1.FontSize = 13F;
            this.tLabel1.FontStyle = System.Drawing.FontStyle.Regular;
            this.tLabel1.Location = new System.Drawing.Point(244, 11);
            this.tLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.tLabel1.Name = "tLabel1";
            this.tLabel1.Size = new System.Drawing.Size(100, 31);
            this.tLabel1.TabIndex = 7;
            this.tLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tLabel1.TScale = 1F;
            this.tLabel1.Value = "제조오더번호";
            this.tLabel1.Visible = false;
            // 
            // POP_P9001PA6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 700);
            this.Controls.Add(this.tLabel1);
            this.Controls.Add(this.opn_PRODT_ORDER_NO);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.windowsForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POP_P9001PA6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "POP_P1005P1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.POP_P1005P1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private TGSControl.WindowsForm windowsForm1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private TGSControl.TOpenPopup opn_PRODT_ORDER_NO;
        private TGSControl.TLabel tLabel1;
    }
}