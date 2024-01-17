namespace MES_APP_P90
{
    partial class APP_P9003MA1
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APP_P9003MA1));
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
         this.Panel_Doc = new System.Windows.Forms.TableLayoutPanel();
         this.Panel_Doc1 = new System.Windows.Forms.TableLayoutPanel();
         this.cboFacility = new TGSControl.TCombo();
         this.tLabel4 = new TGSControl.TLabel();
         this.tLabel2 = new TGSControl.TLabel();
         this.tLabel1 = new TGSControl.TLabel();
         this.tDateTerm1 = new TGSControl.TDateTerm();
         this.Panel_Doc2 = new System.Windows.Forms.TableLayoutPanel();
         this.tButton1 = new TGSControl.TButton();
         this.btn_RESULT_CANCEL = new TGSControl.TButton();
         this.btn_WorkOrder_Info = new TGSControl.TButton();
         this.btn_Label_Print = new TGSControl.TButton();
         this.btn_Bad_Qty_Insert = new TGSControl.TButton();
         this.btn_Before = new TGSControl.TButton();
         this.btn_Next = new TGSControl.TButton();
         this.btn_Query = new TGSControl.TButton();
         this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
         this.tLabel14 = new TGSControl.TLabel();
         this.Grid2 = new System.Windows.Forms.DataGridView();
         this.Grid1 = new System.Windows.Forms.DataGridView();
         this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
         this.printDocument1 = new System.Drawing.Printing.PrintDocument();
         this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
         this.printDialog1 = new System.Windows.Forms.PrintDialog();
         this.cboWorker = new TGSControl.TCombo();
         this.cboTYPE = new TGSControl.TCombo();
         this.tLabel5 = new TGSControl.TLabel();
         this.btnFind = new TGSControl.TButton();
         this.tLabel3 = new TGSControl.TLabel();
         this.opn_ITEM_CD = new TGSControl.TOpenPopup();
         this.Panel_Doc.SuspendLayout();
         this.Panel_Doc1.SuspendLayout();
         this.Panel_Doc2.SuspendLayout();
         this.tableLayoutPanel2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.Grid2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
         this.SuspendLayout();
         // 
         // Panel_Doc
         // 
         this.Panel_Doc.ColumnCount = 1;
         this.Panel_Doc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.Panel_Doc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.Panel_Doc.Controls.Add(this.Panel_Doc1, 0, 0);
         this.Panel_Doc.Controls.Add(this.Panel_Doc2, 0, 2);
         this.Panel_Doc.Controls.Add(this.tableLayoutPanel2, 0, 1);
         this.Panel_Doc.Dock = System.Windows.Forms.DockStyle.Fill;
         this.Panel_Doc.Location = new System.Drawing.Point(0, 0);
         this.Panel_Doc.Name = "Panel_Doc";
         this.Panel_Doc.RowCount = 3;
         this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
         this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
         this.Panel_Doc.Size = new System.Drawing.Size(973, 661);
         this.Panel_Doc.TabIndex = 2;
         // 
         // Panel_Doc1
         // 
         this.Panel_Doc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
         this.Panel_Doc1.ColumnCount = 9;
         this.Panel_Doc1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
         this.Panel_Doc1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33481F));
         this.Panel_Doc1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.Panel_Doc1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
         this.Panel_Doc1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.00013F));
         this.Panel_Doc1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.33024F));
         this.Panel_Doc1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.Panel_Doc1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
         this.Panel_Doc1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33481F));
         this.Panel_Doc1.Controls.Add(this.cboFacility, 8, 0);
         this.Panel_Doc1.Controls.Add(this.tLabel5, 4, 0);
         this.Panel_Doc1.Controls.Add(this.cboWorker, 8, 1);
         this.Panel_Doc1.Controls.Add(this.tLabel4, 7, 1);
         this.Panel_Doc1.Controls.Add(this.tLabel2, 7, 0);
         this.Panel_Doc1.Controls.Add(this.tLabel1, 0, 0);
         this.Panel_Doc1.Controls.Add(this.tLabel3, 0, 1);
         this.Panel_Doc1.Controls.Add(this.opn_ITEM_CD, 1, 1);
         this.Panel_Doc1.Controls.Add(this.tDateTerm1, 1, 0);
         this.Panel_Doc1.Controls.Add(this.cboTYPE, 5, 0);
         this.Panel_Doc1.Controls.Add(this.btnFind, 5, 1);
         this.Panel_Doc1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.Panel_Doc1.Location = new System.Drawing.Point(3, 3);
         this.Panel_Doc1.Name = "Panel_Doc1";
         this.Panel_Doc1.RowCount = 2;
         this.Panel_Doc1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.Panel_Doc1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.Panel_Doc1.Size = new System.Drawing.Size(967, 74);
         this.Panel_Doc1.TabIndex = 0;
         // 
         // cboFacility
         // 
         this.cboFacility.BackColor = System.Drawing.Color.White;
         this.cboFacility.BorderBackColor = System.Drawing.Color.White;
         this.cboFacility.BorderBottom = true;
         this.cboFacility.BorderColor = System.Drawing.SystemColors.ActiveBorder;
         this.cboFacility.BorderLeft = true;
         this.cboFacility.BorderRight = false;
         this.cboFacility.BorderTop = true;
         this.cboFacility.Caption = "";
         this.cboFacility.DefaultComboType = null;
         this.cboFacility.DisplayCaption = "Code Name";
         this.cboFacility.DisplayMember = "CODE_NM";
         this.cboFacility.Dock = System.Windows.Forms.DockStyle.Fill;
         this.cboFacility.FontSize = 13F;
         this.cboFacility.FontStyle = System.Drawing.FontStyle.Regular;
         this.cboFacility.Location = new System.Drawing.Point(750, 3);
         this.cboFacility.Name = "cboFacility";
         this.cboFacility.PasswordChar = '\0';
         this.cboFacility.SelectedIndex = -1;
         this.cboFacility.SelectedText = "";
         this.cboFacility.SelectionLength = 0;
         this.cboFacility.SelectionStart = 0;
         this.cboFacility.Size = new System.Drawing.Size(214, 31);
         this.cboFacility.TabIndex = 21;
         this.cboFacility.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
         this.cboFacility.TScale = 1F;
         this.cboFacility.Value = "";
         this.cboFacility.ValueCaption = "Code";
         this.cboFacility.ValueMember = "CODE_ID";
         this.cboFacility.ValueName = "";
         this.cboFacility.SelectedValueChanged += new System.EventHandler(this.cboFacility_SelectedValueChanged);
         // 
         // tLabel4
         // 
         this.tLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
         this.tLabel4.Base_FontSize = 13F;
         this.tLabel4.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
         this.tLabel4.BorderBottom = true;
         this.tLabel4.BorderColor = System.Drawing.SystemColors.ActiveBorder;
         this.tLabel4.BorderLeft = true;
         this.tLabel4.BorderRight = true;
         this.tLabel4.BorderTop = true;
         this.tLabel4.Caption = "작업자";
         this.tLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tLabel4.FontSize = 13F;
         this.tLabel4.FontStyle = System.Drawing.FontStyle.Regular;
         this.tLabel4.Location = new System.Drawing.Point(659, 39);
         this.tLabel4.Margin = new System.Windows.Forms.Padding(2);
         this.tLabel4.Name = "tLabel4";
         this.tLabel4.Size = new System.Drawing.Size(86, 33);
         this.tLabel4.TabIndex = 6;
         this.tLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.tLabel4.TScale = 1F;
         this.tLabel4.Value = "작업자";
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
         this.tLabel2.Caption = "설비";
         this.tLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tLabel2.FontSize = 13F;
         this.tLabel2.FontStyle = System.Drawing.FontStyle.Regular;
         this.tLabel2.Location = new System.Drawing.Point(659, 2);
         this.tLabel2.Margin = new System.Windows.Forms.Padding(2);
         this.tLabel2.Name = "tLabel2";
         this.tLabel2.Size = new System.Drawing.Size(86, 33);
         this.tLabel2.TabIndex = 5;
         this.tLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.tLabel2.TScale = 1F;
         this.tLabel2.Value = "설비";
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
         this.tLabel1.Size = new System.Drawing.Size(86, 33);
         this.tLabel1.TabIndex = 0;
         this.tLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.tLabel1.TScale = 1F;
         this.tLabel1.Value = "일자";
         // 
         // tDateTerm1
         // 
         this.tDateTerm1.BorderBottom = false;
         this.tDateTerm1.BorderColor = System.Drawing.SystemColors.Control;
         this.tDateTerm1.BorderLeft = false;
         this.tDateTerm1.BorderRight = false;
         this.tDateTerm1.BorderTop = false;
         this.tDateTerm1.Caption = "Calendar";
         this.Panel_Doc1.SetColumnSpan(this.tDateTerm1, 3);
         this.tDateTerm1.DateDeleteVisible_From = false;
         this.tDateTerm1.DateDeleteVisible_To = false;
         this.tDateTerm1.DateFormat = "yyyy-MM-dd";
         this.tDateTerm1.DefaultValue = "00";
         this.tDateTerm1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tDateTerm1.FontSize = 14.25F;
         this.tDateTerm1.FontStyle = System.Drawing.FontStyle.Regular;
         this.tDateTerm1.Location = new System.Drawing.Point(93, 3);
         this.tDateTerm1.Name = "tDateTerm1";
         this.tDateTerm1.ReadOnly_From = false;
         this.tDateTerm1.ReadOnly_To = false;
         this.tDateTerm1.Required = false;
         this.tDateTerm1.Size = new System.Drawing.Size(323, 31);
         this.tDateTerm1.TabIndex = 4;
         this.tDateTerm1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.tDateTerm1.TScale = 1F;
         this.tDateTerm1.ValueFrom = "2016-01-01";
         this.tDateTerm1.ValueFrom_Datetime = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
         this.tDateTerm1.ValueTo = "2016-01-01";
         this.tDateTerm1.ValueTo_Datetime = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
         // 
         // Panel_Doc2
         // 
         this.Panel_Doc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
         this.Panel_Doc2.ColumnCount = 11;
         this.Panel_Doc2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.090816F));
         this.Panel_Doc2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.090816F));
         this.Panel_Doc2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
         this.Panel_Doc2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.21199F));
         this.Panel_Doc2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.64661F));
         this.Panel_Doc2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.64661F));
         this.Panel_Doc2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
         this.Panel_Doc2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.64989F));
         this.Panel_Doc2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.21991F));
         this.Panel_Doc2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
         this.Panel_Doc2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.44336F));
         this.Panel_Doc2.Controls.Add(this.tButton1, 8, 0);
         this.Panel_Doc2.Controls.Add(this.btn_RESULT_CANCEL, 5, 0);
         this.Panel_Doc2.Controls.Add(this.btn_WorkOrder_Info, 4, 0);
         this.Panel_Doc2.Controls.Add(this.btn_Label_Print, 10, 0);
         this.Panel_Doc2.Controls.Add(this.btn_Bad_Qty_Insert, 7, 0);
         this.Panel_Doc2.Controls.Add(this.btn_Before, 0, 0);
         this.Panel_Doc2.Controls.Add(this.btn_Next, 1, 0);
         this.Panel_Doc2.Controls.Add(this.btn_Query, 3, 0);
         this.Panel_Doc2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.Panel_Doc2.Location = new System.Drawing.Point(3, 604);
         this.Panel_Doc2.Name = "Panel_Doc2";
         this.Panel_Doc2.RowCount = 1;
         this.Panel_Doc2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.Panel_Doc2.Size = new System.Drawing.Size(967, 54);
         this.Panel_Doc2.TabIndex = 1;
         // 
         // tButton1
         // 
         this.tButton1.BackColor = System.Drawing.SystemColors.Control;
         this.tButton1.BorderBackColor = System.Drawing.SystemColors.Control;
         this.tButton1.BorderBottom = true;
         this.tButton1.BorderColor = System.Drawing.SystemColors.Control;
         this.tButton1.BorderColorSelect = System.Drawing.Color.Blue;
         this.tButton1.BorderLeft = true;
         this.tButton1.BorderRight = true;
         this.tButton1.BorderTop = true;
         this.tButton1.BorderWidth = 0;
         this.tButton1.ButtonSelected = false;
         this.tButton1.Caption = "불량집계";
         this.tButton1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tButton1.Font = new System.Drawing.Font("맑은 고딕", 14.25F);
         this.tButton1.FontSize = 14.25F;
         this.tButton1.FontStyle = System.Drawing.FontStyle.Regular;
         this.tButton1.ForeColor = System.Drawing.Color.Black;
         this.tButton1.ForeColorSelect = System.Drawing.Color.Red;
         this.tButton1.IConImage1 = null;
         this.tButton1.IConImage2 = null;
         this.tButton1.IConViewFlag = false;
         this.tButton1.ImageButton = ((System.Drawing.Image)(resources.GetObject("tButton1.ImageButton")));
         this.tButton1.ImageButtonViewFlag = false;
         this.tButton1.Location = new System.Drawing.Point(689, 3);
         this.tButton1.Name = "tButton1";
         this.tButton1.Padding = new System.Windows.Forms.Padding(1);
         this.tButton1.SelectedWidth = 3;
         this.tButton1.Size = new System.Drawing.Size(108, 48);
         this.tButton1.TabIndex = 186;
         this.tButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.tButton1.TScale = 1F;
         this.tButton1.ButtonClick += new System.EventHandler(this.tButton1_ButtonClick);
         // 
         // btn_RESULT_CANCEL
         // 
         this.btn_RESULT_CANCEL.BackColor = System.Drawing.SystemColors.Control;
         this.btn_RESULT_CANCEL.BorderBackColor = System.Drawing.SystemColors.Control;
         this.btn_RESULT_CANCEL.BorderBottom = true;
         this.btn_RESULT_CANCEL.BorderColor = System.Drawing.SystemColors.Control;
         this.btn_RESULT_CANCEL.BorderColorSelect = System.Drawing.Color.Blue;
         this.btn_RESULT_CANCEL.BorderLeft = true;
         this.btn_RESULT_CANCEL.BorderRight = true;
         this.btn_RESULT_CANCEL.BorderTop = true;
         this.btn_RESULT_CANCEL.BorderWidth = 0;
         this.btn_RESULT_CANCEL.ButtonSelected = false;
         this.btn_RESULT_CANCEL.Caption = "실적 취소";
         this.btn_RESULT_CANCEL.Dock = System.Windows.Forms.DockStyle.Fill;
         this.btn_RESULT_CANCEL.Font = new System.Drawing.Font("맑은 고딕", 14.25F);
         this.btn_RESULT_CANCEL.FontSize = 14.25F;
         this.btn_RESULT_CANCEL.FontStyle = System.Drawing.FontStyle.Regular;
         this.btn_RESULT_CANCEL.ForeColor = System.Drawing.Color.Black;
         this.btn_RESULT_CANCEL.ForeColorSelect = System.Drawing.Color.Red;
         this.btn_RESULT_CANCEL.IConImage1 = null;
         this.btn_RESULT_CANCEL.IConImage2 = null;
         this.btn_RESULT_CANCEL.IConViewFlag = false;
         this.btn_RESULT_CANCEL.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_RESULT_CANCEL.ImageButton")));
         this.btn_RESULT_CANCEL.ImageButtonViewFlag = false;
         this.btn_RESULT_CANCEL.Location = new System.Drawing.Point(404, 2);
         this.btn_RESULT_CANCEL.Margin = new System.Windows.Forms.Padding(2);
         this.btn_RESULT_CANCEL.Name = "btn_RESULT_CANCEL";
         this.btn_RESULT_CANCEL.Padding = new System.Windows.Forms.Padding(1);
         this.btn_RESULT_CANCEL.SelectedWidth = 3;
         this.btn_RESULT_CANCEL.Size = new System.Drawing.Size(133, 50);
         this.btn_RESULT_CANCEL.TabIndex = 185;
         this.btn_RESULT_CANCEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btn_RESULT_CANCEL.TScale = 1F;
         this.btn_RESULT_CANCEL.Visible = false;
         this.btn_RESULT_CANCEL.ButtonClick += new System.EventHandler(this.btn_RESULT_CANCEL_ButtonClick);
         // 
         // btn_WorkOrder_Info
         // 
         this.btn_WorkOrder_Info.BackColor = System.Drawing.SystemColors.Control;
         this.btn_WorkOrder_Info.BorderBackColor = System.Drawing.SystemColors.Control;
         this.btn_WorkOrder_Info.BorderBottom = true;
         this.btn_WorkOrder_Info.BorderColor = System.Drawing.SystemColors.Control;
         this.btn_WorkOrder_Info.BorderColorSelect = System.Drawing.Color.Blue;
         this.btn_WorkOrder_Info.BorderLeft = true;
         this.btn_WorkOrder_Info.BorderRight = true;
         this.btn_WorkOrder_Info.BorderTop = true;
         this.btn_WorkOrder_Info.BorderWidth = 0;
         this.btn_WorkOrder_Info.ButtonSelected = false;
         this.btn_WorkOrder_Info.Caption = "지시서 정보";
         this.btn_WorkOrder_Info.Dock = System.Windows.Forms.DockStyle.Fill;
         this.btn_WorkOrder_Info.Font = new System.Drawing.Font("맑은 고딕", 14.25F);
         this.btn_WorkOrder_Info.FontSize = 14.25F;
         this.btn_WorkOrder_Info.FontStyle = System.Drawing.FontStyle.Regular;
         this.btn_WorkOrder_Info.ForeColor = System.Drawing.Color.Black;
         this.btn_WorkOrder_Info.ForeColorSelect = System.Drawing.Color.Red;
         this.btn_WorkOrder_Info.IConImage1 = null;
         this.btn_WorkOrder_Info.IConImage2 = null;
         this.btn_WorkOrder_Info.IConViewFlag = false;
         this.btn_WorkOrder_Info.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_WorkOrder_Info.ImageButton")));
         this.btn_WorkOrder_Info.ImageButtonViewFlag = false;
         this.btn_WorkOrder_Info.Location = new System.Drawing.Point(267, 2);
         this.btn_WorkOrder_Info.Margin = new System.Windows.Forms.Padding(2);
         this.btn_WorkOrder_Info.Name = "btn_WorkOrder_Info";
         this.btn_WorkOrder_Info.Padding = new System.Windows.Forms.Padding(1);
         this.btn_WorkOrder_Info.SelectedWidth = 3;
         this.btn_WorkOrder_Info.Size = new System.Drawing.Size(133, 50);
         this.btn_WorkOrder_Info.TabIndex = 182;
         this.btn_WorkOrder_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btn_WorkOrder_Info.TScale = 1F;
         this.btn_WorkOrder_Info.ButtonClick += new System.EventHandler(this.btn_WorkOrder_Info_ButtonClick);
         // 
         // btn_Label_Print
         // 
         this.btn_Label_Print.BackColor = System.Drawing.SystemColors.Control;
         this.btn_Label_Print.BorderBackColor = System.Drawing.SystemColors.Control;
         this.btn_Label_Print.BorderBottom = true;
         this.btn_Label_Print.BorderColor = System.Drawing.SystemColors.Control;
         this.btn_Label_Print.BorderColorSelect = System.Drawing.Color.Blue;
         this.btn_Label_Print.BorderLeft = true;
         this.btn_Label_Print.BorderRight = true;
         this.btn_Label_Print.BorderTop = true;
         this.btn_Label_Print.BorderWidth = 0;
         this.btn_Label_Print.ButtonSelected = false;
         this.btn_Label_Print.Caption = "바코드 재발행";
         this.btn_Label_Print.Dock = System.Windows.Forms.DockStyle.Fill;
         this.btn_Label_Print.Font = new System.Drawing.Font("맑은 고딕", 14.25F);
         this.btn_Label_Print.FontSize = 14.25F;
         this.btn_Label_Print.FontStyle = System.Drawing.FontStyle.Regular;
         this.btn_Label_Print.ForeColor = System.Drawing.Color.Black;
         this.btn_Label_Print.ForeColorSelect = System.Drawing.Color.Red;
         this.btn_Label_Print.IConImage1 = null;
         this.btn_Label_Print.IConImage2 = null;
         this.btn_Label_Print.IConViewFlag = false;
         this.btn_Label_Print.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Label_Print.ImageButton")));
         this.btn_Label_Print.ImageButtonViewFlag = false;
         this.btn_Label_Print.Location = new System.Drawing.Point(813, 3);
         this.btn_Label_Print.Name = "btn_Label_Print";
         this.btn_Label_Print.Padding = new System.Windows.Forms.Padding(1);
         this.btn_Label_Print.SelectedWidth = 3;
         this.btn_Label_Print.Size = new System.Drawing.Size(151, 48);
         this.btn_Label_Print.TabIndex = 4;
         this.btn_Label_Print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btn_Label_Print.TScale = 1F;
         this.btn_Label_Print.ButtonClick += new System.EventHandler(this.btn_Label_Print_ButtonClick);
         // 
         // btn_Bad_Qty_Insert
         // 
         this.btn_Bad_Qty_Insert.BackColor = System.Drawing.SystemColors.Control;
         this.btn_Bad_Qty_Insert.BorderBackColor = System.Drawing.SystemColors.Control;
         this.btn_Bad_Qty_Insert.BorderBottom = true;
         this.btn_Bad_Qty_Insert.BorderColor = System.Drawing.SystemColors.Control;
         this.btn_Bad_Qty_Insert.BorderColorSelect = System.Drawing.Color.Blue;
         this.btn_Bad_Qty_Insert.BorderLeft = true;
         this.btn_Bad_Qty_Insert.BorderRight = true;
         this.btn_Bad_Qty_Insert.BorderTop = true;
         this.btn_Bad_Qty_Insert.BorderWidth = 0;
         this.btn_Bad_Qty_Insert.ButtonSelected = false;
         this.btn_Bad_Qty_Insert.Caption = "불량등록";
         this.btn_Bad_Qty_Insert.Dock = System.Windows.Forms.DockStyle.Fill;
         this.btn_Bad_Qty_Insert.Font = new System.Drawing.Font("맑은 고딕", 14.25F);
         this.btn_Bad_Qty_Insert.FontSize = 14.25F;
         this.btn_Bad_Qty_Insert.FontStyle = System.Drawing.FontStyle.Regular;
         this.btn_Bad_Qty_Insert.ForeColor = System.Drawing.Color.Black;
         this.btn_Bad_Qty_Insert.ForeColorSelect = System.Drawing.Color.Red;
         this.btn_Bad_Qty_Insert.IConImage1 = null;
         this.btn_Bad_Qty_Insert.IConImage2 = null;
         this.btn_Bad_Qty_Insert.IConViewFlag = false;
         this.btn_Bad_Qty_Insert.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Bad_Qty_Insert.ImageButton")));
         this.btn_Bad_Qty_Insert.ImageButtonViewFlag = false;
         this.btn_Bad_Qty_Insert.Location = new System.Drawing.Point(552, 3);
         this.btn_Bad_Qty_Insert.Name = "btn_Bad_Qty_Insert";
         this.btn_Bad_Qty_Insert.Padding = new System.Windows.Forms.Padding(1);
         this.btn_Bad_Qty_Insert.SelectedWidth = 3;
         this.btn_Bad_Qty_Insert.Size = new System.Drawing.Size(131, 48);
         this.btn_Bad_Qty_Insert.TabIndex = 3;
         this.btn_Bad_Qty_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btn_Bad_Qty_Insert.TScale = 1F;
         this.btn_Bad_Qty_Insert.Visible = false;
         this.btn_Bad_Qty_Insert.ButtonClick += new System.EventHandler(this.btn_Bad_Qty_Insert_ButtonClick);
         // 
         // btn_Before
         // 
         this.btn_Before.BackColor = System.Drawing.SystemColors.Control;
         this.btn_Before.BorderBackColor = System.Drawing.SystemColors.Control;
         this.btn_Before.BorderBottom = true;
         this.btn_Before.BorderColor = System.Drawing.SystemColors.Control;
         this.btn_Before.BorderColorSelect = System.Drawing.Color.Blue;
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
         this.btn_Before.ForeColorSelect = System.Drawing.Color.Red;
         this.btn_Before.IConImage1 = null;
         this.btn_Before.IConImage2 = null;
         this.btn_Before.IConViewFlag = false;
         this.btn_Before.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Before.ImageButton")));
         this.btn_Before.ImageButtonViewFlag = false;
         this.btn_Before.Location = new System.Drawing.Point(3, 3);
         this.btn_Before.Name = "btn_Before";
         this.btn_Before.Padding = new System.Windows.Forms.Padding(1);
         this.btn_Before.SelectedWidth = 3;
         this.btn_Before.Size = new System.Drawing.Size(69, 48);
         this.btn_Before.TabIndex = 0;
         this.btn_Before.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btn_Before.TScale = 1F;
         this.btn_Before.ButtonClick += new System.EventHandler(this.btn_Before_ButtonClick);
         // 
         // btn_Next
         // 
         this.btn_Next.BackColor = System.Drawing.SystemColors.Control;
         this.btn_Next.BorderBackColor = System.Drawing.SystemColors.Control;
         this.btn_Next.BorderBottom = true;
         this.btn_Next.BorderColor = System.Drawing.SystemColors.Control;
         this.btn_Next.BorderColorSelect = System.Drawing.Color.Blue;
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
         this.btn_Next.ForeColorSelect = System.Drawing.Color.Red;
         this.btn_Next.IConImage1 = null;
         this.btn_Next.IConImage2 = null;
         this.btn_Next.IConViewFlag = false;
         this.btn_Next.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Next.ImageButton")));
         this.btn_Next.ImageButtonViewFlag = false;
         this.btn_Next.Location = new System.Drawing.Point(78, 3);
         this.btn_Next.Name = "btn_Next";
         this.btn_Next.Padding = new System.Windows.Forms.Padding(1);
         this.btn_Next.SelectedWidth = 3;
         this.btn_Next.Size = new System.Drawing.Size(69, 48);
         this.btn_Next.TabIndex = 1;
         this.btn_Next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btn_Next.TScale = 1F;
         this.btn_Next.ButtonClick += new System.EventHandler(this.btn_Next_ButtonClick);
         // 
         // btn_Query
         // 
         this.btn_Query.BackColor = System.Drawing.SystemColors.Control;
         this.btn_Query.BorderBackColor = System.Drawing.SystemColors.Control;
         this.btn_Query.BorderBottom = true;
         this.btn_Query.BorderColor = System.Drawing.SystemColors.Control;
         this.btn_Query.BorderColorSelect = System.Drawing.Color.Blue;
         this.btn_Query.BorderLeft = true;
         this.btn_Query.BorderRight = true;
         this.btn_Query.BorderTop = true;
         this.btn_Query.BorderWidth = 0;
         this.btn_Query.ButtonSelected = false;
         this.btn_Query.Caption = "조회";
         this.btn_Query.Dock = System.Windows.Forms.DockStyle.Fill;
         this.btn_Query.Font = new System.Drawing.Font("맑은 고딕", 14.25F);
         this.btn_Query.FontSize = 14.25F;
         this.btn_Query.FontStyle = System.Drawing.FontStyle.Regular;
         this.btn_Query.ForeColor = System.Drawing.Color.Black;
         this.btn_Query.ForeColorSelect = System.Drawing.Color.Red;
         this.btn_Query.IConImage1 = null;
         this.btn_Query.IConImage2 = null;
         this.btn_Query.IConViewFlag = false;
         this.btn_Query.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Query.ImageButton")));
         this.btn_Query.ImageButtonViewFlag = false;
         this.btn_Query.Location = new System.Drawing.Point(163, 3);
         this.btn_Query.Name = "btn_Query";
         this.btn_Query.Padding = new System.Windows.Forms.Padding(1);
         this.btn_Query.SelectedWidth = 3;
         this.btn_Query.Size = new System.Drawing.Size(99, 48);
         this.btn_Query.TabIndex = 2;
         this.btn_Query.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btn_Query.TScale = 1F;
         this.btn_Query.ButtonClick += new System.EventHandler(this.btn_Query_ButtonClick);
         // 
         // tableLayoutPanel2
         // 
         this.tableLayoutPanel2.ColumnCount = 1;
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel2.Controls.Add(this.tLabel14, 0, 1);
         this.tableLayoutPanel2.Controls.Add(this.Grid2, 0, 2);
         this.tableLayoutPanel2.Controls.Add(this.Grid1, 0, 0);
         this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 80);
         this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
         this.tableLayoutPanel2.Name = "tableLayoutPanel2";
         this.tableLayoutPanel2.RowCount = 3;
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel2.Size = new System.Drawing.Size(967, 521);
         this.tableLayoutPanel2.TabIndex = 2;
         // 
         // tLabel14
         // 
         this.tLabel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
         this.tLabel14.Base_FontSize = 13F;
         this.tLabel14.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
         this.tLabel14.BorderBottom = true;
         this.tLabel14.BorderColor = System.Drawing.SystemColors.ActiveBorder;
         this.tLabel14.BorderLeft = true;
         this.tLabel14.BorderRight = true;
         this.tLabel14.BorderTop = true;
         this.tLabel14.Caption = "LOT 별 상세 내역";
         this.tLabel14.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tLabel14.FontSize = 13F;
         this.tLabel14.FontStyle = System.Drawing.FontStyle.Regular;
         this.tLabel14.Location = new System.Drawing.Point(2, 250);
         this.tLabel14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
         this.tLabel14.Name = "tLabel14";
         this.tLabel14.Size = new System.Drawing.Size(963, 23);
         this.tLabel14.TabIndex = 53;
         this.tLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.tLabel14.TScale = 1F;
         this.tLabel14.Value = "LOT 별 상세 내역";
         // 
         // Grid2
         // 
         this.Grid2.AllowUserToAddRows = false;
         this.Grid2.AllowUserToDeleteRows = false;
         this.Grid2.AllowUserToResizeRows = false;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.Grid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
         this.Grid2.BackgroundColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.Grid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
         this.Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
         dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.Grid2.DefaultCellStyle = dataGridViewCellStyle3;
         this.Grid2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.Grid2.Location = new System.Drawing.Point(2, 275);
         this.Grid2.Margin = new System.Windows.Forms.Padding(2);
         this.Grid2.MultiSelect = false;
         this.Grid2.Name = "Grid2";
         this.Grid2.ReadOnly = true;
         dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.Grid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
         dataGridViewCellStyle5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.Grid2.RowsDefaultCellStyle = dataGridViewCellStyle5;
         this.Grid2.RowTemplate.Height = 42;
         this.Grid2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.Grid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.Grid2.Size = new System.Drawing.Size(963, 244);
         this.Grid2.TabIndex = 52;
         this.Grid2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid2_CellClick);
         this.Grid2.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid2_CellMouseUp);
         this.Grid2.Enter += new System.EventHandler(this.Grid2_Enter);
         // 
         // Grid1
         // 
         this.Grid1.AllowUserToAddRows = false;
         this.Grid1.AllowUserToDeleteRows = false;
         this.Grid1.AllowUserToResizeRows = false;
         dataGridViewCellStyle6.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.Grid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
         this.Grid1.BackgroundColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle7.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.Grid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
         this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle8.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
         dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.Grid1.DefaultCellStyle = dataGridViewCellStyle8;
         this.Grid1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.Grid1.Location = new System.Drawing.Point(2, 2);
         this.Grid1.Margin = new System.Windows.Forms.Padding(2);
         this.Grid1.MultiSelect = false;
         this.Grid1.Name = "Grid1";
         this.Grid1.ReadOnly = true;
         dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.Grid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
         dataGridViewCellStyle10.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.Grid1.RowsDefaultCellStyle = dataGridViewCellStyle10;
         this.Grid1.RowTemplate.Height = 42;
         this.Grid1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.Grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.Grid1.Size = new System.Drawing.Size(963, 244);
         this.Grid1.TabIndex = 51;
         this.Grid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid1_CellClick);
         this.Grid1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid1_CellMouseUp);
         this.Grid1.Enter += new System.EventHandler(this.Grid1_Enter);
         // 
         // printPreviewDialog1
         // 
         this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
         this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
         this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
         this.printPreviewDialog1.Document = this.printDocument1;
         this.printPreviewDialog1.Enabled = true;
         this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
         this.printPreviewDialog1.Name = "printPreviewDialog1";
         this.printPreviewDialog1.Visible = false;
         // 
         // printDocument1
         // 
         this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
         this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
         this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
         // 
         // pageSetupDialog1
         // 
         this.pageSetupDialog1.Document = this.printDocument1;
         // 
         // printDialog1
         // 
         this.printDialog1.Document = this.printDocument1;
         this.printDialog1.UseEXDialog = true;
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
         this.cboWorker.Location = new System.Drawing.Point(750, 40);
         this.cboWorker.Name = "cboWorker";
         this.cboWorker.PasswordChar = '\0';
         this.cboWorker.SelectedIndex = -1;
         this.cboWorker.SelectedText = "";
         this.cboWorker.SelectionLength = 0;
         this.cboWorker.SelectionStart = 0;
         this.cboWorker.Size = new System.Drawing.Size(214, 31);
         this.cboWorker.TabIndex = 20;
         this.cboWorker.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
         this.cboWorker.TScale = 1F;
         this.cboWorker.Value = "";
         this.cboWorker.ValueCaption = "Code";
         this.cboWorker.ValueMember = "CODE_ID";
         this.cboWorker.ValueName = "";
         this.cboWorker.SelectedValueChanged += new System.EventHandler(this.cboWorker_SelectedValueChanged);
         // 
         // cboTYPE
         // 
         this.cboTYPE.BackColor = System.Drawing.Color.White;
         this.cboTYPE.BorderBackColor = System.Drawing.Color.White;
         this.cboTYPE.BorderBottom = true;
         this.cboTYPE.BorderColor = System.Drawing.SystemColors.ActiveBorder;
         this.cboTYPE.BorderLeft = true;
         this.cboTYPE.BorderRight = false;
         this.cboTYPE.BorderTop = true;
         this.cboTYPE.Caption = "";
         this.cboTYPE.DefaultComboType = null;
         this.cboTYPE.DisplayCaption = "Code Name";
         this.cboTYPE.DisplayMember = "CODE_NM";
         this.cboTYPE.Dock = System.Windows.Forms.DockStyle.Fill;
         this.cboTYPE.FontSize = 13F;
         this.cboTYPE.FontStyle = System.Drawing.FontStyle.Regular;
         this.cboTYPE.Location = new System.Drawing.Point(500, 3);
         this.cboTYPE.Name = "cboTYPE";
         this.cboTYPE.PasswordChar = '\0';
         this.cboTYPE.SelectedIndex = -1;
         this.cboTYPE.SelectedText = "";
         this.cboTYPE.SelectionLength = 0;
         this.cboTYPE.SelectionStart = 0;
         this.cboTYPE.Size = new System.Drawing.Size(134, 31);
         this.cboTYPE.TabIndex = 22;
         this.cboTYPE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
         this.cboTYPE.TScale = 1F;
         this.cboTYPE.Value = "";
         this.cboTYPE.ValueCaption = "Code";
         this.cboTYPE.ValueMember = "CODE_ID";
         this.cboTYPE.ValueName = "";
         this.cboTYPE.SelectedValueChanged += new System.EventHandler(this.cboTYPE_SelectedValueChanged);
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
         this.tLabel5.Caption = "구분";
         this.tLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tLabel5.FontSize = 13F;
         this.tLabel5.FontStyle = System.Drawing.FontStyle.Regular;
         this.tLabel5.Location = new System.Drawing.Point(421, 2);
         this.tLabel5.Margin = new System.Windows.Forms.Padding(2);
         this.tLabel5.Name = "tLabel5";
         this.tLabel5.Size = new System.Drawing.Size(74, 33);
         this.tLabel5.TabIndex = 1;
         this.tLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.tLabel5.TScale = 1F;
         this.tLabel5.Value = "구분";
         // 
         // btnFind
         // 
         this.btnFind.BackColor = System.Drawing.SystemColors.Control;
         this.btnFind.BorderBackColor = System.Drawing.SystemColors.Control;
         this.btnFind.BorderBottom = true;
         this.btnFind.BorderColor = System.Drawing.SystemColors.Control;
         this.btnFind.BorderColorSelect = System.Drawing.Color.Blue;
         this.btnFind.BorderLeft = true;
         this.btnFind.BorderRight = true;
         this.btnFind.BorderTop = true;
         this.btnFind.BorderWidth = 0;
         this.btnFind.ButtonSelected = false;
         this.btnFind.Caption = "품번검색";
         this.btnFind.Dock = System.Windows.Forms.DockStyle.Fill;
         this.btnFind.Font = new System.Drawing.Font("맑은 고딕", 12F);
         this.btnFind.FontSize = 12F;
         this.btnFind.FontStyle = System.Drawing.FontStyle.Regular;
         this.btnFind.ForeColor = System.Drawing.Color.Black;
         this.btnFind.ForeColorSelect = System.Drawing.Color.Red;
         this.btnFind.IConImage1 = null;
         this.btnFind.IConImage2 = null;
         this.btnFind.IConViewFlag = false;
         this.btnFind.ImageButton = ((System.Drawing.Image)(resources.GetObject("btnFind.ImageButton")));
         this.btnFind.ImageButtonViewFlag = false;
         this.btnFind.Location = new System.Drawing.Point(499, 39);
         this.btnFind.Margin = new System.Windows.Forms.Padding(2);
         this.btnFind.Name = "btnFind";
         this.btnFind.Padding = new System.Windows.Forms.Padding(1);
         this.btnFind.SelectedWidth = 3;
         this.btnFind.Size = new System.Drawing.Size(136, 33);
         this.btnFind.TabIndex = 63;
         this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btnFind.TScale = 1F;
         this.btnFind.ButtonClick += new System.EventHandler(this.btnFind_ButtonClick);
         // 
         // tLabel3
         // 
         this.tLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
         this.tLabel3.Base_FontSize = 13F;
         this.tLabel3.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
         this.tLabel3.BorderBottom = true;
         this.tLabel3.BorderColor = System.Drawing.SystemColors.ActiveBorder;
         this.tLabel3.BorderLeft = true;
         this.tLabel3.BorderRight = true;
         this.tLabel3.BorderTop = true;
         this.tLabel3.Caption = "품번";
         this.tLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tLabel3.FontSize = 13F;
         this.tLabel3.FontStyle = System.Drawing.FontStyle.Regular;
         this.tLabel3.Location = new System.Drawing.Point(2, 39);
         this.tLabel3.Margin = new System.Windows.Forms.Padding(2);
         this.tLabel3.Name = "tLabel3";
         this.tLabel3.Size = new System.Drawing.Size(86, 33);
         this.tLabel3.TabIndex = 2;
         this.tLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.tLabel3.TScale = 1F;
         this.tLabel3.Value = "품번";
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
         this.Panel_Doc1.SetColumnSpan(this.opn_ITEM_CD, 4);
         this.opn_ITEM_CD.CommonCD = "";
         this.opn_ITEM_CD.DefaultPopup = "TEXT";
         this.opn_ITEM_CD.Dock = System.Windows.Forms.DockStyle.Fill;
         this.opn_ITEM_CD.FontSize = 13F;
         this.opn_ITEM_CD.FontStyle = System.Drawing.FontStyle.Regular;
         this.opn_ITEM_CD.Location = new System.Drawing.Point(93, 40);
         this.opn_ITEM_CD.Name = "opn_ITEM_CD";
         this.opn_ITEM_CD.PasswordChar = '\0';
         this.opn_ITEM_CD.ReadOnly = false;
         this.opn_ITEM_CD.Required = false;
         this.opn_ITEM_CD.SelectedText = "";
         this.opn_ITEM_CD.SelectionLength = 0;
         this.opn_ITEM_CD.SelectionStart = 0;
         this.opn_ITEM_CD.Size = new System.Drawing.Size(401, 31);
         this.opn_ITEM_CD.TabIndex = 3;
         this.opn_ITEM_CD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
         this.opn_ITEM_CD.TextColor = System.Drawing.SystemColors.ControlText;
         this.opn_ITEM_CD.TextNameColor = System.Drawing.SystemColors.ControlText;
         this.opn_ITEM_CD.TScale = 1F;
         this.opn_ITEM_CD.Value = "";
         this.opn_ITEM_CD.Value_Visible = true;
         this.opn_ITEM_CD.ValueName = "";
         this.opn_ITEM_CD.ValueName_Visible = true;
         this.opn_ITEM_CD.ValueName_Visuble = true;
         this.opn_ITEM_CD.OpenPopup += new System.EventHandler(this.opn_ITEM_CD_OpenPopup);
         this.opn_ITEM_CD.ValueChanged += new System.EventHandler(this.opn_ITEM_CD_ValueChanged);
         // 
         // APP_P9003MA1
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         this.Controls.Add(this.Panel_Doc);
         this.Name = "APP_P9003MA1";
         this.Size = new System.Drawing.Size(973, 661);
         this.Resize += new System.EventHandler(this.APP_P3101Q1_Resize);
         this.Panel_Doc.ResumeLayout(false);
         this.Panel_Doc1.ResumeLayout(false);
         this.Panel_Doc2.ResumeLayout(false);
         this.tableLayoutPanel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.Grid2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Panel_Doc;
        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.TableLayoutPanel Panel_Doc1;
        private TGSControl.TCombo cboFacility;
        private TGSControl.TLabel tLabel4;
        private TGSControl.TLabel tLabel2;
        private TGSControl.TLabel tLabel1;
        private TGSControl.TDateTerm tDateTerm1;
        private System.Windows.Forms.TableLayoutPanel Panel_Doc2;
        private TGSControl.TButton btn_Before;
        private TGSControl.TButton btn_Next;
        private TGSControl.TButton btn_Query;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView Grid2;
        private TGSControl.TLabel tLabel14;
        private TGSControl.TButton btn_Label_Print;
        private TGSControl.TButton btn_Bad_Qty_Insert;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private TGSControl.TButton btn_WorkOrder_Info;
        private TGSControl.TButton btn_RESULT_CANCEL;
        private TGSControl.TButton tButton1;
      private TGSControl.TLabel tLabel5;
      private TGSControl.TCombo cboWorker;
      private TGSControl.TLabel tLabel3;
      private TGSControl.TOpenPopup opn_ITEM_CD;
      private TGSControl.TCombo cboTYPE;
      private TGSControl.TButton btnFind;
   }
}
