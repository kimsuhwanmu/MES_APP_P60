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

//using MES_APP_P02;

namespace MES_APP_P90
{
    public partial class APP_P9002MA1 : UserControl
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
            public const string WK_ORD_NO = "WK_ORD_NO";
        }
        public struct SetValueName
        {
            public const string UNIT_CD = "UNIT_CD";
            public const string PLANT_CD = "PLANT_CD";
            public const string RESULT_NO = "RESULT_NO";
            public const string FACILITY_CD = "FACILITY_CD";
            public const string WC_CD = "WC_CD";
            public const string WC_MGR = "WC_MGR";
            public const string WC_MGR_NM = "WC_MGR_NM";
            public const string WORKER_CD = "WORKER_CD";
            public const string WC_NM = "WC_NM";

            public const string RESULT_USER_FLAG = "RESULT_USER_FLAG";    //사용자 일자 사용여부
            public const string RESULT_USER_DT = "RESULT_USER_DT";    //사용자 일자
        }

        public struct TABCONTROL_TAB_NAME
        {
            public const string RESERVATION = "tabPage_RESERVATION";
            public const string SCAN = "tabPage_SCAN";
            public const string SCAN_PUBLIC = "tabPage_SCAN_PUBLIC";
        }

        public struct grid1_COLUMN
        {
            //public const string CHECKFLAG = "CHKFLAG";
            public const string SEQ = "SEQ";
            public const string PRODT_ORDER_NO = "PRODT_ORDER_NO";
            public const string OPR_NO = "OPR_NO";
            public const string WK_DT = "WK_DT";
            public const string WK_ORD_NO = "WK_ORD_NO";
            public const string ITEM_CD = "ITEM_CD";
            public const string ITEM_NM = "ITEM_NM";
            public const string WK_ORD_QTY = "WK_ORD_QTY";
            public const string PROD_QTY = "PROD_QTY";
            public const string GOOD_QTY = "GOOD_QTY";
            public const string BAD_QTY = "BAD_QTY";
            public const string EMP_DESC = "EMP_DESC";
            public const string STATUS = "STATUS";
            public const string REAL_START_TM = "REAL_START_TM";
            public const string REAL_END_TM = "REAL_END_TM";
            public const string RESULT_NO = "RESULT_NO";
            public const string WORKER_ID = "WORKER_ID";
            public const string LOT_QTY = "LOT_QTY";
            public const string WK_ORD_UNIT = "WK_ORD_UNIT";

            public const string RESULT_FLAG = "RESULT_FLAG";


        }

        public struct grid2_COLUMN  //자재소요량
        {
            //public const string CHECKFLAG = "CHKFLAG";
            public const string WK_ORD_NO = "WK_ORD_NO";
            public const string PRODT_ORDER_NO = "PRODT_ORDER_NO";
            public const string OPR_NO = "OPR_NO";
            public const string ITEM_CD = "ITEM_CD";
            public const string ITEM_NM = "ITEM_NM";
            public const string RESV_QTY = "RESV_QTY";
            public const string BASE_UNIT = "BASE_UNIT";
            public const string INV_QTY = "INV_QTY";
            public const string INV_UNIT = "INV_UNIT";
            //public const string PUBLIC_FLAG = "PUBLIC_FLAG";
            //public const string PUBLIC_NM = "PUBLIC_NM";
            public const string OUT_QTY = "OUT_QTY";
            public const string UNIT_QTY = "UNIT_QTY";
            //public const string REAL_USED_QTY = "REAL_USED_QTY";

        }

        public struct grid3_COLUMN  //창고별 재고정보
        {
            //public const string CHECKFLAG = "CHKFLAG";
            public const string LOC_NM = "LOC_NM";
            public const string GOOD_QTY = "GOOD_QTY";
            public const string INV_UNIT = "INV_UNIT";
            public const string LOC_NM1 = "LOC_NM1";
            public const string LOC_NM2 = "LOC_NM2";
            public const string LOC_NM3 = "LOC_NM3";
            public const string LOC_NM4 = "LOC_NM4";
            public const string LOC_NM5 = "LOC_NM5";



        }

        public struct grid4_COLUMN  //LOT 투입내역 
        {
            //public const string CHECKFLAG = "CHKFLAG";
            public const string SEQ = "SEQ";
            public const string ITEM_CD = "ITEM_CD";
            public const string ITEM_NM = "ITEM_NM";
            public const string LOC_NO = "LOC_NO";
            public const string LOC_NM = "LOC_NM";
            public const string LOT_NO = "LOT_NO";

            public const string INV_QTY = "INV_QTY";
            public const string INV_UNT = "INV_UNT";
            //public const string RESV_QTY = "RESV_QTY";
            public const string OUT_QTY = "OUT_QTY";
            public const string REAL_USED_QTY = "REAL_USED_QTY";
            public const string STATE_NM = "STATE_NM";
            public const string PUBLIC_NM = "PUBLIC_NM";
            //public const string PUBLIC_FLAG = "PUBLIC_FLAG";
            

        }

        public struct grid5_COLUMN  //공용부품 LOT 투입내역 
        {
            //public const string CHECKFLAG = "CHKFLAG";
            public const string SEQ = "SEQ";
            public const string ITEM_CD = "ITEM_CD";
            public const string ITEM_NM = "ITEM_NM";
            public const string LOC_NO = "LOC_NO";
            public const string LOC_NM = "LOC_NM";
            public const string LOT_NO = "LOT_NO";
            
            public const string INV_QTY = "INV_QTY";
            public const string INV_UNT = "INV_UNT";
            //public const string RESV_QTY = "RESV_QTY";
            public const string OUT_QTY = "OUT_QTY";
            public const string REAL_USED_QTY = "REAL_USED_QTY";
            public const string STATE_NM = "STATE_NM";
            public const string PUBLIC_NM = "PUBLIC_NM";
            //public const string PUBLIC_FLAG = "PUBLIC_FLAG";

        }

       


        #endregion

        #region ■ 1.3. Class global variables (common) //글로벌 변수 선언

        Global global = new Global();
        Form sMainForm;

        string sPLANT_CD = "";      //공장
        string sWC_MGR = "";        //대공정
        string sWC_MGR_NM = "";
        string sWC_CD = "";         //작업장
        string sFACILITY_CD = "";   //설비번호
        string sWORKER_CD = "";     //작업자
        string sWC_NM = "";         //작업장
        string sWK_ORD_NO = "";


        bool sRESULT_USER_FLAG = false;    //사용자 소급실적등록 여부
        string sRESULT_USER_DT = "";   //사용자 소급 실적일자
        
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

        public APP_P9002MA1()
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

            tabControl1.SelectedIndex = 1;
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
                            sWC_CD = ds.Tables["PassData"].Rows[0]["WC_CD"].ToString();
                            sFACILITY_CD = ds.Tables["PassData"].Rows[0]["FACILITY_CD"].ToString();
                            sWORKER_CD = ds.Tables["PassData"].Rows[0]["WORKER_CD"].ToString();

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

                switch (sWC_MGR)
                {
                    case "10":
                        vSendData.Tables["COMMAND"].Rows.Add("APP_RUN", "MES_APP_P00.APP_P1003M1", "", "", "");
                        break;
                    case "20":
                        vSendData.Tables["COMMAND"].Rows.Add("APP_RUN", "MES_APP_P50.APP_P5001M1", "", "", "");
                        break;
                    case "30":
                        if (sRESULT_USER_FLAG == true)  //예외실적처리 이면
                        {
                            vSendData.Tables["COMMAND"].Rows.Add("APP_RUN", "MES_APP_P00.APP_P1003M1", "", "", ""); //부품등록창 그대로
                        }
                        else
                        {
                            vSendData.Tables["COMMAND"].Rows.Add("APP_RUN", "MES_APP_P30.APP_P3001M1", "", "", ""); //성형실적등록창으로 이동
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
                if (Grid1.CurrentRow != null)
                {
                    vSendData.Tables["PassData"].Rows[0]["WORKER_CD"] = Grid1.CurrentRow.Cells[grid1_COLUMN.WORKER_ID].Value;   //현작업의 작업자
                }
                else
                {
                    vSendData.Tables["PassData"].Rows[0]["WORKER_CD"] = cboWorker.Value;
                }
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

                case GetValueName.WK_ORD_NO:
                    //if (Grid1.CurrentRow == null)
                    //{
                    //    if (Grid1.Rows.Count > 0)
                    //    {
                    //        Grid1.Rows[0].Cells[grid1_COLUMN.WK_ORD_NO].Selected = true;
                    //    }
                    //}

                    //if (Grid1.CurrentRow != null)
                    //    return Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString();
                    //else
                    //    return "";
                    if (sWK_ORD_NO == null)
                    {
                        return "";
                    }
                    else
                    {
                        return sWK_ORD_NO;
                    }
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
                case SetValueName.WC_CD:
                    sWC_CD = pValue;
                    break;
                case SetValueName.WC_NM:
                    sWC_NM = pValue;
                    break;
                case SetValueName.WC_MGR:
                    sWC_MGR = pValue;
                    break;
                case SetValueName.WC_MGR_NM:
                    sWC_MGR_NM = pValue;
                    break;
                case SetValueName.WORKER_CD:
                    sWORKER_CD = pValue;
                    break;
                case SetValueName.FACILITY_CD:

                    sFACILITY_CD = pValue;
                    
                    break;
                case SetValueName.RESULT_USER_FLAG: //사용자 소급실적여부
                    bool vRESULT_USER_FLAG_BEFORE = sRESULT_USER_FLAG;

                    if (pValue.ToUpper() == "Y")
                    {
                        sRESULT_USER_FLAG = true;
                    }
                    else
                    {
                        sRESULT_USER_FLAG = false;
                    }

                    if (vRESULT_USER_FLAG_BEFORE != sRESULT_USER_FLAG)
                    {

                        if (sWC_MGR == "10")    //준비공정일때
                        {
                            btn_WORK_RESULT.Caption = "실적등록(바코드)";
                            btn_WORK_RESULT.FontSize = 12F;
                        }
                        else
                        {
                            if (sRESULT_USER_FLAG == true)  //예외실적 flag가 설정되어 있으면
                            {
                                btn_WORK_RESULT.Caption = "실적등록(바코드)";
                                btn_WORK_RESULT.FontSize = 12F;
                            }
                            else
                            {
                                btn_WORK_RESULT.Caption = "스캔완료";
                                btn_WORK_RESULT.FontSize = 14.25F;
                            }
                        }

                        OnFncQuery();
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

            


            if (sPLANT_CD == "") sPLANT_CD = Global.workinfo.szFactoryCD;
            if (sFACILITY_CD == "") sFACILITY_CD = Global.workinfo.szFacilityCD;
            if (sWC_CD == "") sWC_CD = Global.workinfo.szWorkSpaceCD;
            if (sWC_MGR == "") sWC_MGR = Global.workinfo.szProcessCD;
            if (sWC_MGR_NM == "") sWC_MGR_NM = Global.workinfo.szProcessNM;
            if (sWORKER_CD == "") sWORKER_CD = Global.workinfo.szOperatorCD;
            if (sWC_NM == "") sWC_NM = Global.workinfo.szWorkSpaceNM;



        }

        #endregion

        #region ■ 2.5 Gathering combo data(GatheringComboData) //콤보관련 데이타 설정

        protected void GatheringComboData()
        {
            if (Global.workinfo.szServerIP == "") return;

            //Load_Operator();  //작업자정보조회
            Fnc_crt_combo(this.cboWorker, "", "WORKER", 0, "작업자", "작업자명", "작업자 선택");  //작업자정보조회

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

            string pValueMember = "code";
            string pDisplayMember = "name";

            //DataSet iDataSet = new DataSet();
            DataTable dtData1 = null;
            dtData1 = new DataTable();

            string strSql = "";

            switch (@FLAG)
            {
                //case "LOC_NO":    // 받는 적치장  대표공정의 창고만 조회 함 정렬순서가 LOC_NO DESC로 창고코드 내림차순으로 되어 있어 첫번째 창고가 99 창고로 조회 됨
                //    strSql = "EXEC DBO.XUSP_MES_P0101P1_GET_LOC ";
                //    strSql += "@PLANT_CD='" + sPLANT_CD + "',";
                //    strSql += "@WC_MGR='" + sWC_MGR + "'";

                //    pValueMember = "LOC_NO";
                //    pDisplayMember = "SL_NM";

                //    break;
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
                //string strState = TGSClass.DataBase.GetDataSql(this.MainForm, strSql, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
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

        //        string strState = TGSClass.DataBase.GetDataSql(this.ParentForm, szSendData, ref dtData1, ref nCnt,
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

        //            strState = TGSClass.DataBase.GetDataSql(this.ParentForm, szSendData, ref dtData1, ref nCnt,
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
                //strSql += sPLANT_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strSql += sWC_MGR + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strSql += sWC_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strSql += "";  //Mixing의 JobCode자리

                strSql = "EXEC DBO.XUSP_MESSVR_GET_FACILITY "
                            + " @PLANT_CD='" + sPLANT_CD + "',"
                            + " @WC_MGR='" + sWC_MGR + "',"
                            + " @WC_CD='" + sWC_CD + "',"
                            + " @JOB_CD='" + "" + "'";  //Mixing의 JobCode자리


                DataTable dtData1 = null;
                dtData1 = new DataTable();


                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strSql, ref dtData1, ref nCnt);

                //string strState = TGSClass.DataBase.GetDataSql(this.ParentForm, szSendData, ref dtData1, ref nCnt,
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

        //        string strState = TGSClass.DataBase.GetDataSql(this.ParentForm, szSendData, ref dtData1, ref nCnt,
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
            InitSpreadSheet(1); //GRID1
            InitSpreadSheet(2); //GRID2
            InitSpreadSheet(3); //GRID3
            InitSpreadSheet(4); //GRID4
            InitSpreadSheet(5); //GRID4
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


                    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.SEQ, "NO", 0));
                    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.PRODT_ORDER_NO, "제조오더번호", 0));
                    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.OPR_NO, "공순", 0));
                    
                    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.WK_DT, "지시일자", 90));
                    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.WK_ORD_NO, "작업지시번호", 200));
                    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.ITEM_CD, "품번", 130));
                    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.ITEM_NM, "품명", 160));
                    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.WK_ORD_QTY, "지시량", 90));
                    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.PROD_QTY, "생산량", 0));
                    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.GOOD_QTY, "양품량", 90));
                    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.BAD_QTY, "불량", 80));
                    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.EMP_DESC, "작업자", 80));
                    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.STATUS, "상태", 80));

                    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.REAL_START_TM, "시작시각", 0));
                    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.REAL_END_TM, "종료시각", 0));
                    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.RESULT_NO, "실적번호", 0));
                    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.WORKER_ID, "작업자", 0));
                    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.LOT_QTY, "용기당수량", 0));
                    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.WK_ORD_UNIT, "단위", 0));

                    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.RESULT_FLAG, "예외구분", 0));

                

                #endregion


                #region ■■ 3.1.2 Formatting grid information
                    //uniGrid2.flagInformation("cud_flag", "rownum");
                    //uniGrid2.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.No);
                    Grid1.Columns[grid1_COLUMN.WK_DT].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    Grid1.Columns[grid1_COLUMN.WK_ORD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    Grid1.Columns[grid1_COLUMN.PROD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    Grid1.Columns[grid1_COLUMN.GOOD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    Grid1.Columns[grid1_COLUMN.BAD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    Grid1.Columns[grid1_COLUMN.WK_ORD_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태
                    Grid1.Columns[grid1_COLUMN.PROD_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                    Grid1.Columns[grid1_COLUMN.GOOD_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                    Grid1.Columns[grid1_COLUMN.BAD_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태

                
                #endregion


                #region ■■ 3.1.3 Setting etc grid
                
                    // Hidden Column Setting
                    Grid1.Columns[grid1_COLUMN.SEQ].Visible = false;
                    Grid1.Columns[grid1_COLUMN.PRODT_ORDER_NO].Visible = false;
                    Grid1.Columns[grid1_COLUMN.OPR_NO].Visible = false;

                    Grid1.Columns[grid1_COLUMN.PROD_QTY].Visible = false;

                    Grid1.Columns[grid1_COLUMN.REAL_START_TM].Visible = false;
                    Grid1.Columns[grid1_COLUMN.REAL_END_TM].Visible = false;
                    Grid1.Columns[grid1_COLUMN.RESULT_NO].Visible = false;
                    Grid1.Columns[grid1_COLUMN.WORKER_ID].Visible = false;
                    Grid1.Columns[grid1_COLUMN.LOT_QTY].Visible = false;
                    Grid1.Columns[grid1_COLUMN.WK_ORD_UNIT].Visible = false;
                    Grid1.Columns[grid1_COLUMN.RESULT_FLAG].Visible = false;
                

                #endregion

                TGSClass.Util.Grid_Resize(Grid1);
            }

            #endregion


            #region ▶▶▶ 3.1.2 GRID1 설정

            if (p_GridIndex == 2)
            {
                #region ■■ 3.1.2.1 Pre-setting grid information

                

                /*** grid1
                 *  소요량정보 조회
                 * **/
                Grid2.Columns.Clear();

                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("맑은 고딕", 12);
                Grid2.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                Grid2.RowHeadersVisible = false;

                //Grid2.Columns.Add(SetColumnImage(grid2_COLUMN.CHECKFLAG, "√", 40));    //이미지형태의 그리드



                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.ITEM_CD, "품번", 120));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.ITEM_NM, "품명", 140));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.RESV_QTY, "소요량", 80));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.INV_QTY, sWC_MGR_NM + "재고", 80));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.OUT_QTY, "스캔", 80));
                //Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.REAL_USED_QTY, "사용량", 0));
                                
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.BASE_UNIT, "단위", 50));
                //Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.PUBLIC_NM, "구분", 50));
                //Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.PUBLIC_FLAG, "구분", 0));

                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.WK_ORD_NO, "지시번호", 0));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.PRODT_ORDER_NO, "제조오더번호", 0));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.OPR_NO, "공순", 0));

                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.UNIT_QTY, "기준량", 70));

                #endregion


                #region ■■ 3.1.2.2 Formatting grid information

                //uniGrid2.flagInformation("cud_flag", "rownum");
                //uniGrid2.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.No);

                Grid2.Columns[grid2_COLUMN.RESV_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid2.Columns[grid2_COLUMN.RESV_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태
                Grid2.Columns[grid2_COLUMN.INV_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid2.Columns[grid2_COLUMN.INV_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태
                Grid2.Columns[grid2_COLUMN.OUT_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid2.Columns[grid2_COLUMN.OUT_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                //Grid2.Columns[grid2_COLUMN.REAL_USED_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid2.Columns[grid2_COLUMN.REAL_USED_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                Grid2.Columns[grid2_COLUMN.UNIT_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid2.Columns[grid2_COLUMN.UNIT_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태


                #endregion


                #region ■■ 3.1.2.3 Setting etc grid
                // Hidden Column Setting
                //Grid2.Columns[grid2_COLUMN.REAL_USED_QTY].Visible = false;
                //Grid2.Columns[grid2_COLUMN.PUBLIC_FLAG].Visible = false;
                Grid2.Columns[grid2_COLUMN.WK_ORD_NO].Visible = false;
                Grid2.Columns[grid2_COLUMN.PRODT_ORDER_NO].Visible = false;
                Grid2.Columns[grid2_COLUMN.OPR_NO].Visible = false;
                //Grid2.Columns[grid2_COLUMN.REAL_USED_QTY].Visible = false;


                #endregion

                TGSClass.Util.Grid_Resize(Grid2);
            }
            #endregion


            #region ▶▶▶ 3.1.3 GRID3 설정
            if (p_GridIndex == 3)
            {
                #region ■■ 3.1.3.1 Pre-setting grid information



                /*** grid1
                 *  실적조회
                 * **/
                Grid3.Columns.Clear();
                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("맑은 고딕", 12);
                Grid3.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                Grid3.RowHeadersVisible = false;

                //Grid4.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                Grid3.Columns.Add(SetColumnEdit(grid3_COLUMN.LOC_NM, "창고", 160));
                Grid3.Columns.Add(SetColumnEdit(grid3_COLUMN.GOOD_QTY, "재고량", 90));
                Grid3.Columns.Add(SetColumnEdit(grid3_COLUMN.INV_UNIT, "단위", 50));
                
                Grid3.Columns.Add(SetColumnEdit(grid3_COLUMN.LOC_NM1, "자재창고", 75));
                Grid3.Columns.Add(SetColumnEdit(grid3_COLUMN.LOC_NM2, "준비대기", 75));
                Grid3.Columns.Add(SetColumnEdit(grid3_COLUMN.LOC_NM3, "공정중", 75));
                Grid3.Columns.Add(SetColumnEdit(grid3_COLUMN.LOC_NM4, "준비완료", 75));
                Grid3.Columns.Add(SetColumnEdit(grid3_COLUMN.LOC_NM5, "성형대기", 75));
                

                #endregion


                #region ■■ 3.1.3.2 Formatting grid information

                //uniGrid3.flagInformation("cud_flag", "rownum");
                //uniGrid3.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.No);

                Grid3.Columns[grid3_COLUMN.GOOD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid3.Columns[grid3_COLUMN.GOOD_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태

                Grid3.Columns[grid3_COLUMN.LOC_NM1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid3.Columns[grid3_COLUMN.LOC_NM1].DefaultCellStyle.Format = "N0"; //숫자표시형태
                Grid3.Columns[grid3_COLUMN.LOC_NM2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid3.Columns[grid3_COLUMN.LOC_NM2].DefaultCellStyle.Format = "N0"; //숫자표시형태
                Grid3.Columns[grid3_COLUMN.LOC_NM3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid3.Columns[grid3_COLUMN.LOC_NM3].DefaultCellStyle.Format = "N0"; //숫자표시형태
                Grid3.Columns[grid3_COLUMN.LOC_NM4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid3.Columns[grid3_COLUMN.LOC_NM4].DefaultCellStyle.Format = "N0"; //숫자표시형태
                Grid3.Columns[grid3_COLUMN.LOC_NM5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid3.Columns[grid3_COLUMN.LOC_NM5].DefaultCellStyle.Format = "N0"; //숫자표시형태

                #endregion


                #region ■■ 3.1.3.3 Setting etc grid
                // Hidden Column Setting
                //Grid3.Columns[grid3_COLUMN.SEQ].Visible = false;
                //Grid3.Columns[grid3_COLUMN.PRODT_ORDER_NO].Visible = false;
                //Grid3.Columns[grid3_COLUMN.OPR_NO].Visible = false;

                //if (sWC_MGR == "30")    //성형이면
                //{
                //    Grid3.Columns[grid3_COLUMN.LOC_NM].Visible = false;
                //    Grid3.Columns[grid3_COLUMN.INV_QTY].Visible = false;
                //    Grid3.Columns[grid3_COLUMN.INV_UNIT].Visible = false;
                //    Grid3.Columns[grid3_COLUMN.LOC_NM1].Visible = true;
                //    Grid3.Columns[grid3_COLUMN.LOC_NM2].Visible = true;
                //    Grid3.Columns[grid3_COLUMN.LOC_NM3].Visible = true;
                //    Grid3.Columns[grid3_COLUMN.LOC_NM4].Visible = true;
                //    Grid3.Columns[grid3_COLUMN.LOC_NM5].Visible = true;
                //}
                //else
                //{
                    Grid3.Columns[grid3_COLUMN.LOC_NM].Visible = true;
                    Grid3.Columns[grid3_COLUMN.GOOD_QTY].Visible = true;
                    Grid3.Columns[grid3_COLUMN.INV_UNIT].Visible = true;
                    Grid3.Columns[grid3_COLUMN.LOC_NM1].Visible = false;
                    Grid3.Columns[grid3_COLUMN.LOC_NM2].Visible = false;
                    Grid3.Columns[grid3_COLUMN.LOC_NM3].Visible = false;
                    Grid3.Columns[grid3_COLUMN.LOC_NM4].Visible = false;
                    Grid3.Columns[grid3_COLUMN.LOC_NM5].Visible = false;
                //}



                #endregion

                TGSClass.Util.Grid_Resize(Grid3);

            }
            #endregion


            

            #region ▶▶▶ 3.1.4 GRID4 설정
            if (p_GridIndex == 4)
            {
                #region ■■ 3.1.4.1 Pre-setting grid information



                /*** grid4
                 *  자재투입정보
                 * **/
                Grid4.Columns.Clear();

                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("맑은 고딕", 12);
                Grid4.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                Grid4.RowHeadersVisible = false;

                Grid4.Columns.Add(SetColumnEdit(grid4_COLUMN.SEQ, "No.", 50));
                Grid4.Columns.Add(SetColumnEdit(grid4_COLUMN.ITEM_CD, "품번", 130));
                Grid4.Columns.Add(SetColumnEdit(grid4_COLUMN.ITEM_NM, "품명", 200));
                Grid4.Columns.Add(SetColumnEdit(grid4_COLUMN.LOT_NO, "LOT NO", 150));
                Grid4.Columns.Add(SetColumnEdit(grid4_COLUMN.INV_QTY, "현재고", 100));
                Grid4.Columns.Add(SetColumnEdit(grid4_COLUMN.OUT_QTY, "스캔(예약량)", 100));
                Grid4.Columns.Add(SetColumnEdit(grid4_COLUMN.REAL_USED_QTY, "실소모량", 80));
                Grid4.Columns.Add(SetColumnEdit(grid4_COLUMN.LOC_NM, "적치장", 80));
                Grid4.Columns.Add(SetColumnEdit(grid4_COLUMN.INV_UNT, "단위", 50));
                Grid4.Columns.Add(SetColumnEdit(grid4_COLUMN.STATE_NM, "상태", 60));
                Grid4.Columns.Add(SetColumnEdit(grid4_COLUMN.PUBLIC_NM, "구분", 80));
                Grid4.Columns.Add(SetColumnEdit(grid4_COLUMN.LOC_NO, "적치장", 0));
                

                #endregion


                #region ■■ 3.1.4.2 Formatting grid information

                //uniGrid2.flagInformation("cud_flag", "rownum");
                //uniGrid2.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.No);

                Grid4.Columns[grid4_COLUMN.SEQ].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid4.Columns[grid4_COLUMN.SEQ].DefaultCellStyle.Format = "N0"; //숫자표시형태
                Grid4.Columns[grid4_COLUMN.INV_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid4.Columns[grid4_COLUMN.INV_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태
                Grid4.Columns[grid4_COLUMN.OUT_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid4.Columns[grid4_COLUMN.OUT_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태
                Grid4.Columns[grid4_COLUMN.REAL_USED_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid4.Columns[grid4_COLUMN.REAL_USED_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태


                #endregion


                #region ■■ 3.1.4.3 Setting etc grid
                // Hidden Column Setting
                Grid4.Columns[grid4_COLUMN.LOC_NO].Visible = false;
                Grid4.Columns[grid4_COLUMN.STATE_NM].Visible = false;
                Grid4.Columns[grid4_COLUMN.PUBLIC_NM].Visible = false;



                #endregion

                TGSClass.Util.Grid_Resize(Grid4);
            }
            #endregion

            #region ▶▶▶ 3.1.5 GRID5 설정
            if (p_GridIndex == 5)
            {
                #region ■■ 3.1.5.1 Pre-setting grid information



                /*** grid5
                 *  공용자재 투입정보
                 * **/
                Grid5.Columns.Clear();

                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("맑은 고딕", 12);
                Grid5.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                Grid5.RowHeadersVisible = false;

                Grid5.Columns.Add(SetColumnEdit(grid5_COLUMN.SEQ, "No.", 50));
                Grid5.Columns.Add(SetColumnEdit(grid5_COLUMN.ITEM_CD, "품번", 130));
                Grid5.Columns.Add(SetColumnEdit(grid5_COLUMN.ITEM_NM, "품명", 200));
                Grid5.Columns.Add(SetColumnEdit(grid5_COLUMN.LOT_NO, "LOT NO", 150));
                Grid5.Columns.Add(SetColumnEdit(grid5_COLUMN.INV_QTY, "현재고", 100));
                Grid5.Columns.Add(SetColumnEdit(grid5_COLUMN.OUT_QTY, "스캔(예약량)", 100));
                Grid5.Columns.Add(SetColumnEdit(grid5_COLUMN.REAL_USED_QTY, "실소모량", 80));
                Grid5.Columns.Add(SetColumnEdit(grid5_COLUMN.LOC_NM, "적치장", 90));
                Grid5.Columns.Add(SetColumnEdit(grid5_COLUMN.INV_UNT, "단위", 50));
                Grid5.Columns.Add(SetColumnEdit(grid5_COLUMN.STATE_NM, "상태", 80));
                Grid5.Columns.Add(SetColumnEdit(grid5_COLUMN.PUBLIC_NM, "구분", 80));
                Grid5.Columns.Add(SetColumnEdit(grid5_COLUMN.LOC_NO, "적치장", 0));
                

                #endregion


                #region ■■ 3.1.5.2 Formatting grid information

                //uniGrid5.flagInformation("cud_flag", "rownum");
                //uniGrid5.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.No);
                Grid5.Columns[grid5_COLUMN.SEQ].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid5.Columns[grid5_COLUMN.SEQ].DefaultCellStyle.Format = "N0"; //숫자표시형태
                Grid5.Columns[grid5_COLUMN.INV_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid5.Columns[grid5_COLUMN.INV_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태
                Grid5.Columns[grid5_COLUMN.OUT_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid5.Columns[grid5_COLUMN.OUT_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태
                Grid5.Columns[grid5_COLUMN.REAL_USED_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid5.Columns[grid5_COLUMN.REAL_USED_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태


                #endregion


                #region ■■ 3.1.5.3 Setting etc grid
                // Hidden Column Setting
                Grid5.Columns[grid5_COLUMN.LOC_NO].Visible = false;
                Grid5.Columns[grid5_COLUMN.STATE_NM].Visible = false;
                Grid5.Columns[grid5_COLUMN.PUBLIC_NM].Visible = false;



                #endregion

                TGSClass.Util.Grid_Resize(Grid5);
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
            cboWorker.Visible = false;

            if (cboWorker.Value != sWORKER_CD)
            {
                cboWorker.Value = sWORKER_CD; // Global.workinfo.szOperatorCD;
            }


            if (cboFacility.Value != sFACILITY_CD)
            {
                
                ProcessInform_Review(sFACILITY_CD, ref sWC_CD, ref sWC_NM, false);   //선택된 설비의 작업장 정보
                //lbl_WorkCenterNm.Value = sWC_NM;


                cboFacility.Value = sFACILITY_CD;

                if (cboFacility.SelectedIndex == -1)    //콤보에 해당 설비가 없을 경우 설비정보를 다시 조회 함
                {
                    Load_Facility();    //설비 정보를 조회한다.

                    cboFacility.Value = sFACILITY_CD;
                }
            }
            
            
            if (sWC_MGR == "10")    //준비공정일때
            {
                btn_WORK_RESULT.Caption = "실적등록(바코드)";
                btn_WORK_RESULT.FontSize = 12F;
            }
            else
            {
                if (sRESULT_USER_FLAG == true)  //예외실적 flag가 설정되어 있으면
                {
                    btn_WORK_RESULT.Caption = "실적등록(바코드)";
                    btn_WORK_RESULT.FontSize = 12F;
                }
                else
                {
                    btn_WORK_RESULT.Caption = "스캔완료";
                    btn_WORK_RESULT.FontSize = 14.25F;
                }
            }

            if (sWC_MGR == "30") //성형공정일때
            {
                tLabel5.Visible = false;
                cboWorker.Value = "";
                cboWorker.Visible = false;                
            }
            else
            {
                tLabel5.Visible = true;
                cboWorker.Visible = true;
            }

            
            btn_LOT_SCAN_DELETE.Visible = true; //LOT SCAN 내역 삭제 버튼을 표시한다.

            //lbl_WorkCenterNm.Value = sWC_NM;
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


            DBQuery_WorkOrder();

            if (Grid1.Rows.Count > 0)
            {

                int vRowIndex = GetFirstRowIndex(Grid1, 0);

                if (vRowIndex >= 0) Grid1.Rows[vRowIndex].Cells[grid1_COLUMN.ITEM_CD].Selected = true;

                switch (tabControl1.SelectedTab.Name)
                {
                    case TABCONTROL_TAB_NAME.RESERVATION:

                        //선택된 작업지시서의 자재품번 리스트를 조회
                        if (Grid1.CurrentRow != null) DBQuery_WorkReservation(Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString());

                        //창고별재고현황 조회
                        if (Grid2.CurrentRow == null)
                        {
                            if (Grid2.Rows.Count > 0) Grid2.Rows[GetFirstRowIndex(Grid2, 0)].Cells[0].Selected = true;

                        }
                        if (Grid2.CurrentRow != null && Grid1.CurrentRow != null) DBQuery_Stock_Work(Grid2.CurrentRow.Cells[grid1_COLUMN.ITEM_CD].Value.ToString(), Grid1.CurrentRow.Cells[grid1_COLUMN.ITEM_CD].Value.ToString());



                        break;
                    case TABCONTROL_TAB_NAME.SCAN:
                        //선택된 작업지시서의 LOT 스캔 정보 조회
                        if (Grid1.CurrentRow != null) DBQuery_WorkLotResule(Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString(), cboFacility.Value, "");
                        break;
                    case TABCONTROL_TAB_NAME.SCAN_PUBLIC:
                        //선택된 작업지시서의 공용LOT 스캔 정보 조회
                        if (chk_ITEM_GROUP.ValueChar == "Y")
                            if (Grid1.CurrentRow != null) DBQuery_WorkLotResule_PUBLIC(Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString(), cboFacility.Value, "");
                        else
                            DBQuery_WorkLotResule_PUBLIC("", cboFacility.Value, "");
                        break;
                }



            }
            else
            {
                Grid2.Rows.Clear();
                Grid3.Rows.Clear();
                Grid4.Rows.Clear();

                lbl_RESV_QTY.Value = "0";
                lbl_LotScanQty.Value = "0";
                lbl_LotScanPublicQty.Value = "0";

                if (chk_ITEM_GROUP.ValueChar == "Y")
                {
                    Grid5.Rows.Clear();
                }
                else
                {
                    DBQuery_WorkLotResule_PUBLIC("", cboFacility.Value, "");
                }

            }

            LoadingForm(false);
            
            this.ResumeLayout();
            this.PerformLayout();

            return true;
        }



        #region ▶▶▶ 작업지시현황 정보 조회
        private void DBQuery_WorkOrder()//작업지시현황을 조회 
        {
            int nCnt = 0;

            /* 임시주석 손유진

            try
            {
                LoadingForm(true);


                Grid1.Rows.Clear();


                string strData = "";
                //strData = WorkCode.WorkCd.PO_REVIEW;
                //strData += Global.workinfo.szFactoryCD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strData += Global.workinfo.szProcessCD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strData += Global.workinfo.szWorkSpaceCD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strData += Global.workinfo.szFacilityCD;

                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MES_P5001P1_GET @PLANT_CD='" + sPLANT_CD + "', "; //공장
                strData += "@WC_MGR='" + sWC_MGR + "',";        //대공정
                strData += "@WC_CD='" + sWC_CD + "',";          //작업장
                strData += "@FACILITY_CD ='" + sFACILITY_CD + "', ";  //설비번호
                if (sWC_MGR == "30") //성형공정일때
                {
                    strData += "@WORKER_CD=''";  //작업자
                }
                else
                {
                    strData += "@WORKER_CD='" + sWORKER_CD + "'";  //작업자
                }


                DataTable dtData1 = null;
                dtData1 = new DataTable();


                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);
                //string strState = TGSClass.DataBase.GetDataSql(this.MainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);

                if (!strState.Equals("OK"))
                {
                    if (strState.Substring(2, 7) == "서버 연결오류")
                    {
                        TGSControl.UsrFunction.MessageBoxInfo(strState.Substring(2), "작업지시정보조회");
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
                //    TGSControl.UsrFunction.MessageBoxErr("조회할 데이타가 존재하지 않습니다.", "조회");
                //    return;
                //}


                //System.Drawing.Image imgChecked = Properties.Resources.CheckBoxUnChecked;
                //imgChecked.Tag = "N";



                for (int i = 0; i < dtData1.Rows.Count; i++)
                {


                    this.Grid1.Rows.Add();

                    //gridWRDW11.SetData(gridWRDW11.Rows.Fixed + i, gridWRDW11.Cols.Fixed + 0, "N");        //체크  

                    //imgChecked = Properties.Resources.CheckBoxUnChecked;
                    //imgChecked.Tag = "N";
                    //Grid1.Rows[i].Cells[grid1_COLUMN.CHECKFLAG].Value = imgChecked; //1.체크 



                    if (dtData1.Rows[i][grid1_COLUMN.SEQ].ToString() == "긴급")
                        Grid1.Rows[i].Cells[grid1_COLUMN.SEQ].Value = dtData1.Rows[i][grid1_COLUMN.SEQ].ToString(); //순번
                    else
                        Grid1.Rows[i].Cells[grid1_COLUMN.SEQ].Value = (i + 1).ToString(); //순번;

                    Grid1.Rows[i].Cells[grid1_COLUMN.PRODT_ORDER_NO].Value = dtData1.Rows[i][grid1_COLUMN.PRODT_ORDER_NO].ToString(); //제조오더번호 
                    Grid1.Rows[i].Cells[grid1_COLUMN.OPR_NO].Value = dtData1.Rows[i][grid1_COLUMN.OPR_NO].ToString(); //공순 
                    Grid1.Rows[i].Cells[grid1_COLUMN.WK_DT].Value = dtData1.Rows[i][grid1_COLUMN.WK_DT].ToString(); //지시일
                    Grid1.Rows[i].Cells[grid1_COLUMN.WK_ORD_NO].Value = dtData1.Rows[i][grid1_COLUMN.WK_ORD_NO].ToString(); //작업지시번호
                    Grid1.Rows[i].Cells[grid1_COLUMN.ITEM_CD].Value = dtData1.Rows[i][grid1_COLUMN.ITEM_CD].ToString(); //품번
                    Grid1.Rows[i].Cells[grid1_COLUMN.ITEM_NM].Value = dtData1.Rows[i][grid1_COLUMN.ITEM_NM].ToString(); //품명

                    if (dtData1.Rows[i][grid1_COLUMN.WK_ORD_UNIT].ToString().ToUpper() == "KG" || dtData1.Rows[i][grid1_COLUMN.WK_ORD_UNIT].ToString().ToUpper() == "G")
                    {
                        Grid1.Rows[i].Cells[grid1_COLUMN.WK_ORD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.WK_ORD_QTY].ToString()).ToString("N0"); //지시수량
                        Grid1.Rows[i].Cells[grid1_COLUMN.PROD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.PROD_QTY].ToString()).ToString("N0"); //생산수량
                        Grid1.Rows[i].Cells[grid1_COLUMN.GOOD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.GOOD_QTY].ToString()).ToString("N0"); //생산수량
                        Grid1.Rows[i].Cells[grid1_COLUMN.BAD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.BAD_QTY].ToString()).ToString("N0"); //불량
                    }
                    else
                    {
                        Grid1.Rows[i].Cells[grid1_COLUMN.WK_ORD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.WK_ORD_QTY].ToString()).ToString("N2"); //지시수량
                        Grid1.Rows[i].Cells[grid1_COLUMN.PROD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.PROD_QTY].ToString()).ToString("N2"); //생산수량
                        Grid1.Rows[i].Cells[grid1_COLUMN.GOOD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.GOOD_QTY].ToString()).ToString("N2"); //생산수량
                        Grid1.Rows[i].Cells[grid1_COLUMN.BAD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.BAD_QTY].ToString()).ToString("N2"); //불량
                    }

                    Grid1.Rows[i].Cells[grid1_COLUMN.WORKER_ID].Value = dtData1.Rows[i][grid1_COLUMN.WORKER_ID].ToString(); //작업자
                    Grid1.Rows[i].Cells[grid1_COLUMN.EMP_DESC].Value = dtData1.Rows[i][grid1_COLUMN.EMP_DESC].ToString(); //작업자

                    if (dtData1.Rows[i][grid1_COLUMN.REAL_START_TM].ToString().Length > 0 &&
                        dtData1.Rows[i][grid1_COLUMN.REAL_END_TM].ToString().Length == 0)
                        Grid1.Rows[i].Cells[grid1_COLUMN.STATUS].Value = "작업중"; //작업상태
                    else
                        Grid1.Rows[i].Cells[grid1_COLUMN.STATUS].Value = ""; //작업상태

                    Grid1.Rows[i].Cells[grid1_COLUMN.REAL_START_TM].Value = dtData1.Rows[i][grid1_COLUMN.REAL_START_TM].ToString(); //작업시작시각
                    Grid1.Rows[i].Cells[grid1_COLUMN.REAL_END_TM].Value = dtData1.Rows[i][grid1_COLUMN.REAL_END_TM].ToString(); //작업시작완료

                    Grid1.Rows[i].Cells[grid1_COLUMN.RESULT_NO].Value = dtData1.Rows[i][grid1_COLUMN.RESULT_NO].ToString(); //실적번호
                    Grid1.Rows[i].Cells[grid1_COLUMN.LOT_QTY].Value = dtData1.Rows[i][grid1_COLUMN.LOT_QTY].ToString(); //적입량
                    Grid1.Rows[i].Cells[grid1_COLUMN.WK_ORD_UNIT].Value = dtData1.Rows[i][grid1_COLUMN.WK_ORD_UNIT].ToString(); //단위


                    Grid1.Rows[i].Cells[grid1_COLUMN.RESULT_FLAG].Value = dtData1.Rows[i][grid1_COLUMN.RESULT_FLAG].ToString(); //실적구분 'Y' 자료소급용 예외실적

                    if (Grid1.Rows[i].Cells[grid1_COLUMN.RESULT_FLAG].Value.ToString() == "Y")
                    {
                        if (sRESULT_USER_FLAG == true)
                        {
                            for (int j = 0; j < Grid1.Columns.Count; j++)
                            {
                                Grid1.Rows[i].Cells[j].Style.ForeColor = Color.Magenta;
                            }
                            if (Grid1.Rows[i].Cells[grid1_COLUMN.STATUS].Value.ToString() == "작업중") //작업상태
                            {
                                Grid1.Rows[i].Cells[grid1_COLUMN.STATUS].Value = "작업중(예외)"; //작업상태
                            }
                            Grid1.Rows[i].Visible = true;
                        }
                        else
                        {
                            Grid1.Rows[i].Visible = false;
                        }
                    }
                    else
                    {
                        Grid1.Rows[i].Visible = true;
                    }

                    TGSClass.Util.Grid_Resize(Grid1);

                    //string szaa = dtData1.Rows[i][grid1_COLUMN.REAL_START_TM].ToString();
                    //string szbb = dtData1.Rows[i][grid1_COLUMN.REAL_END_TM].ToString();
                    //    //작업진행중인 항목이 있으면
                    //    if (dtData1.Rows[i][gridWRDW11_COLUMN.REAL_START_TM].ToString().Length > 0 &&
                    //        dtData1.Rows[i][gridWRDW11_COLUMN.REAL_END_TM].ToString().Length == 0)
                    //    {

                    //        //imgChecked = Properties.Resources.CheckBoxChecked;
                    //        //imgChecked.Tag = "Y";

                    //        //gridWRDW11.SetCellImage(gridWRDW11.Rows.Fixed + i, gridWRDW11.Cols.Fixed + 0, imgChecked);
                    //        //gridWRDW11.Rows[gridWRDW11.Rows.Fixed + 1].Style = gridWRDW11.Styles["Working"];


                    //        this.gridWPDW12.Rows.Add();

                    //        //gridWRDW11.SetData(gridWRDW11.Rows.Fixed + i, gridWRDW11.Cols.Fixed + 0, "N");        //체크 
                    //        imgChecked = Properties.Resources.CheckBoxUnChecked;
                    //        imgChecked.Tag = "N";
                    //        gridWPDW12.SetCellImage(gridWPDW12.Rows.Fixed + ii, gridWPDW12.Cols.Fixed + 0, imgChecked);  //1.체크 

                    //        gridWPDW12.SetData(gridWPDW12.Rows.Fixed + ii, gridWPDW12.Cols.Fixed + 1, dtData1.Rows[i][gridWPDW12_COLUMN.SEQ]);             //순번 
                    //        gridWPDW12.SetData(gridWPDW12.Rows.Fixed + ii, gridWPDW12.Cols.Fixed + 2, dtData1.Rows[i][gridWPDW12_COLUMN.PRODT_ORDER_NO]);  //제조오더번호    
                    //        gridWPDW12.SetData(gridWPDW12.Rows.Fixed + ii, gridWPDW12.Cols.Fixed + 3, dtData1.Rows[i][gridWPDW12_COLUMN.OPR_NO]);          //공순    
                    //        gridWPDW12.SetData(gridWPDW12.Rows.Fixed + ii, gridWPDW12.Cols.Fixed + 4, dtData1.Rows[i][gridWPDW12_COLUMN.WK_ORD_NO]);       //작업지시번호               
                    //        gridWPDW12.SetData(gridWPDW12.Rows.Fixed + ii, gridWPDW12.Cols.Fixed + 5, dtData1.Rows[i][gridWPDW12_COLUMN.ITEM_CD]);         //품번             
                    //        gridWPDW12.SetData(gridWPDW12.Rows.Fixed + ii, gridWPDW12.Cols.Fixed + 6, dtData1.Rows[i][gridWPDW12_COLUMN.ITEM_NM]);         //품명
                    //        gridWPDW12.SetData(gridWPDW12.Rows.Fixed + ii, gridWPDW12.Cols.Fixed + 7, dtData1.Rows[i][gridWPDW12_COLUMN.WK_ORD_QTY]);      //지시수량
                    //        gridWPDW12.SetData(gridWPDW12.Rows.Fixed + ii, gridWPDW12.Cols.Fixed + 8, dtData1.Rows[i][gridWPDW12_COLUMN.PROD_QTY]);        //완료수량
                    //        gridWPDW12.SetData(gridWPDW12.Rows.Fixed + ii, gridWPDW12.Cols.Fixed + 9, dtData1.Rows[i][gridWPDW12_COLUMN.EMP_DESC]);        //작업자명


                    //        if (dtData1.Rows[i][gridWPDW12_COLUMN.REAL_START_TM].ToString().Length > 0)
                    //            gridWPDW12.SetData(gridWPDW12.Rows.Fixed + ii, gridWPDW12.Cols.Fixed + 10, DateTime.Parse(dtData1.Rows[i][gridWPDW12_COLUMN.REAL_START_TM].ToString()).ToString("hh:mm"));   //시작시각
                    //        else
                    //            gridWPDW12.SetData(gridWPDW12.Rows.Fixed + ii, gridWPDW12.Cols.Fixed + 10, "");   //시작시각

                    //        if (dtData1.Rows[i][gridWPDW12_COLUMN.REAL_END_TM].ToString().Length > 0)
                    //            gridWPDW12.SetData(gridWPDW12.Rows.Fixed + ii, gridWPDW12.Cols.Fixed + 11, DateTime.Parse(dtData1.Rows[i][gridWPDW12_COLUMN.REAL_END_TM].ToString()).ToString("hh:mm"));    //종료시각
                    //        else
                    //            gridWPDW12.SetData(gridWPDW12.Rows.Fixed + ii, gridWPDW12.Cols.Fixed + 11, "");    //종료시각

                    //        gridWPDW12.SetData(gridWPDW12.Rows.Fixed + ii, gridWPDW12.Cols.Fixed + 12, dtData1.Rows[i][gridWPDW12_COLUMN.REAL_START_TM]);    //시각시각저장
                    //        gridWPDW12.SetData(gridWPDW12.Rows.Fixed + ii, gridWPDW12.Cols.Fixed + 13, dtData1.Rows[i][gridWPDW12_COLUMN.RESULT_NO]);    //실적번호
                    //        gridWPDW12.SetData(gridWPDW12.Rows.Fixed + ii, gridWPDW12.Cols.Fixed + 14, "");    //금형번호
                    //        gridWPDW12.SetData(gridWPDW12.Rows.Fixed + ii, gridWPDW12.Cols.Fixed + 15, dtData1.Rows[i][gridWPDW12_COLUMN.CAVITY]);    //캐비티
                    //        gridWPDW12.SetData(gridWPDW12.Rows.Fixed + ii, gridWPDW12.Cols.Fixed + 16, dtData1.Rows[i][gridWPDW12_COLUMN.LOT_DEEP]);    //박스당판수
                    //        gridWPDW12.SetData(gridWPDW12.Rows.Fixed + ii, gridWPDW12.Cols.Fixed + 17, dtData1.Rows[i][gridWPDW12_COLUMN.EMP_NO]);    //박스당판수
                    //        ii++;
                    //    }

                }




            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "작업지시정보조회");
            }
            finally
            {
                LoadingForm(false);
            }
            */
        }
        #endregion ▶▶▶ 작업지시현황 정보 조회



        #region ▶▶▶ 자재예약 정보 조회
        private void DBQuery_WorkReservation(string p_WK_ORD_NO)  //자재예약정보
        {
            int nCnt = 0;
            try
            {
                //LoadingForm(true);
                Grid2.SuspendLayout();

                


                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MESSVR_PO_STOCK_WORK_GET2 @WK_ORD_NO='" + p_WK_ORD_NO + "', ";
                strData += "@FACILITY_CD='" + sFACILITY_CD + "'";

                DataTable dtData1 = null;
                dtData1 = new DataTable();


                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);
                //string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (@strState.Equals("OK") == false)
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "자재소요현황 조회");
                    return;
                }

                Grid2.Rows.Clear();

                if (dtData1 != null)
                {
                    for (int i = 0; i < dtData1.Rows.Count; i++)
                    {

                        Grid2.Rows.Add();

                        Grid2.Rows[i].Cells[grid2_COLUMN.ITEM_CD].Value = dtData1.Rows[i][grid2_COLUMN.ITEM_CD].ToString(); //품번 
                        Grid2.Rows[i].Cells[grid2_COLUMN.ITEM_NM].Value = dtData1.Rows[i][grid2_COLUMN.ITEM_NM].ToString(); //품명 

                        if (dtData1.Rows[i][grid2_COLUMN.BASE_UNIT].ToString() == "KG" || dtData1.Rows[i][grid2_COLUMN.BASE_UNIT].ToString() == "G")
                        {
                            Grid2.Rows[i].Cells[grid2_COLUMN.RESV_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid2_COLUMN.RESV_QTY].ToString()).ToString("N2"); //소요량
                            Grid2.Rows[i].Cells[grid2_COLUMN.INV_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid2_COLUMN.INV_QTY].ToString()).ToString("N2"); //총재고량
                            Grid2.Rows[i].Cells[grid2_COLUMN.OUT_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid2_COLUMN.OUT_QTY].ToString()).ToString("N2"); //예약량(SCAN) 잔량
                            //Grid2.Rows[i].Cells[grid2_COLUMN.REAL_USED_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid2_COLUMN.REAL_USED_QTY].ToString()).ToString("N2"); //실소모량
                            Grid2.Rows[i].Cells[grid2_COLUMN.UNIT_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid2_COLUMN.UNIT_QTY].ToString()).ToString("N2"); //단위수량
                        }
                        else
                        {
                            Grid2.Rows[i].Cells[grid2_COLUMN.RESV_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid2_COLUMN.RESV_QTY].ToString()).ToString("N0"); //소요량
                            Grid2.Rows[i].Cells[grid2_COLUMN.INV_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid2_COLUMN.INV_QTY].ToString()).ToString("N0"); //총재고량
                            Grid2.Rows[i].Cells[grid2_COLUMN.OUT_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid2_COLUMN.OUT_QTY].ToString()).ToString("N0"); //예약량(SCAN) 잔량
                            //Grid2.Rows[i].Cells[grid2_COLUMN.REAL_USED_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid2_COLUMN.REAL_USED_QTY].ToString()).ToString("N0"); //실소모량
                            Grid2.Rows[i].Cells[grid2_COLUMN.UNIT_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid2_COLUMN.UNIT_QTY].ToString()).ToString("N0"); //단위수량
                        }

                        Grid2.Rows[i].Cells[grid2_COLUMN.BASE_UNIT].Value = dtData1.Rows[i][grid2_COLUMN.BASE_UNIT].ToString(); //단위
                        //Grid2.Rows[i].Cells[grid2_COLUMN.PUBLIC_NM].Value = dtData1.Rows[i][grid2_COLUMN.PUBLIC_NM].ToString(); //구분
                        //Grid2.Rows[i].Cells[grid2_COLUMN.PUBLIC_FLAG].Value = dtData1.Rows[i][grid2_COLUMN.PUBLIC_FLAG].ToString(); //구분

                        Grid2.Rows[i].Cells[grid2_COLUMN.WK_ORD_NO].Value = dtData1.Rows[i][grid2_COLUMN.WK_ORD_NO].ToString(); //지시번호
                        Grid2.Rows[i].Cells[grid2_COLUMN.PRODT_ORDER_NO].Value = dtData1.Rows[i][grid2_COLUMN.PRODT_ORDER_NO].ToString(); //제조오더번호
                        Grid2.Rows[i].Cells[grid2_COLUMN.OPR_NO].Value = dtData1.Rows[i][grid2_COLUMN.OPR_NO].ToString(); //공순
                        
                    }

                    if (Grid2.Rows.Count > 0) Grid2.Rows[0].Cells[0].Selected = true;

                }

                TGSClass.Util.Grid_Resize(Grid2);
            }
            catch (Exception e)
            {
                TGSControl.UsrFunction.MessageBoxErr(e.Message, "자재소요현황 조회");
            }
            finally
            {
                //LoadingForm(false);
                Grid2.ResumeLayout();
                Grid2.PerformLayout();
            }
            
        }
        #endregion ▶▶▶ 자재예약 정보 조회


        #region ▶▶▶ 재고상세 조회
        private void DBQuery_Stock_Work(string p_ITEM_CD, string p_PRNT_ITEM_CD) //품목의 창고재고조회
        {
            int nCnt = 0;
            try
            {
                //LoadingForm(true);



                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MESSVR_PO_STOCK_ITEM_GET @PLANT_CD='" + sPLANT_CD + "', ";
                strData += "@ITEM_CD='" + p_ITEM_CD + "',";
                strData += "@WC_MGR='" + sWC_MGR + "',";
                strData += "@PRNT_ITEM_CD='" + p_PRNT_ITEM_CD + "'";



                DataTable dtData1 = null;
                dtData1 = new DataTable();


                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);
                //string strState = TGSClass.DataBase.GetDataSql(this.ParentForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (@strState.Equals("OK") == false)
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "창고별재고 조회");
                    return;
                }

                Grid3.Rows.Clear();
                if (dtData1 != null)
                {
                    int k = 0;
                    for (int i = 0; i < dtData1.Rows.Count; i++)
                    {

                        
                        if (Convert.ToDecimal(dtData1.Rows[i][grid3_COLUMN.GOOD_QTY].ToString()) > 0)
                        {
                            Grid3.Rows.Add();

                            Grid3.Rows[k].Cells[grid3_COLUMN.LOC_NM].Value = dtData1.Rows[i][grid3_COLUMN.LOC_NM].ToString(); //창고 
                            if (dtData1.Rows[i][grid3_COLUMN.INV_UNIT].ToString() == "KG" || dtData1.Rows[i][grid3_COLUMN.INV_UNIT].ToString() == "G")
                            {
                                Grid3.Rows[k].Cells[grid3_COLUMN.GOOD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid3_COLUMN.GOOD_QTY].ToString()).ToString("N2"); //재고량
                            }
                            else
                            {
                                Grid3.Rows[k].Cells[grid3_COLUMN.GOOD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid3_COLUMN.GOOD_QTY].ToString()).ToString("N0"); //재고량
                            }

                            Grid3.Rows[k].Cells[grid3_COLUMN.INV_UNIT].Value = dtData1.Rows[i][grid3_COLUMN.INV_UNIT].ToString(); //단위

                            Grid3.Rows[k].Cells[grid3_COLUMN.LOC_NM1].Value = Convert.ToDecimal(dtData1.Rows[i][grid3_COLUMN.LOC_NM1].ToString()).ToString("N0"); //창고1 
                            Grid3.Rows[k].Cells[grid3_COLUMN.LOC_NM2].Value = Convert.ToDecimal(dtData1.Rows[i][grid3_COLUMN.LOC_NM2].ToString()).ToString("N0"); //창고2
                            Grid3.Rows[k].Cells[grid3_COLUMN.LOC_NM3].Value = Convert.ToDecimal(dtData1.Rows[i][grid3_COLUMN.LOC_NM3].ToString()).ToString("N0"); //창고3 
                            Grid3.Rows[k].Cells[grid3_COLUMN.LOC_NM4].Value = Convert.ToDecimal(dtData1.Rows[i][grid3_COLUMN.LOC_NM4].ToString()).ToString("N0"); //창고4
                            Grid3.Rows[k].Cells[grid3_COLUMN.LOC_NM5].Value = Convert.ToDecimal(dtData1.Rows[i][grid3_COLUMN.LOC_NM5].ToString()).ToString("N0"); //창고5
                            k = k + 1;
                        }
                    }
                }
                TGSClass.Util.Grid_Resize(Grid3);
            }
            catch (Exception e)
            {
                TGSControl.UsrFunction.MessageBoxErr(e.Message, "창고별재고 조회");
            }
            finally
            {
                //LoadingForm(false);
            }

        }
        #endregion ▶▶▶ 재고상세 조회

        #region ▶▶▶ LOT SCAN 정보 조회
        private void DBQuery_WorkLotResule(string p_WK_ORD_NO, string p_Facility_CD, string p_CHILD_ITEM_CD)    //lot예약정보
        {
            
            int nCnt = 0;
            try
            {
                //LoadingForm(true);

                

                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MES_P1003M1_GET_LOT_SCAN @PLANT_CD='" + sPLANT_CD + "', ";
                strData += "@WK_ORD_NO='" + p_WK_ORD_NO + "'";

                DataTable dtData1 = null;
                dtData1 = new DataTable();


                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);
                //string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (@strState.Equals("OK") == false)
                {
                    
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "자재투입 조회");
                    return;
                }

                Grid4.Rows.Clear();
                TGSClass.Util.Grid_Resize(Grid4);
                if (dtData1 != null)
                {
                    decimal vLotScanQty = 0;
                    decimal vResvQty = 0;

                    for (int i = 0; i < dtData1.Rows.Count; i++)
                    {

                        Grid4.Rows.Add();

                        Grid4.Rows[i].Cells[grid4_COLUMN.SEQ].Value = (i + 1).ToString(); //순번
                        Grid4.Rows[i].Cells[grid4_COLUMN.ITEM_CD].Value = dtData1.Rows[i][grid4_COLUMN.ITEM_CD].ToString(); //품번
                        Grid4.Rows[i].Cells[grid4_COLUMN.ITEM_NM].Value = dtData1.Rows[i][grid4_COLUMN.ITEM_NM].ToString(); //품명
                        Grid4.Rows[i].Cells[grid4_COLUMN.LOT_NO].Value = dtData1.Rows[i][grid4_COLUMN.LOT_NO].ToString(); //LOT NO 
                        if (dtData1.Rows[i][grid4_COLUMN.INV_UNT].ToString().ToUpper() == "KG" || dtData1.Rows[i][grid4_COLUMN.INV_UNT].ToString().ToUpper() == "G")
                        {
                            Grid4.Rows[i].Cells[grid4_COLUMN.INV_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid4_COLUMN.INV_QTY].ToString()).ToString("N2"); //재고량
                            Grid4.Rows[i].Cells[grid4_COLUMN.OUT_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid4_COLUMN.OUT_QTY].ToString()).ToString("N2"); //예약량(SCAN)
                            Grid4.Rows[i].Cells[grid4_COLUMN.REAL_USED_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid4_COLUMN.REAL_USED_QTY].ToString()).ToString("N2"); //실소모량
                        }
                        else
                        {
                            Grid4.Rows[i].Cells[grid4_COLUMN.INV_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid4_COLUMN.INV_QTY].ToString()).ToString("N0"); //재고량
                            Grid4.Rows[i].Cells[grid4_COLUMN.OUT_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid4_COLUMN.OUT_QTY].ToString()).ToString("N0"); //예약량(SCAN)
                            Grid4.Rows[i].Cells[grid4_COLUMN.REAL_USED_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid4_COLUMN.REAL_USED_QTY].ToString()).ToString("N0"); //실소모량
                        }
                        Grid4.Rows[i].Cells[grid4_COLUMN.INV_QTY].Style.ForeColor = Color.Blue;

                        Grid4.Rows[i].Cells[grid4_COLUMN.LOC_NM].Value = dtData1.Rows[i][grid4_COLUMN.LOC_NM].ToString(); //적치장
                        Grid4.Rows[i].Cells[grid4_COLUMN.INV_UNT].Value = dtData1.Rows[i][grid4_COLUMN.INV_UNT].ToString(); //단위
                        Grid4.Rows[i].Cells[grid4_COLUMN.STATE_NM].Value = dtData1.Rows[i][grid4_COLUMN.STATE_NM].ToString(); //상태
                        Grid4.Rows[i].Cells[grid4_COLUMN.PUBLIC_NM].Value = dtData1.Rows[i][grid4_COLUMN.PUBLIC_NM].ToString(); //구분
                        Grid4.Rows[i].Cells[grid4_COLUMN.LOC_NO].Value = dtData1.Rows[i][grid4_COLUMN.LOC_NO].ToString(); //적치장

                        vLotScanQty = vLotScanQty + Convert.ToDecimal(dtData1.Rows[i][grid4_COLUMN.INV_QTY].ToString()); //재고량
                        vResvQty = vResvQty + Convert.ToDecimal(dtData1.Rows[i][grid4_COLUMN.OUT_QTY].ToString()); //재고량

                        
                        
                    }

                    lbl_LotScanQty.Value = vLotScanQty.ToString("N0");
                    lbl_RESV_QTY.Value = vResvQty.ToString("N0");
                    
                }

                if (tabControl1.SelectedTab.Name == TABCONTROL_TAB_NAME.SCAN)
                {
                    if (Grid4.Rows.Count > 0)
                    {
                        btn_BAD_PART_INSERT.Visible = true;
                    }
                    else
                    {
                        btn_BAD_PART_INSERT.Visible = false;
                    }
                }

                
            }
            catch (Exception e)
            {
                TGSControl.UsrFunction.MessageBoxErr(e.Message, "자재투입 조회");
            }
            finally
            {
                //LoadingForm(false);
            }
        }
        #endregion ▶▶▶ LOT SCAN 정보 조회

        #region ▶▶▶ 공용 투입 LOT SCAN 정보 조회
        private void DBQuery_WorkLotResule_PUBLIC(string p_WK_ORD_NO, string p_Facility_CD, string p_CHILD_ITEM_CD)    //lot예약정보
        {

            int nCnt = 0;
            try
            {
                //LoadingForm(true);



                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MES_P1003M1_GET_LOT_SCAN_PUBLIC @PLANT_CD='" + sPLANT_CD + "', ";
                strData += "@WK_ORD_NO='" + p_WK_ORD_NO + "',";
                strData += "@FACILITY_CD='" + p_Facility_CD + "',";
                strData += "@CHILD_ITEM_CD='" + p_CHILD_ITEM_CD + "'";


                DataTable dtData1 = null;
                dtData1 = new DataTable();


                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);
                //string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (@strState.Equals("OK") == false)
                {

                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "LOT SCAN 자재투입 조회");
                    return;
                }

                Grid5.Rows.Clear();
                TGSClass.Util.Grid_Resize(Grid5);

                if (dtData1 != null)
                {
                    decimal vLotScanPublicQty = 0;

                    for (int i = 0; i < dtData1.Rows.Count; i++)
                    {

                        Grid5.Rows.Add();

                        Grid5.Rows[i].Cells[grid5_COLUMN.SEQ].Value = (i + 1).ToString(); //순번
                        Grid5.Rows[i].Cells[grid5_COLUMN.ITEM_CD].Value = dtData1.Rows[i][grid5_COLUMN.ITEM_CD].ToString(); //품번
                        Grid5.Rows[i].Cells[grid5_COLUMN.ITEM_NM].Value = dtData1.Rows[i][grid5_COLUMN.ITEM_NM].ToString(); //품명
                        Grid5.Rows[i].Cells[grid5_COLUMN.LOT_NO].Value = dtData1.Rows[i][grid5_COLUMN.LOT_NO].ToString(); //LOT NO
                        if (dtData1.Rows[i][grid5_COLUMN.INV_UNT].ToString().ToUpper() == "KG" || dtData1.Rows[i][grid5_COLUMN.INV_UNT].ToString().ToUpper() == "G")
                        {
                            Grid5.Rows[i].Cells[grid5_COLUMN.INV_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid5_COLUMN.INV_QTY].ToString()).ToString("N2"); //현재고
                            Grid5.Rows[i].Cells[grid5_COLUMN.OUT_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid5_COLUMN.OUT_QTY].ToString()).ToString("N2"); //예약량(SCAN)
                            Grid5.Rows[i].Cells[grid5_COLUMN.REAL_USED_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid5_COLUMN.REAL_USED_QTY].ToString()).ToString("N2"); //실소모량
                        }
                        else
                        {
                            Grid5.Rows[i].Cells[grid5_COLUMN.INV_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid5_COLUMN.INV_QTY].ToString()).ToString("N0"); //현재고
                            Grid5.Rows[i].Cells[grid5_COLUMN.OUT_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid5_COLUMN.OUT_QTY].ToString()).ToString("N0"); //예약량(SCAN)
                            Grid5.Rows[i].Cells[grid5_COLUMN.REAL_USED_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid5_COLUMN.REAL_USED_QTY].ToString()).ToString("N0"); //실소모량
                        }
                        Grid5.Rows[i].Cells[grid5_COLUMN.INV_QTY].Style.ForeColor = Color.Blue;
                        
                        Grid5.Rows[i].Cells[grid5_COLUMN.LOC_NM].Value = dtData1.Rows[i][grid5_COLUMN.LOC_NM].ToString(); //적치장 
                        Grid5.Rows[i].Cells[grid5_COLUMN.INV_UNT].Value = dtData1.Rows[i][grid5_COLUMN.INV_UNT].ToString(); //단위
                        Grid5.Rows[i].Cells[grid5_COLUMN.STATE_NM].Value = dtData1.Rows[i][grid5_COLUMN.STATE_NM].ToString(); //상태
                        Grid5.Rows[i].Cells[grid5_COLUMN.PUBLIC_NM].Value = dtData1.Rows[i][grid5_COLUMN.PUBLIC_NM].ToString(); //구분
                        Grid5.Rows[i].Cells[grid5_COLUMN.LOC_NO].Value = dtData1.Rows[i][grid5_COLUMN.LOC_NO].ToString(); //적치장 

                        if (Convert.ToDecimal(dtData1.Rows[i][grid5_COLUMN.INV_QTY].ToString()) > Convert.ToDecimal(dtData1.Rows[i][grid5_COLUMN.OUT_QTY].ToString()) - Convert.ToDecimal(dtData1.Rows[i][grid5_COLUMN.REAL_USED_QTY].ToString()))
                        {
                            vLotScanPublicQty = vLotScanPublicQty + (Convert.ToDecimal(dtData1.Rows[i][grid5_COLUMN.OUT_QTY].ToString()) - Convert.ToDecimal(dtData1.Rows[i][grid5_COLUMN.REAL_USED_QTY].ToString())); //스캔량
                        }
                        else
                        {
                            vLotScanPublicQty = vLotScanPublicQty + Convert.ToDecimal(dtData1.Rows[i][grid5_COLUMN.INV_QTY].ToString()); //재고량
                        }
                    }


                    lbl_LotScanPublicQty.Value = vLotScanPublicQty.ToString("N0");
                    
                }
                if (tabControl1.SelectedTab.Name == TABCONTROL_TAB_NAME.SCAN_PUBLIC)
                {
                    if (Grid5.Rows.Count > 0)
                    {
                        btn_BAD_PART_INSERT.Visible = true;
                    }
                    else
                    {
                        btn_BAD_PART_INSERT.Visible = false;
                    }
                }

                
            }
            catch (Exception e)
            {
                TGSControl.UsrFunction.MessageBoxErr(e.Message, "LOT SCAN 자재투입 조회");
            }
            finally
            {
                //LoadingForm(false);
            }
        }
        #endregion ▶▶▶ 공용 투입 LOT SCAN 정보 조회



        #region ▶▶▶ LOT SCAN 예약정보 유무 체크
        private int DBQuery_WorkLotScanCheck(string p_WK_ORD_NO, string p_Facility_CD)    //lot scan 예약정보 유무 체크
        {

            int nCnt = 0;
            try
            {
                //LoadingForm(true);

                if (p_WK_ORD_NO == "")
                {
                    TGSControl.UsrFunction.MessageBoxErr("지시서 정보가 없습니다.", "자재투입 체크");
                    return -1;
                }

                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MES_P1003M1_GET_LOT_SCAN_CHECK @PLANT_CD='" + sPLANT_CD + "', ";
                strData += "@WK_ORD_NO='" + p_WK_ORD_NO + "'";



                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);
                //string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (@strState.Equals("OK") == false)
                {

                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "자재투입 체크");
                    return -1;
                }

                if (dtData1 != null)
                {
                    if (dtData1.Rows.Count > 0)
                    {
                        nCnt = Convert.ToInt32(dtData1.Rows[0]["SCAN_COUNT"]); //LOT SCAN 건수
                    }
                }
            }
            catch (Exception e)
            {
                TGSControl.UsrFunction.MessageBoxErr(e.Message, "자재투입 체크");
                return -1;
            }
            finally
            {
                //LoadingForm(false);
            }
            return nCnt;
        }
        #endregion ▶▶▶ LOT SCAN 예약정보 유무 체크


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


        #region ▶▶▶ LOT 스캔한 실적을 삭제한다.
        private void DBDelete_LOT_SCAN()
        {
            if (Grid1.CurrentRow == null ) 
            {
                TGSControl.UsrFunction.MessageBoxErr("작업지시 행을 선택하십시요", "LOT 스캔 삭제");
                return;
            }
            if (Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString() == "")
            {
                TGSControl.UsrFunction.MessageBoxErr("지시내역을 선택하세요.", "LOT 스캔 삭제");
                return;
            }

            if (Grid4.CurrentRow == null)
            {
                TGSControl.UsrFunction.MessageBoxErr("삭제할 행을 선택하십시요", "LOT 스캔 삭제");
                return;
            }


            DBSave_LotScan(Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString(), Grid4.CurrentRow.Cells[grid4_COLUMN.LOT_NO].Value.ToString(), Grid4.CurrentRow.Cells[grid4_COLUMN.LOC_NO].Value.ToString(), "D"); //삭제

        }
        #endregion ▶▶▶ LOT 스캔한 실적을 삭제한다.



        #region ▶▶▶ 공용부품 LOT 스캔한 실적을 삭제한다.
        private void DBDelete_LOT_SCAN_PUBLIC()
        {
            

            if (cboFacility.Value.ToString() == "")
            {
                TGSControl.UsrFunction.MessageBoxErr("설비를 선택하세요.", "공용부품 LOT 스캔 삭제");
                return;
            }

            if (Grid5.CurrentRow == null)
            {
                TGSControl.UsrFunction.MessageBoxErr("삭제할 행을 선택하십시요", "공용부품 LOT 스캔 삭제");
                return;
            }

            //공용부품 롯트스캔
            DBSave_LotScan_PUBLIC("", cboFacility.Value, Grid5.CurrentRow.Cells[grid5_COLUMN.LOT_NO].Value.ToString(), Grid5.CurrentRow.Cells[grid5_COLUMN.LOC_NO].Value.ToString(), "D"); //삭제

        }
        #endregion ▶▶▶ 공용부품 LOT 스캔한 실적을 삭제한다.



        #endregion

        #region ■■ 4.4.3 DBSave(Common)

        private bool DBSave()
        {
            return true;
        }


        private bool DBSave_LotScan(string p_WK_ORD_NO, string p_LOT_NO, string p_LOC_NO, string p_CUD_CHAR)
        {
            try
            {
                int nCnt = 0;



                LoadingForm(true);

                p_WK_ORD_NO = p_WK_ORD_NO.ToUpper();
                p_LOT_NO = p_LOT_NO.ToUpper();
                p_LOC_NO = p_LOC_NO.ToUpper();

                string strData = WorkCode.WorkCd.SQLPROCEDURE; //프로시져 형태로 호출
                strData += "DBO.XUSP_MES_P5001P2_SET_LOT_SCAN";       //프로시져 명
                strData += Global.COLUMNS_DIV + "N" + TGSClass.nsGlobal.Global.Separation.COLUMNS;   //조회데이타가 없을 경우 'N' = nonquery 있을 경우 'Q' = query
                //일반변수 리스트
                strData += "@PLANT_CD" + Global.COLUMNS_DIV;
                strData += "@WK_ORD_NO" + Global.COLUMNS_DIV;
                strData += "@LOT_NO" + Global.COLUMNS_DIV;
                strData += "@LOC_NO" + Global.COLUMNS_DIV;
                strData += "@USER_ID" + Global.COLUMNS_DIV;
                strData += "@CUD_CHAR" + TGSClass.nsGlobal.Global.Separation.COLUMNS;


                //일반변수 리스트의 형식
                strData += Global.DBVarType.VarChar + "(4)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(20)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(30)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(10)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(20)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(1)" + TGSClass.nsGlobal.Global.Separation.COLUMNS;

                //일반변수값 리스트
                strData += sPLANT_CD + Global.COLUMNS_DIV;
                strData += p_WK_ORD_NO + Global.COLUMNS_DIV;
                strData += p_LOT_NO + Global.COLUMNS_DIV;
                strData += p_LOC_NO + Global.COLUMNS_DIV;
                strData += sWORKER_CD + Global.COLUMNS_DIV;
                strData += p_CUD_CHAR + TGSClass.nsGlobal.Global.Separation.COLUMNS;


                //OUTPUT변수 리스트 
                strData += "@RTN_MSG";
                strData += TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //OUTPUT변수 리스트 형식
                strData += Global.DBVarType.VarChar + "(200)" + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //OUTPUT변수값 리스트
                strData += ""; // +TGSClass.nsGlobal.Global.Separation.COLUMNS;




                ////반환테이블이 없을 경우 (OUTPUT 변수가 없을 경우)
                //string strState = TGSClass.DataBase.ExcuteSql(MainForm, strData, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                //반환테이블이 있을 경우(파라메터가 1개 이상이면 테이블로 반환됨 (조회데이타가 있거나 OUTPUT변수가 있을 경우)

                DataTable dtData1 = null;
                dtData1 = new DataTable();
                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);

                if (!strState.Equals("OK"))
                {

                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "롯트스캔 저장 에러");
                    LoadingForm(false);
                    return false;
                }

                ////실적번호를 반환함
                //sRESULT_NO = dtData1.Rows[0]["RESULT_NO"].ToString();

                DBQuery_WorkLotResule(p_WK_ORD_NO, cboFacility.Value, "");//공용자재 스캔 정보창을 갱신

                if (Grid4.Rows.Count > 0) btn_LOT_SCAN_DELETE.Enabled = true;

            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "스캔작업");
            }
            finally
            {
                LoadingForm(false);
            }

            return true;
        }
        #region ▶▶▶ 공용품 롯트 스캔 저장을 한다.

        private bool DBSave_LotScan_PUBLIC(string p_WK_ORD_NO, string p_FACILITY_CD, string p_LOT_NO, string p_LOC_NO, string p_CUD_CHAR)
        {
            try
            {
                int nCnt = 0;

                p_WK_ORD_NO = p_WK_ORD_NO.ToUpper();
                p_FACILITY_CD = p_FACILITY_CD.ToUpper();
                p_LOT_NO = p_LOT_NO.ToUpper();
                p_LOC_NO = p_LOC_NO.ToUpper();

                LoadingForm(true);



                string strData = WorkCode.WorkCd.SQLPROCEDURE; //프로시져 형태로 호출
                strData += "DBO.XUSP_MES_P1003M1_SET_LOT_SCAN_PUBLIC";       //프로시져 명
                strData += Global.COLUMNS_DIV + "N" + TGSClass.nsGlobal.Global.Separation.COLUMNS;   //조회데이타가 없을 경우 'N' = nonquery 있을 경우 'Q' = query
                //일반변수 리스트
                strData += "@PLANT_CD" + Global.COLUMNS_DIV;
                strData += "@WK_ORD_NO" + Global.COLUMNS_DIV;
                strData += "@FACILITY_CD" + Global.COLUMNS_DIV;
                strData += "@LOT_NO" + Global.COLUMNS_DIV;
                strData += "@LOC_NO" + Global.COLUMNS_DIV;
                strData += "@USER_ID" + Global.COLUMNS_DIV;
                strData += "@CUD_CHAR" + TGSClass.nsGlobal.Global.Separation.COLUMNS;


                //일반변수 리스트의 형식
                strData += Global.DBVarType.VarChar + "(4)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(20)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(20)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(30)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(10)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(20)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(1)" + TGSClass.nsGlobal.Global.Separation.COLUMNS;

                //일반변수값 리스트
                strData += sPLANT_CD + Global.COLUMNS_DIV;
                strData += p_WK_ORD_NO + Global.COLUMNS_DIV;
                strData += p_FACILITY_CD + Global.COLUMNS_DIV;
                strData += p_LOT_NO + Global.COLUMNS_DIV;
                strData += p_LOC_NO + Global.COLUMNS_DIV;
                strData += sWORKER_CD + Global.COLUMNS_DIV;
                strData += p_CUD_CHAR + TGSClass.nsGlobal.Global.Separation.COLUMNS;


                //OUTPUT변수 리스트 
                strData += "@RTN_MSG";
                strData += TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //OUTPUT변수 리스트 형식
                strData += Global.DBVarType.VarChar + "(200)" + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //OUTPUT변수값 리스트
                strData += ""; // +TGSClass.nsGlobal.Global.Separation.COLUMNS;




                ////반환테이블이 없을 경우 (OUTPUT 변수가 없을 경우)
                //string strState = TGSClass.DataBase.ExcuteSql(MainForm, strData, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                //반환테이블이 있을 경우(파라메터가 1개 이상이면 테이블로 반환됨 (조회데이타가 있거나 OUTPUT변수가 있을 경우)

                DataTable dtData1 = null;
                dtData1 = new DataTable();
                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);

                if (!strState.Equals("OK"))
                {

                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "공용부품 롯트스캔 저장 에러");
                    LoadingForm(false);
                    return false;
                }

                ////실적번호를 반환함
                //sRESULT_NO = dtData1.Rows[0]["RESULT_NO"].ToString();

                
                //공용자재 스캔 정보창을 갱신
                if (Grid1.CurrentRow != null)
                {
                    if (chk_ITEM_GROUP.ValueChar == "Y")
                        DBQuery_WorkLotResule_PUBLIC(Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString(), cboFacility.Value, "");
                    else
                        DBQuery_WorkLotResule_PUBLIC("", cboFacility.Value, "");
                }
                else
                {
                    DBQuery_WorkLotResule_PUBLIC("", cboFacility.Value, "");
                }

                if (Grid5.Rows.Count > 0) btn_LOT_SCAN_DELETE.Enabled = true;

            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "공용부품 롯트스캔 저장 에러");
            }
            finally
            {
                LoadingForm(false);
            }

            return true;
        }
        #endregion ▶▶▶ 공용품 롯트 스캔 저장을 한다.


        #region ▶▶▶ 작업시작된 지시서를 착수 취소 한다.
        private bool DBSave_Work_Cancel()
        {
            DataTable vDT = new DataTable();
            vDT = null;
            int nCnt = 0;
            try
            {
                if (Grid1.CurrentRow == null)   //선택된 지시내역이 없을 경우
                {
                    TGSControl.UsrFunction.MessageBoxErr("작업시작 된 지시내역을 선택하세요.", "작업취소");
                    return false;
                }
                
                if ( Grid1.CurrentRow.Cells [grid1_COLUMN.RESULT_NO].Value.ToString () == "")
                {
                    TGSControl.UsrFunction.MessageBoxErr("작업시작 된 지시내역을 선택하세요.", "작업취소");
                    return false;
                }

                //if (Grid4.Rows.Count > 0)
                int vScanCount = DBQuery_WorkLotScanCheck(Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString(), sFACILITY_CD);
                if ( vScanCount > 0)
                {
                    TGSControl.UsrFunction.MessageBoxErr("스캔한 데이타가 있어서 삭제 할수가 없습니다.", "작업취소");
                    return false;
                }
                else if (vScanCount == -1)
                {
                    return false;
                }

                //if (dgWorking[nCheckedRow, gridWPDW12_COLUMN.REAL_END_TM].ToString().Length > 0)
                //{
                //    TGSControl.UsrFunction.MessageBoxErr("작업이 완료되어서 취소 할 수 업습니다.", "작업취소");
                //    return;
                //}


                LoadingForm(true);


                string szSendData = WorkCode.WorkCd.WORK_CANCEL;
                szSendData += sPLANT_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString() + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += sWC_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += sFACILITY_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += "0" + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += sWORKER_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += Grid1.CurrentRow.Cells[grid1_COLUMN.RESULT_NO].Value.ToString();

                //string szSendData = nsWorkCode.WorkCode.WorkCd.PO_WORK_CANCEL;
                //szSendData += Global.workinfo.szFactoryCD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += Global.workinfo.szOperatorCD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += dgWorkOrder[nCheckedRow, gridWRDW11_COLUMN.WK_ORD_NO].ToString();
               

                string strState = TGSClass.DataBase.GetDataSql(MainForm, szSendData, ref vDT, ref nCnt);
                if (!strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "작업취소");
                    return false;
                }


                //tabActualOupputs.SelectTab(TABCONTROL_NAME.WorkProcess);

                //System.Drawing.Image imgChecked = Properties.Resources.CheckBoxUnChecked;
                //imgChecked.Tag = "N";


                //gridWRDW11.SetCellImage(nCheckedRow, gridWRDW11.Cols.Fixed + 0, imgChecked); 

                //lblWPWorkSpace.Caption = Global.workinfo.szWorkSpaceNM;
                //lblWPFacilityNM.Caption = lblWRFacilityNM.Caption ;

                

            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "작업취소");
                return false;
            }
            finally
            {
                LoadingForm(false);
            }

            return true;
        }
        #endregion ▶▶▶ 작업시작된 지시서를 착수 취소 한다.




        #endregion

        #endregion

        #endregion ▶ 4. Toolbar method part


        #region ▶ 5. Event method part


        #endregion


        #region ▶ 6. Popup method part

        #region ■ 6.1 Common popup implementation group

        #endregion

        #region ■ 6.2 User-defined popup implementation group

        #region ■■ 6.2.1 Popup 오픈

        //private void opn_ITEM_CD_OpenPopup(object sender, EventArgs e)
        //{
        //    POP_P5001P1 myPopupForm = new POP_P5001P1();

            
        //    DataTable dt = new DataTable("PassData");
        //    dt.Columns.Add("PLANT_CD");
        //    dt.Columns.Add("FACILITY_CD");
        //    dt.Columns.Add("WC_MGR");
        //    dt.Columns.Add("WC_CD");
        //    dt.Columns.Add("WORKER_CD");

        //    dt.Rows.Add();

        //    dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
        //    dt.Rows[0]["FACILITY_CD"] = sFACILITY_CD;
        //    dt.Rows[0]["WC_MGR"] = sWC_MGR;
        //    dt.Rows[0]["WC_CD"] = sWC_CD;
        //    dt.Rows[0]["WORKER_CD"] = cboWorker.Value;

        //    myPopupForm.ResultData.Tables.Add(dt); //변수전달

            
        //    myPopupForm.MainForm = this.MainForm;
        //    myPopupForm.Start();

        //    DialogResult dResult = myPopupForm.ShowDialog();

        //    if (dResult == DialogResult.OK)
        //    {

        //        opn_ITEM_CD.Value = myPopupForm.ResultData.Tables["Result"].Rows[0]["ITEM_CD"].ToString();
        //        opn_ITEM_CD.ValueName = myPopupForm.ResultData.Tables["Result"].Rows[0]["ITEM_NM"].ToString();
        //        lbl_WK_ORD_NO.Caption = myPopupForm.ResultData.Tables["Result"].Rows[0]["WK_ORD_NO"].ToString();
        //        lbl_WK_ORD_QTY.Caption = myPopupForm.ResultData.Tables["Result"].Rows[0]["WK_ORD_QTY"].ToString();
        //        lbl_RESULT_NO.Caption = myPopupForm.ResultData.Tables["Result"].Rows[0]["RESULT_NO"].ToString();
        //        cboWorker.Value = myPopupForm.ResultData.Tables["Result"].Rows[0]["WORKER_CD"].ToString();

        //        //작업지시 정보가 갱신 되어 서 재 조회 함
        //        DBQuery();

        //    }

        //    myPopupForm.Dispose();
        //}
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



        #region 설비작업장정보 조회
        

        private void ProcessInform_Review(string szFacilityCD, ref string szWOrkSpaceCD, ref string szWOrkSpaceNM, bool bQueryOnly) //설비의 작업장 정보 조회
        {
            string strData = string.Empty;
            int nCnt = 0;

            try
            {
                LoadingForm(true);


                // 대표공정 가져오기
                //szSendData = "";
                //szSendData = WorkCode.WorkCd.WORKSPACE_INFORM_REVIEW;
                //szSendData += szFacilityCD;

                strData = ""
                         + "SELECT B.WC_CD,"      //작업장코드
                         + "  B.WC_NM"      //작업장명
                         + " FROM P_RESOURCE AS A (NOLOCK)"
                         + "  INNER JOIN P_WORK_CENTER AS B (NOLOCK) ON A.EXT2_CD = B.WC_CD "
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
                //string strState = TGSClass.DataBase.GetDataSql(sMainForm , szSendData, ref dtData1, ref nCnt,
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
        #endregion 설비작업장정보 조회

        //작업자가 변경되었을 때
        private void cboWorker_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboWorker.SelectedIndex < 0) return;

            sWORKER_CD = cboWorker.Value;

            Global.workinfo.szOperatorCD = cboWorker.Value;
            Global.workinfo.szOperatorNM = cboWorker.ValueName;

            global.ConfigFileWriteAll();

            DBQuery();
        }
        //설비를 변경하였을 때
        private void cboFacility_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboFacility.Value != sFACILITY_CD)
            {
                sFACILITY_CD = cboFacility.Value;
                ProcessInform_Review(sFACILITY_CD, ref sWC_CD, ref sWC_NM, false);   //선택된 설비의 작업장 정보

                DBQuery(); 
            }

        }

        private void opn_ITEM_CD_KeyPress(object sender, KeyPressEventArgs e)
        {
            DBQuery(); 
        }
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFacility.Value == "")
            {
                TGSControl.UsrFunction.MessageBoxInfo("설비를 선택하세요", "설비선택");
                return;
            }
            int vRowIndex = -1;

            switch (tabControl1.SelectedTab.Name)
            {
                case TABCONTROL_TAB_NAME.RESERVATION:


                    if (Grid1.Rows.Count == 0) return;
                    if (Grid1.CurrentRow == null)
                    {
                        vRowIndex = GetFirstRowIndex(Grid1, 0);
                        if (vRowIndex >= 0) Grid1.Rows[vRowIndex].Cells[grid1_COLUMN.ITEM_CD].Selected = true;
                    }

                    //선택된 작업지시서의 자재품번 리스트를 조회
                    if (Grid1.CurrentRow != null) DBQuery_WorkReservation(Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString());

                    //창고별재고현황 조회
                    if (Grid2.CurrentRow == null)
                    {
                        if (Grid2.Rows.Count > 0)
                        {
                            vRowIndex = GetFirstRowIndex(Grid2, 0);
                            if (vRowIndex >= 0) Grid2.Rows[vRowIndex].Cells[0].Selected = true;
                        }

                    }
                    if (Grid2.CurrentRow != null && Grid1.CurrentRow != null)
                        DBQuery_Stock_Work(Grid2.CurrentRow.Cells[grid2_COLUMN.ITEM_CD].Value.ToString(), Grid1.CurrentRow.Cells[grid1_COLUMN.ITEM_CD].Value.ToString());
                    else
                        InitSpreadSheet(3); //하위재고 창을 초기화 한다.

                    btn_LOT_SCAN.Visible = true;    //재고리스트에서 롯트 선택 투입 창 진입 버튼을 활성화 한다.
                    btn_LOT_SCAN_DELETE.Visible = false;    //LOT SCAN 내역 삭제 버튼을 표시하지 않는다.

                    btn_BAD_PART_INSERT.Visible = false; //부품불량등록창 표시안함

                    break;
                case TABCONTROL_TAB_NAME.SCAN:

                    if (Grid1.Rows.Count == 0) return;
                    if (Grid1.CurrentRow == null) 
                    {
                        vRowIndex = GetFirstRowIndex(Grid1, 0);
                        if (vRowIndex >= 0) Grid1.Rows[vRowIndex].Cells[grid1_COLUMN.ITEM_CD].Selected = true;
                    }

                    //선택된 작업지시서의 LOT 스캔 정보 조회
                    if (Grid1.CurrentRow != null) DBQuery_WorkLotResule(Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString(), cboFacility.Value, "");
                    

                    btn_LOT_SCAN.Visible = false;       //재고리스트에서 롯트 선택 투입 창 진입 버튼을 활성화 하지 않는다..
                    btn_LOT_SCAN_DELETE.Visible = true; //LOT SCAN 내역 삭제 버튼을 표시한다.

                    if (Grid4.Rows.Count > 0)
                    {
                        btn_LOT_SCAN_DELETE.Enabled = true;
                        btn_BAD_PART_INSERT.Visible = true;
                    }
                    else
                    {
                        btn_LOT_SCAN_DELETE.Enabled = false;
                        btn_BAD_PART_INSERT.Visible = false;
                    }

                    //선택된 작업지시서의 자재품번 리스트를 조회
                    if (Grid1.CurrentRow != null) DBQuery_WorkReservation(Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString());

                    opn_LOT_SCAN.Focus();

                    break;
                case TABCONTROL_TAB_NAME.SCAN_PUBLIC:
                    //선택된 작업지시서의 공용LOT 스캔 정보 조회
                    //공용자재 스캔 정보창을 갱신
                    if (cboFacility.Value == "") return;
                    
                    if (Grid1.CurrentRow != null)
                    {
                        if (chk_ITEM_GROUP.ValueChar == "Y")
                            DBQuery_WorkLotResule_PUBLIC(Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString(), cboFacility.Value, "");
                        else
                            DBQuery_WorkLotResule_PUBLIC("", cboFacility.Value, "");
                    }
                    else
                    {
                        DBQuery_WorkLotResule_PUBLIC("", cboFacility.Value, "");
                    }


                    btn_LOT_SCAN.Visible = false;       //재고리스트에서 롯트 선택 투입 창 진입 버튼을 활성화 하지 않는다..
                    btn_LOT_SCAN_DELETE.Visible = true; //LOT SCAN 내역 삭제 버튼을 표시한다.

                    if (Grid5.Rows.Count > 0)
                    {
                        btn_LOT_SCAN_DELETE.Enabled = true;
                        btn_BAD_PART_INSERT.Visible = true;
                    }
                    else
                    {
                        btn_LOT_SCAN_DELETE.Enabled = false;
                        btn_BAD_PART_INSERT.Visible = false;
                    }

                    //선택된 작업지시서의 자재품번 리스트를 조회
                    if (Grid1.CurrentRow != null) DBQuery_WorkReservation(Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString());

                    opn_LOT_SCAN_PUBLIC.Focus();
                    break;

                    
            }
        }
        
        //조회버튼을 클릭했을 때
        private void btn_Query_Click(object sender, EventArgs e)
        {
            
            DBQuery();
            
        }
        //자재투입버튼을 클릭했을 때
        private void btn_LOT_SCAN_ButtonClick(object sender, EventArgs e)
        {
            if (Grid2.CurrentRow == null)
            {
                TGSControl.UsrFunction.MessageBoxErr("선택된 자재품목이 없습니다. 품목을 선택하십시오", "자품목투입 스캔");
                return;
            }

            POP_P9002PA1 myPopupForm = new POP_P9002PA1();

            DataTable dt = new DataTable("PassData");
            dt.Columns.Add("WK_ORD_NO");
            dt.Columns.Add("RESULT_NO");
            dt.Columns.Add("ITEM_CD");
            dt.Columns.Add("ITEM_NM");
            dt.Columns.Add("PLANT_CD");
            dt.Columns.Add("FACILITY_CD");
            dt.Columns.Add("WC_MGR");
            dt.Columns.Add("WC_CD");
            dt.Columns.Add("WORKER_CD");
            dt.Columns.Add("RESV_QTY");

            
            dt.Rows.Add();

            dt.Rows[0]["WK_ORD_NO"] = Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString();
            dt.Rows[0]["RESULT_NO"] = Grid1.CurrentRow.Cells[grid1_COLUMN.RESULT_NO].Value.ToString();
            dt.Rows[0]["ITEM_CD"] = Grid2.CurrentRow.Cells[grid2_COLUMN .ITEM_CD ].Value;
            dt.Rows[0]["ITEM_NM"] = Grid2.CurrentRow.Cells[grid2_COLUMN.ITEM_NM ].Value;
            dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
            dt.Rows[0]["FACILITY_CD"] = sFACILITY_CD ;
            dt.Rows[0]["WC_MGR"] = sWC_MGR;
            dt.Rows[0]["WC_CD"] = sWC_CD ;
            dt.Rows[0]["WORKER_CD"] = cboWorker.Value;
            dt.Rows[0]["RESV_QTY"] = Grid2.CurrentRow.Cells[grid2_COLUMN.RESV_QTY].Value;
            

            myPopupForm.ResultData.Tables.Add(dt); //변수전달


            myPopupForm.MainForm = this.MainForm;
            myPopupForm.Start();

            DialogResult dResult = myPopupForm.ShowDialog();

            if (dResult == DialogResult.OK)
            {

                //opn_ITEM_CD.Value = fMatLotScan.ResultData.Tables["Result"].Rows[0]["ITEM_CD"].ToString();
                //opn_ITEM_CD.ValueName = fMatLotScan.ResultData.Tables["Result"].Rows[0]["ITEM_NM"].ToString();
                //lbl_WK_ORD_NO.Caption = fMatLotScan.ResultData.Tables["Result"].Rows[0]["WK_ORD_NO"].ToString();
                //lbl_WK_ORD_QTY.Caption = fMatLotScan.ResultData.Tables["Result"].Rows[0]["WK_ORD_QTY"].ToString();
                ////lbl_DEEP_QTY.Caption = fWorkOrder.ResultData.Tables["Result"].Rows[0]["ITEM_CD"].ToString();

                //작업지시 정보가 갱신 되어 서 재 조회 함
                int v_row = Grid1.CurrentRow.Index;
                DBQuery_WorkReservation(Grid2.CurrentRow.Cells[grid2_COLUMN.WK_ORD_NO].Value.ToString());     //작업예약량 재 조회
                Grid1.Rows[v_row].Cells[grid1_COLUMN.ITEM_CD].Selected = true;

                DBQuery_WorkLotResule(Grid2.CurrentRow.Cells[grid2_COLUMN.WK_ORD_NO].Value.ToString(), cboFacility.Value, Grid2.CurrentRow.Cells[grid2_COLUMN.ITEM_CD].Value.ToString());    //롯트스캔실적 재조회
                
                

            }

            myPopupForm.Dispose();

        }
        //실적처리버튼을 클릭했을 때
        private void btn_WORK_RESULT_ButtonClick(object sender, EventArgs e)
        {
            if (Grid1.CurrentRow == null) return;   //선택된 지시내역이 없을 경우


            if (sWC_MGR == "10" || sRESULT_USER_FLAG == true)    //준비공정일때
            {
                //부품 재고량을 감안해서 실적등록할 수량을 자동 계산함 (준비공정은 자재투입이 1품목만 투입함)
                decimal vLOT_SCAN_QTY = 0;
                decimal vWK_ORD_QTY = Convert.ToDecimal(Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_QTY].Value.ToString()) - Convert.ToDecimal(Grid1.CurrentRow.Cells[grid1_COLUMN.PROD_QTY].Value.ToString());  //지시잔량
                decimal vWORK_QTY = vWK_ORD_QTY;

                decimal vRESV_QTY = 0;   //예약잔량
                decimal vRate = 1;

                for (int i = 0; i < Grid2.Rows.Count; i++)
                {

                    vRESV_QTY = Convert.ToDecimal(Grid2.Rows[i].Cells[grid2_COLUMN.RESV_QTY].Value.ToString());   //예약잔량

                    
                    if (vRESV_QTY > 0)
                    {
                         vRate = decimal.Round((vWK_ORD_QTY / vRESV_QTY), 2);
                    }
                    else
                    {
                        vRate = 1;
                    }


                    vLOT_SCAN_QTY = decimal.Round(Convert.ToDecimal(Grid2.Rows[i].Cells[grid2_COLUMN.OUT_QTY].Value.ToString()) * vRate, 0);  // - Convert.ToDecimal(Grid2.Rows[i].Cells[grid2_COLUMN.REAL_USED_QTY].Value.ToString());
                    if (vWORK_QTY > vLOT_SCAN_QTY) vWORK_QTY = vLOT_SCAN_QTY;
                }



                POP_P9002PA2 myPopupForm = new POP_P9002PA2();

                DataTable dt = new DataTable("PassData");
                dt.Columns.Add("WK_ORD_NO");
                dt.Columns.Add("RESULT_NO");
                dt.Columns.Add("ITEM_CD");
                dt.Columns.Add("ITEM_NM");
                dt.Columns.Add("PLANT_CD");
                dt.Columns.Add("FACILITY_CD");
                dt.Columns.Add("WC_MGR");
                dt.Columns.Add("WC_CD");
                dt.Columns.Add("WK_ORD_QTY");
                dt.Columns.Add("WORK_QTY");
                dt.Columns.Add("LOT_QTY");
                dt.Columns.Add("WORKER_ID");
                dt.Columns.Add("WORKER_NM");
                dt.Columns.Add("REAL_START_DT");

                dt.Columns.Add("RESULT_USER_FLAG");
                dt.Columns.Add("RESULT_USER_DT");
                

                dt.Rows.Add();

                dt.Rows[0]["WK_ORD_NO"] = Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString();
                dt.Rows[0]["RESULT_NO"] = Grid1.CurrentRow.Cells[grid1_COLUMN.RESULT_NO].Value.ToString();
                dt.Rows[0]["ITEM_CD"] = Grid1.CurrentRow.Cells[grid1_COLUMN.ITEM_CD].Value.ToString();
                dt.Rows[0]["ITEM_NM"] = Grid1.CurrentRow.Cells[grid1_COLUMN.ITEM_NM].Value.ToString();
                dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
                dt.Rows[0]["FACILITY_CD"] = sFACILITY_CD;
                dt.Rows[0]["WC_MGR"] = sWC_MGR;
                dt.Rows[0]["WC_CD"] = sWC_CD;
                dt.Rows[0]["WK_ORD_QTY"] = Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_QTY].Value.ToString();
                dt.Rows[0]["WORK_QTY"] = vWORK_QTY.ToString("N2"); //Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_QTY].Value.ToString();
                dt.Rows[0]["LOT_QTY"] = Grid1.CurrentRow.Cells[grid1_COLUMN.LOT_QTY].Value.ToString();
                dt.Rows[0]["WORKER_ID"] = Grid1.CurrentRow.Cells[grid1_COLUMN.WORKER_ID].Value.ToString(); // cboWorker.Value;
                dt.Rows[0]["WORKER_NM"] = Grid1.CurrentRow.Cells[grid1_COLUMN.EMP_DESC].Value.ToString(); // cboWorker.Value;
                dt.Rows[0]["REAL_START_DT"] = Grid1.CurrentRow.Cells[grid1_COLUMN.REAL_START_TM].Value.ToString();

                if (sRESULT_USER_FLAG == true)
                {
                    dt.Rows[0]["RESULT_USER_FLAG"] = "Y";
                }
                else
                {
                    dt.Rows[0]["RESULT_USER_FLAG"] = "N";
                }
                dt.Rows[0]["RESULT_USER_DT"] = sRESULT_USER_DT;

                myPopupForm.ResultData.Tables.Add(dt); //변수전달


                myPopupForm.MainForm = this.MainForm;
                myPopupForm.Start();

                DialogResult dResult = myPopupForm.ShowDialog();

                if (dResult == DialogResult.OK)
                {

                    //실적처리 완료
                    DBQuery();

                    TGSControl.UsrFunction.MessageBoxInfo("실적저장 및 바코드를 출력 하였습니다.", "실적처리 완료");

                }

                myPopupForm.Dispose();

            }
            else
            {
                //내부에서 명령을 생성해준후 명령이벤트를 실행한다.
                CommandRun_Event(0);
            }

        }


        //행의 첫 시작 위치를 선택할 때 row위치가 visible = false 이면 오류 발생함으로 visible 여부를 체크 함
        private int GetFirstRowIndex(DataGridView pGrid, int pRowIndex)
        {
            int i = 0;

            for (i = pRowIndex; i < pGrid.Rows.Count; i++)
            {
                if (pGrid.Rows[i].Visible == true)
                {
                    return i;
                    //break;
                }
            }

            return -1;
        }

        private void btn_Before_ButtonClick(object sender, EventArgs e)
        {
            if (sGrid_Current_id == 2)    //그리드 2가 활성화 상태이면 다음 버튼을 누르면 그리드2의 페이지가 변경됨
            {
                int vDisplayedRowCount = Grid2.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid2.FirstDisplayedScrollingRowIndex - vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex < 0)
                        Grid2.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid2, 0);
                    else
                        Grid2.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid2, Grid2.FirstDisplayedScrollingRowIndex - vDisplayedRowCount);
                }
            }
            else if (sGrid_Current_id == 3)    //그리드 2가 활성화 상태이면 다음 버튼을 누르면 그리드2의 페이지가 변경됨
            {
                int vDisplayedRowCount = Grid3.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid3.FirstDisplayedScrollingRowIndex - vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex < 0)
                        Grid3.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid3, 0);
                    else
                        Grid3.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid3, Grid3.FirstDisplayedScrollingRowIndex - vDisplayedRowCount);
                }
            }
            else if (sGrid_Current_id == 4)    //그리드 2가 활성화 상태이면 다음 버튼을 누르면 그리드2의 페이지가 변경됨
            {
                int vDisplayedRowCount = Grid4.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid4.FirstDisplayedScrollingRowIndex - vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex < 0)
                        Grid4.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid4, 0);
                    else
                        Grid4.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid4, Grid4.FirstDisplayedScrollingRowIndex - vDisplayedRowCount);
                }
            }
            else if (sGrid_Current_id == 5)    //그리드 2가 활성화 상태이면 다음 버튼을 누르면 그리드2의 페이지가 변경됨
            {
                int vDisplayedRowCount = Grid5.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid5.FirstDisplayedScrollingRowIndex - vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex < 0)
                        Grid5.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid5, 0);
                    else
                        Grid5.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid5, Grid5.FirstDisplayedScrollingRowIndex - vDisplayedRowCount);
                }
            }
            else
            {
                int vDisplayedRowCount = Grid1.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid1.FirstDisplayedScrollingRowIndex - vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex <= 0)
                        Grid1.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid1, 0);
                    else
                        Grid1.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid1, Grid1.FirstDisplayedScrollingRowIndex - vDisplayedRowCount);
                }
            }
        }


        private void btn_Next_ButtonClick(object sender, EventArgs e)
        {
            if (sGrid_Current_id == 4)    //그리드 4가 활성화 상태이면 다음 버튼을 누르면 그리드2의 페이지가 변경됨
            {
                int vDisplayedRowCount = Grid4.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid4.FirstDisplayedScrollingRowIndex + vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex >= Grid4.Rows.Count)
                        Grid4.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid4, Grid4.Rows.Count - 1);
                    else
                        Grid4.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid4, vFirstDisplayedScrollingRowIndex);
                }
            }
            else if (sGrid_Current_id == 5)    //그리드 5가 활성화 상태이면 다음 버튼을 누르면 그리드2의 페이지가 변경됨
            {
                int vDisplayedRowCount = Grid5.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid5.FirstDisplayedScrollingRowIndex + vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex >= Grid5.Rows.Count)
                        Grid5.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid5, Grid5.Rows.Count - 1);
                    else
                        Grid5.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid5, vFirstDisplayedScrollingRowIndex);
                }
            }
            else if (sGrid_Current_id == 3)    //그리드 3가 활성화 상태이면 다음 버튼을 누르면 그리드2의 페이지가 변경됨
            {
                int vDisplayedRowCount = Grid3.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid3.FirstDisplayedScrollingRowIndex + vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex >= Grid3.Rows.Count)
                        Grid3.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid3, Grid3.Rows.Count - 1);
                    else
                        Grid3.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid3, vFirstDisplayedScrollingRowIndex);
                }
            }
            else if (sGrid_Current_id == 2)    //그리드 2가 활성화 상태이면 다음 버튼을 누르면 그리드2의 페이지가 변경됨
            {
                int vDisplayedRowCount = Grid2.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid2.FirstDisplayedScrollingRowIndex + vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex >= Grid2.Rows.Count)
                        Grid2.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid2, Grid2.Rows.Count - 1);
                    else
                        Grid2.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid2, vFirstDisplayedScrollingRowIndex);
                }
            }
            else
            { 
                int vDisplayedRowCount = Grid1.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid1.FirstDisplayedScrollingRowIndex + vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex >= Grid1.Rows.Count)
                        Grid1.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid1, Grid1.Rows.Count - 1);
                    else
                        Grid1.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid1, vFirstDisplayedScrollingRowIndex);
                }
            }

            
        }

        private void Grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid1.CurrentRow != null)
            {
                //APP_P0204M1  소요자재로트로 작업지시번호 세팅
                if (Grid1.CurrentRow != null)
                {
                    sWK_ORD_NO = Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString();
                    
                    //MES_APP_P02.APP_P0201M1 apP_P0201M11 = new MES_APP_P02.APP_P0201M1();
                    //apP_P0201M11.SetValue(MES_APP_P02.APP_P0201M1.SetValueName.WK_ORD_NO, Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString());

                    if (Convert.ToDecimal(Grid1.CurrentRow.Cells[grid1_COLUMN.PROD_QTY].Value.ToString()) > 0)
                    {
                        btn_WORK_CANCEL.Caption = "작업완료";
                    }
                    else
                    {
                        btn_WORK_CANCEL.Caption = "작업취소";
                    }
                }
                switch (tabControl1.SelectedTab.Name)
                {
                    case TABCONTROL_TAB_NAME.RESERVATION:

                        //선택된 작업지시서의 자재품번 리스트를 조회
                        if (Grid1.CurrentRow != null) DBQuery_WorkReservation(Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString());

                        //창고별재고현황 조회
                        if (Grid2.CurrentRow == null)
                        {
                            if (Grid2.Rows.Count > 0) Grid2.Rows[0].Cells[0].Selected = true;

                        }
                        if (Grid2.CurrentRow != null && Grid1.CurrentRow != null)
                            DBQuery_Stock_Work(Grid2.CurrentRow.Cells[grid1_COLUMN.ITEM_CD].Value.ToString(), Grid1.CurrentRow.Cells[grid1_COLUMN.ITEM_CD].Value.ToString());
                        else
                            InitSpreadSheet(3); //하위재고 창을 초기화 한다.

                        btn_LOT_SCAN.Visible = true;    //재고리스트에서 롯트 선택 투입 창 진입 버튼을 활성화 한다.
                        btn_LOT_SCAN_DELETE.Visible = false;    //LOT SCAN 내역 삭제 버튼을 표시하지 않는다.

                        break;
                    case TABCONTROL_TAB_NAME.SCAN:
                        //선택된 작업지시서의 LOT 스캔 정보 조회
                        DBQuery_WorkLotResule(Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString(), cboFacility.Value, "");
                        

                        btn_LOT_SCAN.Visible = false;       //재고리스트에서 롯트 선택 투입 창 진입 버튼을 활성화 하지 않는다..
                        btn_LOT_SCAN_DELETE.Visible = true; //LOT SCAN 내역 삭제 버튼을 표시한다.

                        if (Grid4.Rows.Count > 0)
                            btn_LOT_SCAN_DELETE.Enabled = true;
                        else
                            btn_LOT_SCAN_DELETE.Enabled = false;

                        break;
                    case TABCONTROL_TAB_NAME.SCAN_PUBLIC:
                        //선택된 작업지시서의 공용LOT 스캔 정보 조회
                        //공용자재 스캔 정보창을 갱신
                        if (chk_ITEM_GROUP.ValueChar == "Y")
                            DBQuery_WorkLotResule_PUBLIC(Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString(), cboFacility.Value, "");
                        else
                            DBQuery_WorkLotResule_PUBLIC("", cboFacility.Value, "");


                        btn_LOT_SCAN.Visible = false;       //재고리스트에서 롯트 선택 투입 창 진입 버튼을 활성화 하지 않는다..
                        btn_LOT_SCAN_DELETE.Visible = true; //LOT SCAN 내역 삭제 버튼을 표시한다.

                        if (Grid5.Rows.Count > 0)
                            btn_LOT_SCAN_DELETE.Enabled = true;
                        else
                            btn_LOT_SCAN_DELETE.Enabled = false;

                        break;
                }

            }
        }

        private void Grid2_CellClick(object sender, DataGridViewCellEventArgs e)    //부품소요량 그리드를 클릭 시 재고현황을 보여준다.
        {
            if (Grid1.CurrentRow != null)
            {

                //창고별재고현황 조회
                if (Grid2.CurrentRow == null)
                {
                    if (Grid2.Rows.Count > 0) Grid2.Rows[0].Cells[0].Selected = true;

                }
                if (Grid2.CurrentRow != null && Grid1.CurrentRow != null)
                    DBQuery_Stock_Work(Grid2.CurrentRow.Cells[grid1_COLUMN.ITEM_CD].Value.ToString(), Grid1.CurrentRow.Cells[grid1_COLUMN.ITEM_CD].Value.ToString()); //하위재고를 표시한다.
                else
                    InitSpreadSheet(3); //하위재고 창을 초기화 한다.

                btn_LOT_SCAN.Visible = true;    //재고리스트에서 롯트 선택 투입 창 진입 버튼을 활성화 한다.
                btn_LOT_SCAN_DELETE.Visible = false;    //LOT SCAN 내역 삭제 버튼을 표시하지 않는다.

            }
        }

        //작업시작 취소
        private void btn_WORK_CANCEL_ButtonClick(object sender, EventArgs e)//착수 시작된 작업지시를 착수 취소한다.
        {
            
            if (DBSave_Work_Cancel())   //작업시작 취소
            {

                TGSControl.UsrFunction.MessageBoxInfo("작업을 취소 하였습니다.", "작업취소 완료");

                //실적취소 완료, 작업지시 내역을 다시 조회한다.
                DBQuery();
            }

            
        }

        


        private void btn_LOT_SCAN_DELETE_ButtonClick(object sender, EventArgs e) //LOT 스캔 내역을 삭제한다.
        {

            switch (tabControl1.SelectedTab.Name)
            {
                case TABCONTROL_TAB_NAME.SCAN:
                    DBDelete_LOT_SCAN(); //LOT 스캔 내역을 삭제한다.
                    break;
                case TABCONTROL_TAB_NAME.SCAN_PUBLIC:
                    DBDelete_LOT_SCAN_PUBLIC(); //공용 LOT 스캔 내역을 삭제한다.
                    break;
            }

        }

        private void opn_LOT_SCAN_EnterKeyDown(object sender, EventArgs e)  //자재LOT 스캔 시
        {
           
            //부품 롯트스캔
            string vScanLot = opn_LOT_SCAN.Value;
            vScanLot = TGSClass.Util.ScanLotReplace(vScanLot);
            //vScanLot = vScanLot.Replace("ㅔ", "P");
            //vScanLot = vScanLot.Replace("ㅖ", "P");
            //vScanLot = vScanLot.Replace("ㅁ", "A");
            //vScanLot = vScanLot.Replace("ㅠ", "B");
            //vScanLot = vScanLot.Replace("ㅡ", "M");
            //vScanLot = vScanLot.Replace("ㅂ", "Q");
            //vScanLot = vScanLot.Replace("ㅃ", "Q");
            //vScanLot = vScanLot.Replace("ㄴ", "S");
            //vScanLot = vScanLot.Replace("ㅅ", "T");
            //vScanLot = vScanLot.Replace("ㅆ", "T");
            //vScanLot = vScanLot.Replace("ㅍ", "V");

            opn_LOT_SCAN.Value = vScanLot.ToUpper();

            if (Grid1.CurrentRow == null)
            {
                opn_LOT_SCAN.Value = "";
                return;
            }

            DBSave_LotScan(Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString(), opn_LOT_SCAN.Value, "", "C"); //신규등록

            opn_LOT_SCAN.Value = "";
        }

        private void opn_LOT_SCAN_PUBLIC_EnterKeyDown(object sender, EventArgs e)   //공용자재 LOT 스캔 시
        {
            
            //공용부품 롯트스캔
            string vScanLot = opn_LOT_SCAN_PUBLIC.Value;
            vScanLot = TGSClass.Util.ScanLotReplace(vScanLot);
            //vScanLot = vScanLot.Replace("ㅔ", "P");
            //vScanLot = vScanLot.Replace("ㅖ", "P");
            //vScanLot = vScanLot.Replace("ㅁ", "A");
            //vScanLot = vScanLot.Replace("ㅠ", "B");
            //vScanLot = vScanLot.Replace("ㅡ", "M");
            //vScanLot = vScanLot.Replace("ㅂ", "Q");
            //vScanLot = vScanLot.Replace("ㅃ", "Q");
            //vScanLot = vScanLot.Replace("ㄴ", "S");
            //vScanLot = vScanLot.Replace("ㅅ", "T");
            //vScanLot = vScanLot.Replace("ㅆ", "T");
            //vScanLot = vScanLot.Replace("ㅍ", "V");

            opn_LOT_SCAN_PUBLIC.Value = vScanLot.ToUpper();

            //DBSave_LotScan_PUBLIC(Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString(), cboFacility.Value, opn_LOT_SCAN_PUBLIC.Value, "", "C"); //신규등록
            DBSave_LotScan_PUBLIC("", cboFacility.Value, opn_LOT_SCAN_PUBLIC.Value, "", "C"); //신규등록
            opn_LOT_SCAN_PUBLIC.Value = "";
        }

        private void chk_ITEM_GROUP_CheckedChange(object sender, EventArgs e)   //공용자재에서 품목그룹별 집계 선택 시
        {
            

            //선택된 작업지시서의 공용LOT 스캔 정보 조회
            //공용자재 스캔 정보창을 갱신
            if (Grid1.CurrentRow != null)
            {
                if (chk_ITEM_GROUP.ValueChar == "Y")
                    DBQuery_WorkLotResule_PUBLIC(Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString(), cboFacility.Value, "");
                else
                    DBQuery_WorkLotResule_PUBLIC("", cboFacility.Value, "");
            }
            else
            {
                DBQuery_WorkLotResule_PUBLIC("", cboFacility.Value, "");
            }


            btn_LOT_SCAN.Visible = false;       //재고리스트에서 롯트 선택 투입 창 진입 버튼을 활성화 하지 않는다..
            btn_LOT_SCAN_DELETE.Visible = true; //LOT SCAN 내역 삭제 버튼을 표시한다.

            if (Grid5.Rows.Count > 0)
                btn_LOT_SCAN_DELETE.Enabled = true;
            else
                btn_LOT_SCAN_DELETE.Enabled = false;

            

        }

        private void Grid1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Grid_RowMove((DataGridView)sender, e); //그리드 이동
        }

        private void Grid2_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Grid_RowMove((DataGridView)sender, e); //그리드 이동
        }

        private void Grid3_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Grid_RowMove((DataGridView)sender, e); //그리드 이동
        }
        
        private void Grid4_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Grid_RowMove((DataGridView)sender, e); //그리드 이동
        }

        private void Grid5_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
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

        private void btn_BAD_INSERT_ButtonClick(object sender, EventArgs e)
        {
            if (Grid1.Rows.Count == 0) return;

            if (Grid1.CurrentRow == null)
            {
                TGSControl.UsrFunction.MessageBoxErr("불량등록할 지시서를 선택하세요.", "불량등록");
                return;
            }


            POP_P9002PA3 myPopupForm = new POP_P9002PA3();


            try
            {
                
                DataTable dt = new DataTable("PassData");

                dt.Columns.Add("PLANT_CD");
                dt.Columns.Add("FACILITY_CD");
                dt.Columns.Add("FACILITY_NM");
                dt.Columns.Add("WC_MGR");
                dt.Columns.Add("WC_MGR_NM");

                dt.Columns.Add("WC_CD");
                //dt.Columns.Add("WC_NM");

                dt.Columns.Add("RESULT_NO");
                dt.Columns.Add("RESULT_SEQ");
                dt.Columns.Add("WK_ORD_NO");

                //dt.Columns.Add("WC_CD");
                //dt.Columns.Add("WC_NM");

                dt.Columns.Add("WORKER_ID");
                //dt.Columns.Add("LOT_NO");

                dt.Columns.Add("ITEM_CD");
                dt.Columns.Add("ITEM_NM");

                dt.Columns.Add("WK_ORD_QTY");
                dt.Columns.Add("PROD_QTY");
                dt.Columns.Add("GOOD_QTY");
                dt.Columns.Add("BAD_QTY");

                dt.Columns.Add("WORK_END_FLAG");


                dt.Columns.Add("RESULT_USER_FLAG");
                dt.Columns.Add("RESULT_USER_DT");

                dt.Rows.Add();


                dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
                dt.Rows[0]["FACILITY_CD"] = sFACILITY_CD;
                dt.Rows[0]["FACILITY_NM"] = cboFacility.ValueName;
                dt.Rows[0]["WC_MGR"] = sWC_MGR;
                dt.Rows[0]["WC_MGR_NM"] = sWC_MGR_NM;

                dt.Rows[0]["WC_CD"] = sWC_CD;
                //dt.Rows[0]["WC_NM"] = sWC_NM;

                dt.Rows[0]["RESULT_NO"] = Grid1.CurrentRow.Cells[grid1_COLUMN.RESULT_NO].Value.ToString();
                dt.Rows[0]["WK_ORD_NO"] = Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_NO].Value.ToString();

                dt.Rows[0]["WORKER_ID"] = Grid1.CurrentRow.Cells[grid1_COLUMN.WORKER_ID].Value.ToString();

                dt.Rows[0]["ITEM_CD"] = Grid1.CurrentRow.Cells[grid1_COLUMN.ITEM_CD].Value.ToString();
                dt.Rows[0]["ITEM_NM"] = Grid1.CurrentRow.Cells[grid1_COLUMN.ITEM_NM].Value.ToString();


                dt.Rows[0]["WK_ORD_QTY"] = Grid1.CurrentRow.Cells[grid1_COLUMN.WK_ORD_QTY].Value.ToString();
                dt.Rows[0]["PROD_QTY"] = Grid1.CurrentRow.Cells[grid1_COLUMN.PROD_QTY].Value.ToString();
                dt.Rows[0]["GOOD_QTY"] = Grid1.CurrentRow.Cells[grid1_COLUMN.GOOD_QTY].Value.ToString();
                dt.Rows[0]["BAD_QTY"] = Grid1.CurrentRow.Cells[grid1_COLUMN.BAD_QTY].Value.ToString();

                dt.Rows[0]["WORK_END_FLAG"] = "N";

                if (sRESULT_USER_FLAG == true)
                {
                    dt.Rows[0]["RESULT_USER_FLAG"] = "Y";
                }
                else
                {
                    dt.Rows[0]["RESULT_USER_FLAG"] = "N";
                }
                dt.Rows[0]["RESULT_USER_DT"] = sRESULT_USER_DT;

                myPopupForm.ResultData.Tables.Add(dt); //변수전달


                myPopupForm.MainForm = this.MainForm;
                myPopupForm.Start();

                DialogResult dResult = myPopupForm.ShowDialog();

                if (dResult == DialogResult.OK)
                {

                    DBQuery(); 
                }

                

            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "불량등록");
            }
            finally
            {
                myPopupForm.Dispose();
            }



        
        }

        private void opn_LOT_SCAN_Enter(object sender, EventArgs e)
        {
            opn_LOT_SCAN.BackColor = Color.Yellow;
        }

        private void opn_LOT_SCAN_Leave(object sender, EventArgs e)
        {
            opn_LOT_SCAN.BackColor = Color.White;
        }

        private void opn_LOT_SCAN_PUBLIC_Enter(object sender, EventArgs e)
        {
            opn_LOT_SCAN_PUBLIC.BackColor = Color.Yellow;
        }

        private void opn_LOT_SCAN_PUBLIC_Leave(object sender, EventArgs e)
        {
            opn_LOT_SCAN_PUBLIC.BackColor = Color.White;
        }

        private void APP_P1003M1_Resize(object sender, EventArgs e)
        {
            TGSClass.Util.Grid_Resize(Grid1);
            TGSClass.Util.Grid_Resize(Grid2);
            TGSClass.Util.Grid_Resize(Grid3);
            TGSClass.Util.Grid_Resize(Grid4);
            TGSClass.Util.Grid_Resize(Grid5);
        }

        private void btn_BAD_PART_INSERT_ButtonClick(object sender, EventArgs e)
        {
            DataGridView myGrid;
            string @LOT_NO;
            string @ITEM_CD;
            string @ITEM_NM;
            string @INV_QTY;

            if (tabControl1.SelectedTab.Name == TABCONTROL_TAB_NAME.RESERVATION)
            {
                return;
                //myGrid = Grid3;
                //@LOT_NO = Grid3.CurrentRow.Cells[grid3_COLUMN.LOT_NO].Value.ToString();
                //@ITEM_CD = Grid1.CurrentRow.Cells[grid1_COLUMN.ITEM_CD].Value.ToString();
                //@ITEM_NM = Grid1.CurrentRow.Cells[grid1_COLUMN.ITEM_NM].Value.ToString();
                //@INV_QTY = Grid3.CurrentRow.Cells[grid3_COLUMN.INV_QTY].Value.ToString();
            }
            else if (tabControl1.SelectedTab.Name == TABCONTROL_TAB_NAME.SCAN)
            {
                myGrid = Grid4;
                @LOT_NO = Grid4.CurrentRow.Cells[grid4_COLUMN.LOT_NO].Value.ToString();
                @ITEM_CD = Grid4.CurrentRow.Cells[grid4_COLUMN.ITEM_CD].Value.ToString();
                @ITEM_NM = Grid4.CurrentRow.Cells[grid4_COLUMN.ITEM_NM].Value.ToString();
                @INV_QTY = Grid4.CurrentRow.Cells[grid4_COLUMN.INV_QTY].Value.ToString();
            }
            else if (tabControl1.SelectedTab.Name == TABCONTROL_TAB_NAME.SCAN_PUBLIC)
            {
                myGrid = Grid5;
                @LOT_NO = Grid5.CurrentRow.Cells[grid5_COLUMN.LOT_NO].Value.ToString();
                @ITEM_CD = Grid5.CurrentRow.Cells[grid5_COLUMN.ITEM_CD].Value.ToString();
                @ITEM_NM = Grid5.CurrentRow.Cells[grid5_COLUMN.ITEM_NM].Value.ToString();
                @INV_QTY = Grid5.CurrentRow.Cells[grid5_COLUMN.INV_QTY].Value.ToString();
            }
            else
            {
                return;
                //myGrid = Grid3;
                //@LOT_NO = Grid3.CurrentRow.Cells[grid3_COLUMN.LOT_NO].Value.ToString();
                //@ITEM_CD = Grid1.CurrentRow.Cells[grid1_COLUMN.ITEM_CD].Value.ToString();
                //@ITEM_NM = Grid1.CurrentRow.Cells[grid1_COLUMN.ITEM_NM].Value.ToString();
                //@INV_QTY = Grid3.CurrentRow.Cells[grid3_COLUMN.INV_QTY].Value.ToString();
            }


            if (myGrid.Rows.Count == 0) return;

            if (myGrid.CurrentRow == null)
            {
                TGSControl.UsrFunction.MessageBoxErr("불량등록할 재고를 선택하세요.", "재고롯트 선택");
                return;
            }


            if (Convert.ToDecimal(@INV_QTY) <= 0)
            {
                TGSControl.UsrFunction.MessageBoxErr("양품재고가 없습니다.", "재고부족");
                return;
            }

            //임시주석
            //MES_APP_P02.POP_P0213P1 myPopupForm = new MES_APP_P02.POP_P0213P1();


            //try
            //{

            //    DataTable dt = new DataTable("PassData");

            //    dt.Columns.Add("PLANT_CD");
            //    dt.Columns.Add("WC_MGR");
            //    dt.Columns.Add("FACILITY_CD");
            //    dt.Columns.Add("LOT_NO");
            //    dt.Columns.Add("WORKER_ID");

            //    dt.Columns.Add("WC_CD");

            //    dt.Columns.Add("ITEM_CD");
            //    dt.Columns.Add("ITEM_NM");

            //    dt.Columns.Add("INV_QTY");
            //    dt.Columns.Add("GOOD_QTY");
            //    dt.Columns.Add("BAD_QTY");

            //    dt.Columns.Add("PRNT_RESULT_NO");
            //    dt.Columns.Add("PRNT_ITEM_CD");

            //    dt.Rows.Add();


            //    dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
            //    dt.Rows[0]["FACILITY_CD"] = sFACILITY_CD;
            //    dt.Rows[0]["WC_MGR"] = sWC_MGR;
            //    dt.Rows[0]["LOT_NO"] = @LOT_NO;
            //    dt.Rows[0]["WORKER_ID"] = cboWorker.Value;

            //    dt.Rows[0]["WC_CD"] = sWC_CD;



            //    dt.Rows[0]["ITEM_CD"] = @ITEM_CD;
            //    dt.Rows[0]["ITEM_NM"] = @ITEM_NM;


            //    dt.Rows[0]["INV_QTY"] = @INV_QTY;
            //    dt.Rows[0]["GOOD_QTY"] = @INV_QTY;
            //    dt.Rows[0]["BAD_QTY"] = "0";

            //    dt.Rows[0]["PRNT_RESULT_NO"] = "";
            //    dt.Rows[0]["PRNT_ITEM_CD"] = @ITEM_CD;


            //    myPopupForm.ResultData.Tables.Add(dt); //변수전달


            //    myPopupForm.MainForm = this.MainForm;
            //    myPopupForm.Start();

            //    DialogResult dResult = myPopupForm.ShowDialog();

            //    if (dResult == DialogResult.OK)
            //    {

            //        DBQuery();
            //    }

            //    opn_LOT_SCAN.Focus();


            //}
            //catch (Exception se)
            //{
            //    TGSControl.UsrFunction.MessageBoxErr(se.Message, "양품재고 불량처리");
            //}
            //finally
            //{
            //    myPopupForm.Dispose();
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

        private void Grid3_Enter(object sender, EventArgs e)
        {
            sGrid_Current_id = 3;
        }

        private void Grid4_Enter(object sender, EventArgs e)
        {
            sGrid_Current_id = 4;
        }

        private void Grid5_Enter(object sender, EventArgs e)
        {
            sGrid_Current_id = 5;
        }

        private void cboFacility_Click(object sender, EventArgs e)
        {
            int i = 0;
        }
    }
}
