namespace MES_APP_P90
{
    partial class APP_P9001MA2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APP_P9001MA2));
            this.Panel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Doc = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Cmd = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Cancel = new TGSControl.TButton();
            this.btn_Save = new TGSControl.TButton();
            this.Panel_Condition = new System.Windows.Forms.TableLayoutPanel();
            this.cboWorker = new TGSControl.TCombo();
            this.cboFacility = new TGSControl.TCombo();
            this.tLabel2 = new TGSControl.TLabel();
            this.tLabel4 = new TGSControl.TLabel();
            this.tLabel1 = new TGSControl.TLabel();
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.tLabel3 = new TGSControl.TLabel();
            this.cboSHIFT = new TGSControl.TCombo();
            this.Panel_Main.SuspendLayout();
            this.Panel_Doc.SuspendLayout();
            this.Panel_Cmd.SuspendLayout();
            this.Panel_Condition.SuspendLayout();
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
            this.Panel_Main.Size = new System.Drawing.Size(1000, 610);
            this.Panel_Main.TabIndex = 1;
            // 
            // Panel_Doc
            // 
            this.Panel_Doc.ColumnCount = 1;
            this.Panel_Doc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Doc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Panel_Doc.Controls.Add(this.Panel_Cmd, 0, 2);
            this.Panel_Doc.Controls.Add(this.Panel_Condition, 0, 0);
            this.Panel_Doc.Controls.Add(this.Grid1, 0, 1);
            this.Panel_Doc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Doc.Location = new System.Drawing.Point(0, 0);
            this.Panel_Doc.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Doc.Name = "Panel_Doc";
            this.Panel_Doc.RowCount = 3;
            this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Doc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.Panel_Doc.Size = new System.Drawing.Size(1000, 610);
            this.Panel_Doc.TabIndex = 1;
            // 
            // Panel_Cmd
            // 
            this.Panel_Cmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.Panel_Cmd.ColumnCount = 4;
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Panel_Cmd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Panel_Cmd.Controls.Add(this.btn_Cancel, 3, 0);
            this.Panel_Cmd.Controls.Add(this.btn_Save, 1, 0);
            this.Panel_Cmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Cmd.Location = new System.Drawing.Point(0, 555);
            this.Panel_Cmd.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Cmd.Name = "Panel_Cmd";
            this.Panel_Cmd.RowCount = 1;
            this.Panel_Cmd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Cmd.Size = new System.Drawing.Size(1000, 55);
            this.Panel_Cmd.TabIndex = 2;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.BorderBottom = true;
            this.btn_Cancel.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.BorderLeft = true;
            this.btn_Cancel.BorderRight = true;
            this.btn_Cancel.BorderTop = true;
            this.btn_Cancel.ButtonSelected = false;
            this.btn_Cancel.Caption = "닫기";
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Cancel.FontSize = 14.25F;
            this.btn_Cancel.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_Cancel.IConViewFlag = false;
            this.btn_Cancel.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.ImageButton")));
            this.btn_Cancel.ImageButtonViewFlag = false;
            this.btn_Cancel.Location = new System.Drawing.Point(513, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Cancel.Size = new System.Drawing.Size(484, 49);
            this.btn_Cancel.TabIndex = 175;
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.ButtonClick += new System.EventHandler(this.btn_Cancel_ButtonClick);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Save.BorderBackColor = System.Drawing.SystemColors.Control;
            this.btn_Save.BorderBottom = true;
            this.btn_Save.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_Save.BorderLeft = true;
            this.btn_Save.BorderRight = true;
            this.btn_Save.BorderTop = true;
            this.btn_Save.ButtonSelected = false;
            this.btn_Save.Caption = "저장";
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Save.FontSize = 14.25F;
            this.btn_Save.FontStyle = System.Drawing.FontStyle.Regular;
            this.btn_Save.IConViewFlag = false;
            this.btn_Save.ImageButton = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageButton")));
            this.btn_Save.ImageButtonViewFlag = false;
            this.btn_Save.Location = new System.Drawing.Point(3, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Save.Size = new System.Drawing.Size(484, 49);
            this.btn_Save.TabIndex = 174;
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Save.ButtonClick += new System.EventHandler(this.btn_Save_ButtonClick);
            // 
            // Panel_Condition
            // 
            this.Panel_Condition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.Panel_Condition.ColumnCount = 6;
            this.Panel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.933775F));
            this.Panel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.16556F));
            this.Panel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.933775F));
            this.Panel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.86755F));
            this.Panel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.933775F));
            this.Panel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.16556F));
            this.Panel_Condition.Controls.Add(this.cboSHIFT, 3, 1);
            this.Panel_Condition.Controls.Add(this.tLabel3, 2, 1);
            this.Panel_Condition.Controls.Add(this.cboWorker, 5, 1);
            this.Panel_Condition.Controls.Add(this.cboFacility, 1, 1);
            this.Panel_Condition.Controls.Add(this.tLabel2, 0, 1);
            this.Panel_Condition.Controls.Add(this.tLabel4, 4, 1);
            this.Panel_Condition.Controls.Add(this.tLabel1, 0, 0);
            this.Panel_Condition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Condition.Location = new System.Drawing.Point(0, 0);
            this.Panel_Condition.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Condition.Name = "Panel_Condition";
            this.Panel_Condition.RowCount = 2;
            this.Panel_Condition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Panel_Condition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Panel_Condition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Panel_Condition.Size = new System.Drawing.Size(1000, 80);
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
            this.cboWorker.Location = new System.Drawing.Point(749, 43);
            this.cboWorker.Name = "cboWorker";
            this.cboWorker.SelectedIndex = -1;
            this.cboWorker.Size = new System.Drawing.Size(248, 34);
            this.cboWorker.TabIndex = 25;
            this.cboWorker.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cboWorker.Value = "";
            this.cboWorker.ValueCaption = "Code";
            this.cboWorker.ValueMember = "CODE_ID";
            this.cboWorker.ValueName = "";
            this.cboWorker.SelectedValueChanged += new System.EventHandler(this.cboWorker_SelectedValueChanged);
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
            this.cboFacility.DisplayCaption = "Code Name";
            this.cboFacility.DisplayMember = "CODE_NM";
            this.cboFacility.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboFacility.FontSize = 14.25F;
            this.cboFacility.FontStyle = System.Drawing.FontStyle.Regular;
            this.cboFacility.Location = new System.Drawing.Point(102, 43);
            this.cboFacility.Name = "cboFacility";
            this.cboFacility.SelectedIndex = -1;
            this.cboFacility.Size = new System.Drawing.Size(245, 34);
            this.cboFacility.TabIndex = 24;
            this.cboFacility.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cboFacility.Value = "";
            this.cboFacility.ValueCaption = "Code";
            this.cboFacility.ValueMember = "CODE_ID";
            this.cboFacility.ValueName = "";
            this.cboFacility.SelectedValueChanged += new System.EventHandler(this.cboFacility_SelectedValueChanged);
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
            this.tLabel2.Caption = "설비";
            this.tLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLabel2.FontSize = 14.25F;
            this.tLabel2.FontStyle = System.Drawing.FontStyle.Regular;
            this.tLabel2.Location = new System.Drawing.Point(2, 42);
            this.tLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.tLabel2.Name = "tLabel2";
            this.tLabel2.Size = new System.Drawing.Size(95, 36);
            this.tLabel2.TabIndex = 23;
            this.tLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tLabel2.Value = "설비";
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
            this.tLabel4.Caption = "점검자";
            this.tLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLabel4.FontSize = 14.25F;
            this.tLabel4.FontStyle = System.Drawing.FontStyle.Regular;
            this.tLabel4.Location = new System.Drawing.Point(649, 42);
            this.tLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.tLabel4.Name = "tLabel4";
            this.tLabel4.Size = new System.Drawing.Size(95, 36);
            this.tLabel4.TabIndex = 22;
            this.tLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tLabel4.Value = "점검자";
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
            this.tLabel1.Caption = "설 비 일 상  점 검";
            this.Panel_Condition.SetColumnSpan(this.tLabel1, 6);
            this.tLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLabel1.FontSize = 14.25F;
            this.tLabel1.FontStyle = System.Drawing.FontStyle.Regular;
            this.tLabel1.Location = new System.Drawing.Point(2, 2);
            this.tLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.tLabel1.Name = "tLabel1";
            this.tLabel1.Size = new System.Drawing.Size(996, 36);
            this.tLabel1.TabIndex = 8;
            this.tLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tLabel1.Value = "설 비 일 상  점 검";
            // 
            // Grid1
            // 
            this.Grid1.AllowUserToAddRows = false;
            this.Grid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Grid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Grid1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid1.DefaultCellStyle = dataGridViewCellStyle8;
            this.Grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid1.Location = new System.Drawing.Point(3, 83);
            this.Grid1.MultiSelect = false;
            this.Grid1.Name = "Grid1";
            this.Grid1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Grid1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.Grid1.RowTemplate.Height = 39;
            this.Grid1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid1.Size = new System.Drawing.Size(994, 469);
            this.Grid1.TabIndex = 46;
            this.Grid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid1_CellClick);
            // 
            // tLabel3
            // 
            this.tLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.tLabel3.BorderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(229)))));
            this.tLabel3.BorderBottom = true;
            this.tLabel3.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.tLabel3.BorderLeft = true;
            this.tLabel3.BorderRight = true;
            this.tLabel3.BorderTop = true;
            this.tLabel3.Caption = "주/야";
            this.tLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLabel3.FontSize = 14.25F;
            this.tLabel3.FontStyle = System.Drawing.FontStyle.Regular;
            this.tLabel3.Location = new System.Drawing.Point(352, 42);
            this.tLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.tLabel3.Name = "tLabel3";
            this.tLabel3.Size = new System.Drawing.Size(95, 36);
            this.tLabel3.TabIndex = 26;
            this.tLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tLabel3.Value = "주/야";
            // 
            // cboSHIFT
            // 
            this.cboSHIFT.BackColor = System.Drawing.SystemColors.Window;
            this.cboSHIFT.BorderBackColor = System.Drawing.SystemColors.Window;
            this.cboSHIFT.BorderBottom = true;
            this.cboSHIFT.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.cboSHIFT.BorderLeft = true;
            this.cboSHIFT.BorderRight = false;
            this.cboSHIFT.BorderTop = true;
            this.cboSHIFT.Caption = "";
            this.cboSHIFT.DisplayCaption = "Code Name";
            this.cboSHIFT.DisplayMember = "CODE_NM";
            this.cboSHIFT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboSHIFT.FontSize = 14.25F;
            this.cboSHIFT.FontStyle = System.Drawing.FontStyle.Regular;
            this.cboSHIFT.Location = new System.Drawing.Point(452, 43);
            this.cboSHIFT.Name = "cboSHIFT";
            this.cboSHIFT.SelectedIndex = -1;
            this.cboSHIFT.Size = new System.Drawing.Size(192, 34);
            this.cboSHIFT.TabIndex = 27;
            this.cboSHIFT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cboSHIFT.Value = "";
            this.cboSHIFT.ValueCaption = "Code";
            this.cboSHIFT.ValueMember = "CODE_ID";
            this.cboSHIFT.ValueName = "";
            // 
            // APP_P0301M1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Panel_Main);
            this.Name = "APP_P0301M1";
            this.Size = new System.Drawing.Size(1000, 610);
            this.Panel_Main.ResumeLayout(false);
            this.Panel_Doc.ResumeLayout(false);
            this.Panel_Cmd.ResumeLayout(false);
            this.Panel_Condition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Panel_Main;
        private System.Windows.Forms.TableLayoutPanel Panel_Doc;
        private System.Windows.Forms.TableLayoutPanel Panel_Cmd;
        private TGSControl.TButton btn_Save;
        private System.Windows.Forms.TableLayoutPanel Panel_Condition;
        private TGSControl.TCombo cboWorker;
        private TGSControl.TCombo cboFacility;
        private TGSControl.TLabel tLabel2;
        private TGSControl.TLabel tLabel4;
        private TGSControl.TLabel tLabel1;
        private System.Windows.Forms.DataGridView Grid1;
        private TGSControl.TButton btn_Cancel;
        private TGSControl.TCombo cboSHIFT;
        private TGSControl.TLabel tLabel3;
    }
}
