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
    public partial class APP_P6001MA1: UserControl
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
        public event CommandRunEventHandler CommandRuned;



        public struct GetValueName
        {
            public const string PLANT_CD = "PLANT_CD";
            public const string ITEM_CD = "ITEM_CD";
        }
        public struct SetValueName
        {
            public const string PLANT_CD = "PLANT_CD";
            public const string WC_MGR = "WC_MGR";
            public const string WC_MGR_NM = "WC_MGR_NM";

            public const string WC_CD = "WC_CD";
            public const string WC_NM = "WC_NM";

            public const string FACILITY_CD = "FACILITY_CD";
            public const string ITEM_CD = "ITEM_CD";

            public const string WORKER_ID = "WORKER_ID";
            
        }
      
        public struct grid1_COLUMN
        {
            public const string ITEM_CD = "ITEM_CD";  //품번
            public const string ITEM_NM = "ITEM_NM";  //품목
            public const string REAL_START_DT = "REAL_START_DT";  //착수시각
            public const string REAL_END_DT = "REAL_END_DT";      //종료시각
            //public const string PROD_QTY = "PROD_QTY";            //생산수량
            public const string GOOD_QTY = "GOOD_QTY";            //양품수량
            public const string BAD_QTY = "BAD_QTY";              //불량품수량
            public const string RESULT_NO = "RESULT_NO";          //실적번호
            public const string WK_ORD_NO = "WK_ORD_NO";          //지시번호

        }

        public struct grid2_COLUMN
        {
            public const string CHECKFLAG = "CHKFLAG";
            public const string REAL_END_DT = "REAL_END_DT";
            public const string LOT_NO = "LOT_NO";
            public const string PROD_QTY = "PROD_QTY";
            public const string GOOD_QTY = "GOOD_QTY";
            public const string BAD_QTY = "BAD_QTY";
            public const string WORKER_ID = "WORKER_ID";
            public const string WORKER_NM = "WORKER_NM";
            public const string SL_NM = "SL_NM";
            public const string RESULT_NO = "RESULT_NO";
            public const string RESULT_SEQ = "RESULT_SEQ";
            public const string TOP_LOT_NO = "TOP_LOT_NO";
            public const string REASON_NM = "REASON_NM";

        }

        public struct barcode_COLUMN
        {

            //public const string LOC_NO = "LOC_NO";
            public const string LOT_NO = "LOT_NO";
            public const string ITEM_CD = "ITEM_CD";
            public const string ITEM_NM = "ITEM_NM";
            public const string PROD_QTY = "PROD_QTY";
            public const string BAD_QTY = "BAD_QTY";
            //public const string INV_UNIT = "INV_UNIT";
            public const string REAL_END_DT = "REAL_END_DT";
            public const string FACILITY_CD = "FACILITY_CD";
            public const string FACILITY_NM = "FACILITY_NM";
            public const string EMP_DESC = "EMP_DESC";
            public const string ERROR_NM = "ERROR_NM";
            public const string REPRINT_FLAG = "REPRINT_FLAG";
            public const string LIMIT_DT = "LIMIT_DT";

            //public const string UNIT = "UNIT";
            public const string ISSUED_CD = "ISSUED_CD";
            //public const string ITEM_ACCT_NM = "ITEM_ACCT_NM";
            //public const string BARCODE_FLAG = "BARCODE_FLAG";
            public const string WC_NM = "WC_NM";
            

        }

        

        #endregion

        #region ■ 1.3. Class global variables (common) //글로벌 변수 선언


        private bool bSelectedPrinted = false;  //바코드 연속 발행여부
        ArrayList alBarcode = new ArrayList();  //바코드 출력용 배열


        Global global = new Global();
        Form sMainForm;
        bool sLoading = true;

        DataSet sResultData = new DataSet();

        int sGrid_Current_id = 1;

        string sPLANT_CD = "";      //공장
        string sWC_MGR = "";        //대공정
        string sWC_MGR_NM = "";        //대공정
        
        string sWC_CD = "";         //작업장
        string sWC_NM = "";         //작업장
        string sFACILITY_CD = "";   //설비번호 
        string sITEM_CD = "";
        string sWORKER_ID = "";
        //String sWK_ORD_NO = "";

        

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

        

        #endregion

        #endregion

        #region ▶ 2. Initialization part

        #region ■ 2.1 Constructor(common)      //생성자

        public APP_P6001MA1()
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

            
            //string WC_NM = "";
            //ProcessInform_Review(Global.workinfo.szFacilityCD, ref sWC_CD, ref WC_NM, false);   //선택된 설비의 작업장 정보

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
            if (CommandRuned != null)
                CommandRuned(this, args);

        }
        //내부에서 명령을 생성해준후 명령이벤트를 실행한다.
        private void CommandRun_Event(int index)
        {

            //DataSet vSendData = new DataSet();

            //vSendData.Tables.Add("COMMAND");


            //if (index == 0)
            //{
            //    vSendData.Tables["COMMAND"].Rows.Add("APP_RUN", "MES_APP_P50.APP_P5001M1");

            //    vSendData.Tables.Add("PassData");

            //    vSendData.Tables["PassData"].Columns.Add("PLANT_CD");
            //    vSendData.Tables["PassData"].Columns.Add("WC_MGR");
            //    vSendData.Tables["PassData"].Columns.Add("WC_CD");
            //    vSendData.Tables["PassData"].Columns.Add("FACILITY_CD");
            //    vSendData.Tables["PassData"].Columns.Add("WORKER_CD");


            //    vSendData.Tables["PassData"].Rows.Add();

            //    vSendData.Tables["PassData"].Rows[0]["PLANT_CD"] = sPLANT_CD;
            //    vSendData.Tables["PassData"].Rows[0]["WC_MGR"] = sWC_MGR;
            //    vSendData.Tables["PassData"].Rows[0]["WC_CD"] = sWC_CD;
            //    vSendData.Tables["PassData"].Rows[0]["FACILITY_CD"] = cboFacility.Value;
            //    vSendData.Tables["PassData"].Rows[0]["WORKER_CD"] = cboWorker.Value;
            //}

            //CommandRun_Event(vSendData);  //이벤트 실행
        }



        public string GetValue(string pValueName)
        {

            switch (pValueName)
            {
                case GetValueName.PLANT_CD:

                    return sPLANT_CD;
                case GetValueName.ITEM_CD:

                    //if (Grid1.CurrentRow == null)
                    //{
                    //    if (Grid1.Rows.Count > 0)
                    //    {
                    //        Grid1.Rows[0].Cells[grid1_COLUMN.ITEM_CD].Selected = true;
                    //    }
                    //}

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
                case SetValueName.PLANT_CD:

                    sPLANT_CD = pValue;
                    break;

                
                case SetValueName.WC_MGR:

                    sWC_MGR = pValue;
                    break;
                case SetValueName.WC_MGR_NM:

                    sWC_MGR_NM = pValue;
                    break;
                case SetValueName.WC_CD:

                    sWC_CD = pValue;
                    break;
                case SetValueName.WC_NM:

                    sWC_NM = pValue;
                    break;
                case SetValueName.FACILITY_CD:

                    sFACILITY_CD = pValue;
                    break;
                case SetValueName.ITEM_CD:

                    sITEM_CD = pValue;
                    break;
                case SetValueName.WORKER_ID:

                    sWORKER_ID = pValue;

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
            if (sFACILITY_CD == "") sFACILITY_CD = Global.workinfo.szFacilityCD;
            
            if (sWC_MGR == "") sWC_MGR = Global.workinfo.szProcessCD;
            if (sWC_MGR_NM == "") sWC_MGR_NM = Global.workinfo.szProcessNM;

            if (sWORKER_ID == "") sWORKER_ID = Global.workinfo.szOperatorCD;
            if (sWC_CD == "") sWC_CD = Global.workinfo.szWorkSpaceCD;
            if (sWC_NM == "") sWC_NM = Global.workinfo.szWorkSpaceNM;


            DateTime A = DateTime.Today;
            tDateTerm1.ValueFrom = A.ToString("yyyy-MM-dd");
            tDateTerm1.ValueTo = A.ToString("yyyy-MM-dd");


        }

        #endregion

        #region ■ 2.5 Gathering combo data(GatheringComboData) //콤보관련 데이타 설정

        protected void GatheringComboData()
        {
          //  Fnc_crt_combo(this.cboWorker, "", "WORKER", 0, "작업자", "작업자명", "작업자 선택");  //작업자정보조회

            //Load_Operator();  //작업자정보조회

            Load_Facility();    //설비 정보를 조회한다.

            /* 판매계획유형*/
            //Fnc_crt_combo(this.cboSP_TYPE, "S0018", "S0018", 0, "판매계획", "판매계획명", "판매계획 선택");
            /* 구분*/
           // Fnc_crt_combo(this.cboTYPE, "", "TYPE", 0, "구분", "재고구분", "재고구분 선택");
            
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

            string strData = "";

            switch (@FLAG)
            {
                //case "LOC_NO":    // 받는 적치장  대표공정의 창고만 조회 함 정렬순서가 LOC_NO DESC로 창고코드 내림차순으로 되어 있어 첫번째 창고가 99 창고로 조회 됨
                //    strSql = "EXEC DBO.XUSP_MES_P0101P1_GET_LOC ";
                //    strSql += "@PLANT_CD='" + sPLANT_CD + "',";
                //    strSql += "@WC_MGR='" + sWC_MGR + "'";

                //    pValueMember = "LOC_NO";
                //    pDisplayMember = "SL_NM";

                //    break;
                case "TYPE":    // 구분
                    strData = " SELECT RTRIM(AA.code) AS code, RTRIM(AA.name) AS name ";
                    strData += " FROM ( ";
                    strData += " SELECT  '1' AS LVL, '' AS code, '전체' AS name ";
                    strData += " UNION ALL ";
                    strData += " SELECT  '2' AS LVL, 'G' AS code, '양품' AS name ";
                    strData += " UNION ALL ";
                    strData += " SELECT  '3' AS LVL, 'B' AS code, '불량' AS name ";
                    strData += " ) AS AA ";
                    strData += " ORDER BY LVL ";

                    pValueMember = "code";
                    pDisplayMember = "name";

                    break;
                case "WORKER":    // 작업자 
                    strData = "EXEC DBO.XUSP_MES_P3101Q1_GET_WORKER ";
                    strData += "@PLANT_CD='" + sPLANT_CD + "',";
                    strData += "@WC_MGR='" + sWC_MGR + "'";


                    pValueMember = "USER_ID";
                    pDisplayMember = "EMP_DESC";

                    break;
                case "UD_MAJOR_CD":    // 사용자정의-공통코드..
                    strData = " SELECT DISTINCT RTRIM(AA.code) AS code, RTRIM(AA.name) AS name ";
                    strData += " FROM ( ";
                    strData += " SELECT  '1' AS LVL, '' AS code, '' AS name ";
                    strData += " UNION ALL ";
                    strData += " SELECT '2' AS LVL, RTRIM(AA.UD_MINOR_CD) AS code, RTRIM(AA.UD_MINOR_NM) AS name ";
                    strData += " FROM B_USER_DEFINED_MINOR AA (NOLOCK) ";
                    strData += " WHERE RTRIM(AA.UD_MAJOR_CD) = RTRIM('" + @MAJOR_CD + "')  ) AA ";
                    strData += " WHERE AA.LVL = '2' ";
                    break;
                default:    // 공통코드..
                    strData = " SELECT DISTINCT RTRIM(AA.code) AS code, RTRIM(AA.name) AS name ";
                    strData += " FROM ( ";
                    strData += " SELECT  '1' AS LVL, '' AS code, '' AS name ";
                    strData += " UNION ALL ";
                    strData += " SELECT '2' AS LVL, RTRIM(AA.MINOR_CD) AS code, RTRIM(AA.MINOR_NM) AS name ";
                    strData += " FROM B_MINOR AA (NOLOCK) ";
                    strData += " WHERE RTRIM(AA.MAJOR_CD) = RTRIM('" + @MAJOR_CD + "')  ) AA ";
                    break;
            }
            try
            {
                int nCnt = 0;
                //strSql = WorkCode.WorkCd.SQLQUERY + strSql;
                //string strState = nsFuncUtil.FuncUtil.GetDataSql(this.MainForm, strSql, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);

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
        
        //#region ▶▶▶ 작업자정보 조회
        //private int Load_Operator()
        //{
        //    string szSendData = string.Empty;
        //    int nCnt = 0;

        //    try
        //    {
        //        LoadingForm(true);

        //        DataTable dtTmp = (DataTable)cboWorker.DataSource;
        //        if (dtTmp != null)
        //            dtTmp.Clear();

        //        // 작업자정보 가져오기
        //        szSendData = "";
        //        szSendData = WorkCode.WorkCd.OPERTOR;
        //        szSendData += Global.workinfo.szFactoryCD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
        //        szSendData += Global.workinfo.szProcessCD;

        //        DataTable dtData1 = null;
        //        dtData1 = new DataTable();

        //        string strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, szSendData, ref dtData1, ref nCnt,
        //            Global.workinfo.szServerIP,
        //            Global.workinfo.szPortNo);

        //        if (!strState.Equals("OK"))
        //        {
        //            TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2)  + "(" + this.ToString() + ")", "작업자조회" );
        //            return -1;
        //        }

        //        cboWorker.Caption = "";

                

        //        if (dtData1 != null && dtData1.Rows.Count > 0)
        //        {
        //            //this.cboWPOperator.DataMode = WinControl.SSMComboBox.DataModeEnum.Normal;
        //            this.cboWorker.DataSource = dtData1;
        //            this.cboWorker.DisplayMember = "EMP_DESC";
        //            this.cboWorker.ValueMember = "USER_ID";
        //            this.cboWorker.DisplayCaption = "작업자명";
        //            this.cboWorker.ValueCaption = "작업자ID";
        //            this.cboWorker.Caption = "작업자 선택";


        //            // 최종 작업자정보 가져오기
        //            szSendData = "";
        //            szSendData = WorkCode.WorkCd.LAST_OPERTOR;
        //            szSendData += Global.workinfo.szFacilityCD;

        //            dtData1 = null;
        //            dtData1 = new DataTable();

        //            strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, szSendData, ref dtData1, ref nCnt,
        //                Global.workinfo.szServerIP,
        //                Global.workinfo.szPortNo);

        //            if (strState.Equals("OK"))
        //            {
        //                this.cboWorker.Value = dtData1.Rows[0][0].ToString();//기본값 설정
        //            }

        //            if (cboWorker.SelectedIndex > -1)
        //            {

        //                Global.workinfo.szOperatorCD = cboWorker.Value;
        //                Global.workinfo.szOperatorNM = cboWorker.ValueName;
        //            }
        //            else
        //            {
        //                Global.workinfo.szOperatorCD = "";
        //                Global.workinfo.szOperatorNM = "";
        //            }

        //            return 0;
        //        }
        //    }
        //    catch (Exception se)
        //    {
        //        TGSControl.UsrFunction.MessageBoxErr(se.Message  + "(" + this.ToString() + ")", "작업자조회"  );
        //    }
        //    finally
        //    {
        //        LoadingForm(false);
        //    }
        //    return -1;

        //}
        //#endregion ▶▶▶ 작업자정보 조회



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
                //strSql = "";
                //strSql = WorkCode.WorkCd.FACILITY;
                //strSql += Global.workinfo.szFactoryCD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strSql += Global.workinfo.szProcessCD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strSql += Global.workinfo.szWorkSpaceCD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strSql += "";  //Mixing의 JobCode자리


                strSql = "EXEC DBO.XUSP_MESSVR_GET_FACILITY "
                           + " @PLANT_CD='" + sPLANT_CD + "',"
                           + " @WC_MGR='" + sWC_MGR + "',"
                           + " @WC_CD='" + sWC_CD + "',"
                           + " @JOB_CD='" + "" + "'";  //Mixing의 JobCode자리


                DataTable dtData1 = null;
                dtData1 = new DataTable();


                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strSql, ref dtData1, ref nCnt);

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
        //        szSendData += Global.workinfo.szFactoryCD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
        //        szSendData += Global.workinfo.szProcessCD;

        //        DataTable dtData1 = null;
        //        dtData1 = new DataTable();

        //        string strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, szSendData, ref dtData1, ref nCnt,
        //            Global.workinfo.szServerIP,
        //            Global.workinfo.szPortNo);

        //        if (!strState.Equals("OK"))
        //        {
        //            TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "작업장조회");
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
        //        TGSControl.UsrFunction.MessageBoxErr(se.Message, "작업장조회");
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
            InitSpreadSheet(2);
        }

        private void InitSpreadSheet(int p_GridIndex)   //선택된 스프레드시트를 초기화 한다.
        {


            if (p_GridIndex == 1)
            {

                #region ■■ 3.1.1 Pre-setting grid information

                
                /*** grid1
                 *  실적조회
                 * **/
                //Grid1.Columns.Clear();

                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("맑은 고딕", 13);
                //columnHeaderStyle.Font = new Font("맑은 고딕", 12, FontStyle.Bold);
                //Grid1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                //Grid1.RowHeadersVisible = false;
                //Grid1.AllowUserToResizeRows = false;  //행높이 변경
                //Grid1.RowTemplate.Height = 30;  //기본 행높이를 설정
                //
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.ITEM_CD, "품번", 160));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.ITEM_NM, "품명", 200));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.REAL_START_DT, "착수시각", 130));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.REAL_END_DT, "종료시각", 130));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.GOOD_QTY, "양품수량", 90));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.BAD_QTY, "불량수량", 90));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.WK_ORD_NO, "지시번호", 160));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.RESULT_NO, "실적번호", 140));


                


                #endregion


                #region ■■ 3.1.2 Formatting grid information

                //uniGrid2.flagInformation("cud_flag", "rownum");
                //uniGrid2.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.No);

                //Grid1.Columns[grid1_COLUMN.RESULT_NO_CNT].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.RESULT_NO_CNT].DefaultCellStyle.Format = "N0"; //숫자표시형태
                //Grid1.Columns[grid1_COLUMN.GOOD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.GOOD_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                //Grid1.Columns[grid1_COLUMN.BAD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.BAD_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태

                #endregion


                #region ■■ 3.1.3 Setting etc grid
                // Hidden Column Setting
                //Grid1.Columns[grid1_COLUMN.RESULT_NO].Visible = false;
               
                //Grid1.Columns[grid1_COLUMN.PRODT_ORDER_NO].Visible = false;
                //Grid1.Columns[grid1_COLUMN.OPR_NO].Visible = false;

                //Grid1.Columns[grid1_COLUMN.REAL_START_TM].Visible = false;
                //Grid1.Columns[grid1_COLUMN.REAL_END_TM].Visible = false;

                #endregion

                //TGSClass.Util.Grid_Resize(Grid1);
            }


            if (p_GridIndex == 2)
            {

                #region ■■ 3.2.1 Pre-setting grid information


                /*** grid1
                 *  실적조회
                 * **/
                
                Grid2.Columns.Clear();

                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("맑은 고딕", 13);
                //columnHeaderStyle.Font = new Font("맑은 고딕", 12, FontStyle.Bold);
                Grid2.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                Grid2.RowHeadersVisible = false;
                Grid2.AllowUserToResizeRows = false;  //행높이 변경
                Grid2.RowTemplate.Height = 30;  //기본 행높이를 설정

                Grid2.Columns.Add(SetColumnImage(grid2_COLUMN.CHECKFLAG, "√", 40));    //이미지형태의 그리드
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.REAL_END_DT, "완료시각", 140));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.LOT_NO, "Lot_No", 160));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.PROD_QTY, "생산량", 0));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.GOOD_QTY, "양품수량", 100));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.BAD_QTY, "불량수량", 100));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.WORKER_NM, "작업자", 80));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.SL_NM, "입고창고", 120));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.RESULT_NO, "실적번호", 110));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.RESULT_SEQ, "실적순번", 70));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.WORKER_ID, "작업자", 0));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.TOP_LOT_NO, "최상위롯트번호", 0));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.REASON_NM, "불량사유", 110));
                #endregion
                

                #region ■■ 3.2.2 Formatting grid information

                //uniGrid2.flagInformation("cud_flag", "rownum");
                //uniGrid2.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.No);

                //Grid1.Columns[grid1_COLUMN.RESULT_NO_CNT].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.RESULT_NO_CNT].DefaultCellStyle.Format = "N0"; //숫자표시형태
                Grid2.Columns[grid2_COLUMN.PROD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid2.Columns[grid2_COLUMN.PROD_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                Grid2.Columns[grid2_COLUMN.GOOD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid2.Columns[grid2_COLUMN.GOOD_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                Grid2.Columns[grid2_COLUMN.BAD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid2.Columns[grid2_COLUMN.BAD_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태

                #endregion

                

                #region ■■ 3.2.3 Setting etc grid
                // Hidden Column Setting
                Grid2.Columns[grid2_COLUMN.RESULT_NO].Visible = false;
                Grid2.Columns[grid2_COLUMN.PROD_QTY].Visible = false;
                Grid2.Columns[grid2_COLUMN.WORKER_ID].Visible = false;
                Grid2.Columns[grid2_COLUMN.TOP_LOT_NO].Visible = false;

                #endregion

                TGSClass.Util.Grid_Resize(Grid2);
            }
        }


        #endregion

        #region ■ 3.2 InitData

        public void InitData()
        {
            // TO-DO: 컨트롤을 초기화(또는 초기값)할때 할일 
            // SetDefaultVal과의 차이점은 전자는 Form_Load 시점에 콘트롤에 초기값을 세팅하는것이고
            // 후자는 특정 시점(조회후 또는 행추가후 등 특정이벤트)에서 초기값을 셋팅한다.


            //DateTime A = DateTime.Today;
            //tDateTerm1.ValueFrom = A.ToString("yyyy-MM-dd");
            //tDateTerm1.ValueTo = A.ToString("yyyy-MM-dd");
            
            //작업일자 조회
            tDateTerm1.ValueFrom_Datetime = DBQuery_WK_DT();
            tDateTerm1.ValueTo_Datetime = tDateTerm1.ValueFrom_Datetime;
            

            //opn_ITEM_CD.Value = sITEM_CD;
            

            if (cboFacility.Value != sFACILITY_CD)
            {

                cboFacility.Value = sFACILITY_CD;

                if (cboFacility.SelectedIndex == -1)    //콤보에 해당 설비가 없을 경우 설비정보를 다시 조회 함
                {
                    Load_Facility();    //설비 정보를 조회한다.

                    cboFacility.Value = sFACILITY_CD;
                }
            }


           // cboWorker.Value = sWORKER_ID; //작업자

            //if (sWC_MGR == "30")    //성형은 실적 삭제안되게 수정 2016-12-02 이동환 향후 사용하기위해 아래 구문만 삭제하면 됨
            //{
            //    btn_RESULT_CANCEL.Visible = false;
            //    btn_Bad_Qty_Insert.Visible = false;
            //}
            //else
            //{
            //    btn_RESULT_CANCEL.Visible = true;
            //    btn_Bad_Qty_Insert.Visible = true;
            //}

                sLoading = false;   //로딩완료
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
        #endregion

        #endregion


        #region ■ 4.4 Db function group
       
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



        #region ■■ 4.4.1 DBQuery(Common)

        private bool DBQuery()
        {
            DBQuery_WorkPackingList();    //작업지시현황을 조회 
            return true;
        }


        //SQL QUERY를 직접실행하는 구문 예제 , SQL QUERY 또는 프로시저를 TEXT 형태로 넘겨서 실행할 경우
        private void DBQuery_WorkPackingList() //품목의 거래처별 포장대기자재 조회
        {
            if (sPLANT_CD == "") return ;

            int nCnt = 0;
            try
            {
                //LoadingForm(true);
                //Grid1.DataSource = null;
               // Grid1.Rows.Clear();


                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MES_P3101Q1_GET_GONGJUNG @PLANT_CD='" + sPLANT_CD + "', ";
                strData += "@WK_DT_FR = '" + tDateTerm1.ValueFrom + "',";
                strData += "@WK_DT_TO = '" + tDateTerm1.ValueTo + "',";
                strData += "@FACILITY_CD='" + sFACILITY_CD + "',";
                //strData += "@ITEM_CD='" + opn_ITEM_CD.Value + "',";
                //strData += "@WORKER_CD='" + cboWorker.Value + "',";
                strData += "@WC_MGR='" + sWC_MGR + "', ";
                //strData += "@TYPE='" + cboTYPE.Value + "'";

                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);

                //string strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (@strState.Equals("OK") == false)
                { 
                    MessageBox.Show((strState.Substring(2)));

                    //TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "포장대기 자재 조회");
                    return;
                }

                if (dtData1 != null)
                {
                    //Grid1.DataSource = dtData1;

                    for (int i = 0; i < dtData1.Rows.Count; i++)
                    {

                        //Grid1.Rows.Add();

                        //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.TYPE_NM, "구분", 80));
                        //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.LOT_NO, "롯트", 130));
                        //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.ITEM_CD, "품번", 130));
                        //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.ITEM_NM, "품명", 160));
                        //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.GOOD_QTY, "수량", 90));
                        //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.INV_UNIT, "단위", 50));
                        //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.LOT_QTY, "재고량", 90));


                        //Grid1.Rows[i].Cells[grid1_COLUMN.ITEM_CD].Value = dtData1.Rows[i][grid1_COLUMN.ITEM_CD].ToString(); //품번 
                        //Grid1.Rows[i].Cells[grid1_COLUMN.ITEM_NM].Value = dtData1.Rows[i][grid1_COLUMN.ITEM_NM].ToString(); //품명
                        //Grid1.Rows[i].Cells[grid1_COLUMN.REAL_START_DT].Value = dtData1.Rows[i][grid1_COLUMN.REAL_START_DT].ToString(); //착수일자
                        //Grid1.Rows[i].Cells[grid1_COLUMN.REAL_END_DT].Value = dtData1.Rows[i][grid1_COLUMN.REAL_END_DT].ToString(); //종료일자
                        //Grid1.Rows[i].Cells[grid1_COLUMN.GOOD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.GOOD_QTY].ToString()).ToString("N0"); //생산량
                        //Grid1.Rows[i].Cells[grid1_COLUMN.BAD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.BAD_QTY].ToString()).ToString("N0"); //생산량
                        //Grid1.Rows[i].Cells[grid1_COLUMN.WK_ORD_NO].Value = dtData1.Rows[i][grid1_COLUMN.WK_ORD_NO].ToString(); //지시번호
                        //Grid1.Rows[i].Cells[grid1_COLUMN.RESULT_NO].Value = dtData1.Rows[i][grid1_COLUMN.RESULT_NO].ToString(); //실적번호



                    }

                    if (dtData1.Rows.Count > 0)
                    {
                      //  Grid1.Rows[0].Cells[grid1_COLUMN.ITEM_CD].Selected = true;
                    }


                }
                
               // Grid1_CellClick(Grid1, null);


            }
            catch (Exception e)
            {
                TGSControl.UsrFunction.MessageBoxErr(e.Message, "성형 공정별 조회");
            }
            finally
            {
                //LoadingForm(false);
            }
        }



        private void DBQuery_lot_no(string p_RESUIT_NO) //품목의 거래처별 포장대기자재 조회
        {
            int nCnt = 0;
            try
            {
                //LoadingForm(true);
                

                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MES_P3101Q1_GET_LOT_NO @PLANT_CD='" + sPLANT_CD + "', ";
                strData += "@RESULT_NO = '" + p_RESUIT_NO + "', ";
                //strData += "@TYPE='" + cboTYPE.Value + "'";

                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);
                
                if (@strState.Equals("OK") == false)
                {
                    MessageBox.Show((strState.Substring(2)));

                    //TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "포장대기 자재 조회");
                    return;
                }


                System.Drawing.Image imgChecked = Properties.Resources.CheckBoxUnChecked;
                imgChecked.Tag = "N";


                Grid2.Rows.Clear(); 

                if (dtData1 != null)
                {
                    //Grid1.DataSource = dtData1;

                    for (int i = 0; i < dtData1.Rows.Count; i++)
                    {

                        Grid2.Rows.Add();

                        imgChecked = Properties.Resources.CheckBoxUnChecked;
                        imgChecked.Tag = "N";
                        Grid2.Rows[i].Cells[grid2_COLUMN.CHECKFLAG].Value = imgChecked; //1.체크 

                        Grid2.Rows[i].Cells[grid2_COLUMN.REAL_END_DT].Value = dtData1.Rows[i][grid2_COLUMN.REAL_END_DT].ToString(); //완료시간
                        Grid2.Rows[i].Cells[grid2_COLUMN.LOT_NO].Value = dtData1.Rows[i][grid2_COLUMN.LOT_NO].ToString(); //LOT_NO 
                        Grid2.Rows[i].Cells[grid2_COLUMN.PROD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid2_COLUMN.PROD_QTY].ToString()).ToString("N0"); //생산수량
                        Grid2.Rows[i].Cells[grid2_COLUMN.GOOD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid2_COLUMN.GOOD_QTY].ToString()).ToString("N0"); //양품수량
                        Grid2.Rows[i].Cells[grid2_COLUMN.BAD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid2_COLUMN.BAD_QTY].ToString()).ToString ("N0"); //불량수량
                        Grid2.Rows[i].Cells[grid2_COLUMN.WORKER_NM].Value = dtData1.Rows[i][grid2_COLUMN.WORKER_NM].ToString(); //작업자
                        Grid2.Rows[i].Cells[grid2_COLUMN.SL_NM].Value = dtData1.Rows[i][grid2_COLUMN.SL_NM].ToString(); //입고창고
                        Grid2.Rows[i].Cells[grid2_COLUMN.RESULT_NO].Value = dtData1.Rows[i][grid2_COLUMN.RESULT_NO].ToString(); //실적번호
                        Grid2.Rows[i].Cells[grid2_COLUMN.RESULT_SEQ].Value = dtData1.Rows[i][grid2_COLUMN.RESULT_SEQ].ToString(); //실적순번
                        Grid2.Rows[i].Cells[grid2_COLUMN.WORKER_ID].Value = dtData1.Rows[i][grid2_COLUMN.WORKER_ID].ToString(); //작업자
                        Grid2.Rows[i].Cells[grid2_COLUMN.TOP_LOT_NO].Value = dtData1.Rows[i][grid2_COLUMN.TOP_LOT_NO].ToString(); //TOP_LOT_NO 
                        Grid2.Rows[i].Cells[grid2_COLUMN.REASON_NM].Value = dtData1.Rows[i][grid2_COLUMN.REASON_NM].ToString(); //REASON_NM 


                        //해당 제조오더의 마지막 공정실적 LOT번호와 비교해서 동일하면 수정여부 표시
                        if (Grid2.Rows[i].Cells[grid2_COLUMN.LOT_NO].Value.ToString().ToUpper() == Grid2.Rows[i].Cells[grid2_COLUMN.TOP_LOT_NO].Value.ToString().ToUpper())
                        {
                            Grid2.Rows[i].Cells[grid2_COLUMN.REAL_END_DT].Style.ForeColor = Color.Blue;
                            Grid2.Rows[i].Cells[grid2_COLUMN.LOT_NO].Style.ForeColor = Color.Blue;
                            Grid2.Rows[i].Cells[grid2_COLUMN.GOOD_QTY].Style.ForeColor = Color.Blue;
                            Grid2.Rows[i].Cells[grid2_COLUMN.BAD_QTY].Style.ForeColor = Color.Blue;
                            Grid2.Rows[i].Cells[grid2_COLUMN.WORKER_NM].Style.ForeColor = Color.Blue;
                            Grid2.Rows[i].Cells[grid2_COLUMN.SL_NM].Style.ForeColor = Color.Blue;
                            Grid2.Rows[i].Cells[grid2_COLUMN.RESULT_SEQ].Style.ForeColor = Color.Blue;

                            Grid2.Rows[i].Cells[grid2_COLUMN.REAL_END_DT].Style.BackColor = Color.YellowGreen;
                            Grid2.Rows[i].Cells[grid2_COLUMN.BAD_QTY].Style.BackColor = Color.YellowGreen;
                            Grid2.Rows[i].Cells[grid2_COLUMN.LOT_NO].Style.BackColor = Color.YellowGreen;
                            Grid2.Rows[i].Cells[grid2_COLUMN.GOOD_QTY].Style.BackColor = Color.YellowGreen;
                            Grid2.Rows[i].Cells[grid2_COLUMN.BAD_QTY].Style.BackColor = Color.YellowGreen;
                            Grid2.Rows[i].Cells[grid2_COLUMN.WORKER_NM].Style.BackColor = Color.YellowGreen;
                            Grid2.Rows[i].Cells[grid2_COLUMN.SL_NM].Style.BackColor = Color.YellowGreen;
                            Grid2.Rows[i].Cells[grid2_COLUMN.RESULT_SEQ].Style.BackColor = Color.YellowGreen;

                        }

                        if (Grid2.Rows[i].Cells[grid2_COLUMN.REASON_NM].Value.ToString() != "")
                        {
                            Grid2.Rows[i].Cells[grid2_COLUMN.BAD_QTY].Style.ForeColor = Color.Red;
                            Grid2.Rows[i].Cells[grid2_COLUMN.REASON_NM].Style.ForeColor = Color.Red;

                        }

                    }


                }

                if (Grid2.Rows.Count > 0)
                {
                    Grid2.Rows[Grid2.Rows.Count - 1].Cells[grid2_COLUMN.LOT_NO].Selected = true;   //첫번째 롯트 선택


                    if (Grid2.CurrentRow != null)
                    {
                        if (Grid2.CurrentRow.Cells[grid2_COLUMN.LOT_NO].Value.ToString().ToUpper() == Grid2.CurrentRow.Cells[grid2_COLUMN.TOP_LOT_NO].Value.ToString().ToUpper())
                        {
                           // btn_RESULT_CANCEL.Visible = true;
                           // btn_Bad_Qty_Insert.Visible = true;
                        }
                        else
                        {
                           // btn_RESULT_CANCEL.Visible = false;
                          // btn_Bad_Qty_Insert.Visible = false;
                        }
                    }
                }


            }
            catch (Exception e)
            {
                TGSControl.UsrFunction.MessageBoxErr(e.Message, "");
            }
            finally
            {
                //LoadingForm(false);
            }
        }


        //SQL QUERY를 직접실행하는 구문 예제 , SQL QUERY 또는 프로시저를 TEXT 형태로 넘겨서 실행할 경우
        private DateTime DBQuery_WK_DT() //작업일자 조회
        {
            DateTime v_WK_DT = DateTime.Today;

            if (sPLANT_CD == "") return v_WK_DT;

            int nCnt = 0;
            try
            {
                

                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MESSVR_BL_WK_DT_GET ";
                strData += "@PLANT_CD='" + sPLANT_CD + "', ";
                strData += "@WC_MGR='" + sWC_MGR + "' ";
                
                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);

                //string strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (@strState.Equals("OK") == false)
                {
                    MessageBox.Show((strState.Substring(2)));

                    //TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "포장대기 자재 조회");
                    return v_WK_DT;
                }

                if (dtData1 != null)
                {
                    //Grid1.DataSource = dtData1;

                    if (dtData1.Rows.Count > 0)
                    {
                        v_WK_DT = Convert.ToDateTime(dtData1.Rows[0]["WK_DT"].ToString()); //일자

                    }
                }

            }
            catch (Exception e)
            {
                return v_WK_DT;
                //TGSControl.UsrFunction.MessageBoxErr(e.Message, "작업일 조회");
            }
            finally
            {
                //LoadingForm(false);
                
            }

            return v_WK_DT;
        }

        #endregion


        #region 설비작업장정보 조회


        private void ProcessInform_Review(string szFacilityCD, ref string szWOrkSpaceCD, ref string szWOrkSpaceNM, bool bQueryOnly) //설비의 작업장 정보 조회
        {
            string strSql = string.Empty;
            int nCnt = 0;

            try
            {
                LoadingForm(true);


                // 대표공정 가져오기
                //szSendData = "";
                //szSendData = WorkCode.WorkCd.WORKSPACE_INFORM_REVIEW;
                //szSendData += szFacilityCD;

                strSql = ""
                         + "SELECT B.WC_CD,"      //작업장코드
                         + "       B.WC_NM"      //작업장명
                         + " FROM P_RESOURCE AS A (NOLOCK) "
                         + "     INNER JOIN P_WORK_CENTER AS B (NOLOCK) ON A.EXT2_CD = B.WC_CD "
                         + " WHERE A.RESOURCE_CD = '" + szFacilityCD + "'";

                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strSql, ref dtData1, ref nCnt);
                
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
                    Global.workinfo.szWorkSpaceCD = dtData1.Rows[0]["WC_CD"].ToString();
                    Global.workinfo.szWorkSpaceNM = dtData1.Rows[0]["WC_NM"].ToString();

                    //lbl_WorkCenterNm.Caption = Global.workinfo.szWorkSpaceNM;


                    global.WorkingFileWriteAll();
                }
                else
                {
                    szWOrkSpaceCD = dtData1.Rows[0]["WC_CD"].ToString();
                    szWOrkSpaceNM = dtData1.Rows[0]["WC_NM"].ToString();
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
        #endregion 설비작업장정보 조회
        
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

        #region ▶▶▶ 생산실적 취소   //SQL QUERY를 파라메터로 넘겨서 실행하는 구문 예제, 프로시저의 OUTPUT 반환값이 있을 경우에 사용 , 프로시저에 변수명 및 값을 넘겨서  실행 후 반환값을 사용해야 하는 경우
        private bool DBDelete_Work_Result_Cancel(string @RESULT_NO, string @RESULT_SEQ) //생산실적 처리 함
        {

            int nCnt = 0;
            try
            {
                LoadingForm(true);




                string strData = WorkCode.WorkCd.SQLPROCEDURE; //프로시져 형태로 호출
                strData += "DBO.XUSP_MES_P_WORK_FINISHED_CANCEL";       //프로시져 명
                strData += Global.COLUMNS_DIV + "N" + TGSClass.nsGlobal.Global.Separation.COLUMNS;   //조회데이타가 없을 경우 'N' = nonquery 있을 경우 'Q' = query
                //일반변수 리스트
                strData += "@PLANT_CD" + Global.COLUMNS_DIV;
                strData += "@RESULT_NO" + Global.COLUMNS_DIV;
                strData += "@RESULT_SEQ" + Global.COLUMNS_DIV;
                strData += "@USER_ID" + Global.COLUMNS_DIV;
                strData += "@RTN_MSG" + TGSClass.nsGlobal.Global.Separation.COLUMNS;


                //일반변수 리스트의 형식
                strData += Global.DBVarType.VarChar + "(4)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(20)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(3)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(50)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(200) OUTPUT" + TGSClass.nsGlobal.Global.Separation.COLUMNS;

                //일반변수값 리스트
                strData += sPLANT_CD + Global.COLUMNS_DIV;
                strData += @RESULT_NO + Global.COLUMNS_DIV;
                strData += @RESULT_SEQ + Global.COLUMNS_DIV;
                strData += Global.USER_ID + Global.COLUMNS_DIV;
                strData += "" + TGSClass.nsGlobal.Global.Separation.COLUMNS;


                //OUTPUT변수 리스트 
                //strData += "@RESULT_NO" + Global.COLUMNS_DIV;
                //strData += "@RTN_MSG";
                strData += TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //OUTPUT변수 리스트 형식
                //strData += Global.DBVarType.VarChar + "(20)" + Global.COLUMNS_DIV;
                //strData += Global.DBVarType.VarChar + "(200)" + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                strData += TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //OUTPUT변수값 리스트
                //strData += "" + Global.COLUMNS_DIV;
                strData += ""; // +TGSClass.nsGlobal.Global.Separation.COLUMNS;




                ////반환테이블이 없을 경우 (OUTPUT 변수가 없을 경우)
                //string strState = nsFuncUtil.FuncUtil.ExcuteSql(MainForm, strData, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                //반환테이블이 있을 경우(파라메터가 1개 이상이면 테이블로 반환됨 (조회데이타가 있거나 OUTPUT변수가 있을 경우)

                DataTable dtData1 = null;
                dtData1 = new DataTable();
                string strState = TGSClass.DataBase.GetDataSql(this.ParentForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);

                if (!strState.Equals("OK"))
                {

                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "실적 취소 에러");
                    LoadingForm(false);
                    return false;
                }

                ////반환함
                //sRESULT_NO = dtData1.Rows[0]["@RESULT_NO"].ToString();




                //TGSControl.UsrFunction.MessageBoxInfo("실적 취소처리 되었습니다.", "취소완료");
            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxInfo(se.Message, "실적취소 중 에러");
                LoadingForm(false);
                return false;
            }
            finally
            {
                LoadingForm(false);
            }

            return true;
        }
        #endregion


        #endregion

        #region ■■ 4.4.3 DBSave(Common)

        private bool DBSave()
        {
            return true;
        }


        //#region ▶▶▶ 생산실적 처리   //SQL QUERY를 파라메터로 넘겨서 실행하는 구문 예제, 프로시저의 OUTPUT 반환값이 있을 경우에 사용 , 프로시저에 변수명 및 값을 넘겨서  실행 후 반환값을 사용해야 하는 경우
        //private bool DBSave_Work_SaveLotResult() //생산실적 처리 함
        //{

        //    int nCnt = 0;
        //    try
        //    {
        //        LoadingForm(true);

        //        //double nOrderQty = double.Parse((string)dgWorking[nCheckRow, gridWPDW12_COLUMN.WK_ORD_QTY].ToString());
        //        //if (nTotalQty > nOrderQty)
        //        //{
        //        //    TGSControl.UsrFunction.MessageBoxErr("총 출고수량이 작업지시수량을 초과하였습니다.", "작업완료");
        //        //    return;
        //        //}

        //        //   0 공장코드 plant_cd
        //        //   1 업지시번호   wk_ord_no
        //        //   2 작업장 wc_cd
        //        //   3 설비코드 facility_cd
        //        //   4 생산수량  prod_qty
        //        //   5 LOT수량
        //        //   6 작업시작일시
        //        //   7 작업구분    --공정 코드(배합만 입력 나머지 공정은 '*')
        //        //   8 작업자 user_id
        //        //   9 작업실적코드

        //        string strData = WorkCode.WorkCd.SQLPROCEDURE; //프로시져 형태로 호출
        //        strData += "DBO.XUSP_MESSVR_P5002P2_SET";       //프로시져 명
        //        strData += Global.COLUMNS_DIV + "N" + TGSClass.nsGlobal.Global.Separation.COLUMNS;   //조회데이타가 없을 경우 'N' = nonquery 있을 경우 'Q' = query
        //        //일반변수 리스트
        //        strData += "@PLANT_CD" + Global.COLUMNS_DIV;
        //        strData += "@WC_MGR" + Global.COLUMNS_DIV;
        //        strData += "@WC_CD" + Global.COLUMNS_DIV;
        //        strData += "@FACILITY_CD" + Global.COLUMNS_DIV;
        //        strData += "@WORKER_CD" + Global.COLUMNS_DIV;
        //        strData += "@ITEM_CD" + Global.COLUMNS_DIV;
        //        strData += "@PACKINT_QTY" + Global.COLUMNS_DIV;
        //        strData += "@DEEP_QTY" + TGSClass.nsGlobal.Global.Separation.COLUMNS;


        //        //일반변수 리스트의 형식
        //        strData += Global.DBVarType.VarChar + "(4)" + Global.COLUMNS_DIV;
        //        strData += Global.DBVarType.VarChar + "(7)" + Global.COLUMNS_DIV;
        //        strData += Global.DBVarType.VarChar + "(7)" + Global.COLUMNS_DIV;
        //        strData += Global.DBVarType.VarChar + "(10)" + Global.COLUMNS_DIV;
        //        strData += Global.DBVarType.VarChar + "(20)" + Global.COLUMNS_DIV;
        //        strData += Global.DBVarType.VarChar + "(18)" + Global.COLUMNS_DIV;
        //        strData += Global.DBVarType.Numeric + "(18,6)" + Global.COLUMNS_DIV;
        //        strData += Global.DBVarType.Numeric + "(18,6)" + TGSClass.nsGlobal.Global.Separation.COLUMNS;

        //        //일반변수값 리스트
        //        strData += Global.workinfo.szFactoryCD + Global.COLUMNS_DIV;
        //        strData += Global.workinfo.szProcessCD + Global.COLUMNS_DIV;
        //        strData += sWC_CD + Global.COLUMNS_DIV;
        //        strData += sFACILITY_CD + Global.COLUMNS_DIV;
        //        strData += sWORKER_CD + Global.COLUMNS_DIV;
        //        strData += lbl_ITEM_CD.Value + Global.COLUMNS_DIV;
        //        strData += lbl_WORK_QTY.Value + Global.COLUMNS_DIV;
        //        strData += lbl_DEEP_QTY.Value + TGSClass.nsGlobal.Global.Separation.COLUMNS;


        //        //OUTPUT변수 리스트 
        //        strData += "@RESULT_NO" + Global.COLUMNS_DIV;
        //        strData += "@RTN_MSG";
        //        strData += TGSClass.nsGlobal.Global.Separation.COLUMNS;
        //        //OUTPUT변수 리스트 형식
        //        strData += Global.DBVarType.VarChar + "(20)" + Global.COLUMNS_DIV;
        //        strData += Global.DBVarType.VarChar + "(200)" + TGSClass.nsGlobal.Global.Separation.COLUMNS;
        //        //OUTPUT변수값 리스트
        //        strData += "" + Global.COLUMNS_DIV;
        //        strData += ""; // +TGSClass.nsGlobal.Global.Separation.COLUMNS;




        //        ////반환테이블이 없을 경우 (OUTPUT 변수가 없을 경우)
        //        //string strState = nsFuncUtil.FuncUtil.ExcuteSql(MainForm, strData, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
        //        //반환테이블이 있을 경우(파라메터가 1개 이상이면 테이블로 반환됨 (조회데이타가 있거나 OUTPUT변수가 있을 경우)

        //        DataTable dtData1 = null;
        //        dtData1 = new DataTable();
        //        string strState = nsFuncUtil.FuncUtil.GetDataSql(this.ParentForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);

        //        if (!strState.Equals("OK"))
        //        {

        //            TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "포장 실적 저장 에러");
        //            LoadingForm(false);
        //            return false;
        //        }

        //        //실적번호를 반환함
        //        sRESULT_NO = dtData1.Rows[0]["@RESULT_NO"].ToString();




        //        TGSControl.UsrFunction.MessageBoxInfo("완료처리 되었습니다.", "작업완료");
        //    }
        //    catch (Exception se)
        //    {
        //        TGSControl.UsrFunction.MessageBoxInfo(se.Message, "작업완료 중 에러");
        //        LoadingForm(false);
        //        return false;
        //    }
        //    finally
        //    {
        //        LoadingForm(false);
        //    }

        //    return true;
        //}
        //#endregion


        #endregion

        #endregion



        

        

        


        #region ETC Function

        private void LoadingForm(bool bVisible)
        {
            Cursor.Current = (bVisible == true) ? Cursors.WaitCursor : Cursors.Default;
            //waitLoading.Visible = bVisible;
            Application.DoEvents();
        }


        private void btn_Before_ButtonClick(object sender, EventArgs e)
        {

      }


      private void btn_Next_ButtonClick(object sender, EventArgs e)
        {

      }



      #endregion ETC Function

      private void cboWorker_Click(object sender, EventArgs e)
        {
            
        }

       





        //그리드 선택을 할 경우
        //private void Grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{

        //    if (Grid1.Columns[Grid1.CurrentCell.ColumnIndex].Name == grid1_COLUMN.CHECKFLAG)
        //    {
        //        System.Drawing.Image imgCheck = (System.Drawing.Image)Grid1.CurrentRow.Cells[grid1_COLUMN.CHECKFLAG].Value;
        //        if (imgCheck.Tag.ToString() == "N")
        //        {

                    
        //            System.Drawing.Image imgChecked = Properties.Resources.CheckBoxChecked;
        //            imgChecked.Tag = "Y";

        //            Grid1.CurrentRow.Cells[grid1_COLUMN.CHECKFLAG].Value = imgChecked;

        //            sITEM_CD = Grid1.CurrentRow.Cells[grid1_COLUMN.ITEM_CD].Value.ToString();  //선택된 품번
        //        }
        //        else
        //        {
                    

        //            System.Drawing.Image imgUnChecked = Properties.Resources.CheckBoxUnChecked;
        //            imgUnChecked.Tag = "N";

        //            Grid1.CurrentRow.Cells[grid1_COLUMN.CHECKFLAG].Value = imgUnChecked;

        //            sITEM_CD = "";//선택된 품번

        //        }
        //    }
            
            
        //}

        
        


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





        //private void Work_Start()
        //{
        //    //int nCnt = 0;

        //    try
        //    {

        //        //int nCheckedRowCount = CheckedRowCount(Grid1, Grid1.Columns[grid1_COLUMN.CHECKFLAG].Index);
        //        //if (nCheckedRowCount == 0)
        //        //{
        //        //    TGSControl.UsrFunction.MessageBoxErr("작업할 데이타를 체크하세요.", "작업시작");
        //        //    return;
        //        //}

        //        //if (cboWorker.SelectedIndex < 0)
        //        //{
        //        //    TGSControl.UsrFunction.MessageBoxErr("작업자를 선택하세요.", "작업시작");
        //        //    return;
        //        //}


        //        //if (nCheckedRowCount > 1)   //1건 이상일 경우 작업시작 메시지를 띄움
        //        //{
        //        //    TGSControl.UsrFunction.MessageBoxErr(nCheckedRowCount + "건의 작업지시를 시작하겠습니다.", "체크ROW확인");
        //        //}



        //        LoadingForm(true);

                
        //        foreach(DataGridViewRow myRow in Grid1.Rows)
        //        {
        //            System.Drawing.Image imgCheck = (System.Drawing.Image)myRow.Cells[grid1_COLUMN.CHECKFLAG].Value;

        //            if (imgCheck.Tag.ToString()  == "Y")
        //            {
        //                if (myRow.Cells[grid1_COLUMN.STATUS].Value.ToString().Trim().Length > 0) 
        //                    continue;   //작업상태가 작업진행 중인 건이면 처리하지 않고 다음 for문으로 제어를 전달한다.

        //                string szSendData = WorkCode.WorkCd.WORK_START;
        //                szSendData += Global.workinfo.szFactoryCD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
        //                szSendData += Global.workinfo.szProcessCD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
        //                szSendData += Global.workinfo.szWorkSpaceCD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
        //                szSendData += Global.workinfo.szFacilityCD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
        //                szSendData += Global.workinfo.szOperatorCD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
        //                szSendData += myRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString() + TGSClass.nsGlobal.Global.Separation.COLUMNS;
        //                szSendData += "0";

        //                string strState = nsFuncUtil.FuncUtil.ExcuteSql(sMainForm , szSendData, Global.workinfo.szServerIP, Global.workinfo.szPortNo);

        //                if (!strState.Equals("OK"))
        //                {
        //                    TGSControl.UsrFunction.MessageBoxErr(myRow .Cells [grid1_COLUMN.WK_ORD_NO].Value .ToString() + " " + strState.Substring(2), "작업시작");
        //                }

        //            }
        //        }

        //        //lblWorkCenter.Caption = Global.workinfo.szWorkSpaceNM;
        //        //lblWPFacilityNM.Caption = Global.workinfo.szFacilityNM;


                
        //        //tabActualOupputs.SelectTab(TABCONTROL_NAME.WorkProcess);  //작업시작 텝으로 이동한다.

        //        //Lot_RetriveData(strState);
        //    }
        //    catch (Exception se)
        //    {
        //        TGSControl.UsrFunction.MessageBoxErr(se.Message, "작업시작");
        //    }
        //    finally
        //    {
        //        LoadingForm(false);
        //    }

        //}


        private void FuncWRWorkStart()
        {

            global.WorkingFileWriteAll();

            //내부에서 명령을 생성해준후 명령이벤트를 실행한다.
            CommandRun_Event(0);

        }
        
        
        

        private void opn_ITEM_CD_OpenPopup(object sender, EventArgs e)
        {
            
        }
        private void btnFind_ButtonClick(object sender, EventArgs e)
        {
            MES_SYS_B00.POP_ITEM myPopupForm = new MES_SYS_B00.POP_ITEM();

            DataTable dt = new DataTable("PassData");
            dt.Columns.Add("PLANT_CD");
            dt.Columns.Add("ITEM_CD");
            dt.Columns.Add("ITEM_NM");

            dt.Rows.Add();

           // dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
           // dt.Rows[0]["ITEM_CD"] = opn_ITEM_CD.Value;
           // dt.Rows[0]["ITEM_NM"] = opn_ITEM_CD.ValueName;

            myPopupForm.ResultData.Tables.Add(dt); //변수전달


            myPopupForm.MainForm = this.MainForm;
            myPopupForm.Start();

            DialogResult dResult = myPopupForm.ShowDialog();

            if (dResult == DialogResult.OK)
            {

                //품번조회 완료


          //      opn_ITEM_CD.Value = myPopupForm.ResultData.Tables["Result"].Rows[0]["ITEM_CD"].ToString();
          //      opn_ITEM_CD.ValueName = myPopupForm.ResultData.Tables["Result"].Rows[0]["ITEM_NM"].ToString();


            }

            myPopupForm.Dispose();
        }
        
        private void Grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Grid2.Rows.Clear();

         //   if (Grid1.CurrentRow == null)
                return;

         //   string strResult_No = Grid1.CurrentRow.Cells[grid1_COLUMN.RESULT_NO].Value.ToString().Trim();

         //   sITEM_CD = Grid1.CurrentRow.Cells[grid1_COLUMN.ITEM_CD].Value.ToString();  //선택된 품번

         //   if (strResult_No != "")
         //   {
         //       DBQuery_lot_no(strResult_No);
         //   }

            
        }

        private void btn_Query_ButtonClick(object sender, EventArgs e)
        {
            DBQuery();
        }
        //작업자가 선택될 경우
        private void cboWorker_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sLoading) return;
           // if (cboWorker.SelectedIndex < 0) return;

          //  sWORKER_ID = cboWorker.Value;

          //  Global.workinfo.szOperatorCD = cboWorker.Value;
          //  Global.workinfo.szOperatorNM = cboWorker.ValueName;

            global.ConfigFileWriteAll();

        }

        private void Grid1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Grid_RowMove((DataGridView)sender, e); //그리드 이동
        }

        private void Grid2_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Grid_RowMove((DataGridView)sender, e); //그리드 이동
        }

        //그리드 이동처리
        private void Grid_RowMove(DataGridView Grid, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Grid.CurrentRow != null)
                {
                    if (Grid.CurrentRow.Index > e.RowIndex)    //이전페이지
                    {
                        btn_Before_ButtonClick(null, null);
                    }
                    else if (Grid.CurrentRow.Index < e.RowIndex)   //다음페이지
                    {
                        btn_Next_ButtonClick(null, null);
                    }
                }

            }

        }

        private void btn_Bad_Qty_Insert_ButtonClick(object sender, EventArgs e)
        {

      }

      private void btn_Label_Print_ButtonClick(object sender, EventArgs e)
        {

      }



      private bool LabelPrint_Work_Lot_RetriveData(string pPLANT_CD, string pRESULT_NO, string pRESULT_SEQ, bool pClearFlag)
        {
            int nCnt = 0;


            try
            {
                LoadingForm(true);



                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MES_P3001M1_GET_LOT_RESULT ";
                strData += "@PLANT_CD='" + pPLANT_CD + "',";
                strData += "@RESULT_NO='" + pRESULT_NO + "',";
                strData += "@RESULT_SEQ='" + pRESULT_SEQ + "'";


                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);
                //string strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);

                if (!strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "LABEL LOT조회");
                    return false;
                }
                //if (dtData1 == null || dtData1.Rows.Count <= 0)
                //{
                //    LoadingForm(false);
                //    TGSControl.UsrFunction.MessageBoxErr("조회할 데이타가 존재하지 않습니다.", "LABEL LOT조회");
                //    return;
                //}


                if (pClearFlag == true)
                {
                    nCurrentIndex = 0;
                    alBarcode.Clear();
                }

                if (dtData1.Rows.Count > 0)
                {
                    for (int i = 0; i < dtData1.Rows.Count; i++)
                    {

                        DateTime dtTmp = DateTime.Parse(dtData1.Rows[i][barcode_COLUMN.REAL_END_DT].ToString());
                        Hashtable htTmp = new Hashtable();

                        htTmp.Add("LOT_NO", dtData1.Rows[i][barcode_COLUMN.LOT_NO].ToString());
                        htTmp.Add("ITEM_CD", dtData1.Rows[i][barcode_COLUMN.ITEM_CD].ToString());
                        htTmp.Add("ITEM_NM", dtData1.Rows[i][barcode_COLUMN.ITEM_NM].ToString());

                        if (dtData1.Rows[i][barcode_COLUMN.ERROR_NM].ToString() == "")
                        {
                            htTmp.Add("QTY", dtData1.Rows[i][barcode_COLUMN.PROD_QTY].ToString());
                        }
                        else
                        {
                            htTmp.Add("QTY", dtData1.Rows[i][barcode_COLUMN.BAD_QTY].ToString());
                        }

                        htTmp.Add("FACILITY_CD", dtData1.Rows[i][barcode_COLUMN.FACILITY_CD].ToString());
                        htTmp.Add("FACILITY_NM", dtData1.Rows[i][barcode_COLUMN.FACILITY_NM].ToString());
                        htTmp.Add("WORKPLACE", dtData1.Rows[i][barcode_COLUMN.WC_NM].ToString());
                        htTmp.Add("WORKDATE", dtTmp.ToString("yy-MM-dd HH:mm"));
                        htTmp.Add("ERROR_NM", dtData1.Rows[i][barcode_COLUMN.ERROR_NM].ToString());


                        dtTmp = DateTime.Parse(dtData1.Rows[i][barcode_COLUMN.LIMIT_DT].ToString());
                        htTmp.Add("VALIDDATE", dtTmp.ToString("yy-MM-dd HH:mm"));

                        //if (Global.workinfo.szProcessCD == Global.Process.PREPARE)
                        //{

                        //    //double nValidDate = ValidDate_retriveData();
                        //    double nValidDate = 14;
                        //    dtTmp = dtTmp.AddDays(nValidDate);
                        //    htTmp.Add("VALIDDATE", dtTmp.ToString("yy-MM-dd HH:mm"));
                        //}
                        //else
                        //{
                        //    //double nValidDate = ValidDate_retriveData();
                        //    double nValidDate = 14;
                        //    dtTmp = dtTmp.AddDays(nValidDate);
                        //    htTmp.Add("VALIDDATE", dtTmp.ToString("yy-MM-dd HH:mm"));
                        //}
                        htTmp.Add("OPERATOR", dtData1.Rows[i][barcode_COLUMN.EMP_DESC].ToString());
                        htTmp.Add("REPRINT_FLAG", dtData1.Rows[i][barcode_COLUMN.REPRINT_FLAG].ToString());

                        htTmp.Add("ISSUED_CD", dtData1.Rows[i][barcode_COLUMN.ISSUED_CD].ToString());

                        //if (@sWC_MGR == "20")
                        //{
                        //    htTmp.Add("UNIT", dtData1.Rows[i][barcode_COLUMN.UNIT].ToString());
                        //    htTmp.Add("ISSUED_CD", dtData1.Rows[i][barcode_COLUMN.ISSUED_CD].ToString());
                        //    htTmp.Add("ITEM_ACCT_NM", dtData1.Rows[i][barcode_COLUMN.ITEM_ACCT_NM].ToString());
                        //    htTmp.Add("BARCODE_FLAG", dtData1.Rows[i][barcode_COLUMN.BARCODE_FLAG].ToString());
                        //    htTmp.Add("LIMIT_DT", dtData1.Rows[i][barcode_COLUMN.LIMIT_DT].ToString());
                        //}
                        

                        alBarcode.Add(htTmp);


                    }
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "LABEL LOT조회");
                return false;
            }
            finally
            {
                LoadingForm(false);
            }

        }
        private void DBSave_LabelPrint(string szLotNo, string szItem_CD, string szOperator, string szWC_CD)
        {
            try
            {
                LoadingForm(true);

                //string szSendData = WorkCode.WorkCd.LABEL_PRINTOUT;

                //szSendData += sPLANT_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += szLotNo + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += szOperator + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += szItem_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += sWC_CD;

                string strData = "";

                strData += "EXEC DBO.XUSP_MESSVR_BL_LABEL_PRINTOUT ";
                strData += "@PLANT_CD='" + sPLANT_CD + "',";
                strData += "@LOT_NO='" + szLotNo + "',";
                strData += "@USER_ID='" + szOperator + "',";
                strData += "@ITEM_CD='" + szItem_CD + "',";
                strData += "@WC_CD='" + szWC_CD + "'";


                DataTable dtData = new DataTable();
                int nCnt = 0;
                string strState = TGSClass.DataBase.GetDataSql(this.MainForm, strData, ref dtData, ref nCnt);
                if (!strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "라벨출력정보저장");
                    return;
                }
            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "라벨출력정보저장");
            }
            finally
            {
                LoadingForm(false);
            }
        }
        //private void LabelPrint_Save(string szLotNo, string szItem_CD, string szOperator)
        //{
        //    try
        //    {
        //        LoadingForm(true);

        //        string szSendData = WorkCode.WorkCd.LABEL_PRINTOUT;

        //        szSendData += sPLANT_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
        //        szSendData += szLotNo + TGSClass.nsGlobal.Global.Separation.COLUMNS;
        //        szSendData += szOperator + TGSClass.nsGlobal.Global.Separation.COLUMNS;
        //        szSendData += szItem_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
        //        szSendData += sWC_CD;

        //        string strState = nsFuncUtil.FuncUtil.ExcuteSql(sMainForm, szSendData, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
        //        if (!strState.Equals("OK"))
        //        {
        //            TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "라벨출력정보저장");
        //            return;
        //        }
        //    }
        //    catch (Exception se)
        //    {
        //        TGSControl.UsrFunction.MessageBoxErr(se.Message, "라벨출력정보저장");
        //    }
        //    finally
        //    {
        //        LoadingForm(false);
        //    }
        //}


        float XGab = 0; //실질적으로 출력되는 X오차보정용
        float YGab = 0; //실질적으로 출력되는 Y오차보정용
        int nCurrentIndex = 0;
        string[] ArrayColumns = new string[] { };
        private void Barcode_Print(System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                

                Graphics g = e.Graphics;
                g.PageUnit = GraphicsUnit.Millimeter;


                Hashtable htTmp = new Hashtable();

                htTmp = (Hashtable)alBarcode[nCurrentIndex];

                //if (@sWC_MGR == "20")
                //{
                //    BarcodePrint_20(g, htTmp);  //숙성실 바코드 출력
                //}
                //else
                //{
                    BarcodePrint_1030(g, htTmp);    //준비 성형 바코드 출력
                //}




                if (bSelectedPrinted) // 연속발행이면
                {
                    nCurrentIndex++;
                }

                if (bSelectedPrinted) // 연속발행이면
                {
                    //다음 Page가 있는지 체크
                    if (nCurrentIndex >= alBarcode.Count)
                    {
                        nCurrentIndex = 0;
                        e.HasMorePages = false;
                    }
                    else
                    {
                        e.HasMorePages = true;
                    }
                }
                else
                {
                    nCurrentIndex = 0;
                    e.HasMorePages = false;
                }

                //}	
            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "바코드발행중");
            }
        }
        
        private void BarcodePrint_1030(Graphics g, Hashtable htTmp)
        {
            XGab = 0;
            YGab = 0;

            Font Font7b = new Font("맑은고딕", 7, System.Drawing.FontStyle.Bold);
            Font Font8b = new Font("맑은고딕", 8, System.Drawing.FontStyle.Bold);
            Font Font9b = new Font("맑은고딕", 9, System.Drawing.FontStyle.Bold);
            Font Font10b = new Font("맑은고딕", 10, System.Drawing.FontStyle.Bold);
            Font Font11b = new Font("맑은고딕", 11, System.Drawing.FontStyle.Bold);
            Font Font12b = new Font("맑은고딕", 12, System.Drawing.FontStyle.Bold);
            Font Font14b = new Font("맑은고딕", 14, System.Drawing.FontStyle.Bold);



            Brush brushBlack = new SolidBrush(Color.Black);
            Pen pen1 = new Pen(brushBlack, 0.3F);

            Brush brushBlack1 = new SolidBrush(Color.Black);
            Pen pen3 = new Pen(brushBlack1, 0.6F);

            //Font BcdFont = new Font("BC C39 2 to 1 Medium", 17);
            Font Code128 = new Font("Code 128", 30);



            if (sWC_MGR == "30")    //성형
            {

                        //Box Line
                        g.DrawRectangle(pen3, XGab + 0001.0F, YGab + 0001.0F, 0076.0F, 0014.0F); 
                        g.DrawRectangle(pen3, XGab + 0001.0F, YGab + 00015.0F, 0076.0F, 0010.0F);
                        g.DrawRectangle(pen3, XGab + 0001.0F, YGab + 00026.0F, 0076.0F, 0030.0F);

                        // 가로 라인
                        g.DrawLine(pen1, XGab + 0001.0F, YGab + 0034.0F, XGab + 0077.0F, YGab + 0034.0F);//품명 밑가로 
                        g.DrawLine(pen1, XGab + 0001.0F, YGab + 0042.0F, XGab + 0077.0F, YGab + 0042.0F);//생산일 밑 가로
                        g.DrawLine(pen1, XGab + 0001.0F, YGab + 0050.0F, XGab + 0077.0F, YGab + 0050.0F);//유효일 밑 가로

                        // 세로 라인
                        g.DrawLine(pen1, XGab + 0016.0F, YGab + 0015.0F, XGab + 0016.0F, YGab + 0025.0F);//품번 우측 세로 줄
                        g.DrawLine(pen1, XGab + 0052.0F, YGab + 0015.0F, XGab + 0052.0F, YGab + 0025.0F);//수량 좌측 세로 줄


                        g.DrawLine(pen1, XGab + 0016.0F, YGab + 0026.0F, XGab + 0016.0F, YGab + 0056.0F);

                        //성형
                        g.DrawLine(pen1, XGab + 0046.0F, YGab + 0034.0F, XGab + 0046.0F, YGab + 0050.0F); //작업자 좌측 세로 줄
                    


                        //Header
                        g.DrawString("품  번", Font10b, brushBlack, XGab + 0002.0F, YGab + 0018.0F, new StringFormat());

                        g.DrawString("품  명", Font10b, brushBlack, XGab + 0002.0F, YGab + 0028.0F, new StringFormat());
                        g.DrawString("생산일", Font10b, brushBlack, XGab + 0002.0F, YGab + 0036.0F, new StringFormat());


                        if (htTmp["ERROR_NM"].ToString() != "")
                        {
                            g.DrawString("★불량", Font10b, brushBlack, XGab + 0002.0F, YGab + 0044.0F, new StringFormat());
                        }
                        else
                        {
                            if (sWC_MGR == "30")
                            {
                                g.DrawString("작업자", Font10b, brushBlack, XGab + 0002.0F, YGab + 0044.0F, new StringFormat());
                            }
                            else
                            {
                                g.DrawString("유효일", Font10b, brushBlack, XGab + 0002.0F, YGab + 0044.0F, new StringFormat());
                            }
                        }

                        g.DrawString("자  원", Font10b, brushBlack, XGab + 0002.0F, YGab + 0051.0F, new StringFormat());



                        // g.DrawString("장비번호", Font10b, brushBlack, XGab + 0043.0F, YGab + 0028.0F, new StringFormat());
                        g.DrawString(htTmp["REPRINT_FLAG"].ToString(), Font14b, brushBlack, XGab + 0073.0F, YGab + 001.0F, new StringFormat());  //재발행여부



                        string szCode128 = "";
                        //nsCode128.Code128 bcd = new nsCode128.Code128();
                        if (!TGSClass.Code128.Get_Code128(htTmp["LOT_NO"].ToString(), ref szCode128))
                        {
                            TGSControl.UsrFunction.MessageBoxErr("Code128 체크디지트 계산중 오류발생하였습니다.", "바코드발행중");
                            return;
                        }

                        g.DrawString(szCode128, Code128, brushBlack, XGab + 008.0F, YGab + 001.0F, new StringFormat());        //LOT-NO 바코드
                        g.DrawString(htTmp["LOT_NO"].ToString(), Font9b, brushBlack, XGab + 0023F, YGab + 0011.0F, new StringFormat());       //휴먼문자

                        g.DrawString(htTmp["ITEM_CD"].ToString(), Font12b, brushBlack, XGab + 0017.0F, YGab + 00018.0F, new StringFormat());  //품번



                        g.DrawString((double.Parse(htTmp["QTY"].ToString())).ToString("###,##0").PadLeft(8, ' ') + "  EA", Font12b, brushBlack, XGab + 0052.0F, YGab + 0018.0F, new StringFormat());  //작업수량

                        if (htTmp["ISSUED_CD"].ToString() != "사내" && htTmp["ISSUED_CD"].ToString() != "샘플" && htTmp["ISSUED_CD"].ToString() != "" && htTmp["ITEM_NM"].ToString().Length > 9)
                        {
                            g.DrawString(htTmp["ITEM_NM"].ToString().Substring(0, 9), Font10b, brushBlack, XGab + 0017.0F, YGab + 00028.0F, new StringFormat());  //품명
                        }
                        else
                        {
                            g.DrawString(htTmp["ITEM_NM"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 00028.0F, new StringFormat());  //품명
                        }

                        g.DrawString(htTmp["WORKDATE"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 0036.0F, new StringFormat());  //작업일

                        if (htTmp["ERROR_NM"].ToString() != "")
                        {
                            g.DrawString(htTmp["ERROR_NM"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 0044.0F, new StringFormat());  //불량사유
                        }
                        else
                        {
                             //성형
                            g.DrawString(htTmp["OPERATOR"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 0044.0F, new StringFormat());  //유효일
                            g.DrawString(htTmp["LOT_NO"].ToString().Substring(8), Font14b, brushBlack, XGab + 0047.0F, YGab + 0044.0F, new StringFormat());   //롯트축약
                        }


                        g.DrawString(htTmp["FACILITY_CD"] + "/" + htTmp["FACILITY_NM"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 0051.0F, new StringFormat());  //장비번호

                        g.DrawString(htTmp["WORKPLACE"].ToString(), Font10b, brushBlack, XGab + 0047.0F, YGab + 0036.0F, new StringFormat());  //작업장

                        //g.DrawString(htTmp["PROCESS"].ToString(), Font10b, brushBlack, XGab + 0062.0F, YGab + 0051.0F, new StringFormat());  //완료공정


            }
            else
            {
                //성형공정 외

                        //Box Line
                        g.DrawRectangle(pen3, XGab + 0001.0F, YGab + 0001.0F, 0076.0F, 0014.0F);
                        g.DrawRectangle(pen3, XGab + 0001.0F, YGab + 00015.0F, 0076.0F, 0009.0F);
                        g.DrawRectangle(pen3, XGab + 0001.0F, YGab + 00025.0F, 0076.0F, 0027.0F);
                        //g.DrawRectangle(pen3, XGab + 0001.0F, YGab + 0001.0F, 0076.0F, 0014.0F); //2018-06-29 하단 품목바코드 추가를 위한 위치조정
                        //g.DrawRectangle(pen3, XGab + 0001.0F, YGab + 00015.0F, 0076.0F, 0010.0F);
                        //g.DrawRectangle(pen3, XGab + 0001.0F, YGab + 00026.0F, 0076.0F, 0030.0F);

                        // 가로 라인
                        g.DrawLine(pen1, XGab + 0001.0F, YGab + 0032.0F, XGab + 0077.0F, YGab + 0032.0F);//품명 밑 가로
                        g.DrawLine(pen1, XGab + 0001.0F, YGab + 0039.0F, XGab + 0077.0F, YGab + 0039.0F);//생산일 밑 가로
                        g.DrawLine(pen1, XGab + 0001.0F, YGab + 0046.0F, XGab + 0077.0F, YGab + 0046.0F);//유효일 밑 가로

                        //g.DrawLine(pen1, XGab + 0001.0F, YGab + 0034.0F, XGab + 0077.0F, YGab + 0034.0F);//품명 밑가로 //2018-06-29 하단 품목바코드 추가를 위한 위치조정
                        //g.DrawLine(pen1, XGab + 0001.0F, YGab + 0042.0F, XGab + 0077.0F, YGab + 0042.0F);//생산일 밑 가로
                        //g.DrawLine(pen1, XGab + 0001.0F, YGab + 0050.0F, XGab + 0077.0F, YGab + 0050.0F);//유효일 밑 가로

                        // 세로 라인
                        g.DrawLine(pen1, XGab + 0016.0F, YGab + 0015.0F, XGab + 0016.0F, YGab + 0024.0F);//품번 우측 세로 줄
                        g.DrawLine(pen1, XGab + 0052.0F, YGab + 0015.0F, XGab + 0052.0F, YGab + 0024.0F);//수량 좌측 세로 줄
                        //g.DrawLine(pen1, XGab + 0016.0F, YGab + 0015.0F, XGab + 0016.0F, YGab + 0025.0F);//품번 우측 세로 줄 //2018-06-29 하단 품목바코드 추가를 위한 위치조정
                        //g.DrawLine(pen1, XGab + 0052.0F, YGab + 0015.0F, XGab + 0052.0F, YGab + 0025.0F);//수량 좌측 세로 줄


                        g.DrawLine(pen1, XGab + 0016.0F, YGab + 0025.0F, XGab + 0016.0F, YGab + 0052.0F); //품명 우측 세로 줄
                        //g.DrawLine(pen1, XGab + 0016.0F, YGab + 0026.0F, XGab + 0016.0F, YGab + 0056.0F); //2018-06-29 하단 품목바코드 추가를 위한 위치조정

                        if (sWC_MGR != "30")
                        {
                            g.DrawLine(pen1, XGab + 0046.0F, YGab + 0032.0F, XGab + 0046.0F, YGab + 0046.0F); //작업자 좌측 세로 줄
                        }


                        //Header
                        g.DrawString("품  번", Font10b, brushBlack, XGab + 0002.0F, YGab + 0017.5F, new StringFormat());

                        g.DrawString("품  명", Font10b, brushBlack, XGab + 0002.0F, YGab + 0027.0F, new StringFormat());
                        g.DrawString("생산일", Font10b, brushBlack, XGab + 0002.0F, YGab + 0034.0F, new StringFormat());


                        if (htTmp["ERROR_NM"].ToString() != "")
                        {
                            g.DrawString("★불량", Font10b, brushBlack, XGab + 0002.0F, YGab + 0041.0F, new StringFormat());
                        }
                        else
                        {
                            if (sWC_MGR == "30")
                            {
                                g.DrawString("작업자", Font10b, brushBlack, XGab + 0002.0F, YGab + 0041.0F, new StringFormat());
                            }
                            else
                            {
                                g.DrawString("유효일", Font10b, brushBlack, XGab + 0002.0F, YGab + 0041.0F, new StringFormat());
                            }
                        }

                        g.DrawString("자  원", Font10b, brushBlack, XGab + 0002.0F, YGab + 0047.0F, new StringFormat());



                        // g.DrawString("장비번호", Font10b, brushBlack, XGab + 0043.0F, YGab + 0028.0F, new StringFormat());
                        g.DrawString(htTmp["REPRINT_FLAG"].ToString(), Font14b, brushBlack, XGab + 0073.0F, YGab + 001.0F, new StringFormat());  //재발행여부



                        string szCode128 = "";
                        
                        if (!TGSClass.Code128.Get_Code128(htTmp["LOT_NO"].ToString(), ref szCode128))
                        {
                            TGSControl.UsrFunction.MessageBoxErr("Code128 체크디지트 계산중 오류발생하였습니다.", "바코드발행중");
                            return;
                        }

                        g.DrawString(szCode128, Code128, brushBlack, XGab + 008.0F, YGab + 001.0F, new StringFormat());        //LOT-NO 바코드
                        g.DrawString(htTmp["LOT_NO"].ToString(), Font9b, brushBlack, XGab + 0023F, YGab + 0011.0F, new StringFormat());       //휴먼문자

                        g.DrawString(htTmp["ITEM_CD"].ToString(), Font12b, brushBlack, XGab + 0017.0F, YGab + 00017.5F, new StringFormat());  //품번



                        g.DrawString((double.Parse(htTmp["QTY"].ToString())).ToString("###,##0").PadLeft(8, ' ') + "  EA", Font12b, brushBlack, XGab + 0052.0F, YGab + 0017.5F, new StringFormat());  //작업수량

                        if (htTmp["ISSUED_CD"].ToString() != "사내" && htTmp["ISSUED_CD"].ToString() != "샘플" && htTmp["ISSUED_CD"].ToString() != "" && htTmp["ITEM_NM"].ToString().Length > 9)
                        {
                            g.DrawString(htTmp["ITEM_NM"].ToString().Substring(0, 9), Font10b, brushBlack, XGab + 0017.0F, YGab + 00027.0F, new StringFormat());  //품명
                        }
                        else
                        {
                            g.DrawString(htTmp["ITEM_NM"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 00027.0F, new StringFormat());  //품명
                        }

                        g.DrawString(htTmp["WORKDATE"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 0034.0F, new StringFormat());  //작업일

                        if (htTmp["ERROR_NM"].ToString() != "")
                        {
                            g.DrawString(htTmp["ERROR_NM"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 0041.0F, new StringFormat());  //불량사유
                        }
                        else
                        {
                            if (sWC_MGR == "30")    //성형
                            {
                                g.DrawString(htTmp["OPERATOR"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 0041.0F, new StringFormat());  //유효일
                                g.DrawString(htTmp["LOT_NO"].ToString().Substring(8), Font14b, brushBlack, XGab + 0047.0F, YGab + 0041.0F, new StringFormat());   //롯트축약
                            }
                            else
                            {   //준비
                                g.DrawString(htTmp["VALIDDATE"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 0041.0F, new StringFormat());  //유효일
                                g.DrawString(htTmp["OPERATOR"].ToString(), Font10b, brushBlack, XGab + 0047.0F, YGab + 0041.0F, new StringFormat());   //작업자명


                                if (htTmp["ISSUED_CD"].ToString() != "사내" && htTmp["ISSUED_CD"].ToString() != "샘플" && htTmp["ISSUED_CD"].ToString() != "")
                                {
                                    if (htTmp["ISSUED_CD"].ToString().Length > 7)
                                    {
                                        g.DrawString(htTmp["ISSUED_CD"].ToString().Substring(0, 7), Font10b, brushBlack, XGab + 0047.0F, YGab + 0027.0F, new StringFormat());  //출고처
                                    }
                                    else
                                    {
                                        g.DrawString(htTmp["ISSUED_CD"].ToString(), Font10b, brushBlack, XGab + 0047.0F, YGab + 0027.0F, new StringFormat());  //출고처
                                    }
                                    g.DrawLine(pen1, XGab + 0046.0F, YGab + 0026.0F, XGab + 0046.0F, YGab + 0032.0F);
                                }
                                else
                                {
                                    if (htTmp["ITEM_NM"].ToString().Length < 11)
                                    {
                                        g.DrawString(htTmp["LOT_NO"].ToString().Substring(8), Font14b, brushBlack, XGab + 0054.0F, YGab + 0027.0F, new StringFormat());   //롯트축약
                                    }
                                }

                            }

                        }


                        g.DrawString(htTmp["WORKPLACE"].ToString(), Font10b, brushBlack, XGab + 0047.0F, YGab + 0034.0F, new StringFormat());  //작업장
                        g.DrawString(htTmp["FACILITY_CD"] + "/" + htTmp["FACILITY_NM"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 0047.0F, new StringFormat());  //장비번호


                        //g.DrawString(htTmp["PROCESS"].ToString(), Font10b, brushBlack, XGab + 0062.0F, YGab + 0051.0F, new StringFormat());  //완료공정


                        if (sWC_MGR == "10")//2018-06-08    이동환 준비공정 바코드 일 경우 하단에 품목코드 바코드 출력
                        {
                            if (!TGSClass.Code128.Get_Code128(htTmp["ITEM_CD"].ToString(), ref szCode128))
                            {
                                TGSControl.UsrFunction.MessageBoxErr("Code128 체크디지트 계산중 오류발생하였습니다.", "품번 바코드");
                                return;
                            }

                            g.DrawString(szCode128, Code128, brushBlack, XGab + 008.0F, YGab + 051.5F, new StringFormat());        //품번 바코드
                        }

            }

            DBSave_LabelPrint(htTmp["LOT_NO"].ToString(),
                   htTmp["ITEM_CD"].ToString(),
                   Global.workinfo.szOperatorNM,
                   sWC_CD);

        }

        //private void BarcodePrint_20(Graphics g, Hashtable htTmp)
        //{
        //    YGab = 0;

        //    Font Font7b = new Font("견고딕", 7, System.Drawing.FontStyle.Bold);
        //    Font Font8b = new Font("견고딕", 8, System.Drawing.FontStyle.Bold);
        //    Font Font9b = new Font("견고딕", 9, System.Drawing.FontStyle.Bold);
        //    Font Font10b = new Font("견고딕", 10, System.Drawing.FontStyle.Bold);
        //    Font Font11b = new Font("견고딕", 11, System.Drawing.FontStyle.Bold);
        //    Font Font13b = new Font("견고딕", 13, System.Drawing.FontStyle.Bold);
        //    Font Font23b = new Font("견고딕", 23, System.Drawing.FontStyle.Bold);

        //    Font Ver9 = new Font("Verdana", 9);
        //    Font Ver10 = new Font("Verdana", 10);

        //    Brush brushBlack = new SolidBrush(Color.Black);
        //    Pen pen1 = new Pen(brushBlack, 0.3F);

        //    Brush brushBlack1 = new SolidBrush(Color.Black);
        //    Pen pen3 = new Pen(brushBlack1, 0.6F);

        //    //Font BcdFont = new Font("BC C39 2 to 1 Medium", 17);
        //    Font Code128_25 = new Font("Code 128", 25);
        //    Font Code128_26 = new Font("Code 128", 26);
        //    Font Code128_27 = new Font("Code 128", 27);




        //    //********************* 80 X 60 라벨지 *******************************
        //    //Box Line
        //    g.DrawRectangle(pen3, XGab + 0001.0F, YGab + 0001.0F, XGab + 0075.0F, YGab + 0031.5F);


        //    // 가로 라인
        //    g.DrawLine(pen1, XGab + 0001.0F, YGab + 0008.0F, XGab + 0076.0F, YGab + 0008.0F);
        //    g.DrawLine(pen1, XGab + 0001.0F, YGab + 0022.0F, XGab + 0076.0F, YGab + 0022.0F);
        //    g.DrawLine(pen1, XGab + 0001.0F, YGab + 0027.0F, XGab + 0076.0F, YGab + 0027.0F);




        //    // 세로 라인
        //    g.DrawLine(pen1, XGab + 0016.0F, YGab + 0001.0F, XGab + 0016.0F, YGab + 0008.0F);
        //    g.DrawLine(pen1, XGab + 0045.0F, YGab + 0001.0F, XGab + 0045.0F, YGab + 0008.0F);
        //    g.DrawLine(pen1, XGab + 0055.5F, YGab + 0001.0F, XGab + 0055.5F, YGab + 0008.0F);

        //    //g.DrawLine(pen1, XGab + 0021.0F, YGab + 0008.0F, XGab + 0021.0F, YGab + 00026.0F);
        //    g.DrawLine(pen1, XGab + 0016.0F, YGab + 0008.0F, XGab + 0016.0F, YGab + 0032.5F);

        //    //Header
        //    g.DrawString("품  번", Font10b, brushBlack, XGab + 0002.0F, YGab + 0003.0F, new StringFormat());
        //    g.DrawString("중량", Font10b, brushBlack, XGab + 0045.2F, YGab + 0003.0F, new StringFormat());


        //    g.DrawString("공  정", Font10b, brushBlack, XGab + 0002.0F, YGab + 0011.0F, new StringFormat());
        //    g.DrawString("롯  트", Font10b, brushBlack, XGab + 0002.0F, YGab + 0016.0F, new StringFormat());

        //    g.DrawString("입고일", Font9b, brushBlack, XGab + 0002.0F, YGab + 0023.0F, new StringFormat());
        //    g.DrawString("유효일", Font9b, brushBlack, XGab + 0002.0F, YGab + 0028.0F, new StringFormat());


        //    if (htTmp["ITEM_CD"].ToString().Length > 8)
        //    {
        //        g.DrawString(htTmp["ITEM_CD"].ToString().ToUpper(), Font11b, brushBlack, XGab + 0017.0F, YGab + 0002.9F, new StringFormat());  //품번
        //    }
        //    else
        //    {
        //        g.DrawString(htTmp["ITEM_CD"].ToString().ToUpper(), Font11b, brushBlack, XGab + 0018.5F, YGab + 0002.9F, new StringFormat());  //품번
        //    }

        //    if (htTmp["QTY"].ToString().Length > 5)
        //    {
        //        g.DrawString(htTmp["QTY"].ToString() + " " + htTmp["UNIT"].ToString(), Font10b, brushBlack, XGab + 0057.0F, YGab + 0003.0F, new StringFormat());  //중량
        //    }
        //    else
        //    {
        //        g.DrawString(htTmp["QTY"].ToString() + " " + htTmp["UNIT"].ToString(), Font10b, brushBlack, XGab + 0058.0F, YGab + 0003.0F, new StringFormat());  //중량
        //    }


        //    string szCode128 = "";
        //    nsCode128.Code128 bcd = new nsCode128.Code128();
        //    if (!bcd.Get_Code128(htTmp["LOT_NO"].ToString().ToUpper(), ref szCode128))
        //    {
        //        TGSControl.UsrFunction.MessageBoxErr("Code128 체크디지트 계산중 오류발생하였습니다.", "바코드발행중");
        //        return;
        //    }

        //    g.DrawString(szCode128, Code128_27, brushBlack, XGab + 0019.0F, YGab + 008.5F, new StringFormat());        //LOT-NO 바코드
        //    g.DrawString(htTmp["LOT_NO"].ToString(), Font9b, brushBlack, XGab + 0021.0F, YGab + 0018.2F, new StringFormat());       //휴먼문자

        //    g.DrawString("(" + htTmp["ITEM_ACCT_NM"].ToString() + ")", Font8b, brushBlack, XGab + 0055.0F, YGab + 0018.2F, new StringFormat());       //계정



        //    g.DrawString(htTmp["WORKDATE"].ToString(), Font10b, brushBlack, XGab + 0026.0F, YGab + 0022.5F, new StringFormat());  //입고일
        //    g.DrawString(htTmp["LIMIT_DT"].ToString(), Font10b, brushBlack, XGab + 0026.0F, YGab + 0028.0F, new StringFormat());  //유효일

        //    //g.DrawString(htTmp["WORKDATE"].ToString() + " ~ " + htTmp["LIMITDATE"].ToString(),
        //    //                        Font10b, brushBlack, XGab + 0018.0F, YGab + 0023.0F, new StringFormat());  //유효일자

        //    string szBarcode = "";
        //    string szHuman = "";
        //    switch (htTmp["BARCODE_FLAG"].ToString())
        //    {
        //        case "00":   //기본출력물
        //            szCode128 = "";
        //            szBarcode = htTmp["ITEM_CD"].ToString().ToUpper() + htTmp["QTY"].ToString().Replace(".", "") + htTmp["LIMIT_DT"].ToString().Replace("-", "");
        //            szHuman = htTmp["ITEM_CD"].ToString().ToUpper() + "      " + htTmp["QTY"].ToString().Replace(".", "") + htTmp["LIMIT_DT"].ToString().Replace("-", "").Substring(0, 8);
        //            if (!bcd.Get_Code128(szBarcode, ref szCode128))
        //            {
        //                TGSControl.UsrFunction.MessageBoxErr("Code128 체크디지트 계산중 오류발생하였습니다.", "바코드발행중");
        //                return;
        //            }

        //            g.DrawString(szCode128, Code128_27, brushBlack, XGab + 0006.0F, YGab + 0033.5F, new StringFormat());        //바코드
        //            g.DrawString(szHuman, Font9b, brushBlack, XGab + 0017.0F, YGab + 0043.5F, new StringFormat());       //휴먼문자
        //            break;

        //        case "":     //사용처가 없는 출력
        //        case "01":   //하단 품번 출력
        //            szHuman = htTmp["ITEM_CD"].ToString().ToUpper();
        //            g.DrawString(szHuman, Font23b, brushBlack, XGab + 0017.0F, YGab + 0034.0F, new StringFormat());       //품번출력

        //            break;
        //        case "02":   //하단 바코드 정보출력(바코드(품번, 중량, 유효일) + TEXT(사용처))
        //            szCode128 = "";
        //            szBarcode = htTmp["ITEM_CD"].ToString().ToUpper() + htTmp["QTY"].ToString().Replace(".", "") + htTmp["LIMIT_DT"].ToString().Replace("-", "").Substring(0, 8);
        //            szHuman = "사용처 : " + htTmp["ISSUED_CD"].ToString();
        //            if (!bcd.Get_Code128(szBarcode, ref szCode128))
        //            {
        //                TGSControl.UsrFunction.MessageBoxErr("Code128 체크디지트 계산중 오류발생하였습니다.", "바코드발행중");
        //                return;
        //            }

        //            g.DrawString(szCode128, Code128_27, brushBlack, XGab + 0006.0F, YGab + 0033.5F, new StringFormat());        //바코드
        //            g.DrawString(szHuman, Font9b, brushBlack, XGab + 0017.0F, YGab + 0043.5F, new StringFormat());       //휴먼문자
        //            break;
        //    }

        //    //********************* 80 X 60 라벨지 *******************************

        //    /*****************  70X45 라벨지*******************************
        //    //Box Line
        //    g.DrawRectangle(pen3, XGab + 0001.0F, YGab + 0001.0F, XGab + 0065.0F, YGab + 0030.0F);


        //    // 가로 라인
        //    g.DrawLine(pen1, XGab + 0001.0F, YGab + 0008.0F, XGab + 0066.0F, YGab + 0008.0F);
        //    g.DrawLine(pen1, XGab + 0001.0F, YGab + 0022.0F, XGab + 0066.0F, YGab + 0022.0F);
        //    g.DrawLine(pen1, XGab + 0001.0F, YGab + 0026.5F, XGab + 0066.0F, YGab + 0026.5F);




        //    // 세로 라인
        //    g.DrawLine(pen1, XGab + 0012.0F, YGab + 0001.0F, XGab + 0012.0F, YGab + 0008.0F);
        //    g.DrawLine(pen1, XGab + 0035.0F, YGab + 0001.0F, XGab + 0035.0F, YGab + 0008.0F);
        //    g.DrawLine(pen1, XGab + 0046.0F, YGab + 0001.0F, XGab + 0046.0F, YGab + 0008.0F);

        //    //g.DrawLine(pen1, XGab + 0021.0F, YGab + 0008.0F, XGab + 0021.0F, YGab + 00026.0F);
        //    g.DrawLine(pen1, XGab + 0012.0F, YGab + 0008.0F, XGab + 0012.0F, YGab + 00031.0F);

        //    //Header
        //    g.DrawString("품번", Font10b, brushBlack, XGab + 0002.0F, YGab + 0003.0F, new StringFormat());
        //    g.DrawString("중량", Font10b, brushBlack, XGab + 0036.0F, YGab + 0003.0F, new StringFormat());


        //    g.DrawString("공정", Font10b, brushBlack, XGab + 0002.0F, YGab + 0011.0F, new StringFormat());
        //    g.DrawString("롯트", Font10b, brushBlack, XGab + 0002.0F, YGab + 0016.0F, new StringFormat());

        //    g.DrawString("입고일", Font8b, brushBlack, XGab + 0001.2F, YGab + 0023.0F, new StringFormat());
        //    g.DrawString("유효일", Font8b, brushBlack, XGab + 0001.2F, YGab + 0027.0F, new StringFormat());


        //    htTmp = (Hashtable)alBarcode[nCurrentIndex];

        //    if (htTmp["ITEM_NO"].ToString().Length > 8)
        //    {
        //        g.DrawString(htTmp["ITEM_NO"].ToString(), Font11b, brushBlack, XGab + 0012.2F, YGab + 0002.9F, new StringFormat());  //품번
        //    }
        //    else
        //    {
        //        g.DrawString(htTmp["ITEM_NO"].ToString(), Font11b, brushBlack, XGab + 0013.5F, YGab + 0002.9F, new StringFormat());  //품번
        //    }

        //    g.DrawString(htTmp["WEIGHT"].ToString() + " " + htTmp["UNIT"].ToString(), Font10b, brushBlack, XGab + 0046.0F, YGab + 0003.0F, new StringFormat());  //중량


        //    string szCode128 = "";
        //    nsCode128.Code128 bcd = new nsCode128.Code128();
        //    if (!bcd.Get_Code128(htTmp["LOT_NO"].ToString(), ref szCode128))
        //    {
        //        TGSControl.UsrFunction.MessageBoxErr("Code128 체크디지트 계산중 오류발생하였습니다.", "바코드발행중");
        //        return;
        //    }

        //    g.DrawString(szCode128, Code128_27, brushBlack, XGab + 0013.0F, YGab + 008.5F, new StringFormat());        //LOT-NO 바코드
        //    g.DrawString(htTmp["LOT_NO"].ToString(), Font9b, brushBlack, XGab + 0016.0F, YGab + 0018.2F, new StringFormat());       //휴먼문자

        //    g.DrawString("(" + htTmp["ITEM_ACCT_NM"].ToString() + ")", Font8b, brushBlack, XGab + 0048.0F, YGab + 0018.2F, new StringFormat());       //계정



        //    g.DrawString(htTmp["WORKDATE"].ToString(),Font10b, brushBlack, XGab + 0018.0F, YGab + 0022.5F, new StringFormat());  //입고일
        //    g.DrawString(htTmp["LIMITDATE"].ToString(), Font10b, brushBlack, XGab + 0018.0F, YGab + 0026.8F, new StringFormat());  //유효일

        //    //g.DrawString(htTmp["WORKDATE"].ToString() + " ~ " + htTmp["LIMITDATE"].ToString(),
        //    //                        Font10b, brushBlack, XGab + 0018.0F, YGab + 0023.0F, new StringFormat());  //유효일자

        //    string szBarcode = "";
        //    string szHuman = "";
        //    switch (htTmp["BARCODE_FLAG"].ToString())
        //    {
        //        case "00":   //기본출력물
        //            szCode128 = "";
        //            szBarcode = htTmp["ITEM_NO"].ToString() + htTmp["WEIGHT"].ToString().Replace(".", "") + htTmp["LIMITDATE"].ToString().Replace("-", "");
        //            szHuman = htTmp["ITEM_NO"].ToString() + "      " + htTmp["WEIGHT"].ToString().Replace(".", "") + htTmp["LIMITDATE"].ToString().Replace("-", "");
        //            if (!bcd.Get_Code128(szBarcode, ref szCode128))
        //            {
        //                TGSControl.UsrFunction.MessageBoxErr("Code128 체크디지트 계산중 오류발생하였습니다.", "바코드발행중");
        //                return;
        //            }

        //            g.DrawString(szCode128, Code128_27, brushBlack, XGab + 0000.0F, YGab + 0031.5F, new StringFormat());        //바코드
        //            g.DrawString(szHuman, Font9b, brushBlack, XGab + 0014.0F, YGab + 0041.5F, new StringFormat());       //휴먼문자
        //            break;

        //        case "":     //사용처가 없는 출력
        //        case "01":   //하단 품번 출력
        //            szHuman = htTmp["ITEM_NO"].ToString();
        //            g.DrawString(szHuman, Font23b, brushBlack, XGab + 0014.0F, YGab + 0032.0F, new StringFormat());       //품번출력

        //            break;
        //        case "02":   //하단 바코드 정보출력(바코드(품번, 중량, 유효일) + TEXT(사용처))
        //            szCode128 = "";
        //            szBarcode = htTmp["ITEM_NO"].ToString() + htTmp["WEIGHT"].ToString().Replace(".", "") + htTmp["LIMITDATE"].ToString().Replace("-", "");
        //            szHuman = "사용처 : " + htTmp["ISSUE_CD"].ToString();
        //            if (!bcd.Get_Code128(szBarcode, ref szCode128))
        //            {
        //                TGSControl.UsrFunction.MessageBoxErr("Code128 체크디지트 계산중 오류발생하였습니다.", "바코드발행중");
        //                return;
        //            }

        //            g.DrawString(szCode128, Code128_27, brushBlack, XGab + 0000.0F, YGab + 0031.5F, new StringFormat());        //바코드
        //            g.DrawString(szHuman, Font9b, brushBlack, XGab + 0014.0F, YGab + 0041.5F, new StringFormat());       //휴먼문자
        //            break;
        //    }
        //    */
        //    //*****************  70X45 라벨지*******************************

        //    LabelPrint_Save(htTmp["LOT_NO"].ToString(),
        //           htTmp["ITEM_NO"].ToString(),
        //           cboWorker.Value);
                
        //}


        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Barcode_Print(e);
        }






        private void cboFacility_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboFacility.Value != sFACILITY_CD)
            {
                sFACILITY_CD = cboFacility.Value;
                ProcessInform_Review(sFACILITY_CD, ref sWC_CD, ref sWC_NM, false);   //선택된 설비의 작업장 정보

            }

            DBQuery(); 
        }

        private void Grid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (Grid2.CurrentRow == null) return;
            if (Grid2.CurrentCell == null) return;

            if (Grid2.Columns[Grid2.CurrentCell.ColumnIndex].Name == grid2_COLUMN.CHECKFLAG)
            {
                System.Drawing.Image imgCheck = (System.Drawing.Image)Grid2.CurrentRow.Cells[grid2_COLUMN.CHECKFLAG].Value;
                if (imgCheck.Tag.ToString() == "N")
                {


                    System.Drawing.Image imgChecked = Properties.Resources.CheckBoxChecked;
                    imgChecked.Tag = "Y";

                    Grid2.CurrentRow.Cells[grid2_COLUMN.CHECKFLAG].Value = imgChecked;

                    
                }
                else
                {


                    System.Drawing.Image imgUnChecked = Properties.Resources.CheckBoxUnChecked;
                    imgUnChecked.Tag = "N";

                    Grid2.CurrentRow.Cells[grid2_COLUMN.CHECKFLAG].Value = imgUnChecked;

                    

                }

            }

            if (Grid2.CurrentRow != null)
            {

               // if (Grid2.CurrentRow.Cells[grid2_COLUMN.LOT_NO].Value.ToString().ToUpper() == Grid2.CurrentRow.Cells[grid2_COLUMN.TOP_LOT_NO].Value.ToString().ToUpper())
               // {
               //     btn_RESULT_CANCEL.Visible = true;
               //     btn_Bad_Qty_Insert.Visible = true;
               // }
               // else
               // {
               //     btn_RESULT_CANCEL.Visible = false;
               //     btn_Bad_Qty_Insert.Visible = false;
               // }
               //
               // if (Convert.ToDecimal(Grid2.CurrentRow.Cells[grid2_COLUMN.GOOD_QTY].Value.ToString()) == 0)
               // {
               //     btn_Bad_Qty_Insert.Visible = false;
               // }
            }

        }

        private void opn_ITEM_CD_VisibleChanged(object sender, EventArgs e)
        {
            DBQuery();
        }

        private void opn_ITEM_CD_ValueChanged(object sender, EventArgs e)
        {
            if (sLoading) return;
            DBQuery();
        }
        //작업지시서 정보 조회
        private void btn_WorkOrder_Info_ButtonClick(object sender, EventArgs e)
        {

      }

      //생산실적취소
      private void btn_RESULT_CANCEL_ButtonClick(object sender, EventArgs e)
        {

      }

      private void cboTYPE_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sLoading) return;

           // if (cboTYPE.Value == "B")
           // {
           //     cboWorker.Value = "";   //불량일 경우 작업자 조건을 뺍
           // }
            DBQuery();
        }

        private void APP_P3101Q1_Resize(object sender, EventArgs e)
        {
           // TGSClass.Util.Grid_Resize(Grid1);
            TGSClass.Util.Grid_Resize(Grid2);
        }

        private void tButton1_ButtonClick(object sender, EventArgs e)
        {

            POP_P9003PA1 myForm = new POP_P9003PA1();

            //파라메터를 설정한다.

            DataTable dt = new DataTable("PassData");
            dt.Columns.Add("PLANT_CD");
            dt.Columns.Add("WC_MGR");
            dt.Columns.Add("FACILITY_CD");
            dt.Columns.Add("WC_CD");



            dt.Rows.Add();

            dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
            dt.Rows[0]["WC_MGR"] = sWC_MGR;
            dt.Rows[0]["FACILITY_CD"] = sFACILITY_CD;
            dt.Rows[0]["WC_CD"] = sWC_CD;


            myForm.ResultData.Tables.Add(dt); //변수전달


            myForm.MainForm = this.MainForm;


            //myForm.Caption = "불량 집계조회";
            myForm.Start(); //시작함수를 실행한다.
            //myForm.OnFncQuery(); //조회함


            DialogResult dResult = myForm.ShowDialog();//화면에 표시

            //if (dResult == DialogResult.OK)
            //{

            //    DBQuery();
            //}
        }

        private void Grid1_Enter(object sender, EventArgs e)
        {
            sGrid_Current_id = 1;
        }

        private void Grid2_Enter(object sender, EventArgs e)
        {
            sGrid_Current_id = 2;
        }

        
        
    }
}

