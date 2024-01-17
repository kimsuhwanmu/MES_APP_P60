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
    public partial class POP_P9002PA3 : Form
    {
        
        
        #region ▶ 1. Declaration part  //선언부

        #region ■ 1.1 Program information      //프로그램 정보 및 수정 이력 정보 
        /// <TemplateVersion>0.0.1.0</TemplateVersion>
        /// <NameSpace>①namespace</NameSpace>
        /// <Module>②module name</Module>
        /// <Class>③class name</Class>
        /// <Desc>④
        ///   품목별로 자품목 투입을 하는 프로그램 , 품목 선택 또는 바코드 LOT 스캔으로 처리 함
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
            
            public const string ERROR_CD = "ERROR_CD";
            public const string ERROR_SEQ = "ERROR_SEQ";
            public const string ERROR_NM = "ERROR_NM";
            public const string ERROR_RTN = "ERROR_RTN";

            public const string INPUTED_BAD_QTY = "INPUTED_BAD_QTY";
            public const string BAD_QTY = "BAD_QTY";
            
        }

        public struct barcode_COLUMN
        {

            //public const string LOC_NO = "LOC_NO";
            public const string LOT_NO = "LOT_NO";
            public const string ITEM_CD = "ITEM_CD";
            public const string ITEM_NM = "ITEM_NM";
            public const string BAD_QTY = "BAD_QTY";
            //public const string INV_UNIT = "INV_UNIT";
            public const string REAL_END_DT = "REAL_END_DT";
            public const string FACILITY_CD = "FACILITY_CD";
            public const string FACILITY_NM = "FACILITY_NM";
            public const string EMP_DESC = "EMP_DESC";
            public const string ERROR_NM = "ERROR_NM";

        }

        #endregion

        #region ■ 1.3. Class global variables (common) //글로벌 변수 선언

        private bool bSelectedPrinted = false;  //바코드 연속 발행여부
        ArrayList alBarcode = new ArrayList();  //바코드 출력용 배열


        Global global = new Global();
        Form sMainForm;

        string sPLANT_CD = "";      //공장
        string sWC_MGR = "";        //대공정
        string sWC_MGR_NM = "";     //대공정명
        string sWC_CD = "";         //작업장
        
        string sFACILITY_CD = "";   //설비번호
        string sFACILITY_NM = "";   //설비명

        string sRESULT_NO = "";     //실적
        //string sRESULT_SEQ = "";    //실적순번
        string sWK_ORD_NO = "";     //지시번호

        string sWORKER_CD = "";     //작업자
        //string sLOT_NO = "";        //lot

        decimal sWK_ORD_QTY = 0;
        decimal sPROD_QTY = 0;
        decimal sGOOD_QTY = 0;
        decimal sBAD_QTY = 0;

        bool sBAD_QTY_CHANGE = false;   //불량수량 수정여부 체크

        string sWORK_END_FLAG = "Y";    //실적 저장후 자동으로 실적 종료를 할 지 여부
                
        DataSet sResultData = new DataSet();
        
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

        public POP_P9002PA3()
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
                
                sPLANT_CD = sResultData.Tables["PassData"].Rows[0]["PLANT_CD"].ToString();
                
                sWC_MGR = sResultData.Tables["PassData"].Rows[0]["WC_MGR"].ToString();
                lbl_WC_MGR_NM.Value = sResultData.Tables["PassData"].Rows[0]["WC_MGR_NM"].ToString();

                sFACILITY_CD = sResultData.Tables["PassData"].Rows[0]["FACILITY_CD"].ToString();
                lbl_FACILITY_NM.Value = sResultData.Tables["PassData"].Rows[0]["FACILITY_NM"].ToString();

                sRESULT_NO = sResultData.Tables["PassData"].Rows[0]["RESULT_NO"].ToString();
                //sRESULT_SEQ = sResultData.Tables["PassData"].Rows[0]["RESULT_SEQ"].ToString();
                sWK_ORD_NO = sResultData.Tables["PassData"].Rows[0]["WK_ORD_NO"].ToString();
                
                sWORKER_CD = sResultData.Tables["PassData"].Rows[0]["WORKER_ID"].ToString();
                //sLOT_NO = sResultData.Tables["PassData"].Rows[0]["LOT_NO"].ToString();

                sWC_CD = sResultData.Tables["PassData"].Rows[0]["WC_CD"].ToString();


                lbl_ITEM_CD.Value = sResultData.Tables["PassData"].Rows[0]["ITEM_CD"].ToString();
                lbl_ITEM_NM.Value = sResultData.Tables["PassData"].Rows[0]["ITEM_NM"].ToString();
                lbl_RESULT_NO.Value = sRESULT_NO;

                sWK_ORD_QTY = Convert.ToDecimal(sResultData.Tables["PassData"].Rows[0]["WK_ORD_QTY"].ToString());
                sPROD_QTY = Convert.ToDecimal(sResultData.Tables["PassData"].Rows[0]["PROD_QTY"].ToString());
                sGOOD_QTY = Convert.ToDecimal(sResultData.Tables["PassData"].Rows[0]["GOOD_QTY"].ToString());
                sBAD_QTY = Convert.ToDecimal(sResultData.Tables["PassData"].Rows[0]["BAD_QTY"].ToString());


                sWORK_END_FLAG = sResultData.Tables["PassData"].Rows[0]["WORK_END_FLAG"].ToString();    //실적저장 후 최종완료처리 할지 여부


                if (sResultData.Tables["PassData"].Rows[0]["RESULT_USER_FLAG"].ToString().ToUpper() == "Y")
                {
                    sRESULT_USER_FLAG = true;
                }
                else
                {
                    sRESULT_USER_FLAG = false;
                }
                sRESULT_USER_DT = sResultData.Tables["PassData"].Rows[0]["RESULT_USER_DT"].ToString();


                lbl_WK_ORD_QTY.Value = sWK_ORD_QTY.ToString("N0");
                lbl_PROD_QTY.Value = sPROD_QTY.ToString("N0");
                lbl_GOOD_QTY.Value = sGOOD_QTY.ToString("N0");
                lbl_BAD_QTY.Value = sBAD_QTY.ToString("N0");

                lbl_BAD_REASON.Value = "";
                lbl_BAD_QTY_IN.Value = "0";


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

            //Fnc_crt_combo(this.cboSL_CD, "", "SL_CD", -1, "창고", "창고명", "창고선택");

        }

        #region ▶▶▶ 공용코드 콤보 셋팅
        //private void Fnc_crt_combo(TGSControl.TCombo combo, string @MAJOR_CD, string @FLAG, int idx)
        //{
        //    Fnc_crt_combo(combo, @MAJOR_CD, @FLAG, idx, "코드", "코드명", "코드선택");
        //}

        //private void Fnc_crt_combo(TGSControl.TCombo combo, string @MAJOR_CD, string @FLAG, int idx, string p_ValueCaption, string p_DisplayCaption, string p_Caption)
        //{
        //    combo.Clear();

        //    string pValueMember = "code";
        //    string pDisplayMember = "name";

        //    //DataSet iDataSet = new DataSet();
        //    DataTable dtData1 = null;
        //    dtData1 = new DataTable();

        //    string strSql = "";

        //    switch (@FLAG)
        //    {
        //        case "SL_CD":    // 창고
        //            strSql = "EXEC DBO.XUSP_MES_P5002P2_GET_SL ";
        //            strSql += "@PLANT_CD='" + Global.workinfo.szFactoryCD + "',";
        //            strSql += "@FACILITY_CD='" + Global.workinfo.szFacilityCD + "'";
                    

        //            pValueMember = "SL_CD";
        //            pDisplayMember = "SL_NM";

        //            break;
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
        //        string strState = nsFuncUtil.FuncUtil.GetDataSql(this.MainForm , strSql, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);

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
        //        combo.ValueMember = pValueMember;
        //        combo.DisplayMember = pDisplayMember;
        //        combo.DisplayCaption = p_DisplayCaption;
        //        combo.ValueCaption = p_ValueCaption;
        //        combo.Caption = p_Caption;

        //        //combo.DataBind();
        //        if (idx >= 0) combo.SelectedIndex = idx;
        //    }
        //}
        #endregion ▶▶▶ 공용코드 콤보 셋팅




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
            InitSpreadSheet(1);
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
                columnHeaderStyle.Font = new Font("맑은 고딕", 12, FontStyle.Bold);
                Grid1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                Grid1.RowHeadersVisible = false;
                
                Grid1.AllowUserToResizeColumns = false;
                Grid1.RowTemplate.Height = 45;
                //Grid1.Columns.Add(SetColumnImage(gridWRDW11_COLUMN.CHECKFLAG, "√", 40));    //이미지형태의 그리드





                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.ERROR_SEQ, "불량순번", 80));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.ERROR_CD, "불량코드", 80));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.ERROR_NM, "불량명", 180));

                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.ERROR_RTN, "조치방법", 110));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.INPUTED_BAD_QTY, "현 불량수량", 110));

                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.BAD_QTY, "불량수량", 110));
                
                

                #endregion


                #region ■■ 3.1.1.2 Formatting grid information

                //uniGrid2.flagInformation("cud_flag", "rownum");
                //uniGrid2.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.No);

                Grid1.Columns[grid1_COLUMN.INPUTED_BAD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid1.Columns[grid1_COLUMN.INPUTED_BAD_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태
                Grid1.Columns[grid1_COLUMN.BAD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid1.Columns[grid1_COLUMN.BAD_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                

                #endregion


                #region ■■ 3.1.1.3 Setting etc grid
                // Hidden Column Setting
                Grid1.Columns[grid1_COLUMN.INPUTED_BAD_QTY].Visible = false;


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

       


        #region ■ 4.4 Db function group

        #region ■■ 4.4.1 DBQuery(Common)

        private bool DBQuery()
        {
            DBQuery_BadInfom(sPLANT_CD, sWC_MGR );    //재고현황 조회 


            return true;
        }

        #region ▶▶▶ 불량내역 조회
        private void DBQuery_BadInfom(string pPLANT_CD, string pWC_MGR)//재고현황 조회
        {
            int nCnt = 0;

            try
            {
                //LoadingForm(true);


                Grid1.Rows.Clear();

                string strData = "";
                //strData = WorkCode.WorkCd.PO_BAD_REVIEW;
                //strData += pPLANT_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strData += pWC_MGR + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strData += "" + TGSClass.nsGlobal.Global.Separation.COLUMNS;  //신규 등록을 위해 실적번호 없이 조회 함 
                //strData += "0";

                strData = ""
                            + " SELECT T1.ERROR_CD, "          //   -- 불량 코드
                            + "	 T1.ERROR_NM,"            //  -- 코드 명칭 
                            + "  0 AS BAD_QTY,"              //-- 불량 수량
                            + "	 '' AS ERROR_RTN,"         //   -- 조치 방법
                            + "  T2.ERROR_SEQ, "        //에러순번
                            + "	 T2.BAD_QTY AS INPUTED_BAD_QTY"  //이미 입력된 불량정보
                            + " FROM MES_Q_ERROR AS T1 (NOLOCK)"
                            + " LEFT OUTER JOIN MES_Q_ARVL_ERROR AS T2 (NOLOCK) "
                            + "  ON T1.PLANT_CD   =  T2.PLANT_CD"
                            + "	 AND T1.ERROR_CD =  T2.ERROR_CD "
                            + "	 AND ARVL_NO =  '" + "" + "'"   //RESLT_NO
                            + "	 AND RESULT_SEQ = '" + "0" + "'" //RESULT_SEQ
                            + " WHERE T1.PLANT_CD   = '" + pPLANT_CD + "'"    // -- 공장
                            + "  AND T1.INSPECT_CD = 'P'"             //   -- 생산
                            + "  AND T1.PROCESS_CD = '" + pWC_MGR + "'"        // -- 공정
                            + " ORDER BY T1.PROCESS_CD, ERROR_SEQ ";        // -- 공정



                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);

                //string strState = nsFuncUtil.FuncUtil.GetDataSql(MainForm , strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (!@strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "불량정보 조회");
                    return;
                }

                if (dtData1 != null)
                {
                    //Grid1.DataSource = dtData1;


                    for (int i = 0; i < dtData1.Rows.Count; i++)
                    {
                        Grid1.Rows.Add();

                        Grid1.Rows[i].Cells[grid1_COLUMN.ERROR_SEQ].Value = dtData1.Rows[i][grid1_COLUMN.ERROR_SEQ].ToString();
                        Grid1.Rows[i].Cells[grid1_COLUMN.ERROR_CD].Value = dtData1.Rows[i][grid1_COLUMN.ERROR_CD].ToString();
                        Grid1.Rows[i].Cells[grid1_COLUMN.ERROR_NM].Value = dtData1.Rows[i][grid1_COLUMN.ERROR_NM].ToString();
                        Grid1.Rows[i].Cells[grid1_COLUMN.ERROR_RTN].Value = dtData1.Rows[i][grid1_COLUMN.ERROR_RTN].ToString();

                        Grid1.Rows[i].Cells[grid1_COLUMN.INPUTED_BAD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.INPUTED_BAD_QTY].ToString().PadLeft(1, '0')).ToString("N0");
                        Grid1.Rows[i].Cells[grid1_COLUMN.BAD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.INPUTED_BAD_QTY].ToString().PadLeft(1, '0')).ToString("N0");
                        


                    }
                }




            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "불량정보 조회");
            }
            finally
            {
                LoadingForm(false);
            }

        }
        

        #endregion ▶▶▶ 불량내역 정보 조회



        
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
            return DBSave_BadQty();
        }

        private bool DBSave_BadQty()
        {

            
           


            try
            {


                decimal vPROD_QTY = Convert.ToDecimal(lbl_WK_ORD_QTY.Value);
                decimal vBAD_QTY_SUM = Convert.ToDecimal(lbl_BAD_QTY.Value);

                if (vBAD_QTY_SUM > vPROD_QTY)
                {
                    TGSControl.UsrFunction.MessageBoxErr("불량수량은 생산수량을 초과 할수없습니다.", "불량정보저장");
                    return false;
                }

                if (Grid1.Rows.Count == 0)
                {
                    TGSControl.UsrFunction.MessageBoxErr("저장할 정보가 없습니다.", "불량정보저장");
                    return false;
                }

                if (TGSControl.UsrFunction.MessageBoxYesNo("불량정보를 저장하시겠습니까?", "불량정보저장") == DialogResult.No)
                {
                    return false;
                }

                
                string strData = "";

                bool vSAVE_OK = false;
                bool vSAVE_ERROR = false;
                string vERROR_CD = "";
                decimal vBAD_QTY = 0;           //신규 등록된 수량
                decimal vINPUTED_BAD_QTY = 0;   //기존 저장된 불량수량


                LoadingForm(true);

                for (int i = 0; i < Grid1.Rows.Count; i++)
                {

                    vBAD_QTY = Convert.ToDecimal(Grid1.Rows[i].Cells[grid1_COLUMN.BAD_QTY].Value.ToString());
                    vINPUTED_BAD_QTY = Convert.ToDecimal(Grid1.Rows[i].Cells[grid1_COLUMN.INPUTED_BAD_QTY].Value.ToString());
                        

                    if (vINPUTED_BAD_QTY != vBAD_QTY)   //수량이 변경되었으면
                    {
                        vERROR_CD = Grid1.Rows[i].Cells[grid1_COLUMN.ERROR_CD].Value.ToString();

                       // if (vINPUTED_BAD_QTY > 0)
                       //     strData = WorkCode.WorkCd.PO_BAD_UPDATE;
                       // else
                       //     strData = WorkCode.WorkCd.PO_BAD_INSERT;

                       // strData += sPLANT_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                       // strData += sWK_ORD_NO + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                       // strData += sRESULT_NO + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                       // //strData += sRESULT_SEQ + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                       // strData += Grid1.Rows[i].Cells[grid1_COLUMN.ERROR_CD].Value.ToString() + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                       // strData += Grid1.Rows[i].Cells[grid1_COLUMN.ERROR_RTN].Value.ToString() + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                       // strData += Grid1.Rows[i].Cells[grid1_COLUMN.ERROR_SEQ].Value.ToString() + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                       // strData += Grid1.Rows[i].Cells[grid1_COLUMN.BAD_QTY].Value.ToString() + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                       // strData += sWORKER_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                       //// strData += sLOT_NO;



                        if (DBSave_Work_SaveLotResult(vBAD_QTY.ToString("N0"), vERROR_CD))
                        {
                            vSAVE_OK = true;
                        }
                        else
                        {
                            vSAVE_ERROR = true;
                        }

                        //string strState = nsFuncUtil.FuncUtil.ExcuteSql(MainForm, strData, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                        //if (!strState.Equals("OK"))
                        //{

                        //    //TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "불량정보 저장 에러");
                        //    TGSControl.UsrFunction.MessageBoxInfo(strState.Substring(2), "불량정보 저장", 0);
                        //    LoadingForm(false);
                        //    return false;
                        //}

                    }

                    

                }

                //저장시 에러가 발생하지 않았으면
                if (vSAVE_ERROR == false)
                {
                    //자동실적마감여부에 따라 실적을 종료한다.
                    if (sWORK_END_FLAG == "Y")
                    {
                        DBSave_PO_FM_SET_WORK_END(sRESULT_NO);  //실적완료처리
                    }
                }


                
                //저장된 건이 있으면
                if (vSAVE_OK)
                {
                    //바코드 라밸 출력
                    if (Global.workinfo.szPrinterName.Trim().Length > 0)
                    {
                        LabelPrint_Work_Lot_RetriveData(sPLANT_CD, sRESULT_NO);

                        //불량 바코드 출력
                        bSelectedPrinted = true;


                        if (Global.workinfo.szPrinterName == "")
                            printPreviewDialog1.ShowDialog();
                        else
                        {
                            printDialog1.PrinterSettings.PrinterName = Global.workinfo.szPrinterName; //"WF-2540 Series(네트워크)";
                            printDocument1.Print();
                        }

                    }
                }



                TGSControl.UsrFunction.MessageBoxInfo("처리완료 되었습니다.", "불량정보 저장");
                


            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "불량정보 저장");
                return false;
            }
            finally
            {
                LoadingForm(false);
            }

            return true;
        }

        //#region ▶▶▶ 생산실적 시작
        //private void Work_Start()
        //{
        //    //int nCnt = 0;

        //    try
        //    {

                
        //        if (sWK_ORD_NO == "")
        //        {
        //            TGSControl.UsrFunction.MessageBoxErr("작업할 지시서를 선택하세요.", "작업시작");
        //            return;
        //        }

        //        if (sWORKER_CD == "")
        //        {
        //            TGSControl.UsrFunction.MessageBoxErr("작업자를 선택하세요.", "작업시작");
        //            return;
        //        }

        //        if (sFACILITY_CD == "")
        //        {
        //            TGSControl.UsrFunction.MessageBoxErr("설비를 선택하세요.", "작업시작");
        //            return;
        //        }

              
                
        //        string szSendData = WorkCode.WorkCd.WORK_START;
        //        szSendData += sPLANT_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
        //        szSendData += sWC_MGR + TGSClass.nsGlobal.Global.Separation.COLUMNS;
        //        szSendData += sWC_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
        //        szSendData += sFACILITY_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
        //        szSendData += sWORKER_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
        //        szSendData += sWK_ORD_NO + TGSClass.nsGlobal.Global.Separation.COLUMNS;
        //        szSendData += "0";

        //        string strState = nsFuncUtil.FuncUtil.ExcuteSql(sMainForm, szSendData, Global.workinfo.szServerIP, Global.workinfo.szPortNo);

        //        //if (!strState.Equals("OK"))
        //        if (strState.Substring(0, 2) != "OK")
        //        {
        //            TGSControl.UsrFunction.MessageBoxErr(sWK_ORD_NO + " " + strState.Substring(2), "작업시작");
        //        }

        //        DBQuery_Work_Order_RetriveData();
                
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
        //#endregion ▶▶▶ 생산실적 시작

        #region ▶▶▶ 생산실적 처리
        private bool DBSave_Work_SaveLotResult(string p_BAD_QTY, string p_ERROR_CD) //생산실적 처리 함
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
                //szSendData += sWC_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += sFACILITY_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += p_BAD_QTY.Replace(",", "") + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += p_BAD_QTY.Replace(",", "") + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += "*" + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += sWORKER_CD.ToString() + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += sRESULT_NO + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += "1" + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += p_BAD_QTY.Replace(",", "") + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //szSendData += "N" + TGSClass.nsGlobal.Global.Separation.COLUMNS;  //포장여부
                //szSendData += "N" + TGSClass.nsGlobal.Global.Separation.COLUMNS;  //실적마감여부 --불량등록 이후 계속 실적을 등록해야 함
                //szSendData += p_ERROR_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;   //에러코드
                //szSendData += "" + TGSClass.nsGlobal.Global.Separation.COLUMNS;   //대차코드
                //szSendData += "0" + TGSClass.nsGlobal.Global.Separation.COLUMNS;  //대차중량
                //szSendData += "0";   //최대 박스수량


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

                strData += p_BAD_QTY.Replace(",", "") + Global.COLUMNS_DIV;    //생산량
                strData += p_BAD_QTY.Replace(",", "") + Global.COLUMNS_DIV;     //롯트량
                strData += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + Global.COLUMNS_DIV; //시작일자
                
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
                strData += p_BAD_QTY.Replace(",", "") + Global.COLUMNS_DIV;
                strData += sWORKER_CD.ToString() + Global.COLUMNS_DIV;   //WORKER
                strData += sRESULT_NO + Global.COLUMNS_DIV;
                strData += "" + Global.COLUMNS_DIV;

                strData += "N" + Global.COLUMNS_DIV;  //포장여부
                strData += "N" + Global.COLUMNS_DIV;  //실적마감여부 '실적을 등록하면 실적마감됨
                strData += p_ERROR_CD + Global.COLUMNS_DIV;   //에러코드
                strData += "" + Global.COLUMNS_DIV;   //대차코드
                strData += "0" + Global.COLUMNS_DIV;  //대차중량

                strData += "0" + Global.COLUMNS_DIV;   //최대 박스수량
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
                    return false;
                }


                



                //TGSControl.UsrFunction.MessageBoxInfo("완료처리 되었습니다.", "작업완료");
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

        #region 최종완료실적을 등록했을 때         --2016-03-01 이동환
        //2. 하나의 작업지시를 최종 완료 등록했을 때
        private bool DBSave_PO_FM_SET_WORK_END(string @RESULT_NO)
        {
            try
            {
                DataTable vDT = new DataTable();
                int nCnt = 0;
                LoadingForm(true);

                string szSendData = WorkCode.WorkCd.PO_FM_WORK_END_SET;

                szSendData += sPLANT_CD+ TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += @RESULT_NO + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                szSendData += sWORKER_CD; // +TGSClass.nsGlobal.Global.Separation.COLUMNS;


                string strState = TGSClass.DataBase.GetDataSql(MainForm, szSendData, ref vDT, ref nCnt);
                if (!strState.Equals("OK"))
                {
                    //TGSControl.UsrFunction.MessageBoxErr("작업완료중 오류가 발생하였습니다.", "작업완료");

                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "완료오류");
                    //작업진행현황을 다시 조회함
                                        
                    return false;
                }


                
            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxInfo(se.Message, "오류발생");
                return false;
            }
            finally
            {
                LoadingForm(false);
            }

            return true;
        }

        #endregion 최종완료실적을 등록했을 때         --2016-03-01 이동환


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












        private void Form_Resize(object sender, EventArgs e)
        {
            Panel_Doc_s1.Width = windowsForm1.Width - Panel_Doc_s1.Left - Panel_Doc_s1.Left;
            Panel_Doc_s1.Height = windowsForm1.Height - Panel_Doc_s1.Top - Panel_Doc_s1.Left;


        }

        private void windowsForm1_CloseClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_Before_ButtonClick(object sender, EventArgs e)//이전버튼
        {
            
                int vDisplayedRowCount = Grid1.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid1.FirstDisplayedScrollingRowIndex - vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex < 0)
                        Grid1.FirstDisplayedScrollingRowIndex = 0;
                    else
                        Grid1.FirstDisplayedScrollingRowIndex = Grid1.FirstDisplayedScrollingRowIndex - vDisplayedRowCount;
                }
            

        }

        private void btn_Next_ButtonClick(object sender, EventArgs e)//다음버튼
        {
            
                int vDisplayedRowCount = Grid1.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid1.FirstDisplayedScrollingRowIndex + vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex >= Grid1.Rows.Count)
                        Grid1.FirstDisplayedScrollingRowIndex = Grid1.Rows.Count - 1;
                    else
                        Grid1.FirstDisplayedScrollingRowIndex = vFirstDisplayedScrollingRowIndex;
                }
            
        }

        private void but_OK_Click(object sender, EventArgs e)//불량정보 저장
        {

            if (sBAD_QTY_CHANGE)   //총불량 수량이 다르면
            {
                if (DBSave())
                {
                    this.DialogResult = DialogResult.OK;
                }

            }
            else
            {
                TGSControl.UsrFunction.MessageBoxErr( "저장할 불량정보가 없습니다. " , "불량정보 저장");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)//취소버튼
        {
            this.DialogResult = DialogResult.Cancel;
        }

        
        


        private void Grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = Grid1.CurrentCell.ColumnIndex;

            lbl_BAD_REASON.Value = Grid1.CurrentRow.Cells[grid1_COLUMN.ERROR_NM].Value.ToString();
            lbl_BAD_QTY_IN.Value = Grid1.CurrentRow.Cells[grid1_COLUMN.BAD_QTY].Value.ToString();

            tEditNumeric1.Value = lbl_BAD_QTY_IN.Value;

            tEditNumeric1.CursorLocation = 0;
            tEditNumeric1.CursorSelectionLength = lbl_BAD_QTY_IN.Value.Length;

        }
        
        

        private void tEditNumeric1_EditValue(object sender, EventArgs e)
        {
            lbl_BAD_QTY_IN.Value = tEditNumeric1.Value; //수량이 변경될 경우
            Grid1.CurrentRow.Cells[grid1_COLUMN.BAD_QTY].Value = tEditNumeric1.Value;

            Show_WORK_QTY();
        }

        //생산량, 양품, 불량 수량을 갱신한다.
        private void Show_WORK_QTY()
        {
            decimal vBad_Qty = 0;
            decimal vBad_Qty_ORG = 0;
            decimal vBad_Qty_SUM = 0;
            decimal vGOOD_QTY = 0;
            decimal vPROD_QTY = 0;

            
            for (int i = 0; i < Grid1.Rows.Count; i++)
            {
                
                vBad_Qty = Convert.ToDecimal(Grid1.Rows[i].Cells[grid1_COLUMN.BAD_QTY].Value);
                vBad_Qty_ORG = Convert.ToDecimal(Grid1.Rows[i].Cells[grid1_COLUMN.INPUTED_BAD_QTY].Value);

                if (vBad_Qty != vBad_Qty_ORG) sBAD_QTY_CHANGE = true;

                vBad_Qty_SUM = vBad_Qty_SUM + vBad_Qty;
            }

            vGOOD_QTY = Convert.ToDecimal(lbl_GOOD_QTY.Value);
            vPROD_QTY = vGOOD_QTY + vBad_Qty_SUM;

            lbl_PROD_QTY.Value = vPROD_QTY.ToString("N0");
            lbl_BAD_QTY.Value = vBad_Qty_SUM.ToString("N0");
        }


        private void Grid1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Grid_RowMove((DataGridView)sender, e); //그리드 이동
        }

        //그리드 이동처리
        private void Grid_RowMove(DataGridView Grid, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
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




        















        private void LabelPrint_Work_Lot_RetriveData(string pPLANT_CD, string pRESULT_NO)
        {
            int nCnt = 0;


            try
            {
                LoadingForm(true);


                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MES_P0013P1_GET_LOT_RESULT ";
                strData += "@PLANT_CD='" + pPLANT_CD + "',";
                strData += "@RESULT_NO='" + pRESULT_NO + "'";

                //string strData = "";
                //strData = WorkCode.WorkCd.LABEL_LOT_REVIEW;
                //strData += pPLANT_CD + TGSClass.nsGlobal.Global.Separation.COLUMNS;
                //strData += pRESULT_NO;

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

                    DateTime dtTmp = DateTime.Parse(dtData1.Rows[i][barcode_COLUMN.REAL_END_DT].ToString());
                    Hashtable htTmp = new Hashtable();

                    htTmp.Add("LOT_NO", dtData1.Rows[i][barcode_COLUMN.LOT_NO].ToString());
                    htTmp.Add("ITEM_CD", dtData1.Rows[i][barcode_COLUMN.ITEM_CD].ToString());
                    htTmp.Add("ITEM_NM", dtData1.Rows[i][barcode_COLUMN.ITEM_NM].ToString());
                    htTmp.Add("QTY", dtData1.Rows[i][barcode_COLUMN.BAD_QTY].ToString());
                    htTmp.Add("FACILITY_CD", dtData1.Rows[i][barcode_COLUMN.FACILITY_CD].ToString());
                    htTmp.Add("FACILITY_NM", dtData1.Rows[i][barcode_COLUMN.FACILITY_NM].ToString());
                    htTmp.Add("WORKPLACE", Global.workinfo.szWorkSpaceNM);
                    htTmp.Add("WORKDATE", dtTmp.ToString("yy-MM-dd HH:mm"));

                    htTmp.Add("ERROR_NM", dtData1.Rows[i][barcode_COLUMN.ERROR_NM].ToString());
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
                DataTable vDT = new DataTable();
                int nCnt = 0;
                LoadingForm(true);

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
        private void BarcodeBad_Print(System.Drawing.Printing.PrintPageEventArgs e)
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



                Brush brushBlack = new SolidBrush(Color.Black);
                Pen pen1 = new Pen(brushBlack, 0.3F);

                Brush brushBlack1 = new SolidBrush(Color.Black);
                Pen pen3 = new Pen(brushBlack1, 0.6F);

                //Font BcdFont = new Font("BC C39 2 to 1 Medium", 17);
                Font Code128 = new Font("Code 128", 30);


                Hashtable htTmp = new Hashtable();

                //Box Line
                //g.DrawRectangle(pen3, XGab + 0001.0F, YGab + 0001.0F, XGab + 0076.0F, YGab + 0014.0F);
                //g.DrawRectangle(pen3, XGab + 0001.0F, YGab + 00015.0F, XGab + 0076.0F, YGab + 0010.0F);
                //g.DrawRectangle(pen3, XGab + 0001.0F, YGab + 00026.0F, XGab + 0076.0F, YGab + 0030.0F);

                g.DrawRectangle(pen3, XGab + 0001.0F, YGab + 0001.0F, 0076.0F, 0014.0F);
                g.DrawRectangle(pen3, XGab + 0001.0F, YGab + 00015.0F, 0076.0F, 0010.0F);
                g.DrawRectangle(pen3, XGab + 0001.0F, YGab + 00026.0F, 0076.0F, 0030.0F);

                // 가로 라인
                g.DrawLine(pen1, XGab + 0001.0F, YGab + 0034.0F, XGab + 0077.0F, YGab + 0034.0F);
                g.DrawLine(pen1, XGab + 0001.0F, YGab + 0042.0F, XGab + 0077.0F, YGab + 0042.0F);
                g.DrawLine(pen1, XGab + 0001.0F, YGab + 0050.0F, XGab + 0077.0F, YGab + 0050.0F);


                // 세로 라인
                g.DrawLine(pen1, XGab + 0016.0F, YGab + 0015.0F, XGab + 0016.0F, YGab + 0025.0F);
                g.DrawLine(pen1, XGab + 0052.0F, YGab + 0015.0F, XGab + 0052.0F, YGab + 0025.0F);


                g.DrawLine(pen1, XGab + 0016.0F, YGab + 0026.0F, XGab + 0016.0F, YGab + 0056.0F);

                g.DrawLine(pen1, XGab + 0046.0F, YGab + 0034.0F, XGab + 0046.0F, YGab + 0050.0F);
                //g.DrawLine(pen1, XGab + 0061.0F, YGab + 0042.0F, XGab + 0061.0F, YGab + 0058.0F);

                //g.DrawLine(pen1, XGab + 0050.0F, YGab + 0050.0F, XGab + 0050.0F, YGab + 0056.0F);
                //g.DrawLine(pen1, XGab + 0061.0F, YGab + 0050.0F, XGab + 0061.0F, YGab + 0056.0F);

                //Header
                g.DrawString("품  번", Font10b, brushBlack, XGab + 0002.0F, YGab + 0018.0F, new StringFormat());

                g.DrawString("품  명", Font10b, brushBlack, XGab + 0002.0F, YGab + 0028.0F, new StringFormat());
                g.DrawString("생산일", Font10b, brushBlack, XGab + 0002.0F, YGab + 0036.0F, new StringFormat());
                g.DrawString("★불량", Font10b, brushBlack, XGab + 0002.0F, YGab + 0044.0F, new StringFormat());
                g.DrawString("자  원", Font10b, brushBlack, XGab + 0002.0F, YGab + 0051.0F, new StringFormat());



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

                g.DrawString(htTmp["ITEM_CD"].ToString(), Font12b, brushBlack, XGab + 0017.0F, YGab + 00018.0F, new StringFormat());  //품번


                g.DrawString((double.Parse(htTmp["QTY"].ToString())).ToString("###,##0").PadLeft(8, ' ') + "  EA", Font12b, brushBlack, XGab + 0052.0F, YGab + 0018.0F, new StringFormat());  //작업수량

                g.DrawString(htTmp["ITEM_NM"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 00028.0F, new StringFormat());  //품명
                g.DrawString(htTmp["WORKDATE"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 0036.0F, new StringFormat());  //작업일
                //g.DrawString(htTmp["VALIDDATE"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 0044.0F, new StringFormat());  //유효일
                g.DrawString(htTmp["ERROR_NM"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 0044.0F, new StringFormat());  //불량사유

                g.DrawString(htTmp["FACILITY_CD"] + "/" + htTmp["FACILITY_NM"].ToString(), Font10b, brushBlack, XGab + 0017.0F, YGab + 0051.0F, new StringFormat());  //장비번호


                g.DrawString(htTmp["OPERATOR"].ToString(), Font10b, brushBlack, XGab + 0047.0F, YGab + 0044.0F, new StringFormat());   //작업자명
                g.DrawString(htTmp["WORKPLACE"].ToString(), Font10b, brushBlack, XGab + 0047.0F, YGab + 0036.0F, new StringFormat());  //작업장
                //g.DrawString(htTmp["PROCESS"].ToString(), Font10b, brushBlack, XGab + 0062.0F, YGab + 0051.0F, new StringFormat());  //완료공정


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
            BarcodeBad_Print(e);
        }

    }
}
