using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TGSClass;
using TGSClass.nsGlobal;
using TGSClass.nsWorkCode;

using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

using System.Web.Services.Protocols;

namespace MES_APP_P90
{
    public partial class APP_P9005MA3 : UserControl
    {
        #region ▶ 1. Declaration part  //선언부

        String _PG_NM = "PDA DATA 조회";

        String Msg = "";
        String msg1 = "";

        public string sPRODT_ORDER_NO = "";
        public string sOPR_NO = "";
        public Int16 sCnt = 0;
        DataSet sResultData = new DataSet();

        #region ■ 1.1 Program information      //프로그램 정보 및 수정 이력 정보
        /// <TemplateVersion>0.0.1.0</TemplateVersion>
        /// <NameSpace>①namespace</NameSpace>
        /// <Module>②module name</Module>
        /// <Class>③class name</Class>
        /// <Desc>④
        ///   This part describe the summary information about class 
        /// </Desc>
        /// <History>⑤
        ///   <FirstCreated>
        ///     <history name="creator" Date="created date">Make …</history>
        ///   </FirstCreated>
        ///   <Lastmodified>
        ///     <history name="modifier"  Date="modified date"> contents </history>
        ///     <history name="modifier"  Date="modified date"> contents </history>
        ///     <history name="modifier"  Date="modified date"> contents </history>
        ///   </Lastmodified>
        /// </History>
        /// <Remarks>⑥
        ///   <remark name="modifier"  Date="modified date">… </remark>
        ///   <remark name="modifier"  Date="modified date">… </remark>
        /// </Remarks>

        #endregion

        #region ■ 1.2. Class global constants (common) //글로벌 상수 선언


        //이벤트 선언
        private CommandRunEventHandler commandRuned;


        public event CommandRunEventHandler CommandRuned
        {
            add
            {
                this.commandRuned += value;
            }
            remove
            {
                this.commandRuned -= value;
            }
        }

        [Category("시작변수"), Description("파라메터 전달 및 결과값 반환을 위해 사용합니다.")]
        public DataSet ResultData
        {
            get
            {
                return sResultData;
            }
            set
            {
                sResultData = value;
            }
        }

        public struct GetValueName
        {
            public const string PLANT_CD = "PLANT_CD";
            public const string ITEM_CD = "ITEM_CD";
            public const string RESULT_NO = "RESULT_NO";
        }
        public struct SetValueName
        {
            public const string PLANT_CD = "PLANT_CD";
            public const string WC_MGR = "WC_MGR";
            public const string WC_CD = "WC_CD";
            public const string FACILITY_CD = "FACILITY_CD";
            public const string WORKER_CD = "WORKER_CD";
        }


        public struct grid1_COLUMN
        {
            ///<summary>품목</summary>
            public const string ITEM_CD = "ITEM_CD";
            ///<summary>품명</summary>
            public const string ITEM_NM = "ITEM_NM";
            ///<summary>규격</summary>
            public const string SPEC = "SPEC";
            ///<summary>상위LOT</summary>
            public const string UPPER_LOT = "UPPER_LOT";
            ///<summary>제조오더번호</summary>
            public const string PRODT_ORDER_NO = "PRODT_ORDER_NO";
            ///<summary>출하번호</summary>
            public const string DN_NO = "DN_NO";
            ///<summary>입고번호</summary>
            public const string MVMT_NO = "MVMT_NO";
            ///<summary>등록시각</summary>
            public const string INSRT_DT = "INSRT_DT";
            ///<summary>등록자</summary>
            public const string INSRT_USER_ID = "INSRT_USER_ID";
        }


        #endregion

        #region ■ 1.3. Class global variables (common) //글로벌 변수 선언

        private bool bFormLoaded = false;
        private bool bWorkStopStarted = false;
        Global global = new Global();
        Form sMainForm;

        string sPLANT_CD = "";      //공장
        string sWC_MGR = "";        //
        string sWC_MGR_NM = "";     //
        string sWC_CD = "";         //작업장
        string sWC_NM = "";      //작업장
        string sFACILITY_CD = "";   //설비번호
        string sFACILITY_NM = "";   //설비번호
        string sWORKER_CD = "";     //작업자
        string sWORKER_NM = "";     //작업자

        #endregion

        #region ■ 1.4. Class global property (common) //컨트롤 변수 선언

