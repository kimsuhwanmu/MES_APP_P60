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
using TGSControl;




namespace MES_APP_P90
{
    public partial class APP_P9005MA1 : UserControl
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
            public const string PLANT_CD = "PLANT_CD";                      //공장코드
            public const string PRODT_ORDER_NO = "PRODT_ORDER_NO";          //제조오더번호   
            public const string OPR_NO = "OPR_NO";//공순
            public const string WC_NM = "WC_NM";//작업장명
            public const string FACILITY_CD = "FACILITY_CD";//설비코드
            public const string FACILITY_NM = "FACILITY_NM";//설비명
            public const string PLAN_START_DT = "PLAN_START_DT"; //제조오더 시작 예정 시간
            public const string ITEM_CD = "ITEM_CD"; //품번
            public const string PRODT_ORDER_QTY = "PRODT_ORDER_QTY";//오더수량
            public const string PROD_QTY_IN_ORDER_UNIT = "PROD_QTY_IN_ORDER_UNIT"; //단위별오더수량
            public const string PROD_QTY = "PROD_QTY"; //총생산수량
            public const string GOOD_QTY = "GOOD_QTY";//양품수량
            public const string BAD_QTY = "BAD_QTY"; //불량수량
            public const string BAD_RATE = "BAD_RATE"; //불량률
            public const string ORDER_STATUS = "ORDER_STATUS"; //오더 상태
            public const string ITEM_NM = "ITEM_NM";//품명
            public const string SPEC = "SPEC";//규격

        }

        public struct grid2_COLUMN
        {

            public const string PLANT_CD = "PLANT_CD";
            public const string PRODT_ORDER_NO = "PRODT_ORDER_NO";
            public const string OPR_NO = "OPR_NO";
            public const string WC_NM = "WC_NM";
            public const string FACILITY_CD = "FACILITY_CD";
            public const string FACILITY_NM = "FACILITY_NM";
            public const string REAL_START_DT = "REAL_START_DT";
            public const string REAL_END_DT = "REAL_END_DT";
            public const string R01 = "R01";
            public const string R02 = "R02";
            public const string ITEM_CD = "ITEM_CD";
            public const string PRODT_ORDER_QTY = "PRODT_ORDER_QTY";
            public const string PROD_QTY_IN_ORDER_UNIT = "PROD_QTY_IN_ORDER_UNIT";
            public const string GOOD_QTY = "GOOD_QTY";
            public const string BAD_QTY = "BAD_QTY";
            public const string ORDER_STATUS = "ORDER_STATUS";
            public const string ITEM_NM = "ITEM_NM";
            public const string SPEC = "SPEC";
            public const string STATUS = "STATUS";
        }
            

        public struct grid3_COLUMN
        {

            public const string WC_CD = "WC_CD";
            public const string WC_NM = "WC_NM";
            public const string FACILITY_CD = "FACILITY_CD";
            public const string FACILITY_NM = "FACILITY_NM";
            public const string ITEM_CD = "ITEM_CD";
            public const string ITEM_NM = "ITEM_NM";
            public const string PRODT_ORDER_QTY = "PRODT_ORDER_QTY";
            public const string PRODT_QTY = "PRODT_QTY";
            public const string GOOD_QTY = "GOOD_QTY";
            public const string BAD_QTY = "BAD_QTY";
            public const string BAD_RATE = "BAD_RATE";

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
        String _PG_NM = "POP 데이터 조회";

        string sPLANT_CD = "";      //공장
        string sWC_MGR = "";        //대공정
        string sWC_MGR_NM = "";        //대공정
        
        string sWC_CD = "";         //작업장
        string sWC_NM = "";         //작업장
        string sFACILITY_CD = "";   //설비번호 
        string sFACILITY_NM = "";
        string sITEM_CD = "";
        string sWORKER_CD = "";
        string sWORKER_NM = "";
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

        public APP_P9005MA1()
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
            dt_DT_con.ValueFrom = A.ToString("yyyy-MM-dd");
            dt_DT_con.ValueTo = A.ToString("yyyy-MM-dd");


        }

        #endregion

        #region ■ 2.5 Gathering combo data(GatheringComboData) //콤보관련 데이타 설정

        protected void GatheringComboData()
        {

            //Load_Operator();  //작업자정보조회

            
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
        
        private void InitSpreadSheet()  //전체 스프레드시트를 초기화 한다.=====
        {
         
            InitSpreadSheet(1);
            InitSpreadSheet(2);
            InitSpreadSheet(3);

        }

        private void InitSpreadSheet(int p_GridIndex)   //선택된 스프레드시트를 초기화 한다.
        {

            

            if (p_GridIndex == 1)
            {

                #region ■■ 3.1.1 Pre-setting grid information

                Grid1.SetViewType(TGSControl.ControlEnumDef.FormType.Query);

                Grid1.Columns.Clear();


                Grid1.SetColumnEdit(grid1_COLUMN.PLANT_CD, "공장코드", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 130);
                Grid1.SetColumnEdit(grid1_COLUMN.PRODT_ORDER_NO, "제조오더번호", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 130);
                Grid1.SetColumnEdit(grid1_COLUMN.OPR_NO, "공순", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 70);
                Grid1.SetColumnEdit(grid1_COLUMN.WC_NM, "작업장명", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 100);
                Grid1.SetColumnEdit(grid1_COLUMN.FACILITY_CD, "설비코드", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 100);
                Grid1.SetColumnEdit(grid1_COLUMN.FACILITY_NM, "설비명", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 120);
                Grid1.SetColumnEdit(grid1_COLUMN.PLAN_START_DT, "오더시작시간", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 130);
                Grid1.SetColumnEdit(grid1_COLUMN.ITEM_CD, "품목", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 130);
                Grid1.SetColumnEdit(grid1_COLUMN.ITEM_NM, "품명", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 120);
                Grid1.SetColumnEdit(grid1_COLUMN.SPEC, "규격", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 100);

                Grid1.SetColumnFloat(grid1_COLUMN.PRODT_ORDER_QTY, "오더수량", TGridNumericColumn.ggQty, ControlEnumDef.FieldType.ReadOnly, ControlEnumDef.HAlign.Right, int.MinValue, int.MaxValue, 120);
                Grid1.SetColumnFloat(grid1_COLUMN.PROD_QTY_IN_ORDER_UNIT, "오더단위수량", TGridNumericColumn.ggQty, ControlEnumDef.FieldType.ReadOnly, ControlEnumDef.HAlign.Right, int.MinValue, int.MaxValue, 120);
                Grid1.SetColumnFloat(grid1_COLUMN.PROD_QTY, "총생산수량", TGridNumericColumn.ggQty, ControlEnumDef.FieldType.ReadOnly, ControlEnumDef.HAlign.Right, int.MinValue, int.MaxValue, 120);
                Grid1.SetColumnFloat(grid1_COLUMN.GOOD_QTY, "양품수량", TGridNumericColumn.ggQty, ControlEnumDef.FieldType.ReadOnly, ControlEnumDef.HAlign.Right, int.MinValue, int.MaxValue, 120);
                Grid1.SetColumnFloat(grid1_COLUMN.BAD_QTY, "불량수량", TGridNumericColumn.ggQty, ControlEnumDef.FieldType.ReadOnly, ControlEnumDef.HAlign.Right, int.MinValue, int.MaxValue, 120);
                Grid1.SetColumnFloat(grid1_COLUMN.BAD_RATE, "불량률", TGridNumericColumn.ggUserDefined6, ControlEnumDef.FieldType.ReadOnly, ControlEnumDef.HAlign.Right, int.MinValue, int.MaxValue, 100);
                
                Grid1.SetColumnEdit(grid1_COLUMN.ORDER_STATUS, "오더상태", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 80);
                
                #endregion


                #region ■■ 3.1.2 Formatting grid information

                //Grid1.Columns[grid1_COLUMN.PRODT_ORDER_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.PRODT_ORDER_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                //Grid1.Columns[grid1_COLUMN.PROD_QTY_IN_ORDER_UNIT].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.PROD_QTY_IN_ORDER_UNIT].DefaultCellStyle.Format = "N0";   //숫자표시형태
                //Grid1.Columns[grid1_COLUMN.PROD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.PROD_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                //Grid1.Columns[grid1_COLUMN.GOOD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.GOOD_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                //Grid1.Columns[grid1_COLUMN.BAD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.BAD_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                Grid1.Columns[grid1_COLUMN.BAD_RATE].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid1.Columns[grid1_COLUMN.BAD_RATE].DefaultCellStyle.Format = "N5";   //숫자표시형태

                #endregion


                #region ■■ 3.1.3 Setting etc grid
                // Hidden Column Setting
                Grid1.Columns[grid1_COLUMN.PLANT_CD].Visible = false;
                Grid1.Columns[grid1_COLUMN.FACILITY_CD].Visible = false;
                Grid1.Columns[grid1_COLUMN.PROD_QTY_IN_ORDER_UNIT].Visible = false;

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

                Grid2.SetViewType(TGSControl.ControlEnumDef.FormType.Query);

                Grid2.Columns.Clear();


                Grid2.SetColumnEdit(grid2_COLUMN.PRODT_ORDER_NO, "제조오더번호", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 120);
                Grid2.SetColumnEdit(grid2_COLUMN.OPR_NO, "공순", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 80);
                Grid2.SetColumnEdit(grid2_COLUMN.ITEM_CD, "품목", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 130);
                Grid2.SetColumnEdit(grid2_COLUMN.ITEM_NM, "품명", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 120);
                Grid2.SetColumnEdit(grid2_COLUMN.SPEC, "규격", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 140);
                Grid2.SetColumnEdit(grid2_COLUMN.WC_NM, "작업장", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 100);
                Grid2.SetColumnEdit(grid2_COLUMN.FACILITY_CD, "설비코드", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 140);
                Grid2.SetColumnEdit(grid2_COLUMN.FACILITY_NM, "설비명", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 120);
                Grid2.SetColumnEdit(grid2_COLUMN.REAL_START_DT, "시작시간", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 130);
                Grid2.SetColumnEdit(grid2_COLUMN.REAL_END_DT, "완료시각", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 130);
                Grid2.SetColumnFloat(grid2_COLUMN.R01, "작업시간(분)", TGridNumericColumn.ggQty, ControlEnumDef.FieldType.ReadOnly, ControlEnumDef.HAlign.Right, int.MinValue, int.MaxValue, 120);
                Grid2.SetColumnFloat(grid2_COLUMN.R02, "시간당생산량(분)", TGridNumericColumn.ggQty, ControlEnumDef.FieldType.ReadOnly, ControlEnumDef.HAlign.Right, int.MinValue, int.MaxValue, 140);
                Grid2.SetColumnFloat(grid2_COLUMN.PRODT_ORDER_QTY, "오더수량", TGridNumericColumn.ggQty, ControlEnumDef.FieldType.ReadOnly, ControlEnumDef.HAlign.Right, int.MinValue, int.MaxValue, 120);
                Grid2.SetColumnFloat(grid2_COLUMN.PROD_QTY_IN_ORDER_UNIT, "오더단위수량", TGridNumericColumn.ggQty, ControlEnumDef.FieldType.ReadOnly, ControlEnumDef.HAlign.Right, int.MinValue, int.MaxValue, 140);
                Grid2.SetColumnFloat(grid2_COLUMN.GOOD_QTY, "양품수량", TGridNumericColumn.ggQty, ControlEnumDef.FieldType.ReadOnly, ControlEnumDef.HAlign.Right, int.MinValue, int.MaxValue, 100);
                Grid2.SetColumnFloat(grid2_COLUMN.BAD_QTY, "불량수량", TGridNumericColumn.ggQty, ControlEnumDef.FieldType.ReadOnly, ControlEnumDef.HAlign.Right, int.MinValue, int.MaxValue, 100);
                Grid2.SetColumnEdit(grid2_COLUMN.ORDER_STATUS, "오더상태", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 100);
                Grid2.SetColumnEdit(grid2_COLUMN.STATUS, "생산상태", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 100);


                #endregion


                #region ■■ 3.2.2 Formatting grid information

                #endregion



                #region ■■ 3.2.3 Setting etc grid
                // Hidden Column Setting
                Grid2.Columns[grid2_COLUMN.PROD_QTY_IN_ORDER_UNIT].Visible = false;
                Grid2.Columns[grid2_COLUMN.ORDER_STATUS].Visible = false;
             

                #endregion

                //TGSClass.Util.Grid_Resize(Grid2);
            }

            if (p_GridIndex == 3)
            {

                #region ■■ 3.2.1 Pre-setting grid information


                /*** grid1
                 *  실적조회
                 * **/

                Grid3.SetViewType(TGSControl.ControlEnumDef.FormType.Query);

                Grid3.Columns.Clear();


                Grid3.SetColumnEdit(grid3_COLUMN.WC_CD, "작업장코드", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 120);
                Grid3.SetColumnEdit(grid3_COLUMN.WC_NM, "작업장", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 120);
                Grid3.SetColumnEdit(grid3_COLUMN.FACILITY_CD, "설비코드", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 120);
                Grid3.SetColumnEdit(grid3_COLUMN.FACILITY_NM, "설비", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 140);
                Grid3.SetColumnEdit(grid3_COLUMN.ITEM_CD, "품목", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 130);
                Grid3.SetColumnEdit(grid3_COLUMN.ITEM_NM, "품명", ControlEnumDef.FieldType.ReadOnly, false, ControlEnumDef.HAlign.Left, 120);
                Grid3.SetColumnFloat(grid3_COLUMN.PRODT_ORDER_QTY, "오더수량", TGridNumericColumn.ggQty, ControlEnumDef.FieldType.ReadOnly, ControlEnumDef.HAlign.Right, int.MinValue, int.MaxValue, 100);
                Grid3.SetColumnFloat(grid3_COLUMN.PRODT_QTY, "생산수량", TGridNumericColumn.ggQty, ControlEnumDef.FieldType.ReadOnly, ControlEnumDef.HAlign.Right, int.MinValue, int.MaxValue, 100);
                Grid3.SetColumnFloat(grid3_COLUMN.GOOD_QTY, "양품수량", TGridNumericColumn.ggQty, ControlEnumDef.FieldType.ReadOnly, ControlEnumDef.HAlign.Right, int.MinValue, int.MaxValue, 100);
                Grid3.SetColumnFloat(grid3_COLUMN.BAD_QTY, "불량수량", TGridNumericColumn.ggQty, ControlEnumDef.FieldType.ReadOnly, ControlEnumDef.HAlign.Right, int.MinValue, int.MaxValue, 100);
                Grid3.SetColumnFloat(grid3_COLUMN.BAD_RATE, "불량률", TGridNumericColumn.ggUserDefined6, ControlEnumDef.FieldType.ReadOnly, ControlEnumDef.HAlign.Right, int.MinValue, int.MaxValue, 100);


                #endregion


                #region ■■ 3.2.2 Formatting grid information

                Grid3.Columns[grid3_COLUMN.BAD_RATE].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid3.Columns[grid3_COLUMN.BAD_RATE].DefaultCellStyle.Format = "N5";   //숫자표시형태


                #endregion


                #region ■■ 3.2.3 Setting etc grid
                // Hidden Column Setting
                Grid3.Columns[grid3_COLUMN.WC_CD].Visible = false;
                Grid3.Columns[grid3_COLUMN.FACILITY_CD].Visible = false;

                #endregion

                //TGSClass.Util.Grid_Resize(Grid2);
            }
        }


        #endregion

        #region ■ 3.2 InitData

        public void InitData()
        {
            // TO-DO: 컨트롤을 초기화(또는 초기값)할때 할일 
            // SetDefaultVal과의 차이점은 전자는 Form_Load 시점에 콘트롤에 초기값을 세팅하는것이고
            // 후자는 특정 시점(조회후 또는 행추가후 등 특정이벤트)에서 초기값을 셋팅한다.


            DateTime CurrentDT = DateTime.Now;
            dt_DT_con.ValueFrom = CurrentDT.ToString("yyyy-MM-01");
            dt_DT_con.ValueTo = CurrentDT.ToString("yyyy-MM-dd");
            
            //작업일자 조회
            /*tDateTerm1.ValueFrom_Datetime = DBQuery_WK_DT();
            tDateTerm1.ValueTo_Datetime = tDateTerm1.ValueFrom_Datetime;*/
            

           

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
            DBQuery_grid1();    //작업지시현황을 조회 
            DBQuery_grid3();

            return true;
        }

        private void DBQuery_grid1() //
        {
            //Grid1.Rows.Clear();

            DataTable dataT = null;
            dataT = new DataTable();
            int nCnt = 0;

            string strData = "";

            strData += "EXEC DBO.XUSP_TPC_P9005MA1_GET_LIST ";
            strData += " @PLANT_CD ='" + sPLANT_CD + "' ";
            strData += ", @DT_FR ='" + dt_DT_con.ValueFrom.ToString().Substring(0, 10) + "' ";
            strData += ", @DT_TO ='" + dt_DT_con.ValueTo.ToString().Substring(0, 10) + "' ";
            strData += ", @ITEM_CD ='" + opn_ITEM_CD.Value.ToString() + "' ";
            strData += ", @WK_ID ='" + opn_WK_ID.Value.ToString() + "'  ";
            strData += ", @WC_CD ='" + opn_WC_CD.Value.ToString() + "' ";
            strData += ", @RESOURCE_CD ='" + opn_FA_CD.Value.ToString() + "' ";

            strData += ";";

            try
            {

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dataT, ref nCnt);
                //string strState = nsFuncUtil.FuncUtil.GetDataSql(MainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (!@strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "품목정보 조회");
                    return;
                }

                if (dataT != null)
                {
                    Grid1.GridDataBinding(dataT);
                }
                else
                {

                    string Msg = "검색된 작업지시가 없습니다...\r\n\r\n* 검색 조건을 확인하시기 바랍니다.";
                     TGSControl.UsrFunction.MessageBoxErr(Msg, _PG_NM);
                    //MessageBox.Show(Msg, "[확인]", MessageBoxButtons.OK);
                    return;

                }
            }
            catch (Exception ex)
            {
                string Msg = ex.Message;
                TGSControl.UsrFunction.MessageBoxErr(Msg, _PG_NM);
                //MessageBox.Show(msg1);


                return;
            }
            finally
            {
            }
            return;
        }


        private void DBQuery_grid2(string prodt_no) //제조오더별 실적현황
        {
            //Grid2.Rows.Clear();

            DataTable dataT = null;
            dataT = new DataTable();
            int nCnt = 0;

            string strData = "";

            strData += "EXEC DBO.XUSP_TPC_P9005MA1_GET_LIST2 ";
            strData += " @PLANT_CD ='" + sPLANT_CD + "' ";
            strData += ", @PRODT_NO ='" + prodt_no + "' ";
            strData += ", @WK_ID ='" + opn_WK_ID.Value.ToString() + "'  ";
            strData += ", @WC_CD ='" + opn_WC_CD.Value.ToString() + "' ";
            strData += ", @RESOURCE_CD ='" + opn_FA_CD.Value.ToString() + "' ";

            strData += ";";

            try
            {
                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dataT, ref nCnt);
                //string strState = nsFuncUtil.FuncUtil.GetDataSql(MainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (!@strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "품목정보 조회");
                    return;
                }

                if (dataT != null)
                {
                    Grid2.GridDataBinding(dataT);
                }

            }
            catch (Exception ex)
            {
                string Msg = ex.Message;
                TGSControl.UsrFunction.MessageBoxErr(Msg, _PG_NM);
                //MessageBox.Show(msg1);


                return;
            }
            finally
            {
            }
            return;
        }


        private void DBQuery_grid3() //제조오더별 실적현황
        {
            //Grid3.Rows.Clear();

            DataTable dataT = null;
            dataT = new DataTable();
            int nCnt = 0;

            string strData = "";

            strData += "EXEC DBO.XUSP_TPC_P9005MA1_GET_LIST3";
            strData += " @PLANT_CD ='" + sPLANT_CD + "' ";
            strData += ", @DT_FR ='" + dt_DT_con.ValueFrom.ToString().Substring(0, 10) + "' ";
            strData += ", @DT_TO ='" + dt_DT_con.ValueTo.ToString().Substring(0, 10) + "' ";
            strData += ", @ITEM_CD ='" + opn_ITEM_CD.Value.ToString() + "' ";
            strData += ", @WK_ID ='" + opn_WK_ID.Value.ToString() + "'  ";
            strData += ", @WC_CD ='" + opn_WC_CD.Value.ToString() + "' ";
            strData += ", @RESOURCE_CD ='" + opn_FA_CD.Value.ToString() + "' ";

            strData += ";";

            try
            {
                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dataT, ref nCnt);
                //string strState = nsFuncUtil.FuncUtil.GetDataSql(MainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (!@strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "품목정보 조회");
                    return;
                }

                if (dataT != null)
                {
                    Grid3.GridDataBinding(dataT);
                }

            }
            catch (Exception ex)
            {
                string Msg = ex.Message;
                TGSControl.UsrFunction.MessageBoxErr(Msg, _PG_NM);
                //MessageBox.Show(msg1);


                return;
            }
            finally
            {
            }
            return;
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
        #region ■■ 5.1.1 User_Defined
        private void opn_ITEM_CD_OpenPopup(object sender, EventArgs e)
        {
            MES_SYS_B00.POP_ITEM myPopupForm = new MES_SYS_B00.POP_ITEM();

            DataTable dt = new DataTable("PassData");
            dt.Columns.Add("PLANT_CD");
            dt.Columns.Add("ITEM_CD");
            dt.Columns.Add("ITEM_NM");

            dt.Rows.Add();

            dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
            dt.Rows[0]["ITEM_CD"] = opn_ITEM_CD.Value;
            dt.Rows[0]["ITEM_NM"] = opn_ITEM_CD.ValueName;

            myPopupForm.ResultData.Tables.Add(dt); //변수전달


            myPopupForm.MainForm = this.MainForm;
            myPopupForm.Start();

            DialogResult dResult = myPopupForm.ShowDialog();

            if (dResult == DialogResult.OK)
            {

                //품번조회 완료


                opn_ITEM_CD.Value = myPopupForm.ResultData.Tables["Result"].Rows[0]["ITEM_CD"].ToString();
                opn_ITEM_CD.ValueName = myPopupForm.ResultData.Tables["Result"].Rows[0]["ITEM_NM"].ToString();


            }

            myPopupForm.Dispose();
        }
        private void btnFind_ButtonClick(object sender, EventArgs e)
        {
           
        }
        
        private void Grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if (Grid1.CurrentRow == null)
                return;

            /* string strResult_No = Grid1.CurrentRow.Cells[grid1_COLUMN.RESULT_NO].Value.ToString().Trim();

             sITEM_CD = Grid1.CurrentRow.Cells[grid1_COLUMN.ITEM_CD].Value.ToString();  //선택된 품번*/

            /* if (strResult_No != "")
             {
                 //DBQuery_lot_no(strResult_No);
             }*/
            DBQuery_grid2(Grid1.CurrentRow.Cells[grid1_COLUMN.PRODT_ORDER_NO].Value.ToString());


        }

        private void Grid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (Grid2.CurrentRow == null) return;
            if (Grid2.CurrentCell == null) return;


        }

        private void Grid3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return;
            if (Grid3.CurrentRow == null) return;
            if (Grid3.CurrentCell == null) return;
        }

        private void opn_ITEM_CD_ValueChanged(object sender, EventArgs e)
        {
            if (sLoading) return;
            DBQuery();

        }
    

    
        private void APP_P3101Q1_Resize(object sender, EventArgs e)
        {
            /*TGSClass.Util.Grid_Resize(Grid1);
            TGSClass.Util.Grid_Resize(Grid2);
            TGSClass.Util.Grid_Resize(Grid3);*/

        }

        private void opn_WC_CD_OpenPopup(object sender, EventArgs e)
        {
            MES_SYS_B03.POP_RESOURCE_WC myPopupForm = new MES_SYS_B03.POP_RESOURCE_WC();

            DataTable dt = new DataTable("PassData");
            dt.Columns.Add("FLAG");
            dt.Columns.Add("PLANT_CD");
            dt.Columns.Add("WC_MGR");
            dt.Columns.Add("WC_MGR_NM");
            dt.Columns.Add("WC_CD");
            dt.Columns.Add("WC_NM");
            dt.Columns.Add("RESOURCE_CD");
            dt.Columns.Add("RESOURCE_NM");
            dt.Columns.Add("WK_ID");
            dt.Columns.Add("WK_NM");
            dt.Columns.Add("BASE_DT");

            dt.Rows.Add();

            dt.Rows[0]["FLAG"] = "RES";
            dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
            dt.Rows[0]["WC_MGR"] = sWC_MGR;
            dt.Rows[0]["WC_MGR_NM"] = sWC_MGR_NM;
            dt.Rows[0]["WC_CD"] = sWC_CD;
            dt.Rows[0]["WC_NM"] = sWC_NM;
            dt.Rows[0]["RESOURCE_CD"] = sFACILITY_CD;
            dt.Rows[0]["RESOURCE_NM"] = sFACILITY_NM;
            dt.Rows[0]["WK_ID"] = sWORKER_CD;
            dt.Rows[0]["WK_NM"] = sWORKER_NM;
            dt.Rows[0]["BASE_DT"] = DateTime.Now.ToString("yyyy-MM-dd");

            myPopupForm.ResultData.Tables.Add(dt); //변수전달

            myPopupForm.MainForm = this.MainForm;
            myPopupForm.Start();

            DialogResult dResult = myPopupForm.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                sWC_MGR = myPopupForm.ResultData.Tables["Result"].Rows[0]["WC_MGR"].ToString();
                sWC_MGR_NM = myPopupForm.ResultData.Tables["Result"].Rows[0]["WC_MGR_NM"].ToString();
                sFACILITY_CD = myPopupForm.ResultData.Tables["Result"].Rows[0]["RESOURCE_CD"].ToString();
                sFACILITY_NM = myPopupForm.ResultData.Tables["Result"].Rows[0]["RESOURCE_NM"].ToString();
                sWC_CD = myPopupForm.ResultData.Tables["Result"].Rows[0]["WC_CD"].ToString();
                sWC_NM = myPopupForm.ResultData.Tables["Result"].Rows[0]["WC_NM"].ToString();
                sWORKER_CD = myPopupForm.ResultData.Tables["Result"].Rows[0]["WK_ID"].ToString();
                sWORKER_NM = myPopupForm.ResultData.Tables["Result"].Rows[0]["WK_NM"].ToString();

                opn_WC_CD.Value = sWC_CD;
                opn_WC_CD.ValueName = sWC_NM;
                opn_FA_CD.Value = sFACILITY_CD;
                opn_FA_CD.ValueName = sFACILITY_NM;
                opn_WK_ID.Value = sWORKER_CD;
                opn_WK_ID.ValueName = sWORKER_NM;
            }

            myPopupForm.Dispose();
        }

        private void opn_FA_CD_OpenPopup(object sender, EventArgs e)
        {
            MES_SYS_B03.POP_RESOURCE_WC myPopupForm = new MES_SYS_B03.POP_RESOURCE_WC();

            DataTable dt = new DataTable("PassData");
            dt.Columns.Add("FLAG");
            dt.Columns.Add("PLANT_CD");
            dt.Columns.Add("WC_MGR");
            dt.Columns.Add("WC_MGR_NM");
            dt.Columns.Add("WC_CD");
            dt.Columns.Add("WC_NM");
            dt.Columns.Add("RESOURCE_CD");
            dt.Columns.Add("RESOURCE_NM");
            dt.Columns.Add("WK_ID");
            dt.Columns.Add("WK_NM");
            dt.Columns.Add("BASE_DT");

            dt.Rows.Add();

            dt.Rows[0]["FLAG"] = "RES";
            dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
            dt.Rows[0]["WC_MGR"] = sWC_MGR;
            dt.Rows[0]["WC_MGR_NM"] = sWC_MGR_NM;
            dt.Rows[0]["WC_CD"] = sWC_CD;
            dt.Rows[0]["WC_NM"] = sWC_NM;
            dt.Rows[0]["RESOURCE_CD"] = sFACILITY_CD;
            dt.Rows[0]["RESOURCE_NM"] = sFACILITY_NM;
            dt.Rows[0]["WK_ID"] = sWORKER_CD;
            dt.Rows[0]["WK_NM"] = sWORKER_NM;
            dt.Rows[0]["BASE_DT"] = DateTime.Now.ToString("yyyy-MM-dd");

            myPopupForm.ResultData.Tables.Add(dt); //변수전달

            myPopupForm.MainForm = this.MainForm;
            myPopupForm.Start();

            DialogResult dResult = myPopupForm.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                sWC_MGR = myPopupForm.ResultData.Tables["Result"].Rows[0]["WC_MGR"].ToString();
                sWC_MGR_NM = myPopupForm.ResultData.Tables["Result"].Rows[0]["WC_MGR_NM"].ToString();
                sFACILITY_CD = myPopupForm.ResultData.Tables["Result"].Rows[0]["RESOURCE_CD"].ToString();
                sFACILITY_NM = myPopupForm.ResultData.Tables["Result"].Rows[0]["RESOURCE_NM"].ToString();
                sWC_CD = myPopupForm.ResultData.Tables["Result"].Rows[0]["WC_CD"].ToString();
                sWC_NM = myPopupForm.ResultData.Tables["Result"].Rows[0]["WC_NM"].ToString();
                sWORKER_CD = myPopupForm.ResultData.Tables["Result"].Rows[0]["WK_ID"].ToString();
                sWORKER_NM = myPopupForm.ResultData.Tables["Result"].Rows[0]["WK_NM"].ToString();

                opn_WC_CD.Value = sWC_CD;
                opn_WC_CD.ValueName = sWC_NM;
                opn_FA_CD.Value = sFACILITY_CD;
                opn_FA_CD.ValueName = sFACILITY_NM;
                opn_WK_ID.Value = sWORKER_CD;
                opn_WK_ID.ValueName = sWORKER_NM;
            }

            myPopupForm.Dispose();
        }

        private void opn_WK_ID_OpenPopup(object sender, EventArgs e)
        {
            MES_SYS_B03.POP_RESOURCE_WC myPopupForm = new MES_SYS_B03.POP_RESOURCE_WC();

            DataTable dt = new DataTable("PassData");
            dt.Columns.Add("FLAG");
            dt.Columns.Add("PLANT_CD");
            dt.Columns.Add("WC_MGR");
            dt.Columns.Add("WC_MGR_NM");
            dt.Columns.Add("WC_CD");
            dt.Columns.Add("WC_NM");
            dt.Columns.Add("RESOURCE_CD");
            dt.Columns.Add("RESOURCE_NM");
            dt.Columns.Add("WK_ID");
            dt.Columns.Add("WK_NM");
            dt.Columns.Add("BASE_DT");

            dt.Rows.Add();

            dt.Rows[0]["FLAG"] = "USR";
            dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
            dt.Rows[0]["WC_MGR"] = sWC_MGR;
            dt.Rows[0]["WC_MGR_NM"] = sWC_MGR_NM;
            dt.Rows[0]["WC_CD"] = sWC_CD;
            dt.Rows[0]["WC_NM"] = sWC_NM;
            dt.Rows[0]["RESOURCE_CD"] = sFACILITY_CD;
            dt.Rows[0]["RESOURCE_NM"] = sFACILITY_NM;
            dt.Rows[0]["WK_ID"] = sWORKER_CD;
            dt.Rows[0]["WK_NM"] = sWORKER_NM;
            dt.Rows[0]["BASE_DT"] = DateTime.Now.ToString("yyyy-MM-dd");

            myPopupForm.ResultData.Tables.Add(dt); //변수전달

            myPopupForm.MainForm = this.MainForm;
            myPopupForm.Start();

            DialogResult dResult = myPopupForm.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                sWC_MGR = myPopupForm.ResultData.Tables["Result"].Rows[0]["WC_MGR"].ToString();
                sWC_MGR_NM = myPopupForm.ResultData.Tables["Result"].Rows[0]["WC_MGR_NM"].ToString();
                sWORKER_CD = myPopupForm.ResultData.Tables["Result"].Rows[0]["WK_ID"].ToString();
                sWORKER_NM = myPopupForm.ResultData.Tables["Result"].Rows[0]["WK_NM"].ToString();

                opn_WK_ID.Value = sWORKER_CD;
                opn_WK_ID.ValueName = sWORKER_NM;
            }

            myPopupForm.Dispose();
        }

        private void btn_Query_ButtonClick(object sender, EventArgs e)
        {
            DBQuery();
        }
        #endregion


    }
}

