﻿namespace MES_APP_P90
{
    partial class CTL_P9001C2
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
            this.lbl_UNWORK_TIME = new System.Windows.Forms.Label();
            this.lbl_UNWORK_NM = new System.Windows.Forms.Label();
            this.windowsForm1 = new TGSControl.WindowsForm();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_UNWORK_TIME
            // 
            this.lbl_UNWORK_TIME.AutoSize = true;
            this.lbl_UNWORK_TIME.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_UNWORK_TIME.ForeColor = System.Drawing.Color.Magenta;
            this.lbl_UNWORK_TIME.Location = new System.Drawing.Point(104, 117);
            this.lbl_UNWORK_TIME.Name = "lbl_UNWORK_TIME";
            this.lbl_UNWORK_TIME.Size = new System.Drawing.Size(206, 50);
            this.lbl_UNWORK_TIME.TabIndex = 7;
            this.lbl_UNWORK_TIME.Text = "경과시간 : ";
            // 
            // lbl_UNWORK_NM
            // 
            this.lbl_UNWORK_NM.AutoSize = true;
            this.lbl_UNWORK_NM.Font = new System.Drawing.Font("맑은 고딕", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_UNWORK_NM.ForeColor = System.Drawing.Color.Blue;
            this.lbl_UNWORK_NM.Location = new System.Drawing.Point(92, 37);
            this.lbl_UNWORK_NM.Name = "lbl_UNWORK_NM";
            this.lbl_UNWORK_NM.Size = new System.Drawing.Size(295, 71);
            this.lbl_UNWORK_NM.TabIndex = 6;
            this.lbl_UNWORK_NM.Text = "비가동내역";
            // 
            // windowsForm1
            // 
            this.windowsForm1.BorderColor = System.Drawing.Color.Fuchsia;
            this.windowsForm1.Caption = "";
            this.windowsForm1.Close_Visible = false;
            this.windowsForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowsForm1.Location = new System.Drawing.Point(0, 0);
            this.windowsForm1.Margin = new System.Windows.Forms.Padding(0);
            this.windowsForm1.Name = "windowsForm1";
            this.windowsForm1.Size = new System.Drawing.Size(788, 204);
            this.windowsForm1.TabIndex = 5;
            this.windowsForm1.Title_Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CTL_P0401C2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_UNWORK_TIME);
            this.Controls.Add(this.lbl_UNWORK_NM);
            this.Controls.Add(this.windowsForm1);
            this.Name = "CTL_P0401C2";
            this.Size = new System.Drawing.Size(788, 204);
            this.Resize += new System.EventHandler(this.CTL_P0401C2_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UNWORK_TIME;
        private System.Windows.Forms.Label lbl_UNWORK_NM;
        private TGSControl.WindowsForm windowsForm1;
        private System.Windows.Forms.Timer timer1;
    }
}