        public Form MainForm    //메인폼
        {
            get
            {
                return sMainForm;
            }
            set
            {
                sMainForm = value;
            }
        }



        #endregion

        #endregion

        #region ▶ 2. Initialization part

        #region ■ 2.1 Constructor(common)      //생성자

        public APP_P9005MA3()
        {
            InitializeComponent();
        }

        #endregion

        #region ■ 2.2 Form_Load(common)    //Control이 로딩시

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void initControl()  //컨트롤 초기화
        {
            InitLocalVariables();   //로컬 변수 선언
            SetLocalDefaultValue(); //로컬 변수 값 지정
            GatheringComboData();   //로컬 콤보 로딩
            InitSpreadSheet();     //스프레드시트 초기화

        }


        public void Start() //시작
        {

            initControl(); //컨트롤 초기화

            InitData();    //초기값 설정

            //DBQuery();     //조회

        }


        //외부에서 명령을 실행한다.
        public void CommandRun(DataSet ds)
        {
            if (ds.Tables["COMMAND"] != null)
            {
                for (int i = 0; i < ds.Tables["COMMAND"].Rows.Count; i++)
                {
                    switch (ds.Tables["COMMAND"].Rows[i][0].ToString().ToUpper())
                    {
                        case "DBQUERY":
                            DBQuery();
                            break;

                        case "APP_RUN":

                            sPLANT_CD = ds.Tables["PassData"].Rows[0]["PLANT_CD"].ToString();
                            sWC_MGR = ds.Tables["PassData"].Rows[0]["WC_MGR"].ToString();
                            sWC_MGR_NM = ds.Tables["PassData"].Rows[0]["WC_MGR_NM"].ToString();
                            sWC_CD = ds.Tables["PassData"].Rows[0]["WC_CD"].ToString();
                            sWC_NM = ds.Tables["PassData"].Rows[0]["WC_NM"].ToString();

                            InitData();
                            DBQuery();

                            break;
                    }
                }
            }
        }

        public void CommandRun(string CommandString)
        {
            CommandString.Split(TGSClass.nsGlobal.Global.Separation.COLUMNS);

            DataSet vSendData = new DataSet();

            vSendData.Tables.Add("COMMAND");
            vSendData.Tables["COMMAND"].Columns.Add("COMMAND_ID");
            vSendData.Tables["COMMAND"].Columns.Add("REFERENCE1");
            vSendData.Tables["COMMAND"].Columns.Add("REFERENCE2");
            vSendData.Tables["COMMAND"].Columns.Add("REFERENCE3");
            vSendData.Tables["COMMAND"].Columns.Add("REFERENCE4");

            vSendData.Tables["COMMAND"].Rows.Add("DBQUERY");
            vSendData.Tables["COMMAND"].Rows.Add(CommandString, "", "", "", "");

            CommandRun(vSendData);

        }

