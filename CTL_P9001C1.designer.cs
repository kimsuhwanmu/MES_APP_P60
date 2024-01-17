namespace MES_APP_P90
{
    partial class CTL_P9001C1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTL_P9001C1));
            this.lbl_UNWORK_NM = new System.Windows.Forms.Label();
            this.windowsForm1 = new TGSControl.WindowsForm();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_UNWORK_TIME = new System.Windows.Forms.Label();
            this.btn_End = new TGSControl.TButton();
            this.tButton1 = new TGSControl.TButton();
            this.btn_ING = new TGSControl.TButton();
            this.SuspendLayout();
            // 
            // lbl_UNWORK_NM
            // 
            this.lbl_UNWORK_NM.AutoSize = true;
            this.lbl_UNWORK_NM.Font = new System.Drawing.Font("맑은 고딕", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_UNWORK_NM.ForeColor = System.Drawing.Color.Blue;
            this.lbl_UNWORK_NM.Location = new System.Drawing.Point(101, 67);
            this.lbl_UNWORK_NM.Name = "lbl_UNWORK_NM";
            this.lbl_UNWORK_NM.Size = new System.Drawing.Size(295, 71);
            this.lbl_UNWORK_NM.TabIndex = 3;
            this.lbl_UNWORK_NM.Text = "비가동내역";
            // 
            // windowsForm1
            // 
            this.windowsForm1.BorderColor = System.Drawing.Color.Fuchsia;
            this.windowsForm1.BorderWidth = 5;
            this.windowsForm1.Caption = "설비 비가동 중입니다.";
            this.windowsForm1.Close_Visible = false;
            this.windowsForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowsForm1.Font = new System.Drawing.Font("맑은 고딕", 22F, System.Drawing.FontStyle.Bold);
            this.windowsForm1.ForeColor = System.Drawing.Color.White;
            this.windowsForm1.Location = new System.Drawing.Point(0, 0);
            this.windowsForm1.Margin = new System.Windows.Forms.Padding(0);
            this.windowsForm1.Name = "windowsForm1";
            this.windowsForm1.Size = new System.Drawing.Size(684, 307);
            this.windowsForm1.TabIndex = 2;
            this.windowsForm1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.windowsForm1.Title_Height = 50;
            this.windowsForm1.Title_Icon = null;
            this.windowsForm1.Title_Visible = true;
            this.windowsForm1.CloseClick += new System.EventHandler(this.windowsForm1_CloseClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_UNWORK_TIME
            // 
            this.lbl_UNWORK_TIME.AutoSize = true;
            this.lbl_UNWORK_TIME.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_UNWORK_TIME.ForeColor = System.Drawing.Color.Magenta;
            this.lbl_UNWORK_TIME.Location = new System.Drawing.Point(104, 149);
            this.lbl_UNWORK_TIME.Name = "lbl_UNWORK_TIME";
            this.lbl_UNWORK_TIME.Size = new System.Drawing.Size(0, 50);
            this.lbl_UNWORK_TIME.TabIndex = 4;
            // 
            // btn_End
            // 
            this.btn_End.BackColor = System.Drawing.SystemColors.Control;
            this.btn_End.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_End.BorderBottom = true;
            this.btn_End.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_End.BorderColorSelect = System.Drawing.Color.Blue;
            this.btn_End.BorderLeft = true;
            this.btn_End.BorderRight = true;
            this.btn_End.BorderTop = true;
            this.btn_End.BorderWidth = 0;
            this.btn_End.ButtonSelected = false;
            this.btn_End.Caption = "비가동 종료";
            this.btn_End.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.btn_End.FontSize = 18F;
            this.btn_End.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_End.ForeColor = System.Drawing.Color.Black;
            this.btn_End.ForeColorSelect = System.Drawing.Color.Red;
            this.btn_End.IConImage1 = null;
            this.btn_End.IConImage2 = null;
            this.btn_End.IConViewFlag = false;
            this.btn_End.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_End.ImageButton")));
            this.btn_End.ImageButtonViewFlag = false;
            this.btn_End.Location = new System.Drawing.Point(473, 232);
            this.btn_End.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_End.Name = "btn_End";
            this.btn_End.Padding = new System.Windows.Forms.Padding(1);
            this.btn_End.SelectedWidth = 3;
            this.btn_End.Size = new System.Drawing.Size(183, 51);
            this.btn_End.TabIndex = 5;
            this.btn_End.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_End.TScale = 1F;
            this.btn_End.ButtonClick += new System.EventHandler(this.btn_End_ButtonClick);
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
            this.tButton1.Caption = "비가동 전환";
            this.tButton1.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.tButton1.FontSize = 18F;
            this.tButton1.FontStyle = System.Drawing.FontStyle.Regular;
            this.tButton1.ForeColor = System.Drawing.Color.Black;
            this.tButton1.ForeColorSelect = System.Drawing.Color.Red;
            this.tButton1.IConImage1 = null;
            this.tButton1.IConImage2 = null;
            this.tButton1.IConViewFlag = false;
            this.tButton1.ImageButton = ((System.Drawing.Image)(resources.GetObject("tButton1.ImageButton")));
            this.tButton1.ImageButtonViewFlag = false;
            this.tButton1.Location = new System.Drawing.Point(91, 233);
            this.tButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tButton1.Name = "tButton1";
            this.tButton1.Padding = new System.Windows.Forms.Padding(1);
            this.tButton1.SelectedWidth = 3;
            this.tButton1.Size = new System.Drawing.Size(183, 50);
            this.tButton1.TabIndex = 6;
            this.tButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tButton1.TScale = 1F;
            this.tButton1.ButtonClick += new System.EventHandler(this.tButton1_ButtonClick);
            // 
            // btn_ING
            // 
            this.btn_ING.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ING.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_ING.BorderBottom = true;
            this.btn_ING.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_ING.BorderColorSelect = System.Drawing.Color.Blue;
            this.btn_ING.BorderLeft = true;
            this.btn_ING.BorderRight = true;
            this.btn_ING.BorderTop = true;
            this.btn_ING.BorderWidth = 0;
            this.btn_ING.ButtonSelected = false;
            this.btn_ING.Caption = "비가동 점검";
            this.btn_ING.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.btn_ING.FontSize = 18F;
            this.btn_ING.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_ING.ForeColor = System.Drawing.Color.Black;
            this.btn_ING.ForeColorSelect = System.Drawing.Color.Red;
            this.btn_ING.IConImage1 = null;
            this.btn_ING.IConImage2 = null;
            this.btn_ING.IConViewFlag = false;
            this.btn_ING.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_ING.ImageButton")));
            this.btn_ING.ImageButtonViewFlag = false;
            this.btn_ING.Location = new System.Drawing.Point(282, 233);
            this.btn_ING.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ING.Name = "btn_ING";
            this.btn_ING.Padding = new System.Windows.Forms.Padding(1);
            this.btn_ING.SelectedWidth = 3;
            this.btn_ING.Size = new System.Drawing.Size(183, 50);
            this.btn_ING.TabIndex = 7;
            this.btn_ING.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ING.TScale = 1F;
            this.btn_ING.ButtonClick += new System.EventHandler(this.btn_ING_ButtonClick);
            // 
            // CTL_P9001C1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ING);
            this.Controls.Add(this.tButton1);
            this.Controls.Add(this.btn_End);
            this.Controls.Add(this.lbl_UNWORK_TIME);
            this.Controls.Add(this.lbl_UNWORK_NM);
            this.Controls.Add(this.windowsForm1);
            this.Name = "CTL_P9001C1";
            this.Size = new System.Drawing.Size(684, 307);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UNWORK_NM;
        private TGSControl.WindowsForm windowsForm1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_UNWORK_TIME;
        private TGSControl.TButton btn_End;
        private TGSControl.TButton tButton1;
        private TGSControl.TButton btn_ING;
    }
}
