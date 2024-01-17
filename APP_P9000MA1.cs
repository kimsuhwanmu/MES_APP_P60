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


using MES_SYS_B00;

namespace MES_APP_P90
{
    public partial class APP_P9000MA1 : UserControl
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
            public const string RESULT_NO = "RESULT_NO";
        }
        public struct SetValueName
        {
            public const string UNIT_CD = "UNIT_CD";       //UNIT CD
            public const string PLANT_CD = "PLANT_CD";
            public const string RESULT_NO = "RESULT_NO";
            public const string FACILITY_CD = "FACILITY_CD";
            public const string WC_CD = "WC_CD";
            public const string WC_NM = "WC_NM";
            public const string WC_MGR = "WC_MGR";
            public const string WC_MGR_NM = "WC_MGR_NM";
            public const string WORKER_CD = "WORKER_CD";

            public const string TIMER_TIC = "TIMER_TIC";    //부모창의 타이머에 의해 호출될 때 사용
            public const string SERVER_CONNECT_ERROR = "SERVER_CONNECT_ERROR";  //데몬서버 연결 오류일 경우


            public const string RESULT_USER_FLAG = "RESULT_USER_FLAG";    //사용자 일자 사용여부
            public const string RESULT_USER_DT = "RESULT_USER_DT";    //사용자 일자
        }

        private const int MAX_CHECK_ROW = 10;
        public struct TABCONTROL_NAME
        {
            public const string 지시현황 = "지시현황";
            public const string 부품투입 = "부품투입";
            public const string 성형작업 = "성형작업";
            public const string 실적조회 = "실적조회";
            public const string 가동상세 = "가동상세";
            public const string 작업표준 = "작업표준";
            public const string 재고현황 = "재고현황";
            public const string 이동출고 = "이동출고";

        }


        #endregion

        #region ■ 1.3. Class global variables (common) //글로벌 변수 선언

        Global global = new Global();
        Form sMainForm;


        string sUNIT_CD = "";       //UNIT CD
        string sPLANT_CD = "";      //공장
        string sWC_MGR = "40";        //대공정
        string sWC_MGR_NM = "";        //대공정
        string sWC_CD = "";         //작업장
        string sWC_NM = "";
        string sFACILITY_CD = "";   //설비번호
        string sWORKER_CD = "";
        string sORD_NO = "";        //작업지시번호

        bool s_ERROR_SERVER_CONNECT = false;    //서버연결 체크를 해서 연결이 안되면 true
        bool s_ERROR_RUN = false;   //성형 자동실적처리를 위한 데이타를 체크 해서 오류가 있으면 true, 또는 그외 오류를 표시해야 되면 true

        int s_TIMER_COUNT = 0;  //타이머를 위한 증가 카운터

        private int nWorkingButton = 0; //하단 버튼의 선택 
        private string szCurrentTabControl = TABCONTROL_NAME.지시현황;    //선택된 탭

        ArrayList alBarcode = new ArrayList();
        


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

        public APP_P9000MA1()
        {
            InitializeComponent();
        }

        #endregion

        #region ■ 2.2 Form_Load(common)    //Control이 로딩시

        private void Form_Load(object sender, EventArgs e)
        {
            global.ConfigFileReadAll(sWC_MGR);

           // initControl();
           //Start();
        }

        private void initControl()  //컨트롤 초기화
        {
            InitLocalVariables();   //로컬 변수 선언
            SetLocalDefaultValue(); //로컬 변수 값 지정
            GatheringComboData();   //로컬 콤보 로딩
            InitSpreadSheet();     //스프레드시트 초기화

            InitWorking(); //하단메뉴컨트롤 초기화
            SetBottomButton();//하단메뉴 셋팅

        }
        

        public void Start() //시작
        {
            
            
            
            initControl(); //컨트롤 초기화

            InitData();    //초기값 설정

            //DBQuery();     //조회


            for (int k = 0; k < tMatrixButtonV1.DataSource.Rows.Count; k++)
            {
                if (tMatrixButtonV1.DataSource.Rows[k][0].ToString() != "")
                {
                    tMatrixButtonV1.ClickButton(k);
                    break;
                }
            }
            

        }



        private void InitWorking()
        {

            //Hashtable CLEAR
            Global.alWorking.Clear();


            //버튼 1
            Global.htFacilitys = new Hashtable();
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.WORKING, "N");
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.FACILITYCD, "");
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.FACILITYNM, "");
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.OPERATOR, "");


            Global.alWorking.Add(Global.htFacilitys);

            //버튼 2
            Global.htFacilitys = new Hashtable();
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.WORKING, "N");
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.FACILITYCD, "");
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.FACILITYNM, "");
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.OPERATOR, "");


            Global.alWorking.Add(Global.htFacilitys);

            //버튼 3
            Global.htFacilitys = new Hashtable();
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.WORKING, "N");
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.FACILITYCD, "");
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.FACILITYNM, "");
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.OPERATOR, "");


            Global.alWorking.Add(Global.htFacilitys);


            //버튼 4
            Global.htFacilitys = new Hashtable();
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.WORKING, "N");
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.FACILITYCD, "");
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.FACILITYNM, "");
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.OPERATOR, "");


            Global.alWorking.Add(Global.htFacilitys);


            //버튼 5
            Global.htFacilitys = new Hashtable();
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.WORKING, "N");
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.FACILITYCD, "");
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.FACILITYNM, "");
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.OPERATOR, "");


            Global.alWorking.Add(Global.htFacilitys);

            //버튼 6
            Global.htFacilitys = new Hashtable();
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.WORKING, "N");
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.FACILITYCD, "");
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.FACILITYNM, "");
            Global.htFacilitys.Add(Global.htFacilitys_ITEMS.OPERATOR, "");

            Global.alWorking.Add(Global.htFacilitys);


            global.WorkingFileReadAll(sWC_MGR);

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

                //case GetValueName.ITEM_CD:

                //    return sITEM_CD;

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
                case SetValueName.RESULT_NO:

                    break;

                case SetValueName.FACILITY_CD:

                    sFACILITY_CD = pValue;


                    break;

                case SetValueName.TIMER_TIC:

                    if (s_TIMER_COUNT >= 5) //5초마다 한번씩 갱신함
                    {
                        DBQuery_PLC_INFO("", sUNIT_CD);
                        s_TIMER_COUNT = 0;
                    }
                    else
                    {
                        s_TIMER_COUNT = s_TIMER_COUNT + 1;
                    }
                    break;

                case SetValueName.SERVER_CONNECT_ERROR: //서버연결 오류 일 경우
                    if (pValue == "1")
                    {
                        s_ERROR_SERVER_CONNECT = true;
                    }
                    else
                    {
                        s_ERROR_SERVER_CONNECT = false;
                    }
                    break;
                case SetValueName.RESULT_USER_FLAG: //사이트 실적일자 
                    apP_P9001M11.SetValue(APP_P9001MA1.SetValueName.RESULT_USER_FLAG, pValue);
                    apP_P9002M11.SetValue(APP_P9002MA1.SetValueName.RESULT_USER_FLAG, pValue);

                    break;
                case SetValueName.RESULT_USER_DT: //사이트 실적일자 
                    apP_P9001M11.SetValue(APP_P9001MA1.SetValueName.RESULT_USER_DT, pValue);
                    apP_P9002M11.SetValue(APP_P9002MA1.SetValueName.RESULT_USER_DT, pValue);
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

            //임시주석 손유진 unit_cd = 01 PLANT_CD=4000
            if (sUNIT_CD == "") sUNIT_CD = Global.workinfo.szUNIT_CD;
            //if (sUNIT_CD == "") sUNIT_CD = "01";
            if (sPLANT_CD == "") sPLANT_CD = Global.workinfo.szFactoryCD;
            //if (sPLANT_CD == "") sPLANT_CD = "4000";
            if (sFACILITY_CD == "") sFACILITY_CD = Global.workinfo.szFacilityCD;
            if (sWC_CD == "") sWC_CD = Global.workinfo.szWorkSpaceCD;
            if (sWC_NM == "") sWC_NM = Global.workinfo.szWorkSpaceNM;
            if (sWC_MGR == "") sWC_MGR = Global.workinfo.szProcessCD;
            if (sWC_MGR_NM == "") sWC_MGR_NM = Global.workinfo.szProcessNM;
            if (sWORKER_CD == "") sWORKER_CD = Global.workinfo.szOperatorCD;



        }

        #endregion

        #region ■ 2.5 Gathering combo data(GatheringComboData) //콤보관련 데이타 설정

        protected void GatheringComboData()
        {
            //Load_Operator();  //작업자정보조회

            //Load_Facility();    //설비 정보를 조회한다.

            /* 판매계획유형*/
            //Fnc_crt_combo(this.cboSP_TYPE, "S0018", "S0018", 0, "판매계획", "판매계획명", "판매계획 선택");
            /* 거래구분*/
            //Fnc_crt_combo(this.cboLOC_EXP_FLAG, "S4225", "", 1);

        }

        //#region ▶▶▶ 공용코드 콤보 셋팅
        //private void Fnc_crt_combo(TGSControl.TCombo combo, string @MAJOR_CD, string @FLAG, int idx)
        //{
        //    Fnc_crt_combo(combo, @MAJOR_CD, @FLAG, idx, "코드", "코드명", "코드선택");
        //}

        //private void Fnc_crt_combo(TGSControl.TCombo combo, string @MAJOR_CD, string @FLAG, int idx, string p_ValueCaption, string p_DisplayCaption, string p_Caption)
        //{
        //    combo.Clear();


        //    //DataSet iDataSet = new DataSet();
        //    DataTable dtData1 = null;
        //    dtData1 = new DataTable();

        //    string strSql = "";

        //    switch (@FLAG)
        //    {
        //        //case "S0018":    // 판내계획유형..
        //        //    strSql = " SELECT DISTINCT UPPER(RTRIM(AA.code))  AS code, RTRIM(AA.name) AS name ";
        //        //    strSql += " FROM ( ";
        //        //    strSql += " SELECT	CASE WHEN A.SEQ_NO = 1 THEN 'E' ELSE 'M' END  AS code  ";
        //        //    strSql += "              , CASE WHEN A.SEQ_NO = 1 THEN '실행계획' ELSE '경영계획' END +'('+ B.MINOR_NM + ')'  AS name   ";
        //        //    strSql += " FROM	B_CONFIGURATION AS A (NOLOCK) ";
        //        //    strSql += " 		        JOIN B_MINOR AS B (NOLOCK) ON A.MAJOR_CD = B.MAJOR_CD AND A.MINOR_CD = B.MINOR_CD";
        //        //    strSql += " WHERE A.MAJOR_CD = 'S0018'   ) AA ";
        //        //    break;
        //        case "UD_MAJOR_CD":    // 사용자정의-공통코드..
        //            strSql = " SELECT DISTINCT RTRIM(AA.code) AS code, RTRIM(AA.name) AS name ";
        //            strSql += " FROM ( ";
        //            strSql += " SELECT  '1' AS LVL, '' AS code, '' AS name ";
        //            strSql += " UNION ALL ";
        //            strSql += " SELECT '2' AS LVL, RTRIM(AA.UD_MINOR_CD) AS code, RTRIM(AA.UD_MINOR_NM) AS name ";
        //            strSql += " FROM B_USER_DEFINED_MINOR AA (NOLOCK) ";
        //            strSql += " WHERE RTRIM(AA.UD_MAJOR_CD) = RTRIM('" + @MAJOR_CD + "')  ) AA ";
        //            strSql += " WHERE AA.LVL = '2' ";
        //            break;
        //        default:    // 공통코드..
        //            strSql = " SELECT DISTINCT RTRIM(AA.code) AS code, RTRIM(AA.name) AS name ";
        //            strSql += " FROM ( ";
        //            strSql += " SELECT  '1' AS LVL, '' AS code, '' AS name ";
        //            strSql += " UNION ALL ";
        //            strSql += " SELECT '2' AS LVL, RTRIM(AA.MINOR_CD) AS code, RTRIM(AA.MINOR_NM) AS name ";
        //            strSql += " FROM B_MINOR AA (NOLOCK) ";
        //            strSql += " WHERE RTRIM(AA.MAJOR_CD) = RTRIM('" + @MAJOR_CD + "')  ) AA ";
        //            break;
        //    }
        //    try
        //    {
        //        int nCnt = 0;
        //        strSql = WorkCode.WorkCd.SQLQUERY + strSql;
        //        string strState = nsFuncUtil.FuncUtil.GetDataSql(this.ParentForm, strSql, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);

        //    }
        //    catch (Exception ex)
        //    {
        //        TGSControl.UsrFunction.MessageBoxErr(ex.Message, "기준정보조회");

        //        return;
        //    }
        //    //if (dtData1 != null && dtData1.Rows.Count > 0)
        //    if (dtData1 != null)
        //    {
        //        combo.DataSource = dtData1;
        //        combo.ValueMember = "code";
        //        combo.DisplayMember = "name";
        //        combo.DisplayCaption = p_DisplayCaption;
        //        combo.ValueCaption = p_ValueCaption;
        //        combo.Caption = p_Caption;

        //        //combo.DataBind();

        //        combo.SelectedIndex = idx;
        //    }
        //}
        //#endregion ▶▶▶ 공용코드 콤보 셋팅
        
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
            //InitSpreadSheet(1); //GRID1
            //InitSpreadSheet(2); //GRID2
            //InitSpreadSheet(3); //GRID3
            //InitSpreadSheet(4); //GRID4
        }

        private void InitSpreadSheet(int p_GridIndex)   //선택된 스프레드시트를 초기화 한다.
        {

            #region ▶▶▶ 3.1.1 GRID1 설정

            if (p_GridIndex == 1)
            {
                #region ■■ 3.1.1.1 Pre-setting grid information



                ///*** grid1
                // *  실적조회
                // * **/
                //Grid1.Columns.Clear();

                //DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                //columnHeaderStyle.BackColor = Color.Beige;
                //columnHeaderStyle.Font = new Font("맑은 고딕", 11);
                //Grid1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                //Grid1.RowHeadersVisible = false;

                //Grid1.Columns.Add(SetColumnImage(gridWRDW11_COLUMN.CHECKFLAG, "√", 40));    //이미지형태의 그리드



                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.ITEM_CD, "품번", 130));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.ITEM_NM, "품명", 150));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.RESV_QTY, "소요량", 80));
                

                #endregion


                #region ■■ 3.1.1.2 Formatting grid information

                //uniGrid2.flagInformation("cud_flag", "rownum");
                //uniGrid2.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.No);

                //Grid1.Columns[grid1_COLUMN.RESV_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.RESV_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태


                #endregion


                #region ■■ 3.1.1.3 Setting etc grid
                // Hidden Column Setting
                //Grid1.Columns[grid1_COLUMN.REAL_USED_QTY].Visible = false;


                #endregion

            }
            #endregion


        }


        #endregion

        #region ■ 3.2 InitData

        private void InitData()
        {
            // TO-DO: 컨트롤을 초기화(또는 초기값)할때 할일 
            // SetDefaultVal과의 차이점은 전자는 Form_Load 시점에 콘트롤에 초기값을 세팅하는것이고
            // 후자는 특정 시점(조회후 또는 행추가후 등 특정이벤트)에서 초기값을 셋팅한다.
            

            

            apP_P9001M11.MainForm = this.MainForm;

            apP_P9001M11.SetValue(MES_APP_P90.APP_P9001MA1.SetValueName.UNIT_CD, sUNIT_CD);
            apP_P9001M11.SetValue(MES_APP_P90.APP_P9001MA1.SetValueName.PLANT_CD, sPLANT_CD);
            apP_P9001M11.SetValue(MES_APP_P90.APP_P9001MA1.SetValueName.WC_MGR, sWC_MGR);
            apP_P9001M11.SetValue(MES_APP_P90.APP_P9001MA1.SetValueName.WC_CD, sWC_CD);
            apP_P9001M11.SetValue(MES_APP_P90.APP_P9001MA1.SetValueName.WC_NM, sWC_NM);
            apP_P9001M11.SetValue(MES_APP_P90.APP_P9001MA1.SetValueName.WORKER_CD, sWORKER_CD);
            apP_P9001M11.SetValue(MES_APP_P90.APP_P9001MA1.SetValueName.FACILITY_CD, sFACILITY_CD);
            apP_P9001M11.Start();    //작업지시현황
            
            if (sPLANT_CD != "") apP_P9001M11.OnFncQuery();   //조회 실행
           

            //자재투입
            
            apP_P9002M11.MainForm = this.MainForm;
            apP_P9002M11.SetValue(MES_APP_P90.APP_P9002MA1.SetValueName.UNIT_CD, sUNIT_CD);
            apP_P9002M11.SetValue(MES_APP_P90.APP_P9002MA1.SetValueName.PLANT_CD, sPLANT_CD);
            apP_P9002M11.SetValue(MES_APP_P90.APP_P9002MA1.SetValueName.WC_MGR, sWC_MGR);
            apP_P9002M11.SetValue(MES_APP_P90.APP_P9002MA1.SetValueName.WC_CD, sWC_CD);
            apP_P9002M11.SetValue(MES_APP_P90.APP_P9002MA1.SetValueName.WC_NM, sWC_NM);
            apP_P9002M11.SetValue(MES_APP_P90.APP_P9002MA1.SetValueName.WORKER_CD, sWORKER_CD);
            apP_P9002M11.SetValue(MES_APP_P90.APP_P9002MA1.SetValueName.FACILITY_CD, sFACILITY_CD);
            apP_P9002M11.Start();   //자재투입

            //apP_P9003M11.SetValue(MES_APP_P90.APP_P9003MA1.SetValueName.UNIT_CD, sUNIT_CD);
            apP_P9003M11.SetValue(MES_APP_P90.APP_P9003MA1.SetValueName.PLANT_CD, sPLANT_CD);
            apP_P9003M11.SetValue(MES_APP_P90.APP_P9003MA1.SetValueName.WC_MGR, sWC_MGR);
            apP_P9003M11.SetValue(MES_APP_P90.APP_P9003MA1.SetValueName.WC_CD, sWC_CD);
            apP_P9003M11.SetValue(MES_APP_P90.APP_P9003MA1.SetValueName.WC_NM, sWC_NM);
            //apP_P9003M11.SetValue(MES_APP_P90.APP_P9003MA1.SetValueName.WORKER_CD, sWORKER_CD);
            apP_P9003M11.SetValue(MES_APP_P90.APP_P9003MA1.SetValueName.FACILITY_CD, sFACILITY_CD);
            apP_P9003M11.MainForm = this.MainForm;
            apP_P9003M11.Start();

            apP_P9004MA11.SetValue(MES_APP_P90.APP_P9004MA1.SetValueName.UNIT_CD, sUNIT_CD);
            apP_P9004MA11.SetValue(MES_APP_P90.APP_P9004MA1.SetValueName.PLANT_CD, sPLANT_CD);
            apP_P9004MA11.SetValue(MES_APP_P90.APP_P9004MA1.SetValueName.WC_MGR, sWC_MGR);
            apP_P9004MA11.SetValue(MES_APP_P90.APP_P9004MA1.SetValueName.WC_CD, sWC_CD);
            apP_P9004MA11.SetValue(MES_APP_P90.APP_P9004MA1.SetValueName.WC_NM, sWC_NM);
            apP_P9004MA11.SetValue(MES_APP_P90.APP_P9004MA1.SetValueName.WORKER_CD, sWORKER_CD);
            apP_P9004MA11.SetValue(MES_APP_P90.APP_P9004MA1.SetValueName.FACILITY_CD, sFACILITY_CD);
            

            apP_P9004MA11.MainForm = this.MainForm;
            apP_P9004MA11.Start();


            if (tabMenu.SelectedTab != null && tabMenu.SelectedTab.Name == TABCONTROL_NAME.부품투입)
            {
                if (sPLANT_CD != "") apP_P9002M11.OnFncQuery();   //조회 실행
            }

           

            ////설비 비가동 상태화면
            //ctL_P0401C11.MainForm = this.MainForm;
            //ctL_P0401C11.Object_Enable = 성형작업;
            //ctL_P0401C11.DBQuery(sPLANT_CD, sFACILITY_CD, sWC_MGR, sWC_CD, sWORKER_CD);

            //로딩완료시 컨트롤 사용가능하게 활성화
            tMatrixButtonV1.Enabled = true;
            tabMenu.Enabled = true;
            btnBottomSet.Enabled = true;
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

            //this.SuspendLayout();


            DBQuery_PLC_INFO(sFACILITY_CD, sUNIT_CD);//설비의 상태 정보를 조회한다.

            
            //this.ResumeLayout();
            //this.PerformLayout();

            return true;
        }
        
        private void DBQuery_PLC_INFO(string p_FACILITY_CD, string p_UNIT_ID) //설비의 상태 정보를 조회한다.
        {
            if (s_ERROR_SERVER_CONNECT == true)//서버연결 오류 일 경우
            {
                for (int k = 0; k < tMatrixButtonV1.DataSource.Rows.Count; k++)
                {
                    System.Drawing.Image myImage = MES_APP_P90.Properties.Resources.PLC_ERROR;
                    tMatrixButtonV1.iConImage1_Set(k, myImage); //연결오류 이미지 표시
                }
                return;
            }

            int nCnt = 0;
            try
            {
                //LoadingForm(true);

                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MES_P9000M1_GET_PLC @PLANT_CD='" + sPLANT_CD + "', ";
                strData += "@FACILITY_CD='" + p_FACILITY_CD + "',";
                strData += "@UNIT_ID='" + p_UNIT_ID + "'";

                DataTable dtData1 = null;
                dtData1 = new DataTable();


                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);

                //string strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);



                if (@strState.Equals("OK") == false)
                {
                    if (strState.Substring(2, 7) == "서버 연결오류")
                    {
                        TGSControl.UsrFunction.MessageBoxInfo(strState.Substring(2), "상태 조회");
                    }
                    else if (strState.Substring(2, 20) == "Error Code: 80004005")
                    {
                        TGSControl.UsrFunction.MessageBoxInfo(strState.Substring(2), "상태 조회");
                    }
                    else
                    {
                        TGSControl.UsrFunction.MessageBoxInfo(strState.Substring(2), "상태 조회");
                    }
                    return;
                }



                if (dtData1 != null)
                {
                    for (int i = 0; i < dtData1.Rows.Count; i++)
                    {
                        for (int k = 0; k < tMatrixButtonV1.DataSource.Rows.Count; k++)
                        {
                            if (dtData1.Rows[i]["FACILITY_CD"].ToString().ToUpper() == tMatrixButtonV1.DataSource.Rows[k][tMatrixButtonV1.ValueMember].ToString().ToUpper())
                            {
                                
                                System.Drawing.Image myImage = null;

                                if (s_ERROR_SERVER_CONNECT == false)      //SERVER 연결상태일경우
                                {
                                    switch (dtData1.Rows[i]["JOBSTATE"].ToString())    //성형기 상태 체크
                                    {
                                        case "":
                                        case "0":
                                            myImage = MES_APP_P90.Properties.Resources.STATES_0;
                                            break;
                                        case "1":
                                            myImage = MES_APP_P90.Properties.Resources.STATES_1;
                                            break;
                                        case "2":
                                            myImage = MES_APP_P90.Properties.Resources.STATES_2;
                                            break;
                                        case "3":
                                            myImage = MES_APP_P90.Properties.Resources.STATES_3;
                                            break;
                                        case "4":
                                            myImage = MES_APP_P90.Properties.Resources.STATES_4;
                                            break;
                                    }

                                    if (dtData1.Rows[i]["PLC_CONNECT_FLAG"].ToString() == "0")  //PLC 연결상태 에러 일경우
                                    {
                                        myImage = MES_APP_P90.Properties.Resources.PLC_ERROR;
                                    }
                                }
                                else
                                {
                                    //SERVER 연결상태 에러 일경우
                                    myImage = MES_APP_P90.Properties.Resources.PLC_ERROR;
                                }
                                                                tMatrixButtonV1.iConImage1_Set(k,myImage) ; //상태정보



                                System.Drawing.Image myImage2 = null;

                                if (s_ERROR_RUN == false)
                                {
                                    switch (dtData1.Rows[i]["AUTO_FLAG"].ToString())    //자동 수동 상태 체크
                                    {
                                        case "Y":
                                            myImage2 = MES_APP_P90.Properties.Resources.RUN_AUTO;
                                            break;

                                        default:
                                            myImage2 = MES_APP_P90.Properties.Resources.RUN_MENUAL;
                                            break;
                                    }
                                }
                                else
                                {
                                    //데이타 에러일 경우
                                    myImage2 = MES_APP_P90.Properties.Resources.RUN_ERROR;
                                }


                                tMatrixButtonV1.iConImage2_Set(k, myImage2); //성형가동 상태정보

                                break;
                            }
                        }
                    }


                }



            }
            catch (Exception e)
            {
                try
                {
                    TGSControl.UsrFunction.MessageBoxInfo(e.Message, "작업장 조회");
                }
                catch (Exception e1)
                {

                }
            }
            finally
            {
                //LoadingForm(false);

            }
        }

        private void DBQuery_WC_NM(string p_FACILITY_CD, ref string p_WC_CD, ref string p_WC_NM) //설비의 작업장 정보를 조회한다.
        {
            int nCnt = 0;
            try
            {
                //LoadingForm(true);

                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MESSVR_GET_FACILITY_WC @PLANT_CD='" + sPLANT_CD + "', ";
                strData += "@FACILITY_CD='" + p_FACILITY_CD + "'";

                DataTable dtData1 = null;
                dtData1 = new DataTable();




                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);
                
                //string strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (@strState.Equals("OK") == false)
                {
                    TGSControl.UsrFunction.MessageBoxInfo(strState.Substring(2), "작업장 조회");
                    return;
                }

                if (dtData1 != null)
                {
                    
                    for (int i = 0; i < dtData1.Rows.Count; i++)
                    {
                        p_WC_CD = dtData1.Rows[i]["WC_CD"].ToString(); //품번
                        p_WC_NM = dtData1.Rows[i]["WC_NM"].ToString(); //품번
                                                
                        break;
                    }


                }

                if (Global.workinfo.szWorkSpaceCD == "") TGSControl.UsrFunction.MessageBoxInfo(Global.workinfo.szFacilityNM + " 설비의 작업장 정보가 없습니다. (수정:ERP 자원등록)", "ERP 작업장 정보 누락");

            }
            catch (Exception e)
            {
                try
                {
                    TGSControl.UsrFunction.MessageBoxInfo(e.Message, "작업장 조회");
                }
                catch (Exception e1)
                {

                }
            }
            finally
            {
                //LoadingForm(false);

            }
        }

        private void DBQuery_UNIT_FACILITY() //UNIT에 설정되어 있는 설비리스트를 가져온다.
        {
            int nCnt = 0;
            try
            {
                //LoadingForm(true);

                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MESSVR_GET_UNIT_FACILITY @PLANT_CD='" + sPLANT_CD + "', ";
                strData += "@UNIT_CD='" + sUNIT_CD + "'";

                DataTable dtData1 = null;
                dtData1 = new DataTable();


                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);


                //string strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (@strState.Equals("OK") == false)
                {
                    TGSControl.UsrFunction.MessageBoxInfo(strState.Substring(2), "UNIT 설비 조회");
                    return;
                }

                if (dtData1 != null)
                {
                    tMatrixButtonV1.Clear();

                    for (int i = 0; i < dtData1.Rows.Count; i++)
                    {
                        if (dtData1.Rows[i]["FACILITY_CD"].ToString() != "")
                        {
                            
                            tMatrixButtonV1.AddItem(dtData1.Rows[i]["FACILITY_CD"].ToString(),  //설비번호
                                                    dtData1.Rows[i]["FACILITY_NM"].ToString(),  //설비명
                                                    dtData1.Rows[i]["WC_CD"].ToString(),        //작업장
                                                    dtData1.Rows[i]["WC_NM"].ToString(),        //작업장명
                                                    ""                                          //작업자
                                                    );
                            
                        }
                        else
                        {
                            tMatrixButtonV1.AddItem(dtData1.Rows[i]["WC_CD"].ToString(),        //설비번호 = 작업장
                                                    dtData1.Rows[i]["WC_NM"].ToString(),        //설비명   = 작업장명
                                                    dtData1.Rows[i]["WC_CD"].ToString(),        //작업장
                                                    dtData1.Rows[i]["WC_NM"].ToString(),        //작업장명
                                                    ""                                          //작업자
                                                    );
                        }

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
               
                try
                {
                    TGSControl.UsrFunction.MessageBoxInfo(e.Message, "UNIT 설비 조회");
                }
                catch (Exception e1)
                {

                }
            }
            finally
            {
                //LoadingForm(false);

            }
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

        private void btnBottomSet_ButtonClick(object sender, EventArgs e)
        {
            //Global.ExecMetMenu();

            string szProcessCD = Global.workinfo.szProcessCD;
            string szWorkSpaceCD = Global.workinfo.szWorkSpaceCD;

            POP_FAC_SET frmFacility = new MES_SYS_B00.POP_FAC_SET();

            frmFacility.MainForm = MainForm;
            frmFacility.PLANT_CD = sPLANT_CD;
            frmFacility.WC_MGR = sWC_MGR;
            frmFacility.WC_CD = ""; //-sWC_CD;
            frmFacility.JOB_CD = "";
            frmFacility.ShowDialog();

            if (frmFacility.DialogResult == DialogResult.OK)
            {

                SetBottomButton();//하단메뉴 셋팅



                global.WorkingFileWriteAll();
            }
        }

        //하단메뉴 셋팅

        private void SetBottomButton()
        {
            if (sUNIT_CD != "")
            {

                DBQuery_UNIT_FACILITY(); //UNIT에 설정되어 있는 설비리스트를 DB에서 가져온다.

                Panel_Bottom.ColumnStyles[0].SizeType = SizeType.Percent;
                Panel_Bottom.ColumnStyles[1].SizeType = SizeType.Absolute;
                Panel_Bottom.ColumnStyles[0].Width = 100;
                Panel_Bottom.ColumnStyles[1].Width = 0;

            }
            else
            {

                if (Global.alWorking.Count > 0)
                {
                    tMatrixButtonV1.Clear();

                    if (((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT1])[Global.htFacilitys_ITEMS.FACILITYCD].ToString() != "")
                    {
                        tMatrixButtonV1.AddItem(((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT1])[Global.htFacilitys_ITEMS.FACILITYCD].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT1])[Global.htFacilitys_ITEMS.FACILITYNM].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT1])[Global.htFacilitys_ITEMS.WC_CD].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT1])[Global.htFacilitys_ITEMS.WC_NM].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT1])[Global.htFacilitys_ITEMS.OPERATOR].ToString());
                    }

                    if (((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT2])[Global.htFacilitys_ITEMS.FACILITYCD].ToString() != "")
                    {
                        tMatrixButtonV1.AddItem(((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT2])[Global.htFacilitys_ITEMS.FACILITYCD].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT2])[Global.htFacilitys_ITEMS.FACILITYNM].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT2])[Global.htFacilitys_ITEMS.WC_CD].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT2])[Global.htFacilitys_ITEMS.WC_NM].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT2])[Global.htFacilitys_ITEMS.OPERATOR].ToString());
                    }

                    if (((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT3])[Global.htFacilitys_ITEMS.FACILITYCD].ToString() != "")
                    {
                        tMatrixButtonV1.AddItem(((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT3])[Global.htFacilitys_ITEMS.FACILITYCD].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT3])[Global.htFacilitys_ITEMS.FACILITYNM].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT3])[Global.htFacilitys_ITEMS.WC_CD].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT3])[Global.htFacilitys_ITEMS.WC_NM].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT3])[Global.htFacilitys_ITEMS.OPERATOR].ToString());
                    }

                    if (((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT4])[Global.htFacilitys_ITEMS.FACILITYCD].ToString() != "")
                    {
                        tMatrixButtonV1.AddItem(((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT4])[Global.htFacilitys_ITEMS.FACILITYCD].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT4])[Global.htFacilitys_ITEMS.FACILITYNM].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT4])[Global.htFacilitys_ITEMS.WC_CD].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT4])[Global.htFacilitys_ITEMS.WC_NM].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT4])[Global.htFacilitys_ITEMS.OPERATOR].ToString());
                    }

                    if (((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT5])[Global.htFacilitys_ITEMS.FACILITYCD].ToString() != "")
                    {
                        tMatrixButtonV1.AddItem(((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT5])[Global.htFacilitys_ITEMS.FACILITYCD].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT5])[Global.htFacilitys_ITEMS.FACILITYNM].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT5])[Global.htFacilitys_ITEMS.WC_CD].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT5])[Global.htFacilitys_ITEMS.WC_NM].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT5])[Global.htFacilitys_ITEMS.OPERATOR].ToString());
                    }

                    if (((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT6])[Global.htFacilitys_ITEMS.FACILITYCD].ToString() != "")
                    {
                        tMatrixButtonV1.AddItem(((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT6])[Global.htFacilitys_ITEMS.FACILITYCD].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT6])[Global.htFacilitys_ITEMS.FACILITYNM].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT6])[Global.htFacilitys_ITEMS.WC_CD].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT6])[Global.htFacilitys_ITEMS.WC_NM].ToString(),
                                                ((Hashtable)Global.alWorking[(int)Global.alWorkings_ITEMS.BT6])[Global.htFacilitys_ITEMS.OPERATOR].ToString());

                    }

                    tMatrixButtonV1.DataBind();

                }

                Panel_Bottom.ColumnStyles[0].SizeType = SizeType.Percent;
                Panel_Bottom.ColumnStyles[1].SizeType = SizeType.Absolute;
                Panel_Bottom.ColumnStyles[0].Width = 100;
                Panel_Bottom.ColumnStyles[1].Width = 110;

            }

            for (int k = 0; k < tMatrixButtonV1.DataSource.Rows.Count; k++)
            {
                tMatrixButtonV1.iConViewFlag(k, true);//버튼의 상태정보 이미지를 활성화 한다. *******************************
            }
            
        }




        
        private void tMatrixButtonV1_ButtonClick(object sender, EventArgs e)
        {


            if (tMatrixButtonV1.Value == "") return;

            
            this.apP_P9001M11.SuspendLayout();
            this.apP_P9002M11.SuspendLayout();
            this.apP_P9003M11.SuspendLayout();
            //this.cP50_WorkResultAssy1.SuspendLayout();
            //this.cP50_WorkResultPacking1.SuspendLayout();
            this.SuspendLayout();
            

            //SelectFacility_rtn(tMatrixButtonV1.SelectedIndex + 1);
            SelectFacility_rtn();

            this.apP_P9001M11.ResumeLayout(false);
            this.apP_P9002M11.ResumeLayout(false);
            this.apP_P9003M11.ResumeLayout(false);
            //this.cP50_WorkResultAssy1.ResumeLayout();
            //this.cP50_WorkResultPacking1.ResumeLayout();

            this.ResumeLayout(false);
            //this.PerformLayout();

        }

        private void SelectFacility_rtn()
        {
            
            //Hashtable htTmp;


            //하단버튼이 클릭되면 선택된 탭과 상관없이 모든 화면에 해당 설비로 변경 
            Global.workinfo.szFacilityCD = tMatrixButtonV1.Value;
            Global.workinfo.szFacilityNM = tMatrixButtonV1.ValueName;
            Global.workinfo.szWorkSpaceCD = tMatrixButtonV1.Reference1;
            Global.workinfo.szWorkSpaceNM = tMatrixButtonV1.Reference2;
            if (Global.workinfo.szOperatorCD != tMatrixButtonV1.Reference3 && tMatrixButtonV1.Reference3 != "")
            {
                Global.workinfo.szOperatorCD = tMatrixButtonV1.Reference3;
            }

            sFACILITY_CD = Global.workinfo.szFacilityCD;
            sWC_CD = Global.workinfo.szWorkSpaceCD;
            sWC_NM = Global.workinfo.szWorkSpaceNM;
            sWORKER_CD = Global.workinfo.szOperatorCD;


            if (Global.workinfo.szWorkSpaceNM == "")
            {
                DBQuery_WC_NM(Global.workinfo.szFacilityCD, ref Global.workinfo.szWorkSpaceCD, ref Global.workinfo.szWorkSpaceNM);
            }

            
                    

            global.ConfigFileWriteAll();

            apP_P9001M11.SetValue(APP_P9001MA1.SetValueName.WC_CD, Global.workinfo.szWorkSpaceCD);
            apP_P9001M11.SetValue(APP_P9001MA1.SetValueName.WC_NM, Global.workinfo.szWorkSpaceNM);
            apP_P9001M11.SetValue(APP_P9001MA1.SetValueName.FACILITY_CD, Global.workinfo.szFacilityCD);
            apP_P9001M11.InitData();
            if (tabMenu.SelectedTab.Name == TABCONTROL_NAME.지시현황) apP_P9001M11.OnFncQuery();

            apP_P9002M11.SetValue(APP_P9002MA1.SetValueName.WC_CD, Global.workinfo.szWorkSpaceCD);
            apP_P9002M11.SetValue(APP_P9002MA1.SetValueName.WC_NM, Global.workinfo.szWorkSpaceNM);
            apP_P9002M11.SetValue(APP_P9002MA1.SetValueName.FACILITY_CD, Global.workinfo.szFacilityCD);
            //apP_P9002M11.SetValue(APP_P9002MA1.SetValueName.WORKER_CD, Global.workinfo.szOperatorCD);
            apP_P9002M11.InitData();
            if (tabMenu.SelectedTab.Name == TABCONTROL_NAME.부품투입) apP_P9002M11.OnFncQuery();


            //apP_P9003M11.SetValue(MES_APP_P31.APP_P3101Q1.SetValueName.WC_CD, sWC_CD);
            //apP_P9003M11.SetValue(MES_APP_P31.APP_P3101Q1.SetValueName.WC_NM, sWC_NM);
            //sWORKER_CD = aPP_P9003M11.GetValue(MES_APP_P30.APP_P3001M1.GetValueName.WORKER_CD);
            apP_P9003M11.SetValue(MES_APP_P90.APP_P9003MA1.SetValueName.FACILITY_CD, sFACILITY_CD);
            //this.apP_P9003M11.SetValue(MES_APP_P90.APP_P9003MA1.SetValueName.WORKER_ID, aPP_P3001M11.GetValue(MES_APP_P30.APP_P3001M1.GetValueName.WORKER_CD));
            
            apP_P9003M11.InitData();

            apP_P9004MA11.SetValue(APP_P9004MA1.SetValueName.WC_CD, Global.workinfo.szWorkSpaceCD);
            apP_P9004MA11.SetValue(APP_P9004MA1.SetValueName.WC_NM, Global.workinfo.szWorkSpaceNM);
            apP_P9004MA11.SetValue(APP_P9004MA1.SetValueName.FACILITY_CD, Global.workinfo.szFacilityCD);
            //apP_P9004MA11.SetValue(APP_P9004MA1.SetValueName.WORKER_CD, Global.workinfo.szOperatorCD);
            apP_P9004MA11.InitData();



            if (tabMenu.SelectedTab.Name == TABCONTROL_NAME.실적조회) apP_P9003M11.OnFncQuery();
           


            switch (tabMenu.SelectedTab.Name)
            {
                case TABCONTROL_NAME.지시현황:   //현작업 전반(모든 TABPAGE에 영향을 줌
                case TABCONTROL_NAME.부품투입:
                case TABCONTROL_NAME.성형작업:
                case TABCONTROL_NAME.실적조회:
                case TABCONTROL_NAME.가동상세:

                    if (tabMenu.SelectedTab.Name == TABCONTROL_NAME.성형작업)
                    {
                        ctL_P9001C11.DBQuery(sPLANT_CD, sFACILITY_CD, sWC_MGR, sWC_CD, sWORKER_CD); //설비 비가동 체크
                    }
                    else
                    {
                        ctL_P9001C11.OP_NM = "";    //비가동 창 숨김
                    }


                    break;
                                      
                default:
                    ctL_P9001C11.OP_NM = "";    //비가동 창 숨김
                    break;

            }



        }

        private void apP_P9001M11_CommandRuned(object sender, CommandRunEventArgs e)
        {
            if (e.SendData != null)
            {
                for (int i = 0; i < e.SendData.Tables["COMMAND"].Rows.Count; i++)
                {
                    switch (e.SendData.Tables["COMMAND"].Rows[i][0].ToString())
                    {
                        case "APP_RUN":

                            switch (e.SendData.Tables["COMMAND"].Rows[i][1].ToString())
                            {                               
                                case "MES_APP_P90.APP_P9002MA1":
                                    this.apP_P9002M11.CommandRun(e.SendData);
                                    tabMenu.SelectedTab = tabMenu.TabPages[TABCONTROL_NAME.부품투입];

                                    break;
                            }
                            break;

                    }


                }

            }
        }

        private void apP_P9002M11_CommandRuned(object sender, CommandRunEventArgs e)
        {
            if (e.SendData != null)
            {
                for (int i = 0; i < e.SendData.Tables["COMMAND"].Rows.Count; i++)
                {
                    switch (e.SendData.Tables["COMMAND"].Rows[i][0].ToString())
                    {
                        case "APP_RUN":

                            switch (e.SendData.Tables["COMMAND"].Rows[i][1].ToString())
                            {
                                case "MES_APP_P90.APP_P3001M1":
                                    

                                    break;

                            }
                            break;

                    }


                }

            }
        }
        

        private void tabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {


           

            switch (tabMenu.SelectedTab.Name)
            {
                case TABCONTROL_NAME.지시현황:
                    ctL_P9001C11.OP_NM = "";    //비가동 창 숨김
                    this.apP_P9001M11.OnFncQuery();
                    break;

                case TABCONTROL_NAME.부품투입:
                    ctL_P9001C11.OP_NM = "";    //비가동 창 숨김
                    this.apP_P9002M11.OnFncQuery();
                    break;

                case TABCONTROL_NAME.실적조회:
                    ctL_P9001C11.OP_NM = "";    //비가동 창 숨김

                    //if (szCurrentTabControl == TABCONTROL_NAME.성형작업)
                    //{
                    //     this.apP_P9003M11.SetValue(MES_APP_P31.APP_P3101Q1.SetValueName.WORKER_ID, aPP_P3001M11.GetValue(MES_APP_P30.APP_P3001M1.GetValueName.WORKER_CD));
                    //}
                   // this.apP_P9003M11.SetValue(MES_APP_P31.APP_P3101Q1.SetValueName.WORKER_ID, aPP_P3001M11.GetValue(MES_APP_P30.APP_P3001M1.GetValueName.WORKER_CD));
                    
                    this.apP_P9003M11.InitData();
                    this.apP_P9003M11.OnFncQuery();
                    break;

         
                
                //case TABCONTROL_NAME.작업표준:
                //    string v_ITEM_CD = "";


                //    if (szCurrentTabControl == TABCONTROL_NAME.지시현황)
                //    {
                //        v_ITEM_CD = apP_P1004M11.GetValue("ITEM_CD");
                //    }
                //    if (szCurrentTabControl == TABCONTROL_NAME.부품투입)
                //    {
                //        v_ITEM_CD = apP_P9002M11.GetValue("ITEM_CD");
                //    }
                //    else if (szCurrentTabControl == TABCONTROL_NAME.성형작업)
                //    {
                //        v_ITEM_CD = this.aPP_P3001M11.GetValue("ITEM_CD");
                //    }
                //    else if (szCurrentTabControl == TABCONTROL_NAME.실적조회)
                //    {
                //        v_ITEM_CD = this.apP_P9003M11 .GetValue("ITEM_CD");
                //    }
                    
                    


                //    if (v_ITEM_CD != "")
                //    {

                //        apP_P1005M11.SetValue(MES_APP_P00.APP_P1005M1.SetValueName.PLANT_CD, sPLANT_CD);
                //        apP_P1005M11.SetValue(MES_APP_P00.APP_P1005M1.SetValueName.WC_MGR, sWC_MGR);
                //        apP_P1005M11.SetValue(MES_APP_P00.APP_P1005M1.SetValueName.WC_CD, sWC_CD);
                //        apP_P1005M11.SetValue(MES_APP_P00.APP_P1005M1.SetValueName.ITEM_CD, v_ITEM_CD);
                //        apP_P1005M11.InitData();
                //        apP_P1005M11.OnFncQuery();
                //    }


                //    break;
                
                
                default:
                    ctL_P9001C11.OP_NM = "";    //비가동 창 숨김
                    break;
            }

            szCurrentTabControl = tabMenu.SelectedTab.Name;

        }

        private void aPP_P3001M11_CommandRuned(object sender, CommandRunEventArgs e)
        {
            if (e.SendData != null)
            {
                for (int i = 0; i < e.SendData.Tables["COMMAND"].Rows.Count; i++)
                {
                    switch (e.SendData.Tables["COMMAND"].Rows[i][0].ToString())
                    {
                        //case "APP_RUN":

                        //    switch (e.SendData.Tables["COMMAND"].Rows[i][1].ToString())
                        //    {
                        //        case "MES_APP_P00.APP_P9002MA1":
                        //            this.apP_P9002M11.CommandRun(e.SendData);
                        //            tabMenu.SelectedTab = tabMenu.TabPages[TABCONTROL_NAME.실적등록];

                        //            break;

                        //    }
                        //    break;
                        case "USER_EVENT":
                            string vFACILITY_CD = "";
                            Image myImage = null;

                            switch (e.SendData.Tables["COMMAND"].Rows[i][1].ToString())
                            {
                                case "AUTO_FLAG":
                                    vFACILITY_CD = e.SendData.Tables["COMMAND"].Rows[i][2].ToString();
                                    
                                    for (int k = 0; k < tMatrixButtonV1.DataSource.Rows.Count; k++)
                                    {
                                        if (tMatrixButtonV1.DataSource.Rows[k][tMatrixButtonV1.ValueMember].ToString().ToUpper() == vFACILITY_CD)
                                        {
                                            if (e.SendData.Tables["COMMAND"].Rows[i][3].ToString() == "Y")
                                            {
                                                myImage = MES_APP_P90.Properties.Resources.RUN_AUTO;
                                                
                                            }
                                            else
                                            {
                                                myImage = MES_APP_P90.Properties.Resources.RUN_MENUAL;
                                            }
                                            tMatrixButtonV1.iConImage2_Set(k, myImage);
                                            break;
                                        }
                                    }

                                    break;


                                case "RUN_ERROR":

                                    vFACILITY_CD = e.SendData.Tables["COMMAND"].Rows[i][2].ToString();
                                    
                                    for (int k = 0; k < tMatrixButtonV1.DataSource.Rows.Count; k++)
                                    {
                                        if (tMatrixButtonV1.DataSource.Rows[k][tMatrixButtonV1.ValueMember].ToString().ToUpper() == vFACILITY_CD)
                                        {
                                            if (e.SendData.Tables["COMMAND"].Rows[i][3].ToString() == "1")
                                            {
                                                myImage = MES_APP_P90.Properties.Resources.RUN_ERROR;
                                                
                                            }
                                            else
                                            {
                                                myImage = MES_APP_P90.Properties.Resources.RUN_MENUAL;
                                            }
                                            tMatrixButtonV1.iConImage2_Set(k, myImage);
                                            break;
                                        }
                                    }

                                    break;

                                case "RUN_UNWORK":  //비가동 상태

                                    if (tabMenu.SelectedTab.Name == TABCONTROL_NAME.성형작업)
                                    {
                                        ctL_P9001C11.DBQuery(sPLANT_CD, sFACILITY_CD, sWC_MGR, sWC_CD, sWORKER_CD); //설비 비가동 체크
                                    }
                                    else
                                    {
                                        ctL_P9001C11.OP_NM = "";    //비가동 창 숨김
                                    }

                                    break;

                                case "STATUS_CHANGE":   //설비 상태값이 변경된다.

                                    DBQuery_PLC_INFO(sFACILITY_CD, sUNIT_CD);//설비의 상태 정보를 조회한다.

                                    break;
                            }
                            break;
                    }


                }

            }
        }

        private void apP_P9001M11_Load(object sender, EventArgs e)
        {

        }
    }
}
