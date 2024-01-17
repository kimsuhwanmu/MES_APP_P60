namespace MES_APP_P90
{
    partial class POP_P9001PA5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POP_P9001PA5));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.windowsForm1 = new TGSControl.WindowsForm();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cboWorker = new TGSControl.TCombo();
            this.tLabel5 = new TGSControl.TLabel();
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.tLabel1 = new TGSControl.TLabel();
            this.Panel_Cmd = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Close = new TGSControl.TButton();
            this.btn_Start = new TGSControl.TButton();
            this.btn_Next = new TGSControl.TButton();
            this.btn_Before = new TGSControl.TButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.Panel_Cmd.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowsForm1
            // 
            this.windowsForm1.BorderColor = System.Drawing.Color.DarkOrange;
            this.windowsForm1.BorderWidth = 5;
            this.windowsForm1.Caption = "비가동 전환";
            this.windowsForm1.Close_Visible = true;
            this.windowsForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowsForm1.Font = new System.Drawing.Font("맑은 고딕", 22F, System.Drawing.FontStyle.Bold);
            this.windowsForm1.ForeColor = System.Drawing.Color.White;
            this.windowsForm1.Location = new System.Drawing.Point(0, 0);
            this.windowsForm1.Margin = new System.Windows.Forms.Padding(0);
            this.windowsForm1.Name = "windowsForm1";
            this.windowsForm1.Size = new System.Drawing.Size(549, 568);
            this.windowsForm1.TabIndex = 1;
            this.windowsForm1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.windowsForm1.Title_Height = 50;
            this.windowsForm1.Title_Icon = null;
            this.windowsForm1.Title_Visible = true;
            this.windowsForm1.CloseClick += new System.EventHandler(this.windowsForm1_CloseClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Grid1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Panel_Cmd, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 513);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.cboWorker, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tLabel5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(538, 40);
            this.tableLayoutPanel2.TabIndex = 54;
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
            this.cboWorker.Location = new System.Drawing.Point(164, 3);
            this.cboWorker.Name = "cboWorker";
            this.cboWorker.SelectedIndex = -1;
            this.cboWorker.SelectedText = "";
            this.cboWorker.SelectionLength = 0;
            this.cboWorker.SelectionStart = 0;
            this.cboWorker.Size = new System.Drawing.Size(371, 34);
            this.cboWorker.TabIndex = 28;
            this.cboWorker.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cboWorker.Value = "";
            this.cboWorker.ValueCaption = "Code";
            this.cboWorker.ValueMember = "CODE_ID";
            this.cboWorker.ValueName = "";
            this.cboWorker.SelectedValueChanged += new System.EventHandler(this.cboWorker_SelectedValueChanged);
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
            this.tLabel5.Size = new System.Drawing.Size(157, 36);
            this.tLabel5.TabIndex = 27;
            this.tLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tLabel5.Value = "작업자";
            // 
            // Grid1
            // 
            this.Grid1.AllowUserToAddRows = false;
            this.Grid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Grid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid1.Location = new System.Drawing.Point(3, 71);
            this.Grid1.MultiSelect = false;
            this.Grid1.Name = "Grid1";
            this.Grid1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Grid1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Grid1.RowTemplate.Height = 39;
            this.Grid1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid1.Size = new System.Drawing.Size(532, 379);
            this.Grid1.TabIndex = 53;
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
            this.tLabel1.Caption = "시작할 비가동을 선택하세요";
            this.tableLayoutPanel1.SetColumnSpan(this.tLabel1, 2);
            this.tLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLabel1.FontSize = 12F;
            this.tLabel1.FontStyle = System.Drawing.FontStyle.Regular;
            this.tLabel1.Location = new System.Drawing.Point(2, 42);
            this.tLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.tLabel1.Name = "tLabel1";
            this.tLabel1.Size = new System.Drawing.Size(534, 26);
            this.tLabel1.TabIndex = 52;
            this.tLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tLabel1.Value = "시작할 비가동을 선택하세요";
            // 
            // Panel_Cmd
            // 
            this.Panel_Cmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.Panel_Cmd.ColumnCount = 6;
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.Panel_Cmd.Controls.Add(this.btn_Close, 5, 0);
            this.Panel_Cmd.Controls.Add(this.btn_Start, 3, 0);
            this.Panel_Cmd.Controls.Add(this.btn_Next, 1, 0);
            this.Panel_Cmd.Controls.Add(this.btn_Before, 0, 0);
            this.Panel_Cmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Cmd.Location = new System.Drawing.Point(0, 453);
            this.Panel_Cmd.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Cmd.Name = "Panel_Cmd";
            this.Panel_Cmd.RowCount = 1;
            this.Panel_Cmd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Cmd.Size = new System.Drawing.Size(538, 60);
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
            this.btn_Close.Location = new System.Drawing.Point(400, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Close.SelectedWidth = 3;
            this.btn_Close.Size = new System.Drawing.Size(135, 54);
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
            this.btn_Start.ForeColor = System.Drawing.Color.Black;
            this.btn_Start.IConImage1 = null;
            this.btn_Start.IConImage2 = null;
            this.btn_Start.IConViewFlag = false;
            this.btn_Start.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Start.ImageButton")));
            this.btn_Start.ImageButtonViewFlag = false;
            this.btn_Start.Location = new System.Drawing.Point(241, 3);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Start.SelectedWidth = 3;
            this.btn_Start.Size = new System.Drawing.Size(143, 54);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Start.ButtonClick += new System.EventHandler(this.btn_Start_ButtonClick);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Next.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_Next.BorderBottom = true;
            this.btn_Next.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btn_Next.BorderLeft = true;
            this.btn_Next.BorderRight = true;
            this.btn_Next.BorderTop = true;
            this.btn_Next.BorderWidth = 0;
            this.btn_Next.ButtonSelected = false;
            this.btn_Next.Caption = "다음";
            this.btn_Next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Next.Font = new System.Drawing.Font("맑은 고딕", 14.25F);
            this.btn_Next.FontSize = 14.25F;
            this.btn_Next.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_Next.ForeColor = System.Drawing.Color.Black;
            this.btn_Next.IConImage1 = null;
            this.btn_Next.IConImage2 = null;
            this.btn_Next.IConViewFlag = false;
            this.btn_Next.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Next.ImageButton")));
            this.btn_Next.ImageButtonViewFlag = false;
            this.btn_Next.Location = new System.Drawing.Point(107, 3);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Next.SelectedWidth = 3;
            this.btn_Next.Size = new System.Drawing.Size(98, 54);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Next.ButtonClick += new System.EventHandler(this.btn_Before_ButtonClick);
            // 
            // btn_Before
            // 
            this.btn_Before.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Before.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_Before.BorderBottom = true;
            this.btn_Before.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btn_Before.BorderLeft = true;
            this.btn_Before.BorderRight = true;
            this.btn_Before.BorderTop = true;
            this.btn_Before.BorderWidth = 0;
            this.btn_Before.ButtonSelected = false;
            this.btn_Before.Caption = "이전";
            this.btn_Before.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Before.Font = new System.Drawing.Font("맑은 고딕", 14.25F);
            this.btn_Before.FontSize = 14.25F;
            this.btn_Before.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_Before.ForeColor = System.Drawing.Color.Black;
            this.btn_Before.IConImage1 = null;
            this.btn_Before.IConImage2 = null;
            this.btn_Before.IConViewFlag = false;
            this.btn_Before.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Before.ImageButton")));
            this.btn_Before.ImageButtonViewFlag = false;
            this.btn_Before.Location = new System.Drawing.Point(3, 3);
            this.btn_Before.Name = "btn_Before";
            this.btn_Before.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Before.SelectedWidth = 3;
            this.btn_Before.Size = new System.Drawing.Size(98, 54);
            this.btn_Before.TabIndex = 0;
            this.btn_Before.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Before.ButtonClick += new System.EventHandler(this.btn_Before_ButtonClick);
            // 
            // POP_P0402P1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 568);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.windowsForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POP_P0402P1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "POP_P0402P1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.Panel_Cmd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TGSControl.WindowsForm windowsForm1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel Panel_Cmd;
        private TGSControl.TButton btn_Close;
        private TGSControl.TButton btn_Start;
        private TGSControl.TButton btn_Next;
        private TGSControl.TButton btn_Before;
        private TGSControl.TLabel tLabel1;
        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private TGSControl.TLabel tLabel5;
        private TGSControl.TCombo cboWorker;
    }
}