        //명령이벤트를 발생시킨다.
        private void CommandRun_Event(DataSet ds)
        {
            //DataSet vSendData = new DataSet();

            //vSendData.Tables.Add("COMMAND");

            //이벤트 argument 설정
            CommandRunEventArgs args = new CommandRunEventArgs(ds);
            //이벤트 발생
            if (commandRuned != null)
                commandRuned(this, args);

        }
        //내부에서 명령을 생성해준후 명령이벤트를 실행한다.
        private void CommandRun_Event(int index)
        {

            DataSet vSendData = new DataSet();

            vSendData.Tables.Add("COMMAND");


            if (index == 0)
            {
                vSendData.Tables["COMMAND"].Columns.Add("COMMAND_ID");
                vSendData.Tables["COMMAND"].Columns.Add("REFERENCE1");
                vSendData.Tables["COMMAND"].Columns.Add("REFERENCE2");
                vSendData.Tables["COMMAND"].Columns.Add("REFERENCE3");
                vSendData.Tables["COMMAND"].Columns.Add("REFERENCE4");

                //switch (sWC_MGR)
                //{
                //    case "10":
                //        vSendData.Tables["COMMAND"].Rows.Add("APP_RUN", "MES_APP_P00.APP_P2003M1", "", "", "");
                //        break;
                //    case "20":
                //        vSendData.Tables["COMMAND"].Rows.Add("APP_RUN", "MES_APP_P50.APP_P5001M1", "", "", "");
                //        break;
                //    case "30":
                //        vSendData.Tables["COMMAND"].Rows.Add("APP_RUN", "MES_APP_P50.APP_P3001M1", "", "", "");
                //        break;
                //    case "40":
                //        vSendData.Tables["COMMAND"].Rows.Add("APP_RUN", "MES_APP_P50.APP_P5001M1", "", "", "");
                //        break;
                //    case "50":
                //        vSendData.Tables["COMMAND"].Rows.Add("APP_RUN", "MES_APP_P50.APP_P5001M1", "", "", "");
                //        break;
                //}

                //vSendData.Tables.Add("PassData");

                //vSendData.Tables["PassData"].Columns.Add("PLANT_CD");
                //vSendData.Tables["PassData"].Columns.Add("WC_MGR");
                //vSendData.Tables["PassData"].Columns.Add("WC_CD");
                //vSendData.Tables["PassData"].Columns.Add("FACILITY_CD");
                //vSendData.Tables["PassData"].Columns.Add("WORKER_CD");


                //vSendData.Tables["PassData"].Rows.Add();

                //vSendData.Tables["PassData"].Rows[0]["PLANT_CD"] = sPLANT_CD;
                //vSendData.Tables["PassData"].Rows[0]["WC_MGR"] = sWC_MGR;
                //vSendData.Tables["PassData"].Rows[0]["WC_CD"] = sWC_CD;
                //vSendData.Tables["PassData"].Rows[0]["FACILITY_CD"] = cboFacility.Value;
                //vSendData.Tables["PassData"].Rows[0]["WORKER_CD"] = cboWorker.Value;
            }

            CommandRun_Event(vSendData);  //이벤트 실행
        }
        public void CommandRun_Event(string CommandString)
        {
            //CommandString.Split(nsWinUtilGlobal.Global.Separation.COLUMNS);

            DataSet vSendData = new DataSet();

            vSendData.Tables.Add("COMMAND");
            vSendData.Tables["COMMAND"].Columns.Add("COMMAND_ID");
            vSendData.Tables["COMMAND"].Columns.Add("REFERENCE1");
            vSendData.Tables["COMMAND"].Columns.Add("REFERENCE2");
            vSendData.Tables["COMMAND"].Columns.Add("REFERENCE3");
            vSendData.Tables["COMMAND"].Columns.Add("REFERENCE4");

            //vSendData.Tables["COMMAND"].Rows.Add("DBQUERY");
            vSendData.Tables["COMMAND"].Rows.Add(CommandString, "", "", "", "");

            CommandRun_Event(vSendData);

        }


        public string GetValue(string pValueName)
        {
            switch (pValueName)
            {
                case GetValueName.PLANT_CD:
                    return sPLANT_CD;

                default:
                    return "";
            }
        }

        public void SetValue(string pValueName, string pValue)
        {
            switch (pValueName)
            {
                case SetValueName.WC_CD:
                    sWC_CD = pValue;
                    break;
                case SetValueName.PLANT_CD:
                    sPLANT_CD = pValue;
                    break;
                case SetValueName.WC_MGR:
                    sWC_MGR = pValue;
                    break;
                case SetValueName.WORKER_CD:
                    sWORKER_CD = pValue;
                    break;
                case SetValueName.FACILITY_CD:
                    sFACILITY_CD = pValue;
                    break;
            }
        }
        #endregion ■ 2.2 Form_Load(common)

        #region ■ 2.3 Initializatize local global variables

        protected void InitLocalVariables()
        {
            // init OperationMode is Create Mode
            //base.viewDBSaveMode = enumDef.DBSaveMode.CreateMode;

        }

        #endregion

        #region ■ 2.4 Set local global default variables   //초기변수값 설정

