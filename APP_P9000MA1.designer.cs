namespace MES_APP_P90
{
    partial class APP_P9000MA1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APP_P9000MA1));
            this.Panel_DocumentMain = new System.Windows.Forms.Panel();
            this.Panel_Document1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.지시현황 = new System.Windows.Forms.TabPage();
            this.apP_P9001M11 = new MES_APP_P90.APP_P9001MA1();
            this.부품투입 = new System.Windows.Forms.TabPage();
            this.apP_P9002M11 = new MES_APP_P90.APP_P9002MA1();
            this.작업 = new System.Windows.Forms.TabPage();
            this.apP_P9004MA11 = new MES_APP_P90.APP_P9004MA1();
            this.실적조회 = new System.Windows.Forms.TabPage();
            this.apP_P9003M11 = new MES_APP_P90.APP_P9003MA1();
            this.Panel_Bottom = new System.Windows.Forms.TableLayoutPanel();
            this.tMatrixButtonV1 = new TGSControl.TMatrixButtonV();
            this.btnBottomSet = new TGSControl.TButton();
            this.Panel_UNWORK = new System.Windows.Forms.Panel();
            this.ctL_P9001C11 = new MES_APP_P90.CTL_P9001C1();
            this.Panel_DocumentMain.SuspendLayout();
            this.Panel_Document1.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.지시현황.SuspendLayout();
            this.부품투입.SuspendLayout();
            this.작업.SuspendLayout();
            this.실적조회.SuspendLayout();
            this.Panel_Bottom.SuspendLayout();
            this.Panel_UNWORK.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_DocumentMain
            // 
            this.Panel_DocumentMain.Controls.Add(this.Panel_Document1);
            this.Panel_DocumentMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_DocumentMain.Location = new System.Drawing.Point(0, 0);
            this.Panel_DocumentMain.Name = "Panel_DocumentMain";
            this.Panel_DocumentMain.Size = new System.Drawing.Size(1023, 705);
            this.Panel_DocumentMain.TabIndex = 3;
            // 
            // Panel_Document1
            // 
            this.Panel_Document1.ColumnCount = 1;
            this.Panel_Document1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Document1.Controls.Add(this.tabMenu, 0, 0);
            this.Panel_Document1.Controls.Add(this.Panel_Bottom, 0, 1);
            this.Panel_Document1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Document1.Location = new System.Drawing.Point(0, 0);
            this.Panel_Document1.Name = "Panel_Document1";
            this.Panel_Document1.RowCount = 2;
            this.Panel_Document1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Document1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.Panel_Document1.Size = new System.Drawing.Size(1023, 705);
            this.Panel_Document1.TabIndex = 1;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.지시현황);
            this.tabMenu.Controls.Add(this.부품투입);
            this.tabMenu.Controls.Add(this.작업);
            this.tabMenu.Controls.Add(this.실적조회);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Enabled = false;
            this.tabMenu.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabMenu.ItemSize = new System.Drawing.Size(116, 35);
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1023, 645);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.SelectedIndexChanged += new System.EventHandler(this.tabMenu_SelectedIndexChanged);
            // 
            // 지시현황
            // 
            this.지시현황.Controls.Add(this.apP_P9001M11);
            this.지시현황.Location = new System.Drawing.Point(4, 39);
            this.지시현황.Name = "지시현황";
            this.지시현황.Padding = new System.Windows.Forms.Padding(3);
            this.지시현황.Size = new System.Drawing.Size(1015, 602);
            this.지시현황.TabIndex = 6;
            this.지시현황.Text = "  지시현황  ";
            this.지시현황.UseVisualStyleBackColor = true;
            // 
            // apP_P9001M11
            // 
            this.apP_P9001M11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apP_P9001M11.Location = new System.Drawing.Point(3, 3);
            this.apP_P9001M11.MainForm = null;
            this.apP_P9001M11.Name = "apP_P9001M11";
            this.apP_P9001M11.PROGRAM_ID = "MES_APP_P90.APP_P9001MA1";
            this.apP_P9001M11.Size = new System.Drawing.Size(1009, 596);
            this.apP_P9001M11.TabIndex = 0;
            this.apP_P9001M11.CommandRuned += new TGSClass.CommandRunEventHandler(this.apP_P9001M11_CommandRuned);
            this.apP_P9001M11.Load += new System.EventHandler(this.apP_P9001M11_Load);
            // 
            // 부품투입
            // 
            this.부품투입.Controls.Add(this.apP_P9002M11);
            this.부품투입.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.부품투입.Location = new System.Drawing.Point(4, 39);
            this.부품투입.Margin = new System.Windows.Forms.Padding(0);
            this.부품투입.Name = "부품투입";
            this.부품투입.Padding = new System.Windows.Forms.Padding(3);
            this.부품투입.Size = new System.Drawing.Size(1015, 602);
            this.부품투입.TabIndex = 0;
            this.부품투입.Text = "  부품투입  ";
            this.부품투입.UseVisualStyleBackColor = true;
            // 
            // apP_P9002M11
            // 
            this.apP_P9002M11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apP_P9002M11.Location = new System.Drawing.Point(3, 3);
            this.apP_P9002M11.MainForm = null;
            this.apP_P9002M11.Name = "apP_P9002M11";
            this.apP_P9002M11.PROGRAM_ID = "MES_APP_P90.APP_P9002MA1";
            this.apP_P9002M11.Size = new System.Drawing.Size(1009, 596);
            this.apP_P9002M11.TabIndex = 0;
            this.apP_P9002M11.CommandRuned += new TGSClass.CommandRunEventHandler(this.apP_P9002M11_CommandRuned);
            // 
            // 작업
            // 
            this.작업.Controls.Add(this.apP_P9004MA11);
            this.작업.Location = new System.Drawing.Point(4, 39);
            this.작업.Name = "작업";
            this.작업.Padding = new System.Windows.Forms.Padding(3);
            this.작업.Size = new System.Drawing.Size(1015, 602);
            this.작업.TabIndex = 7;
            this.작업.Text = "   작업   ";
            this.작업.UseVisualStyleBackColor = true;
            // 
            // apP_P9004MA11
            // 
            this.apP_P9004MA11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apP_P9004MA11.Location = new System.Drawing.Point(3, 3);
            this.apP_P9004MA11.MainForm = null;
            this.apP_P9004MA11.Name = "apP_P9004MA11";
            this.apP_P9004MA11.PROGRAM_ID = "MES_APP_P90.APP_P9004MA1";
            this.apP_P9004MA11.Size = new System.Drawing.Size(1009, 596);
            this.apP_P9004MA11.TabIndex = 0;
            // 
            // 실적조회
            // 
            this.실적조회.Controls.Add(this.apP_P9003M11);
            this.실적조회.Location = new System.Drawing.Point(4, 39);
            this.실적조회.Name = "실적조회";
            this.실적조회.Size = new System.Drawing.Size(1015, 602);
            this.실적조회.TabIndex = 2;
            this.실적조회.Text = "  실적조회  ";
            this.실적조회.UseVisualStyleBackColor = true;
            // 
            // apP_P9003M11
            // 
            this.apP_P9003M11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apP_P9003M11.Location = new System.Drawing.Point(0, 0);
            this.apP_P9003M11.MainForm = null;
            this.apP_P9003M11.Name = "apP_P9003M11";
            this.apP_P9003M11.PROGRAM_ID = "MES_APP_P90.APP_P9003M1";
            this.apP_P9003M11.Size = new System.Drawing.Size(1015, 602);
            this.apP_P9003M11.TabIndex = 0;
            // 
            // Panel_Bottom
            // 
            this.Panel_Bottom.ColumnCount = 2;
            this.Panel_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.Panel_Bottom.Controls.Add(this.tMatrixButtonV1, 0, 0);
            this.Panel_Bottom.Controls.Add(this.btnBottomSet, 1, 0);
            this.Panel_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Bottom.Location = new System.Drawing.Point(0, 645);
            this.Panel_Bottom.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Bottom.Name = "Panel_Bottom";
            this.Panel_Bottom.RowCount = 1;
            this.Panel_Bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Bottom.Size = new System.Drawing.Size(1023, 60);
            this.Panel_Bottom.TabIndex = 1;
            // 
            // tMatrixButtonV1
            // 
            this.tMatrixButtonV1.BorderColorSelect = System.Drawing.Color.Blue;
            this.tMatrixButtonV1.ButtonCount = 0;
            this.tMatrixButtonV1.DisplayMember = "CODE_NM";
            this.tMatrixButtonV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tMatrixButtonV1.Enabled = false;
            this.tMatrixButtonV1.FontSize = 12F;
            this.tMatrixButtonV1.FontStyle = System.Drawing.FontStyle.Regular;
            this.tMatrixButtonV1.ForeColorSelect = System.Drawing.Color.Red;
            this.tMatrixButtonV1.Location = new System.Drawing.Point(0, 0);
            this.tMatrixButtonV1.Margin = new System.Windows.Forms.Padding(0);
            this.tMatrixButtonV1.Name = "tMatrixButtonV1";
            this.tMatrixButtonV1.ReferenceMember1 = "REF1";
            this.tMatrixButtonV1.ReferenceMember2 = "REF2";
            this.tMatrixButtonV1.ReferenceMember3 = "REF3";
            this.tMatrixButtonV1.ReferenceMember4 = "REF4";
            this.tMatrixButtonV1.RowTopIndex = 0;
            this.tMatrixButtonV1.Size = new System.Drawing.Size(913, 60);
            this.tMatrixButtonV1.TabIndex = 1;
            this.tMatrixButtonV1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tMatrixButtonV1.Value = "";
            this.tMatrixButtonV1.ValueMember = "CODE_ID";
            this.tMatrixButtonV1.ButtonClick += new System.EventHandler(this.tMatrixButtonV1_ButtonClick);
            // 
            // btnBottomSet
            // 
            this.btnBottomSet.BackColor = System.Drawing.SystemColors.Control;
            this.btnBottomSet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBottomSet.BackgroundImage")));
            this.btnBottomSet.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btnBottomSet.BorderBottom = true;
            this.btnBottomSet.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBottomSet.BorderColorSelect = System.Drawing.Color.Blue;
            this.btnBottomSet.BorderLeft = true;
            this.btnBottomSet.BorderRight = true;
            this.btnBottomSet.BorderTop = true;
            this.btnBottomSet.BorderWidth = 0;
            this.btnBottomSet.ButtonSelected = false;
            this.btnBottomSet.Caption = "설비설정";
            this.btnBottomSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBottomSet.Enabled = false;
            this.btnBottomSet.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.btnBottomSet.FontSize = 12F;
            this.btnBottomSet.FontStyle = System.Drawing.FontStyle.Regular;
            this.btnBottomSet.ForeColor = System.Drawing.Color.Black;
            this.btnBottomSet.ForeColorSelect = System.Drawing.Color.Red;
            this.btnBottomSet.IConImage1 = null;
            this.btnBottomSet.IConImage2 = null;
            this.btnBottomSet.IConViewFlag = false;
            this.btnBottomSet.ImageButton = ((System.Drawing.Image)(resources.GetObject("btnBottomSet.ImageButton")));
            this.btnBottomSet.ImageButtonViewFlag = false;
            this.btnBottomSet.Location = new System.Drawing.Point(915, 3);
            this.btnBottomSet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBottomSet.Name = "btnBottomSet";
            this.btnBottomSet.Padding = new System.Windows.Forms.Padding(1);
            this.btnBottomSet.SelectedWidth = 3;
            this.btnBottomSet.Size = new System.Drawing.Size(106, 54);
            this.btnBottomSet.TabIndex = 2;
            this.btnBottomSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBottomSet.TScale = 1F;
            this.btnBottomSet.ButtonClick += new System.EventHandler(this.btnBottomSet_ButtonClick);
            // 
            // Panel_UNWORK
            // 
            this.Panel_UNWORK.Controls.Add(this.ctL_P9001C11);
            this.Panel_UNWORK.Location = new System.Drawing.Point(996, 31);
            this.Panel_UNWORK.Name = "Panel_UNWORK";
            this.Panel_UNWORK.Size = new System.Drawing.Size(684, 312);
            this.Panel_UNWORK.TabIndex = 155;
            this.Panel_UNWORK.Visible = false;
            // 
            // ctL_P9001C11
            // 
            this.ctL_P9001C11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctL_P9001C11.FACILITY_CD = "";
            this.ctL_P9001C11.L_OP_CD = "";
            this.ctL_P9001C11.Location = new System.Drawing.Point(0, 0);
            this.ctL_P9001C11.M_OP_CD = "";
            this.ctL_P9001C11.MainForm = null;
            this.ctL_P9001C11.Name = "ctL_P9001C11";
            this.ctL_P9001C11.Object_Enable = null;
            this.ctL_P9001C11.OP_CD = "";
            this.ctL_P9001C11.Size = new System.Drawing.Size(684, 312);
            this.ctL_P9001C11.TabIndex = 0;
            this.ctL_P9001C11.WC_CD = "";
            this.ctL_P9001C11.WORKER_CD = "";
            // 
            // APP_P9000MA1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Panel_UNWORK);
            this.Controls.Add(this.Panel_DocumentMain);
            this.Name = "APP_P9000MA1";
            this.Size = new System.Drawing.Size(1023, 705);
            this.Load += new System.EventHandler(this.Form_Load);
            this.Panel_DocumentMain.ResumeLayout(false);
            this.Panel_Document1.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.지시현황.ResumeLayout(false);
            this.부품투입.ResumeLayout(false);
            this.작업.ResumeLayout(false);
            this.실적조회.ResumeLayout(false);
            this.Panel_Bottom.ResumeLayout(false);
            this.Panel_UNWORK.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_DocumentMain;
        private System.Windows.Forms.TableLayoutPanel Panel_Document1;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage 지시현황;
        private System.Windows.Forms.TabPage 부품투입;
        private System.Windows.Forms.TabPage 실적조회;
        private System.Windows.Forms.TableLayoutPanel Panel_Bottom;
        private TGSControl.TMatrixButtonV tMatrixButtonV1;
        private TGSControl.TButton btnBottomSet;
        private MES_APP_P90.APP_P9001MA1 apP_P9001M11;
        private MES_APP_P90.APP_P9002MA1 apP_P9002M11;
        private MES_APP_P90.APP_P9003MA1 apP_P9003M11;       
        private System.Windows.Forms.Panel Panel_UNWORK;
        private MES_APP_P90.CTL_P9001C1 ctL_P9001C11;
        private System.Windows.Forms.TabPage 작업;
        private APP_P9004MA1 apP_P9004MA11;
    }
}
