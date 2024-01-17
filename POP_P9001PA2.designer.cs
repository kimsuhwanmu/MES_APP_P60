namespace MES_APP_P90
{
    partial class POP_P9001PA2
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
            this.apP_P9001MA21 = new MES_APP_P90.APP_P9001MA2();
            this.SuspendLayout();
            // 
            // windowsForm1
            // 
            this.windowsForm1.BorderColor = System.Drawing.Color.DarkOrange;
            this.windowsForm1.BorderWidth = 5;
            this.windowsForm1.Caption = "설비일상점검";
            this.windowsForm1.Close_Visible = true;
            this.windowsForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowsForm1.Font = new System.Drawing.Font("맑은 고딕", 22F, System.Drawing.FontStyle.Bold);
            this.windowsForm1.ForeColor = System.Drawing.Color.White;
            this.windowsForm1.Location = new System.Drawing.Point(0, 0);
            this.windowsForm1.Margin = new System.Windows.Forms.Padding(0);
            this.windowsForm1.Name = "windowsForm1";
            this.windowsForm1.Size = new System.Drawing.Size(1001, 700);
            this.windowsForm1.TabIndex = 5;
            this.windowsForm1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.windowsForm1.Title_Height = 50;
            this.windowsForm1.Title_Icon = null;
            this.windowsForm1.Title_Visible = true;
            this.windowsForm1.CloseClick += new System.EventHandler(this.windowsForm1_CloseClick);
            // 
            // apP_P9001MA21
            // 
            this.apP_P9001MA21.Location = new System.Drawing.Point(6, 52);
            this.apP_P9001MA21.MainForm = null;
            this.apP_P9001MA21.Name = "apP_P9001MA21";
            this.apP_P9001MA21.PROGRAM_ID = "MES_APP_P90.APP_P9001MA2";
            this.apP_P9001MA21.Size = new System.Drawing.Size(988, 644);
            this.apP_P9001MA21.TabIndex = 6;
            this.apP_P9001MA21.CommandRuned += new TGSClass.CommandRunEventHandler(this.apP_P9001MA21_CommandRuned);
            // 
            // POP_P9001PA2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 700);
            this.Controls.Add(this.apP_P9001MA21);
            this.Controls.Add(this.windowsForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POP_P9001PA2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "POP_P9001PA2";
            this.Activated += new System.EventHandler(this.POP_P9001PA2_Activated);
            this.Deactivate += new System.EventHandler(this.POP_P9001PA2_Deactivate);
            this.Load += new System.EventHandler(this.Form_Load);
            this.Resize += new System.EventHandler(this.POP_P9001PA2_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private TGSControl.WindowsForm windowsForm1;
        private APP_P9001MA2 apP_P9001MA21;
    }
}