namespace MES_APP_P90
{
    partial class APP_P9001MA1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APP_P9001MA1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_Doc = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Cmd = new System.Windows.Forms.TableLayoutPanel();
            this.btn_DailyCheck = new TGSControl.TButton2();
            this.btn_WorkOrder_Info = new TGSControl.TButton2();
            this.btn_StandardSheet = new TGSControl.TButton2();
            this.btn_Unwork = new TGSControl.TButton2();
            this.btn_WorkStart = new TGSControl.TButton2();
            this.btn_Next = new TGSControl.TButton2();
            this.btn_Query = new TGSControl.TButton2();
            this.btn_Before = new TGSControl.TButton2();
            this.Panel_Doc12 = new System.Windows.Forms.TableLayoutPanel();
            this.tLabel3 = new TGSControl.TLabel();
            this.tLabel1 = new TGSControl.TLabel();
            this.Panel_Condition = new System.Windows.Forms.TableLayoutPanel();
            this.lblWROrderCount = new System.Windows.Forms.Label();
            this.btnFind = new TGSControl.TButton2();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tCheckBox2 = new TGSControl.TCheckBox();
            this.tCheckBox1 = new TGSControl.TCheckBox();
            this.opn_ITEM_CD = new TGSControl.TOpenCombo();
            this.Panel_Doc11 = new System.Windows.Forms.TableLayoutPanel();
            this.opn_FA_CD = new TGSControl.TOpenPopup();
            this.tLabel5 = new TGSControl.TLabel();
            this.tLabel4 = new TGSControl.TLabel();
            this.tLabel2 = new TGSControl.TLabel();
            this.lbl_WorkCenterNm = new TGSControl.TLabel();
            this.cboWorker = new TGSControl.TCombo();
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.lblMiWorkQty = new TGSControl.TLabel();
            this.Panel_Doc.SuspendLayout();
            this.Panel_Cmd.SuspendLayout();
            this.Panel_Doc12.SuspendLayout();
            this.Panel_Condition.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Panel_Doc11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Doc
            // 
            this.Panel_Doc.ColumnCount = 1;
            this.Panel_Doc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Doc.Controls.Add(this.Panel_Cmd, 0, 3);
            this.Panel_Doc.Controls.Add(this.Panel_Doc12, 0, 1);
            this.Panel_Doc.Controls.Add(this.Panel_Doc11, 0, 0);
            this.Panel_Doc.Controls.Add(this.Grid1, 0, 2);
            this.Panel_Doc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Doc.Location = new System.Drawing.Point(0, 0);
            this.Panel_Doc.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Doc.Name = "Panel_Doc";
            this.Panel_Doc.RowCount = 4;
            this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.Panel_Doc.Size = new System.Drawing.Size(1024, 604);
            this.Panel_Doc.TabIndex = 2;
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
            this.Panel_Cmd.Controls.Add(this.btn_DailyCheck, 10, 0);
            this.Panel_Cmd.Controls.Add(this.btn_WorkOrder_Info, 4, 0);
            this.Panel_Cmd.Controls.Add(this.btn_StandardSheet, 5, 0);
            this.Panel_Cmd.Controls.Add(this.btn_Unwork, 9, 0);
            this.Panel_Cmd.Controls.Add(this.btn_WorkStart, 7, 0);
            this.Panel_Cmd.Controls.Add(this.btn_Next, 1, 0);
            this.Panel_Cmd.Controls.Add(this.btn_Query, 3, 0);
            this.Panel_Cmd.Controls.Add(this.btn_Before, 0, 0);
            this.Panel_Cmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Cmd.Location = new System.Drawing.Point(0, 544);
            this.Panel_Cmd.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Cmd.Name = "Panel_Cmd";
            this.Panel_Cmd.RowCount = 1;
            this.Panel_Cmd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Cmd.Size = new System.Drawing.Size(1024, 60);
            this.Panel_Cmd.TabIndex = 49;
            // 
            // btn_DailyCheck
            // 
            this.btn_DailyCheck.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DailyCheck.Base_FontSize = 13F;
            this.btn_DailyCheck.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_DailyCheck.BorderBottom = true;
            this.btn_DailyCheck.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_DailyCheck.BorderColorSelect = System.Drawing.Color.Blue;
            this.btn_DailyCheck.BorderLeft = true;
            this.btn_DailyCheck.BorderRight = true;
            this.btn_DailyCheck.BorderTop = true;
            this.btn_DailyCheck.BorderWidth = 0;
            this.btn_DailyCheck.ButtonSelected = false;
            this.btn_DailyCheck.ButtonType = "Success";
            this.btn_DailyCheck.Caption = "설비일상점검";
            this.btn_DailyCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_DailyCheck.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.btn_DailyCheck.FontSize = 13F;
            this.btn_DailyCheck.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_DailyCheck.ForeColor = System.Drawing.Color.White;
            this.btn_DailyCheck.ForeColorSelect = System.Drawing.Color.Red;
            this.btn_DailyCheck.IConImage1 = null;
            this.btn_DailyCheck.IConImage2 = null;
            this.btn_DailyCheck.IConViewFlag = false;
            this.btn_DailyCheck.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_DailyCheck.ImageButton")));
            this.btn_DailyCheck.ImageButtonViewFlag = false;
            this.btn_DailyCheck.Location = new System.Drawing.Point(872, 2);
            this.btn_DailyCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DailyCheck.Name = "btn_DailyCheck";
            this.btn_DailyCheck.Padding = new System.Windows.Forms.Padding(1);
            this.btn_DailyCheck.SelectedWidth = 3;
            this.btn_DailyCheck.Size = new System.Drawing.Size(150, 56);
            this.btn_DailyCheck.TabIndex = 182;
            this.btn_DailyCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_DailyCheck.TScale = 1F;
            this.btn_DailyCheck.ButtonClick += new System.EventHandler(this.btn_DailyCheck_ButtonClick);
            this.btn_DailyCheck.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_DailyCheck_MouseClick);
            // 
            // btn_WorkOrder_Info
            // 
            this.btn_WorkOrder_Info.BackColor = System.Drawing.SystemColors.Control;
            this.btn_WorkOrder_Info.Base_FontSize = 13F;
            this.btn_WorkOrder_Info.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_WorkOrder_Info.BorderBottom = true;
            this.btn_WorkOrder_Info.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_WorkOrder_Info.BorderColorSelect = System.Drawing.Color.Blue;
            this.btn_WorkOrder_Info.BorderLeft = true;
            this.btn_WorkOrder_Info.BorderRight = true;
            this.btn_WorkOrder_Info.BorderTop = true;
            this.btn_WorkOrder_Info.BorderWidth = 0;
            this.btn_WorkOrder_Info.ButtonSelected = false;
            this.btn_WorkOrder_Info.ButtonType = "Info";
            this.btn_WorkOrder_Info.Caption = "지시서 정보";
            this.btn_WorkOrder_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_WorkOrder_Info.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.btn_WorkOrder_Info.FontSize = 13F;
            this.btn_WorkOrder_Info.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_WorkOrder_Info.ForeColor = System.Drawing.Color.White;
            this.btn_WorkOrder_Info.ForeColorSelect = System.Drawing.Color.Red;
            this.btn_WorkOrder_Info.IConImage1 = null;
            this.btn_WorkOrder_Info.IConImage2 = null;
            this.btn_WorkOrder_Info.IConViewFlag = false;
            this.btn_WorkOrder_Info.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_WorkOrder_Info.ImageButton")));
            this.btn_WorkOrder_Info.ImageButtonViewFlag = false;
            this.btn_WorkOrder_Info.Location = new System.Drawing.Point(252, 2);
            this.btn_WorkOrder_Info.Margin = new System.Windows.Forms.Padding(2);
            this.btn_WorkOrder_Info.Name = "btn_WorkOrder_Info";
            this.btn_WorkOrder_Info.Padding = new System.Windows.Forms.Padding(1);
            this.btn_WorkOrder_Info.SelectedWidth = 3;
            this.btn_WorkOrder_Info.Size = new System.Drawing.Size(146, 56);
            this.btn_WorkOrder_Info.TabIndex = 181;
            this.btn_WorkOrder_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_WorkOrder_Info.TScale = 1F;
            this.btn_WorkOrder_Info.ButtonClick += new System.EventHandler(this.btn_WorkOrder_Info_ButtonClick);
            this.btn_WorkOrder_Info.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_WorkOrder_Info_MouseClick);
            // 
            // btn_StandardSheet
            // 
            this.btn_StandardSheet.BackColor = System.Drawing.SystemColors.Control;
            this.btn_StandardSheet.Base_FontSize = 13F;
            this.btn_StandardSheet.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_StandardSheet.BorderBottom = true;
            this.btn_StandardSheet.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_StandardSheet.BorderColorSelect = System.Drawing.Color.Blue;
            this.btn_StandardSheet.BorderLeft = true;
            this.btn_StandardSheet.BorderRight = true;
            this.btn_StandardSheet.BorderTop = true;
            this.btn_StandardSheet.BorderWidth = 0;
            this.btn_StandardSheet.ButtonSelected = false;
            this.btn_StandardSheet.ButtonType = "Info";
            this.btn_StandardSheet.Caption = "작업지시서";
            this.btn_StandardSheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_StandardSheet.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.btn_StandardSheet.FontSize = 13F;
            this.btn_StandardSheet.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_StandardSheet.ForeColor = System.Drawing.Color.White;
            this.btn_StandardSheet.ForeColorSelect = System.Drawing.Color.Red;
            this.btn_StandardSheet.IConImage1 = null;
            this.btn_StandardSheet.IConImage2 = null;
            this.btn_StandardSheet.IConViewFlag = false;
            this.btn_StandardSheet.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_StandardSheet.ImageButton")));
            this.btn_StandardSheet.ImageButtonViewFlag = false;
            this.btn_StandardSheet.Location = new System.Drawing.Point(402, 2);
            this.btn_StandardSheet.Margin = new System.Windows.Forms.Padding(2);
            this.btn_StandardSheet.Name = "btn_StandardSheet";
            this.btn_StandardSheet.Padding = new System.Windows.Forms.Padding(1);
            this.btn_StandardSheet.SelectedWidth = 3;
            this.btn_StandardSheet.Size = new System.Drawing.Size(146, 56);
            this.btn_StandardSheet.TabIndex = 180;
            this.btn_StandardSheet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_StandardSheet.TScale = 1F;
            this.btn_StandardSheet.ButtonClick += new System.EventHandler(this.btn_StandardSheet_ButtonClick);
            this.btn_StandardSheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_StandardSheet_MouseClick);
            // 
            // btn_Unwork
            // 
            this.btn_Unwork.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Unwork.Base_FontSize = 13F;
            this.btn_Unwork.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_Unwork.BorderBottom = true;
            this.btn_Unwork.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_Unwork.BorderColorSelect = System.Drawing.Color.Blue;
            this.btn_Unwork.BorderLeft = true;
            this.btn_Unwork.BorderRight = true;
            this.btn_Unwork.BorderTop = true;
            this.btn_Unwork.BorderWidth = 0;
            this.btn_Unwork.ButtonSelected = false;
            this.btn_Unwork.ButtonType = "Warning";
            this.btn_Unwork.Caption = "비가동등록";
            this.btn_Unwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Unwork.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.btn_Unwork.FontSize = 13F;
            this.btn_Unwork.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_Unwork.ForeColor = System.Drawing.Color.White;
            this.btn_Unwork.ForeColorSelect = System.Drawing.Color.Red;
            this.btn_Unwork.IConImage1 = null;
            this.btn_Unwork.IConImage2 = null;
            this.btn_Unwork.IConViewFlag = false;
            this.btn_Unwork.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Unwork.ImageButton")));
            this.btn_Unwork.ImageButtonViewFlag = false;
            this.btn_Unwork.Location = new System.Drawing.Point(722, 2);
            this.btn_Unwork.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Unwork.Name = "btn_Unwork";
            this.btn_Unwork.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Unwork.SelectedWidth = 3;
            this.btn_Unwork.Size = new System.Drawing.Size(146, 56);
            this.btn_Unwork.TabIndex = 16;
            this.btn_Unwork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Unwork.TScale = 1F;
            this.btn_Unwork.ButtonClick += new System.EventHandler(this.btn_Unwork_Click);
            this.btn_Unwork.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Unwork_MouseClick);
            // 
            // btn_WorkStart
            // 
            this.btn_WorkStart.BackColor = System.Drawing.SystemColors.Control;
            this.btn_WorkStart.Base_FontSize = 13F;
            this.btn_WorkStart.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_WorkStart.BorderBottom = true;
            this.btn_WorkStart.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_WorkStart.BorderColorSelect = System.Drawing.Color.Blue;
            this.btn_WorkStart.BorderLeft = false;
            this.btn_WorkStart.BorderRight = false;
            this.btn_WorkStart.BorderTop = false;
            this.btn_WorkStart.BorderWidth = 0;
            this.btn_WorkStart.ButtonSelected = false;
            this.btn_WorkStart.ButtonType = "Primary";
            this.btn_WorkStart.Caption = "작업시작";
            this.btn_WorkStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_WorkStart.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.btn_WorkStart.FontSize = 13F;
            this.btn_WorkStart.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_WorkStart.ForeColor = System.Drawing.Color.White;
            this.btn_WorkStart.ForeColorSelect = System.Drawing.Color.Red;
            this.btn_WorkStart.IConImage1 = null;
            this.btn_WorkStart.IConImage2 = null;
            this.btn_WorkStart.IConViewFlag = false;
            this.btn_WorkStart.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_WorkStart.ImageButton")));
            this.btn_WorkStart.ImageButtonViewFlag = false;
            this.btn_WorkStart.Location = new System.Drawing.Point(562, 2);
            this.btn_WorkStart.Margin = new System.Windows.Forms.Padding(2);
            this.btn_WorkStart.Name = "btn_WorkStart";
            this.btn_WorkStart.Padding = new System.Windows.Forms.Padding(1);
            this.btn_WorkStart.SelectedWidth = 3;
            this.btn_WorkStart.Size = new System.Drawing.Size(146, 56);
            this.btn_WorkStart.TabIndex = 15;
            this.btn_WorkStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_WorkStart.TScale = 1F;
            this.btn_WorkStart.ButtonClick += new System.EventHandler(this.btn_WorkStart_Click);
            this.btn_WorkStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_WorkStart_MouseClick);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Next.Base_FontSize = 13F;
            this.btn_Next.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_Next.BorderBottom = true;
            this.btn_Next.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_Next.BorderColorSelect = System.Drawing.Color.Blue;
            this.btn_Next.BorderLeft = true;
            this.btn_Next.BorderRight = true;
            this.btn_Next.BorderTop = true;
            this.btn_Next.BorderWidth = 0;
            this.btn_Next.ButtonSelected = false;
            this.btn_Next.ButtonType = "Default";
            this.btn_Next.Caption = "다음";
            this.btn_Next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Next.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.btn_Next.FontSize = 13F;
            this.btn_Next.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_Next.ForeColor = System.Drawing.Color.Black;
            this.btn_Next.ForeColorSelect = System.Drawing.Color.Red;
            this.btn_Next.IConImage1 = null;
            this.btn_Next.IConImage2 = null;
            this.btn_Next.IConViewFlag = false;
            this.btn_Next.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Next.ImageButton")));
            this.btn_Next.ImageButtonViewFlag = false;
            this.btn_Next.Location = new System.Drawing.Point(82, 2);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Next.SelectedWidth = 3;
            this.btn_Next.Size = new System.Drawing.Size(76, 56);
            this.btn_Next.TabIndex = 179;
            this.btn_Next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Next.TScale = 1F;
            this.btn_Next.ButtonClick += new System.EventHandler(this.btn_Next_ButtonClick);
            this.btn_Next.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Next_MouseClick);
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
            this.btn_Query.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.btn_Query.Location = new System.Drawing.Point(172, 2);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Query.SelectedWidth = 3;
            this.btn_Query.Size = new System.Drawing.Size(76, 56);
            this.btn_Query.TabIndex = 17;
            this.btn_Query.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Query.TScale = 1F;
            this.btn_Query.ButtonClick += new System.EventHandler(this.btn_Query_Click);
            this.btn_Query.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Query_MouseClick);
            // 
            // btn_Before
            // 
            this.btn_Before.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Before.Base_FontSize = 13F;
            this.btn_Before.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_Before.BorderBottom = true;
            this.btn_Before.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_Before.BorderColorSelect = System.Drawing.Color.Blue;
            this.btn_Before.BorderLeft = true;
            this.btn_Before.BorderRight = true;
            this.btn_Before.BorderTop = true;
            this.btn_Before.BorderWidth = 0;
            this.btn_Before.ButtonSelected = false;
            this.btn_Before.ButtonType = "Default";
            this.btn_Before.Caption = "이전";
            this.btn_Before.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Before.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.btn_Before.FontSize = 13F;
            this.btn_Before.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_Before.ForeColor = System.Drawing.Color.Black;
            this.btn_Before.ForeColorSelect = System.Drawing.Color.Red;
            this.btn_Before.IConImage1 = null;
            this.btn_Before.IConImage2 = null;
            this.btn_Before.IConViewFlag = false;
            this.btn_Before.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Before.ImageButton")));
            this.btn_Before.ImageButtonViewFlag = false;
            this.btn_Before.Location = new System.Drawing.Point(2, 2);
            this.btn_Before.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Before.Name = "btn_Before";
            this.btn_Before.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Before.SelectedWidth = 3;
            this.btn_Before.Size = new System.Drawing.Size(76, 56);
            this.btn_Before.TabIndex = 178;
            this.btn_Before.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Before.TScale = 1F;
            this.btn_Before.ButtonClick += new System.EventHandler(this.btn_Before_ButtonClick);
            this.btn_Before.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Before_MouseClick);
            // 
            // Panel_Doc12
            // 
            this.Panel_Doc12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.Panel_Doc12.ColumnCount = 8;
            this.Panel_Doc12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.Panel_Doc12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.Panel_Doc12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.Panel_Doc12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.Panel_Doc12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.Panel_Doc12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.Panel_Doc12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.Panel_Doc12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.Panel_Doc12.Controls.Add(this.tLabel3, 6, 0);
            this.Panel_Doc12.Controls.Add(this.tLabel1, 0, 0);
            this.Panel_Doc12.Controls.Add(this.Panel_Condition, 4, 0);
            this.Panel_Doc12.Controls.Add(this.tableLayoutPanel1, 7, 0);
            this.Panel_Doc12.Controls.Add(this.opn_ITEM_CD, 1, 0);
            this.Panel_Doc12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Doc12.Location = new System.Drawing.Point(3, 46);
            this.Panel_Doc12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Panel_Doc12.Name = "Panel_Doc12";
            this.Panel_Doc12.RowCount = 1;
            this.Panel_Doc12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Doc12.Size = new System.Drawing.Size(1018, 40);
            this.Panel_Doc12.TabIndex = 48;
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
            this.tLabel3.Caption = "상태";
            this.tLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLabel3.FontSize = 13F;
            this.tLabel3.FontStyle = System.Drawing.FontStyle.Regular;
            this.tLabel3.Location = new System.Drawing.Point(691, 2);
            this.tLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.tLabel3.Name = "tLabel3";
            this.tLabel3.Size = new System.Drawing.Size(86, 36);
            this.tLabel3.TabIndex = 21;
            this.tLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tLabel3.TScale = 1F;
            this.tLabel3.Value = "상태";
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
            this.tLabel1.Caption = "품번/롯트검색";
            this.tLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLabel1.FontSize = 13F;
            this.tLabel1.FontStyle = System.Drawing.FontStyle.Regular;
            this.tLabel1.Location = new System.Drawing.Point(2, 2);
            this.tLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.tLabel1.Name = "tLabel1";
            this.tLabel1.Size = new System.Drawing.Size(136, 36);
            this.tLabel1.TabIndex = 9;
            this.tLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tLabel1.TScale = 1F;
            this.tLabel1.Value = "품번/롯트검색";
            // 
            // Panel_Condition
            // 
            this.Panel_Condition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.Panel_Condition.ColumnCount = 3;
            this.Panel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.Panel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Panel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.Panel_Condition.Controls.Add(this.lblWROrderCount, 2, 0);
            this.Panel_Condition.Controls.Add(this.btnFind, 0, 0);
            this.Panel_Condition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Condition.Location = new System.Drawing.Point(463, 0);
            this.Panel_Condition.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Condition.Name = "Panel_Condition";
            this.Panel_Condition.RowCount = 1;
            this.Panel_Condition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Condition.Size = new System.Drawing.Size(216, 40);
            this.Panel_Condition.TabIndex = 0;
            // 
            // lblWROrderCount
            // 
            this.lblWROrderCount.AutoSize = true;
            this.lblWROrderCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.lblWROrderCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWROrderCount.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWROrderCount.Location = new System.Drawing.Point(111, 3);
            this.lblWROrderCount.Margin = new System.Windows.Forms.Padding(3);
            this.lblWROrderCount.Name = "lblWROrderCount";
            this.lblWROrderCount.Size = new System.Drawing.Size(102, 34);
            this.lblWROrderCount.TabIndex = 4;
            this.lblWROrderCount.Text = "0건";
            this.lblWROrderCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.Control;
            this.btnFind.Base_FontSize = 13F;
            this.btnFind.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btnFind.BorderBottom = true;
            this.btnFind.BorderColor = System.Drawing.SystemColors.Control;
            this.btnFind.BorderColorSelect = System.Drawing.Color.Blue;
            this.btnFind.BorderLeft = true;
            this.btnFind.BorderRight = true;
            this.btnFind.BorderTop = true;
            this.btnFind.BorderWidth = 0;
            this.btnFind.ButtonSelected = false;
            this.btnFind.ButtonType = "Default";
            this.btnFind.Caption = "품번검색";
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFind.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.btnFind.FontSize = 13F;
            this.btnFind.FontStyle = System.Drawing.FontStyle.Regular;
            this.btnFind.ForeColor = System.Drawing.Color.Black;
            this.btnFind.ForeColorSelect = System.Drawing.Color.Red;
            this.btnFind.IConImage1 = null;
            this.btnFind.IConImage2 = null;
            this.btnFind.IConViewFlag = false;
            this.btnFind.ImageButton = ((System.Drawing.Image)(resources.GetObject("btnFind.ImageButton")));
            this.btnFind.ImageButtonViewFlag = false;
            this.btnFind.Location = new System.Drawing.Point(2, 2);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Padding = new System.Windows.Forms.Padding(1);
            this.btnFind.SelectedWidth = 3;
            this.btnFind.Size = new System.Drawing.Size(84, 36);
            this.btnFind.TabIndex = 20;
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFind.TScale = 1F;
            this.btnFind.ButtonClick += new System.EventHandler(this.btnFind_ButtonClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tCheckBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tCheckBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(779, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(239, 40);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // tCheckBox2
            // 
            this.tCheckBox2.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.tCheckBox2.BorderBottom = false;
            this.tCheckBox2.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tCheckBox2.BorderLeft = false;
            this.tCheckBox2.BorderRight = false;
            this.tCheckBox2.BorderTop = false;
            this.tCheckBox2.Caption = "미착수";
            this.tCheckBox2.Checked = false;
            this.tCheckBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCheckBox2.FontSize = 13F;
            this.tCheckBox2.FontStyle = System.Drawing.FontStyle.Regular;
            this.tCheckBox2.Location = new System.Drawing.Point(122, 3);
            this.tCheckBox2.Name = "tCheckBox2";
            this.tCheckBox2.Size = new System.Drawing.Size(114, 34);
            this.tCheckBox2.TabIndex = 9;
            this.tCheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tCheckBox2.Value = 0;
            this.tCheckBox2.ValueChar = "N";
            this.tCheckBox2.ValueChar_Check = "Y";
            this.tCheckBox2.ValueChar_unCheck = "N";
            this.tCheckBox2.CheckedChange += new System.EventHandler(this.tCheckBox2_CheckedChange);
            // 
            // tCheckBox1
            // 
            this.tCheckBox1.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.tCheckBox1.BorderBottom = false;
            this.tCheckBox1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tCheckBox1.BorderLeft = false;
            this.tCheckBox1.BorderRight = false;
            this.tCheckBox1.BorderTop = false;
            this.tCheckBox1.Caption = "작업중";
            this.tCheckBox1.Checked = true;
            this.tCheckBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCheckBox1.FontSize = 13F;
            this.tCheckBox1.FontStyle = System.Drawing.FontStyle.Regular;
            this.tCheckBox1.Location = new System.Drawing.Point(3, 3);
            this.tCheckBox1.Name = "tCheckBox1";
            this.tCheckBox1.Size = new System.Drawing.Size(113, 34);
            this.tCheckBox1.TabIndex = 8;
            this.tCheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tCheckBox1.Value = 1;
            this.tCheckBox1.ValueChar = "Y";
            this.tCheckBox1.ValueChar_Check = "Y";
            this.tCheckBox1.ValueChar_unCheck = "N";
            this.tCheckBox1.CheckedChange += new System.EventHandler(this.tCheckBox1_CheckedChange);
            this.tCheckBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tCheckBox1_MouseClick);
            // 
            // opn_ITEM_CD
            // 
            this.opn_ITEM_CD.BackColor = System.Drawing.SystemColors.Window;
            this.opn_ITEM_CD.BorderBackColor = System.Drawing.SystemColors.Window;
            this.opn_ITEM_CD.BorderBottom = true;
            this.opn_ITEM_CD.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.opn_ITEM_CD.BorderLeft = true;
            this.opn_ITEM_CD.BorderRight = false;
            this.opn_ITEM_CD.BorderTop = true;
            this.opn_ITEM_CD.Caption = "";
            this.Panel_Doc12.SetColumnSpan(this.opn_ITEM_CD, 3);
            this.opn_ITEM_CD.DefaultPopup = "TEXT";
            this.opn_ITEM_CD.DefaultSqlID = "";
            this.opn_ITEM_CD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opn_ITEM_CD.FontSize = 14.25F;
            this.opn_ITEM_CD.FontStyle = System.Drawing.FontStyle.Regular;
            this.opn_ITEM_CD.Location = new System.Drawing.Point(143, 3);
            this.opn_ITEM_CD.Name = "opn_ITEM_CD";
            this.opn_ITEM_CD.PasswordChar = '\0';
            this.opn_ITEM_CD.SelectedText = "";
            this.opn_ITEM_CD.SelectionLength = 0;
            this.opn_ITEM_CD.SelectionStart = 0;
            this.opn_ITEM_CD.Size = new System.Drawing.Size(317, 34);
            this.opn_ITEM_CD.TabIndex = 18;
            this.opn_ITEM_CD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.opn_ITEM_CD.TextColor = System.Drawing.SystemColors.ControlText;
            this.opn_ITEM_CD.TScale = 1F;
            this.opn_ITEM_CD.Value = "";
            this.opn_ITEM_CD.ValueName = "";
            this.opn_ITEM_CD.EnterKeyDown += new System.EventHandler(this.opn_ITEM_CD_EnterKeyDown);
            this.opn_ITEM_CD.OpenPopup += new System.EventHandler(this.opn_ITEM_CD_OpenPopup);
            this.opn_ITEM_CD.ValueChanged += new System.EventHandler(this.opn_ITEM_CD_ValueChanged);
            this.opn_ITEM_CD.Enter += new System.EventHandler(this.opn_ITEM_CD_Enter);
            this.opn_ITEM_CD.Leave += new System.EventHandler(this.opn_ITEM_CD_Leave);
            this.opn_ITEM_CD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opn_ITEM_CD_MouseClick);
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
            this.Panel_Doc11.Controls.Add(this.opn_FA_CD, 7, 0);
            this.Panel_Doc11.Controls.Add(this.tLabel5, 3, 0);
            this.Panel_Doc11.Controls.Add(this.tLabel4, 6, 0);
            this.Panel_Doc11.Controls.Add(this.tLabel2, 0, 0);
            this.Panel_Doc11.Controls.Add(this.lbl_WorkCenterNm, 1, 0);
            this.Panel_Doc11.Controls.Add(this.cboWorker, 4, 0);
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
            // opn_FA_CD
            // 
            this.opn_FA_CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.opn_FA_CD.BorderBackColor = System.Drawing.SystemColors.Window;
            this.opn_FA_CD.BorderBottom = true;
            this.opn_FA_CD.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.opn_FA_CD.BorderLeft = true;
            this.opn_FA_CD.BorderNameBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.opn_FA_CD.BorderRight = true;
            this.opn_FA_CD.BorderTop = true;
            this.opn_FA_CD.Caption = "";
            this.opn_FA_CD.CommonCD = "";
            this.opn_FA_CD.DefaultPopup = "";
            this.opn_FA_CD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opn_FA_CD.FontSize = 13F;
            this.opn_FA_CD.FontStyle = System.Drawing.FontStyle.Regular;
            this.opn_FA_CD.Location = new System.Drawing.Point(779, 3);
            this.opn_FA_CD.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.opn_FA_CD.Name = "opn_FA_CD";
            this.opn_FA_CD.PasswordChar = '\0';
            this.opn_FA_CD.ReadOnly = false;
            this.opn_FA_CD.Required = false;
            this.opn_FA_CD.SelectedText = "";
            this.opn_FA_CD.SelectionLength = 0;
            this.opn_FA_CD.SelectionStart = 0;
            this.opn_FA_CD.Size = new System.Drawing.Size(236, 34);
            this.opn_FA_CD.TabIndex = 27;
            this.opn_FA_CD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.opn_FA_CD.TextColor = System.Drawing.SystemColors.ControlText;
            this.opn_FA_CD.TextNameColor = System.Drawing.SystemColors.ControlText;
            this.opn_FA_CD.TScale = 1F;
            this.opn_FA_CD.Value = "";
            this.opn_FA_CD.Value_Visible = true;
            this.opn_FA_CD.ValueName = "";
            this.opn_FA_CD.ValueName_Visible = true;
            this.opn_FA_CD.ValueName_Visuble = true;
            this.opn_FA_CD.OpenPopup += new System.EventHandler(this.opn_FA_CD_OpenPopup);
            this.opn_FA_CD.ValueChanged += new System.EventHandler(this.opn_FA_CD_ValueChanged);
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
            this.tLabel4.Caption = "설비";
            this.tLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLabel4.FontSize = 13F;
            this.tLabel4.FontStyle = System.Drawing.FontStyle.Regular;
            this.tLabel4.Location = new System.Drawing.Point(691, 2);
            this.tLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.tLabel4.Name = "tLabel4";
            this.tLabel4.Size = new System.Drawing.Size(86, 36);
            this.tLabel4.TabIndex = 15;
            this.tLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tLabel4.TScale = 1F;
            this.tLabel4.Value = "설비";
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
            this.tLabel2.Location = new System.Drawing.Point(2, 2);
            this.tLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.tLabel2.Name = "tLabel2";
            this.tLabel2.Size = new System.Drawing.Size(136, 36);
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
            this.lbl_WorkCenterNm.Location = new System.Drawing.Point(142, 2);
            this.lbl_WorkCenterNm.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_WorkCenterNm.Name = "lbl_WorkCenterNm";
            this.lbl_WorkCenterNm.Size = new System.Drawing.Size(219, 36);
            this.lbl_WorkCenterNm.TabIndex = 21;
            this.lbl_WorkCenterNm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_WorkCenterNm.TScale = 1F;
            this.lbl_WorkCenterNm.Value = "";
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
            this.cboWorker.SelectedValueChanged += new System.EventHandler(this.cboWorker_SelectedValueChanged);
            this.cboWorker.Click += new System.EventHandler(this.cboWorker_Click);
            this.cboWorker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboWorker_MouseClick);
            // 
            // Grid1
            // 
            this.Grid1.AllowUserToAddRows = false;
            this.Grid1.AllowUserToDeleteRows = false;
            this.Grid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Grid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Grid1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid1.DefaultCellStyle = dataGridViewCellStyle8;
            this.Grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid1.Location = new System.Drawing.Point(3, 89);
            this.Grid1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Grid1.MultiSelect = false;
            this.Grid1.Name = "Grid1";
            this.Grid1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Grid1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.Grid1.RowTemplate.Height = 42;
            this.Grid1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid1.Size = new System.Drawing.Size(1018, 455);
            this.Grid1.TabIndex = 46;
            this.Grid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid1_CellClick);
            this.Grid1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid1_CellMouseEnter);
            this.Grid1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid1_CellMouseLeave);
            this.Grid1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Grid1_MouseClick);
            // 
            // lblMiWorkQty
            // 
            this.lblMiWorkQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMiWorkQty.Base_FontSize = 13F;
            this.lblMiWorkQty.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMiWorkQty.BorderBottom = true;
            this.lblMiWorkQty.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMiWorkQty.BorderLeft = true;
            this.lblMiWorkQty.BorderRight = true;
            this.lblMiWorkQty.BorderTop = true;
            this.lblMiWorkQty.Caption = "잔량 : 0";
            this.lblMiWorkQty.FontSize = 13F;
            this.lblMiWorkQty.FontStyle = System.Drawing.FontStyle.Regular;
            this.lblMiWorkQty.Location = new System.Drawing.Point(504, 295);
            this.lblMiWorkQty.Margin = new System.Windows.Forms.Padding(2);
            this.lblMiWorkQty.Name = "lblMiWorkQty";
            this.lblMiWorkQty.Size = new System.Drawing.Size(144, 30);
            this.lblMiWorkQty.TabIndex = 22;
            this.lblMiWorkQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMiWorkQty.TScale = 1F;
            this.lblMiWorkQty.Value = "잔량 : 0";
            this.lblMiWorkQty.Visible = false;
            // 
            // APP_P9001MA1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblMiWorkQty);
            this.Controls.Add(this.Panel_Doc);
            this.Name = "APP_P9001MA1";
            this.Size = new System.Drawing.Size(1024, 604);
            this.Load += new System.EventHandler(this.Form_Load);
            this.Resize += new System.EventHandler(this.APP_P1001M1_Resize);
            this.Panel_Doc.ResumeLayout(false);
            this.Panel_Cmd.ResumeLayout(false);
            this.Panel_Doc12.ResumeLayout(false);
            this.Panel_Condition.ResumeLayout(false);
            this.Panel_Condition.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Panel_Doc11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Panel_Doc;
        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.TableLayoutPanel Panel_Condition;
        private System.Windows.Forms.Label lblWROrderCount;
        private TGSControl.TLabel tLabel1;
        private System.Windows.Forms.TableLayoutPanel Panel_Doc11;
        private TGSControl.TLabel tLabel2;
        private TGSControl.TLabel tLabel4;
        private TGSControl.TLabel tLabel5;
        private TGSControl.TCombo cboWorker;
        private TGSControl.TLabel lbl_WorkCenterNm;
        private TGSControl.TButton2 btn_WorkStart;
        private TGSControl.TButton2 btn_Unwork;
        private TGSControl.TButton2 btn_Query;
        private TGSControl.TOpenCombo opn_ITEM_CD;
        private System.Windows.Forms.TableLayoutPanel Panel_Doc12;
        private System.Windows.Forms.TableLayoutPanel Panel_Cmd;
        private TGSControl.TButton2 btn_Next;
        private TGSControl.TButton2 btn_Before;
        private TGSControl.TLabel tLabel3;
        private TGSControl.TButton2 btnFind;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TGSControl.TCheckBox tCheckBox1;
        private TGSControl.TButton2 btn_StandardSheet;
        private TGSControl.TButton2 btn_DailyCheck;
        private TGSControl.TButton2 btn_WorkOrder_Info;
        private TGSControl.TCheckBox tCheckBox2;
        private TGSControl.TLabel lblMiWorkQty;
        private TGSControl.TOpenPopup opn_FA_CD;
    }
}

