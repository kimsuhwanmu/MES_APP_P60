namespace MES_APP_P90
{
    partial class APP_P9005MA2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Doc = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Cmd = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Next = new TGSControl.TButton2();
            this.btn_Before = new TGSControl.TButton2();
            this.btnClose = new TGSControl.TButton2();
            this.btnAdd = new TGSControl.TButton2();
            this.btnQuery = new TGSControl.TButton2();
            this.btnDelete = new TGSControl.TButton2();
            this.Panel_Condition = new System.Windows.Forms.TableLayoutPanel();
            this.lblConBaseDt = new TGSControl.TLabel();
            this.lblConWcCd = new TGSControl.TLabel();
            this.dtConBaseDt = new TGSControl.TDateTerm();
            this.lblConResourceCd = new TGSControl.TLabel();
            this.Panel_MainData = new System.Windows.Forms.TableLayoutPanel();
            this.Grid1 = new TGSControl.TGrid2();
            this.lblTitle = new TGSControl.TLabel();
            this.popConWcCd = new TGSControl.TOpenPopup();
            this.popConResourceCd = new TGSControl.TOpenPopup();
            this.Panel_Main.SuspendLayout();
            this.Panel_Doc.SuspendLayout();
            this.Panel_Cmd.SuspendLayout();
            this.Panel_Condition.SuspendLayout();
            this.Panel_MainData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
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
            this.Panel_Main.Size = new System.Drawing.Size(985, 586);
            this.Panel_Main.TabIndex = 4;
            // 
            // Panel_Doc
            // 
            this.Panel_Doc.ColumnCount = 1;
            this.Panel_Doc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Doc.Controls.Add(this.Panel_Cmd, 0, 2);
            this.Panel_Doc.Controls.Add(this.Panel_Condition, 0, 0);
            this.Panel_Doc.Controls.Add(this.Panel_MainData, 0, 1);
            this.Panel_Doc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Doc.Location = new System.Drawing.Point(0, 0);
            this.Panel_Doc.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Doc.Name = "Panel_Doc";
            this.Panel_Doc.RowCount = 3;
            this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Panel_Doc.Size = new System.Drawing.Size(985, 586);
            this.Panel_Doc.TabIndex = 1;
            // 
            // Panel_Cmd
            // 
            this.Panel_Cmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.Panel_Cmd.ColumnCount = 10;
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.Panel_Cmd.Controls.Add(this.btn_Next, 1, 0);
            this.Panel_Cmd.Controls.Add(this.btn_Before, 0, 0);
            this.Panel_Cmd.Controls.Add(this.btnClose, 9, 0);
            this.Panel_Cmd.Controls.Add(this.btnAdd, 5, 0);
            this.Panel_Cmd.Controls.Add(this.btnQuery, 3, 0);
            this.Panel_Cmd.Controls.Add(this.btnDelete, 7, 0);
            this.Panel_Cmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Cmd.Location = new System.Drawing.Point(0, 506);
            this.Panel_Cmd.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Cmd.Name = "Panel_Cmd";
            this.Panel_Cmd.Padding = new System.Windows.Forms.Padding(10);
            this.Panel_Cmd.RowCount = 1;
            this.Panel_Cmd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Cmd.Size = new System.Drawing.Size(985, 80);
            this.Panel_Cmd.TabIndex = 2;
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Next.Base_FontSize = 13F;
            this.btn_Next.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_Next.BorderBottom = true;
            this.btn_Next.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
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
            this.btn_Next.ImageButton = null;
            this.btn_Next.ImageButtonViewFlag = false;
            this.btn_Next.Location = new System.Drawing.Point(130, 10);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Next.SelectedWidth = 3;
            this.btn_Next.Size = new System.Drawing.Size(120, 60);
            this.btn_Next.TabIndex = 35;
            this.btn_Next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Next.TScale = 1F;
            this.btn_Next.Visible = false;
            this.btn_Next.ButtonClick += new System.EventHandler(this.btn_Next_ButtonClick_1);
            // 
            // btn_Before
            // 
            this.btn_Before.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Before.Base_FontSize = 13F;
            this.btn_Before.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_Before.BorderBottom = true;
            this.btn_Before.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
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
            this.btn_Before.ImageButton = null;
            this.btn_Before.ImageButtonViewFlag = false;
            this.btn_Before.Location = new System.Drawing.Point(10, 10);
            this.btn_Before.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Before.Name = "btn_Before";
            this.btn_Before.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Before.SelectedWidth = 3;
            this.btn_Before.Size = new System.Drawing.Size(120, 60);
            this.btn_Before.TabIndex = 34;
            this.btn_Before.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Before.TScale = 1F;
            this.btn_Before.Visible = false;
            this.btn_Before.ButtonClick += new System.EventHandler(this.btn_Before_ButtonClick_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Base_FontSize = 13F;
            this.btnClose.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btnClose.BorderBottom = true;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btnClose.BorderColorSelect = System.Drawing.Color.Blue;
            this.btnClose.BorderLeft = true;
            this.btnClose.BorderRight = true;
            this.btnClose.BorderTop = true;
            this.btnClose.BorderWidth = 0;
            this.btnClose.ButtonSelected = false;
            this.btnClose.ButtonType = "Success";
            this.btnClose.Caption = "저장";
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.btnClose.FontSize = 13F;
            this.btnClose.FontStyle = System.Drawing.FontStyle.Regular;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ForeColorSelect = System.Drawing.Color.Red;
            this.btnClose.IConImage1 = null;
            this.btnClose.IConImage2 = null;
            this.btnClose.IConViewFlag = false;
            this.btnClose.ImageButton = null;
            this.btnClose.ImageButtonViewFlag = false;
            this.btnClose.Location = new System.Drawing.Point(975, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(1);
            this.btnClose.SelectedWidth = 3;
            this.btnClose.Size = new System.Drawing.Size(1, 60);
            this.btnClose.TabIndex = 35;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.TScale = 1F;
            this.btnClose.Visible = false;
            this.btnClose.ButtonClick += new System.EventHandler(this.btnClose_ButtonClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Base_FontSize = 13F;
            this.btnAdd.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BorderBottom = true;
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btnAdd.BorderColorSelect = System.Drawing.Color.Blue;
            this.btnAdd.BorderLeft = true;
            this.btnAdd.BorderRight = true;
            this.btnAdd.BorderTop = true;
            this.btnAdd.BorderWidth = 0;
            this.btnAdd.ButtonSelected = false;
            this.btnAdd.ButtonType = "Primary";
            this.btnAdd.Caption = "추가";
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.btnAdd.FontSize = 13F;
            this.btnAdd.FontStyle = System.Drawing.FontStyle.Regular;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ForeColorSelect = System.Drawing.Color.Red;
            this.btnAdd.IConImage1 = null;
            this.btnAdd.IConImage2 = null;
            this.btnAdd.IConViewFlag = false;
            this.btnAdd.ImageButton = null;
            this.btnAdd.ImageButtonViewFlag = false;
            this.btnAdd.Location = new System.Drawing.Point(975, 10);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(1);
            this.btnAdd.SelectedWidth = 3;
            this.btnAdd.Size = new System.Drawing.Size(1, 60);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TScale = 1F;
            this.btnAdd.Visible = false;
            this.btnAdd.ButtonClick += new System.EventHandler(this.btnAdd_ButtonClick);
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuery.Base_FontSize = 13F;
            this.btnQuery.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btnQuery.BorderBottom = true;
            this.btnQuery.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btnQuery.BorderColorSelect = System.Drawing.Color.Blue;
            this.btnQuery.BorderLeft = true;
            this.btnQuery.BorderRight = true;
            this.btnQuery.BorderTop = true;
            this.btnQuery.BorderWidth = 0;
            this.btnQuery.ButtonSelected = false;
            this.btnQuery.ButtonType = "Success";
            this.btnQuery.Caption = "조회";
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.btnQuery.FontSize = 13F;
            this.btnQuery.FontStyle = System.Drawing.FontStyle.Regular;
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.ForeColorSelect = System.Drawing.Color.Red;
            this.btnQuery.IConImage1 = null;
            this.btnQuery.IConImage2 = null;
            this.btnQuery.IConViewFlag = false;
            this.btnQuery.ImageButton = null;
            this.btnQuery.ImageButtonViewFlag = false;
            this.btnQuery.Location = new System.Drawing.Point(855, 10);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Padding = new System.Windows.Forms.Padding(1);
            this.btnQuery.SelectedWidth = 3;
            this.btnQuery.Size = new System.Drawing.Size(120, 60);
            this.btnQuery.TabIndex = 35;
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuery.TScale = 1F;
            this.btnQuery.ButtonClick += new System.EventHandler(this.btnQuery_ButtonClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Base_FontSize = 13F;
            this.btnDelete.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.BorderBottom = true;
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.btnDelete.BorderColorSelect = System.Drawing.Color.Blue;
            this.btnDelete.BorderLeft = true;
            this.btnDelete.BorderRight = true;
            this.btnDelete.BorderTop = true;
            this.btnDelete.BorderWidth = 0;
            this.btnDelete.ButtonSelected = false;
            this.btnDelete.ButtonType = "Danger";
            this.btnDelete.Caption = "삭제";
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.btnDelete.FontSize = 13F;
            this.btnDelete.FontStyle = System.Drawing.FontStyle.Regular;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ForeColorSelect = System.Drawing.Color.Red;
            this.btnDelete.IConImage1 = null;
            this.btnDelete.IConImage2 = null;
            this.btnDelete.IConViewFlag = false;
            this.btnDelete.ImageButton = null;
            this.btnDelete.ImageButtonViewFlag = false;
            this.btnDelete.Location = new System.Drawing.Point(975, 10);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(1);
            this.btnDelete.SelectedWidth = 3;
            this.btnDelete.Size = new System.Drawing.Size(1, 60);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.TScale = 1F;
            this.btnDelete.Visible = false;
            this.btnDelete.ButtonClick += new System.EventHandler(this.btnDelete_ButtonClick);
            // 
            // Panel_Condition
            // 
            this.Panel_Condition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.Panel_Condition.ColumnCount = 6;
            this.Panel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Panel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.Panel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Panel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.Panel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.Panel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.Panel_Condition.Controls.Add(this.lblConBaseDt, 0, 0);
            this.Panel_Condition.Controls.Add(this.lblConWcCd, 2, 0);
            this.Panel_Condition.Controls.Add(this.dtConBaseDt, 1, 0);
            this.Panel_Condition.Controls.Add(this.lblConResourceCd, 4, 0);
            this.Panel_Condition.Controls.Add(this.popConWcCd, 3, 0);
            this.Panel_Condition.Controls.Add(this.popConResourceCd, 5, 0);
            this.Panel_Condition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Condition.Location = new System.Drawing.Point(0, 0);
            this.Panel_Condition.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Condition.Name = "Panel_Condition";
            this.Panel_Condition.RowCount = 2;
            this.Panel_Condition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Condition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.Panel_Condition.Size = new System.Drawing.Size(985, 60);
            this.Panel_Condition.TabIndex = 0;
            // 
            // lblConBaseDt
            // 
            this.lblConBaseDt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.lblConBaseDt.Base_FontSize = 13F;
            this.lblConBaseDt.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.lblConBaseDt.BorderBottom = true;
            this.lblConBaseDt.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblConBaseDt.BorderLeft = true;
            this.lblConBaseDt.BorderRight = true;
            this.lblConBaseDt.BorderTop = true;
            this.lblConBaseDt.Caption = "일자";
            this.lblConBaseDt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConBaseDt.FontSize = 13F;
            this.lblConBaseDt.FontStyle = System.Drawing.FontStyle.Regular;
            this.lblConBaseDt.Location = new System.Drawing.Point(2, 2);
            this.lblConBaseDt.Margin = new System.Windows.Forms.Padding(2);
            this.lblConBaseDt.Name = "lblConBaseDt";
            this.lblConBaseDt.Size = new System.Drawing.Size(105, 46);
            this.lblConBaseDt.TabIndex = 0;
            this.lblConBaseDt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConBaseDt.TScale = 1F;
            this.lblConBaseDt.Value = "일자";
            // 
            // lblConWcCd
            // 
            this.lblConWcCd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.lblConWcCd.Base_FontSize = 13F;
            this.lblConWcCd.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.lblConWcCd.BorderBottom = true;
            this.lblConWcCd.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblConWcCd.BorderLeft = true;
            this.lblConWcCd.BorderRight = true;
            this.lblConWcCd.BorderTop = true;
            this.lblConWcCd.Caption = "작업장";
            this.lblConWcCd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConWcCd.FontSize = 13F;
            this.lblConWcCd.FontStyle = System.Drawing.FontStyle.Regular;
            this.lblConWcCd.Location = new System.Drawing.Point(329, 2);
            this.lblConWcCd.Margin = new System.Windows.Forms.Padding(2);
            this.lblConWcCd.Name = "lblConWcCd";
            this.lblConWcCd.Size = new System.Drawing.Size(105, 46);
            this.lblConWcCd.TabIndex = 0;
            this.lblConWcCd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConWcCd.TScale = 1F;
            this.lblConWcCd.Value = "작업장";
            // 
            // dtConBaseDt
            // 
            this.dtConBaseDt.BorderBottom = false;
            this.dtConBaseDt.BorderColor = System.Drawing.SystemColors.Control;
            this.dtConBaseDt.BorderLeft = false;
            this.dtConBaseDt.BorderRight = false;
            this.dtConBaseDt.BorderTop = false;
            this.dtConBaseDt.Caption = "Calendar";
            this.dtConBaseDt.DateDeleteVisible_From = false;
            this.dtConBaseDt.DateDeleteVisible_To = false;
            this.dtConBaseDt.DateFormat = "yyyy-MM-dd";
            this.dtConBaseDt.DefaultValue = "00";
            this.dtConBaseDt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtConBaseDt.FontSize = 14.25F;
            this.dtConBaseDt.FontStyle = System.Drawing.FontStyle.Regular;
            this.dtConBaseDt.Location = new System.Drawing.Point(112, 3);
            this.dtConBaseDt.Name = "dtConBaseDt";
            this.dtConBaseDt.ReadOnly_From = false;
            this.dtConBaseDt.ReadOnly_To = false;
            this.dtConBaseDt.Required = false;
            this.dtConBaseDt.Size = new System.Drawing.Size(212, 44);
            this.dtConBaseDt.TabIndex = 1;
            this.dtConBaseDt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtConBaseDt.TScale = 1F;
            this.dtConBaseDt.ValueFrom = "2023-12-07";
            this.dtConBaseDt.ValueFrom_Datetime = new System.DateTime(2023, 12, 7, 0, 0, 0, 0);
            this.dtConBaseDt.ValueTo = "2023-12-07";
            this.dtConBaseDt.ValueTo_Datetime = new System.DateTime(2023, 12, 7, 0, 0, 0, 0);
            // 
            // lblConResourceCd
            // 
            this.lblConResourceCd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.lblConResourceCd.Base_FontSize = 13F;
            this.lblConResourceCd.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.lblConResourceCd.BorderBottom = true;
            this.lblConResourceCd.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblConResourceCd.BorderLeft = true;
            this.lblConResourceCd.BorderRight = true;
            this.lblConResourceCd.BorderTop = true;
            this.lblConResourceCd.Caption = "설비";
            this.lblConResourceCd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConResourceCd.FontSize = 13F;
            this.lblConResourceCd.FontStyle = System.Drawing.FontStyle.Regular;
            this.lblConResourceCd.Location = new System.Drawing.Point(656, 2);
            this.lblConResourceCd.Margin = new System.Windows.Forms.Padding(2);
            this.lblConResourceCd.Name = "lblConResourceCd";
            this.lblConResourceCd.Size = new System.Drawing.Size(105, 46);
            this.lblConResourceCd.TabIndex = 3;
            this.lblConResourceCd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConResourceCd.TScale = 1F;
            this.lblConResourceCd.Value = "설비";
            // 
            // Panel_MainData
            // 
            this.Panel_MainData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.Panel_MainData.ColumnCount = 1;
            this.Panel_MainData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_MainData.Controls.Add(this.Grid1, 0, 1);
            this.Panel_MainData.Controls.Add(this.lblTitle, 0, 0);
            this.Panel_MainData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_MainData.Location = new System.Drawing.Point(3, 63);
            this.Panel_MainData.Name = "Panel_MainData";
            this.Panel_MainData.RowCount = 2;
            this.Panel_MainData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Panel_MainData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_MainData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Panel_MainData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Panel_MainData.Size = new System.Drawing.Size(979, 440);
            this.Panel_MainData.TabIndex = 4;
            // 
            // Grid1
            // 
            this.Grid1.AllowUserToAddRows = false;
            this.Grid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 13F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(196)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.Grid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Grid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Grid1.Base_FontSize = 13F;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(216)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(196)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.ContextMenuRowDeleteVisible = true;
            this.Grid1.ContextMenuRowInsertVisible = true;
            this.Grid1.ContextMenuRowUndoVisible = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(196)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid1.EnableHeadersVisualStyles = false;
            this.Grid1.ImgPopup_Open_Flg = true;
            this.Grid1.Location = new System.Drawing.Point(0, 40);
            this.Grid1.Margin = new System.Windows.Forms.Padding(0);
            this.Grid1.Name = "Grid1";
            this.Grid1.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 13F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(196)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.Grid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Grid1.RowHeadersWidth = 50;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("맑은 고딕", 13F);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(196)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.Grid1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Grid1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(196)))), ((int)(((byte)(241)))));
            this.Grid1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.Grid1.RowTemplate.Height = 34;
            this.Grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid1.Size = new System.Drawing.Size(979, 400);
            this.Grid1.TabIndex = 54;
            this.Grid1.TGridMultiLineFlag = false;
            this.Grid1.TScale = 1F;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.lblTitle.Base_FontSize = 13F;
            this.lblTitle.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.lblTitle.BorderBottom = true;
            this.lblTitle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTitle.BorderLeft = true;
            this.lblTitle.BorderRight = true;
            this.lblTitle.BorderTop = true;
            this.lblTitle.Caption = "  * 설비, 공정별 생산현황";
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.FontSize = 13F;
            this.lblTitle.FontStyle = System.Drawing.FontStyle.Bold;
            this.lblTitle.ForeColor = System.Drawing.Color.Green;
            this.lblTitle.Location = new System.Drawing.Point(2, 2);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(975, 36);
            this.lblTitle.TabIndex = 56;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.TScale = 1F;
            this.lblTitle.Value = "  * 설비, 공정별 생산현황";
            // 
            // popConWcCd
            // 
            this.popConWcCd.BackColor = System.Drawing.SystemColors.Window;
            this.popConWcCd.BorderBackColor = System.Drawing.SystemColors.Window;
            this.popConWcCd.BorderBottom = true;
            this.popConWcCd.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.popConWcCd.BorderLeft = true;
            this.popConWcCd.BorderNameBackColor = System.Drawing.SystemColors.Window;
            this.popConWcCd.BorderRight = true;
            this.popConWcCd.BorderTop = true;
            this.popConWcCd.Caption = "";
            this.popConWcCd.CommonCD = "";
            this.popConWcCd.DefaultPopup = "NONE";
            this.popConWcCd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popConWcCd.FontSize = 14.25F;
            this.popConWcCd.FontStyle = System.Drawing.FontStyle.Regular;
            this.popConWcCd.Location = new System.Drawing.Point(439, 3);
            this.popConWcCd.Name = "popConWcCd";
            this.popConWcCd.PasswordChar = '\0';
            this.popConWcCd.ReadOnly = false;
            this.popConWcCd.Required = false;
            this.popConWcCd.SelectedText = "";
            this.popConWcCd.SelectionLength = 0;
            this.popConWcCd.SelectionStart = 0;
            this.popConWcCd.Size = new System.Drawing.Size(212, 44);
            this.popConWcCd.TabIndex = 4;
            this.popConWcCd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.popConWcCd.TextColor = System.Drawing.SystemColors.ControlText;
            this.popConWcCd.TextNameColor = System.Drawing.SystemColors.ControlText;
            this.popConWcCd.TScale = 1F;
            this.popConWcCd.Value = "";
            this.popConWcCd.Value_Visible = true;
            this.popConWcCd.ValueName = "";
            this.popConWcCd.ValueName_Visible = true;
            this.popConWcCd.ValueName_Visuble = true;
            // 
            // popConResourceCd
            // 
            this.popConResourceCd.BackColor = System.Drawing.SystemColors.Window;
            this.popConResourceCd.BorderBackColor = System.Drawing.SystemColors.Window;
            this.popConResourceCd.BorderBottom = true;
            this.popConResourceCd.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.popConResourceCd.BorderLeft = true;
            this.popConResourceCd.BorderNameBackColor = System.Drawing.SystemColors.Window;
            this.popConResourceCd.BorderRight = true;
            this.popConResourceCd.BorderTop = true;
            this.popConResourceCd.Caption = "";
            this.popConResourceCd.CommonCD = "";
            this.popConResourceCd.DefaultPopup = "NONE";
            this.popConResourceCd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popConResourceCd.FontSize = 14.25F;
            this.popConResourceCd.FontStyle = System.Drawing.FontStyle.Regular;
            this.popConResourceCd.Location = new System.Drawing.Point(766, 3);
            this.popConResourceCd.Name = "popConResourceCd";
            this.popConResourceCd.PasswordChar = '\0';
            this.popConResourceCd.ReadOnly = false;
            this.popConResourceCd.Required = false;
            this.popConResourceCd.SelectedText = "";
            this.popConResourceCd.SelectionLength = 0;
            this.popConResourceCd.SelectionStart = 0;
            this.popConResourceCd.Size = new System.Drawing.Size(216, 44);
            this.popConResourceCd.TabIndex = 5;
            this.popConResourceCd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.popConResourceCd.TextColor = System.Drawing.SystemColors.ControlText;
            this.popConResourceCd.TextNameColor = System.Drawing.SystemColors.ControlText;
            this.popConResourceCd.TScale = 1F;
            this.popConResourceCd.Value = "";
            this.popConResourceCd.Value_Visible = true;
            this.popConResourceCd.ValueName = "";
            this.popConResourceCd.ValueName_Visible = true;
            this.popConResourceCd.ValueName_Visuble = true;
            // 
            // APP_P9005MA2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Panel_Main);
            this.Name = "APP_P9005MA2";
            this.Size = new System.Drawing.Size(985, 586);
            this.Panel_Main.ResumeLayout(false);
            this.Panel_Doc.ResumeLayout(false);
            this.Panel_Cmd.ResumeLayout(false);
            this.Panel_Condition.ResumeLayout(false);
            this.Panel_MainData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Panel_Main;
        private System.Windows.Forms.TableLayoutPanel Panel_Doc;
        private System.Windows.Forms.TableLayoutPanel Panel_Cmd;
        private System.Windows.Forms.TableLayoutPanel Panel_MainData;
        private TGSControl.TButton2 btn_Next;
        private TGSControl.TButton2 btn_Before;
        private System.Windows.Forms.TableLayoutPanel Panel_Condition;
        private TGSControl.TButton2 btnClose;
        private TGSControl.TButton2 btnAdd;
        private TGSControl.TButton2 btnQuery;
        private TGSControl.TLabel lblConBaseDt;
        private TGSControl.TLabel lblConWcCd;
        private TGSControl.TButton2 btnDelete;
        private TGSControl.TGrid2 Grid1;
        private TGSControl.TLabel lblTitle;
        private TGSControl.TDateTerm dtConBaseDt;
        private TGSControl.TLabel lblConResourceCd;
        private TGSControl.TOpenPopup popConWcCd;
        private TGSControl.TOpenPopup popConResourceCd;
    }
}
