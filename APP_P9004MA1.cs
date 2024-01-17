using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;

using TGSClass;
using TGSClass.nsGlobal;
using TGSClass.nsWorkCode;


namespace MES_APP_P90
{


    

    public partial class APP_P9004MA1 : UserControl
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
            public const string WORKER_CD = "WORKER_CD";
            public const string WK_ORD_NO = "WK_ORD_NO";
            
        }
        public struct SetValueName
        {
            public const string UNIT_CD = "UNIT_CD";
            public const string PLANT_CD = "PLANT_CD";
            public const string FACILITY_CD = "FACILITY_CD";
            public const string WC_CD = "WC_CD";
            public const string WC_NM = "WC_NM";
            public const string WC_MGR = "WC_MGR";
            public const string WORKER_CD = "WORKER_CD";

            public const string RESULT_USER_FLAG = "RESULT_USER_FLAG";    //사용자 일자 사용여부
            public const string RESULT_USER_DT = "RESULT_USER_DT";    //사용자 일자

        }

        public struct grid1_COLUMN
        {
            public const string CHECKFLAG = "CHKFLAG";
            public const string SEQ = "SEQ";
            public const string WK_DT = "WK_DT";
            public const string SHIFT_NM = "SHIFT_NM";
            public const string PRODT_ORDER_NO = "PRODT_ORDER_NO";
            public const string OPR_NO = "OPR_NO";
            public const string WK_ORD_NO = "WK_ORD_NO";
            public const string ITEM_CD = "ITEM_CD";
            public const string ITEM_NM = "ITEM_NM";
            public const string WK_ORD_QTY = "WK_ORD_QTY";
            public const string PROD_QTY = "PROD_QTY";
            public const string EMP_DESC = "EMP_DESC";
            public const string STATUS = "STATUS";
            public const string REAL_START_TM = "REAL_START_TM";
            public const string REAL_END_TM = "REAL_END_TM";
            public const string WK_FACILITY_NM = "WK_FACILITY_NM";
            public const string WK_ORD_UNIT = "WK_ORD_UNIT";

            public const string REQ_A_QTY = "REQ_A_QTY";    //성형주간작업계획량
            public const string REQ_B_QTY = "REQ_B_QTY";    //성형야간작업계획량
            public const string REQ_1H_QTY = "REQ_1H_QTY";
            public const string REQ_2H_QTY = "REQ_2H_QTY";
            public const string REQ_4H_QTY = "REQ_4H_QTY";
            public const string REQ_4H_OVER_QTY = "REQ_4H_OVER_QTY";

            public const string PLAN_START_DT = "PLAN_START_DT";
            public const string CAST_CHANGE = "CAST_CHANGE";

            public const string RESULT_FLAG = "RESULT_FLAG";

            public const string BEFORE_WORK_FLAG = "BEFORE_WORK_FLAG";
        }


        #endregion

        #region ■ 1.3. Class global variables (common) //글로벌 변수 선언

        Global global = new Global();
        Form sMainForm;

        DataSet sResultData = new DataSet();

        string sUNIT_CD = "";       //단말기 ID
        string sPLANT_CD = "";      //공장
        string sWC_MGR = "";        //대공정
        string sWC_CD = "";         //작업장
        string sFACILITY_CD = "";   //설비번호
        string sWC_NM = "";
        string sWORKER_CD = "";
        
        string sITEM_CD = "";

        bool sRESULT_USER_FLAG = false;    //사용자 소급실적등록 여부
        string sRESULT_USER_DT = "";   //사용자 소급 실적일자

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

        #region ■ 2.1 Constructor(common)      //등록자

        public APP_P9004MA1()
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

                    }
                }
            }
                   
        }
        public void CommandRun(string CommandString)
        {
            CommandString.Split(TGSClass.nsGlobal.Global.Separation.COLUMNS); 
            DataSet vSendData = new DataSet();

            vSendData.Tables.Add("COMMAND");
            vSendData.Tables["COMMAND"].Rows.Add("DBQUERY");

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
        //내부에서 명령을 등록해준후 명령이벤트를 실행한다.
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

                switch (sWC_MGR)
                {
                    case "10":
                        vSendData.Tables["COMMAND"].Rows.Add("APP_RUN", "MES_APP_P00.APP_P1003M1", "", "", "");
                        break;
                    case "20":
                        vSendData.Tables["COMMAND"].Rows.Add("APP_RUN", "MES_APP_P50.APP_P5001M1", "", "", "");
                        break;
                    case "30":
                        if (sRESULT_USER_FLAG)  //예외실적 처리 일 경우
                        {
                            vSendData.Tables["COMMAND"].Rows.Add("APP_RUN", "MES_APP_P00.APP_P1003M1", "", "", "");
                        }
                        else
                        {
                            vSendData.Tables["COMMAND"].Rows.Add("APP_RUN", "MES_APP_P30.APP_P3001M1", "", "", "");
                        }
                        break;
                    case "40":
                        vSendData.Tables["COMMAND"].Rows.Add("APP_RUN", "MES_APP_P50.APP_P5001M1", "", "", "");
                        break;
                    case "50":
                        vSendData.Tables["COMMAND"].Rows.Add("APP_RUN", "MES_APP_P50.APP_P5001M1", "", "", "");
                        break;
                }
                       


                vSendData.Tables.Add("PassData");

                vSendData.Tables["PassData"].Columns.Add("PLANT_CD");
                vSendData.Tables["PassData"].Columns.Add("WC_MGR");
                vSendData.Tables["PassData"].Columns.Add("WC_CD");
                vSendData.Tables["PassData"].Columns.Add("FACILITY_CD");
                vSendData.Tables["PassData"].Columns.Add("WORKER_CD");


                vSendData.Tables["PassData"].Rows.Add();

                vSendData.Tables["PassData"].Rows[0]["PLANT_CD"] = sPLANT_CD;
                vSendData.Tables["PassData"].Rows[0]["WC_MGR"] = sWC_MGR;
                vSendData.Tables["PassData"].Rows[0]["WC_CD"] = sWC_CD;
                vSendData.Tables["PassData"].Rows[0]["FACILITY_CD"] = cboFacility.Value;
                //vSendData.Tables["PassData"].Rows[0]["WORKER_CD"] = cboWorker.Value;
            }

            CommandRun_Event(vSendData);  //이벤트 실행
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
                            Grid1.Rows[0].Cells[grid1_COLUMN.ITEM_CD].Selected = true;
                        }
                    }

                    if (Grid1.CurrentRow != null)
                        return Grid1.CurrentRow.Cells[grid1_COLUMN.ITEM_CD].Value.ToString();
                    else
                        return "";
                case GetValueName.WORKER_CD:

                    return sWORKER_CD;
                case GetValueName.WK_ORD_NO:
                    if (Grid1.CurrentRow == null)
                    {
                        if (Grid1.Rows.Count > 0)
                        {
                            int vFirstRowIndex = GetFirstRowIndex(Grid1, 0);
                            if (vFirstRowIndex >= 0)
                            {
                                Grid1.Rows[vFirstRowIndex].Cells[grid1_COLUMN.WK_ORD_NO].Selected = true;
                            }
                        }
                    }

                    if (Grid1.CurrentRow != null)
                        return Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString();
                    else
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
                case SetValueName.WC_CD:

                    sWC_CD = pValue;
                    break;
                case SetValueName.WC_NM:

                    sWC_NM = pValue;
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

                case SetValueName.RESULT_USER_FLAG: //사용자 소급실적여부
                    if (pValue.ToUpper() == "Y")
                    {
                        sRESULT_USER_FLAG = true;
                    }
                    else
                    {
                        sRESULT_USER_FLAG = false;
                    }
                    break;
                case SetValueName.RESULT_USER_DT:   //사용자 소급실적일자
                    if (pValue != "")
                    {
                        sRESULT_USER_DT = pValue;
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

            if (sPLANT_CD == "") sPLANT_CD  = Global.workinfo.szFactoryCD;
            if (sFACILITY_CD == "") sFACILITY_CD = Global.workinfo.szFacilityCD;
            if (sWC_CD == "") sWC_CD = Global.workinfo.szWorkSpaceCD;
            if (sWC_MGR == "") sWC_MGR = Global.workinfo.szProcessCD;
            if (sWC_NM == "") sWC_NM = Global.workinfo.szWorkSpaceNM;
            if (sWORKER_CD == "") sWORKER_CD = Global.workinfo.szOperatorCD;


            

        }

        #endregion

        #region ■ 2.5 Gathering combo data(GatheringComboData) //콤보관련 데이타 설정

        protected void GatheringComboData()
        {
            if (Global.workinfo.szServerIP == "") return;

            Load_Operator();  //작업자정보조회

            Load_Facility();    //설비 정보를 조회한다.

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


            //DataSet iDataSet = new DataSet();
            DataTable dtData1 = null;
            dtData1 = new DataTable();

            string strSql = "";

            switch (@FLAG)
            {
                //case "S0018":    // 판내계획유형..
                //    strSql = " SELECT DISTINCT UPPER(RTRIM(AA.code))  AS code, RTRIM(AA.name) AS name ";
                //    strSql += " FROM ( ";
                //    strSql += " SELECT	CASE WHEN A.SEQ_NO = 1 THEN 'E' ELSE 'M' END  AS code  ";
                //    strSql += "              , CASE WHEN A.SEQ_NO = 1 THEN '실행계획' ELSE '경영계획' END +'('+ B.MINOR_NM + ')'  AS name   ";
                //    strSql += " FROM	B_CONFIGURATION AS A (NOLOCK) ";
                //    strSql += " 		        JOIN B_MINOR AS B (NOLOCK) ON A.MAJOR_CD = B.MAJOR_CD AND A.MINOR_CD = B.MINOR_CD";
                //    strSql += " WHERE A.MAJOR_CD = 'S0018'   ) AA ";
                //    break;
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
                //string strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, strSql, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);

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
                combo.ValueMember = "code";
                combo.DisplayMember = "name";
                combo.DisplayCaption = p_DisplayCaption;
                combo.ValueCaption = p_ValueCaption;
                combo.Caption = p_Caption;

                //combo.DataBind();

                combo.SelectedIndex = idx;
            }
        }
        #endregion ▶▶▶ 공용코드 콤보 셋팅
        
        #region ▶▶▶ 작업자정보 조회
        private int Load_Operator()
        {
            string strSql = string.Empty;
            int nCnt = 0;

            //try
            //{
            //    LoadingForm(true);

            //    DataTable dtTmp = (DataTable)cboWorker.DataSource;
            //    if (dtTmp != null)
            //        dtTmp.Clear();

            //    // 작업자정보 가져오기
            //    //szSendData = "";
            //    //szSendData = WorkCode.WorkCd.OPERTOR;
            //    //szSendData += Global.workinfo.szFactoryCD + nsWinUtilGlobal.Global.Separation.COLUMNS;
            //    //szSendData += Global.workinfo.szProcessCD;

            //    //SP로 쿼리 변경 22016-06-30 이동환
            //    strSql = " EXEC dbo.XUSP_MESSVR_CM_OPERTOR_GET "
            //          + " @PLANT_CD = '" + sPLANT_CD + "'"        //공장
            //          + ",@WC_MGR = '" + sWC_MGR + "'";        //공정


            //    DataTable dtData1 = null;
            //    dtData1 = new DataTable();


            //    string strState = "";

            //    if (Global.szDBConnectStr != "")
            //    {
            //        DataSet dsTmp = new DataSet();
            //        TGSClass.DataBase vDB = new DataBase(Global.szDBConnectStr);

            //        vDB.DBOpen();

            //        if (vDB.QueryOpen(strSql, ref dsTmp))
            //        {
            //            dtData1 = dsTmp.Tables[0];
            //            strState = "OK";
            //        }
            //        else
            //        {
            //            strState = "99" + vDB.szErrMgs.ToString();
            //        }
            //        vDB.DBClose();

            //    }
            //    else
            //    {
            //        strSql = WorkCode.WorkCd.SQLQUERY + strSql;
            //        strState = TGSClass.DataBase.GetDataSql(sMainForm, strSql, ref dtData1, ref nCnt);
            //    }

            //    //string strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, szSendData, ref dtData1, ref nCnt,
            //    //    Global.workinfo.szServerIP,
            //    //    Global.workinfo.szPortNo);

            //    if (!strState.Equals("OK"))
            //    {
            //        TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "작업자조회" + "(" + this.AccessibleName.ToString() + ")" );
            //        return -1;
            //    }

            //   // cboWorker.Caption = "";

            //    if (dtData1 != null && dtData1.Rows.Count > 0)
            //    {
            //        //this.cboWPOperator.DataMode = WinControl.SSMComboBox.DataModeEnum.Normal;
            //        //this.cboWorker.DataSource = dtData1;
            //        //this.cboWorker.DisplayMember = "EMP_DESC";
            //        //this.cboWorker.ValueMember = "USER_ID";
            //        //this.cboWorker.DisplayCaption = "작업자명";
            //        //this.cboWorker.ValueCaption = "작업자ID";
            //        //this.cboWorker.Caption = "작업자 선택";


            //        //// 최종 작업자정보 가져오기
            //        //szSendData = "";
            //        //szSendData = WorkCode.WorkCd.LAST_OPERTOR;
            //        //szSendData += Global.workinfo.szFacilityCD;

            //        dtData1 = null;
            //        dtData1 = new DataTable();

            //        strSql = ""
            //                   + "SELECT TOP 1 WORKER_ID"
            //                   + " FROM MES_P_WORK_RESULT AS A (NOLOCK) "
            //                   + " WHERE A.PLANT_CD = '" + sPLANT_CD + "'"
            //                   + "   AND A.FACILITY_CD = '" + sFACILITY_CD + "'"    //--설비번호
            //                   + "   AND A.REAL_END_DT IS NULL"
            //                   + " ORDER BY WK_DT DESC";


            //        strState = "";

            //        if (Global.szDBConnectStr != "")
            //        {
            //            DataSet dsTmp = new DataSet();
            //            TGSClass.DataBase vDB = new DataBase(Global.szDBConnectStr);

            //            vDB.DBOpen();

            //            if (vDB.QueryOpen(strSql, ref dsTmp))
            //            {
            //                dtData1 = dsTmp.Tables[0];
            //                strState = "OK";
            //            }
            //            else
            //            {
            //                strState = "99" + vDB.szErrMgs.ToString();
            //            }
            //            vDB.DBClose();

            //        }
            //        else
            //        {
            //            strSql = WorkCode.WorkCd.SQLQUERY + strSql;
            //            strState = TGSClass.DataBase.GetDataSql(sMainForm, strSql, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
            //        }

            //        //strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, szSendData, ref dtData1, ref nCnt,
            //        //    Global.workinfo.szServerIP,
            //        //    Global.workinfo.szPortNo);

            //        if (strState.Equals("OK"))
            //        {
            //            if (dtData1 != null && dtData1.Rows.Count > 0)
            //            {
            //                //this.cboWorker.Value = dtData1.Rows[0][0].ToString();//기본값 설정
            //            }
            //        }

            //        //if (cboWorker.SelectedIndex > -1)
            //        //{

            //        //    Global.workinfo.szOperatorCD = cboWorker.Value;
            //        //    Global.workinfo.szOperatorNM = cboWorker.ValueName;
            //        //}
            //        //else
            //        //{
            //        //    Global.workinfo.szOperatorCD = "";
            //        //    Global.workinfo.szOperatorNM = "";
            //        //}

            //        return 0;
            //    }
            //}
            //catch (Exception se)
            //{
            //    TGSControl.UsrFunction.MessageBoxErr(se.Message  + "(" + this.ToString() + ")", "작업자조회"  );
            //}
            //finally
            //{
            //    LoadingForm(false);
            //}
            return -1;

        }
        #endregion ▶▶▶ 작업자정보 조회

        #region ▶▶▶ 설비정보 조회
        //설비정보를 가져온다.
        private int Load_Facility()
        {
            string strSql = string.Empty;
            int nCnt = 0;

            try
            {
                //if (Global.workinfo.szProcessCD == "") return -1;


                LoadingForm(true);

                DataTable dtTmp = (DataTable)cboFacility.DataSource;
                if (dtTmp != null) dtTmp.Clear();

                // 작업장정보 가져오기
                strSql = "";
                //strSql = WorkCode.WorkCd.FACILITY;
                //strSql += sPLANT_CD + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //strSql += sWC_MGR + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //strSql += sWC_CD + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //strSql += "";  //Mixing의 JobCode자리

                strSql = "EXEC DBO.XUSP_MESSVR_GET_FACILITY "
                            + " @PLANT_CD='" + sPLANT_CD + "',"
                            + " @WC_MGR='" + sWC_MGR + "',"
                            + " @WC_CD='" + sWC_CD + "',"
                            + " @JOB_CD='" + "" + "'";  //Mixing의 JobCode자리


                DataTable dtData1 = null;
                dtData1 = new DataTable();


                string strState = "";

                if (Global.szDBConnectStr != "")
                {
                    DataSet dsTmp = new DataSet();
                    TGSClass.DataBase vDB = new DataBase(Global.szDBConnectStr);

                    vDB.DBOpen();

                    if (vDB.QueryOpen(strSql, ref dsTmp))
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
                    strSql = WorkCode.WorkCd.SQLQUERY + strSql;
                    strState = TGSClass.DataBase.GetDataSql(sMainForm, strSql, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                }

                //string strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, szSendData, ref dtData1, ref nCnt,
                //    Global.workinfo.szServerIP,
                //    Global.workinfo.szPortNo);

                if (!strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "설비정보 조회");
                    return -1;
                }

                cboFacility.Caption = "";

                if (dtData1 != null && dtData1.Rows.Count > 0)
                {
                    //this.cboWorkPlace.DataMode = WinControl.SSMComboBox.DataModeEnum.Normal;
                    this.cboFacility.DataSource = dtData1;
                    this.cboFacility.DisplayMember = "FACILITY_NM";
                    this.cboFacility.ValueMember = "FACILITY_CD";
                    this.cboFacility.DisplayCaption = "설비명";
                    this.cboFacility.ValueCaption = "설비코드";
                    this.cboFacility.Caption = "설비정보조회";

                    cboFacility.SelectedIndex = 0;
                    if (Global.workinfo.szFacilityCD != "")
                        cboFacility.Value = Global.workinfo.szFacilityCD;

                    Global.workinfo.szFacilityCD = cboFacility.Value;
                    Global.workinfo.szFacilityNM = cboFacility.ValueName;

                    LoadingForm(false);
                    return 0;
                }
            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "설비조회");
            }
            finally
            {
                LoadingForm(false);
            }
            return -1;


        }
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

        //        string strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, szSendData, ref dtData1, ref nCnt,
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
            InitSpreadSheet(1);
        }

        private void InitSpreadSheet(int p_GridIndex)   //선택된 스프레드시트를 초기화 한다.
        {


            if (p_GridIndex == 1)
            {

                #region ■■ 3.1.1 Pre-setting grid information

                
                /*** grid1
                 *  실적조회
                 * **/
                Grid1.Columns.Clear();

                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("맑은 고딕", 11, FontStyle.Bold);
                Grid1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                Grid1.RowHeadersVisible = false;

                Grid1.Columns.Add(SetColumnEdit("ITEM_NM", "품번", 150));
                Grid1.Columns.Add(SetColumnEdit("PLAN_QTY", "총계획량", 100));
                Grid1.Columns.Add(SetColumnEdit("ORDER_QTY", "미발행량", 100));
                Grid1.Columns.Add(SetColumnEdit("BAD_QTY", "불량", 100));
                Grid1.Columns.Add(SetColumnEdit("PLAN_START", "계획시작", 150));
                Grid1.Columns.Add(SetColumnEdit("PLAN_END", "계획종료", 150));
                Grid1.Columns.Add(SetColumnEdit("DT", "착수시각", 100));
                Grid1.Columns.Add(SetColumnEdit("AUTO", "자동", 80));
                Grid1.Columns.Add(SetColumnEdit("INFO", "정보", 150));

                //Grid1.Columns.Add(SetColumnImage(grid1_COLUMN.CHECKFLAG, "√", 40));    //이미지형태의 그리드

                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.SEQ, "NO", 40));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.PRODT_ORDER_NO, "제조오더번호", 0));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.OPR_NO, "공순", 0));
                //if (sWC_MGR == "30")
                //{
                //    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.WK_DT, "계획시각", 100));
                //}
                //else
                //{
                //    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.WK_DT, "지시일", 60));
                //}
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.SHIFT_NM, "주/야", 58));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.WK_ORD_NO, "작업지시번호", 170));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.ITEM_CD, "품번", 130));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.ITEM_NM, "품명", 80));

                //if (sWC_MGR == "10")
                //{
                //    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.WK_ORD_QTY, "롯트량", 72));
                //}
                //else
                //{
                //    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.WK_ORD_QTY, "지시량", 72));
                //}

                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.PROD_QTY, "생산량", 72));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.REQ_A_QTY, "성형주간", 75)); 
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.REQ_B_QTY, "성형야간", 75)); 

                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.REQ_1H_QTY, "~1H투입", 65));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.REQ_2H_QTY, "~2H투입", 65));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.REQ_4H_QTY, "~4H투입", 65));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.REQ_4H_OVER_QTY, "4H~투입", 65));


                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.CAST_CHANGE, "구분", 80));



                //if (sWC_MGR == "10")
                //{
                //    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.EMP_DESC, "사용처", 65));
                //    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.STATUS, "상태", 80));
                //    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.WK_FACILITY_NM, "작업설비", 60));
                //}
                //else
                //{
                //    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.EMP_DESC, "작업자", 65));
                //    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.STATUS, "상태", 90));
                //    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.WK_FACILITY_NM, "작업설비", 90));                    
                //}



                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.REAL_START_TM, "시작시각", 0));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.REAL_END_TM, "종료시각", 0));


                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.BEFORE_WORK_FLAG, "전공정실적", 0));


                #endregion


                #region ■■ 3.1.2 Formatting grid information

                //uniGrid2.flagInformation("cud_flag", "rownum");
                //uniGrid2.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.No);

                //Grid1.Columns[grid1_COLUMN.WK_DT].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //Grid1.Columns[grid1_COLUMN.WK_ORD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.PROD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                //Grid1.Columns[grid1_COLUMN.REQ_A_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.REQ_B_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                //Grid1.Columns[grid1_COLUMN.REQ_1H_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.REQ_2H_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.REQ_4H_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.REQ_4H_OVER_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                //Grid1.Columns[grid1_COLUMN.WK_ORD_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태
                //Grid1.Columns[grid1_COLUMN.PROD_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태

                //Grid1.Columns[grid1_COLUMN.REQ_A_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                //Grid1.Columns[grid1_COLUMN.REQ_B_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태


                //Grid1.Columns[grid1_COLUMN.REQ_1H_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                //Grid1.Columns[grid1_COLUMN.REQ_2H_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                //Grid1.Columns[grid1_COLUMN.REQ_4H_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                //Grid1.Columns[grid1_COLUMN.REQ_4H_OVER_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태


                #endregion


                #region ■■ 3.1.3 Setting etc grid
                // Hidden Column Setting
                //Grid1.Columns[grid1_COLUMN.WK_ORD_NO].Visible = false;
                //Grid1.Columns[grid1_COLUMN.PRODT_ORDER_NO].Visible = false;
                //Grid1.Columns[grid1_COLUMN.OPR_NO].Visible = false;


                //Grid1.Columns[grid1_COLUMN.REAL_START_TM].Visible = false;
                //Grid1.Columns[grid1_COLUMN.REAL_END_TM].Visible = false;

                //Grid1.Columns[grid1_COLUMN.BEFORE_WORK_FLAG].Visible = false;


                //if (tCheckBox1.ValueChar == "N")
                //    Grid1.Columns[grid1_COLUMN.WK_FACILITY_NM].Visible = false;
                //else
                //    Grid1.Columns[grid1_COLUMN.WK_FACILITY_NM].Visible = true;

                //if (sWC_MGR == "10")
                //{
                //    Grid1.Columns[grid1_COLUMN.SHIFT_NM].Visible = false;
                //    //Grid1.Columns[grid1_COLUMN.WK_ORD_NO].Visible = false;
                //    Grid1.Columns[grid1_COLUMN.REQ_A_QTY].Visible = true;
                //    Grid1.Columns[grid1_COLUMN.REQ_B_QTY].Visible = true;
                //    Grid1.Columns[grid1_COLUMN.REQ_1H_QTY].Visible = true;
                //    Grid1.Columns[grid1_COLUMN.REQ_2H_QTY].Visible = true;
                //    Grid1.Columns[grid1_COLUMN.REQ_4H_QTY].Visible = true;
                //    Grid1.Columns[grid1_COLUMN.REQ_4H_OVER_QTY].Visible = true;

                //    Grid1.Columns[grid1_COLUMN.STATUS].Visible = false;
                //}
                //else
                //{
                //    Grid1.Columns[grid1_COLUMN.SHIFT_NM].Visible = true;
                //    //Grid1.Columns[grid1_COLUMN.WK_ORD_NO].Visible = true;
                //    Grid1.Columns[grid1_COLUMN.REQ_A_QTY].Visible = false;
                //    Grid1.Columns[grid1_COLUMN.REQ_B_QTY].Visible = false;
                //    Grid1.Columns[grid1_COLUMN.REQ_1H_QTY].Visible = false;
                //    Grid1.Columns[grid1_COLUMN.REQ_2H_QTY].Visible = false;
                //    Grid1.Columns[grid1_COLUMN.REQ_4H_QTY].Visible = false;
                //    Grid1.Columns[grid1_COLUMN.REQ_4H_OVER_QTY].Visible = false;

                //    Grid1.Columns[grid1_COLUMN.STATUS].Visible = true;
                //}

                //if (sWC_MGR == "30")
                //{
                //    Grid1.Columns[grid1_COLUMN.CAST_CHANGE].Visible = true;
                //}
                //else
                //{
                //    Grid1.Columns[grid1_COLUMN.CAST_CHANGE].Visible = false;

                //}
                //Grid1.Columns[grid1_COLUMN.EMP_DESC].DefaultCellStyle.ForeColor = Color.Blue;
                //Grid1.Columns[grid1_COLUMN.STATUS].DefaultCellStyle.ForeColor = Color.Blue;
                //Grid1.Columns[grid1_COLUMN.WK_FACILITY_NM].DefaultCellStyle.ForeColor = Color.Blue;

                //Grid1.Columns[grid1_COLUMN.EMP_DESC].DefaultCellStyle.SelectionForeColor = Color.Blue;
                //Grid1.Columns[grid1_COLUMN.STATUS].DefaultCellStyle.SelectionForeColor = Color.Blue;
                //Grid1.Columns[grid1_COLUMN.WK_FACILITY_NM].DefaultCellStyle.SelectionForeColor = Color.Blue;



                #endregion

                TGSClass.Util.Grid_Resize(Grid1);
            }
           

        }


        #endregion

        #region ■ 3.2 InitData

        public void InitData()
        {
            // TO-DO: 컨트롤을 초기화(또는 초기값)할때 할일 
            // SetDefaultVal과의 차이점은 전자는 Form_Load 시점에 콘트롤에 초기값을 세팅하는것이고
            // 후자는 특정 시점(조회후 또는 행추가후 등 특정이벤트)에서 초기값을 셋팅한다.

            //if (cboWorker.Value != sWORKER_CD)
            //{
            //    cboWorker.Value = sWORKER_CD; // Global.workinfo.szOperatorCD;
            //}


            if (cboFacility.Value != sFACILITY_CD)
            {
                
                //ProcessInform_Review(sFACILITY_CD, ref sWC_CD, ref sWC_NM, false);   //선택된 설비의 작업장 정보
                
                
                cboFacility.Value = sFACILITY_CD;

                if (cboFacility.SelectedIndex == -1)    //콤보에 해당 설비가 없을 경우 설비정보를 다시 조회 함
                {
                    Load_Facility();    //설비 정보를 조회한다.

                    cboFacility.Value = sFACILITY_CD;


                }

                //if (cboFacility.SelectedIndex >= 0)
                //{

                //    if (cboFacility.DataSource.Rows[cboFacility.SelectedIndex]["TYPE"].ToString() == "M")
                //    {
                //        btn_Unwork.Enabled = true;
                //        btn_DailyCheck.Enabled = true;
                //    }
                //    else
                //    {
                //        btn_Unwork.Enabled = false;
                //        btn_DailyCheck.Enabled = false;
                //    }
                //}
                //else
                //{
                //    btn_Unwork.Enabled = false;
                //    btn_DailyCheck.Enabled = false;
                //}

            }

            if (sFACILITY_CD != "")
            {
                ProcessInform_Review(sFACILITY_CD, ref sWC_CD, ref sWC_NM, false);   //선택된 설비의 작업장 정보
            }

            lbl_WorkCenterNm.Value = sWC_NM;

            //if (sWC_MGR == "30") //성형이면 설비선택 할수 없게
            //{
            //    //성형공정일 경우 착수내역도 보여주게 표시
            //    tCheckBox1.ValueChar = "Y";
            //    tCheckBox1_CheckedChange(null, null);
            
            //    cboFacility.Enabled = false;
            //    tCheckBox2.Visible = false;
            //}
            //else
            //{
            //    cboFacility.Enabled = true;
            //    tCheckBox2.Visible = true;
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

        //그리그 Edit 컬럼 등록
        private void SetColumnEdit(DataGridView pGrid, DataTable pDataTable, string ColumnName, string HeaderText, int Width, Type pType)
        {
            pGrid.Columns.Add(SetColumnEdit(ColumnName, HeaderText, Width));
            pDataTable.Columns.Add(ColumnName, pType);
        }
        private DataGridViewColumn SetColumnEdit(string ColumnName, string HeaderText, int Width)
        {
            DataGridViewColumn myCol = new DataGridViewColumn();

            //myCol.Name = ColumnName; myCol.HeaderText = HeaderText; myCol.Width = Width;
            myCol.Name = ColumnName; myCol.HeaderText = HeaderText; myCol.Width = Width;
            myCol.DataPropertyName = ColumnName;
            myCol.SortMode = DataGridViewColumnSortMode.Automatic;


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

        //그리드 Image 컬럼 등록
        private void SetColumnImage(DataGridView pGrid, DataTable pDataTable, string ColumnName, string HeaderText, int Width, Type pType)
        {
            pGrid.Columns.Add(SetColumnImage(ColumnName, HeaderText, Width));
            pDataTable.Columns.Add(ColumnName, pType);
        }
        private DataGridViewColumn SetColumnImage(string ColumnName, string HeaderText, int Width) //이미지컬럼을 등록한다.
        {
            DataGridViewImageColumn myCol = new DataGridViewImageColumn();


            myCol.Name = ColumnName; myCol.HeaderText = HeaderText; myCol.Width = Width;
            myCol.DataPropertyName = ColumnName;

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
            DBQuery_Work_Order_RetriveData();    //작업지시현황을 조회 

            //tCheckBox1_CheckedChange(null,null);

            //for (int i = 0; i < Grid1.Rows.Count; i++)
            //{
                
                //if (tCheckBox1.ValueChar == "N")
                //    Grid1.Rows[i].Visible = false;
                //else
                //    Grid1.Rows[i].Visible = true;
            //}

            //cboWorker.SelectedIndex = -1;   //작업자를 초기화 함
            //cboWorker.Value = "";   //작업자를 초기화 함
            //cboWorker.ValueName = "";   //작업자를 초기화 함
            //opn_ITEM_CD.Value = "";         //품번 필터를 초기화 함
            //opn_ITEM_CD.ValueName = "";     //품번 필터를 초기화 함

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

        #endregion

        #endregion

        #region 작업지시현황 정보 조회
        

        private void DBQuery_Work_Order_RetriveData()//작업지시현황을 조회 
        {
            int nCnt = 0;

            
            try
            {
                LoadingForm(true);


                
                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MES_P9001M1_GET @PLANT_CD='" + sPLANT_CD + "', "; //공장
                strData += "@WC_MGR='" + sWC_MGR + "',";        //대공정
                strData += "@WC_CD='" + sWC_CD + "',";          //작업장
                strData += "@FACILITY_CD ='" + sFACILITY_CD + "'";  //설비번호
                
                
                DataTable dtData1 = null;
                dtData1 = new DataTable();


                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);



                if (!strState.Equals("OK"))
                {
                    if (strState.Substring(2, 7) == "서버 연결오류")
                    {
                        TGSControl.UsrFunction.MessageBoxInfo(strState.Substring(2), "작업지시정보조회");
                    }
                    else if (strState.Substring(2, 7) == "서버 수신오류")
                    {
                        //nsUsrFunction.UsrFunction.MessageBoxInfo(strState.Substring(2), "성형 CYCLE 조회");
                    }
                    else if (strState.Substring(2, 13) == "(Exception 2)")
                    {
                        TGSControl.UsrFunction.MessageBoxInfo(strState.Substring(2), "작업지시정보 조회");
                    }
                     
                    else
                    {
                        TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "작업지시정보조회");
                    }
                    return;
                }
                //if (dtData1 == null || dtData1.Rows.Count <= 0)
                //{
                //    LoadingForm(false);
                //    nsUsrFunction.UsrFunction.MessageBoxErr("조회할 데이타가 존재하지 않습니다.", "조회");
                //    return;
                //}


                

                //Grid1.AutoGenerateColumns = false;
                //Grid1.DataSource = dtData1;

                
                //for (int i = 0; i < Grid1.Rows.Count; i++)
                //{
                //    imgChecked = Properties.Resources.CheckBoxUnChecked;
                //    imgChecked.Tag = "N";
                //    dtData1.Rows[i].Cells[grid1_COLUMN.CHECKFLAG].Value = imgChecked; //1.체크 


                //    if (Grid1.Rows[i].Cells[grid1_COLUMN.REAL_START_TM].ToString().Length > 0 &&
                //        Grid1.Rows[i].Cells[grid1_COLUMN.REAL_END_TM].ToString().Length == 0)
                //    {
                //        Grid1.Rows[i].Cells[grid1_COLUMN.STATUS].Value = "작업중"; //작업상태

                //        if (tCheckBox1.ValueChar == "N")
                //            Grid1.Rows[i].Visible = false;
                //        else
                //        {
                //            Grid1.Rows[i].Visible = true;
                //            j = j + 1;
                //        }
                //    }
                //    else
                //    {
                //        Grid1.Rows[i].Cells[grid1_COLUMN.STATUS].Value = ""; //작업상태
                //        Grid1.Rows[i].Visible = true;
                //        j = j + 1;
                //    }
                //}


                Grid1.Rows.Clear();

                System.Drawing.Image imgChecked = Properties.Resources.CheckBoxUnChecked;
                imgChecked.Tag = "N";

                int j = 0;


                for (int i = 0; i < dtData1.Rows.Count; i++)
                {


                    this.Grid1.Rows.Add();

                    //gridWRDW11.SetData(gridWRDW11.Rows.Fixed + i, gridWRDW11.Cols.Fixed + 0, "N");        //체크  

                    if (dtData1.Rows[i][grid1_COLUMN.BEFORE_WORK_FLAG].ToString() != "") //전공정 실적이 부족한 경우
                        imgChecked = Properties.Resources.CheckBoxClear;
                    else
                        imgChecked = Properties.Resources.CheckBoxUnChecked;

                    imgChecked.Tag = "N";
                    Grid1.Rows[i].Cells[grid1_COLUMN.CHECKFLAG].Value = imgChecked; //1.체크 


                    if (dtData1.Rows[i][grid1_COLUMN.SEQ].ToString() == "긴급")
                        Grid1.Rows[i].Cells[grid1_COLUMN.SEQ].Value = dtData1.Rows[i][grid1_COLUMN.SEQ].ToString(); //순번
                    else
                        Grid1.Rows[i].Cells[grid1_COLUMN.SEQ].Value = (i + 1).ToString(); //순번;

                    if(sWC_MGR == "30") //성형이면
                    {
                        Grid1.Rows[i].Cells[grid1_COLUMN.WK_DT].Value = Convert.ToDateTime(dtData1.Rows[i][grid1_COLUMN.PLAN_START_DT].ToString()).ToString("MM/dd HH:mm"); //지시일 
                        Grid1.Rows[i].Cells[grid1_COLUMN.CAST_CHANGE].Value = dtData1.Rows[i][grid1_COLUMN.CAST_CHANGE].ToString(); //금형교환
                    }
                    else
                    {
                        Grid1.Rows[i].Cells[grid1_COLUMN.WK_DT].Value = dtData1.Rows[i][grid1_COLUMN.WK_DT].ToString(); //지시일 
                        Grid1.Rows[i].Cells[grid1_COLUMN.CAST_CHANGE].Value = dtData1.Rows[i][grid1_COLUMN.CAST_CHANGE].ToString(); //금형교환 
                    }

                    Grid1.Rows[i].Cells[grid1_COLUMN.WK_ORD_NO].Value = dtData1.Rows[i][grid1_COLUMN.WK_ORD_NO].ToString(); //작업지시번호
                    Grid1.Rows[i].Cells[grid1_COLUMN.ITEM_CD].Value = dtData1.Rows[i][grid1_COLUMN.ITEM_CD].ToString(); //품번
                    Grid1.Rows[i].Cells[grid1_COLUMN.ITEM_NM].Value = dtData1.Rows[i][grid1_COLUMN.ITEM_NM].ToString(); //품명


                    if (dtData1.Rows[i][grid1_COLUMN.WK_ORD_UNIT].ToString().ToUpper() == "KG" || dtData1.Rows[i][grid1_COLUMN.WK_ORD_UNIT].ToString().ToUpper() == "G")
                    {
                        Grid1.Rows[i].Cells[grid1_COLUMN.WK_ORD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.WK_ORD_QTY].ToString()).ToString("N2"); //지시수량
                        Grid1.Rows[i].Cells[grid1_COLUMN.PROD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.PROD_QTY].ToString()).ToString("N2"); //생산수량

                        Grid1.Rows[i].Cells[grid1_COLUMN.REQ_A_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.REQ_A_QTY].ToString()).ToString("N2"); //생산수량
                        Grid1.Rows[i].Cells[grid1_COLUMN.REQ_B_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.REQ_B_QTY].ToString()).ToString("N2"); //생산수량

                        Grid1.Rows[i].Cells[grid1_COLUMN.REQ_1H_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.REQ_1H_QTY].ToString()).ToString("N2"); //생산수량
                        Grid1.Rows[i].Cells[grid1_COLUMN.REQ_2H_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.REQ_2H_QTY].ToString()).ToString("N2"); //생산수량
                        Grid1.Rows[i].Cells[grid1_COLUMN.REQ_4H_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.REQ_4H_QTY].ToString()).ToString("N2"); //생산수량
                        Grid1.Rows[i].Cells[grid1_COLUMN.REQ_4H_OVER_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.REQ_4H_OVER_QTY].ToString()).ToString("N2"); //생산수량

                    }
                    else
                    {
                        Grid1.Rows[i].Cells[grid1_COLUMN.WK_ORD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.WK_ORD_QTY].ToString()).ToString("N0"); //지시수량
                        Grid1.Rows[i].Cells[grid1_COLUMN.PROD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.PROD_QTY].ToString()).ToString("N0"); //생산수량

                        Grid1.Rows[i].Cells[grid1_COLUMN.REQ_A_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.REQ_A_QTY].ToString()).ToString("N0"); //생산수량
                        Grid1.Rows[i].Cells[grid1_COLUMN.REQ_B_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.REQ_B_QTY].ToString()).ToString("N0"); //생산수량

                        Grid1.Rows[i].Cells[grid1_COLUMN.REQ_1H_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.REQ_1H_QTY].ToString()).ToString("N0"); //생산수량
                        Grid1.Rows[i].Cells[grid1_COLUMN.REQ_2H_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.REQ_2H_QTY].ToString()).ToString("N0"); //생산수량
                        Grid1.Rows[i].Cells[grid1_COLUMN.REQ_4H_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.REQ_4H_QTY].ToString()).ToString("N0"); //생산수량
                        Grid1.Rows[i].Cells[grid1_COLUMN.REQ_4H_OVER_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.REQ_4H_OVER_QTY].ToString()).ToString("N0"); //생산수량
                    }

                    if (Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.REQ_4H_QTY].ToString()) == 0)
                    {
                        Grid1.Rows[i].Cells[grid1_COLUMN.REQ_1H_QTY].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        Grid1.Rows[i].Cells[grid1_COLUMN.REQ_1H_QTY].Style.ForeColor = Color.Black;
                    }

                    Grid1.Rows[i].Cells[grid1_COLUMN.EMP_DESC].Value = dtData1.Rows[i][grid1_COLUMN.EMP_DESC].ToString(); //작업자

                    if (dtData1.Rows[i][grid1_COLUMN.REAL_START_TM].ToString().Length > 0 &&
                        dtData1.Rows[i][grid1_COLUMN.REAL_END_TM].ToString().Length == 0)
                    {
                        if (dtData1.Rows[i][grid1_COLUMN.RESULT_FLAG].ToString() == "")
                        {
                            Grid1.Rows[i].Cells[grid1_COLUMN.STATUS].Value = "작업중"; //작업상태
                            Grid1.Rows[i].Cells[grid1_COLUMN.STATUS].Style.ForeColor = Color.Blue;
                        }
                        else
                        {
                            Grid1.Rows[i].Cells[grid1_COLUMN.STATUS].Value = "작업중(예외)"; //작업상태
                            Grid1.Rows[i].Cells[grid1_COLUMN.STATUS].Style.ForeColor = Color.Magenta;
                        }

                       ///if (tCheckBox1.ValueChar == "N")
                       ///    Grid1.Rows[i].Visible = false;
                       ///else
                       ///{
                       ///    
                       ///    Grid1.Rows[i].Visible = true;
                       ///    j = j + 1;
                       ///}
                    }
                    else
                    {
                        Grid1.Rows[i].Cells[grid1_COLUMN.STATUS].Value = ""; //작업상태

                        if (dtData1.Rows[i][grid1_COLUMN.BEFORE_WORK_FLAG].ToString() != "") //전공정 실적이 부족한 경우
                        {
                           ///if (tCheckBox2.ValueChar == "Y")    //전공정 실적 부족 분 표시가 y이면
                           ///{
                           ///    Grid1.Rows[i].Visible = true;
                           ///    j = j + 1;
                           ///}
                           ///else
                           ///{
                           ///    Grid1.Rows[i].Visible = false;
                           ///}
                        }
                        else
                        {
                            Grid1.Rows[i].Visible = true;
                            j = j + 1;
                        }

                        
                    }
                    Grid1.Rows[i].Cells[grid1_COLUMN.WK_FACILITY_NM].Value = dtData1.Rows[i][grid1_COLUMN.WK_FACILITY_NM].ToString(); //작업설비

                    Grid1.Rows[i].Cells[grid1_COLUMN.REAL_START_TM].Value = dtData1.Rows[i][grid1_COLUMN.REAL_START_TM].ToString(); //작업시작시각
                    Grid1.Rows[i].Cells[grid1_COLUMN.REAL_END_TM].Value = dtData1.Rows[i][grid1_COLUMN.REAL_END_TM].ToString(); //작업시작완료

                    string szaa = dtData1.Rows[i][grid1_COLUMN.REAL_START_TM].ToString();
                    string szbb = dtData1.Rows[i][grid1_COLUMN.REAL_END_TM].ToString();


                    Grid1.Rows[i].Cells[grid1_COLUMN.PRODT_ORDER_NO].Value = dtData1.Rows[i][grid1_COLUMN.PRODT_ORDER_NO].ToString(); //제조오더번호 
                    Grid1.Rows[i].Cells[grid1_COLUMN.OPR_NO].Value = dtData1.Rows[i][grid1_COLUMN.OPR_NO].ToString(); //공순 
                    Grid1.Rows[i].Cells[grid1_COLUMN.SHIFT_NM].Value = dtData1.Rows[i][grid1_COLUMN.SHIFT_NM].ToString(); //주/야
                    Grid1.Rows[i].Cells[grid1_COLUMN.BEFORE_WORK_FLAG].Value = dtData1.Rows[i][grid1_COLUMN.BEFORE_WORK_FLAG].ToString(); //전공정실적여부
                    if (Grid1.Rows[i].Cells[grid1_COLUMN.BEFORE_WORK_FLAG].Value.ToString() != "")
                    {
                        Grid1.Rows[i].Cells[grid1_COLUMN.ITEM_CD].Style.ForeColor = Color.Black;
                    }
                    else
                    {
                        Grid1.Rows[i].Cells[grid1_COLUMN.ITEM_CD].Style.ForeColor = Color.Blue;
                    }

                }

                //lblWROrderCount.Text = dtData1.Rows.Count.ToString("#,##0") + " 건";
                ///lblWROrderCount.Text = j.ToString("#,##0") + " 건";



            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "작업지시정보조회");
            }
            finally
            {
                LoadingForm(false);
            }
            
        }
        #endregion 작업지시현황 정보 조회

        

        #region 작업장정보 조회


        private void ProcessInform_Review(string szFacilityCD, ref string szWOrkSpaceCD, ref string szWOrkSpaceNM, bool bQueryOnly) //설비의 작업장 정보 조회
        {
            string strData = string.Empty;
            int nCnt = 0;

            try
            {
                LoadingForm(true);


                //// 대표공정 가져오기
                //szSendData = "";
                //szSendData = WorkCode.WorkCd.WORKSPACE_INFORM_REVIEW;
                //szSendData += szFacilityCD;

                strData = ""
                        + "SELECT B.WC_CD,"      //작업장코드
                        + "       B.WC_NM"      //작업장명
                        + " FROM P_RESOURCE AS A (NOLOCK) "
                        + "     INNER JOIN P_WORK_CENTER AS B (NOLOCK) ON A.EXT2_CD = B.WC_CD "
                        + " WHERE A.RESOURCE_CD = '" + szFacilityCD + "'";


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


                //string strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, szSendData, ref dtData1, ref nCnt,
                //    Global.workinfo.szServerIP,
                //    Global.workinfo.szPortNo);

                if (!strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "작업장정보 조회");
                    return;
                }

                

                if (!bQueryOnly)
                {
                    if (dtData1.Rows.Count > 0)
                    {
                        Global.workinfo.szWorkSpaceCD = dtData1.Rows[0]["WC_CD"].ToString();
                        Global.workinfo.szWorkSpaceNM = dtData1.Rows[0]["WC_NM"].ToString();
                    }
                    else
                    {
                        Global.workinfo.szWorkSpaceCD = "";
                        Global.workinfo.szWorkSpaceNM = "";
                    }

                    lbl_WorkCenterNm.Caption = Global.workinfo.szWorkSpaceNM;
                    global.WorkingFileWriteAll();
                }
                else
                {
                    if (dtData1.Rows.Count > 0)
                    {
                        szWOrkSpaceCD = dtData1.Rows[0]["WC_CD"].ToString();
                        szWOrkSpaceNM = dtData1.Rows[0]["WC_NM"].ToString();
                    }
                    else
                    {
                        szWOrkSpaceCD = "";
                        szWOrkSpaceNM = "";
                    }
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
            return;

        }
        #endregion 작업장정보 조회


        #region ETC Function

        private void LoadingForm(bool bVisible)
        {
            Cursor.Current = (bVisible == true) ? Cursors.WaitCursor : Cursors.Default;
            //waitLoading.Visible = bVisible;
            Application.DoEvents();
        }


        #endregion ETC Function

        private void cboWorker_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Query_Click(object sender, EventArgs e)    //조회버튼
        {
            DBQuery();
        }
        public bool DBQuery_GET_UNWORK(string pPLANT_CD, string pFACILITY_CD) //비가동 진행여부 확인
        {

            //sPLANT_CD = pPLANT_CD;
            //sFACILITY_CD = pFACILITY_CD;

            int nCnt = 0;
            bool vReturn = false;

            try
            {

                if (Global.workinfo.szServerIP == null || Global.workinfo.szServerIP == "")
                {
                    global.ConfigFileReadAll();
                }

                ////LoadingForm(true);

                //string strData = "";
                //strData = WorkCode.WorkCd.STOPWORK_FAC_INFO;
                ////strData += "EXEC DBO.XUSP_MES_P0401M1_GET_OP_CD ";
                //strData += pPLANT_CD + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //strData += pFACILITY_CD;
                string strData = "";
                strData = ""
                            + "EXEC DBO.XUSP_MESSVR_SW_FAC_INFO_GET "
                            + " @PLANT_CD='" + pPLANT_CD + "',"  //공장
                            + " @FACILITY_CD='" + pFACILITY_CD + "'";  //설비코드

                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);
                //string strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (@strState.Equals("OK") == false)
                {
                    //nsUsrFunction.UsrFunction.MessageBoxErr(strState.Substring(2), "설비 비가동");
                    vReturn = false;
                }

                if (dtData1 != null)
                {

                    if (dtData1.Rows[0]["OP_NM"].ToString() != "")
                    {
                        vReturn = true;
                    }
                    else
                    {
                        vReturn = false;
                    }


                }


            }
            catch (Exception e)
            {
                TGSControl.UsrFunction.MessageBoxErr(e.Message, "설비 비가동 조회");
                vReturn = false;
            }
            finally
            {
                //LoadingForm(false);
            }
            return vReturn;
        }

        public bool DBQuery_GET_ITEM(string pITEM_CD) //품번 및 롯트번호를 입력 받아 작업지시 리스트를 조회한다.
        {

            //sPLANT_CD = pPLANT_CD;
            //sFACILITY_CD = pFACILITY_CD;

            int nCnt = 0;
            bool vReturn = false;

            try
            {

                if (Global.workinfo.szServerIP == null || Global.workinfo.szServerIP == "")
                {
                    global.ConfigFileReadAll();
                }

                ////LoadingForm(true);

                //string strData = "";
                //strData = WorkCode.WorkCd.STOPWORK_FAC_INFO;
                ////strData += "EXEC DBO.XUSP_MES_P0401M1_GET_OP_CD ";
                //strData += pPLANT_CD + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //strData += pFACILITY_CD;
                string strData = "";
                strData = ""
                            + "EXEC DBO.XUSP_MES_P1001M1_GET_ITEM_CD "
                            + " @PLANT_CD='" + sPLANT_CD + "',"  //공장
                            + " @LOT_NO='" + pITEM_CD + "'";  //설비코드

                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);
                //string strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (@strState.Equals("OK") == false)
                {
                    //nsUsrFunction.UsrFunction.MessageBoxErr(strState.Substring(2), "설비 비가동");
                    vReturn = false;
                }

                if (dtData1 != null)
                {

                    //opn_ITEM_CD.Value = dtData1.Rows[0]["ITEM_CD"].ToString();
                    string vPRODT_ORDER_NO = dtData1.Rows[0]["PRODT_ORDER_NO"].ToString();

                    if (vPRODT_ORDER_NO != "")
                    {
                        Filter_WORK_ORDER(dtData1);
                    }
                    else
                    {
                        Filter_ITEM();
                    }
                    
                    vReturn = true;
                }

                

            }
            catch (Exception e)
            {
                TGSControl.UsrFunction.MessageBoxErr(e.Message, "작업지시 조회");
                vReturn = false;
            }
            finally
            {
                //LoadingForm(false);
            }
            return vReturn;
        }

        private void btn_Unwork_Click(object sender, EventArgs e)   //비가동버튼
        {
            //임시주석 시작
            //if (cboWorker.Value == "")
            //{
            //    if (DBQuery_GET_UNWORK(sPLANT_CD, sFACILITY_CD) == false)   //비가동 진행여부 체크 비가동 중일 때는 작업자를 체크 안함
            //    {
            //        TGSControl.UsrFunction.MessageBoxErr("작업자를 선택 후 등록하세요.", "작업자 선택");
            //        return;
            //    }
            //}

            //MES_APP_P90.POP_P9001PA3 myForm = new MES_APP_P90.POP_P9001PA3();

            ////파라메터를 설정한다.

            //DataTable dt = new DataTable("PassData");
            //dt.Columns.Add("WC_CD");
            //dt.Columns.Add("PLANT_CD");
            //dt.Columns.Add("WC_MGR");
            //dt.Columns.Add("FACILITY_CD");
            //dt.Columns.Add("WORKER_CD");



            //dt.Rows.Add();

            //dt.Rows[0]["WC_CD"] = sWC_CD;
            //dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
            //dt.Rows[0]["WC_MGR"] = sWC_MGR;
            //dt.Rows[0]["FACILITY_CD"] = sFACILITY_CD;
            //dt.Rows[0]["WORKER_CD"] = sWORKER_CD;


            //myForm.ResultData.Tables.Add(dt); //변수전달


            //myForm.MainForm = this.MainForm;


            ////myForm.Caption = "작업표준서";
            //myForm.Start(); //시작함수를 실행한다.
            ////myForm.OnFncQuery(); //조회함

            //myForm.ShowDialog(); //화면에 표시




            ////string[] strParam = new string[19];
            ////strParam[0] = Global.szHomeDir;
            ////strParam[1] = Global.workinfo.szServerIP;
            ////strParam[2] = Global.workinfo.szPortNo;
            ////strParam[3] = sPLANT_CD; // Global.workinfo.szFactoryCD;
            ////strParam[4] = Global.workinfo.szFactoryNM;
            ////strParam[5] = sWC_MGR; // Global.workinfo.szProcessCD;
            ////strParam[6] = Global.workinfo.szProcessNM;
            ////strParam[7] = sWC_CD; // Global.workinfo.szWorkSpaceCD;
            ////strParam[8] = sWC_NM; // Global.workinfo.szWorkSpaceNM;
            ////strParam[9] = cboFacility.Value; // Global.workinfo.szFacilityCD;
            ////strParam[10] = cboFacility.ValueName;
            ////strParam[11] = cboWorker.Value; //Global.workinfo.szOperatorCD;
            ////strParam[12] = cboWorker.ValueName; // Global.workinfo.szOperatorNM;

            //////int nCheckedRow = CheckedRowCount(Grid1, 0);
            //////if (nCheckedRow < 0)
            //////{
            ////    strParam[13] = "";
            ////    strParam[14] = "";
            ////    strParam[15] = "";   //RESULT_SEQ
            ////    strParam[16] = "";   //LOT_NO

            ////    //nsUsrFunction.UsrFunction.MessageBoxErr("LOT작업중이 아닙니다", "비가동등록");
            ////    //return;
            //////}
            //////else
            //////{

            //////    strParam[13] = Grid1.Rows[gridWPDW12_COLUMN.WK_ORD_NO].ToString();
            //////    strParam[14] = dgWorking[nCheckedRow, gridWPDW12_COLUMN.RESULT_NO].ToString();
            //////    strParam[15] = "";   //RESULT_SEQ
            //////    strParam[16] = "";   //LOT_NO

            //////}


            ////nsUsrFunction.UsrFunction.NewForm_Exec(Global.szHomeDir, "MES_TPC_CM01", strParam, true);
            //임시주석끝

        }

        private void btn_WorkStart_Click(object sender, EventArgs e)    //작업시작버튼
        {
            //작업시작
            Work_Start();
        }






        //그리드 선택을 할 경우
        private void Grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Grid1.Columns[Grid1.CurrentCell.ColumnIndex].Name == grid1_COLUMN.CHECKFLAG)
                {
                    if (Grid1.CurrentRow.Cells[grid1_COLUMN.BEFORE_WORK_FLAG].Value.ToString() != "")
                    {
                        return;
                    }
                    System.Drawing.Image imgCheck = (System.Drawing.Image)Grid1.CurrentRow.Cells[grid1_COLUMN.CHECKFLAG].Value;
                    if (imgCheck.Tag.ToString() == "N")
                    {


                        System.Drawing.Image imgChecked = Properties.Resources.CheckBoxChecked;
                        imgChecked.Tag = "Y";

                        Grid1.CurrentRow.Cells[grid1_COLUMN.CHECKFLAG].Value = imgChecked;

                        sITEM_CD = Grid1.CurrentRow.Cells[grid1_COLUMN.ITEM_CD].Value.ToString();  //선택된 품번
                    }
                    else
                    {


                        System.Drawing.Image imgUnChecked = Properties.Resources.CheckBoxUnChecked;
                        imgUnChecked.Tag = "N";

                        Grid1.CurrentRow.Cells[grid1_COLUMN.CHECKFLAG].Value = imgUnChecked;

                        sITEM_CD = "";//선택된 품번

                    }
                }
            }


        }

        //작업자가 선택될 경우
        private void cboWorker_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (cboWorker.SelectedIndex < 0) return;

            //sWORKER_CD = cboWorker.Value;

            //Global.workinfo.szOperatorCD = cboWorker.Value;
            //Global.workinfo.szOperatorNM = cboWorker.ValueName;

            global.ConfigFileWriteAll();
        }


        private int CheckedRowCount(DataGridView grid, int Check_Col)
        {

            int nCheckRowCnt = 0;

            for (int i = 0; i < grid.Rows.Count; i++)
            {
                System.Drawing.Image imgCheck = (System.Drawing.Image) grid.Rows[i].Cells [Check_Col].Value;

                if (imgCheck.Tag.ToString() == "Y")
                {
                    nCheckRowCnt = nCheckRowCnt + 1;
                }
            }

            return nCheckRowCnt;

        }





        private void Work_Start()
        {
            //int nCnt = 0;

            try
            {
                int nCheckedRowCount = CheckedRowCount(Grid1, Grid1.Columns[grid1_COLUMN.CHECKFLAG].Index);
                if (nCheckedRowCount == 0)
                {
                    TGSControl.UsrFunction.MessageBoxErr("작업할 데이타를 체크하세요.", "작업시작");
                    return;
                }

                //if (cboWorker.SelectedIndex < 0)
                //{
                //    TGSControl.UsrFunction.MessageBoxErr("작업자를 선택하세요.", "작업시작");
                //    return;
                //}

                if (cboFacility.SelectedIndex < 0)
                {
                    TGSControl.UsrFunction.MessageBoxErr("설비를 선택하세요.", "작업시작");
                    return;
                }

                if (nCheckedRowCount > 1)   //1건 이상일 경우 작업시작 메시지를 띄움
                {
                    TGSControl.UsrFunction.MessageBoxErr(nCheckedRowCount + "건의 작업지시를 시작하겠습니다.", "체크ROW확인");
                }




                LoadingForm(true);

                
                foreach(DataGridViewRow myRow in Grid1.Rows)
                {
                    System.Drawing.Image imgCheck = (System.Drawing.Image)myRow.Cells[grid1_COLUMN.CHECKFLAG].Value ;

                    if (imgCheck.Tag.ToString()  == "Y")
                    {
                        if (myRow.Cells[grid1_COLUMN.STATUS].Value.ToString().Trim().Length > 0)
                        {
                            if (myRow.Cells[grid1_COLUMN.WK_FACILITY_NM].Value.ToString().ToUpper() != cboFacility.ValueName.ToString().ToUpper())
                            {
                                //작업중인것을 시작할 때 물어보기
                                if (TGSControl.UsrFunction.MessageBoxYesNo(myRow.Cells[grid1_COLUMN.ITEM_CD].Value.ToString() + "은 현재 작업중입니다. " + "동시작업을 진행하시 겠습니다.", "동시 작업") == DialogResult.No)
                                {
                                    continue;   //작업상태가 작업진행 중인 건이면 처리하지 않고 다음 for문으로 제어를 전달한다.
                                }
                            }
                            else
                            {
                                continue;   //작업상태가 작업진행 중이고 동일 설비에 시작처리 된 작업지시 건이면 처리하지 않고 다음 for문으로 제어를 전달한다.
                            }

                            if (myRow.Cells[grid1_COLUMN.BEFORE_WORK_FLAG].Value.ToString().ToUpper() != "")
                            {
                                TGSControl.UsrFunction.MessageBoxErr("동일 제조오더의 전공정 실적이 없습니다.", "전공정 실적이 없습니다.");
                                LoadingForm(false);
                                return;
                            }
                        }

                        //string szSendData = WorkCode.WorkCd.WORK_START;
                        //szSendData += sPLANT_CD + nsWinUtilGlobal.Global.Separation.COLUMNS;
                        //szSendData += sWC_MGR + nsWinUtilGlobal.Global.Separation.COLUMNS;
                        //szSendData += sWC_CD + nsWinUtilGlobal.Global.Separation.COLUMNS;
                        //szSendData += sFACILITY_CD + nsWinUtilGlobal.Global.Separation.COLUMNS;
                        //szSendData += sWORKER_CD + nsWinUtilGlobal.Global.Separation.COLUMNS;
                        //szSendData += myRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString() + nsWinUtilGlobal.Global.Separation.COLUMNS;
                        //szSendData += "0";

                        //string strState = nsFuncUtil.FuncUtil.ExcuteSql(sMainForm , szSendData, Global.workinfo.szServerIP, Global.workinfo.szPortNo);





                        string strData = "";
                        strData += "dbo.USP_MES_P_WORK_INSERT";       //프로시져 명
                        strData += Global.COLUMNS_DIV + "N" + Global.Separation.COLUMNS;   //조회데이타가 없을 경우 'N' = nonquery 있을 경우 'Q' = query
                        //일반변수 리스트
                        strData += "@PLANT_CD" + Global.COLUMNS_DIV;
                        strData += "@WK_ORD_NO" + Global.COLUMNS_DIV;
                        strData += "@WC_CD" + Global.COLUMNS_DIV;
                        strData += "@FACILITY_CD" + Global.COLUMNS_DIV;

                        strData += "@PROD_QTY" + Global.COLUMNS_DIV;
                        strData += "@USER_ID" + Global.COLUMNS_DIV;

                        strData += "@RESULT_NO" + Global.COLUMNS_DIV;


                        if (sRESULT_USER_FLAG == true && sRESULT_USER_DT != "")//사용자 소급실적일경우
                        {
                            strData += "@RTN_MSG" + Global.COLUMNS_DIV;
                            strData += "@REAL_START_DT" + Global.Separation.COLUMNS;
                        }
                        else
                        {
                            strData += "@RTN_MSG" + Global.Separation.COLUMNS;
                        }

                        //일반변수 리스트의 형식
                        strData += Global.DBVarType.VarChar + "(4)" + Global.COLUMNS_DIV;
                        strData += Global.DBVarType.VarChar + "(30)" + Global.COLUMNS_DIV;
                        strData += Global.DBVarType.VarChar + "(7)" + Global.COLUMNS_DIV;
                        strData += Global.DBVarType.VarChar + "(18)" + Global.COLUMNS_DIV;
                        
                        strData += Global.DBVarType.Numeric + "(18,2)" + Global.COLUMNS_DIV;
                        strData += Global.DBVarType.VarChar + "(10)" + Global.COLUMNS_DIV;

                        strData += Global.DBVarType.VarChar + "(20) OUTPUT" + Global.COLUMNS_DIV;

                        if (sRESULT_USER_FLAG == true && sRESULT_USER_DT != "")//사용자 소급실적일경우
                        {
                            strData += Global.DBVarType.VarChar + "(200) OUTPUT" + Global.COLUMNS_DIV;
                            strData += Global.DBVarType.Datetime + Global.Separation.COLUMNS;
                        }
                        else
                        {
                            strData += Global.DBVarType.VarChar + "(200) OUTPUT" + Global.Separation.COLUMNS;
                        }
                        

                        //일반변수값 리스트
                        strData += sPLANT_CD + Global.COLUMNS_DIV;  //공장
                        strData += myRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString() + Global.COLUMNS_DIV;         //실적번호
                        strData += sWC_CD + Global.COLUMNS_DIV;    //작업장
                        strData += sFACILITY_CD + Global.COLUMNS_DIV;   //설비
                        
                        strData += "0" + Global.COLUMNS_DIV;         //생산량
                        strData += sWORKER_CD + Global.COLUMNS_DIV;     //작업자

                        strData += "" + Global.COLUMNS_DIV;         //실적번호

                        if (sRESULT_USER_FLAG == true && sRESULT_USER_DT != "")     //사용자 소급실적일경우
                        {
                            strData += "" + Global.COLUMNS_DIV;      //RTN MSG 반환
                            strData += sRESULT_USER_DT + Global.Separation.COLUMNS; //실적일자
                        }
                        else
                        {
                            strData += "" + Global.Separation.COLUMNS;      //RTN MSG 반환
                        }

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
                        strData += ""; // +nsWinUtilGlobal.Global.Separation.COLUMNS;


                        //string strState = nsFuncUtil.FuncUtil.ExcuteSql(MainForm, strData, Global.workinfo.szServerIP, Global.workinfo.szPortNo); //반환테이블이 없을 경우
                        DataTable dtData1 = new DataTable();
                        int nCnt = 0;

                        string strState = TGSClass.DataBase.GetDataSqlProcedur(MainForm, strData, ref dtData1, ref nCnt); //TGS Class 사용







                        //if (!strState.Equals("OK"))
                        if (strState.Substring(0,2) != "OK")
                        {

                            TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2) + "\n" + myRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString(), "작업시작");
                        }

                    }
                }

                //lblWorkCenter.Caption = Global.workinfo.szWorkSpaceNM;
                //lblWPFacilityNM.Caption = Global.workinfo.szFacilityNM;


                
                DBQuery_Work_Order_RetriveData();
                FuncWRWorkStart();
                //tabActualOupputs.SelectTab(TABCONTROL_NAME.WorkProcess);  //작업시작 텝으로 이동한다.

                //Lot_RetriveData(strState);
            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "작업시작");
            }
            finally
            {
                LoadingForm(false);
            }

        }


        private void FuncWRWorkStart()
        {

            global.WorkingFileWriteAll();

            //내부에서 명령을 등록해준후 명령이벤트를 실행한다.
            CommandRun_Event(0);

        }
        
        
        //설비를 변경될 경우
        private void cboFacility_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboFacility.Value != sFACILITY_CD)
            {
                sFACILITY_CD = cboFacility.Value;
                ProcessInform_Review(sFACILITY_CD, ref sWC_CD, ref sWC_NM, false);   //선택된 설비의 작업장 정보

                if (cboFacility.SelectedIndex > 0)
                {

                    if (cboFacility.DataSource.Rows[cboFacility.SelectedIndex]["TYPE"].ToString() == "M")
                    {
                        btn_Unwork.Enabled = true;
                        //btn_DailyCheck.Enabled = true;
                    }
                    else
                    {
                        btn_Unwork.Enabled = false;
                        //btn_DailyCheck.Enabled = false;
                    }
                }
                else
                {
                    btn_Unwork.Enabled = false;
                    //btn_DailyCheck.Enabled = false;
                }

                DBQuery();
            }
        }
        


        private void opn_ITEM_CD_OpenPopup(object sender, EventArgs e)
        {
            
            Filter_ITEM(); //검색 버튼을 입력 했을 때는 필터를 건다.
        }
        private void btnFind_ButtonClick(object sender, EventArgs e)
        {
            //Find_ITEM();
            //Filter_ITEM(); //검색 버튼을 입력 했을 때는 필터를 건다.

            MES_SYS_B00.POP_ITEM myPopupForm = new MES_SYS_B00.POP_ITEM();

            DataTable dt = new DataTable("PassData");
            dt.Columns.Add("PLANT_CD");
            dt.Columns.Add("ITEM_CD");
            dt.Columns.Add("ITEM_NM");
            //dt.Columns.Add("WC_MGR");       //대분류
            //dt.Columns.Add("ITEM_ACCT");      //계정
            //dt.Columns.Add("ITEM_GROUP_CD");//품목그룹
            //dt.Columns.Add("SL_CD");        //창고


            dt.Rows.Add();

            dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
            //dt.Rows[0]["ITEM_CD"] = opn_ITEM_CD.Value;
            dt.Rows[0]["ITEM_NM"] = ""; //opn_ITEM_CD.ValueName;
            //dt.Rows[0]["WC_MGR"] = sWC_MGR;
            //dt.Rows[0]["ITEM_ACCT"] = "20";   //반제품
            //dt.Rows[0]["ITEM_GROUP_CD"] = "";
            //dt.Rows[0]["SL_CD"] = "";


            myPopupForm.ResultData.Tables.Add(dt); //변수전달


            myPopupForm.MainForm = this.MainForm;
            myPopupForm.Start();

            DialogResult dResult = myPopupForm.ShowDialog();

            if (dResult == DialogResult.OK)
            {

                //품번조회 완료


                //opn_ITEM_CD.Value = myPopupForm.ResultData.Tables["Result"].Rows[0]["ITEM_CD"].ToString();
                //opn_ITEM_CD.ValueName = myPopupForm.ResultData.Tables["Result"].Rows[0]["ITEM_CD"].ToString();

                DBQuery_Work_Order_RetriveData();    //작업지시현황을 조회 

                //if (opn_ITEM_CD.Value != "") Filter_ITEM(); //Find_ITEM();
            }

            myPopupForm.Dispose();
            
        }
        private void opn_ITEM_CD_EnterKeyDown(object sender, EventArgs e)
        {
            //Find_ITEM();   //품목을 입력했을 때는 바로 검색을 한다.

            //Filter_ITEM(); //검색 버튼을 입력 했을 때는 필터를 건다.
            //DBQuery_GET_ITEM(opn_ITEM_CD.Value);//검색 버튼을 입력 했을 때는 필터를 건다.
        }
        

        private void Find_ITEM()    //품목검색
        {
            //try
            //{
            //    if (opn_ITEM_CD.Value.Trim().Length == 0)
            //    {
            //        TGSControl.UsrFunction.MessageBoxInfo("검색할 품번코드를 입력하세요.", "품번 검색");
            //        opn_ITEM_CD.Focus();
            //        return;
            //    }

            //    for (int i = 0; i < Grid1.Rows.Count; i++)
            //    {
                    

            //        if (opn_ITEM_CD.Value.ToString().ToUpper() == Grid1.Rows[i].Cells[grid1_COLUMN.ITEM_CD].Value.ToString().Substring(0,opn_ITEM_CD.Value.Length).ToUpper())
            //        {
            //            if (Grid1.Rows[i].Visible == true)
            //            {
            //                Grid1.FirstDisplayedScrollingRowIndex = i;

            //                Grid1.Rows[i].Cells[0].Selected = true;
            //                return;
            //            }
            //        }
            //    }


            //    TGSControl.UsrFunction.MessageBoxInfo ("품번을 찾을 수 없습니다.", "품번 검색");
            //    return;
            //}
            //catch (Exception se)
            //{
            //    TGSControl.UsrFunction.MessageBoxErr(se.Message, "품번 검색");
            //}
        }
        private void Filter_ITEM()  //품목을 검색해서 해당 품목만 화면에 보이게 필터를 한다.
        {
            //if (opn_ITEM_CD.Value.Trim().Length == 0)
            //{
            //    //nsUsrFunction.UsrFunction.MessageBoxInfo("검색할 품번코드를 입력하세요.", "품번 검색");
            //    for (int i = 0; i < Grid1.Rows.Count; i++)
            //    {
            //        if (Grid1.Rows[i].Cells[grid1_COLUMN.STATUS].Value.ToString().Trim() != "")  //작업상태
            //        {
            //            if (tCheckBox1.ValueChar == "N")
            //                Grid1.Rows[i].Visible = false;
            //            else
            //            {
            //                Grid1.Rows[i].Visible = true;
            //            }
            //        }
            //        else
            //        {
                        
            //            if (Grid1.Rows[i].Cells[grid1_COLUMN.BEFORE_WORK_FLAG].Value.ToString() != "") //전공정 실적이 부족한 경우
            //            {
            //                if (tCheckBox2.ValueChar == "Y")    //전공정 실적 부족 분 표시가 y이면
            //                {
            //                    Grid1.Rows[i].Visible = true;
            //                }
            //                else
            //                {
            //                    Grid1.Rows[i].Visible = false;
            //                }
            //            }
            //            else
            //            {
            //                Grid1.Rows[i].Visible = true;
            //            }
            //        }

            //    }
            //    opn_ITEM_CD.Focus();
            //    return;
            //}
            ////int slen = opn_ITEM_CD.Value.Length;
            //int vViewCount = 0;
            //for (int i = 0; i < Grid1.Rows.Count; i++)
            //{
            //    if (Grid1.Rows[i].Cells[grid1_COLUMN.ITEM_CD].Value.ToString().ToUpper().IndexOf(opn_ITEM_CD.Value.ToString().ToUpper()) >= 0)
            //    //if (opn_ITEM_CD.Value.ToString().ToUpper() == Grid1.Rows[i].Cells[grid1_COLUMN.ITEM_CD].Value.ToString().Substring(0,slen).ToUpper())
            //    {
            //        if (Grid1.Rows[i].Cells[grid1_COLUMN.STATUS].Value.ToString().Trim() != "")  //작업상태
            //        {
            //            if (tCheckBox1.ValueChar == "N")
            //                Grid1.Rows[i].Visible = false;
            //            else
            //                Grid1.Rows[i].Visible = true;
            //            vViewCount = vViewCount + 1;
            //        }
            //        else
            //        {
            //            if (Grid1.Rows[i].Cells[grid1_COLUMN.BEFORE_WORK_FLAG].Value.ToString() != "") //전공정 실적이 부족한 경우
            //            {
            //                if (tCheckBox2.ValueChar == "Y")    //전공정 실적 부족 분 표시가 y이면
            //                {
            //                    Grid1.Rows[i].Visible = true;
            //                    vViewCount = vViewCount + 1;
            //                }
            //                else
            //                {
            //                    Grid1.Rows[i].Visible = false;
            //                }
            //            }
            //            else
            //            {
            //                Grid1.Rows[i].Visible = true;
            //                vViewCount = vViewCount + 1;
            //            }
            //        }
                                        
            //    }
            //    else
            //    {
            //        Grid1.Rows[i].Visible = false;
            //    }

            //}

            //lblWROrderCount.Text = vViewCount.ToString("#,##0") + " 건";

            this.OnMouseClick(null);
        }

        private void Filter_WORK_ORDER(DataTable pData_PRODT_ORDER_NO)  //품목을 검색해서 해당 품목만 화면에 보이게 필터를 한다.
        {
            //if (opn_ITEM_CD.Value.Trim().Length == 0)
            //{
            //    //nsUsrFunction.UsrFunction.MessageBoxInfo("검색할 품번코드를 입력하세요.", "품번 검색");
            //    for (int i = 0; i < Grid1.Rows.Count; i++)
            //    {
            //        if (Grid1.Rows[i].Cells[grid1_COLUMN.STATUS].Value.ToString().Trim() != "")  //작업상태
            //        {
            //            if (tCheckBox1.ValueChar == "N")
            //                Grid1.Rows[i].Visible = false;
            //            else
            //            {
            //                Grid1.Rows[i].Visible = true;
            //            }
            //        }
            //        else
            //        {

            //            if (Grid1.Rows[i].Cells[grid1_COLUMN.BEFORE_WORK_FLAG].Value.ToString() != "") //전공정 실적이 부족한 경우
            //            {
            //                if (tCheckBox2.ValueChar == "Y")    //전공정 실적 부족 분 표시가 y이면
            //                {
            //                    Grid1.Rows[i].Visible = true;
            //                }
            //                else
            //                {
            //                    Grid1.Rows[i].Visible = false;
            //                }
            //            }
            //            else
            //            {
            //                Grid1.Rows[i].Visible = true;
            //            }
            //        }

            //    }
            //    opn_ITEM_CD.Focus();
            //    return;
            //}
            //int slen = opn_ITEM_CD.Value.Length;
            int vViewCount = 0;

            for (int i = 0; i < Grid1.Rows.Count; i++)
            {
                Grid1.Rows[i].Visible = false;
            }

            string vPRODT_ORDER_NO = "";
            for (int j = 0; j < pData_PRODT_ORDER_NO.Rows.Count; j++)
            {
                vPRODT_ORDER_NO = pData_PRODT_ORDER_NO.Rows[j]["PRODT_ORDER_NO"].ToString().ToUpper();
                for (int i = 0; i < Grid1.Rows.Count; i++)
                {
                    if (Grid1.Rows[i].Cells[grid1_COLUMN.PRODT_ORDER_NO].Value.ToString().ToUpper() == vPRODT_ORDER_NO)
                    //if (opn_ITEM_CD.Value.ToString().ToUpper() == Grid1.Rows[i].Cells[grid1_COLUMN.ITEM_CD].Value.ToString().Substring(0,slen).ToUpper())
                    {
                        if (Grid1.Rows[i].Cells[grid1_COLUMN.STATUS].Value.ToString().Trim() != "")  //작업상태
                        {
                            //if (tCheckBox1.ValueChar != "N")
                            //{
                            //    Grid1.Rows[i].Visible = true;
                            //    vViewCount++;
                            //}
                        }
                        else
                        {
                            if (Grid1.Rows[i].Cells[grid1_COLUMN.BEFORE_WORK_FLAG].Value.ToString() != "") //전공정 실적이 부족한 경우
                            {
                                //if (tCheckBox2.ValueChar == "Y")    //전공정 실적 부족 분 표시가 y이면
                                //{
                                //    Grid1.Rows[i].Visible = true;
                                //    vViewCount++;
                                //}
                            }
                            else
                            {
                                Grid1.Rows[i].Visible = true;
                                vViewCount++;
                            }
                        
                        }

                    }   //IF
                }   //FOR I
                
            }//FOR J

            //lblWROrderCount.Text = vViewCount.ToString("#,##0") + " 건";

            if (vViewCount == 0)    //현 작업지시 리스트에 작업지시가 없으면 공정정보를 조회함
            {
                if (TGSControl.UsrFunction.MessageBoxYesNo("공정정보를 보시겠습니까?", "작업지시가 없습니다.") == DialogResult.Yes)
                {
                    Show_WK_ORDER_ROUT(pData_PRODT_ORDER_NO.Rows[0]["PRODT_ORDER_NO"].ToString());  //작업지시 또는 제조오더의 공정별 작업지시 정보를 조회 함
                }
                else
                {
                    Filter_ITEM();
                }
            }

            this.OnMouseClick(null);
        }

        //private void chk_ITEM_SORT_CheckedChange(object sender, EventArgs e)
        //{
        //    //DataGridViewColumn newColumn = Grid1.Columns.GetColumnCount (DataGridViewElementStates.Selected);

        //    if (chk_ITEM_SORT.Checked)
        //    {
        //        Grid1.Sort(Grid1.Columns[grid1_COLUMN.ITEM_CD], ListSortDirection.Ascending);
        //    }
        //    else
        //    {
        //        Grid1.Sort(Grid1.Columns[grid1_COLUMN.STATUS], ListSortDirection .Descending);
        //    }

        //}
        //행의 첫 시작 위치를 선택할 때 row위치가 visible = false 이면 오류 발생함으로 visible 여부를 체크 함
        private int GetFirstRowIndex(DataGridView Grid, int pRowIndex)
        {
            int i = 0;

            for (i = pRowIndex; i < Grid.Rows.Count; i++)
            {
                if (Grid.Rows[i].Visible == true)
                {
                    return i;
                }
            }

            return -1;
        }

        //행의 첫 시작 위치를 선택할 때 row위치가 visible = false 이면 오류 발생함으로 visible 여부를 체크 함
        private int GetLastRowIndex(DataGridView Grid,  int pRowIndex)
        {
            int i = 0;
            int vDisplayedRowCount = Grid.DisplayedRowCount(false);
            int row = -1;
            int findCount = 0;

            for (i = pRowIndex; i >= 0; i--)
            {
                if (Grid.Rows[i].Visible == true)
                {
                    row = i;
                    findCount = findCount + 1;

                    if (vDisplayedRowCount <= findCount)
                    {
                        return i;
                    }
                }
            }
            if (row >= 0)
            {
                return row;
            }
            else
            {
                return GetFirstRowIndex(Grid, pRowIndex);  //없을 경우 이후 값 다시 찿기
            }


            //return -1;
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
            int vDisplayedRowCount = Grid1.DisplayedRowCount(false);
            if (vDisplayedRowCount > 0)
            {
                int vFirstDisplayedScrollingRowIndex = Grid1.FirstDisplayedScrollingRowIndex - vDisplayedRowCount;

                

                if (vFirstDisplayedScrollingRowIndex <= 0)
                    Grid1.FirstDisplayedScrollingRowIndex = GetLastRowIndex(Grid1, 0);
                else
                    Grid1.FirstDisplayedScrollingRowIndex = GetLastRowIndex(Grid1, Grid1.FirstDisplayedScrollingRowIndex - vDisplayedRowCount);
            }
            //}
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
            int vDisplayedRowCount = Grid1.DisplayedRowCount(false);
            if (vDisplayedRowCount > 0)
            {
                int vFirstDisplayedScrollingRowIndex = Grid1.FirstDisplayedScrollingRowIndex + vDisplayedRowCount;

                if (vFirstDisplayedScrollingRowIndex >= Grid1.Rows.Count)
                    Grid1.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid1, Grid1.Rows.Count - 1);
                else
                    Grid1.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid1, vFirstDisplayedScrollingRowIndex);
            }
            //}
        }

        private void tCheckBox1_CheckedChange(object sender, EventArgs e)
        {
            int vViewCount = 0;
            for (int i = 0; i < Grid1.Rows.Count; i++)
            {
                if (Grid1.Rows[i].Cells[grid1_COLUMN.STATUS].Value.ToString().Trim() != "")  //작업상태
                {
                    //if (tCheckBox1.ValueChar == "N")
                    //    Grid1.Rows[i].Visible = false;
                    //else
                    //{
                    //    Grid1.Rows[i].Visible = true;
                    //    vViewCount = vViewCount + 1;
                    //}
                }
                else
                {
                    if (Grid1.Rows[i].Cells[grid1_COLUMN.BEFORE_WORK_FLAG].Value.ToString() != "") //전공정 실적이 부족한 경우
                    {
                        //if (tCheckBox2.ValueChar == "Y")    //전공정 실적 부족 분 표시가 y이면
                        //{
                        //    Grid1.Rows[i].Visible = true;
                        //    vViewCount = vViewCount + 1;
                        //}
                        //else
                        //{
                        //    Grid1.Rows[i].Visible = false;
                        //}
                    }
                    else
                    {
                        Grid1.Rows[i].Visible = true;
                        vViewCount = vViewCount + 1;
                    }
                }
            }

            //lblWROrderCount.Text = vViewCount.ToString("#,##0") + " 건";


            //if (tCheckBox1.ValueChar == "N")
            //{
            //    Grid1.Columns[grid1_COLUMN.WK_FACILITY_NM].Visible = false;
                
            //}
            //else
            //{
            //    Grid1.Columns[grid1_COLUMN.WK_FACILITY_NM].Visible = true;
                    
            //}

            int vFirstRowIndex = GetFirstRowIndex(Grid1, 0);
            if (vFirstRowIndex >= 0)
            {
                Grid1.FirstDisplayedScrollingRowIndex = vFirstRowIndex;
                Grid1.Rows[vFirstRowIndex].Selected = true;
            }

            TGSClass.Util.Grid_Resize(Grid1);
        }

        private void opn_ITEM_CD_ValueChanged(object sender, EventArgs e)
        {
            //Find_ITEM();
            Filter_ITEM(); //검색 버튼을 입력 했을 때는 필터를 건다.
        }

        private void btn_StandardSheet_ButtonClick(object sender, EventArgs e)
        {
            if (Grid1.CurrentRow != null)
            {
                POP_P9001PA1 myForm = new POP_P9001PA1();

                //파라메터를 설정한다.

                DataTable dt = new DataTable("PassData");
                dt.Columns.Add("ITEM_CD");
                dt.Columns.Add("ITEM_NM");
                dt.Columns.Add("PLANT_CD");
                dt.Columns.Add("WC_MGR");
                dt.Columns.Add("WC_CD");


                dt.Rows.Add();

                dt.Rows[0]["ITEM_CD"] = Grid1.CurrentRow.Cells[grid1_COLUMN.ITEM_CD].Value.ToString();
                dt.Rows[0]["ITEM_NM"] = Grid1.CurrentRow.Cells[grid1_COLUMN.ITEM_NM].Value.ToString();
                dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
                dt.Rows[0]["WC_MGR"] = sWC_MGR;
                dt.Rows[0]["WC_CD"] = sWC_CD;


                myForm.ResultData.Tables.Add(dt); //변수전달


                myForm.MainForm = this.MainForm;


                myForm.Caption = "작업표준서";
                myForm.Start(); //시작함수를 실행한다.
                myForm.OnFncQuery(); //조회함

                myForm.ShowDialog(); //화면에 표시
            }
        }
        //작업지시서 상세정보를 조회한다.
        private void btn_WorkOrder_Info_ButtonClick(object sender, EventArgs e)
        {
            if (Grid1.CurrentRow != null)
            {
                MES_SYS_B00.POP_B0004P1 myForm = new MES_SYS_B00.POP_B0004P1();

                //파라메터를 설정한다.

                DataTable dt = new DataTable("PassData");
                dt.Columns.Add("PLANT_CD");
                dt.Columns.Add("WK_ORD_NO");



                dt.Rows.Add();

                dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
                dt.Rows[0]["WK_ORD_NO"] = Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString();


                myForm.ResultData.Tables.Add(dt); //변수전달


                myForm.MainForm = this.MainForm;


                //myForm.Caption = "작업표준서";
                myForm.Start(); //시작함수를 실행한다.
                //myForm.OnFncQuery(); //조회함

                
                DialogResult dResult = myForm.ShowDialog();//화면에 표시

                if (dResult == DialogResult.OK)
                {

                    DBQuery();
                }
            }

        }

        private void btn_DailyCheck_ButtonClick(object sender, EventArgs e)
        {
            POP_P9001PA2 myForm = new POP_P9001PA2();

            //파라메터를 설정한다.

            DataTable dt = new DataTable("PassData");
            dt.Columns.Add("UNIT_CD");
            dt.Columns.Add("PLANT_CD");
            dt.Columns.Add("WC_MGR");
            dt.Columns.Add("FACILITY_CD");
            dt.Columns.Add("WORKER_CD");



            dt.Rows.Add();

            dt.Rows[0]["UNIT_CD"] = sUNIT_CD;
            dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
            dt.Rows[0]["WC_MGR"] = sWC_MGR;
            dt.Rows[0]["FACILITY_CD"] = sFACILITY_CD;
            dt.Rows[0]["WORKER_CD"] = sWORKER_CD;


            myForm.ResultData.Tables.Add(dt); //변수전달


            myForm.MainForm = this.MainForm;


            //myForm.Caption = "작업표준서";
            myForm.Start(); //시작함수를 실행한다.
            //myForm.OnFncQuery(); //조회함

            myForm.ShowDialog(); //화면에 표시

        }

        private void Grid1_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
        }

        private void btn_DailyCheck_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
        }

        private void btn_Query_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
        }

        private void btn_Next_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
        }

        private void btn_Before_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
        }

        private void btn_Unwork_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
        }

        private void btn_WorkStart_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
        }

        private void btn_StandardSheet_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
        }

        private void btn_WorkOrder_Info_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
        }

        private void opn_ITEM_CD_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
        }

        private void cboWorker_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
        }

        private void cboFacility_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
        }

        private void tCheckBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
        }

        private void APP_P1001M1_Resize(object sender, EventArgs e)
        {
            TGSClass.Util.Grid_Resize(Grid1);
        }

        private void opn_ITEM_CD_Enter(object sender, EventArgs e)
        {
            //opn_ITEM_CD.BorderBackColor = Color.Yellow;
        }

        private void opn_ITEM_CD_Leave(object sender, EventArgs e)
        {
            //opn_ITEM_CD.BorderBackColor = Color.White;
        }




        private void Show_WK_ORDER_ROUT(string pWK_ORD_NO)  //작업지시 또는 제조오더의 공정별 작업지시 정보를 조회 함
        {
            if (pWK_ORD_NO != "")
            {
                MES_SYS_B00.POP_B0007P1 myForm = new MES_SYS_B00.POP_B0007P1();

                //파라메터를 설정한다.

                DataTable dt = new DataTable("PassData");
                dt.Columns.Add("PLANT_CD");
                dt.Columns.Add("WK_ORD_NO");



                dt.Rows.Add();

                dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
                dt.Rows[0]["WK_ORD_NO"] = pWK_ORD_NO;


                myForm.ResultData.Tables.Add(dt); //변수전달


                myForm.MainForm = this.MainForm;


                //myForm.Caption = "작업표준서";
                myForm.Start(); //시작함수를 실행한다.
                //myForm.OnFncQuery(); //조회함


                myForm.ShowDialog();//화면에 표시


            }
        }

        private void tCheckBox2_CheckedChange(object sender, EventArgs e)
        {


            int vViewCount = 0;
            for (int i = 0; i < Grid1.Rows.Count; i++)
            {
                if (Grid1.Rows[i].Cells[grid1_COLUMN.STATUS].Value.ToString().Trim() == "")  //작업상태
                {
                    if (Grid1.Rows[i].Cells[grid1_COLUMN.BEFORE_WORK_FLAG].Value.ToString() != "") //전공정 실적이 부족한 경우
                    {
                        //if (tCheckBox2.ValueChar == "Y")    //전공정 실적 부족 분 표시가 y이면
                        //{
                        //    Grid1.Rows[i].Visible = true;
                        //    vViewCount = vViewCount + 1;
                        //}
                        //else
                        //{
                        //    Grid1.Rows[i].Visible = false;
                        //}
                    }
                    else
                    {
                        Grid1.Rows[i].Visible = true;
                        vViewCount = vViewCount + 1;
                    }
                }

            }

            //lblWROrderCount.Text = vViewCount.ToString("#,##0") + " 건";

            //if (tCheckBox1.ValueChar == "N")
            //{
            //    Grid1.Columns[grid1_COLUMN.WK_FACILITY_NM].Visible = false;

            //}
            //else
            //{
            //    Grid1.Columns[grid1_COLUMN.WK_FACILITY_NM].Visible = true;

            //}

            int vFirstRowIndex = GetFirstRowIndex(Grid1, 0);
            if (vFirstRowIndex >= 0)
            {
                Grid1.FirstDisplayedScrollingRowIndex = vFirstRowIndex;
                Grid1.Rows[vFirstRowIndex].Selected = true;
            }

        }

        private void Grid1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            decimal v_MiWorkQty;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (Grid1.Columns[e.ColumnIndex].Name == grid1_COLUMN.PROD_QTY)
                {

                    v_MiWorkQty = Convert.ToDecimal(Grid1.Rows[e.RowIndex].Cells[grid1_COLUMN.WK_ORD_QTY].Value) - Convert.ToDecimal(Grid1.Rows[e.RowIndex].Cells[grid1_COLUMN.PROD_QTY].Value);
                    if (v_MiWorkQty < 0) v_MiWorkQty = 0;
                    

                    
                    Rectangle rect = this.Grid1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                    
                    //lblMiWorkQty.Left = Grid1.Left + rect.Location.X + rect.Width;
                    //lblMiWorkQty.Top = Grid1.Top + rect.Location.Y + rect.Height;
                    
                    
                    //lblMiWorkQty.Value = "잔량 : " + v_MiWorkQty.ToString("N0");
                    //lblMiWorkQty.Visible = true;
                }
            }
        }

        private void Grid1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid1.Columns[e.ColumnIndex].Name == grid1_COLUMN.PROD_QTY)
            {
                //lblMiWorkQty.Visible = false;
            }
        }

        private void lbl_WorkCenterNm_Click(object sender, EventArgs e)
        {

        }

        private void tLabel2_Click(object sender, EventArgs e)
        {

        }

        private void tLabel17_Click(object sender, EventArgs e)
        {

        }

        private void tLabel18_Click(object sender, EventArgs e)
        {

        }

        private void tLabel7_Click(object sender, EventArgs e)
        {

        }

        private void tLabel9_Click(object sender, EventArgs e)
        {

        }

        private void tLabel29_Click(object sender, EventArgs e)
        {

        }

        private void tLabel15_Click(object sender, EventArgs e)
        {

        }

        private void tLabel24_Click(object sender, EventArgs e)
        {

        }

        private void tLabel3_Click(object sender, EventArgs e)
        {

        }

        private void tLabel21_Click(object sender, EventArgs e)
        {

        }

        private void tLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tLabel8_Click(object sender, EventArgs e)
        {

        }

        private void tLabel11_Click(object sender, EventArgs e)
        {

        }

        private void tLabel20_Click(object sender, EventArgs e)
        {

        }

        private void tLabel31_Click(object sender, EventArgs e)
        {

        }

        private void tLabel32_Click(object sender, EventArgs e)
        {

        }

        private void tLabel6_Click(object sender, EventArgs e)
        {

        }
    }

}