        protected void SetLocalDefaultValue()
        {
            if (MainForm == null)
            {
                if (this.ParentForm != null) MainForm = this.ParentForm;
            }

            if (sPLANT_CD == "") sPLANT_CD = Global.workinfo.szFactoryCD;
            if (sWC_MGR == "") sWC_MGR = Global.workinfo.szProcessCD;
            if (sWC_MGR_NM == "") sWC_MGR_NM = Global.workinfo.szProcessNM;
            if (sFACILITY_CD == "") sFACILITY_CD = Global.workinfo.szFacilityCD;
            if (sFACILITY_NM == "") sFACILITY_NM = Global.workinfo.szFacilityNM;
            if (sWC_CD == "") sWC_CD = Global.workinfo.szWorkSpaceCD;
            if (sWC_NM == "") sWC_NM = Global.workinfo.szWorkSpaceNM;
            if (sWORKER_CD == "") sWORKER_CD = Global.workinfo.szOperatorCD;
            if (sWORKER_NM == "") sWORKER_NM = Global.workinfo.szOperatorNM;

            if (sResultData.Tables["PassData"] != null)
            {
                if (sResultData.Tables["PassData"].Rows.Count > 0)
                {
                }
            }
            SetLocalDefaultValue_site();
        }


        #endregion

        #region ■ 2.5 Gathering combo data(GatheringComboData) //콤보관련 데이타 설정

        protected void GatheringComboData()
        {
            if (Global.workinfo.szServerIP == "") return;

        }

        #region ▶▶▶ 공용코드 콤보 셋팅
        private void Fnc_crt_combo(TGSControl.TCombo combo, string @FLAG, int idx, string @MAJOR_CD)
        {
            Fnc_crt_combo(combo, @FLAG, idx, @MAJOR_CD, "코드", "코드명", "코드선택", "", "", "");
        }
        private void Fnc_crt_combo(TGSControl.TCombo combo, string @MAJOR_CD, string @FLAG, int idx, string p_Caption)
        {
            Fnc_crt_combo(combo, @FLAG, idx, @MAJOR_CD, "코드", "코드명", p_Caption, "", "", "");
        }
        private void Fnc_crt_combo(TGSControl.TCombo combo, string @FLAG, int idx, string p_ValueCaption, string p_DisplayCaption, string p_Caption, string @MAJOR_CD)
        {
            Fnc_crt_combo(combo, @FLAG, idx, @MAJOR_CD, p_ValueCaption, p_DisplayCaption, p_Caption, "", "", "");
        }
        private void Fnc_crt_combo(TGSControl.TCombo combo, string @FLAG, int idx, string p_ValueCaption, string p_DisplayCaption, string @Caption, string @MAJOR_CD, string @ARR1, string @ARR2, string @ARR3)
        {
            combo.Clear();

            DataTable dataT;
            dataT = new DataTable();

            string pValueMember = "code";
            string pDisplayMember = "name";

            string strSql = "";

            switch (@FLAG)
            {
                case "WORKER":    // 작업자 
                    strSql = "EXEC DBO.XUSP_MES_P3101Q1_GET_WORKER ";
                    strSql += "@PLANT_CD='" + sPLANT_CD + "',";
                    strSql += "@WC_MGR='" + sWC_MGR + "'";

                    pValueMember = "USER_ID";
                    pDisplayMember = "EMP_DESC";
                    break;

                case "COMM":    // TPC-COMM
                    strSql = " SELECT DISTINCT RTRIM(T.code) AS code, RTRIM(T.name) AS name ";
                    strSql += " FROM ( ";
                    strSql += " SELECT T.LVL AS LVL, RTRIM(T.CODE) AS code, RTRIM(T.NAME) AS name ";
                    strSql += " FROM DBO.ZZ_TPC_TBL_COMM('" + sPLANT_CD + "' , '" + @ARR1 + "'  , '" + @ARR2 + "', '" + @ARR3 + "' ) T  ";
                    strSql += " WHERE  1=1  ";
                    strSql += "  ) T ";
                    break;

                case "UD_MAJOR_CD":    // 사용자정의-공통코드..
                    strSql = " SELECT DISTINCT RTRIM(AA.code) AS code, RTRIM(AA.name) AS name ";
                    strSql += " FROM ( ";
                    strSql += " SELECT  '1' AS LVL, '' AS code, '' AS name ";
                    strSql += " UNION ALL ";
                    strSql += " SELECT '2' AS LVL, RTRIM(AA.UD_MINOR_CD) AS code, RTRIM(AA.UD_MINOR_NM) AS name ";
                    strSql += " FROM B_USER_DEFINED_MINOR AA (NOLOCK) ";
                    strSql += " WHERE RTRIM(AA.UD_MAJOR_CD) = RTRIM('" + @MAJOR_CD + "')  ) AA ";
                    ////strSql += " WHERE AA.LVL = '2' ";
                    break;

                default:    // 공통코드..
                    strSql = " SELECT DISTINCT RTRIM(AA.code) AS code, RTRIM(AA.name) AS name ";
                    strSql += " FROM ( ";
                    strSql += " SELECT  '1' AS LVL, '' AS code, '' AS name ";
                    strSql += " UNION ALL ";
                    strSql += " SELECT '2' AS LVL, RTRIM(AA.MINOR_CD) AS code, RTRIM(AA.MINOR_NM) AS name ";
                    strSql += " FROM B_MINOR AA (NOLOCK) ";
                    strSql += " WHERE RTRIM(AA.MAJOR_CD) = RTRIM('" + @MAJOR_CD + "')  ) AA ";
                    break;
            }
            try
            {
                //SqlDataAdapter sda = new SqlDataAdapter(strSql, Comm.DbConn.GetConn());
                //sda.Fill(dataT);
                int nCnt = 0;
                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strSql, ref dataT, ref nCnt);
                if (dataT.Rows.Count > 0)
                {
                    combo.DataSource = dataT;
                    combo.ValueMember = pValueMember;
                    combo.DisplayMember = pDisplayMember;

                    combo.Caption = @Caption;
                    combo.ValueCaption = p_ValueCaption;
                    combo.DisplayCaption = p_DisplayCaption;

                    //combo.DataBind();
                    if (idx >= 0) combo.SelectedIndex = idx;
                }
            }
            catch (Exception ex)
            {
                TGSControl.UsrFunction.MessageBoxErr(ex.Message, "기준정보조회");

                return;
            }
        }
        #endregion ▶▶▶ 공용코드 콤보 셋팅

