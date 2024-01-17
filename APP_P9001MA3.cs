using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using TGSClass;
using TGSClass.nsGlobal;
using TGSClass.nsWorkCode;



namespace MES_APP_P90
{
    public partial class APP_P9001MA3 : UserControl
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
            public const string WC_CD = "WC_CD";
            public const string PLANT_CD = "PLANT_CD";
            public const string WC_MGR = "WC_MGR";
            public const string FACILITY_CD = "FACILITY_CD";
            public const string WORKER_CD = "WORKER_CD";

            public const string POPUP_VIEW = "POPUP_VIEW";  //팝업형태 표시

        }



        public struct grid1_COLUMN
        {
            //public const string CHECKFLAG = "CHKFLAG";                         
            public const string L_OP_CD = "L_OP_CD";                        //대분류 
            public const string M_OP_CD = "M_OP_CD";                        //중분류 
            public const string L_OP_NM = "L_OP_NM";                        //대분류 
            public const string M_OP_NM = "M_OP_NM";                        //중분류
            public const string OP_CD = "OP_CD";                            //소분류
            public const string OP_NM = "OP_NM";                            //분류명                                                                         
            public const string UNWORK_START_DT = "UNWORK_START_DT";        //시작일시
            public const string UNWORK_END_DT = "UNWORK_END_DT";            //완료일시
            public const string UNWORK_MIN = "UNWORK_MIN";                  //기간(분)
            public const string UNWORK_NO = "UNWORK_NO";                    //비가동코드번호
            public const string UNWORK_START_DT_B = "UNWORK_START_DT_B";    //시작일시백업
            public const string SERVER_DT = "SERVER_DT";                    //서버시각
            public const string WORKER_NM = "WORKER_NM";                    //작업자
            public const string SMS_LIST = "SMS_LIST";                    //작업자
        }

        public struct grid2_COLUMN
        {
            //public const string CHECKFLAG = "CHKFLAG";          
            public const string L_OP_CD = "L_OP_CD";            //대분류
            public const string M_OP_CD = "M_OP_CD";            //중분류
            public const string M_OP_NM = "M_OP_NM";            //분류명
        }


        public struct grid3_COLUMN
        {
            //public const string CHECKFLAG = "CHKFLAG";
            public const string OP_CD = "OP_CD";
            public const string OP_NM = "OP_NM";
        }




        #endregion

        #region ■ 1.3. Class global variables (common) //글로벌 변수 선언

        private bool bFormLoaded = false;
        private bool bWorkStopStarted = false;
        Global global = new Global();
        Form sMainForm;

        string sUNIT_CD = "";
        string sPLANT_CD = "";      //공장
        string sWC_MGR = "";        //대공정
        string sWC_CD = "";         //작업장
        string sFACILITY_CD = "";   //설비번호
        string sWORKER_CD = "";     //작업자
        //string sWC_NM = "";       //작업장
        string sWK_ORD_NO = "";     //작업지시번호
        string sRESULT_NO = "";


        int sGrid_Current_id = 1;

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

        public APP_P9001MA3()
        {
            InitializeComponent();
        }

        #endregion

        #region ■ 2.2 Form_Load(common)    //Control이 로딩시

        private void Form_Load(object sender, EventArgs e)
        {
            UnworkPanel_View(false);
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
            //CommandString.Split(TGSClass.nsGlobal.Global.Separation.COLUMNS);

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
            //CommandString.Split(TGSClass.nsGlobal.Global.Separation.COLUMNS);

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

                case SetValueName.POPUP_VIEW:

                    switch (pValue.ToUpper())
                    {
                        case "TRUE":
                            btn_Close.Visible = true;
                            break;
                        default:
                            btn_Close.Visible = false;
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



            if (sWC_CD == "") sWC_CD = Global.workinfo.szWorkSpaceCD;
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

            DBQuery_unWORK_GET_OP_CD();     //매트릭스 버튼 비가동 대분류 정보조회
            Retrive_WorkSpace();            //작업장정보조회
            Retrive_Facility();             //설비 정보조회

            Fnc_crt_combo(this.cboWorker, "", "WORKER", 0, "작업자", "작업자명", "작업자 선택");  //작업자정보조회

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
                    strSql += " FROM B_USER_DEFINED_MINOR ";
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
                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strSql, ref dtData1, ref nCnt);

                //strSql = WorkCode.WorkCd.SQLQUERY + strSql;
                //string strState = TGSClass.DataBase.GetDataSql(this.MainForm, strSql, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);

            }
            catch (Exception ex)
            {
                //TGSControl.UsrFunction.MessageBoxErr(ex.Message, "기준정보조회");

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



        private int Retrive_WorkSpace()
        {
            string strSql = string.Empty;
            int nCnt = 0;

            try
            {
                LoadingForm(true);

                // 작업장정보 가져오기
                strSql = "";
                //strSql = WorkCode.WorkCd.WORKSPACE;
                //strSql += sPLANT_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strSql += sWC_MGR;

                strSql = ""
                        + "SELECT A.WC_CD,"      //작업장코드
                        + "       A.WC_NM"      //작업장명
                        + " FROM P_WORK_CENTER AS A (NOLOCK) "
                        + " WHERE A.PLANT_CD = '" + sPLANT_CD + "'"
                        + "  AND A.WC_MGR = '" + sWC_MGR + "'";

                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strSql, ref dtData1, ref nCnt);
                //string strState = TGSClass.DataBase.GetDataSql(sMainForm, szSendData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);

                cboWC.Caption = "";

                if (!strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "작업장정보조회");
                    return -1;
                }

                if (dtData1 != null && dtData1.Rows.Count > 0)
                {
                    //this.cboWC.DataMode = WinControl.SSMComboBox.DataModeEnum.Normal;
                    this.cboWC.DataSource = dtData1;
                    this.cboWC.DisplayMember = "WC_NM";
                    this.cboWC.ValueMember = "WC_CD";
                    cboWC.SelectedIndex = 0;
                    if (sWC_CD != "")
                        cboWC.Value = sWC_CD;


                    return 0;
                }
            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "작업장정보조회");
            }
            finally
            {
                LoadingForm(false);
            }


            return -1;
        }

        private int Retrive_Facility()
        {
            string strSql = string.Empty;
            int nCnt = 0;

            try
            {
                LoadingForm(true);

                //if (cboWC.getSelectedItemIndex() < 0) return -1;


                // 설비정보 가져오기
                strSql = "";
                //strSql = WorkCode.WorkCd.FACILITY;
                //strSql += sPLANT_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strSql += sWC_MGR + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strSql += sWC_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strSql += " ";

                strSql = "EXEC DBO.XUSP_MESSVR_GET_FACILITY "
                            + " @PLANT_CD='" + sPLANT_CD + "',"
                            + " @WC_MGR='" + sWC_MGR + "',"
                            + " @WC_CD='" + sWC_CD + "',"
                            + " @JOB_CD='" + "" + "'";

                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strSql, ref dtData1, ref nCnt);

                //string strState = TGSClass.DataBase.GetDataSql(sMainForm, szSendData, ref dtData1, ref nCnt,
                //        Global.workinfo.szServerIP,
                //        Global.workinfo.szPortNo);

                if (!strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "설비정보조회");
                    return -1;
                }

                cboFacility.Caption = "";

                if (dtData1 != null && dtData1.Rows.Count > 0)
                {
                    //this.cboFacility.DataMode = WinControl.SSMComboBox.DataModeEnum.Normal;
                    this.cboFacility.DataSource = dtData1;
                    this.cboFacility.DisplayMember = "FACILITY_NM";
                    this.cboFacility.ValueMember = "FACILITY_CD";
                    cboFacility.SelectedIndex = 0;
                    if (sFACILITY_CD != "")
                        cboFacility.Value = sFACILITY_CD;


                    LoadingForm(false);
                    return 0;
                }
            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "설비정보조회");
            }
            finally
            {
                LoadingForm(false);
            }
            return -1;
        }
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
            InitSpreadSheet(3); //GRID3
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


                //Grid1.Columns.Add(SetColumnImage(grid1_COLUMN.CHECKFLAG, "√", 40));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.CHECK_DT, "점검일", 100));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.L_OP_CD, "대분류", 0));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.M_OP_CD, "중분류", 0));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.L_OP_NM, "대분류", 100));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.M_OP_NM, "중분류", 115));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.OP_CD, "소분류", 75));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.OP_NM, "분류명", 155));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.UNWORK_START_DT, "시작일시", 190));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.UNWORK_END_DT, "종료일시", 190));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.UNWORK_MIN, "시간(분)", 90));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.UNWORK_NO, "비가동코드번호", 0));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.UNWORK_START_DT_B, "시작일시백업", 0));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.SERVER_DT, "서버시각", 0));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.WORKER_NM, "작업자", 85));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.SMS_LIST, "이력", 60));




                #endregion


                #region ■■ 3.1.1.2 Formatting grid information
                //Grid1.Columns[grid1_COLUMN.WK_DT].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //Grid1.Columns[grid1_COLUMN.WK_ORD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.PROD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.WK_ORD_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태
                //Grid1.Columns[grid1_COLUMN.PROD_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태

                Grid1.Columns[grid1_COLUMN.UNWORK_MIN].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid1.Columns[grid1_COLUMN.UNWORK_MIN].DefaultCellStyle.Format = "N0"; //숫자표시형태


                #endregion


                #region ■■ 3.1.1.3 Setting etc grid

                // Hidden Column Setting
                //Grid1.Columns[grid1_COLUMN.SEQ].Visible = false;
                //Grid1.Columns[grid1_COLUMN.PRODT_ORDER_NO].Visible = false;
                Grid1.Columns[grid1_COLUMN.L_OP_CD].Visible = false;
                Grid1.Columns[grid1_COLUMN.M_OP_CD].Visible = false;
                Grid1.Columns[grid1_COLUMN.OP_CD].Visible = false;
                Grid1.Columns[grid1_COLUMN.UNWORK_NO].Visible = false;
                Grid1.Columns[grid1_COLUMN.UNWORK_START_DT_B].Visible = false;
                Grid1.Columns[grid1_COLUMN.SERVER_DT].Visible = false;



                #endregion

            }

            #endregion

            #region ▶▶▶ 3.1.2 GRID2 설정

            if (p_GridIndex == 2)
            {
                #region ■■ 3.1.2.1 Pre-setting grid information

                /*** grid2
                     *  실적조회
                     * **/
                Grid2.Columns.Clear();


                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("맑은 고딕", 14);
                Grid2.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                Grid2.RowHeadersVisible = false;

                //Grid2.Columns.Add(SetColumnImage(Grid2_COLUMN.CHECKFLAG, "√", 40));    //이미지형태의 그리드


                //Grid2.Columns.Add(SetColumnImage(grid2_COLUMN.CHECKFLAG, "√", 40));
                //Grid2.Columns.Add(SetColumnEdit(Grid2_COLUMN.CHECK_DT, "점검일", 100));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.L_OP_CD, "대분류", 100));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.M_OP_CD, "중분류", 100));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.M_OP_NM, "분류명", 180));

                #endregion


                #region ■■ 3.1.2.2 Formatting grid information
                //Grid2.Columns[Grid2_COLUMN.WK_DT].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //Grid2.Columns[Grid2_COLUMN.WK_ORD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid2.Columns[Grid2_COLUMN.PROD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid2.Columns[Grid2_COLUMN.WK_ORD_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태
                //Grid2.Columns[Grid2_COLUMN.PROD_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태


                #endregion


                #region ■■ 3.1.2.3 Setting etc grid

                // Hidden Column Setting
                //Grid2.Columns[Grid2_COLUMN.SEQ].Visible = false;
                //Grid2.Columns[Grid2_COLUMN.PRODT_ORDER_NO].Visible = false;


                #endregion

            }

            #endregion

            #region ▶▶▶ 3.1.3 GRID3 설정

            if (p_GridIndex == 3)
            {
                #region ■■ 3.1.3.1 Pre-setting grid information

                /*** grid3
                     *  실적조회
                     * **/
                Grid3.Columns.Clear();


                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("맑은 고딕", 14);
                Grid3.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                Grid3.RowHeadersVisible = false;

                //Grid3.Columns.Add(SetColumnImage(Grid3_COLUMN.CHECKFLAG, "√", 40));    //이미지형태의 그리드


                //Grid3.Columns.Add(SetColumnImage(grid3_COLUMN.CHECKFLAG, "√", 40));
                //Grid3.Columns.Add(SetColumnEdit(Grid3_COLUMN.CHECK_DT, "점검일", 100));
                Grid3.Columns.Add(SetColumnEdit(grid3_COLUMN.OP_CD, "소분류", 100));
                Grid3.Columns.Add(SetColumnEdit(grid3_COLUMN.OP_NM, "분류명", 280));


                #endregion


                #region ■■ 3.1.3.2 Formatting grid information
                //Grid3.Columns[Grid3_COLUMN.WK_DT].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //Grid3.Columns[Grid3_COLUMN.WK_ORD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid3.Columns[Grid3_COLUMN.PROD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid3.Columns[Grid3_COLUMN.WK_ORD_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태
                //Grid3.Columns[Grid3_COLUMN.PROD_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태


                #endregion


                #region ■■ 3.1.3.3 Setting etc grid

                // Hidden Column Setting
                //Grid3.Columns[Grid3_COLUMN.SEQ].Visible = false;
                //Grid3.Columns[Grid3_COLUMN.PRODT_ORDER_NO].Visible = false;

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


            //if (cboFacility.Value != sFACILITY_CD)
            //{
            //    cboFacility.Value = sFACILITY_CD;

            //}

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

            sWC_CD = cboWC.Value.ToString();
            sFACILITY_CD = cboFacility.Value.ToString();
            DBQuery_WorkStop_RetriveData(); //비가동 정보조회


            LoadingForm(false);

            this.ResumeLayout();
            this.PerformLayout();

            return true;
        }


        private void DBQuery_unWORK_GET_OP_CD() //UNIT에 설정되어 있는 설비리스트를 가져온다.   //매트릭스 버튼 안에 조회해서 캡션이 나올수 있더럭 하는부분 비가동코드 대분류 조회 쿼리 넣을것!
        {
            int nCnt = 0;
            try
            {
                //LoadingForm(true);

                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MES_P0401M1_GET_OP_CD ";

                DataTable dtData1 = null;
                dtData1 = new DataTable();


                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);


                //string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (@strState.Equals("OK") == false)
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "비가동 대분류 버튼");
                    return;
                }

                if (dtData1 != null)
                {
                    tMatrixButtonV1.Clear();

                    for (int i = 0; i < dtData1.Rows.Count; i++)
                    {
                        if (dtData1.Rows[i]["UD_MINOR_CD"].ToString() != "")
                        {

                            tMatrixButtonV1.AddItem(dtData1.Rows[i]["UD_MINOR_CD"].ToString(),  //대분류 코드
                                                    dtData1.Rows[i]["UD_MINOR_NM"].ToString()  //비가동 대분류 명

                                                    );

                        }
                        //else
                        //{
                        //    tMatrixButtonV1.AddItem(dtData1.Rows[i]["WC_CD"].ToString(),        //설비번호 = 작업장
                        //                            dtData1.Rows[i]["WC_NM"].ToString(),        //설비명   = 작업장명
                        //                            dtData1.Rows[i]["WC_CD"].ToString(),        //작업장
                        //                            dtData1.Rows[i]["WC_NM"].ToString(),        //작업장명
                        //                            ""                                          //작업자
                        //                            );
                        //}

                        //if (i < 6)
                        //{
                        //    Hashtable htTemp = (Hashtable)Global.alWorking[i];

                        //    htTemp[Global.htFacilitys_ITEMS.FACILITYCD] = dtData1.Rows[i]["FACILITY_CD"].ToString();
                        //    htTemp[Global.htFacilitys_ITEMS.FACILITYNM] = dtData1.Rows[i]["FACILITY_NM"].ToString();
                        //    htTemp[Global.htFacilitys_ITEMS.WC_CD] = dtData1.Rows[i]["WC_CD"].ToString();
                        //    htTemp[Global.htFacilitys_ITEMS.WC_NM] = dtData1.Rows[i]["WC_NM"].ToString();
                        //}

                    }

                    tMatrixButtonV1.DataBind();
                }



            }
            catch (Exception e)
            {
                TGSControl.UsrFunction.MessageBoxErr(e.Message, "비가동 대분류 버튼 조회");
            }
            finally
            {
                //LoadingForm(false);

            }
        }


        private void DBQuery_WorkStop_RetriveData()
        {
            int nCnt = 0;
            try
            {

                LoadingForm(true);


                Grid1.Rows.Clear();
                Grid2.Rows.Clear();
                Grid3.Rows.Clear();

                string strData = "";
                //strData = WorkCode.WorkCd.STOPWORK_REVIEW;
                //strData += sPLANT_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strData += sWC_MGR + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strData += sFACILITY_CD;

                strData = ""
                            + "EXEC DBO.XUSP_MESSVR_SW_REVIEW_GET "
                            + " @PLANT_CD='" + sPLANT_CD + "',"       //공장
                            + " @WC_MGR='" + sWC_MGR + "',"         //대표공정
                            + " @FACILITY_CD='" + sFACILITY_CD + "'";    //설비코드

                DataTable dtData1 = null;
                dtData1 = new DataTable();


                string strState = "";

                if (Global.szDBConnectStr != "")
                {
                    DataSet dsTmp = new DataSet();
                    TGSClass.DataBase vDB = new DataBase(Global.szDBConnectStr);

                    vDB.DBOpen();

                    if (vDB.QueryOpen(strData, ref dsTmp))
                    {
                        dtData1 = dsTmp.Tables[0];
                        strState = "OK";
                    }
                    else
                    {
                        strState = "99" + vDB.szErrMgs.ToString();
                    }
                    vDB.DBClose();

                }
                else
                {
                    strData = WorkCode.WorkCd.SQLQUERY + strData;
                    strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                }

                //string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (!strState.Equals("OK"))
                {
                    if (strState.Substring(2, 7) == "서버 연결오류")
                    {
                        TGSControl.UsrFunction.MessageBoxInfo(strState.Substring(2), "비가동정보조회");
                    }
                    else if (strState.Substring(2, 7) == "서버 수신오류")
                    {
                        //TGSControl.UsrFunction.MessageBoxInfo(strState.Substring(2), "비가동정보조회");
                    }
                    else if (strState.Substring(2, 13) == "(Exception 2)")
                    {
                        //TGSControl.UsrFunction.MessageBoxInfo(strState.Substring(2), "비가동정보조회");
                    }
                    else
                    {
                        TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "비가동정보조회");
                    }
                    return;
                }

                //if (dtData1 == null || dtData1.Rows.Count <= 0)
                //{
                //    LoadingForm(false);
                //    TGSControl.UsrFunction.MessageBoxErr("조회할 데이타가 존재하지 않습니다.", "조회");
                //    return;
                //}

                //System.Drawing.Image imgChecked = Properties.Resources.CheckBoxUnChecked;
                //imgChecked.Tag = "N";

                for (int i = 0; i < dtData1.Rows.Count; i++)
                {
                    this.Grid1.Rows.Add();

                    //gridWorkStop.SetCellImage(gridWorkStop.Rows.Fixed + i, gridWorkStop.Cols.Fixed + 0, imgChecked);  //1.체크 
                    Grid1.Rows[i].Cells[grid1_COLUMN.L_OP_CD].Value = dtData1.Rows[i][grid1_COLUMN.L_OP_CD].ToString();              //대분류
                    Grid1.Rows[i].Cells[grid1_COLUMN.M_OP_CD].Value = dtData1.Rows[i][grid1_COLUMN.M_OP_CD].ToString();               //중분류
                    Grid1.Rows[i].Cells[grid1_COLUMN.L_OP_NM].Value = dtData1.Rows[i][grid1_COLUMN.L_OP_NM].ToString();              //대분류
                    Grid1.Rows[i].Cells[grid1_COLUMN.M_OP_NM].Value = dtData1.Rows[i][grid1_COLUMN.M_OP_NM].ToString();               //중분류
                    Grid1.Rows[i].Cells[grid1_COLUMN.OP_CD].Value = dtData1.Rows[i][grid1_COLUMN.OP_CD].ToString();             //소분류
                    Grid1.Rows[i].Cells[grid1_COLUMN.OP_NM].Value = dtData1.Rows[i][grid1_COLUMN.OP_NM].ToString();             //소분류명       

                    if (dtData1.Rows[i][grid1_COLUMN.UNWORK_START_DT].ToString().Length > 0)
                    {
                        Grid1.Rows[i].Cells[grid1_COLUMN.UNWORK_START_DT].Value = DateTime.Parse(dtData1.Rows[i][grid1_COLUMN.UNWORK_START_DT].ToString()).ToString("yyyy-MM-dd HH:mm:ss");          //비가동시작일시
                        Grid1.Rows[i].Cells[grid1_COLUMN.UNWORK_START_DT_B].Value = DateTime.Parse(dtData1.Rows[i][grid1_COLUMN.UNWORK_START_DT].ToString()).ToString("yyyy-MM-dd HH:mm:ss");          //비가동시작일시
                    }
                    else
                    {
                        Grid1.Rows[i].Cells[grid1_COLUMN.UNWORK_START_DT].Value = "";          //비가동시작일시
                        Grid1.Rows[i].Cells[grid1_COLUMN.UNWORK_START_DT_B].Value = "";          //비가동시작일시
                    }

                    if (dtData1.Rows[i][grid1_COLUMN.UNWORK_END_DT].ToString().Length > 0)
                        Grid1.Rows[i].Cells[grid1_COLUMN.UNWORK_END_DT].Value = DateTime.Parse(dtData1.Rows[i][grid1_COLUMN.UNWORK_END_DT].ToString()).ToString("yyyy-MM-dd HH:mm:ss");          //비가동완료일시
                    else
                        Grid1.Rows[i].Cells[grid1_COLUMN.UNWORK_END_DT].Value = "";          //비가동완료일시

                    Grid1.Rows[i].Cells[grid1_COLUMN.UNWORK_MIN].Value = dtData1.Rows[i][grid1_COLUMN.UNWORK_MIN].ToString();          //비가동기간
                    Grid1.Rows[i].Cells[grid1_COLUMN.UNWORK_NO].Value = dtData1.Rows[i][grid1_COLUMN.UNWORK_NO].ToString();          //비가동코드
                    //Grid1.Rows[i].Cells[grid1_COLUMN.UNWORK_START_DT_B].Value = dtData1.Rows[i][grid1_COLUMN.UNWORK_START_DT_B].ToString();

                    Grid1.Rows[i].Cells[grid1_COLUMN.SERVER_DT].Value = DateTime.Parse(dtData1.Rows[i][grid1_COLUMN.SERVER_DT].ToString()).ToString("yyyy-MM-dd HH:mm:ss");          //서버시각
                    Grid1.Rows[i].Cells[grid1_COLUMN.WORKER_NM].Value = dtData1.Rows[i][grid1_COLUMN.WORKER_NM].ToString();             //작업자


                    DataGridViewButtonCell btn = new DataGridViewButtonCell();
                    btn.Value = "보기";
                    Grid1.Rows[i].Cells[grid1_COLUMN.SMS_LIST] = btn;

                }

                //비가동 수정버튼 화면 표시여부
                if (Grid1.Rows.Count > 0)
                {
                    btn_Edit.Visible = true;
                }
                else
                {
                    btn_Edit.Visible = false;
                }

                //시작시간이 있으면 체크표시
                bool vChk = false;
                for (int i = 0; i < Grid1.Rows.Count; i++)
                {
                    if (Grid1.Rows[i].Cells[grid1_COLUMN.UNWORK_START_DT].Value.ToString().Length > 0 &&
                        Grid1.Rows[i].Cells[grid1_COLUMN.UNWORK_END_DT].Value.ToString().Length == 0)
                    {
                        //imgChecked = Properties.Resources.CheckBoxChecked;
                        //imgChecked.Tag = "Y";

                        //dgWorkStop.SetCellImage(i, 0, imgChecked);
                        ctL_P0401C21.SERVER_DT = Grid1.Rows[i].Cells[grid1_COLUMN.SERVER_DT].Value.ToString();
                        ctL_P0401C21.OP_NM = Grid1.Rows[i].Cells[grid1_COLUMN.OP_NM].Value.ToString();
                        ctL_P0401C21.START_DT = Grid1.Rows[i].Cells[grid1_COLUMN.UNWORK_START_DT_B].Value.ToString();
                        ctL_P0401C21.UnworkNo = Grid1.Rows[i].Cells[grid1_COLUMN.UNWORK_NO].Value.ToString();

                        ctL_P0401C21.sLOP_CD = Grid1.Rows[i].Cells[grid1_COLUMN.L_OP_CD].Value.ToString();
                        ctL_P0401C21.sMOP_CD = Grid1.Rows[i].Cells[grid1_COLUMN.M_OP_CD].Value.ToString();
                        ctL_P0401C21.sOP_CD = Grid1.Rows[i].Cells[grid1_COLUMN.OP_CD].Value.ToString();


                        vChk = true;
                    }
                }

                if (vChk)
                {
                    FuncWorkStopStart();
                }
                else
                {
                    FuncWorkStopEnd();
                }

            }
            catch
            {
            }
            finally
            {
                LoadingForm(false);
            }

        }

        #region ▶▶▶ 서버시간조회
        private string DBQuery_SERVER_TIME()//비가동 조회
        {
            int nCnt = 0;

            try
            {
                //LoadingForm(true);





                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "SELECT CONVERT(NVARCHAR(19), GETDATE(), 121) SERVER_TIME ";

                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);


                if (!@strState.Equals("OK"))
                {
                    return "";
                }


                if (dtData1 != null)
                {
                    if (dtData1.Rows.Count > 0)
                        return dtData1.Rows[0]["SERVER_TIME"].ToString();
                    else
                        return "";

                }
                return "";



            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "서버시각 조회");
                return "";
            }
            finally
            {
                LoadingForm(false);

            }
            //return true;

        }
        #endregion


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
        //        TGSControl.UsrFunction.MessageBoxErr("작업지시 행을 선택하십시요", "LOT 스캔 삭제");
        //        return;
        //    }
        //    if (Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString() == "")
        //    {
        //        TGSControl.UsrFunction.MessageBoxErr("지시내역을 선택하세요.", "LOT 스캔 삭제");
        //        return;
        //    }

        //    if (Grid4.CurrentRow == null)
        //    {
        //        TGSControl.UsrFunction.MessageBoxErr("삭제할 행을 선택하십시요", "LOT 스캔 삭제");
        //        return;
        //    }


        //    DBSave_LotScan(Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString(), Grid4.CurrentRow.Cells[grid4_COLUMN.LOT_NO].Value.ToString(), Grid4.CurrentRow.Cells[grid4_COLUMN.LOC_NO].Value.ToString(), "D"); //삭제

        //}
        //#endregion ▶▶▶ LOT 스캔한 실적을 삭제한다.




        #endregion

        #region ■■ 4.4.3 DBSave(Common)

        private bool DBSave()
        {
            //DBSave_UNWORK_START();
            return true;
        }


        //저장
        private bool DBSave_UNWORK_START(string pOP_CD, string pWORKER_CD, string pUNWORK_START_DT, string pSMSCheck)
        {

            LoadingForm(true);

            try
            {
                if (bWorkStopStarted)
                {
                    TGSControl.UsrFunction.MessageBoxErr("이미 비가동 처리중입니다..", "비가동시작");
                    return false;
                }


                if (Grid3.CurrentRow == null)
                {
                    TGSControl.UsrFunction.MessageBoxErr("비가동코드 소분류를 체크하세요.", "비가동시작");
                    return false;
                }

                if (sWORKER_CD == "")
                {
                    TGSControl.UsrFunction.MessageBoxErr("작업자를 선택하세요", "비가동시작");
                    return false;
                }

                LoadingForm(true);



                //string strData = WorkCode.WorkCd.SQLPROCEDURE; //프로시져 형태로 호출
                string strData = "";
                strData += "dbo.USP_MES_P_UNWORK_SAVE";       //프로시져 명
                strData += Global.COLUMNS_DIV + "N" + Global.Separation.COLUMNS;   //조회데이타가 없을 경우 'N' = nonquery 있을 경우 'Q' = query
                //일반변수 리스트
                strData += "@SAVE_FLAG" + Global.COLUMNS_DIV;
                strData += "@PLANT_CD" + Global.COLUMNS_DIV;
                strData += "@UNWORK_NO" + Global.COLUMNS_DIV;
                strData += "@UNWORK_START_DT" + Global.COLUMNS_DIV;
                strData += "@UNWORK_END_DT" + Global.COLUMNS_DIV;

                strData += "@WC_MGR" + Global.COLUMNS_DIV;
                strData += "@WC_CD" + Global.COLUMNS_DIV;
                strData += "@FACILITY_CD" + Global.COLUMNS_DIV;
                strData += "@OP_CD" + Global.COLUMNS_DIV;

                strData += "@UNWORK_MIN" + Global.COLUMNS_DIV;
                strData += "@WK_ORD_NO" + Global.COLUMNS_DIV;
                strData += "@RESULT_NO" + Global.COLUMNS_DIV;
                strData += "@USER_ID" + Global.COLUMNS_DIV;
                strData += "@NEW_UNWORK_NO" + Global.COLUMNS_DIV;

                strData += "@RTN_MSG" + Global.Separation.COLUMNS;


                //일반변수 리스트의 형식
                strData += Global.DBVarType.VarChar + "(1)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(4)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(30)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.Datetime + "" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.Datetime + "" + Global.COLUMNS_DIV;

                strData += Global.DBVarType.VarChar + "(7)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(7)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(18)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(7)" + Global.COLUMNS_DIV;

                strData += Global.DBVarType.Numeric + "(18,2)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(30)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(20)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(10)" + Global.COLUMNS_DIV;

                strData += Global.DBVarType.VarChar + "(30) OUTPUT" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(200) OUTPUT" + Global.Separation.COLUMNS;

                //일반변수값 리스트
                strData += "I" + Global.COLUMNS_DIV;        //저장구분
                strData += sPLANT_CD + Global.COLUMNS_DIV;  //공장
                strData += "" + Global.COLUMNS_DIV;         //실적번호
                strData += pUNWORK_START_DT + Global.COLUMNS_DIV;   //비가동 시작시각
                strData += "NULL" + Global.COLUMNS_DIV;     //비가동 종료시각

                strData += sWC_MGR + Global.COLUMNS_DIV;    //공정그룹
                strData += sWC_CD + Global.COLUMNS_DIV;     //작업장
                strData += sFACILITY_CD + Global.COLUMNS_DIV;   //설비
                strData += pOP_CD + Global.COLUMNS_DIV;         //비가동코드

                strData += "0" + Global.COLUMNS_DIV;            //비가동 시간
                strData += sWK_ORD_NO + Global.COLUMNS_DIV;//작업자
                strData += sRESULT_NO + Global.COLUMNS_DIV;     //생산실적번호
                strData += pWORKER_CD + Global.COLUMNS_DIV;     //작업자

                strData += "" + Global.COLUMNS_DIV;             //비가동번호 반환
                strData += "" + Global.Separation.COLUMNS;      //RTN MSG 반환


                //OUTPUT변수 리스트 
                //strData += "@RESULT_NO" + Global.COLUMNS_DIV;
                //strData += "@RTN_MSG";
                strData += TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //OUTPUT변수 리스트 형식
                //strData += Global.DBVarType.VarChar + "(20)" + Global.COLUMNS_DIV;
                //strData += Global.DBVarType.VarChar + "(200)";
                strData += Global.Separation.COLUMNS;
                //OUTPUT변수값 리스트
                //strData += "" + Global.COLUMNS_DIV;
                strData += ""; // +TGSClass.nsGlobal.Global.Separation.COLUMNS;


                //string strState = TGSClass.DataBase.ExcuteSql(MainForm, strData, Global.workinfo.szServerIP, Global.workinfo.szPortNo); //반환테이블이 없을 경우
                DataTable dtData1 = new DataTable();
                int nCnt = 0;

                string strState = TGSClass.DataBase.GetDataSqlProcedur(MainForm, strData, ref dtData1, ref nCnt); //TGS Class 사용
                //string strState = TGSClass.DataBase.GetDataSql(MainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);//반환테이블이있을 경우


                if (!strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), " 비가동시작");
                    LoadingForm(false);
                    return false;
                }


                ////저장완료
                if (dtData1 != null && dtData1.Rows.Count > 0)
                {
                    string vNEW_UNWORK_NO = dtData1.Rows[0]["@NEW_UNWORK_NO"].ToString();

                    string vLOP_CD = Grid2.CurrentRow.Cells[grid2_COLUMN.L_OP_CD].Value.ToString();
                    string vMOP_CD = Grid2.CurrentRow.Cells[grid2_COLUMN.M_OP_CD].Value.ToString();
                    string vOP_CD = Grid3.CurrentRow.Cells[grid3_COLUMN.OP_CD].Value.ToString();

                    Grid3.CurrentRow.Cells[grid3_COLUMN.OP_CD].Value.ToString();

                    if (pSMSCheck.Equals("Y"))
                    {
                        //비가동으로 등록된 기본 메세지가 있는지 확인한다.
                        if (DBQuery_Count_Unwork_Basic_Message(vLOP_CD, vMOP_CD, vOP_CD) > 0)
                        {
                            ShowSendMessage(vNEW_UNWORK_NO, "ST", vLOP_CD, vMOP_CD, vOP_CD);  //메세지 보내기 호출.
                        }
                    }
                }


                DBQuery_WorkStop_RetriveData(); //비가동 정보조회

                FuncWorkStopStart();    //비가동 시작 활성 플래그

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
        //비가동 SMS 메시지 개수를 조회한다.
        private int DBQuery_Count_Unwork_Basic_Message(string pLOP_CD, string pMOP_CD, string pOP_CD)
        {
            string strSQL = string.Empty;
            strSQL += "EXEC XUSP_SMS_Z1001M1_MESSAGE_GET ";
            strSQL += " @WC_MGR ='" + sWC_MGR + "'";
            strSQL += ",@L_CD ='" + pLOP_CD + "'";
            strSQL += ",@M_CD ='" + pMOP_CD + "'";
            strSQL += ",@S_CD ='" + pOP_CD + "'";
            //strSQL += ",@STATUS ='" + sMSG_STATUS + "'";

            int nCnt = 0;
            DataTable dt = new DataTable();
            string strState = TGSClass.DataBase.GetDataSql(sMainForm, strSQL, ref dt, ref nCnt);

            return dt.Rows.Count;
        }

        private void ShowSendMessage(string pUnworkNo, string pMsgStatus, string pLOP_CD, string pMOP_CD, string pOP_CD)
        {
            //임시주석
            //MES_APP_Z10.C_SMS.ShowSendMessage("OP", sPLANT_CD, sWC_MGR, pUnworkNo, pMsgStatus, pLOP_CD, pMOP_CD, pOP_CD, cboWorker.Value, cboFacility.Value, cboWC.Value, this.MainForm); //비가동 메시지 전달

            //MES_APP_Z10.POP_Z1001M1 popSMS = new MES_APP_Z10.POP_Z1001M1();

            //DataTable dt = new DataTable("PassData");
            //dt.Columns.Add("PLANT_CD");
            //dt.Columns.Add("WC_MGR");
            //dt.Columns.Add("FACILITY_CD");
            //dt.Columns.Add("UNWORK_NO");
            //dt.Columns.Add("OP_CD");
            //dt.Columns.Add("L_OP_CD");
            //dt.Columns.Add("M_OP_CD");

            //dt.Columns.Add("OP_NM");
            //dt.Columns.Add("L_OP_NM");
            //dt.Columns.Add("M_OP_NM");


            //dt.Columns.Add("PLANT_NM");
            //dt.Columns.Add("FACILITY_NM");
            //dt.Columns.Add("WC_MGR_NM");
            //dt.Columns.Add("WC_CD");
            //dt.Columns.Add("WC_NM");
            //dt.Columns.Add("WORKER_CD");
            //dt.Columns.Add("WORKER_NM");
            //dt.Columns.Add("MSG_STATUS");

            //dt.Rows.Add();

            //dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
            //dt.Rows[0]["PLANT_NM"] = Global.workinfo.szFactoryNM;
            //dt.Rows[0]["WC_MGR"] = sWC_MGR;
            //dt.Rows[0]["WC_MGR_NM"] = Global.workinfo.szProcessNM;

            //dt.Rows[0]["UNWORK_NO"] = pUnworkNo;

            //dt.Rows[0]["OP_CD"] = pOP_CD;//Grid3.CurrentRow.Cells[grid3_COLUMN.OP_CD].Value.ToString();
            //dt.Rows[0]["L_OP_CD"] = pLOP_CD;//Grid2.CurrentRow.Cells[grid2_COLUMN.L_OP_CD].Value.ToString();
            //dt.Rows[0]["M_OP_CD"] = pMOP_CD;//Grid2.CurrentRow.Cells[grid2_COLUMN.M_OP_CD].Value.ToString();

            //dt.Rows[0]["OP_NM"] = pOP_CD;//Grid3.CurrentRow.Cells[grid3_COLUMN.OP_CD].Value.ToString();
            //dt.Rows[0]["L_OP_NM"] = pLOP_CD;//Grid2.CurrentRow.Cells[grid2_COLUMN.L_OP_CD].Value.ToString();
            //dt.Rows[0]["M_OP_NM"] = pMOP_CD;//Grid2.CurrentRow.Cells[grid2_COLUMN.M_OP_CD].Value.ToString();

            
            //dt.Rows[0]["FACILITY_CD"] = cboFacility.Value;
            //dt.Rows[0]["FACILITY_NM"] = cboFacility.ValueName;
            //dt.Rows[0]["WC_CD"] = cboWC.Value;
            //dt.Rows[0]["WC_NM"] = cboWC.ValueName;
            //dt.Rows[0]["WORKER_CD"] = cboWorker.Value;
            //dt.Rows[0]["WORKER_NM"] = cboWorker.ValueName;

            

            //dt.Rows[0]["MSG_STATUS"] = pMsgStatus;

            //string vSMS_Title = string.Empty;

            //switch (pMsgStatus)
            //{
            //    case "ST":
            //        vSMS_Title = "-비가동 시작";
            //        break;
            //    case "ING":
            //        vSMS_Title = "-비가동 점검 중";
            //        break;
            //    case "CL":
            //        vSMS_Title = "-비가동 종료";
            //        break;
            //    default:
            //        vSMS_Title = "-경보 알림";
            //        break;
            //}
            //popSMS.MainForm = this.MainForm;
            //popSMS.ResultData.Tables.Add(dt); //변수전달

            //popSMS.Caption = "SMS 발송 " + vSMS_Title;
            //popSMS.Start();

            //if (pMsgStatus != "CL")
            //{
            //    popSMS.ShowDialog();


            //    if (popSMS.DialogResult == DialogResult.OK)
            //    {

            //    }
            //}
        }



        //비가동 수정저장
        private bool DBSave_UNWORK_UPDATE(string pUNWORK_NO, string pOP_CD, string pWORKER_CD, string pUNWORK_START_DT, string pUNWORK_END_DT)
        {

            LoadingForm(true);

            try
            {

                LoadingForm(true);

                //string strData = WorkCode.WorkCd.SQLPROCEDURE; //프로시져 형태로 호출
                string strData = "";
                strData += "dbo.USP_MES_P_UNWORK_UPDATE";       //프로시져 명
                strData += Global.COLUMNS_DIV + "N" + Global.Separation.COLUMNS;   //조회데이타가 없을 경우 'N' = nonquery 있을 경우 'Q' = query
                //일반변수 리스트
                strData += "@PLANT_CD" + Global.COLUMNS_DIV;
                strData += "@UNWORK_NO" + Global.COLUMNS_DIV;
                strData += "@UNWORK_START_DT" + Global.COLUMNS_DIV;
                strData += "@UNWORK_END_DT" + Global.COLUMNS_DIV;

                strData += "@WC_MGR" + Global.COLUMNS_DIV;
                strData += "@FACILITY_CD" + Global.COLUMNS_DIV;
                strData += "@OP_CD" + Global.COLUMNS_DIV;
                strData += "@USER_ID" + Global.COLUMNS_DIV;

                strData += "@RTN_MSG" + Global.Separation.COLUMNS;


                //일반변수 리스트의 형식
                strData += Global.DBVarType.VarChar + "(4)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(30)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.Datetime + "" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.Datetime + "" + Global.COLUMNS_DIV;

                strData += Global.DBVarType.VarChar + "(7)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(18)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(7)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(10)" + Global.COLUMNS_DIV;

                strData += Global.DBVarType.VarChar + "(200) OUTPUT" + Global.Separation.COLUMNS;

                //일반변수값 리스트
                strData += sPLANT_CD + Global.COLUMNS_DIV;  //공장
                strData += pUNWORK_NO + Global.COLUMNS_DIV;         //실적번호
                strData += pUNWORK_START_DT + Global.COLUMNS_DIV;   //비가동 시작시각
                strData += pUNWORK_END_DT + Global.COLUMNS_DIV;     //비가동 종료시각

                strData += sWC_MGR + Global.COLUMNS_DIV;    //공정그룹
                strData += sFACILITY_CD + Global.COLUMNS_DIV;   //설비
                strData += pOP_CD + Global.COLUMNS_DIV;         //비가동코드
                strData += pWORKER_CD + Global.COLUMNS_DIV;     //작업자

                strData += "" + Global.Separation.COLUMNS;      //RTN MSG 반환


                //OUTPUT변수 리스트 
                //strData += "@RESULT_NO" + Global.COLUMNS_DIV;
                //strData += "@RTN_MSG";
                strData += TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //OUTPUT변수 리스트 형식
                //strData += Global.DBVarType.VarChar + "(20)" + Global.COLUMNS_DIV;
                //strData += Global.DBVarType.VarChar + "(200)";
                strData += Global.Separation.COLUMNS;
                //OUTPUT변수값 리스트
                //strData += "" + Global.COLUMNS_DIV;
                strData += ""; // +TGSClass.nsGlobal.Global.Separation.COLUMNS;


                //string strState = TGSClass.DataBase.ExcuteSql(MainForm, strData, Global.workinfo.szServerIP, Global.workinfo.szPortNo); //반환테이블이 없을 경우
                DataTable dtData1 = new DataTable();
                int nCnt = 0;

                string strState = TGSClass.DataBase.GetDataSqlProcedur(MainForm, strData, ref dtData1, ref nCnt); //TGS Class 사용
                //string strState = TGSClass.DataBase.GetDataSql(MainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);//반환테이블이있을 경우


                if (!strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), " 비가동수정");
                    LoadingForm(false);
                    return false;
                }


                ////저장완료
                //if (dtData1 != null && dtData1.Rows.Count > 0)
                //{
                //    //string sNEW_UNWORK_NO = dtData1.Rows[0]["NEW_UNWORK_NO"].ToString();

                //}


                DBQuery_WorkStop_RetriveData(); //비가동 정보조회

                //FuncWorkStopStart();    //비가동 시작 활성 플래그

            }
            catch (Exception se)
            {
                //TGSControl.UsrFunction.MessageBoxErr(se.Message, "저장작업");
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








        //비동기취소 버튼
        private void btnCancel_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (!bWorkStopStarted)
                {
                    TGSControl.UsrFunction.MessageBoxErr("비가동 작업중이 아닙니다.", "비가동취소");
                    return;
                }


                //int nCheckedRow = CheckedRow(gridWorkStop, 0);
                if (Grid1.CurrentRow == null)
                {
                    TGSControl.UsrFunction.MessageBoxErr("비가동이 시작되지 않았습니다.", "비가동취소");
                    return;
                }

                if (TGSControl.UsrFunction.MessageBoxYesNo("비가동 정보를 취소하시겠습니까?", "비가동취소") == DialogResult.No)
                {
                    return;
                }

                LoadingForm(true);


                string szSendData = WorkCode.WorkCd.STOPWORK_CANCEL;
                szSendData += sPLANT_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += sWC_MGR + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += sFACILITY_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += sWORKER_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += sWK_ORD_NO + TGSClass.nsGlobal.Global.Separation.COLUMNS;    //워크오더 하위프로그램에서 받기
                szSendData += sRESULT_NO + TGSClass.nsGlobal.Global.Separation.COLUMNS;   //하위에서

                szSendData += Grid1.CurrentRow.Cells[grid1_COLUMN.UNWORK_NO].ToString() + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += Grid1.CurrentRow.Cells[grid1_COLUMN.OP_CD].ToString() + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += DateTime.Parse(Grid1.CurrentRow.Cells[grid1_COLUMN.UNWORK_START_DT_B].ToString()).ToString("yyyy-MM-dd HH:mm:ss") + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += sWC_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;

                DataTable dtData1 = null;
                dtData1 = new DataTable();
                int nCnt = 0;

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, szSendData, ref dtData1, ref nCnt);
                if (!strState.Equals("OK"))
                {
                    //                    TGSControl.UsrFunction.MessageBoxErr("취소중 오류가 발생하였습다.", "비가동취소");
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "비가동취소");
                    return;
                }


                DBQuery_WorkStop_RetriveData();

                FuncWorkStopEnd();
            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "비가동취소");
            }
            finally
            {
                LoadingForm(false);
            }
        }


        private void FuncWorkStopStart()        //비가동 시작 플래그 활성
        {
            bWorkStopStarted = true;
            UnworkPanel_View(bWorkStopStarted);

            btn_End.Visible = true;
            btn_ING.Visible = true;
            btn_Cancel.Visible = true;
            btn_Start.Visible = false;

            //tMatrixButtonV1.Enabled = false;

            //Grid1.Enabled = false;
            //Grid2.Enabled = false;
            //Grid3.Enabled = false;
        }
        private void FuncWorkStopEnd()
        {
            bWorkStopStarted = false;
            UnworkPanel_View(bWorkStopStarted);

            btn_End.Visible = false;
            btn_ING.Visible = false;
            btn_Cancel.Visible = false;

            btn_Start.Visible = true;

            //tMatrixButtonV1.Enabled = true;

            //Grid1.Enabled = true;
            //Grid2.Enabled = true;
            //Grid3.Enabled = true;
        }

        //닫기 버튼
        private void btn_Close_ButtonClick(object sender, EventArgs e)
        {
            this.CommandRun_Event("CLOSE");
        }



        //매트릭스 버튼 클릭시
        private void tMatrixButtonV1_ButtonClick(object sender, EventArgs e)
        {
            if (tMatrixButtonV1.Value == "") return;

            int nCnt = 0;

            try
            {

                LoadingForm(true);

                FuncL_OP(tMatrixButtonV1.Value.ToString());

                //nsGridUtil.GridUtil.SetGridClear(Grid2);
                //nsGridUtil.GridUtil.SetGridClear(Grid3);
                Grid2.Rows.Clear();
                Grid3.Rows.Clear();
                btn_Start.Enabled = false;

                string strData = "";
                //strData = WorkCode.WorkCd.STOPWORK_M_REVIEW;
                //strData += sPLANT_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strData += sWC_MGR + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strData += tMatrixButtonV1.Value.ToString();

                strData = ""
                            + "SELECT T1.L_OP_CD,T1.M_OP_CD, T2.UD_MINOR_NM AS M_OP_NM  "
                            + " FROM MES_P_OP_CD_M  AS T1 (NOLOCK) "
                            + " LEFT OUTER JOIN B_USER_DEFINED_MINOR AS T2 (NOLOCK) ON T2.UD_MAJOR_CD = 'PD102' AND T1.M_OP_CD = T2.UD_MINOR_CD "
                            + " WHERE T1.PLANT_CD = '" + sPLANT_CD + " '"
                            + "     AND WC_MGR = '" + sWC_MGR + "'"
                            + "     AND T1.L_OP_CD  = '" + tMatrixButtonV1.Value.ToString() + "'"  // --@L_OP_CD
                            + " 	AND T1.WORK_YN  = 'Y'"
                            + "     AND T1.USE_YN   = 'Y'";


                DataTable dtData1 = null;
                dtData1 = new DataTable();


                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);



                //string strState = TGSClass.DataBase.GetDataSql(this.sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (!strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "중분류조회");
                    return;
                }

                //if (dtData1 == null || dtData1.Rows.Count <= 0)
                //{
                //    LoadingForm(false);
                //    TGSControl.UsrFunction.MessageBoxErr("조회할 데이타가 존재하지 않습니다.", "중분류조회");
                //    return;
                //}

                //System.Drawing.Image imgChecked = Properties.Resources.CheckBoxUnChecked;
                //imgChecked.Tag = "N";

                for (int i = 0; i < dtData1.Rows.Count; i++)
                {
                    this.Grid2.Rows.Add();

                    //Grid2.SetCellImage(Grid2.Rows.Fixed + i, Grid2.Cols.Fixed + 0, imgChecked);  //1.체크 

                    Grid2.Rows[i].Cells[grid2_COLUMN.L_OP_CD].Value = dtData1.Rows[i][grid2_COLUMN.L_OP_CD].ToString();             //대분류
                    Grid2.Rows[i].Cells[grid2_COLUMN.M_OP_CD].Value = dtData1.Rows[i][grid2_COLUMN.M_OP_CD].ToString();              //중분류    
                    Grid2.Rows[i].Cells[grid2_COLUMN.M_OP_NM].Value = dtData1.Rows[i][grid2_COLUMN.M_OP_NM].ToString();          //중분류명

                }
            }
            catch (Exception se)
            {
            }
            finally
            {
                LoadingForm(false);
            }

        }

        private void FuncL_OP(string szLOP)
        {
            tMatrixButtonV1.BackColor = Color.Transparent;
            switch (szLOP)
            {
                //case "01": tMatrixButtonV1.RowIndex = Color.Red; break;
                //case "02": btnTroubleStop.BackColor = Color.Red; break;
                //case "03": btnQulityProblem.BackColor = Color.Red; break;
                //case "04": btnPreparatoryDelay.BackColor = Color.Red; break;
                //case "05": btnSample.BackColor = Color.Red; break;
                //case "06": btnWorkerShortSupply.BackColor = Color.Red; break;
            }
        }


        private void Grid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StopWork_S_RetriveData();
        }


        private void StopWork_S_RetriveData()       //grid2에서 셀을 선택했을때 소분류 조회 하는 쿼리
        {
            int nCnt = 0;
            try
            {

                if (Grid2.CurrentRow == null)
                {
                    TGSControl.UsrFunction.MessageBoxErr("중분류를 선택 하세요.", "소분류조회");
                    return;
                }


                LoadingForm(true);


                //nsGridUtil.GridUtil.SetGridClear(gridS_OP);
                Grid3.Rows.Clear();
                btn_Start.Enabled = false;


                string strData = "";
                //strData = WorkCode.WorkCd.STOPWORK_S_REVIEW;
                //strData += sPLANT_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strData += sWC_MGR + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strData += Grid2.CurrentRow.Cells[grid2_COLUMN.L_OP_CD].Value.ToString() + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strData += Grid2.CurrentRow.Cells[grid2_COLUMN.M_OP_CD].Value.ToString();

                strData = ""
                            + "SELECT T1.OP_CD,"
                            + "        T3.UD_MINOR_NM AS OP_NM"
                            + " FROM MES_P_OP_CD AS T1 (NOLOCK)"
                            + " LEFT OUTER JOIN B_USER_DEFINED_MINOR AS T3 (NOLOCK) ON T3.UD_MAJOR_CD = 'PD101' AND T1.OP_CD = T3.UD_MINOR_CD"
                            + " LEFT OUTER JOIN MES_P_OP_CD_M  AS T2 (NOLOCK)"
                            + "   ON T1.PLANT_CD= T2.PLANT_CD"
                            + "  AND T1.WC_MGR= T2.WC_MGR"
                            + "  AND T1.L_OP_CD= T2.L_OP_CD"
                            + "  AND T1.M_OP_CD= T2.M_OP_CD"
                            + "  AND T2.WORK_YN= 'Y'"
                            + "  AND T2.USE_YN= 'Y'"
                            + " WHERE T1.PLANT_CD = '" + sPLANT_CD + "'"
                            + "  AND T1.WC_MGR= '" + sWC_MGR + "'" //--@WC_MGR
                            + "  AND T1.L_OP_CD= '" + Grid2.CurrentRow.Cells[grid2_COLUMN.L_OP_CD].Value.ToString() + "'" //--@L_OP_CD
                            + "  AND T1.M_OP_CD= '" + Grid2.CurrentRow.Cells[grid2_COLUMN.M_OP_CD].Value.ToString() + "'"  //--@M_OP_CD
                            + "  AND T2.WORK_YN= 'Y'"
                            + "  AND T2.USE_YN= 'Y'"
                            + " ORDER BY T1.OP_CD";


                DataTable dtData1 = null;
                dtData1 = new DataTable();


                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);


                //string strState = TGSClass.DataBase.GetDataSql(this.sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);

                if (!strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "소분류조회");
                    return;
                }

                //if (dtData1 == null || dtData1.Rows.Count <= 0)
                //{
                //    LoadingForm(false);
                //    TGSControl.UsrFunction.MessageBoxErr("조회할 데이타가 존재하지 않습니다.", "소분류조회");
                //    return;
                //}

                //System.Drawing.Image imgChecked = Properties.Resources.CheckBoxUnChecked;
                //imgChecked.Tag = "N";

                for (int i = 0; i < dtData1.Rows.Count; i++)
                {
                    this.Grid3.Rows.Add();

                    //gridS_OP.SetCellImage(gridS_OP.Rows.Fixed + i, gridS_OP.Cols.Fixed + 0, imgChecked);  //1.체크 

                    Grid3.Rows[i].Cells[grid3_COLUMN.OP_CD].Value = dtData1.Rows[i][grid3_COLUMN.OP_CD].ToString();             //소분류
                    Grid3.Rows[i].Cells[grid3_COLUMN.OP_NM].Value = dtData1.Rows[i][grid3_COLUMN.OP_NM].ToString();              //소분류명   
                }

            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "소분류조회");
            }
            finally
            {
                LoadingForm(false);
            }

        }

        private void cboWC_SelectedValueChanged(object sender, EventArgs e)
        {
            sWC_CD = cboWC.Value.ToString();
            Retrive_Facility();
            //Grid1.Rows.Clear();
            //Grid2.Rows.Clear();
            //Grid3.Rows.Clear();
            DBQuery();
        }

        private void cboFacility_SelectedValueChanged(object sender, EventArgs e)
        {
            //Grid1.Rows.Clear();
            //Grid2.Rows.Clear();
            //Grid3.Rows.Clear();
            DBQuery();
        }



        private void btn_Start_ButtonClick(object sender, EventArgs e)
        {
            if (Grid3.CurrentRow != null)
            {
                Show_UNWORK_insert();   //비가동 시작창을 띄운 후 저장한다.
                //DBSave_UNWORK_START();
            }
            else
            {
                TGSControl.UsrFunction.MessageBoxErr("비가동 사유를 선택 후 시작하세요.", "비가동 사유 선택");
                return;
            }
        }

        private void Show_UNWORK_insert()
        {

            if (bWorkStopStarted)
            {
                TGSControl.UsrFunction.MessageBoxErr("이미 비가동 처리중입니다..", "비가동시작");
                return;
            }

            if (Grid3.CurrentRow == null)
            {
                TGSControl.UsrFunction.MessageBoxErr("비가동코드 소분류를 체크하세요.", "비가동시작");
                return;
            }


            if (sWORKER_CD == "")
            {
                TGSControl.UsrFunction.MessageBoxErr("작업자를 선택하세요", "비가동시작");
                return;
            }

            POP_P9001PA3 myForm = new POP_P9001PA3();

            //파라메터를 설정한다.

            DataTable dt = new DataTable("PassData");
            dt.Columns.Add("PLANT_CD");
            dt.Columns.Add("WC_MGR");
            dt.Columns.Add("FACILITY_CD");
            dt.Columns.Add("UNWORK_NO");
            dt.Columns.Add("OP_CD");
            dt.Columns.Add("L_OP_CD");
            dt.Columns.Add("M_OP_CD");
            dt.Columns.Add("OP_NM");
            dt.Columns.Add("OP_GRP_NM");
            dt.Columns.Add("WORKER_CD");


            dt.Rows.Add();

            dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
            dt.Rows[0]["WC_MGR"] = sWC_MGR;
            dt.Rows[0]["FACILITY_CD"] = sFACILITY_CD;
            dt.Rows[0]["UNWORK_NO"] = "";
            dt.Rows[0]["OP_CD"] = Grid3.CurrentRow.Cells[grid3_COLUMN.OP_CD].Value.ToString();
            dt.Rows[0]["L_OP_CD"] = Grid2.CurrentRow.Cells[grid2_COLUMN.L_OP_CD].Value.ToString();
            dt.Rows[0]["M_OP_CD"] = Grid2.CurrentRow.Cells[grid2_COLUMN.M_OP_CD].Value.ToString();
            dt.Rows[0]["OP_NM"] = Grid3.CurrentRow.Cells[grid3_COLUMN.OP_NM].Value.ToString();
            dt.Rows[0]["OP_GRP_NM"] = tMatrixButtonV1.ValueName.ToString() + " > " + Grid2.CurrentRow.Cells[grid2_COLUMN.M_OP_NM].Value.ToString();
            dt.Rows[0]["WORKER_CD"] = sWORKER_CD;





            myForm.MainForm = this.MainForm;
            myForm.ResultData.Tables.Add(dt); //변수전달


            myForm.Caption = "비가동 시작";
            myForm.Start(); //시작함수를 실행한다.


            myForm.ShowDialog(); //화면에 표시

            if (myForm.DialogResult == DialogResult.OK)
            {
                string vOP_CD = myForm.ResultData.Tables["Result"].Rows[0]["OP_CD"].ToString();
                string vWORKER_CD = myForm.ResultData.Tables["Result"].Rows[0]["WORKER_CD"].ToString();
                string vUNWORK_START_DT = myForm.ResultData.Tables["Result"].Rows[0]["UNWORK_START_DT"].ToString();
                string vSMSCheck = myForm.ResultData.Tables["Result"].Rows[0]["BOOL_SMS"].ToString();

                ////신규 비가동을 시작한다.
                DBSave_UNWORK_START(vOP_CD, vWORKER_CD, vUNWORK_START_DT, vSMSCheck);
                //DBSave_UNWORK_START(vOP_CD, vWORKER_CD);

            }

            DBQuery();//비가동 내역을 다시 조회
        }

        private void btn_Cancel_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (Grid1.CurrentRow.Cells[grid1_COLUMN.UNWORK_END_DT].Value.ToString() == "")
                {
                    bWorkStopStarted = true;
                    UnworkPanel_View(bWorkStopStarted);
                }
                if (!bWorkStopStarted)
                {
                    TGSControl.UsrFunction.MessageBoxErr("비가동 작업중이 아닙니다.", "비가동취소");
                    return;
                }

                //int nCheckedRow = CheckedRow(gridWorkStop, 0);
                if (Grid1.Rows.Count < 0)
                {
                    TGSControl.UsrFunction.MessageBoxErr("비가동이 시작되지 않았습니다.", "비가동취소");
                    return;
                }

                if (TGSControl.UsrFunction.MessageBoxYesNo("비가동 정보를 취소하시겠습니까?", "비가동취소") == DialogResult.No)
                {
                    return;
                }

                LoadingForm(true);


                string szSendData = WorkCode.WorkCd.STOPWORK_CANCEL;
                szSendData += sPLANT_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += sWC_MGR + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += sFACILITY_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += sWORKER_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += sWK_ORD_NO + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += sRESULT_NO + TGSClass.nsGlobal.Global.Separation.COLUMNS;

                szSendData += Grid1.CurrentRow.Cells[grid1_COLUMN.UNWORK_NO].Value.ToString() + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += Grid1.CurrentRow.Cells[grid1_COLUMN.OP_CD].Value.ToString() + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += Grid1.CurrentRow.Cells[grid1_COLUMN.UNWORK_START_DT].Value.ToString() + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += sWC_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;

                DataTable dtData1 = null;
                dtData1 = new DataTable();
                int nCnt = 0;

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, szSendData, ref dtData1, ref nCnt);
                if (!strState.Equals("OK"))
                {
                    //                    TGSControl.UsrFunction.MessageBoxErr("취소중 오류가 발생하였습다.", "비가동취소");
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "비가동취소");
                    return;
                }

                //비가동 취소 문자메시지 전송
                ShowSendMessage(ctL_P0401C21.UnworkNo, "CN", ctL_P0401C21.sLOP_CD, ctL_P0401C21.sMOP_CD, ctL_P0401C21.sOP_CD);

                DBQuery_WorkStop_RetriveData();

                FuncWorkStopEnd();
            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "비가동취소");
            }
            finally
            {
                LoadingForm(false);
            }
        }

        private void btn_End_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (Grid1.CurrentRow.Cells[grid1_COLUMN.UNWORK_END_DT].Value.ToString() == "")
                {
                    bWorkStopStarted = true;
                    UnworkPanel_View(bWorkStopStarted);
                }
                if (!bWorkStopStarted)
                {
                    TGSControl.UsrFunction.MessageBoxErr("비가동 작업중이 아닙니다.", "비가동종료");
                    return;
                }


                //int nCheckedRow = CheckedRow(gridWorkStop, 0);
                if (Grid1.Rows.Count < 0)
                {
                    TGSControl.UsrFunction.MessageBoxErr("비가동이 시작되지 않았습니다.", "비가동종료");
                    return;
                }

                if (TGSControl.UsrFunction.MessageBoxYesNo("비가동 정보를 종료하시겠습니까?", "비가동종료") == DialogResult.No)
                {
                    return;
                }


                LoadingForm(true);



                //string szSendData = WorkCode.WorkCd.STOPWORK_END;
                //szSendData += sPLANT_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += sWC_MGR + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += sFACILITY_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += sWORKER_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += sWK_ORD_NO + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += sRESULT_NO + TGSClass.nsGlobal.Global.Separation.COLUMNS;

                //szSendData += Grid1.CurrentRow.Cells[grid1_COLUMN.UNWORK_NO].Value.ToString() + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += Grid1.CurrentRow.Cells[grid1_COLUMN.OP_CD].Value.ToString() + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += Grid1.CurrentRow.Cells[grid1_COLUMN.UNWORK_START_DT].Value.ToString() + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += sWC_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;


                //string strState = TGSClass.DataBase.ExcuteSql(this.sMainForm, szSendData, Global.workinfo.szServerIP, Global.workinfo.szPortNo);



                string strData = "";
                strData += "dbo.USP_MES_P_UNWORK_SAVE";       //프로시져 명
                strData += Global.COLUMNS_DIV + "N" + Global.Separation.COLUMNS;   //조회데이타가 없을 경우 'N' = nonquery 있을 경우 'Q' = query
                //일반변수 리스트
                strData += "@SAVE_FLAG" + Global.COLUMNS_DIV;
                strData += "@PLANT_CD" + Global.COLUMNS_DIV;
                strData += "@UNWORK_NO" + Global.COLUMNS_DIV;
                strData += "@UNWORK_START_DT" + Global.COLUMNS_DIV;
                strData += "@UNWORK_END_DT" + Global.COLUMNS_DIV;

                strData += "@WC_MGR" + Global.COLUMNS_DIV;
                strData += "@WC_CD" + Global.COLUMNS_DIV;
                strData += "@FACILITY_CD" + Global.COLUMNS_DIV;
                strData += "@OP_CD" + Global.COLUMNS_DIV;

                strData += "@UNWORK_MIN" + Global.COLUMNS_DIV;
                strData += "@WK_ORD_NO" + Global.COLUMNS_DIV;
                strData += "@RESULT_NO" + Global.COLUMNS_DIV;
                strData += "@USER_ID" + Global.COLUMNS_DIV;
                strData += "@NEW_UNWORK_NO" + Global.COLUMNS_DIV;

                strData += "@RTN_MSG" + Global.Separation.COLUMNS;


                //일반변수 리스트의 형식
                strData += Global.DBVarType.VarChar + "(1)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(4)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(30)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.Datetime + "" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.Datetime + "" + Global.COLUMNS_DIV;

                strData += Global.DBVarType.VarChar + "(7)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(7)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(18)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(7)" + Global.COLUMNS_DIV;

                strData += Global.DBVarType.Numeric + "(18,2)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(30)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(20)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(10)" + Global.COLUMNS_DIV;

                strData += Global.DBVarType.VarChar + "(30) OUTPUT" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(200) OUTPUT" + Global.Separation.COLUMNS;

                //일반변수값 리스트
                strData += "U" + Global.COLUMNS_DIV;        //저장구분
                strData += sPLANT_CD + Global.COLUMNS_DIV;  //공장
                strData += Grid1.CurrentRow.Cells[grid1_COLUMN.UNWORK_NO].Value.ToString() + Global.COLUMNS_DIV;         //실적번호
                strData += Grid1.CurrentRow.Cells[grid1_COLUMN.UNWORK_START_DT].Value.ToString() + Global.COLUMNS_DIV;   //비가동 시작시각

                string vEND_DT = DBQuery_SERVER_TIME();
                strData += vEND_DT + Global.COLUMNS_DIV;     //비가동 종료시각

                strData += sWC_MGR + Global.COLUMNS_DIV;    //공정그룹
                strData += sWC_CD + Global.COLUMNS_DIV;     //작업장
                strData += sFACILITY_CD + Global.COLUMNS_DIV;   //설비
                strData += Grid1.CurrentRow.Cells[grid1_COLUMN.OP_CD].Value.ToString() + Global.COLUMNS_DIV;         //비가동코드

                TimeSpan ts = DateTime.Parse(vEND_DT).Subtract(DateTime.Parse(Grid1.CurrentRow.Cells[grid1_COLUMN.UNWORK_START_DT].Value.ToString()));

                strData += ts.Minutes.ToString() + Global.COLUMNS_DIV;            //비가동 시간
                strData += "" + Global.COLUMNS_DIV;//작업자
                strData += "" + Global.COLUMNS_DIV;     //생산실적번호
                strData += sWORKER_CD + Global.COLUMNS_DIV;     //작업자

                strData += "" + Global.COLUMNS_DIV;             //비가동번호 반환
                strData += "" + Global.Separation.COLUMNS;      //RTN MSG 반환


                //OUTPUT변수 리스트 
                //strData += "@RESULT_NO" + Global.COLUMNS_DIV;
                //strData += "@RTN_MSG";
                strData += TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //OUTPUT변수 리스트 형식
                //strData += Global.DBVarType.VarChar + "(20)" + Global.COLUMNS_DIV;
                //strData += Global.DBVarType.VarChar + "(200)";
                strData += Global.Separation.COLUMNS;
                //OUTPUT변수값 리스트
                //strData += "" + Global.COLUMNS_DIV;
                strData += ""; // +TGSClass.nsGlobal.Global.Separation.COLUMNS;


                //string strState = TGSClass.DataBase.ExcuteSql(MainForm, strData, Global.workinfo.szServerIP, Global.workinfo.szPortNo); //반환테이블이 없을 경우
                DataTable dtData1 = new DataTable();
                int nCnt = 0;

                string strState = TGSClass.DataBase.GetDataSqlProcedur(MainForm, strData, ref dtData1, ref nCnt); //TGS Class 사용
                //string strState = TGSClass.DataBase.GetDataSql(MainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);//반환테이블이있을 경우



                if (!strState.Equals("OK"))
                {
                    //TGSControl.UsrFunction.MessageBoxErr("저장중 오류가 발생하였습다.", "비가동종료");
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "파라메터 비가동종료");
                    return;
                }
                //비가동 종료 문자메시지 전송
                ShowSendMessage(ctL_P0401C21.UnworkNo, "CL", ctL_P0401C21.sLOP_CD, ctL_P0401C21.sMOP_CD, ctL_P0401C21.sOP_CD);


                DBQuery_WorkStop_RetriveData();

                FuncWorkStopEnd();

            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "비가동종료");
            }
            finally
            {
                LoadingForm(false);
            }
        }




        //행의 첫 시작 위치를 선택할 때 row위치가 visible = false 이면 오류 발생함으로 visible 여부를 체크 함
        private int GetFirstRowIndex(int pRowIndex)
        {
            int i = 0;

            for (i = pRowIndex; i < Grid1.Rows.Count; i++)
            {
                if (Grid1.Rows[i].Visible == true)
                {
                    break;
                }
            }

            return i;
        }
        private void btn_Before_ButtonClick(object sender, EventArgs e)//이전버튼
        {
            //if (sGrid_Current_id == 2)    //그리드 2가 활성화 상태이면 다음 버튼을 누르면 그리드2의 페이지가 변경됨
            //{
            //    int vDisplayedRowCount = Grid2.DisplayedRowCount(false);
            //    if (vDisplayedRowCount > 0)
            //    {
            //        int vFirstDisplayedScrollingRowIndex = Grid2.FirstDisplayedScrollingRowIndex - vDisplayedRowCount;

            //        if (vFirstDisplayedScrollingRowIndex < 0)
            //            Grid2.FirstDisplayedScrollingRowIndex = 0;
            //        else
            //            Grid2.FirstDisplayedScrollingRowIndex = Grid2.FirstDisplayedScrollingRowIndex - vDisplayedRowCount;
            //    }
            //}
            //else
            //{
            //}
            if (sGrid_Current_id == 1)
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
            if (sGrid_Current_id == 2)
            {
                int vDisplayedRowCount = Grid2.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid2.FirstDisplayedScrollingRowIndex - vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex <= 0)
                        Grid2.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(0);
                    else
                        Grid2.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid2.FirstDisplayedScrollingRowIndex - vDisplayedRowCount);
                }
            }
            if (sGrid_Current_id == 3)
            {
                int vDisplayedRowCount = Grid3.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid3.FirstDisplayedScrollingRowIndex - vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex <= 0)
                        Grid3.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(0);
                    else
                        Grid3.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid3.FirstDisplayedScrollingRowIndex - vDisplayedRowCount);
                }
            }

        }
        private void btn_Next_ButtonClick(object sender, EventArgs e)//다음버튼
        {
            //if (sGrid_Current_id == 2)    //그리드 2가 활성화 상태이면 다음 버튼을 누르면 그리드2의 페이지가 변경됨
            //{
            //    int vDisplayedRowCount = Grid2.DisplayedRowCount(false);
            //    if (vDisplayedRowCount > 0)
            //    {
            //        int vFirstDisplayedScrollingRowIndex = Grid2.FirstDisplayedScrollingRowIndex + vDisplayedRowCount;

            //        if (vFirstDisplayedScrollingRowIndex >= Grid2.Rows.Count)
            //            Grid2.FirstDisplayedScrollingRowIndex = Grid2.Rows.Count - 1;
            //        else
            //            Grid2.FirstDisplayedScrollingRowIndex = vFirstDisplayedScrollingRowIndex;
            //    }
            //}
            //else
            //{
            //}
            if (sGrid_Current_id == 1)
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
            if (sGrid_Current_id == 2)
            {
                int vDisplayedRowCount = Grid2.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid2.FirstDisplayedScrollingRowIndex + vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex >= Grid2.Rows.Count)
                        Grid2.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid2.Rows.Count - 1);
                    else
                        Grid2.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(vFirstDisplayedScrollingRowIndex);
                }
            }
            if (sGrid_Current_id == 3)
            {
                int vDisplayedRowCount = Grid3.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid3.FirstDisplayedScrollingRowIndex + vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex >= Grid3.Rows.Count)
                        Grid3.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid3.Rows.Count - 1);
                    else
                        Grid3.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(vFirstDisplayedScrollingRowIndex);
                }
            }
        }

        private void Grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Grid1.CurrentRow.Cells[grid1_COLUMN.UNWORK_START_DT].Value.ToString() != "" && Grid1.CurrentRow.Cells[grid1_COLUMN.UNWORK_END_DT].Value.ToString() == "")
                {
                    btn_End.Enabled = true;
                    btn_Cancel.Enabled = true;
                    btn_ING.Enabled = true;
                }
                else
                {
                    btn_End.Enabled = false;
                    btn_ING.Enabled = false;
                    btn_Cancel.Enabled = false;
                }
                if (e.RowIndex >= 0)
                {
                    btn_Edit.Enabled = true;
                }
                else
                {
                    btn_Edit.Enabled = false;
                }
            }
            //이력보기 버튼.
            string vColName = Grid1.Columns[e.ColumnIndex].Name;

            if (vColName.Equals(grid1_COLUMN.SMS_LIST))
            {
                GetSMS_Infomation(Grid1.CurrentRow.Cells[grid1_COLUMN.UNWORK_NO].Value.ToString());
            }

        }

        private void Grid3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btn_Start.Visible == true)
            {
                if (Grid3.CurrentRow != null)
                {
                    btn_Start.Enabled = true;
                }
                else
                {
                    btn_Start.Enabled = false;
                }
            }
        }


        public void UnworkPanel_View(bool pFlag)
        {
            tableLayoutPanel1.ResumeLayout();
            if (pFlag)
            {

                tableLayoutPanel1.RowStyles[0].SizeType = SizeType.Absolute;
                tableLayoutPanel1.RowStyles[0].Height = 28;
                tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Percent;
                tableLayoutPanel1.RowStyles[1].Height = 50;
                tableLayoutPanel1.RowStyles[2].SizeType = SizeType.Absolute;
                tableLayoutPanel1.RowStyles[2].Height = 28;
                tableLayoutPanel1.RowStyles[3].SizeType = SizeType.Absolute;
                tableLayoutPanel1.RowStyles[3].Height = 60;
                tableLayoutPanel1.RowStyles[4].SizeType = SizeType.Percent;
                tableLayoutPanel1.RowStyles[4].Height = 0;
                tableLayoutPanel1.RowStyles[5].SizeType = SizeType.Percent;
                tableLayoutPanel1.RowStyles[5].Height = 50;
                Panel_UNWORK.Visible = true;
            }
            else
            {
                ctL_P0401C21.OP_NM = "";
                Panel_UNWORK.Visible = false;
                tableLayoutPanel1.RowStyles[0].SizeType = SizeType.Absolute;
                tableLayoutPanel1.RowStyles[0].Height = 28;
                tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Percent;
                tableLayoutPanel1.RowStyles[1].Height = 50;
                tableLayoutPanel1.RowStyles[2].SizeType = SizeType.Absolute;
                tableLayoutPanel1.RowStyles[2].Height = 28;
                tableLayoutPanel1.RowStyles[3].SizeType = SizeType.Absolute;
                tableLayoutPanel1.RowStyles[3].Height = 60;
                tableLayoutPanel1.RowStyles[4].SizeType = SizeType.Percent;
                tableLayoutPanel1.RowStyles[4].Height = 50;
                tableLayoutPanel1.RowStyles[5].SizeType = SizeType.Percent;
                tableLayoutPanel1.RowStyles[5].Height = 0;

            }
            tableLayoutPanel1.ResumeLayout();
            Application.DoEvents();
        }

        private void cboWorker_SelectedValueChanged(object sender, EventArgs e)
        {
            sWORKER_CD = cboWorker.Value;
        }

        private void btn_Edit_ButtonClick(object sender, EventArgs e) //비가동 수정
        {
            if (Grid1.CurrentRow == null) return;

            POP_P9001PA3 myForm = new POP_P9001PA3();

            //파라메터를 설정한다.

            DataTable dt = new DataTable("PassData");
            dt.Columns.Add("PLANT_CD");
            dt.Columns.Add("WC_MGR");
            dt.Columns.Add("FACILITY_CD");
            dt.Columns.Add("UNWORK_NO");
            dt.Columns.Add("OP_CD");
            dt.Columns.Add("L_OP_CD");
            dt.Columns.Add("M_OP_CD");
            dt.Columns.Add("OP_NM");
            dt.Columns.Add("OP_GRP_NM");
            dt.Columns.Add("WORKER_CD");


            dt.Rows.Add();

            dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
            dt.Rows[0]["WC_MGR"] = sWC_MGR;
            dt.Rows[0]["FACILITY_CD"] = sFACILITY_CD;
            string vUNWORK_NO = Grid1.CurrentRow.Cells[grid1_COLUMN.UNWORK_NO].Value.ToString();
            dt.Rows[0]["UNWORK_NO"] = vUNWORK_NO;
            dt.Rows[0]["OP_CD"] = Grid1.CurrentRow.Cells[grid1_COLUMN.OP_CD].Value.ToString();
            dt.Rows[0]["L_OP_CD"] = "";
            dt.Rows[0]["M_OP_CD"] = "";
            dt.Rows[0]["OP_NM"] = "";
            dt.Rows[0]["OP_GRP_NM"] = "";
            dt.Rows[0]["WORKER_CD"] = sWORKER_CD;


            myForm.ResultData.Tables.Add(dt); //변수전달


            myForm.MainForm = this.MainForm;


            myForm.Caption = "비가동 수정";
            myForm.Start(); //시작함수를 실행한다.


            myForm.ShowDialog(); //화면에 표시

            if (myForm.DialogResult == DialogResult.OK)
            {
                string vOP_CD = myForm.ResultData.Tables["Result"].Rows[0]["OP_CD"].ToString();
                string vWORKER_CD = myForm.ResultData.Tables["Result"].Rows[0]["WORKER_CD"].ToString();
                string vUNWORK_START_DT = myForm.ResultData.Tables["Result"].Rows[0]["UNWORK_START_DT"].ToString();
                string vUNWORK_END_DT = myForm.ResultData.Tables["Result"].Rows[0]["UNWORK_END_DT"].ToString();

                if (vUNWORK_END_DT == "") vUNWORK_END_DT = "NULL";

                ////신규 비가동을 수정한다.
                DBSave_UNWORK_UPDATE(vUNWORK_NO, vOP_CD, vWORKER_CD, vUNWORK_START_DT, vUNWORK_END_DT);
                //DBSave_UNWORK_START(vOP_CD, vWORKER_CD);

            }

            DBQuery();//비가동 내역을 다시 조회
        }

        private void Grid1_Enter(object sender, EventArgs e)
        {
            sGrid_Current_id = 1;
        }

        private void Grid2_Enter(object sender, EventArgs e)
        {
            sGrid_Current_id = 2;
        }

        private void Grid3_Enter(object sender, EventArgs e)
        {
            sGrid_Current_id = 3;
        }

        private void tButton1_ButtonClick(object sender, EventArgs e)
        {
            //비가동 점검 메세지를 보낸다.
            ShowSendMessage(ctL_P0401C21.UnworkNo, "ING", ctL_P0401C21.sLOP_CD, ctL_P0401C21.sMOP_CD, ctL_P0401C21.sOP_CD);
        }

        private void btnResend_ButtonClick(object sender, EventArgs e)
        {
            if (DBQuery_Count_Unwork_Basic_Message(ctL_P0401C21.sLOP_CD, ctL_P0401C21.sMOP_CD, ctL_P0401C21.sOP_CD) == 0)
            {
                TGSControl.UsrFunction.MessageBoxErr("등록된 비가동에 대한 기본 정보가 없습니다.", "SMS 발송");
                return;
            }

            //전에 발송 여부 체크
            string SQL = @"SELECT MSG_EVENT_ID FROM ZZ_Z_SMS_EVENT_HEADER WHERE REF_CD = '" + ctL_P0401C21.UnworkNo + "'";
            DataTable dtData1 = new DataTable();
            int nCnt = 0;
            string strState = TGSClass.DataBase.GetDataSql(sMainForm, SQL, ref dtData1, ref nCnt);

            if (!strState.Equals("OK"))
            {
                TGSControl.UsrFunction.MessageBoxErr(strState, "SMS 발송");
                return;
            }
            else
            {
                if (dtData1.Rows.Count > 0)
                {
                    TGSControl.UsrFunction.MessageBoxErr("이미 메세지를 발송했습니다.", "SMS 발송");
                    return;
                }
                ShowSendMessage(ctL_P0401C21.UnworkNo, "ST", ctL_P0401C21.sLOP_CD, ctL_P0401C21.sMOP_CD, ctL_P0401C21.sOP_CD);
            }
        }

        private void Grid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //GetSMS_Infomation(Grid1.CurrentRow.Cells[grid1_COLUMN.UNWORK_NO].Value.ToString());
        }

        public void GetSMS_Infomation(string pUnworkCD)
        {
            try
            {
                //임시주석
                //POP_SMS_HISTORY myForm = new POP_SMS_HISTORY(pUnworkCD);

                ////파라메터를 설정한다.

                //myForm.MainForm = this.MainForm;
                //myForm.Start(); //시작함수를 실행한다.

                //myForm.ShowDialog(); //화면에 표시
            }
            catch (Exception ex) { }
        }

        private void Grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnSMS_ButtonClick(object sender, EventArgs e)
        {
            string vLOP_CD = string.Empty;
            string vMOP_CD = string.Empty;
            string vOP_CD = string.Empty;

            if (Grid2.CurrentRow != null)
            {
                vLOP_CD = Grid2.CurrentRow.Cells[grid2_COLUMN.L_OP_CD].Value.ToString();
                vMOP_CD = Grid2.CurrentRow.Cells[grid2_COLUMN.M_OP_CD].Value.ToString();
            }
            if (Grid3.CurrentRow != null)
            {
                vOP_CD = Grid3.CurrentRow.Cells[grid3_COLUMN.OP_CD].Value.ToString();
            }

            ShowSendMessage(string.Empty, "NT", vLOP_CD, vMOP_CD, vOP_CD);


        }
    }
}
