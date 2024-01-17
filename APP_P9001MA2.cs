using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
//using System.Linq;
using System.Text;
using System.Windows.Forms;


using TGSClass;
using TGSClass.nsGlobal;
using TGSClass.nsWorkCode;


namespace MES_APP_P90
{
    public partial class APP_P9001MA2 : UserControl
    {



        #region ▶ 1. Declaration part  //선언부

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


        public struct GetValueName
        {
            public const string PLANT_CD = "PLANT_CD";
            public const string ITEM_CD = "ITEM_CD";
            public const string RESULT_NO = "RESULT_NO";
        }
        public struct SetValueName
        {
            public const string UNIT_CD = "UNIT_CD";
            public const string PLANT_CD = "PLANT_CD";
            public const string WC_MGR = "WC_MGR";
            public const string FACILITY_CD = "FACILITY_CD";
            public const string WORKER_CD = "WORKER_CD";

            public const string POPUP_VIEW = "POPUP_VIEW";  //팝업형태 표시

        }

        public struct grid1_COLUMN
        {
            //public const string CHECKFLAG = "CHKFLAG";
            public const string SEQ = "SEQ";
            //public const string PRODT_ORDER_NO = "PRODT_ORDER_NO";
            //public const string OPR_NO = "OPR_NO";
            //public const string WK_DT = "WK_DT";
            //public const string WK_ORD_NO = "WK_ORD_NO";
            //public const string ITEM_CD = "ITEM_CD";
            //public const string ITEM_NM = "ITEM_NM";
            //public const string WK_ORD_QTY = "WK_ORD_QTY";
            //public const string PROD_QTY = "PROD_QTY";
            //public const string EMP_DESC = "EMP_DESC";
            //public const string STATUS = "STATUS";
            //public const string REAL_START_TM = "REAL_START_TM";
            //public const string REAL_END_TM = "REAL_END_TM";
            //public const string RESULT_NO = "RESULT_NO";
            //public const string WORKER_ID = "WORKER_ID";
            //public const string LOT_QTY = "LOT_QTY";
            //public const string WK_ORD_UNIT = "WK_ORD_UNIT";
            public const string CHECK_DT = "CHECK_DT";
            public const string CHECK_POINT_CD = "CHECK_POINT_CD";
            public const string CHECK_POINT_NM = "CHECK_POINT_NM";
            public const string CHECK_REFERENCE = "CHECK_REFERENCE";
            public const string CHECK_RESULT_CD = "CHECK_RESULT_CD";
            public const string CHECK_REMARK = "CHECK_REMARK";
            public const string WORKER_CD = "WORKER_CD";

        }




        #endregion

        #region ■ 1.3. Class global variables (common) //글로벌 변수 선언

        Global global = new Global();
        Form sMainForm;

        string sUNIT_CD = "";
        string sPLANT_CD = "";      //공장
        string sWC_MGR = "";        //대공정
        //string sWC_CD = "";         //작업장
        string sFACILITY_CD = "";   //설비번호
        string sWORKER_CD = "";     //작업자
        //string sWC_NM = "";         //작업장




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


        string sPROGRAM_ID = "";
        [Category("시작변수"), Description("프로그램 메뉴 ID 입니다.")]
        public string PROGRAM_ID
        {
            get
            {
                if (sPROGRAM_ID == "")
                    return this.GetType().ToString();
                else
                    return sPROGRAM_ID;
            }
            set
            {
                sPROGRAM_ID = value;
            }
        }
        [Category("시작변수"), Description("프로그램 Type 입니다.")]
        public string PROGRAM_TYPE
        {
            get
            {
                return this.GetType().ToString();
            }
        }



        #endregion

        #endregion

        #region ▶ 2. Initialization part

        #region ■ 2.1 Constructor(common)      //생성자

