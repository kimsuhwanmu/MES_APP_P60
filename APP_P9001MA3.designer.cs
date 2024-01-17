namespace MES_APP_P90
{
    partial class APP_P9001MA3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APP_P9001MA3));
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Doc = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Cmd = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Edit = new TGSControl.TButton();
            this.btn_Close = new TGSControl.TButton();
            this.btn_End = new TGSControl.TButton();
            this.btn_Start = new TGSControl.TButton();
            this.btn_Cancel = new TGSControl.TButton();
            this.btn_Next = new TGSControl.TButton();
            this.btn_Before = new TGSControl.TButton();
            this.btn_ING = new TGSControl.TButton();
            this.btnSMS = new TGSControl.TButton();
            this.Panel_Condition = new System.Windows.Forms.TableLayoutPanel();
            this.cboWorker = new TGSControl.TCombo();
            this.tLabel5 = new TGSControl.TLabel();
            this.cboFacility = new TGSControl.TCombo();
            this.cboWC = new TGSControl.TCombo();
            this.tLabel2 = new TGSControl.TLabel();
            this.tLabel4 = new TGSControl.TLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tLabel3 = new TGSControl.TLabel();
            this.tLabel1 = new TGSControl.TLabel();
            this.Panel_Matrix = new System.Windows.Forms.TableLayoutPanel();
            this.tMatrixButtonV1 = new TGSControl.TMatrixButtonV();
            this.Grid3 = new System.Windows.Forms.DataGridView();
            this.Grid2 = new System.Windows.Forms.DataGridView();
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_UNWORK = new System.Windows.Forms.Panel();
            this.ctL_P0401C21 = new MES_APP_P90.CTL_P9001C2();
            this.btnResend = new TGSControl.TButton();
            this.Panel_Main.SuspendLayout();
            this.Panel_Doc.SuspendLayout();
            this.Panel_Cmd.SuspendLayout();
            this.Panel_Condition.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Panel_Matrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.Panel_UNWORK.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Main
            // 
            this.Panel_Main.ColumnCount = 1;
            this.Panel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Main.Controls.Add(this.Panel_Doc, 0, 0);
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Main.Location = new System.Drawing.Point(0, 0);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.RowCount = 1;
            this.Panel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Main.Size = new System.Drawing.Size(1018, 610);
            this.Panel_Main.TabIndex = 2;
            // 
            // Panel_Doc
            // 
            this.Panel_Doc.ColumnCount = 1;
            this.Panel_Doc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Doc.Controls.Add(this.Panel_Cmd, 0, 2);
            this.Panel_Doc.Controls.Add(this.Panel_Condition, 0, 0);
            this.Panel_Doc.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.Panel_Doc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Doc.Location = new System.Drawing.Point(0, 0);
            this.Panel_Doc.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Doc.Name = "Panel_Doc";
            this.Panel_Doc.RowCount = 3;
            this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.Panel_Doc.Size = new System.Drawing.Size(1018, 610);
            this.Panel_Doc.TabIndex = 1;
            // 
            // Panel_Cmd
            // 
            this.Panel_Cmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.Panel_Cmd.ColumnCount = 16;
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.619087F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.619079F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5429F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5429F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5429F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5429F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5429F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.50442F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5429F));
            this.Panel_Cmd.Controls.Add(this.btn_Edit, 3, 0);
            this.Panel_Cmd.Controls.Add(this.btn_Close, 15, 0);
            this.Panel_Cmd.Controls.Add(this.btn_End, 11, 0);
            this.Panel_Cmd.Controls.Add(this.btn_Start, 7, 0);
            this.Panel_Cmd.Controls.Add(this.btn_Cancel, 5, 0);
            this.Panel_Cmd.Controls.Add(this.btn_Next, 1, 0);
            this.Panel_Cmd.Controls.Add(this.btn_Before, 0, 0);
            this.Panel_Cmd.Controls.Add(this.btn_ING, 9, 0);
            this.Panel_Cmd.Controls.Add(this.btnSMS, 13, 0);
            this.Panel_Cmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Cmd.Location = new System.Drawing.Point(0, 555);
            this.Panel_Cmd.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Cmd.Name = "Panel_Cmd";
            this.Panel_Cmd.RowCount = 1;
            this.Panel_Cmd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Cmd.Size = new System.Drawing.Size(1018, 55);
            this.Panel_Cmd.TabIndex = 2;
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Edit.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_Edit.BorderBottom = true;
            this.btn_Edit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btn_Edit.BorderColorSelect = System.Drawing.Color.Blue;
            this.btn_Edit.BorderLeft = true;
            this.btn_Edit.BorderRight = true;
            this.btn_Edit.BorderTop = true;
            this.btn_Edit.BorderWidth = 0;
            this.btn_Edit.ButtonSelected = false;
            this.btn_Edit.Caption = "비가동수정";
            this.btn_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Edit.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btn_Edit.FontSize = 12F;
            this.btn_Edit.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_Edit.ForeColor = System.Drawing.Color.Black;
            this.btn_Edit.ForeColorSelect = System.Drawing.Color.Red;
            this.btn_Edit.IConImage1 = null;
            this.btn_Edit.IConImage2 = null;
            this.btn_Edit.IConViewFlag = false;
            this.btn_Edit.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ImageButton")));
            this.btn_Edit.ImageButtonViewFlag = false;
            this.btn_Edit.Location = new System.Drawing.Point(194, 3);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Edit.SelectedWidth = 3;
            this.btn_Edit.Size = new System.Drawing.Size(105, 49);
            this.btn_Edit.TabIndex = 6;
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Edit.Visible = false;
            this.btn_Edit.ButtonClick += new System.EventHandler(this.btn_Edit_ButtonClick);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Close.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_Close.BorderBottom = true;
            this.btn_Close.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btn_Close.BorderColorSelect = System.Drawing.Color.Blue;
            this.btn_Close.BorderLeft = true;
            this.btn_Close.BorderRight = true;
            this.btn_Close.BorderTop = true;
            this.btn_Close.BorderWidth = 0;
            this.btn_Close.ButtonSelected = false;
            this.btn_Close.Caption = "닫기";
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Close.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btn_Close.FontSize = 12F;
            this.btn_Close.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_Close.ForeColor = System.Drawing.Color.Black;
            this.btn_Close.ForeColorSelect = System.Drawing.Color.Red;
            this.btn_Close.IConImage1 = null;
            this.btn_Close.IConImage2 = null;
            this.btn_Close.IConViewFlag = false;
            this.btn_Close.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Close.ImageButton")));
            this.btn_Close.ImageButtonViewFlag = false;
            this.btn_Close.Location = new System.Drawing.Point(908, 3);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Close.SelectedWidth = 3;
            this.btn_Close.Size = new System.Drawing.Size(108, 49);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Close.ButtonClick += new System.EventHandler(this.btn_Close_ButtonClick);
            // 
            // btn_End
            // 
            this.btn_End.BackColor = System.Drawing.SystemColors.Control;
            this.btn_End.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_End.BorderBottom = true;
            this.btn_End.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btn_End.BorderColorSelect = System.Drawing.Color.Blue;
            this.btn_End.BorderLeft = true;
            this.btn_End.BorderRight = true;
            this.btn_End.BorderTop = true;
            this.btn_End.BorderWidth = 0;
            this.btn_End.ButtonSelected = false;
            this.btn_End.Caption = "비가동종료";
            this.btn_End.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_End.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btn_End.FontSize = 12F;
            this.btn_End.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_End.ForeColor = System.Drawing.Color.Black;
            this.btn_End.ForeColorSelect = System.Drawing.Color.Red;
            this.btn_End.IConImage1 = null;
            this.btn_End.IConImage2 = null;
            this.btn_End.IConViewFlag = false;
            this.btn_End.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_End.ImageButton")));
            this.btn_End.ImageButtonViewFlag = false;
            this.btn_End.Location = new System.Drawing.Point(670, 3);
            this.btn_End.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_End.Name = "btn_End";
            this.btn_End.Padding = new System.Windows.Forms.Padding(1);
            this.btn_End.SelectedWidth = 3;
            this.btn_End.Size = new System.Drawing.Size(105, 49);
            this.btn_End.TabIndex = 4;
            this.btn_End.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_End.ButtonClick += new System.EventHandler(this.btn_End_ButtonClick);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Start.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_Start.BorderBottom = true;
            this.btn_Start.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btn_Start.BorderColorSelect = System.Drawing.Color.Blue;
            this.btn_Start.BorderLeft = true;
            this.btn_Start.BorderRight = true;
            this.btn_Start.BorderTop = true;
            this.btn_Start.BorderWidth = 0;
            this.btn_Start.ButtonSelected = false;
            this.btn_Start.Caption = "비가동시작";
            this.btn_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Start.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btn_Start.FontSize = 12F;
            this.btn_Start.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_Start.ForeColor = System.Drawing.Color.Blue;
            this.btn_Start.ForeColorSelect = System.Drawing.Color.Red;
            this.btn_Start.IConImage1 = null;
            this.btn_Start.IConImage2 = null;
            this.btn_Start.IConViewFlag = false;
            this.btn_Start.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Start.ImageButton")));
            this.btn_Start.ImageButtonViewFlag = false;
            this.btn_Start.Location = new System.Drawing.Point(432, 3);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Start.SelectedWidth = 3;
            this.btn_Start.Size = new System.Drawing.Size(105, 49);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Start.ButtonClick += new System.EventHandler(this.btn_Start_ButtonClick);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.BorderBottom = true;
            this.btn_Cancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btn_Cancel.BorderColorSelect = System.Drawing.Color.Blue;
            this.btn_Cancel.BorderLeft = true;
            this.btn_Cancel.BorderRight = true;
            this.btn_Cancel.BorderTop = true;
            this.btn_Cancel.BorderWidth = 0;
            this.btn_Cancel.ButtonSelected = false;
            this.btn_Cancel.Caption = "비가동취소";
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Cancel.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btn_Cancel.FontSize = 12F;
            this.btn_Cancel.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancel.ForeColorSelect = System.Drawing.Color.Red;
            this.btn_Cancel.IConImage1 = null;
            this.btn_Cancel.IConImage2 = null;
            this.btn_Cancel.IConViewFlag = false;
            this.btn_Cancel.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.ImageButton")));
            this.btn_Cancel.ImageButtonViewFlag = false;
            this.btn_Cancel.Location = new System.Drawing.Point(313, 3);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Cancel.SelectedWidth = 3;
            this.btn_Cancel.Size = new System.Drawing.Size(105, 49);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.ButtonClick += new System.EventHandler(this.btn_Cancel_ButtonClick);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Next.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_Next.BorderBottom = true;
            this.btn_Next.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btn_Next.BorderColorSelect = System.Drawing.Color.Blue;
            this.btn_Next.BorderLeft = true;
            this.btn_Next.BorderRight = true;
            this.btn_Next.BorderTop = true;
            this.btn_Next.BorderWidth = 0;
            this.btn_Next.ButtonSelected = false;
            this.btn_Next.Caption = "다음";
            this.btn_Next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Next.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btn_Next.FontSize = 12F;
            this.btn_Next.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_Next.ForeColor = System.Drawing.Color.Black;
            this.btn_Next.ForeColorSelect = System.Drawing.Color.Red;
            this.btn_Next.IConImage1 = null;
            this.btn_Next.IConImage2 = null;
            this.btn_Next.IConViewFlag = false;
            this.btn_Next.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Next.ImageButton")));
            this.btn_Next.ImageButtonViewFlag = false;
            this.btn_Next.Location = new System.Drawing.Point(93, 3);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Next.SelectedWidth = 3;
            this.btn_Next.Size = new System.Drawing.Size(87, 49);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Next.ButtonClick += new System.EventHandler(this.btn_Next_ButtonClick);
            // 
            // btn_Before
            // 
            this.btn_Before.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Before.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_Before.BorderBottom = true;
            this.btn_Before.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btn_Before.BorderColorSelect = System.Drawing.Color.Blue;
            this.btn_Before.BorderLeft = true;
            this.btn_Before.BorderRight = true;
            this.btn_Before.BorderTop = true;
            this.btn_Before.BorderWidth = 0;
            this.btn_Before.ButtonSelected = false;
            this.btn_Before.Caption = "이전";
            this.btn_Before.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Before.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btn_Before.FontSize = 12F;
            this.btn_Before.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_Before.ForeColor = System.Drawing.Color.Black;
            this.btn_Before.ForeColorSelect = System.Drawing.Color.Red;
            this.btn_Before.IConImage1 = null;
            this.btn_Before.IConImage2 = null;
            this.btn_Before.IConViewFlag = false;
            this.btn_Before.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Before.ImageButton")));
            this.btn_Before.ImageButtonViewFlag = false;
            this.btn_Before.Location = new System.Drawing.Point(2, 3);
            this.btn_Before.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Before.Name = "btn_Before";
            this.btn_Before.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Before.SelectedWidth = 3;
            this.btn_Before.Size = new System.Drawing.Size(87, 49);
            this.btn_Before.TabIndex = 0;
            this.btn_Before.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Before.ButtonClick += new System.EventHandler(this.btn_Before_ButtonClick);
            // 
            // btn_ING
            // 
            this.btn_ING.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ING.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_ING.BorderBottom = true;
            this.btn_ING.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btn_ING.BorderColorSelect = System.Drawing.Color.Blue;
            this.btn_ING.BorderLeft = true;
            this.btn_ING.BorderRight = true;
            this.btn_ING.BorderTop = true;
            this.btn_ING.BorderWidth = 0;
            this.btn_ING.ButtonSelected = false;
            this.btn_ING.Caption = "비가동점검";
            this.btn_ING.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ING.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btn_ING.FontSize = 12F;
            this.btn_ING.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_ING.ForeColor = System.Drawing.Color.Black;
            this.btn_ING.ForeColorSelect = System.Drawing.Color.Red;
            this.btn_ING.IConImage1 = null;
            this.btn_ING.IConImage2 = null;
            this.btn_ING.IConViewFlag = false;
            this.btn_ING.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_ING.ImageButton")));
            this.btn_ING.ImageButtonViewFlag = false;
            this.btn_ING.Location = new System.Drawing.Point(551, 3);
            this.btn_ING.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_ING.Name = "btn_ING";
            this.btn_ING.Padding = new System.Windows.Forms.Padding(1);
            this.btn_ING.SelectedWidth = 3;
            this.btn_ING.Size = new System.Drawing.Size(105, 49);
            this.btn_ING.TabIndex = 4;
            this.btn_ING.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ING.ButtonClick += new System.EventHandler(this.tButton1_ButtonClick);
            // 
            // btnSMS
            // 
            this.btnSMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btnSMS.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btnSMS.BorderBottom = false;
            this.btnSMS.BorderColor = System.Drawing.Color.Gray;
            this.btnSMS.BorderColorSelect = System.Drawing.Color.Blue;
            this.btnSMS.BorderLeft = false;
            this.btnSMS.BorderRight = false;
            this.btnSMS.BorderTop = false;
            this.btnSMS.BorderWidth = 0;
            this.btnSMS.ButtonSelected = false;
            this.btnSMS.Caption = "경보알림";
            this.btnSMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSMS.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btnSMS.FontSize = 12F;
            this.btnSMS.FontStyle = System.Drawing.FontStyle.Regular;
            this.btnSMS.ForeColor = System.Drawing.Color.Black;
            this.btnSMS.ForeColorSelect = System.Drawing.Color.Red;
            this.btnSMS.IConImage1 = null;
            this.btnSMS.IConImage2 = null;
            this.btnSMS.IConViewFlag = false;
            this.btnSMS.ImageButton = null;
            this.btnSMS.ImageButtonViewFlag = false;
            this.btnSMS.Location = new System.Drawing.Point(789, 3);
            this.btnSMS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSMS.Name = "btnSMS";
            this.btnSMS.SelectedWidth = 3;
            this.btnSMS.Size = new System.Drawing.Size(105, 49);
            this.btnSMS.TabIndex = 7;
            this.btnSMS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSMS.ButtonClick += new System.EventHandler(this.btnSMS_ButtonClick);
            // 
            // Panel_Condition
            // 
            this.Panel_Condition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.Panel_Condition.ColumnCount = 6;
            this.Panel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.946584F));
            this.Panel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.58777F));
            this.Panel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.946584F));
            this.Panel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.98471F));
            this.Panel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.946584F));
            this.Panel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.58777F));
            this.Panel_Condition.Controls.Add(this.cboWorker, 5, 0);
            this.Panel_Condition.Controls.Add(this.tLabel5, 4, 0);
            this.Panel_Condition.Controls.Add(this.cboFacility, 3, 0);
            this.Panel_Condition.Controls.Add(this.cboWC, 1, 0);
            this.Panel_Condition.Controls.Add(this.tLabel2, 0, 0);
            this.Panel_Condition.Controls.Add(this.tLabel4, 2, 0);
            this.Panel_Condition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Condition.Location = new System.Drawing.Point(0, 0);
            this.Panel_Condition.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Condition.Name = "Panel_Condition";
            this.Panel_Condition.RowCount = 1;
            this.Panel_Condition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Condition.Size = new System.Drawing.Size(1018, 48);
            this.Panel_Condition.TabIndex = 0;
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
            this.cboWorker.Location = new System.Drawing.Point(799, 3);
            this.cboWorker.Name = "cboWorker";
            this.cboWorker.PasswordChar = '\0';
            this.cboWorker.SelectedIndex = -1;
            this.cboWorker.SelectedText = "";
            this.cboWorker.SelectionLength = 0;
            this.cboWorker.SelectionStart = 0;
            this.cboWorker.Size = new System.Drawing.Size(216, 42);
            this.cboWorker.TabIndex = 27;
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
            this.tLabel5.Location = new System.Drawing.Point(697, 2);
            this.tLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.tLabel5.Name = "tLabel5";
            this.tLabel5.Size = new System.Drawing.Size(97, 44);
            this.tLabel5.TabIndex = 26;
            this.tLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tLabel5.Value = "작업자";
            // 
            // cboFacility
            // 
            this.cboFacility.BackColor = System.Drawing.SystemColors.Window;
            this.cboFacility.BorderBackColor = System.Drawing.SystemColors.Window;
            this.cboFacility.BorderBottom = true;
            this.cboFacility.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.cboFacility.BorderLeft = true;
            this.cboFacility.BorderRight = false;
            this.cboFacility.BorderTop = true;
            this.cboFacility.Caption = "";
            this.cboFacility.DisplayCaption = "설비";
            this.cboFacility.DisplayMember = "CODE_NM";
            this.cboFacility.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboFacility.FontSize = 14.25F;
            this.cboFacility.FontStyle = System.Drawing.FontStyle.Regular;
            this.cboFacility.Location = new System.Drawing.Point(424, 3);
            this.cboFacility.Name = "cboFacility";
            this.cboFacility.PasswordChar = '\0';
            this.cboFacility.SelectedIndex = -1;
            this.cboFacility.SelectedText = "";
            this.cboFacility.SelectionLength = 0;
            this.cboFacility.SelectionStart = 0;
            this.cboFacility.Size = new System.Drawing.Size(268, 42);
            this.cboFacility.TabIndex = 25;
            this.cboFacility.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cboFacility.Value = "";
            this.cboFacility.ValueCaption = "설비코드";
            this.cboFacility.ValueMember = "CODE_ID";
            this.cboFacility.ValueName = "";
            this.cboFacility.SelectedValueChanged += new System.EventHandler(this.cboFacility_SelectedValueChanged);
            // 
            // cboWC
            // 
            this.cboWC.BackColor = System.Drawing.SystemColors.Window;
            this.cboWC.BorderBackColor = System.Drawing.SystemColors.Window;
            this.cboWC.BorderBottom = true;
            this.cboWC.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.cboWC.BorderLeft = true;
            this.cboWC.BorderRight = false;
            this.cboWC.BorderTop = true;
            this.cboWC.Caption = "";
            this.cboWC.DisplayCaption = "작업장 코드";
            this.cboWC.DisplayMember = "CODE_NM";
            this.cboWC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboWC.FontSize = 14.25F;
            this.cboWC.FontStyle = System.Drawing.FontStyle.Regular;
            this.cboWC.Location = new System.Drawing.Point(104, 3);
            this.cboWC.Name = "cboWC";
            this.cboWC.PasswordChar = '\0';
            this.cboWC.SelectedIndex = -1;
            this.cboWC.SelectedText = "";
            this.cboWC.SelectionLength = 0;
            this.cboWC.SelectionStart = 0;
            this.cboWC.Size = new System.Drawing.Size(213, 42);
            this.cboWC.TabIndex = 24;
            this.cboWC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cboWC.Value = "";
            this.cboWC.ValueCaption = "작업장";
            this.cboWC.ValueMember = "CODE_ID";
            this.cboWC.ValueName = "";
            this.cboWC.SelectedValueChanged += new System.EventHandler(this.cboWC_SelectedValueChanged);
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
            this.tLabel2.Caption = "작업장";
            this.tLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLabel2.FontSize = 14.25F;
            this.tLabel2.FontStyle = System.Drawing.FontStyle.Regular;
            this.tLabel2.Location = new System.Drawing.Point(2, 2);
            this.tLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.tLabel2.Name = "tLabel2";
            this.tLabel2.Size = new System.Drawing.Size(97, 44);
            this.tLabel2.TabIndex = 23;
            this.tLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tLabel2.Value = "작업장";
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
            this.tLabel4.Caption = "설비";
            this.tLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLabel4.FontSize = 14.25F;
            this.tLabel4.FontStyle = System.Drawing.FontStyle.Regular;
            this.tLabel4.Location = new System.Drawing.Point(322, 2);
            this.tLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.tLabel4.Name = "tLabel4";
            this.tLabel4.Size = new System.Drawing.Size(97, 44);
            this.tLabel4.TabIndex = 22;
            this.tLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tLabel4.Value = "설비";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.Controls.Add(this.tLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Panel_Matrix, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Grid3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Grid2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Grid1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 48);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1018, 507);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tLabel3
            // 
            this.tLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tLabel3.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tLabel3.BorderBottom = true;
            this.tLabel3.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tLabel3.BorderLeft = true;
            this.tLabel3.BorderRight = true;
            this.tLabel3.BorderTop = true;
            this.tLabel3.Caption = "비 가 동 등 록";
            this.tableLayoutPanel1.SetColumnSpan(this.tLabel3, 2);
            this.tLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLabel3.FontSize = 12F;
            this.tLabel3.FontStyle = System.Drawing.FontStyle.Regular;
            this.tLabel3.Location = new System.Drawing.Point(2, 160);
            this.tLabel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.tLabel3.Name = "tLabel3";
            this.tLabel3.Size = new System.Drawing.Size(1014, 26);
            this.tLabel3.TabIndex = 52;
            this.tLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tLabel3.Value = "비 가 동 등 록";
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
            this.tLabel1.Caption = "비 가 동 현 황";
            this.tableLayoutPanel1.SetColumnSpan(this.tLabel1, 2);
            this.tLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLabel1.FontSize = 12F;
            this.tLabel1.FontStyle = System.Drawing.FontStyle.Regular;
            this.tLabel1.Location = new System.Drawing.Point(2, 2);
            this.tLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.tLabel1.Name = "tLabel1";
            this.tLabel1.Size = new System.Drawing.Size(1014, 26);
            this.tLabel1.TabIndex = 51;
            this.tLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tLabel1.Value = "비 가 동 현 황";
            // 
            // Panel_Matrix
            // 
            this.Panel_Matrix.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.Panel_Matrix, 4);
            this.Panel_Matrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Matrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Panel_Matrix.Controls.Add(this.tMatrixButtonV1, 0, 0);
            this.Panel_Matrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Matrix.Location = new System.Drawing.Point(0, 186);
            this.Panel_Matrix.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Matrix.Name = "Panel_Matrix";
            this.Panel_Matrix.RowCount = 1;
            this.Panel_Matrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Matrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Panel_Matrix.Size = new System.Drawing.Size(1018, 60);
            this.Panel_Matrix.TabIndex = 50;
            // 
            // tMatrixButtonV1
            // 
            this.tMatrixButtonV1.BorderColorSelect = System.Drawing.Color.Blue;
            this.tMatrixButtonV1.ButtonCount = 0;
            this.tMatrixButtonV1.DisplayMember = "CODE_NM";
            this.tMatrixButtonV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tMatrixButtonV1.FontSize = 12F;
            this.tMatrixButtonV1.FontStyle = System.Drawing.FontStyle.Regular;
            this.tMatrixButtonV1.ForeColorSelect = System.Drawing.Color.Red;
            this.tMatrixButtonV1.Location = new System.Drawing.Point(3, 0);
            this.tMatrixButtonV1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tMatrixButtonV1.Name = "tMatrixButtonV1";
            this.tMatrixButtonV1.ReferenceMember1 = "REF1";
            this.tMatrixButtonV1.ReferenceMember2 = "REF2";
            this.tMatrixButtonV1.ReferenceMember3 = "REF3";
            this.tMatrixButtonV1.ReferenceMember4 = "REF4";
            this.tMatrixButtonV1.RowTopIndex = 0;
            this.tMatrixButtonV1.Size = new System.Drawing.Size(1012, 60);
            this.tMatrixButtonV1.TabIndex = 0;
            this.tMatrixButtonV1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tMatrixButtonV1.Value = "";
            this.tMatrixButtonV1.ValueMember = "CODE_ID";
            this.tMatrixButtonV1.ButtonClick += new System.EventHandler(this.tMatrixButtonV1_ButtonClick);
            // 
            // Grid3
            // 
            this.Grid3.AllowUserToAddRows = false;
            this.Grid3.AllowUserToDeleteRows = false;
            this.Grid3.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Grid3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid3.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Grid3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid3.Location = new System.Drawing.Point(461, 249);
            this.Grid3.MultiSelect = false;
            this.Grid3.Name = "Grid3";
            this.Grid3.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid3.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Grid3.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Grid3.RowTemplate.Height = 39;
            this.Grid3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid3.Size = new System.Drawing.Size(554, 124);
            this.Grid3.TabIndex = 49;
            this.Grid3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid3_CellClick);
            this.Grid3.Enter += new System.EventHandler(this.Grid3_Enter);
            // 
            // Grid2
            // 
            this.Grid2.AllowUserToAddRows = false;
            this.Grid2.AllowUserToDeleteRows = false;
            this.Grid2.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Grid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Grid2.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid2.DefaultCellStyle = dataGridViewCellStyle8;
            this.Grid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid2.Location = new System.Drawing.Point(3, 249);
            this.Grid2.MultiSelect = false;
            this.Grid2.Name = "Grid2";
            this.Grid2.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Grid2.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.Grid2.RowTemplate.Height = 39;
            this.Grid2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid2.Size = new System.Drawing.Size(452, 124);
            this.Grid2.TabIndex = 48;
            this.Grid2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid2_CellClick);
            this.Grid2.Enter += new System.EventHandler(this.Grid2_Enter);
            // 
            // Grid1
            // 
            this.Grid1.AllowUserToAddRows = false;
            this.Grid1.AllowUserToDeleteRows = false;
            this.Grid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Grid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.Grid1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.Grid1, 2);
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid1.DefaultCellStyle = dataGridViewCellStyle13;
            this.Grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid1.Location = new System.Drawing.Point(3, 31);
            this.Grid1.MultiSelect = false;
            this.Grid1.Name = "Grid1";
            this.Grid1.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Grid1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.Grid1.RowTemplate.Height = 39;
            this.Grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid1.Size = new System.Drawing.Size(1012, 124);
            this.Grid1.TabIndex = 47;
            this.Grid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid1_CellClick);
            this.Grid1.Enter += new System.EventHandler(this.Grid1_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.Controls.Add(this.Panel_UNWORK, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnResend, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 379);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1012, 125);
            this.tableLayoutPanel2.TabIndex = 53;
            // 
            // Panel_UNWORK
            // 
            this.Panel_UNWORK.AutoSize = true;
            this.Panel_UNWORK.Controls.Add(this.ctL_P0401C21);
            this.Panel_UNWORK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_UNWORK.Location = new System.Drawing.Point(3, 3);
            this.Panel_UNWORK.Name = "Panel_UNWORK";
            this.Panel_UNWORK.Size = new System.Drawing.Size(886, 119);
            this.Panel_UNWORK.TabIndex = 3;
            this.Panel_UNWORK.Visible = false;
            // 
            // ctL_P0401C21
            // 
            this.ctL_P0401C21.BackColor = System.Drawing.SystemColors.Control;
            this.ctL_P0401C21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctL_P0401C21.Location = new System.Drawing.Point(0, 0);
            this.ctL_P0401C21.Name = "ctL_P0401C21";
            this.ctL_P0401C21.Size = new System.Drawing.Size(886, 119);
            this.ctL_P0401C21.sLOP_CD = null;
            this.ctL_P0401C21.sMOP_CD = null;
            this.ctL_P0401C21.sOP_CD = null;
            this.ctL_P0401C21.TabIndex = 0;
            this.ctL_P0401C21.UnworkNo = null;
            // 
            // btnResend
            // 
            this.btnResend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btnResend.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btnResend.BorderBottom = false;
            this.btnResend.BorderColor = System.Drawing.Color.Gray;
            this.btnResend.BorderColorSelect = System.Drawing.Color.Blue;
            this.btnResend.BorderLeft = false;
            this.btnResend.BorderRight = false;
            this.btnResend.BorderTop = false;
            this.btnResend.BorderWidth = 0;
            this.btnResend.ButtonSelected = false;
            this.btnResend.Caption = "문자발송";
            this.btnResend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResend.Font = new System.Drawing.Font("맑은 고딕", 14.25F);
            this.btnResend.FontSize = 14.25F;
            this.btnResend.FontStyle = System.Drawing.FontStyle.Regular;
            this.btnResend.ForeColor = System.Drawing.Color.Black;
            this.btnResend.ForeColorSelect = System.Drawing.Color.Red;
            this.btnResend.IConImage1 = null;
            this.btnResend.IConImage2 = null;
            this.btnResend.IConViewFlag = false;
            this.btnResend.ImageButton = null;
            this.btnResend.ImageButtonViewFlag = false;
            this.btnResend.Location = new System.Drawing.Point(895, 3);
            this.btnResend.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnResend.Name = "btnResend";
            this.btnResend.SelectedWidth = 3;
            this.btnResend.Size = new System.Drawing.Size(117, 119);
            this.btnResend.TabIndex = 4;
            this.btnResend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnResend.ButtonClick += new System.EventHandler(this.btnResend_ButtonClick);
            // 
            // APP_P0401M1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Panel_Main);
            this.Name = "APP_P0401M1";
            this.Size = new System.Drawing.Size(1000, 610);
            this.Panel_Main.ResumeLayout(false);
            this.Panel_Doc.ResumeLayout(false);
            this.Panel_Cmd.ResumeLayout(false);
            this.Panel_Condition.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Panel_Matrix.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.Panel_UNWORK.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Panel_Main;
        private System.Windows.Forms.TableLayoutPanel Panel_Doc;
        private System.Windows.Forms.TableLayoutPanel Panel_Cmd;
        private System.Windows.Forms.TableLayoutPanel Panel_Condition;
        private TGSControl.TCombo cboFacility;
        private TGSControl.TCombo cboWC;
        private TGSControl.TLabel tLabel2;
        private TGSControl.TLabel tLabel4;
        private TGSControl.TButton btn_Before;
        private TGSControl.TButton btn_Close;
        private TGSControl.TButton btn_End;
        private TGSControl.TButton btn_Start;
        private TGSControl.TButton btn_Cancel;
        private TGSControl.TButton btn_Next;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView Grid3;
        private System.Windows.Forms.DataGridView Grid2;
        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.Panel Panel_UNWORK;
        private System.Windows.Forms.TableLayoutPanel Panel_Matrix;
        private TGSControl.TMatrixButtonV tMatrixButtonV1;
        private TGSControl.TLabel tLabel3;
        private TGSControl.TLabel tLabel1;
        private TGSControl.TLabel tLabel5;
        private TGSControl.TCombo cboWorker;
        private TGSControl.TButton btn_Edit;
        private TGSControl.TButton btn_ING;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CTL_P9001C2 ctL_P0401C21;
        private TGSControl.TButton btnResend;
        private TGSControl.TButton btnSMS;
    }
}
