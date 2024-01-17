using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

using TGSClass;
using TGSClass.nsGlobal;
using TGSClass.nsWorkCode;

namespace MES_APP_P90
{
    public partial class POP_P9002PA2 : Form
    {
        
        
        
        #region ▶ 1. Declaration part  //선언부

        #region ■ 1.1 Program information      //프로그램 정보 및 수정 이력 정보 
        /// <TemplateVersion>0.0.1.0</TemplateVersion>
        /// <NameSpace>①namespace</NameSpace>
        /// <Module>②module name</Module>
        /// <Class>③class name</Class>
        /// <Desc>④
        ///   생산실적 수량을 확정 한 후 저장 해서 실적처리 한다.
        /// </Desc>
        /// <History>⑤
        ///   <FirstCreated>
        ///     <history name="creator" Date="created date">2016-03-23 이동환</history>
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


        public struct grid1_COLUMN
        {
            
            //public const string LOC_NO = "LOC_NO";
            public const string LOT_NO = "LOT_NO";
            public const string ITEM_CD = "ITEM_CD";
            public const string ITEM_NM = "ITEM_NM";
            public const string PROD_QTY = "PROD_QTY";
            //public const string INV_UNIT = "INV_UNIT";
            public const string REAL_END_DT = "REAL_END_DT";
            public const string FACILITY_CD = "FACILITY_CD";
            public const string FACILITY_NM = "FACILITY_NM";
            public const string EMP_DESC = "EMP_DESC";
            public const string LIMIT_DT = "LIMIT_DT";
            public const string ISSUED_CD = "ISSUED_CD";

        }






        #endregion

        #region ■ 1.3. Class global variables (common) //글로벌 변수 선언


        private bool bSelectedPrinted = false;  //바코드 연속 발행여부
        ArrayList alBarcode = new ArrayList();  //바코드 출력용 배열


        Global global = new Global();
        Form sMainForm;

        
        String sPLANT_CD = "";      //공장
        String sWC_MGR = "";        //대공정
        String sWC_CD = "";         //작업장
        String sFACILITY_CD = "";   //설비번호

        string sWK_ORD_NO = "";     //작업지시번호
        string sRESULT_NO = "";     //생산실적번호
        string sWORKER_CD = "";     //작업자

        string sWorkQty_Seleted = "A";   //생산량 선택 B=적입량
        
        DataSet sResultData = new DataSet();

        bool sRESULT_USER_FLAG = false;    //사용자 소급실적등록 여부
        string sRESULT_USER_DT = "";   //사용자 소급 실적일자
        string sREAL_START_DT = ""; //작업시작일


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

        public POP_P9002PA2()
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
            //ProcessInform_Review(sFACILITY_CD, ref sWC_CD, ref WC_NM, false);   //선택된 설비의 작업장 정보

        }

        public void Start() //시작
        {

            initControl(); //컨트롤 초기화

            InitData();    //초기값 설정

            DBQuery();     //조회
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
            

            if (sResultData != null)
            {
                
                sWK_ORD_NO = sResultData.Tables["PassData"].Rows[0]["WK_ORD_NO"].ToString();
                sRESULT_NO = sResultData.Tables["PassData"].Rows[0]["RESULT_NO"].ToString();
                lbl_ITEM_CD.Caption  = sResultData.Tables["PassData"].Rows[0]["ITEM_CD"].ToString();
                lbl_ITEM_NM.Caption = sResultData.Tables["PassData"].Rows[0]["ITEM_NM"].ToString();
                sPLANT_CD = sResultData.Tables["PassData"].Rows[0]["PLANT_CD"].ToString();
                sFACILITY_CD = sResultData.Tables["PassData"].Rows[0]["FACILITY_CD"].ToString();
                sWC_MGR = sResultData.Tables["PassData"].Rows[0]["WC_MGR"].ToString();
                sWC_CD = sResultData.Tables["PassData"].Rows[0]["WC_CD"].ToString();

                lbl_WK_ORD_QTY.Caption = sResultData.Tables["PassData"].Rows[0]["WK_ORD_QTY"].ToString();
                lbl_WORK_QTY.Caption = sResultData.Tables["PassData"].Rows[0]["WORK_QTY"].ToString();
                lbl_LOT_QTY.Caption = sResultData.Tables["PassData"].Rows[0]["LOT_QTY"].ToString();

                Calc_BOXCnt();  //박스수량을 변경한다.

                sWORKER_CD = sResultData.Tables["PassData"].Rows[0]["WORKER_ID"].ToString();

                lbl_WORKER_NM.Caption = sResultData.Tables["PassData"].Rows[0]["WORKER_NM"].ToString();
                sREAL_START_DT = sResultData.Tables["PassData"].Rows[0]["REAL_START_DT"].ToString();



                if (sResultData.Tables["PassData"].Rows[0]["RESULT_USER_FLAG"].ToString().ToUpper() == "Y")
                {
                    sRESULT_USER_FLAG = true;
                }
                else
                {
                    sRESULT_USER_FLAG = false;
                }
                sRESULT_USER_DT = sResultData.Tables["PassData"].Rows[0]["RESULT_USER_DT"].ToString();
                
            }


        }