        public APP_P9001MA2()
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
            if (Global.workinfo.szServerIP == null || Global.workinfo.szServerIP == "")
            {
                global.ConfigFileReadAll();
            }

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

                    }
                }
            }

        }
        public void CommandRun(string CommandString)
        {
            CommandString.Split(TGSClass.nsGlobal.Global.Separation.COLUMNS);

            //DataSet vSendData = new DataSet();

            //vSendData.Tables.Add("COMMAND");
            //vSendData.Tables["COMMAND"].Columns.Add("COMMAND_ID");
            //vSendData.Tables["COMMAND"].Columns.Add("REFERENCE1");
            //vSendData.Tables["COMMAND"].Columns.Add("REFERENCE2");
            //vSendData.Tables["COMMAND"].Columns.Add("REFERENCE3");
            //vSendData.Tables["COMMAND"].Columns.Add("REFERENCE4");

            ////vSendData.Tables["COMMAND"].Rows.Add("DBQUERY");
            //vSendData.Tables["COMMAND"].Rows.Add(CommandString, "", "", "", "");

            //CommandRun(vSendData);

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
                //        vSendData.Tables["COMMAND"].Rows.Add("APP_RUN", "MES_APP_P00.APP_P1003M1", "", "", "");
                //        break;
                //    case "20":
                //        vSendData.Tables["COMMAND"].Rows.Add("APP_RUN", "MES_APP_P50.APP_P5001M1", "", "", "");
                //        break;
                //    case "30":
                //        vSendData.Tables["COMMAND"].Rows.Add("APP_RUN", "MES_APP_P30.APP_P3001M1", "", "", "");
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
            CommandString.Split(TGSClass.nsGlobal.Global.Separation.COLUMNS);

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

                case GetValueName.ITEM_CD:

                    if (Grid1.CurrentRow == null)
                    {
                        if (Grid1.Rows.Count > 0)
                        {
                            // Grid1.Rows[0].Cells[grid1_COLUMN.ITEM_CD].Selected = true;
                        }
                    }

                    //if (Grid1.CurrentRow != null)
                    //    return Grid1.CurrentRow.Cells[grid1_COLUMN.ITEM_CD].Value.ToString();
                    //else
                    return "";


                default:
                    return "";
            }




        }
        public void SetValue(string pValueName, string pValue)
        {
            switch (pValueName)
            {
                case SetValueName.UNIT_CD:

                    sUNIT_CD = pValue;
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

                case SetValueName.POPUP_VIEW:

                    switch (pValue.ToUpper())
                    {
                        case "TRUE":
                            btn_Cancel.Visible = true;

                            Panel_Cmd.ColumnStyles[3].SizeType = SizeType.Percent;
                            Panel_Cmd.ColumnStyles[3].Width = 50;
                            Panel_Cmd.ColumnStyles[2].SizeType = SizeType.Absolute;
                            Panel_Cmd.ColumnStyles[2].Width = 20;
                            Panel_Cmd.ColumnStyles[1].SizeType = SizeType.Percent;
                            Panel_Cmd.ColumnStyles[1].Width = 50;
                            Panel_Cmd.ColumnStyles[0].SizeType = SizeType.Absolute;
                            Panel_Cmd.ColumnStyles[0].Width = 20;

                            break;
                        default:
                            btn_Cancel.Visible = false;
                            Panel_Cmd.ColumnStyles[3].SizeType = SizeType.Percent;
                            Panel_Cmd.ColumnStyles[3].Width = 30;
                            Panel_Cmd.ColumnStyles[2].SizeType = SizeType.Absolute;
                            Panel_Cmd.ColumnStyles[2].Width = 0;
                            Panel_Cmd.ColumnStyles[1].SizeType = SizeType.Percent;
                            Panel_Cmd.ColumnStyles[1].Width = 40;
                            Panel_Cmd.ColumnStyles[0].SizeType = SizeType.Percent;
                            Panel_Cmd.ColumnStyles[0].Width = 30;
                            break;
                    }

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



            if (sUNIT_CD == "") sUNIT_CD = Global.workinfo.szUNIT_CD;
            if (sPLANT_CD == "") sPLANT_CD = Global.workinfo.szFactoryCD;
            if (sFACILITY_CD == "") sFACILITY_CD = Global.workinfo.szFacilityCD;
            //if (sWC_CD == "") sWC_CD = Global.workinfo.szWorkSpaceCD;
            if (sWC_MGR == "") sWC_MGR = Global.workinfo.szProcessCD;
            if (sWORKER_CD == "") sWORKER_CD = Global.workinfo.szOperatorCD;
            //if (sWC_NM == "") sWC_NM = Global.workinfo.szWorkSpaceNM;



        }

        #endregion

        #region ■ 2.5 Gathering combo data(GatheringComboData) //콤보관련 데이타 설정

        protected void GatheringComboData()
        {
            if (Global.workinfo.szServerIP == "") return;

            //Load_Operator();  //작업자정보조회
            Fnc_crt_combo(this.cboWorker, "", "WORKER", -1, "작업자", "작업자명", "작업자 선택");  //작업자정보조회
            Fnc_crt_combo(this.cboFacility, "", "FACILITY", -1, "설비", "설비명", "설비 선택");  //설비정보조회
            Fnc_crt_combo(this.cboSHIFT, "", "SHIFT", 0, "주/야", "구분명", "주간/야간 선택");  //설비정보조회


            if (DateTime.Now.Hour >= 7 && DateTime.Now.Hour < 20)
            {
                cboSHIFT.SelectedIndex = 0;
            }
            else
            {
                cboSHIFT.SelectedIndex = 1;
            }
            
            //Load_Facility();    //설비 정보를 조회한다.

            /* 판매계획유형*/
            //Fnc_crt_combo(this.cboSP_TYPE, "S0018", "S0018", 0, "판매계획", "판매계획명", "판매계획 선택");
            /* 거래구분*/
            //Fnc_crt_combo(this.cboLOC_EXP_FLAG, "S4225", "", 1);

        }

        #region ▶▶▶ 공용코드 콤보 셋팅
        private void Fnc_crt_combo(TGSControl.TCombo combo, string @MAJOR_CD, string @FLAG, int idx)
        {
            Fnc_crt_combo(combo, @MAJOR_CD, @FLAG, idx, "코드", "코드명", "코드선택");
        }

        private void Fnc_crt_combo(TGSControl.TCombo combo, string @MAJOR_CD, string @FLAG, int idx, string p_ValueCaption, string p_DisplayCaption, string p_Caption)
        {
            combo.Clear();

            string pValueMember = "code";
            string pDisplayMember = "name";

            //DataSet iDataSet = new DataSet();
            DataTable dtData1 = null;
            dtData1 = new DataTable();

            string strSql = "";

            switch (@FLAG)
            {
                case "FACILITY":    // 설비일상점검 항목이 등록된 설비들만 조회되도록 함
                    //strSql = "  SELECT	DISTINCT A.FACILITY_CD, B.FACILITY_NM ";
                    //strSql += " FROM MES_P_DAILY_CHECK_FACILITY AS A(NOLOCK) ";
                    //strSql += " LEFT OUTER JOIN Y_FACILITY AS B(NOLOCK) ON A.FACILITY_CD = B.FACILITY_CD ";
                    //strSql += " LEFT OUTER JOIN B_USER_DEFINED_MINOR AS C(NOLOCK) ON C.UD_MAJOR_CD = 'PD103' AND A.CHECK_POINT_CD = C.UD_MINOR_CD ";
                    //strSql += " LEFT OUTER JOIN P_WORK_CENTER AS D(NOLOCK) ON D.UD_MAJOR_CD = 'PD103' AND A.CHECK_POINT_CD = D.UD_MINOR_CD ";
                    //strSql += " ORDER BY A.FACILITY_CD ";
                    strSql = "EXEC DBO.XUSP_MES_P0301M1_GET_FACILITY ";
                    strSql += "@PLANT_CD='" + sPLANT_CD + "',";
                    strSql += "@WC_MGR='" + sWC_MGR + "',";
                    strSql += "@UNIT_CD='" + sUNIT_CD + "'";

                    pValueMember = "FACILITY_CD";
                    pDisplayMember = "FACILITY_NM";
                    break;
                case "WORKER":    // 작업자 
                    strSql = "EXEC DBO.XUSP_MES_P3101Q1_GET_WORKER ";
                    strSql += "@PLANT_CD='" + sPLANT_CD + "',";
                    strSql += "@WC_MGR='" + sWC_MGR + "'";


                    pValueMember = "USER_ID";
                    pDisplayMember = "EMP_DESC";

                    break;
                case "SHIFT":    // 작업자 
                    strSql = "SELECT SHIFT_CD, DESCRIPTION AS SHIFT_NM FROM P_SHIFT_HEADER (NOLOCK)  ";
                    strSql += "WHERE PLANT_CD='" + sPLANT_CD + "'";

                    pValueMember = "SHIFT_CD";
                    pDisplayMember = "SHIFT_NM";

                    break;
                case "UD_MAJOR_CD":    // 사용자정의-공통코드..
                    strSql = " SELECT DISTINCT RTRIM(AA.code) AS code, RTRIM(AA.name) AS name ";
                    strSql += " FROM ( ";
                    strSql += " SELECT  '1' AS LVL, '' AS code, '' AS name ";
                    strSql += " UNION ALL ";
                    strSql += " SELECT '2' AS LVL, RTRIM(AA.UD_MINOR_CD) AS code, RTRIM(AA.UD_MINOR_NM) AS name ";
                    strSql += " FROM B_USER_DEFINED_MINOR AA (NOLOCK) ";
                    strSql += " WHERE RTRIM(AA.UD_MAJOR_CD) = RTRIM('" + @MAJOR_CD + "')  ) AA ";
                    strSql += " WHERE AA.LVL = '2' ";
                    break;

                case "CHECK_POINT_RESURT":
                    strSql = " SELECT UD_MINOR_NM AS CHECK_POINT_NM ";
	                strSql += " FROM B_USER_DEFINED_MINOR (NOLOCK) ";
	                strSql += " WHERE RYRIM(UD_MAJOR_CD) = RTRIM('" + @MAJOR_CD + "') ";      //설비일상점검 결과 PD104
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
                int nCnt = 0;
                //strSql = WorkCode.WorkCd.SQLQUERY + strSql;
                //string strState = nsFuncUtil.FuncUtil.GetDataSql(this.MainForm, strSql, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strSql, ref dtData1, ref nCnt);
            }
            catch (Exception ex)
            {
                TGSControl.UsrFunction.MessageBoxErr(ex.Message, "기준정보조회");

                return;
            }
            //if (dtData1 != null && dtData1.Rows.Count > 0)
            if (dtData1 != null)
            {
                combo.DataSource = dtData1;
                combo.ValueMember = pValueMember;
                combo.DisplayMember = pDisplayMember;
                combo.DisplayCaption = p_DisplayCaption;
                combo.ValueCaption = p_ValueCaption;
                combo.Caption = p_Caption;

                //combo.DataBind();
                if (idx >= 0) combo.SelectedIndex = idx;
            }
        }
        #endregion ▶▶▶ 공용코드 콤보 셋팅


        #region ▶▶▶ 설비정보 조회
        //설비정보를 가져온다.
        //private int Load_Facility()
        //{
        //    string szSendData = string.Empty;
        //    int nCnt = 0;

        //    try
        //    {
        //        if (Global.workinfo.szProcessCD == "") return -1;


        //        LoadingForm(true);

        //        DataTable dtTmp = (DataTable)cboFacility.DataSource;
        //        if (dtTmp != null) dtTmp.Clear();

        //        // 작업장정보 가져오기
        //        szSendData = "";
        //        szSendData = WorkCode.WorkCd.FACILITY;
        //        szSendData += Global.workinfo.szFactoryCD + nsWinUtilGlobal.Global.Separation.COLUMNS;
        //        szSendData += Global.workinfo.szProcessCD + nsWinUtilGlobal.Global.Separation.COLUMNS;
        //        szSendData += Global.workinfo.szWorkSpaceCD + nsWinUtilGlobal.Global.Separation.COLUMNS;
        //        szSendData += "";  //Mixing의 JobCode자리


        //        DataTable dtData1 = null;
        //        dtData1 = new DataTable();

        //        string strState = nsFuncUtil.FuncUtil.GetDataSql(this.ParentForm, szSendData, ref dtData1, ref nCnt,
        //            Global.workinfo.szServerIP,
        //            Global.workinfo.szPortNo);

        //        if (!strState.Equals("OK"))
        //        {
        //            nsUsrFunction.UsrFunction.MessageBoxErr(strState.Substring(2), "설비정보 조회");
        //            return -1;
        //        }

        //        cboFacility.Caption = "";

        //        if (dtData1 != null && dtData1.Rows.Count > 0)
        //        {
        //            //this.cboWorkPlace.DataMode = WinControl.SSMComboBox.DataModeEnum.Normal;
        //            this.cboFacility.DataSource = dtData1;
        //            this.cboFacility.DisplayMember = "FACILITY_NM";
        //            this.cboFacility.ValueMember = "FACILITY_CD";
        //            this.cboFacility.DisplayCaption = "설비명";
        //            this.cboFacility.ValueCaption = "설비코드";
        //            this.cboFacility.Caption = "설비정보조회";

        //            cboFacility.SelectedIndex = 0;
        //            if (Global.workinfo.szFacilityCD != "")
        //                cboFacility.Value = Global.workinfo.szFacilityCD;

        //            Global.workinfo.szFacilityCD = cboFacility.Value;
        //            Global.workinfo.szFacilityNM = cboFacility.ValueName;

        //            LoadingForm(false);
        //            return 0;
        //        }
        //    }
        //    catch (Exception se)
        //    {
        //        nsUsrFunction.UsrFunction.MessageBoxErr(se.Message, "설비조회");
        //    }
        //    finally
        //    {
        //        LoadingForm(false);
        //    }
        //    return -1;


        //}
        #endregion ▶▶▶ 설비정보 조회

        #region ▶▶▶ 작업장 정보 조회
        ////작업장 정보를 가져온다.
        //private int Load_WorkSpace()
        //{
        //    string szSendData = string.Empty;
        //    int nCnt = 0;

        //    try
        //    {
        //        if (Global.workinfo.szProcessCD == "") return -1;


        //        LoadingForm(true);

        //        DataTable dtTmp = (DataTable)cboFacility.DataSource;
        //        if (dtTmp != null) dtTmp.Clear();

        //        // 작업장정보 가져오기
        //        szSendData = "";
        //        szSendData = WorkCode.WorkCd.WORKSPACE;
        //        szSendData += Global.workinfo.szFactoryCD + nsWinUtilGlobal.Global.Separation.COLUMNS;
        //        szSendData += Global.workinfo.szProcessCD;

        //        DataTable dtData1 = null;
        //        dtData1 = new DataTable();

        //        string strState = nsFuncUtil.FuncUtil.GetDataSql(this.ParentForm, szSendData, ref dtData1, ref nCnt,
        //            Global.workinfo.szServerIP,
        //            Global.workinfo.szPortNo);

        //        if (!strState.Equals("OK"))
        //        {
        //            nsUsrFunction.UsrFunction.MessageBoxErr(strState.Substring(2), "작업장조회");
        //            return -1;
        //        }

        //        cboFacility.Caption = "";

        //        if (dtData1 != null && dtData1.Rows.Count > 0)
        //        {
        //            //this.cboWorkPlace.DataMode = WinControl.SSMComboBox.DataModeEnum.Normal;
        //            this.cboWorkCenter.DataSource = dtData1;
        //            this.cboWorkCenter.DisplayMember = "WC_NM";
        //            this.cboWorkCenter.ValueMember = "WC_CD";
        //            this.cboWorkCenter.DisplayCaption = "작업장명";
        //            this.cboWorkCenter.ValueCaption = "작업장";              
        //            this.cboWorkCenter.Caption = "작업장 선택";


        //            cboWorkCenter.SelectedIndex = 0;
        //            if (Global.workinfo.szWorkSpaceCD != "")
        //                cboWorkCenter.Value = Global.workinfo.szWorkSpaceCD;

        //            Global.workinfo.szWorkSpaceCD = cboWorkCenter.Value;
        //            Global.workinfo.szWorkSpaceNM = cboWorkCenter.ValueName;

        //            LoadingForm(false);
        //            return 0;
        //        }
        //    }
        //    catch (Exception se)
        //    {
        //        nsUsrFunction.UsrFunction.MessageBoxErr(se.Message, "작업장조회");
        //    }
        //    finally
        //    {
        //        LoadingForm(false);
        //    }
        //    return -1;
        //}
        #endregion ▶▶▶ 작업장정보 조회
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
        }

        private void InitSpreadSheet(int p_GridIndex)   //선택된 스프레드시트를 초기화 한다.
        {



            #region ▶▶▶ 3.1.1 GRID1 설정

            if (p_GridIndex == 1)
            {
                #region ■■ 3.1.1.1 Pre-setting grid information

                /*** grid1
                     *  실적조회
                     * **/
                Grid1.Columns.Clear();


                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("맑은 고딕", 14);
                Grid1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                Grid1.RowHeadersVisible = false;

                //Grid1.Columns.Add(SetColumnImage(grid1_COLUMN.CHECKFLAG, "√", 40));    //이미지형태의 그리드


                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.SEQ, "NO", 80));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.CHECK_DT, "점검일", 100));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.CHECK_POINT_CD, "점검항목코드", 80));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.CHECK_POINT_NM, "점검항목", 300));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.CHECK_REFERENCE, "판단기준", 400));
                Grid1.Columns.Add(SetColumnButton(grid1_COLUMN.CHECK_RESULT_CD, "상태결과", 160));
                Grid1.Columns.Add(SetColumnButton(grid1_COLUMN.CHECK_REMARK, "조치", 0));

                #endregion


                #region ■■ 3.1.2 Formatting grid information
                //Grid1.Columns[grid1_COLUMN.WK_DT].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //Grid1.Columns[grid1_COLUMN.WK_ORD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.PROD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.WK_ORD_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태
                //Grid1.Columns[grid1_COLUMN.PROD_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태


                #endregion


                #region ■■ 3.1.3 Setting etc grid

                // Hidden Column Setting
                //Grid1.Columns[grid1_COLUMN.SEQ].Visible = false;
                //Grid1.Columns[grid1_COLUMN.PRODT_ORDER_NO].Visible = false;
                Grid1.Columns[grid1_COLUMN.CHECK_POINT_CD].Visible = false;
                Grid1.Columns[grid1_COLUMN.CHECK_REMARK].Visible = false;



                #endregion

            }

            #endregion



        }


        #endregion

        #region ■ 3.2 InitData

        public void InitData()
        {
            // TO-DO: 컨트롤을 초기화(또는 초기값)할때 할일 
            // SetDefaultVal과의 차이점은 전자는 Form_Load 시점에 콘트롤에 초기값을 세팅하는것이고
            // 후자는 특정 시점(조회후 또는 행추가후 등 특정이벤트)에서 초기값을 셋팅한다.


            if (cboWorker.Value != sWORKER_CD)
            {
                cboWorker.Value = sWORKER_CD; // Global.workinfo.szOperatorCD;
            }


            if (cboFacility.Value != sFACILITY_CD)
            {
                cboFacility.Value = sFACILITY_CD;

            }

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


            DBQuery_CheckSheet();


            LoadingForm(false);

            this.ResumeLayout();
            this.PerformLayout();

            return true;
        }



        #region ▶▶▶ 일일점검표 리스트를 조회
        private void DBQuery_CheckSheet()//일일점검표 리스트를 조회 
        {
            int nCnt = 0;
            string NowDT = DateTime.Now.Date.ToString();
            try
            {
                //LoadingForm(true);

                Grid1.Rows.Clear();

                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MES_P0301M1_GET @PLANT_CD='" + sPLANT_CD + "', "; //공장
                strData += "@FACILITY_CD ='" + sFACILITY_CD + "', ";  //설비번호
                strData += "@SHIFT_CD ='" + cboSHIFT.Value.ToString() + "' ";  //주야구분

                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);
                //string strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);

                if (!strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "일상점검표 조회");
                    return;
                }
                if (dtData1 == null || dtData1.Rows.Count <= 0)
                {
                    LoadingForm(false);
                    TGSControl.UsrFunction.MessageBoxInfo("UNIERP '설비일상 점검항목등록' 등록 요청하세요.", "일상 점검항목 기초정보가 없습니다.", 3);
                    btn_Save.Enabled = false;
                    return;
                }


                for (int i = 0; i < dtData1.Rows.Count; i++)
                {
                    this.Grid1.Rows.Add();
  
                    Grid1.Rows[i].Cells[grid1_COLUMN.SEQ].Value = (i + 1).ToString(); //순번;                 
                    Grid1.Rows[i].Cells[grid1_COLUMN.CHECK_POINT_NM].Value = dtData1.Rows[i][grid1_COLUMN.CHECK_POINT_NM].ToString();
                    Grid1.Rows[i].Cells[grid1_COLUMN.CHECK_REFERENCE].Value = dtData1.Rows[i][grid1_COLUMN.CHECK_REFERENCE].ToString();
                    Grid1.Rows[i].Cells[grid1_COLUMN.CHECK_POINT_CD].Value = dtData1.Rows[i][grid1_COLUMN.CHECK_POINT_CD].ToString();
                    Grid1.Rows[i].Cells[grid1_COLUMN.CHECK_RESULT_CD].Value = dtData1.Rows[i][grid1_COLUMN.CHECK_RESULT_CD].ToString();

                    switch (dtData1.Rows[i][grid1_COLUMN.CHECK_RESULT_CD].ToString())
                    {
                        case "G":
                            Grid1.Rows[i].Cells[grid1_COLUMN.CHECK_RESULT_CD].Value = "양호";
                            Grid1.Rows[i].Cells[grid1_COLUMN.CHECK_RESULT_CD].Tag = "G";
                            Grid1.Rows[i].Cells[grid1_COLUMN.CHECK_RESULT_CD].Style.ForeColor = Color.Blue;
                            break;
                        case "B":
                            Grid1.Rows[i].Cells[grid1_COLUMN.CHECK_RESULT_CD].Value = "나쁨";
                            Grid1.Rows[i].Cells[grid1_COLUMN.CHECK_RESULT_CD].Tag = "B";
                            Grid1.Rows[i].Cells[grid1_COLUMN.CHECK_RESULT_CD].Style.ForeColor = Color.Red;
                            break;

                        default:
                            Grid1.Rows[i].Cells[grid1_COLUMN.CHECK_RESULT_CD].Value = "미점검";
                            Grid1.Rows[i].Cells[grid1_COLUMN.CHECK_RESULT_CD].Tag = "";
                            Grid1.Rows[i].Cells[grid1_COLUMN.CHECK_RESULT_CD].Style.ForeColor = Color.Black;
                            break;
                    }

                    Grid1.Rows[i].Cells[grid1_COLUMN.CHECK_REMARK].Value = dtData1.Rows[i][grid1_COLUMN.CHECK_REMARK].ToString();

                    if (cboWorker.Value != dtData1.Rows[i][grid1_COLUMN.WORKER_CD].ToString() && dtData1.Rows[i][grid1_COLUMN.WORKER_CD].ToString() != "")
                    {
                        cboWorker.Value = dtData1.Rows[i][grid1_COLUMN.WORKER_CD].ToString();
                    }
                }




            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "일상점검표 조회");
            }
            finally
            {
                LoadingForm(false);
            }

        }
        #endregion ▶▶▶ 일일점검표 리스트 조회


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


        //#region ▶▶▶ LOT 스캔한 실적을 삭제한다.
        //private void DBDelete_LOT_SCAN()
        //{
        //    if (Grid1.CurrentRow == null ) 
        //    {
        //        nsUsrFunction.UsrFunction.MessageBoxErr("작업지시 행을 선택하십시요", "LOT 스캔 삭제");
        //        return;
        //    }
        //    if (Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString() == "")
        //    {
        //        nsUsrFunction.UsrFunction.MessageBoxErr("지시내역을 선택하세요.", "LOT 스캔 삭제");
        //        return;
        //    }

        //    if (Grid4.CurrentRow == null)
        //    {
        //        nsUsrFunction.UsrFunction.MessageBoxErr("삭제할 행을 선택하십시요", "LOT 스캔 삭제");
        //        return;
        //    }


        //    DBSave_LotScan(Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString(), Grid4.CurrentRow.Cells[grid4_COLUMN.LOT_NO].Value.ToString(), Grid4.CurrentRow.Cells[grid4_COLUMN.LOC_NO].Value.ToString(), "D"); //삭제

        //}
        //#endregion ▶▶▶ LOT 스캔한 실적을 삭제한다.




        #endregion

        #region ■■ 4.4.3 DBSave(Common)

        private bool DBSave()
        {

            return DBSave_CheckResult();
        }


        //저장
        private bool DBSave_CheckResult()
        {

            if (Grid1.Rows.Count == 0) return false;

            if (cboWorker.Value == "")
            {
                TGSControl.UsrFunction.MessageBoxInfo("점검자를 입력하세요", "일상점검");
                return false;
            }

            string strState = string.Empty;

            int nCnt = 0;
            

            LoadingForm(true);

            try
            {
                for (int i = 0; i < Grid1.Rows.Count; i++)
                {
                    //결과값 없을시 리턴
                    if (this.Grid1.Rows[i].Cells["CHECK_RESULT_CD"].Tag.ToString() == "")
                    {
                        continue;
                    }

                    //string strData = WorkCode.WorkCd.SQLQUERY;
                    string strData = "";
                    strData += " EXEC DBO.XUSP_MES_P0301M1_SET ";
                    strData += " @FACILITY_CD='" + sFACILITY_CD + "',";
                    strData += " @WORKER_CD='" + sWORKER_CD + "',";
                    strData += " @CHECK_POINT_CD='" + this.Grid1.Rows[i].Cells["CHECK_POINT_CD"].Value.ToString() +"',";
                    strData += " @CHECK_RESULT_CD='" + this.Grid1.Rows[i].Cells["CHECK_RESULT_CD"].Tag.ToString() + "',";
                    strData += " @CHECK_REMARK='" + this.Grid1.Rows[i].Cells["CHECK_REMARK"].Value.ToString() + "',";
                    strData += " @USER_ID='" + sWORKER_CD + "',";
                    strData += " @SHIFT_CD='" + cboSHIFT.Value.ToString() + "' ";  //주야구분


                    //string strData = WorkCode.WorkCd.SQLPROCEDURE; //프로시져 형태로 호출
                    //strData += "DBO.XUSP_MES_P0301M1_SET";       //프로시져 명
                    //strData += Global.COLUMNS_DIV + "N" + nsWinUtilGlobal.Global.Separation.COLUMNS;   //조회데이타가 없을 경우 'N' = nonquery 있을 경우 'Q' = query
                    ////일반변수 리스트
                    //strData += "@FACILITY_CD" + Global.COLUMNS_DIV;
                    //strData += "@WORKER_ID" + Global.COLUMNS_DIV;
                    //strData += "@CHECK_POINT_CD" + Global.COLUMNS_DIV;
                    //strData += "@CHECK_RESULT_CD" + Global.COLUMNS_DIV;
                    //strData += "@CHECK_REMARK" + Global.COLUMNS_DIV;
                    //strData += "@USER_ID" + nsWinUtilGlobal.Global.Separation.COLUMNS;


                    ////일반변수 리스트의 형식
                    //strData += Global.DBVarType.VarChar + "(20)" + Global.COLUMNS_DIV;
                    //strData += Global.DBVarType.VarChar + "(13)" + Global.COLUMNS_DIV;
                    //strData += Global.DBVarType.VarChar + "(10)" + Global.COLUMNS_DIV;
                    //strData += Global.DBVarType.VarChar + "(10)" + Global.COLUMNS_DIV;
                    //strData += Global.DBVarType.VarChar + "(50)" + Global.COLUMNS_DIV;
                    //strData += Global.DBVarType.VarChar + "(13)" + nsWinUtilGlobal.Global.Separation.COLUMNS;

                    ////일반변수값 리스트
                    //strData += sFACILITY_CD + Global.COLUMNS_DIV;
                    //strData += sWORKER_ID + Global.COLUMNS_DIV;
                    //strData += @CHECK_POINT_CD + Global.COLUMNS_DIV;
                    //strData += @CHECK_RESULT_CD + Global.COLUMNS_DIV;
                    //strData += @CHECK_REMARK + Global.COLUMNS_DIV;
                    //strData += sWORKER_ID + nsWinUtilGlobal.Global.Separation.COLUMNS;


                    ////OUTPUT변수 리스트 
                    //strData += "@RTN_MSG";
                    //strData += nsWinUtilGlobal.Global.Separation.COLUMNS;
                    ////OUTPUT변수 리스트 형식
                    //strData += Global.DBVarType.VarChar + "(200)" + nsWinUtilGlobal.Global.Separation.COLUMNS;
                    ////OUTPUT변수값 리스트
                    //strData += ""; // +nsWinUtilGlobal.Global.Separation.COLUMNS;



                    DataTable dtData1 = null;
                    dtData1 = new DataTable();
                    strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);
                    //strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                }

                if (!strState.Equals("OK"))
                {
                    if (strState == "")
                        TGSControl.UsrFunction.MessageBoxErr("설비일상점검 상태결과를 입력하세요", "설비일상점검 결과 저장 에러");
                    else
                        TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "설비일상점검 결과 저장 에러");

                    LoadingForm(false);
                    return false;
                }             

            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "저장작업");
            }
            finally
            {
                LoadingForm(false);
            }

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




        //작업자가 변경되었을 때
        private void cboWorker_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboWorker.SelectedIndex < 0) return;

            sWORKER_CD = cboWorker.Value;



        }
        //설비를 변경하였을 때
        private void cboFacility_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboFacility.Value != sFACILITY_CD)
            {
                sFACILITY_CD = cboFacility.Value;

                DBQuery();
            }

        }

       
        //설비일상점검 상태결과값 버튼을 클릭했을때
        private void Grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid1.CurrentRow != null)
            {
                if (Grid1.Columns[e.ColumnIndex].Name == grid1_COLUMN.CHECK_RESULT_CD)
                {
                    //임시로 작성 대체코드 찾으면 수정
                    //if (Grid1.Rows[e.RowIndex].Cells[grid1_COLUMN.CHECK_RESULT_CD].Value == null || Grid1.Rows[e.RowIndex].Cells[grid1_COLUMN.CHECK_RESULT_CD].Value.ToString() == "미점검")
                    //{
                    //    Grid1.Rows[e.RowIndex].Cells[grid1_COLUMN.CHECK_RESULT_CD].Value = "양호";
                    //    Grid1.Rows[e.RowIndex].Cells[grid1_COLUMN.CHECK_RESULT_CD].Tag = "G";
                    //}
                    if (Grid1.Rows[e.RowIndex].Cells[grid1_COLUMN.CHECK_RESULT_CD].Value.ToString() == "양호")
                    {
                        Grid1.Rows[e.RowIndex].Cells[grid1_COLUMN.CHECK_RESULT_CD].Value = "나쁨";
                        Grid1.Rows[e.RowIndex].Cells[grid1_COLUMN.CHECK_RESULT_CD].Tag = "B";

                        Grid1.Rows[e.RowIndex].Cells[grid1_COLUMN.CHECK_RESULT_CD].Style.ForeColor = Color.Red;
                    }
                    else //if (Grid1.Rows[e.RowIndex].Cells[grid1_COLUMN.CHECK_RESULT_CD].Value.ToString() == "나쁨")
                    {
                        Grid1.Rows[e.RowIndex].Cells[grid1_COLUMN.CHECK_RESULT_CD].Value = "양호";
                        Grid1.Rows[e.RowIndex].Cells[grid1_COLUMN.CHECK_RESULT_CD].Tag = "G";
                        Grid1.Rows[e.RowIndex].Cells[grid1_COLUMN.CHECK_RESULT_CD].Style.ForeColor = Color.Blue;
                    }
                }

                btn_Save.Enabled = true;
            }
        }



        private void btn_Save_ButtonClick(object sender, EventArgs e)
        {
            if (DBSave())
            {
                this.CommandRun_Event("OK");
            }
        }

        private void btn_Cancel_ButtonClick(object sender, EventArgs e)
        {
            this.CommandRun_Event("CLOSE");
        }

       

    }
}