        #endregion

        #region ■ 2.6 Define user defined numeric info

        //public void LoadCustomInfTB19029()
        //{

        //    #region User Define Numeric Format Data Setting  ☆
        //    //base.viewTB19029.ggUserDefined6.DecPoint = 0;
        //    //base.viewTB19029.ggUserDefined6.Integeral = 15;
        //    #endregion
        //}

        #endregion

        #endregion


        #region ▶ 3. Grid method part

        #region ■ 3.1 Initialize Grid (InitSpreadSheet)

        private void InitSpreadSheet()  //전체 스프레드시트를 초기화 한다.
        {
            InitSpreadSheet(1); //GRID1
            InitSpreadSheet(2); //GRID2
        }

        private void InitSpreadSheet(int p_GridIndex)   //선택된 스프레드시트를 초기화 한다.
        {
            if (p_GridIndex == 1)
            {
                #region ■■ 3.1.1 Pre-setting grid information
                Grid1.Columns.Clear();

                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("맑은 고딕", 11, FontStyle.Bold);
                columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                Grid1.RowHeadersVisible = false;

                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.ITEM_CD, "품목", 120));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.ITEM_NM, "품명", 80));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.SPEC, "규격", 80));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.UPPER_LOT, "상위LOT", 80));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.PRODT_ORDER_NO, "제조오더번호", 80));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.DN_NO, "출하번호", 80));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.MVMT_NO, "입고번호", 80));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.INSRT_DT, "등록시각", 80));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.INSRT_USER_ID, "등록자", 80));
                #endregion

                #region ■■ 3.1.2 Formatting grid information

                Grid1.Columns[grid1_COLUMN.ITEM_CD].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid1.Columns[grid1_COLUMN.ITEM_NM].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid1.Columns[grid1_COLUMN.SPEC].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                Grid1.Columns[grid1_COLUMN.UPPER_LOT].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid1.Columns[grid1_COLUMN.PRODT_ORDER_NO].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid1.Columns[grid1_COLUMN.DN_NO].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid1.Columns[grid1_COLUMN.MVMT_NO].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid1.Columns[grid1_COLUMN.INSRT_DT].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid1.Columns[grid1_COLUMN.INSRT_USER_ID].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                #endregion

                #region ■■ 3.1.3 Setting etc grid
                //Grid1.Columns[grid1_COLUMN.PRODT_ORDER_NO].Visible = false;
                #endregion
            }
        }

        #endregion

        #region ■ 3.2 InitData

        public void InitData()
        {
            DBQuery();
        }

        #endregion

        #region ■ 3.3 SetSpreadColor

        private void SetSpreadColor(int pvStartRow, int pvEndRow)
        {
            // TO-DO: InsertRow후 그리드 컬러 변경
            //uniGrid1.SSSetProtected(gridCol.LastNum, pvStartRow, pvEndRow);
        }
        #endregion


        #region ■ 3.3 grid method //그리드 관련 함수

        //그리그 Edit 컬럼 생성
        private DataGridViewColumn SetColumnEdit(string ColumnName, string HeaderText, int Width)
        {
            DataGridViewColumn myCol = new DataGridViewColumn();

            myCol.Name = ColumnName; myCol.HeaderText = HeaderText; myCol.Width = Width;


            DataGridViewCell myCell = new DataGridViewTextBoxCell();

            myCol.CellTemplate = myCell;


            if (myCol.Width == 0)
            {
                myCol.Visible = false;
            }
            else
            {
                myCol.Visible = true;
            }
            return myCol;

        }

        //그리드 Image 컬럼 생성
        private DataGridViewColumn SetColumnImage(string ColumnName, string HeaderText, int Width) //이미지컬럼을 생성한다.
        {
            DataGridViewImageColumn myCol = new DataGridViewImageColumn();


            myCol.Name = ColumnName; myCol.HeaderText = HeaderText; myCol.Width = Width;


            DataGridViewCell myCell = new DataGridViewImageCell();
            myCol.CellTemplate = myCell;


            if (myCol.Width == 0)
            {
                myCol.Visible = false;
            }
            else
            {
                myCol.Visible = true;
            }
            return myCol;

        }

        //그리드 버튼 컬럼 생성
        private DataGridViewColumn SetColumnButton(string ColumnName, string HeaderText, int Width) //그리드 버튼 생성한다.
        {
            DataGridViewButtonColumn myCol = new DataGridViewButtonColumn();

            //DataGridViewComboBoxColumn


            myCol.Name = ColumnName; myCol.HeaderText = HeaderText; myCol.Width = Width;


            DataGridViewButtonCell myCell = new DataGridViewButtonCell();
            myCol.CellTemplate = myCell;


            if (myCol.Width == 0)
            {
                myCol.Visible = false;
            }
            else
            {
                myCol.Visible = true;
            }
            return myCol;

        }

        #endregion

        #endregion

        #region ▶ 4. Toolbar method part

        #region ■ 4.1 Common Fnction group

        #region ■■ 4.1.1 OnFncQuery

        public bool OnFncQuery()
        {
            return OnFncQuery("");
        }
        public bool OnFncQuery(string command)
        {
            return DBQuery();
        }


        #endregion

        #region ■■ 4.1.2 OnFncSave(old:FncSave)
        public bool OnFncSave()
        {
            //TO-DO : code business oriented logic
            return DBSave();
        }
        #endregion


        #endregion

        #region ■ 4.4 Db function group

        #region ■■ 4.4.1 DBQuery(Common)

        private bool DBQuery()
        {

            this.SuspendLayout();

            LoadingForm(true);

            FncGet_list("");

            LoadingForm(false);

            this.ResumeLayout();
            this.PerformLayout();

            return true;
        }

        #endregion


        #region ■■ 4.4.2 DBDelete(Single)

        private bool DBDelete()
        {
            try
            {
                //wsMyBizFL.Service wsDelete = new wsMyBizFL.Service();
                //wsDelete.DeleteWebMethod(CommonVariable.gStrGlobalCollection, dsAnyName);
            }
            catch (Exception ex)
            {
                //bool reThrow = ExceptionControler.AutoProcessException(ex);
                //if (reThrow)
                //    throw;
                return false;
            }

            return true;
        }

        #endregion

        #region ■■ 4.4.3 DBSave(Common)

        private bool DBSave()
        {

            return true;
        }

        #endregion
        #endregion ■ 4.4 Db function group
        #endregion ▶ 4. Toolbar method part


        #region ▶ 5. Event method part


        #endregion


        #region ▶ 6. Popup method part

        #region ■ 6.1 Common popup implementation group

        #endregion

        #region ■ 6.2 User-defined popup implementation group

        #region ■■ 6.2.1 Popup 오픈


        #endregion

        #endregion

        #endregion


        #region ▶ 7. User-defined method part

        private void LoadingForm(bool bVisible)
        {
            Cursor.Current = (bVisible == true) ? Cursors.WaitCursor : Cursors.Default;
            //waitLoading.Visible = bVisible;
            Application.DoEvents();
        }


        #endregion  User-defined method part

        //행의 첫 시작 위치를 선택할 때 row위치가 visible = false 이면 오류 발생함으로 visible 여부를 체크 함
        private int GetFirstRowIndex(int pRowIndex)
        {
            int i = 0;

            ////for (i = pRowIndex; i < Grid1.Rows.Count; i++)
            ////{
            ////    if (Grid1.Rows[i].Visible == true)
            ////    {
            ////        break;
            ////    }
            ////}

            return i;
        }

        protected void SetLocalDefaultValue_site()
        {

        }

        private bool FncGet_list(string @FLAG)
        {
            Grid1.Rows.Clear();

            string strData = "";
            strData += "EXEC XUSP_MES_APP_P9005MA3_GET1 ";
            strData += "@PLANT_CD ='" + sPLANT_CD + "' ";

            try
            {
                DataTable dataT = new DataTable();
                int nCnt = 0;
                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dataT, ref nCnt);

                if (dataT.Rows.Count > 0)
                {
                    for (int i = 0; i < dataT.Rows.Count; i++)
                    {
                        Grid1.Rows.Add();

                        Grid1.Rows[i].Cells[grid1_COLUMN.ITEM_CD].Value = dataT.Rows[i][grid1_COLUMN.ITEM_CD].ToString();
                        Grid1.Rows[i].Cells[grid1_COLUMN.ITEM_NM].Value = dataT.Rows[i][grid1_COLUMN.ITEM_NM].ToString();
                        Grid1.Rows[i].Cells[grid1_COLUMN.SPEC].Value = dataT.Rows[i][grid1_COLUMN.SPEC].ToString();
                        Grid1.Rows[i].Cells[grid1_COLUMN.UPPER_LOT].Value = dataT.Rows[i][grid1_COLUMN.UPPER_LOT].ToString();
                        Grid1.Rows[i].Cells[grid1_COLUMN.PRODT_ORDER_NO].Value = dataT.Rows[i][grid1_COLUMN.PRODT_ORDER_NO].ToString();
                        Grid1.Rows[i].Cells[grid1_COLUMN.DN_NO].Value = dataT.Rows[i][grid1_COLUMN.DN_NO].ToString();
                        Grid1.Rows[i].Cells[grid1_COLUMN.MVMT_NO].Value = dataT.Rows[i][grid1_COLUMN.MVMT_NO].ToString();
                        Grid1.Rows[i].Cells[grid1_COLUMN.INSRT_DT].Value = Convert.ToDateTime(dataT.Rows[i][grid1_COLUMN.INSRT_DT]);
                        Grid1.Rows[i].Cells[grid1_COLUMN.INSRT_USER_ID].Value = dataT.Rows[i][grid1_COLUMN.INSRT_USER_ID].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                TGSControl.UsrFunction.MessageBoxErr(ex.Message, _PG_NM);
                return false;
            }

            return true;
        }

        private void btn_Before_ButtonClick_1(object sender, EventArgs e)
        {
            if (this.ActiveControl == Grid1)
            {
                int vDisplayedRowCount = Grid1.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid1.FirstDisplayedScrollingRowIndex - vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex <= 0)
                        Grid1.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(0);
                    else
                        Grid1.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid1.FirstDisplayedScrollingRowIndex - vDisplayedRowCount);
                }
            }
        }

        private void btn_Next_ButtonClick_1(object sender, EventArgs e)
        {
            if (this.ActiveControl == Grid1)
            {
                int vDisplayedRowCount = Grid1.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid1.FirstDisplayedScrollingRowIndex + vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex >= Grid1.Rows.Count)
                        Grid1.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid1.Rows.Count - 1);
                    else
                        Grid1.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(vFirstDisplayedScrollingRowIndex);
                }
            }
        }

        private void btnQuery_ButtonClick(object sender, EventArgs e)
        {
            DBQuery();
        }

        private void btnClose_ButtonClick(object sender, EventArgs e)
        {
            //닫기 버튼.
            if (commandRuned != null)
            {
                commandRuned(null, null);
            }
        }

        private void btnDelete_ButtonClick(object sender, EventArgs e)
        {

        }

        private void btnAdd_ButtonClick(object sender, EventArgs e)
        {

        }
    }
}