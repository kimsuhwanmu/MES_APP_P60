namespace MES_APP_P90
{
    partial class APP_P6001MA2
   {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APP_P6001MA2));
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
         this.Panel_Doc = new System.Windows.Forms.TableLayoutPanel();
         this.Panel_Cmd = new System.Windows.Forms.TableLayoutPanel();
         this.btn_Query = new TGSControl.TButton2();
         this.Panel_Doc11 = new System.Windows.Forms.TableLayoutPanel();
         this.dt_DT_con = new TGSControl.TDateTerm();
         this.tLabel1 = new TGSControl.TLabel();
         this.tLabel5 = new TGSControl.TLabel();
         this.cboWorker = new TGSControl.TCombo();
         this.tLabel2 = new TGSControl.TLabel();
         this.lbl_WorkCenterNm = new TGSControl.TLabel();
         this.Grid1 = new System.Windows.Forms.DataGridView();
         this.Panel_Doc.SuspendLayout();
         this.Panel_Cmd.SuspendLayout();
         this.Panel_Doc11.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
         this.SuspendLayout();
         // 
         // Panel_Doc
         // 
         this.Panel_Doc.ColumnCount = 1;
         this.Panel_Doc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.Panel_Doc.Controls.Add(this.Panel_Cmd, 0, 2);
         this.Panel_Doc.Controls.Add(this.Panel_Doc11, 0, 0);
         this.Panel_Doc.Controls.Add(this.Grid1, 0, 3);
         this.Panel_Doc.Dock = System.Windows.Forms.DockStyle.Fill;
         this.Panel_Doc.Location = new System.Drawing.Point(0, 0);
         this.Panel_Doc.Margin = new System.Windows.Forms.Padding(0);
         this.Panel_Doc.Name = "Panel_Doc";
         this.Panel_Doc.RowCount = 4;
         this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
         this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
         this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.Panel_Doc.Size = new System.Drawing.Size(1024, 604);
         this.Panel_Doc.TabIndex = 3;
         // 
         // Panel_Cmd
         // 
         this.Panel_Cmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
         this.Panel_Cmd.ColumnCount = 11;
         this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.080808F));
         this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.080808F));
         this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
         this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.080808F));
         this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.15152F));
         this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.15152F));
         this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
         this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.15152F));
         this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
         this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.15152F));
         this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.15152F));
         this.Panel_Cmd.Controls.Add(this.btn_Query, 10, 0);
         this.Panel_Cmd.Dock = System.Windows.Forms.DockStyle.Fill;
         this.Panel_Cmd.Location = new System.Drawing.Point(0, 524);
         this.Panel_Cmd.Margin = new System.Windows.Forms.Padding(0);
         this.Panel_Cmd.Name = "Panel_Cmd";
         this.Panel_Cmd.RowCount = 1;
         this.Panel_Cmd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.Panel_Cmd.Size = new System.Drawing.Size(1024, 60);
         this.Panel_Cmd.TabIndex = 49;
         // 
         // btn_Query
         // 
         this.btn_Query.BackColor = System.Drawing.SystemColors.Control;
         this.btn_Query.Base_FontSize = 13F;
         this.btn_Query.BorderBackColor = System.Drawing.SystemColors.Control;
         this.btn_Query.BorderBottom = true;
         this.btn_Query.BorderColor = System.Drawing.SystemColors.Control;
         this.btn_Query.BorderColorSelect = System.Drawing.Color.Blue;
         this.btn_Query.BorderLeft = true;
         this.btn_Query.BorderRight = true;
         this.btn_Query.BorderTop = true;
         this.btn_Query.BorderWidth = 0;
         this.btn_Query.ButtonSelected = false;
         this.btn_Query.ButtonType = "Info";
         this.btn_Query.Caption = "조회";
         this.btn_Query.Font = new System.Drawing.Font("맑은 고딕", 13F);
         this.btn_Query.FontSize = 13F;
         this.btn_Query.FontStyle = System.Drawing.FontStyle.Regular;
         this.btn_Query.ForeColor = System.Drawing.Color.White;
         this.btn_Query.ForeColorSelect = System.Drawing.Color.Red;
         this.btn_Query.IConImage1 = null;
         this.btn_Query.IConImage2 = null;
         this.btn_Query.IConViewFlag = false;
         this.btn_Query.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Query.ImageButton")));
         this.btn_Query.ImageButtonViewFlag = false;
         this.btn_Query.Location = new System.Drawing.Point(872, 2);
         this.btn_Query.Margin = new System.Windows.Forms.Padding(2);
         this.btn_Query.Name = "btn_Query";
         this.btn_Query.Padding = new System.Windows.Forms.Padding(1);
         this.btn_Query.SelectedWidth = 3;
         this.btn_Query.Size = new System.Drawing.Size(76, 56);
         this.btn_Query.TabIndex = 17;
         this.btn_Query.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btn_Query.TScale = 1F;
         // 
         // Panel_Doc11
         // 
         this.Panel_Doc11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
         this.Panel_Doc11.ColumnCount = 8;
         this.Panel_Doc11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
         this.Panel_Doc11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.00011F));
         this.Panel_Doc11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
         this.Panel_Doc11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
         this.Panel_Doc11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.99977F));
         this.Panel_Doc11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
         this.Panel_Doc11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
         this.Panel_Doc11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.00012F));
         this.Panel_Doc11.Controls.Add(this.dt_DT_con, 0, 0);
         this.Panel_Doc11.Controls.Add(this.tLabel1, 0, 0);
         this.Panel_Doc11.Controls.Add(this.tLabel5, 3, 0);
         this.Panel_Doc11.Controls.Add(this.cboWorker, 4, 0);
         this.Panel_Doc11.Controls.Add(this.tLabel2, 6, 0);
         this.Panel_Doc11.Controls.Add(this.lbl_WorkCenterNm, 7, 0);
         this.Panel_Doc11.Dock = System.Windows.Forms.DockStyle.Fill;
         this.Panel_Doc11.Location = new System.Drawing.Point(3, 3);
         this.Panel_Doc11.Name = "Panel_Doc11";
         this.Panel_Doc11.RowCount = 1;
         this.Panel_Doc11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.Panel_Doc11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.Panel_Doc11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.Panel_Doc11.Size = new System.Drawing.Size(1018, 40);
         this.Panel_Doc11.TabIndex = 47;
         // 
         // dt_DT_con
         // 
         this.dt_DT_con.BorderBottom = false;
         this.dt_DT_con.BorderColor = System.Drawing.SystemColors.Control;
         this.dt_DT_con.BorderLeft = false;
         this.dt_DT_con.BorderRight = false;
         this.dt_DT_con.BorderTop = false;
         this.dt_DT_con.Caption = "Calendar";
         this.dt_DT_con.DateDeleteVisible_From = false;
         this.dt_DT_con.DateDeleteVisible_To = false;
         this.dt_DT_con.DateFormat = "yyyy-MM-dd";
         this.dt_DT_con.DefaultValue = "00";
         this.dt_DT_con.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dt_DT_con.FontSize = 14.25F;
         this.dt_DT_con.FontStyle = System.Drawing.FontStyle.Regular;
         this.dt_DT_con.Location = new System.Drawing.Point(143, 3);
         this.dt_DT_con.Name = "dt_DT_con";
         this.dt_DT_con.ReadOnly_From = false;
         this.dt_DT_con.ReadOnly_To = false;
         this.dt_DT_con.Required = false;
         this.dt_DT_con.Size = new System.Drawing.Size(217, 34);
         this.dt_DT_con.TabIndex = 23;
         this.dt_DT_con.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.dt_DT_con.TScale = 1F;
         this.dt_DT_con.ValueFrom = "2016-01-01";
         this.dt_DT_con.ValueFrom_Datetime = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
         this.dt_DT_con.ValueTo = "2016-01-01";
         this.dt_DT_con.ValueTo_Datetime = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
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
         this.tLabel1.Caption = "일자";
         this.tLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tLabel1.FontSize = 13F;
         this.tLabel1.FontStyle = System.Drawing.FontStyle.Regular;
         this.tLabel1.Location = new System.Drawing.Point(2, 2);
         this.tLabel1.Margin = new System.Windows.Forms.Padding(2);
         this.tLabel1.Name = "tLabel1";
         this.tLabel1.Size = new System.Drawing.Size(136, 36);
         this.tLabel1.TabIndex = 22;
         this.tLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.tLabel1.TScale = 1F;
         this.tLabel1.Value = "일자";
         // 
         // tLabel5
         // 
         this.tLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
         this.tLabel5.Base_FontSize = 13F;
         this.tLabel5.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
         this.tLabel5.BorderBottom = true;
         this.tLabel5.BorderColor = System.Drawing.SystemColors.ActiveBorder;
         this.tLabel5.BorderLeft = true;
         this.tLabel5.BorderRight = true;
         this.tLabel5.BorderTop = true;
         this.tLabel5.Caption = "작업자";
         this.tLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tLabel5.FontSize = 13F;
         this.tLabel5.FontStyle = System.Drawing.FontStyle.Regular;
         this.tLabel5.Location = new System.Drawing.Point(375, 2);
         this.tLabel5.Margin = new System.Windows.Forms.Padding(2);
         this.tLabel5.Name = "tLabel5";
         this.tLabel5.Size = new System.Drawing.Size(86, 36);
         this.tLabel5.TabIndex = 16;
         this.tLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.tLabel5.TScale = 1F;
         this.tLabel5.Value = "작업자";
         // 
         // cboWorker
         // 
         this.cboWorker.BackColor = System.Drawing.Color.White;
         this.cboWorker.BorderBackColor = System.Drawing.Color.White;
         this.cboWorker.BorderBottom = true;
         this.cboWorker.BorderColor = System.Drawing.SystemColors.ActiveBorder;
         this.cboWorker.BorderLeft = true;
         this.cboWorker.BorderRight = false;
         this.cboWorker.BorderTop = true;
         this.cboWorker.Caption = "";
         this.cboWorker.DefaultComboType = null;
         this.cboWorker.DisplayCaption = "Code Name";
         this.cboWorker.DisplayMember = "CODE_NM";
         this.cboWorker.Dock = System.Windows.Forms.DockStyle.Fill;
         this.cboWorker.FontSize = 13F;
         this.cboWorker.FontStyle = System.Drawing.FontStyle.Regular;
         this.cboWorker.Location = new System.Drawing.Point(466, 3);
         this.cboWorker.Name = "cboWorker";
         this.cboWorker.PasswordChar = '\0';
         this.cboWorker.SelectedIndex = -1;
         this.cboWorker.SelectedText = "";
         this.cboWorker.SelectionLength = 0;
         this.cboWorker.SelectionStart = 0;
         this.cboWorker.Size = new System.Drawing.Size(210, 34);
         this.cboWorker.TabIndex = 20;
         this.cboWorker.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
         this.cboWorker.TScale = 1F;
         this.cboWorker.Value = "";
         this.cboWorker.ValueCaption = "Code";
         this.cboWorker.ValueMember = "CODE_ID";
         this.cboWorker.ValueName = "";
         // 
         // tLabel2
         // 
         this.tLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
         this.tLabel2.Base_FontSize = 13F;
         this.tLabel2.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
         this.tLabel2.BorderBottom = true;
         this.tLabel2.BorderColor = System.Drawing.SystemColors.ActiveBorder;
         this.tLabel2.BorderLeft = true;
         this.tLabel2.BorderRight = true;
         this.tLabel2.BorderTop = true;
         this.tLabel2.Caption = "작업장";
         this.tLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tLabel2.FontSize = 13F;
         this.tLabel2.FontStyle = System.Drawing.FontStyle.Regular;
         this.tLabel2.Location = new System.Drawing.Point(691, 2);
         this.tLabel2.Margin = new System.Windows.Forms.Padding(2);
         this.tLabel2.Name = "tLabel2";
         this.tLabel2.Size = new System.Drawing.Size(86, 36);
         this.tLabel2.TabIndex = 9;
         this.tLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.tLabel2.TScale = 1F;
         this.tLabel2.Value = "작업장";
         // 
         // lbl_WorkCenterNm
         // 
         this.lbl_WorkCenterNm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
         this.lbl_WorkCenterNm.Base_FontSize = 13F;
         this.lbl_WorkCenterNm.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
         this.lbl_WorkCenterNm.BorderBottom = true;
         this.lbl_WorkCenterNm.BorderColor = System.Drawing.SystemColors.ActiveBorder;
         this.lbl_WorkCenterNm.BorderLeft = true;
         this.lbl_WorkCenterNm.BorderRight = true;
         this.lbl_WorkCenterNm.BorderTop = true;
         this.lbl_WorkCenterNm.Caption = "";
         this.lbl_WorkCenterNm.Dock = System.Windows.Forms.DockStyle.Fill;
         this.lbl_WorkCenterNm.FontSize = 13F;
         this.lbl_WorkCenterNm.FontStyle = System.Drawing.FontStyle.Regular;
         this.lbl_WorkCenterNm.Location = new System.Drawing.Point(781, 2);
         this.lbl_WorkCenterNm.Margin = new System.Windows.Forms.Padding(2);
         this.lbl_WorkCenterNm.Name = "lbl_WorkCenterNm";
         this.lbl_WorkCenterNm.Size = new System.Drawing.Size(235, 36);
         this.lbl_WorkCenterNm.TabIndex = 21;
         this.lbl_WorkCenterNm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.lbl_WorkCenterNm.TScale = 1F;
         this.lbl_WorkCenterNm.Value = "";
         // 
         // Grid1
         // 
         this.Grid1.AllowUserToAddRows = false;
         this.Grid1.AllowUserToDeleteRows = false;
         this.Grid1.AllowUserToResizeRows = false;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.Grid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
         this.Grid1.BackgroundColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.Grid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
         this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
         dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.Grid1.DefaultCellStyle = dataGridViewCellStyle3;
         this.Grid1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.Grid1.Location = new System.Drawing.Point(3, 584);
         this.Grid1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
         this.Grid1.MultiSelect = false;
         this.Grid1.Name = "Grid1";
         this.Grid1.ReadOnly = true;
         dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.Grid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
         dataGridViewCellStyle5.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.Grid1.RowsDefaultCellStyle = dataGridViewCellStyle5;
         this.Grid1.RowTemplate.Height = 42;
         this.Grid1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.Grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.Grid1.Size = new System.Drawing.Size(1018, 20);
         this.Grid1.TabIndex = 46;
         // 
         // APP_P6001MA2
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         this.Controls.Add(this.Panel_Doc);
         this.Name = "APP_P6001MA2";
         this.Size = new System.Drawing.Size(1024, 604);
         this.Load += new System.EventHandler(this.Form_Load);
         this.Resize += new System.EventHandler(this.APP_P1001M1_Resize);
         this.Panel_Doc.ResumeLayout(false);
         this.Panel_Cmd.ResumeLayout(false);
         this.Panel_Doc11.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
         this.ResumeLayout(false);

        }

      #endregion

      private System.Windows.Forms.TableLayoutPanel Panel_Doc;
      private System.Windows.Forms.TableLayoutPanel Panel_Cmd;
      private TGSControl.TButton2 btn_Query;
      private System.Windows.Forms.TableLayoutPanel Panel_Doc11;
      private TGSControl.TLabel tLabel5;
      private TGSControl.TLabel tLabel2;
      private TGSControl.TLabel lbl_WorkCenterNm;
      private TGSControl.TCombo cboWorker;
      private System.Windows.Forms.DataGridView Grid1;
      private TGSControl.TLabel tLabel1;
      private TGSControl.TDateTerm dt_DT_con;
   }
}