        #endregion

        #region ■ 2.5 Gathering combo data(GatheringComboData) //콤보관련 데이타 설정

        protected void GatheringComboData()
        {

            //Load_Operator();  //작업자정보조회

            //Load_Facility();    //설비 정보를 조회한다.

            //Load_WorkCenter();    //작업장 정보를 조회한다.

            // Example: Set ComboBox List (Column Name, Select, From, Where)
            //uniBase.UData.ComboMajorAdd("TaxPolicy", "B0004");
            //uniBase.UData.ComboCustomAdd("MSG_TYPE", "MINOR_CD , MINOR_NM ", "B_MINOR", "MAJOR_CD='A1001'");
            //uniBase.UData.ComboCustomAdd(cboSalesGrp.Name, "SALES_GRP , SALES_GRP_NM ", "B_SALES_GRP", "SALES_GRP < 'A'"); //영업그룹
            //uniBase.UData.ComboCustomAdd(cboSalesGrp.Name, "SALES_GRP , SALES_GRP_NM ", "B_SALES_GRP", "1=1 "); //영업그룹


            /* 판매계획유형*/
            //Fnc_crt_combo(this.cboSP_TYPE, "S0018", "S0018", 0);
            /* 거래구분*/
            //Fnc_crt_combo(this.cboLOC_EXP_FLAG, "S4225", "", 1);

            //Fnc_crt_combo(this.cboINV_YN, "", "INV_YN", 1, "구분", "실적처리구분", "자동 포장실적 처리 선택");
            

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
                case "INV_YN":    // 창고
                    strSql = "SELECT 'Y' AS CODE, '자동포장실적' AS NAME";
                    strSql += " UNION ALL ";
                    strSql += "SELECT 'N' AS CODE, '포장안함' AS NAME";


                    pValueMember = "CODE";
                    pDisplayMember = "NAME";

                    break;
                //case "SL_CD":    // 창고
                //    strSql = "EXEC DBO.XUSP_MESSVR_P5002P2_GET_SL ";
                //    strSql += "@PLANT_CD='" + Global.workinfo.szFactoryCD + "',";
                //    strSql += "@WC_MGR='" + Global.workinfo.szProcessCD + "'";

                //    pValueMember = "SL_CD";
                //    pDisplayMember = "SL_NM";

                //    break;
                //case "UD_MAJOR_CD":    // 사용자정의-공통코드..
                //    strSql = " SELECT DISTINCT RTRIM(AA.code) AS code, RTRIM(AA.name) AS name ";
                //    strSql += " FROM ( ";
                //    strSql += " SELECT  '1' AS LVL, '' AS code, '' AS name ";
                //    strSql += " UNION ALL ";
                //    strSql += " SELECT '2' AS LVL, RTRIM(AA.UD_MINOR_CD) AS code, RTRIM(AA.UD_MINOR_NM) AS name ";
                //    strSql += " FROM B_USER_DEFINED_MINOR AA (NOLOCK) ";
                //    strSql += " WHERE RTRIM(AA.UD_MAJOR_CD) = RTRIM('" + @MAJOR_CD + "')  ) AA ";
                //    strSql += " WHERE AA.LVL = '2' ";
                //    break;
                //default:    // 공통코드..
                //    strSql = " SELECT DISTINCT RTRIM(AA.code) AS code, RTRIM(AA.name) AS name ";
                //    strSql += " FROM ( ";
                //    strSql += " SELECT  '1' AS LVL, '' AS code, '' AS name ";
                //    strSql += " UNION ALL ";
                //    strSql += " SELECT '2' AS LVL, RTRIM(AA.MINOR_CD) AS code, RTRIM(AA.MINOR_NM) AS name ";
                //    strSql += " FROM B_MINOR AA (NOLOCK) ";
                //    strSql += " WHERE RTRIM(AA.MAJOR_CD) = RTRIM('" + @MAJOR_CD + "')  ) AA ";
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

        #region ■ 3.3 SetSpreadColor

        private void SetSpreadColor(int pvStartRow, int pvEndRow)
        {
            // TO-DO: InsertRow후 그리드 컬러 변경
            //uniGrid1.SSSetProtected(gridCol.LastNum, pvStartRow, pvEndRow);
        }
        #endregion

        #region ■ 3.1 Initialize Grid (InitSpreadSheet)

        private void InitSpreadSheet()  //전체 스프레드시트를 초기화 한다.
        {
            //InitSpreadSheet(1);
            //InitSpreadSheet(2);
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
                //Grid1.Columns.Clear();

                ////DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                ////columnHeaderStyle.BackColor = Color.Beige;
                ////columnHeaderStyle.Font = new Font("맑은 고딕", 14, FontStyle.Bold);
                ////Grid1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                //Grid1.RowHeadersVisible = false;

                ////Grid1.Columns.Add(SetColumnImage(gridWRDW11_COLUMN.CHECKFLAG, "√", 40));    //이미지형태의 그리드

                
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.CHECKFLAG, "√", 40));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.LOC_NO, "LOC_NO", 130));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.LOT_NO, "LOT_NO", 130));
                
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.INV_QTY, "총재고량", 90));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.INV_UNIT, "단위", 50));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.RESV_QTY, "예약량(SCAN)", 90));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.USE_QTY, "실소모량", 90));
                //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.USE_QTY_ORG, "실소모량", 0));

                #endregion


                #region ■■ 3.1.1.2 Formatting grid information

                ////uniGrid2.flagInformation("cud_flag", "rownum");
                ////uniGrid2.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.No);

                //Grid1.Columns[grid1_COLUMN.INV_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.INV_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태
                //Grid1.Columns[grid1_COLUMN.RESV_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.RESV_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                //Grid1.Columns[grid1_COLUMN.USE_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.USE_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                //Grid1.Columns[grid1_COLUMN.USE_QTY_ORG].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[grid1_COLUMN.USE_QTY_ORG].DefaultCellStyle.Format = "N0";   //숫자표시형태

                #endregion


                #region ■■ 3.1.1.3 Setting etc grid
                //// Hidden Column Setting
                //Grid1.Columns[grid1_COLUMN.USE_QTY_ORG].Visible = false;


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


            if (sWorkQty_Seleted == "A")
            {
                lbl_WORK_QTY.BorderBackColor = Color.Yellow;
                lbl_LOT_QTY.BorderBackColor = Color.White;
                lbl_BOX_CNT.BorderBackColor = Color.White;
            }
            else if (sWorkQty_Seleted == "B")
            {
                lbl_WORK_QTY.BorderBackColor = Color.White;
                lbl_LOT_QTY.BorderBackColor = Color.Yellow;
                lbl_BOX_CNT.BorderBackColor = Color.White;
            }
            else if (sWorkQty_Seleted == "C")
            {
                lbl_WORK_QTY.BorderBackColor = Color.White;
                lbl_LOT_QTY.BorderBackColor = Color.White;
                lbl_BOX_CNT.BorderBackColor = Color.Yellow;
            }

        }

        #endregion


        #region ■ 3.3 grid method //그리드 관련 함수

        ////그리그 Edit 컬럼 생성
        //private DataGridViewColumn SetColumnEdit(string ColumnName, string HeaderText, int Width)
        //{
        //    DataGridViewColumn myCol = new DataGridViewColumn();

        //    myCol.Name = ColumnName; myCol.HeaderText = HeaderText; myCol.Width = Width;


        //    DataGridViewCell myCell = new DataGridViewTextBoxCell();

        //    myCol.CellTemplate = myCell;




        //    if (myCol.Width == 0)
        //    {
        //        myCol.Visible = false;
        //    }
        //    else
        //    {
        //        myCol.Visible = true;
        //    }
        //    return myCol;

        //}

        ////그리드 Image 컬럼 생성
        //private DataGridViewColumn SetColumnImage(string ColumnName, string HeaderText, int Width) //이미지컬럼을 생성한다.
        //{
        //    DataGridViewImageColumn myCol = new DataGridViewImageColumn();


        //    myCol.Name = ColumnName; myCol.HeaderText = HeaderText; myCol.Width = Width;


        //    DataGridViewCell myCell = new DataGridViewImageCell();
        //    myCol.CellTemplate = myCell;


        //    if (myCol.Width == 0)
        //    {
        //        myCol.Visible = false;
        //    }
        //    else
        //    {
        //        myCol.Visible = true;
        //    }
        //    return myCol;

        //}
        #endregion

        #endregion

       


        #region ■ 4.4 Db function group

        #region ■■ 4.4.1 DBQuery(Common)

        private bool DBQuery()
        {
            
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
            return DBSave_Work_SaveLotResult();
        }
        #region ▶▶▶ 생산실적 처리
        private bool DBSave_Work_SaveLotResult() //생산실적 처리 함
        {

            
            try
            {
                LoadingForm(true);

                //double nOrderQty = double.Parse((string)dgWorking[nCheckRow, gridWPDW12_COLUMN.WK_ORD_QTY].ToString());
                //if (nTotalQty > nOrderQty)
                //{
                //    TGSControl.UsrFunction.MessageBoxErr("총 출고수량이 작업지시수량을 초과하였습니다.", "작업완료");
                //    return;
                //}

                //   0 공장코드 plant_cd
                //   1 업지시번호   wk_ord_no
                //   2 작업장 wc_cd
                //   3 설비코드 facility_cd
                //   4 생산수량  prod_qty
                //   5 LOT수량
                //   6 작업시작일시
                //   7 작업구분    --공정 코드(배합만 입력 나머지 공정은 '*')
                //   8 작업자 user_id
                //   9 작업실적코드

                //string szSendData = WorkCode.WorkCd.WORK_END;
                //szSendData += sPLANT_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += sWK_ORD_NO + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += sWC_CD  + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += sFACILITY_CD  + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += lbl_WORK_QTY.Caption.ToString().Replace(",", "") + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += lbl_LOT_QTY.Caption.ToString().Replace(",", "") + TGSClass.nsGlobal.Global.Separation.COLUMNS;

                //if (sRESULT_USER_FLAG == true && sRESULT_USER_DT != "")  //소급처리 실적이면
                //{
                //    szSendData += sRESULT_USER_DT + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //}
                //else
                //{
                //    szSendData += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //}

                //szSendData += "*" + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += sWORKER_CD.ToString() + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += sRESULT_NO + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += "1" + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += lbl_LOT_QTY.Caption.ToString() + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += "N" + TGSClass.nsGlobal.Global.Separation.COLUMNS;  //포장여부
                //szSendData += "Y" + TGSClass.nsGlobal.Global.Separation.COLUMNS;  //실적마감여부 '실적을 등록하면 실적마감됨
                //szSendData += "" + TGSClass.nsGlobal.Global.Separation.COLUMNS;   //에러코드
                //szSendData += "" + TGSClass.nsGlobal.Global.Separation.COLUMNS;   //대차코드
                //szSendData += "0" + TGSClass.nsGlobal.Global.Separation.COLUMNS;  //대차중량
                //szSendData += lbl_BOX_CNT.Value.ToString();   //최대 박스수량

                //string strState = nsFuncUtil.FuncUtil.ExcuteSql(this, szSendData, Global.workinfo.szServerIP, Global.workinfo.szPortNo);



                string strData = "";
                strData += "dbo.XUSP_MES_P_WORK_FINISHED_INSERT";       //프로시져 명
                strData += Global.COLUMNS_DIV + "N" + Global.Separation.COLUMNS;   //조회데이타가 없을 경우 'N' = nonquery 있을 경우 'Q' = query
                //일반변수 리스트
                strData += "@PLANT_CD" + Global.COLUMNS_DIV;
                strData += "@WK_ORD_NO" + Global.COLUMNS_DIV;
                strData += "@WC_CD" + Global.COLUMNS_DIV;
                strData += "@FACILITY_CD" + Global.COLUMNS_DIV;

                strData += "@PROD_QTY" + Global.COLUMNS_DIV;
                strData += "@LOT_QTY" + Global.COLUMNS_DIV;
                strData += "@START_DT" + Global.COLUMNS_DIV;
                strData += "@END_DT" + Global.COLUMNS_DIV;
                strData += "@JOB_CD" + Global.COLUMNS_DIV;
                
                strData += "@PAN_QTY" + Global.COLUMNS_DIV;
                strData += "@CAVITY" + Global.COLUMNS_DIV;
                strData += "@USER_ID" + Global.COLUMNS_DIV;
                strData += "@RESULT_NO" + Global.COLUMNS_DIV;
                strData += "@RTN_MSG" + Global.COLUMNS_DIV;
                
                strData += "@PACKING_FLAG" + Global.COLUMNS_DIV;
                strData += "@WORK_END_FLAG" + Global.COLUMNS_DIV;
                strData += "@ERROR_CD" + Global.COLUMNS_DIV;
                
                strData += "@CART_NO" + Global.COLUMNS_DIV;
                strData += "@CART_WGT" + Global.COLUMNS_DIV;
                strData += "@BOX_MAX_CNT" + Global.COLUMNS_DIV;
                strData += "@BP_CD" + Global.Separation.COLUMNS;
                

                //일반변수 리스트의 형식
                strData += Global.DBVarType.VarChar + "(4)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(30)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(7)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(18)" + Global.COLUMNS_DIV;

                strData += Global.DBVarType.Numeric + "(18,6)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.Numeric + "(18,6)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.Datetime + Global.COLUMNS_DIV;
                strData += Global.DBVarType.Datetime + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(10)" + Global.COLUMNS_DIV;


                strData += Global.DBVarType.Numeric + "(4,0)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.Numeric + "(4,0)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(10)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(20)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(200) OUTPUT" + Global.COLUMNS_DIV;

                strData += Global.DBVarType.VarChar + "(1)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(1)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(10)" + Global.COLUMNS_DIV;

                strData += Global.DBVarType.VarChar + "(20)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.Numeric + "(18,2)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.Numeric + "(4,0)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(10)" + Global.Separation.COLUMNS;



                //일반변수값 리스트
                strData += sPLANT_CD + Global.COLUMNS_DIV;  //공장
                strData += sWK_ORD_NO + Global.COLUMNS_DIV;         //실적번호
                strData += sWC_CD + Global.COLUMNS_DIV;    //작업장
                strData += sFACILITY_CD + Global.COLUMNS_DIV;   //설비

                strData += lbl_WORK_QTY.Caption.ToString().Replace(",", "") + Global.COLUMNS_DIV;    //생산량
                strData += lbl_LOT_QTY.Caption.ToString().Replace(",", "") + Global.COLUMNS_DIV;     //롯트량
                if (sREAL_START_DT == "")
                {
                    strData += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + Global.COLUMNS_DIV; //시작일자
                }
                else
                {
                    strData += sREAL_START_DT + Global.COLUMNS_DIV; //시작일자
                }
                if (sRESULT_USER_FLAG == true && sRESULT_USER_DT != "")     //사용자 소급실적일경우
                {
                    strData += sRESULT_USER_DT + Global.COLUMNS_DIV; //종료일자
                }
                else
                {
                    strData += "NULL" + Global.COLUMNS_DIV;      //종료일자
                }
                strData += "*" + Global.COLUMNS_DIV; //JOB CODE

                strData += "1" + Global.COLUMNS_DIV;
                strData += lbl_LOT_QTY.Caption.ToString() + Global.COLUMNS_DIV;
                strData += sWORKER_CD.ToString() + Global.COLUMNS_DIV;   //WORKER
                strData += sRESULT_NO + Global.COLUMNS_DIV;
                strData += "" + Global.COLUMNS_DIV;
                
                strData += "N" + Global.COLUMNS_DIV;  //포장여부
                strData += "Y" + Global.COLUMNS_DIV;  //실적마감여부 '실적을 등록하면 실적마감됨
                strData += "" + Global.COLUMNS_DIV;   //에러코드
                strData += "" + Global.COLUMNS_DIV;   //대차코드
                strData += "0" + Global.COLUMNS_DIV;  //대차중량

                strData += lbl_BOX_CNT.Value.ToString() + Global.COLUMNS_DIV;   //최대 박스수량
                strData += "" + Global.Separation.COLUMNS; //출고처

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


                DataTable dtData1 = new DataTable();
                int nCnt = 0;

                string strState = TGSClass.DataBase.GetDataSqlProcedur(MainForm, strData, ref dtData1, ref nCnt); //TGS Class 사용


                if (!strState.Equals("OK"))
                {
                    //TGSControl.UsrFunction.MessageBoxErr("작업완료중 오류가 발생하였습니다.", "작업완료");

                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "작업완료 중 에러");
                    LoadingForm(false);
                    return false ;
                }

                
                if (Global.workinfo.szPrinterName.Trim().Length > 0)
                {
                    LabelPrint_Work_Lot_RetriveData(sPLANT_CD , sRESULT_NO);

                    //바코드 출력
                    bSelectedPrinted = true;


                    if (Global.workinfo.szPrinterName == "")
                        printPreviewDialog1.ShowDialog();
                    else
                    {
                        printDialog1.PrinterSettings.PrinterName = Global.workinfo.szPrinterName; //"WF-2540 Series(네트워크)";
                        printDocument1.Print();
                    }

                }

                

                TGSControl.UsrFunction.MessageBoxInfo("완료처리 되었습니다.", "작업완료");
            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxInfo(se.Message, "작업완료 중 에러");
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

        #endregion


        #region ■ 7. User-defined method part

        private void LoadingForm(bool bVisible)
        {
            Cursor.Current = (bVisible == true) ? Cursors.WaitCursor : Cursors.Default;
            //waitLoading.Visible = bVisible;
            Application.DoEvents();
        }




        #endregion  User-defined method part

        private void windowsForm1_CloseClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void POP_P5001P3_Resize(object sender, EventArgs e)
        {

        }


        //용기수량 변경
        private void btn_BoxDeepQtyEdit_ButtonClick(object sender, EventArgs e)
        {
            
            TGSControl.frmEditNumeric myPopupForm = new TGSControl.frmEditNumeric();

            myPopupForm.Value = lbl_LOT_QTY.Caption;

            DialogResult dResult = myPopupForm.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                lbl_LOT_QTY.Caption = myPopupForm.Value;
            }

            Calc_BOXCnt();//용기 및 생산수량이 변경되면 박수 수를 재 계산 한다.

            myPopupForm.Dispose();
        }
        
        //생산수량 변경
        private void tEditNumeric1_EditValue(object sender, EventArgs e)
        {
            if (sWorkQty_Seleted == "A")
            {
                lbl_WORK_QTY.Caption = tEditNumeric1.Value;
                Calc_BOXCnt();//용기 및 생산수량이 변경되면 박스 수를 재 계산 한다.
            }
            else if (sWorkQty_Seleted == "B")
            {
                lbl_LOT_QTY.Caption = tEditNumeric1.Value;
                Calc_BOXCnt();//용기 및 생산수량이 변경되면 박스 수를 재 계산 한다.
            }
            else
            {
                lbl_BOX_CNT.Caption = tEditNumeric1.Value;
                //박스수량을 직접 입력 시 수량 재계산을 하지 않는다.
            } 

            
        }

        //용기 및 생산수량이 변경되면 박수 수를 재 계산 한다.
        private void Calc_BOXCnt()
        {
            if (Convert.ToDecimal(lbl_WORK_QTY.Value) > 0)
            {
                if (lbl_WORK_QTY.Value == "") lbl_WORK_QTY.Value = "0";
                if (lbl_LOT_QTY.Value == "") lbl_LOT_QTY.Value = "0";

                decimal vWork_Qty = Convert.ToDecimal (Convert.ToDecimal(lbl_WORK_QTY.Value.ToString().Replace(",","").ToString()));
                decimal vLot_Qty = Convert.ToDecimal(Convert.ToDecimal(lbl_LOT_QTY.Value.ToString().Replace(",", "").ToString()));

                if (vWork_Qty > 0)
                {
                    if (vLot_Qty == 0) vLot_Qty = vWork_Qty;

                    decimal i = decimal.Truncate(vWork_Qty / vLot_Qty);
                    decimal j = vWork_Qty % vLot_Qty;

                    if (j > 0)   //잔량이 있을 경우 용기수량 조정 필드 표시여부 체크
                    {
                        tLabel2.Visible = true;
                        chk_LOT_CNT.Visible = true;

                        i = i + 1;
                    }
                    else
                    {
                        tLabel2.Visible = false;
                        chk_LOT_CNT.Visible = false;
                    }

                    
                    lbl_BOX_CNT.Value = i.ToString();

                    if (sWorkQty_Seleted == "A")
                    {
                        lbl_WORK_QTY.BorderBackColor = Color.Yellow; ;
                        lbl_LOT_QTY.BorderBackColor = Color.White;
                        lbl_BOX_CNT.BorderBackColor = Color.White;
                    }
                    else if (sWorkQty_Seleted == "B")
                    {
                        lbl_WORK_QTY.BorderBackColor = Color.White;
                        lbl_LOT_QTY.BorderBackColor = Color.Yellow;
                        lbl_BOX_CNT.BorderBackColor = Color.White;
                    }
                    else if (sWorkQty_Seleted == "C")
                    {
                        lbl_WORK_QTY.BorderBackColor = Color.White;
                        lbl_LOT_QTY.BorderBackColor = Color.White;
                        lbl_BOX_CNT.BorderBackColor = Color.Yellow;
                    }
                }
                else
                {
                    lbl_BOX_CNT.Value = "0";
                    if (lbl_WORK_QTY.Value == "0")
                    {
                        lbl_WORK_QTY.BorderBackColor = Color.Red;
                    }
                    else
                    {
                        if (sWorkQty_Seleted == "A")
                        {
                            lbl_WORK_QTY.BorderBackColor = Color.Yellow;
                        }
                        else
                        {
                            lbl_WORK_QTY.BorderBackColor = Color.White;
                        }
                    }
                }

                chk_LOT_CNT.Checked = false;
            }
        }













        private void LabelPrint_Work_Lot_RetriveData(string pPLANT_CD, string pRESULT_NO)
        {
            int nCnt = 0;
            

            try
            {
                LoadingForm(true);

                

                string strData = "";
                //strData = WorkCode.WorkCd.LABEL_LOT_REVIEW;
                //strData += pPLANT_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strData += pRESULT_NO;
                
                strData += "EXEC DBO.XUSP_MESSVR_BL_LABEL_LOT_REVIEW_GET ";
                strData += "@PLANT_CD='" + pPLANT_CD + "',";
                strData += "@RESULT_NO='" + pRESULT_NO + "'";

                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);
                //string strState = nsFuncUtil.FuncUtil.GetDataSql(this, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);

                if (!strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "LABEL LOT조회");
                    return;
                }
                //if (dtData1 == null || dtData1.Rows.Count <= 0)
                //{
                //    LoadingForm(false);
                //    TGSControl.UsrFunction.MessageBoxErr("조회할 데이타가 존재하지 않습니다.", "LABEL LOT조회");
                //    return;
                //}


                System.Drawing.Image imgChecked = Properties.Resources.CheckBoxUnChecked;
                imgChecked.Tag = "N";

                nCurrentIndex = 0;
                alBarcode.Clear();
                for (int i = 0; i < dtData1.Rows.Count; i++)
                {
                    
                    DateTime dtTmp = DateTime.Parse(dtData1.Rows[i][grid1_COLUMN.REAL_END_DT].ToString());
                    Hashtable htTmp = new Hashtable();

                    htTmp.Add("LOT_NO", dtData1.Rows[i][grid1_COLUMN.LOT_NO].ToString());
                    htTmp.Add("ITEM_CD", dtData1.Rows[i][grid1_COLUMN.ITEM_CD].ToString());
                    htTmp.Add("ITEM_NM", dtData1.Rows[i][grid1_COLUMN.ITEM_NM].ToString());
                    htTmp.Add("QTY", dtData1.Rows[i][grid1_COLUMN.PROD_QTY].ToString());
                    htTmp.Add("FACILITY_CD", dtData1.Rows[i][grid1_COLUMN.FACILITY_CD].ToString());
                    htTmp.Add("FACILITY_NM", dtData1.Rows[i][grid1_COLUMN.FACILITY_NM].ToString());
                    htTmp.Add("WORKPLACE", Global.workinfo.szWorkSpaceNM);
                    htTmp.Add("WORKDATE", dtTmp.ToString("yy-MM-dd HH:mm"));

                    htTmp.Add("ISSUED_CD", dtData1.Rows[i][grid1_COLUMN.ISSUED_CD].ToString());
                    
                    dtTmp = DateTime.Parse(dtData1.Rows[i][grid1_COLUMN.LIMIT_DT].ToString());
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
                    htTmp.Add("OPERATOR", dtData1.Rows[i][grid1_COLUMN.EMP_DESC].ToString());
                    alBarcode.Add(htTmp);
                    
                }

            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "LABEL LOT조회");
            }
            finally
            {
                LoadingForm(false);
            }

        }

        private void LabelPrint_Save(string szLotNo, string szItem_CD, string szOperator)
        {
            try
            {
                LoadingForm(true);
                DataTable vDT = new DataTable();
                int nCnt = 0;
                string szSendData = WorkCode.WorkCd.LABEL_PRINTOUT;

                szSendData += sPLANT_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += szLotNo + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += szOperator + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += szItem_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += sWC_CD;


                string strState = TGSClass.DataBase.GetDataSql(this, szSendData, ref vDT, ref nCnt);
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


                Hashtable htTmp = new Hashtable();

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


                g.DrawLine(pen1, XGab + 0046.0F, YGab + 0032.0F, XGab + 0046.0F, YGab + 0046.0F); //작업자 좌측 세로 줄
                //g.DrawLine(pen1, XGab + 0046.0F, YGab + 0034.0F, XGab + 0046.0F, YGab + 0050.0F); //작업자 좌측 세로 줄//2018-06-29 하단 품목바코드 추가를 위한 위치조정
                

                //Header
                g.DrawString("품  번", Font10b, brushBlack, XGab + 0002.0F, YGab + 0017.5F, new StringFormat());

                g.DrawString("품  명", Font10b, brushBlack, XGab + 0002.0F, YGab + 0027.0F, new StringFormat());
                g.DrawString("생산일", Font10b, brushBlack, XGab + 0002.0F, YGab + 0034.0F, new StringFormat());
                g.DrawString("유효일", Font10b, brushBlack, XGab + 0002.0F, YGab + 0041.0F, new StringFormat());
                g.DrawString("자  원", Font10b, brushBlack, XGab + 0002.0F, YGab + 0047.0F, new StringFormat());
                //g.DrawString("품  명", Font10b, brushBlack, XGab + 0002.0F, YGab + 0028.0F, new StringFormat());
                //g.DrawString("생산일", Font10b, brushBlack, XGab + 0002.0F, YGab + 0036.0F, new StringFormat());
                //g.DrawString("유효일", Font10b, brushBlack, XGab + 0002.0F, YGab + 0044.0F, new StringFormat());
                //g.DrawString("자  원", Font10b, brushBlack, XGab + 0002.0F, YGab + 0051.0F, new StringFormat());



                // g.DrawString("장비번호", Font10b, brushBlack, XGab + 0043.0F, YGab + 0028.0F, new StringFormat());


                htTmp = (Hashtable)alBarcode[nCurrentIndex];

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
                    //g.DrawString(htTmp["ITEM_NM"].ToString().Substring(0, 9), Font10b, brushBlack, XGab + 0017.0F, YGab + 00028.0F, new StringFormat());  //품명
                }
                else
                {
                    g.DrawString(htTmp["ITEM_NM"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 00027.0F, new StringFormat());  //품명
                    //g.DrawString(htTmp["ITEM_NM"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 00028.0F, new StringFormat());  //품명
                }
                g.DrawString(htTmp["WORKDATE"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 0034.0F, new StringFormat());  //작업일
                g.DrawString(htTmp["VALIDDATE"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 0041.0F, new StringFormat());  //유효일
                //g.DrawString(htTmp["WORKDATE"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 0036.0F, new StringFormat());  //작업일
                //g.DrawString(htTmp["VALIDDATE"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 0044.0F, new StringFormat());  //유효일

                if (htTmp["FACILITY_NM"].ToString() != "")
                {
                    g.DrawString(htTmp["FACILITY_CD"] + "/" + htTmp["FACILITY_NM"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 0047.0F, new StringFormat());  //장비번호
                    //g.DrawString(htTmp["FACILITY_CD"] + "/" + htTmp["FACILITY_NM"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 0051.0F, new StringFormat());  //장비번호
                }

                g.DrawString(htTmp["WORKPLACE"].ToString(), Font10b, brushBlack, XGab + 0047.0F, YGab + 0034.0F, new StringFormat());  //작업장
                g.DrawString(htTmp["OPERATOR"].ToString(), Font10b, brushBlack, XGab + 0047.0F, YGab + 0041.0F, new StringFormat());   //작업자명
                //g.DrawString(htTmp["WORKPLACE"].ToString(), Font10b, brushBlack, XGab + 0047.0F, YGab + 0036.0F, new StringFormat());  //작업장
                //g.DrawString(htTmp["OPERATOR"].ToString(), Font10b, brushBlack, XGab + 0047.0F, YGab + 0044.0F, new StringFormat());   //작업자명
                

                if (htTmp["ISSUED_CD"].ToString() != "사내" && htTmp["ISSUED_CD"].ToString() != "샘플" && htTmp["ISSUED_CD"].ToString() != "")
                {
                    if (htTmp["ISSUED_CD"].ToString().Length > 7)
                    {
                        g.DrawString(htTmp["ISSUED_CD"].ToString().Substring(0, 7), Font10b, brushBlack, XGab + 0047.0F, YGab + 0027.0F, new StringFormat());  //출고처
                        //g.DrawString(htTmp["ISSUED_CD"].ToString().Substring(0, 7), Font10b, brushBlack, XGab + 0047.0F, YGab + 0028.0F, new StringFormat());  //출고처
                    }
                    else
                    {
                        g.DrawString(htTmp["ISSUED_CD"].ToString(), Font10b, brushBlack, XGab + 0047.0F, YGab + 0027.0F, new StringFormat());  //출고처
                        //g.DrawString(htTmp["ISSUED_CD"].ToString(), Font10b, brushBlack, XGab + 0047.0F, YGab + 0028.0F, new StringFormat());  //출고처
                    }
                    g.DrawLine(pen1, XGab + 0046.0F, YGab + 0025.0F, XGab + 0046.0F, YGab + 0032.0F);
                    //g.DrawLine(pen1, XGab + 0046.0F, YGab + 0026.0F, XGab + 0046.0F, YGab + 0034.0F);
                }
                else
                {
                    if (htTmp["ITEM_NM"].ToString().Length < 11)
                    {
                        g.DrawString(htTmp["LOT_NO"].ToString().Substring(8), Font14b, brushBlack, XGab + 0054.0F, YGab + 0027.0F, new StringFormat());   //롯트축약
                        //g.DrawString(htTmp["LOT_NO"].ToString().Substring(8), Font14b, brushBlack, XGab + 0054.0F, YGab + 0028.0F, new StringFormat());   //롯트축약
                    }
                }

                //g.DrawString(htTmp["PROCESS"].ToString(), Font10b, brushBlack, XGab + 0062.0F, YGab + 0051.0F, new StringFormat());  //완료공정

                if (sWC_MGR == "10")//2018-06-08    이동환 준비공정 바코드 일 경우 하단에 품목코드 바코드 출력
                {
                    //if (!bcd.Get_Code128(htTmp["ITEM_CD"].ToString(), ref szCode128))
                    //{
                    //    TGSControl.UsrFunction.MessageBoxErr("Code128 체크디지트 계산중 오류발생하였습니다.", "품번 바코드");
                    //    return;
                    //}
                    if (TGSClass.Code128.Get_Code128(htTmp["ITEM_CD"].ToString(), ref szCode128))
                    {
                        g.DrawString(szCode128, Code128, brushBlack, XGab + 008.0F, YGab + 051.5F, new StringFormat());        //품번 바코드
                    }
                }


                LabelPrint_Save(htTmp["LOT_NO"].ToString(),
                       htTmp["ITEM_CD"].ToString(),
                       Global.workinfo.szOperatorNM);


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


        
        private void btn_OK_ButtonClick(object sender, EventArgs e) //실적저장
        {
            if (DBSave())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void lbl_WORK_QTY_Click(object sender, EventArgs e)
        {
            sWorkQty_Seleted = "A";
            lbl_WORK_QTY.BorderBackColor = Color.Yellow;
            lbl_LOT_QTY.BorderBackColor = Color.White;
            lbl_BOX_CNT.BorderBackColor = Color.White;
            tEditNumeric1.Value = "0";
        }

        private void lbl_LOT_QTY_Click(object sender, EventArgs e)
        {
            sWorkQty_Seleted = "B";
            lbl_WORK_QTY.BorderBackColor = Color.White;
            lbl_LOT_QTY.BorderBackColor = Color.Yellow;
            lbl_BOX_CNT.BorderBackColor = Color.White;
            tEditNumeric1.Value = "0";
        }

        private void lbl_LOT_QTY_DoubleClick(object sender, EventArgs e)
        {
            btn_BoxDeepQtyEdit_ButtonClick(null, null);
        }

        private void lbl_WORK_QTY_LabelClick(object sender, EventArgs e)
        {
            sWorkQty_Seleted = "A";
            lbl_WORK_QTY.BorderBackColor = Color.Yellow;
            lbl_LOT_QTY.BorderBackColor = Color.White;
            lbl_BOX_CNT.BorderBackColor = Color.White;
            tEditNumeric1.Value = "0";
        }

        private void lbl_LOT_QTY_LabelClick(object sender, EventArgs e)
        {
            sWorkQty_Seleted = "B";
            lbl_WORK_QTY.BorderBackColor = Color.White;
            lbl_LOT_QTY.BorderBackColor = Color.Yellow;
            lbl_BOX_CNT.BorderBackColor = Color.White;
            tEditNumeric1.Value = "0";
        }

        private void lbl_BOX_CNT_LabelClick(object sender, EventArgs e)
        {
            sWorkQty_Seleted = "C";
            lbl_WORK_QTY.BorderBackColor = Color.White;
            lbl_LOT_QTY.BorderBackColor = Color.White;
            lbl_BOX_CNT.BorderBackColor = Color.Yellow;
            tEditNumeric1.Value = "0";
        }

        private void chk_LOT_CNT_CheckedChange(object sender, EventArgs e)
        {
            
            if (chk_LOT_CNT.Checked)
            {
                if (lbl_BOX_CNT.Value.ToString() == "0" || lbl_BOX_CNT.Value.ToString() == "") return;
                
                int vBOX_CNT = Convert.ToInt16(lbl_BOX_CNT.Value);
                lbl_BOX_CNT.Value = (vBOX_CNT - 1).ToString("N0");
            }
            else
            {
                Calc_BOXCnt();//용기 및 생산수량이 변경되면 박스 수를 재 계산 한다.
            }
        }






    }
}
