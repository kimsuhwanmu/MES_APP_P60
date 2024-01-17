namespace MES_APP_P90
{
    partial class POP_P9001PA3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POP_P9001PA3));
            this.windowsForm1 = new TGSControl.WindowsForm();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tButton1 = new TGSControl.TButton();
            this.lbl_OP_NM = new TGSControl.TLabel();
            this.cboWorker = new TGSControl.TCombo();
            this.tLabel5 = new TGSControl.TLabel();
            this.tLabel2 = new TGSControl.TLabel();
            this.lbl_OP_GRP_NM = new TGSControl.TLabel();
            this.tLabel1 = new TGSControl.TLabel();
            this.tLabel4 = new TGSControl.TLabel();
            this.tLabel6 = new TGSControl.TLabel();
            this.tDateTime1 = new TGSControl.TDateTime();
            this.tDateTime2 = new TGSControl.TDateTime();
            this.opt_Start_DT1 = new TGSControl.TRadioButton();
            this.opt_Start_DT2 = new TGSControl.TRadioButton();
            this.opt_Start_DT3 = new TGSControl.TRadioButton();
            this.Panel_Cmd = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Close = new TGSControl.TButton();
            this.btn_Start = new TGSControl.TButton();
            this.chkSendMessage = new TGSControl.TCheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Panel_Cmd.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowsForm1
            // 
            this.windowsForm1.BorderColor = System.Drawing.Color.DarkOrange;
            this.windowsForm1.BorderWidth = 5;
            this.windowsForm1.Caption = "비가동 시작";
            this.windowsForm1.Close_Visible = true;
            this.windowsForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowsForm1.Font = new System.Drawing.Font("맑은 고딕", 22F, System.Drawing.FontStyle.Bold);
            this.windowsForm1.ForeColor = System.Drawing.Color.White;
            this.windowsForm1.Location = new System.Drawing.Point(0, 0);
            this.windowsForm1.Margin = new System.Windows.Forms.Padding(0);
            this.windowsForm1.Name = "windowsForm1";
            this.windowsForm1.Size = new System.Drawing.Size(781, 471);
            this.windowsForm1.TabIndex = 55;
            this.windowsForm1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.windowsForm1.Title_Height = 50;
            this.windowsForm1.Title_Icon = null;
            this.windowsForm1.Title_Visible = true;
            this.windowsForm1.CloseClick += new System.EventHandler(this.windowsForm1_CloseClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Panel_Cmd, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(768, 414);
            this.tableLayoutPanel1.TabIndex = 56;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.Controls.Add(this.tButton1, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_OP_NM, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cboWorker, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tLabel5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tLabel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_OP_GRP_NM, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tLabel1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tLabel4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tLabel6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.tDateTime1, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.tDateTime2, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.opt_Start_DT1, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.opt_Start_DT2, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.opt_Start_DT3, 4, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.001F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.001F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.999F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.999F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(762, 280);
            this.tableLayoutPanel2.TabIndex = 54;
            // 
            // tButton1
            // 
            this.tButton1.BackColor = System.Drawing.SystemColors.Control;
            this.tButton1.BorderBackColor = System.Drawing.SystemColors.Control;
            this.tButton1.BorderBottom = true;
            this.tButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.tButton1.BorderLeft = true;
            this.tButton1.BorderRight = true;
            this.tButton1.BorderTop = true;
            this.tButton1.BorderWidth = 0;
            this.tButton1.ButtonSelected = false;
            this.tButton1.Caption = "사유 변경";
            this.tButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tButton1.Font = new System.Drawing.Font("맑은 고딕", 14.25F);
            this.tButton1.FontSize = 14.25F;
            this.tButton1.FontStyle = System.Drawing.FontStyle.Regular;
            this.tButton1.ForeColor = System.Drawing.Color.Blue;
            this.tButton1.IConImage1 = null;
            this.tButton1.IConImage2 = null;
            this.tButton1.IConViewFlag = false;
            this.tButton1.ImageButton = ((System.Drawing.Image)(resources.GetObject("tButton1.ImageButton")));
            this.tButton1.ImageButtonViewFlag = false;
            this.tButton1.Location = new System.Drawing.Point(504, 53);
            this.tButton1.Name = "tButton1";
            this.tButton1.Padding = new System.Windows.Forms.Padding(1);
            this.tButton1.SelectedWidth = 3;
            this.tButton1.Size = new System.Drawing.Size(123, 44);
            this.tButton1.TabIndex = 60;
            this.tButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tButton1.ButtonClick += new System.EventHandler(this.tButton1_ButtonClick);
            // 
            // lbl_OP_NM
            // 
            this.lbl_OP_NM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_OP_NM.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_OP_NM.BorderBottom = true;
            this.lbl_OP_NM.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_OP_NM.BorderLeft = true;
            this.lbl_OP_NM.BorderRight = true;
            this.lbl_OP_NM.BorderTop = true;
            this.lbl_OP_NM.Caption = "";
            this.tableLayoutPanel2.SetColumnSpan(this.lbl_OP_NM, 3);
            this.lbl_OP_NM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_OP_NM.FontSize = 14.25F;
            this.lbl_OP_NM.FontStyle = System.Drawing.FontStyle.Regular;
            this.lbl_OP_NM.Location = new System.Drawing.Point(131, 102);
            this.lbl_OP_NM.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_OP_NM.Name = "lbl_OP_NM";
            this.lbl_OP_NM.Size = new System.Drawing.Size(497, 46);
            this.lbl_OP_NM.TabIndex = 57;
            this.lbl_OP_NM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_OP_NM.Value = "";
            // 
            // cboWorker
            // 
            this.cboWorker.BackColor = System.Drawing.SystemColors.Window;
            this.cboWorker.BorderBackColor = System.Drawing.SystemColors.Window;
            this.cboWorker.BorderBottom = true;
            this.cboWorker.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.cboWorker.BorderLeft = true;
            this.cboWorker.BorderRight = false;
            this.cboWorker.BorderTop = true;
            this.cboWorker.Caption = "";
            this.cboWorker.DisplayCaption = "Code Name";
            this.cboWorker.DisplayMember = "CODE_NM";
            this.cboWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboWorker.FontSize = 14.25F;
            this.cboWorker.FontStyle = System.Drawing.FontStyle.Regular;
            this.cboWorker.Location = new System.Drawing.Point(132, 3);
            this.cboWorker.Name = "cboWorker";
            this.cboWorker.SelectedIndex = -1;
            this.cboWorker.SelectedText = "";
            this.cboWorker.SelectionLength = 0;
            this.cboWorker.SelectionStart = 0;
            this.cboWorker.Size = new System.Drawing.Size(237, 44);
            this.cboWorker.TabIndex = 28;
            this.cboWorker.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cboWorker.Value = "";
            this.cboWorker.ValueCaption = "Code";
            this.cboWorker.ValueMember = "CODE_ID";
            this.cboWorker.ValueName = "";
            // 
            // tLabel5
            // 
            this.tLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.tLabel5.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.tLabel5.BorderBottom = true;
            this.tLabel5.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tLabel5.BorderLeft = true;
            this.tLabel5.BorderRight = true;
            this.tLabel5.BorderTop = true;
            this.tLabel5.Caption = "작업자";
            this.tLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLabel5.FontSize = 14.25F;
            this.tLabel5.FontStyle = System.Drawing.FontStyle.Regular;
            this.tLabel5.Location = new System.Drawing.Point(2, 2);
            this.tLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.tLabel5.Name = "tLabel5";
            this.tLabel5.Size = new System.Drawing.Size(125, 46);
            this.tLabel5.TabIndex = 27;
            this.tLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tLabel5.Value = "작업자";
            // 
            // tLabel2
            // 
            this.tLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.tLabel2.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.tLabel2.BorderBottom = true;
            this.tLabel2.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tLabel2.BorderLeft = true;
            this.tLabel2.BorderRight = true;
            this.tLabel2.BorderTop = true;
            this.tLabel2.Caption = "비가동 사유";
            this.tLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLabel2.FontSize = 14.25F;
            this.tLabel2.FontStyle = System.Drawing.FontStyle.Regular;
            this.tLabel2.Location = new System.Drawing.Point(2, 52);
            this.tLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.tLabel2.Name = "tLabel2";
            this.tLabel2.Size = new System.Drawing.Size(125, 46);
            this.tLabel2.TabIndex = 29;
            this.tLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tLabel2.Value = "비가동 사유";
            // 
            // lbl_OP_GRP_NM
            // 
            this.lbl_OP_GRP_NM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_OP_GRP_NM.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_OP_GRP_NM.BorderBottom = true;
            this.lbl_OP_GRP_NM.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_OP_GRP_NM.BorderLeft = true;
            this.lbl_OP_GRP_NM.BorderRight = true;
            this.lbl_OP_GRP_NM.BorderTop = true;
            this.lbl_OP_GRP_NM.Caption = "";
            this.tableLayoutPanel2.SetColumnSpan(this.lbl_OP_GRP_NM, 2);
            this.lbl_OP_GRP_NM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_OP_GRP_NM.FontSize = 14.25F;
            this.lbl_OP_GRP_NM.FontStyle = System.Drawing.FontStyle.Regular;
            this.lbl_OP_GRP_NM.Location = new System.Drawing.Point(131, 52);
            this.lbl_OP_GRP_NM.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_OP_GRP_NM.Name = "lbl_OP_GRP_NM";
            this.lbl_OP_GRP_NM.Size = new System.Drawing.Size(368, 46);
            this.lbl_OP_GRP_NM.TabIndex = 30;
            this.lbl_OP_GRP_NM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_OP_GRP_NM.Value = "";
            // 
            // tLabel1
            // 
            this.tLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tLabel1.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tLabel1.BorderBottom = true;
            this.tLabel1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tLabel1.BorderLeft = true;
            this.tLabel1.BorderRight = true;
            this.tLabel1.BorderTop = true;
            this.tLabel1.Caption = "비가동 시각";
            this.tableLayoutPanel2.SetColumnSpan(this.tLabel1, 5);
            this.tLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLabel1.FontSize = 12F;
            this.tLabel1.FontStyle = System.Drawing.FontStyle.Regular;
            this.tLabel1.Location = new System.Drawing.Point(2, 152);
            this.tLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.tLabel1.Name = "tLabel1";
            this.tLabel1.Size = new System.Drawing.Size(758, 25);
            this.tLabel1.TabIndex = 52;
            this.tLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tLabel1.Value = "비가동 시각";
            // 
            // tLabel4
            // 
            this.tLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.tLabel4.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.tLabel4.BorderBottom = true;
            this.tLabel4.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tLabel4.BorderLeft = true;
            this.tLabel4.BorderRight = true;
            this.tLabel4.BorderTop = true;
            this.tLabel4.Caption = "시작시각";
            this.tLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLabel4.FontSize = 14.25F;
            this.tLabel4.FontStyle = System.Drawing.FontStyle.Regular;
            this.tLabel4.Location = new System.Drawing.Point(2, 179);
            this.tLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.tLabel4.Name = "tLabel4";
            this.tLabel4.Size = new System.Drawing.Size(125, 46);
            this.tLabel4.TabIndex = 53;
            this.tLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tLabel4.Value = "시작시각";
            // 
            // tLabel6
            // 
            this.tLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.tLabel6.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.tLabel6.BorderBottom = true;
            this.tLabel6.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tLabel6.BorderLeft = true;
            this.tLabel6.BorderRight = true;
            this.tLabel6.BorderTop = true;
            this.tLabel6.Caption = "종료시각";
            this.tLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLabel6.FontSize = 14.25F;
            this.tLabel6.FontStyle = System.Drawing.FontStyle.Regular;
            this.tLabel6.Location = new System.Drawing.Point(2, 229);
            this.tLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.tLabel6.Name = "tLabel6";
            this.tLabel6.Size = new System.Drawing.Size(125, 49);
            this.tLabel6.TabIndex = 54;
            this.tLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tLabel6.Value = "종료시각";
            // 
            // tDateTime1
            // 
            this.tDateTime1.BorderBottom = true;
            this.tDateTime1.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.tDateTime1.BorderLeft = true;
            this.tDateTime1.BorderRight = false;
            this.tDateTime1.BorderTop = true;
            this.tDateTime1.Caption = "시작시각";
            this.tDateTime1.DefaultEdit = "DAY";
            this.tDateTime1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tDateTime1.FontSize = 15.75F;
            this.tDateTime1.FontStyle = System.Drawing.FontStyle.Regular;
            this.tDateTime1.Location = new System.Drawing.Point(132, 180);
            this.tDateTime1.Name = "tDateTime1";
            this.tDateTime1.Size = new System.Drawing.Size(237, 44);
            this.tDateTime1.TabIndex = 55;
            this.tDateTime1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tDateTime1.Value = "2017-01-16";
            this.tDateTime1.Value_Datetime = new System.DateTime(2017, 1, 16, 0, 0, 0, 0);
            this.tDateTime1.ValueTime = "00:00";
            this.tDateTime1.ValueTime_Hour = 0;
            this.tDateTime1.ValueTime_Minute = 0;
            this.tDateTime1.VisibleTime = true;
            this.tDateTime1.EditValue += new System.EventHandler(this.tDateTime1_EditValue);
            // 
            // tDateTime2
            // 
            this.tDateTime2.BorderBottom = true;
            this.tDateTime2.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.tDateTime2.BorderLeft = true;
            this.tDateTime2.BorderRight = false;
            this.tDateTime2.BorderTop = true;
            this.tDateTime2.Caption = "종료시각";
            this.tDateTime2.DefaultEdit = "DAY";
            this.tDateTime2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tDateTime2.FontSize = 15.75F;
            this.tDateTime2.FontStyle = System.Drawing.FontStyle.Regular;
            this.tDateTime2.Location = new System.Drawing.Point(132, 230);
            this.tDateTime2.Name = "tDateTime2";
            this.tDateTime2.Size = new System.Drawing.Size(237, 47);
            this.tDateTime2.TabIndex = 56;
            this.tDateTime2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tDateTime2.Value = "2017-01-16";
            this.tDateTime2.Value_Datetime = new System.DateTime(2017, 1, 16, 0, 0, 0, 0);
            this.tDateTime2.ValueTime = "00:00";
            this.tDateTime2.ValueTime_Hour = 0;
            this.tDateTime2.ValueTime_Minute = 0;
            this.tDateTime2.VisibleTime = true;
            // 
            // opt_Start_DT1
            // 
            this.opt_Start_DT1.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.opt_Start_DT1.BorderBottom = false;
            this.opt_Start_DT1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.opt_Start_DT1.BorderLeft = false;
            this.opt_Start_DT1.BorderRight = false;
            this.opt_Start_DT1.BorderTop = false;
            this.opt_Start_DT1.Caption = "현 시각";
            this.opt_Start_DT1.FontSize = 14.25F;
            this.opt_Start_DT1.FontStyle = System.Drawing.FontStyle.Regular;
            this.opt_Start_DT1.Location = new System.Drawing.Point(375, 180);
            this.opt_Start_DT1.Name = "opt_Start_DT1";
            this.opt_Start_DT1.Selected = false;
            this.opt_Start_DT1.Size = new System.Drawing.Size(123, 44);
            this.opt_Start_DT1.TabIndex = 58;
            this.opt_Start_DT1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.opt_Start_DT1.Value = 0;
            this.opt_Start_DT1.ValueChar = "N";
            this.opt_Start_DT1.ValueChar_Selected = "Y";
            this.opt_Start_DT1.ValueChar_UnSelected = "N";
            this.opt_Start_DT1.SelectedChange += new System.EventHandler(this.opt_Start_DT1_SelectedChange);
            // 
            // opt_Start_DT2
            // 
            this.opt_Start_DT2.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.opt_Start_DT2.BorderBottom = false;
            this.opt_Start_DT2.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.opt_Start_DT2.BorderLeft = false;
            this.opt_Start_DT2.BorderRight = false;
            this.opt_Start_DT2.BorderTop = false;
            this.opt_Start_DT2.Caption = "전 실적";
            this.opt_Start_DT2.FontSize = 14.25F;
            this.opt_Start_DT2.FontStyle = System.Drawing.FontStyle.Regular;
            this.opt_Start_DT2.Location = new System.Drawing.Point(504, 180);
            this.opt_Start_DT2.Name = "opt_Start_DT2";
            this.opt_Start_DT2.Selected = false;
            this.opt_Start_DT2.Size = new System.Drawing.Size(123, 44);
            this.opt_Start_DT2.TabIndex = 59;
            this.opt_Start_DT2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.opt_Start_DT2.Value = 0;
            this.opt_Start_DT2.ValueChar = "N";
            this.opt_Start_DT2.ValueChar_Selected = "Y";
            this.opt_Start_DT2.ValueChar_UnSelected = "N";
            this.opt_Start_DT2.SelectedChange += new System.EventHandler(this.opt_Start_DT2_SelectedChange);
            // 
            // opt_Start_DT3
            // 
            this.opt_Start_DT3.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.opt_Start_DT3.BorderBottom = false;
            this.opt_Start_DT3.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.opt_Start_DT3.BorderLeft = false;
            this.opt_Start_DT3.BorderRight = false;
            this.opt_Start_DT3.BorderTop = false;
            this.opt_Start_DT3.Caption = "수정안함";
            this.opt_Start_DT3.FontSize = 12.25F;
            this.opt_Start_DT3.FontStyle = System.Drawing.FontStyle.Regular;
            this.opt_Start_DT3.Location = new System.Drawing.Point(633, 180);
            this.opt_Start_DT3.Name = "opt_Start_DT3";
            this.opt_Start_DT3.Selected = true;
            this.opt_Start_DT3.Size = new System.Drawing.Size(120, 44);
            this.opt_Start_DT3.TabIndex = 61;
            this.opt_Start_DT3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.opt_Start_DT3.Value = 1;
            this.opt_Start_DT3.ValueChar = "Y";
            this.opt_Start_DT3.ValueChar_Selected = "Y";
            this.opt_Start_DT3.ValueChar_UnSelected = "N";
            this.opt_Start_DT3.SelectedChange += new System.EventHandler(this.opt_Start_DT3_SelectedChange);
            // 
            // Panel_Cmd
            // 
            this.Panel_Cmd.BackColor = System.Drawing.SystemColors.Control;
            this.Panel_Cmd.ColumnCount = 5;
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Panel_Cmd.Controls.Add(this.btn_Close, 4, 0);
            this.Panel_Cmd.Controls.Add(this.btn_Start, 2, 0);
            this.Panel_Cmd.Controls.Add(this.chkSendMessage, 0, 0);
            this.Panel_Cmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Cmd.Location = new System.Drawing.Point(3, 331);
            this.Panel_Cmd.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Cmd.Name = "Panel_Cmd";
            this.Panel_Cmd.RowCount = 2;
            this.Panel_Cmd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Cmd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.Panel_Cmd.Size = new System.Drawing.Size(762, 80);
            this.Panel_Cmd.TabIndex = 3;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Close.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_Close.BorderBottom = true;
            this.btn_Close.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btn_Close.BorderLeft = true;
            this.btn_Close.BorderRight = true;
            this.btn_Close.BorderTop = true;
            this.btn_Close.BorderWidth = 0;
            this.btn_Close.ButtonSelected = false;
            this.btn_Close.Caption = "취소";
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Close.Font = new System.Drawing.Font("맑은 고딕", 14.25F);
            this.btn_Close.FontSize = 14.25F;
            this.btn_Close.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_Close.ForeColor = System.Drawing.Color.Black;
            this.btn_Close.IConImage1 = null;
            this.btn_Close.IConImage2 = null;
            this.btn_Close.IConViewFlag = false;
            this.btn_Close.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Close.ImageButton")));
            this.btn_Close.ImageButtonViewFlag = false;
            this.btn_Close.Location = new System.Drawing.Point(523, 6);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Close.SelectedWidth = 3;
            this.btn_Close.Size = new System.Drawing.Size(236, 61);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Close.ButtonClick += new System.EventHandler(this.btn_Close_ButtonClick);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Start.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_Start.BorderBottom = true;
            this.btn_Start.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btn_Start.BorderLeft = true;
            this.btn_Start.BorderRight = true;
            this.btn_Start.BorderTop = true;
            this.btn_Start.BorderWidth = 0;
            this.btn_Start.ButtonSelected = false;
            this.btn_Start.Caption = "비가동 시작";
            this.btn_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Start.Font = new System.Drawing.Font("맑은 고딕", 14.25F);
            this.btn_Start.FontSize = 14.25F;
            this.btn_Start.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_Start.ForeColor = System.Drawing.Color.Blue;
            this.btn_Start.IConImage1 = null;
            this.btn_Start.IConImage2 = null;
            this.btn_Start.IConViewFlag = false;
            this.btn_Start.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Start.ImageButton")));
            this.btn_Start.ImageButtonViewFlag = false;
            this.btn_Start.Location = new System.Drawing.Point(263, 6);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Start.SelectedWidth = 3;
            this.btn_Start.Size = new System.Drawing.Size(234, 61);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Start.ButtonClick += new System.EventHandler(this.btn_Start_ButtonClick);
            // 
            // chkSendMessage
            // 
            this.chkSendMessage.BorderBackColor = System.Drawing.SystemColors.Control;
            this.chkSendMessage.BorderBottom = false;
            this.chkSendMessage.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.chkSendMessage.BorderLeft = false;
            this.chkSendMessage.BorderRight = false;
            this.chkSendMessage.BorderTop = false;
            this.chkSendMessage.Caption = "메세지 발송";
            this.chkSendMessage.Checked = true;
            this.chkSendMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSendMessage.FontSize = 14.25F;
            this.chkSendMessage.FontStyle = System.Drawing.FontStyle.Regular;
            this.chkSendMessage.Location = new System.Drawing.Point(3, 3);
            this.chkSendMessage.Name = "chkSendMessage";
            this.chkSendMessage.Size = new System.Drawing.Size(234, 64);
            this.chkSendMessage.TabIndex = 6;
            this.chkSendMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkSendMessage.Value = 1;
            this.chkSendMessage.ValueChar = "Y";
            this.chkSendMessage.ValueChar_Check = "Y";
            this.chkSendMessage.ValueChar_unCheck = "N";
            // 
            // POP_P0401P2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 471);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.windowsForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POP_P0401P2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "POP_P0401P2";
            this.Activated += new System.EventHandler(this.POP_P0401P2_Activated);
            this.Deactivate += new System.EventHandler(this.POP_P0401P2_Deactivate);
            this.Load += new System.EventHandler(this.Form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Panel_Cmd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TGSControl.WindowsForm windowsForm1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private TGSControl.TCombo cboWorker;
        private TGSControl.TLabel tLabel5;
        private TGSControl.TLabel tLabel1;
        private System.Windows.Forms.TableLayoutPanel Panel_Cmd;
        private TGSControl.TButton btn_Close;
        private TGSControl.TButton btn_Start;
        private TGSControl.TLabel tLabel2;
        private TGSControl.TLabel lbl_OP_GRP_NM;
        private TGSControl.TLabel tLabel4;
        private TGSControl.TLabel tLabel6;
        private TGSControl.TDateTime tDateTime1;
        private TGSControl.TLabel lbl_OP_NM;
        private TGSControl.TDateTime tDateTime2;
        private TGSControl.TRadioButton opt_Start_DT1;
        private TGSControl.TRadioButton opt_Start_DT2;
        private TGSControl.TButton tButton1;
        private TGSControl.TRadioButton opt_Start_DT3;
        private TGSControl.TCheckBox chkSendMessage;
    }
}