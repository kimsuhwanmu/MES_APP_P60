using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using TGSClass;
using TGSClass.nsGlobal;
using TGSClass.nsWorkCode;

namespace MES_APP_P90
{
    public partial class POP_P9002PA1 : Form
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
            public const string SEL_FLAG = "SEL_FLAG";
            public const string CHECKFLAG = "CHECKFLAG";
            //public const string SEQ = "SEQ";
            public const string LOC_NO = "LOC_NO";
            public const string LOC_NM = "LOC_NM";
            public const string LOT_NO = "LOT_NO";
            //public const string ITEM_CD = "ITEM_CD";
            public const string INV_QTY = "INV_QTY";
            public const string INV_UNT = "INV_UNT";
            public const string RESV_QTY = "RESV_QTY";
            public const string USE_QTY = "USE_QTY";
            public const string USE_QTY_ORG = "USE_QTY_ORG";

        }

        public struct grid2_COLUMN  //LOT 투입내역 
        {
            public const string CUD_CHAR = "CUD_CHAR";
            //public const string ITEM_CD = "ITEM_CD";
            //public const string ITEM_NM = "ITEM_NM";
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
            public const string PUBLIC_FLAG = "PUBLIC_FLAG";

        }


        #endregion

        #region ■ 1.3. Class global variables (common) //글로벌 변수 선언

        Global global = new Global();
        Form sMainForm;

        String sPLANT_CD = "";      //공장
        String sWC_MGR = "";        //대공정
        String sWC_CD = "";         //작업장
        String sFACILITY_CD = "";   //설비번호

        string sWK_ORD_NO = "";     //작업지시번호
        string sRESULT_NO = "";     //생산실적번호
        
        string sWORKER_CD = "";     //작업자

        
        DataSet sResultData = new DataSet();

        int sGrid_Current_id = 1;   //그리드 선택

        bool sLOT_SCAN_Flag = false;    //2017-06-29 이동환    생산자재 투입 시 롯트리스트에서 선택 투입 가능 작업장


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
        //[Category("시작변수"), Description("공장코드 값을 입력 및 조회합니다.")]
        //public String PLANT_CD
        //{
        //    get
        //    {
        //        return sPLANT_CD;
        //    }
        //    set
        //    {
        //        sPLANT_CD = value.ToString();
        //    }
        //}

        //[Category("시작변수"), Description("작업장코드 값을 입력 및 조회합니다.")]
        //public String WC_CD
        //{
        //    get
        //    {
        //        return sWC_CD;
        //    }
        //    set
        //    {
        //        sWC_CD = value.ToString();
        //    }
        //}

        //[Category("시작변수"), Description("작업장그룹코드 값을 입력 및 조회합니다.")]
        //public String WC_MGR
        //{
        //    get
        //    {
        //        return sWC_MGR;
        //    }
        //    set
        //    {
        //        sWC_MGR = value.ToString();
        //    }
        //}
        //public String FACILITY_CD
        //{
        //    get
        //    {
        //        return sFACILITY_CD;
        //    }
        //    set
        //    {
        //        sFACILITY_CD = value.ToString();
        //    }
        //}
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

        public POP_P9002PA1()
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


            tCheckBox1_CheckedChange(null, null); //그리드 보여주는 뷰의 사이즈를 초기화

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
                opn_ITEM_CD.Value = sResultData.Tables["PassData"].Rows[0]["ITEM_CD"].ToString();
                opn_ITEM_CD.ValueName = sResultData.Tables["PassData"].Rows[0]["ITEM_NM"].ToString();
                sPLANT_CD = sResultData.Tables["PassData"].Rows[0]["PLANT_CD"].ToString();
                sFACILITY_CD = sResultData.Tables["PassData"].Rows[0]["FACILITY_CD"].ToString();
                sWC_MGR = sResultData.Tables["PassData"].Rows[0]["WC_MGR"].ToString();
                sWC_CD = sResultData.Tables["PassData"].Rows[0]["WC_CD"].ToString();

                sWORKER_CD = sResultData.Tables["PassData"].Rows[0]["WORKER_CD"].ToString();
                lbl_RESV_QTY.Value = sResultData.Tables["PassData"].Rows[0]["RESV_QTY"].ToString();

            }


        }

        #endregion

        #region ■ 2.5 Gathering combo data(GatheringComboData) //콤보관련 데이타 설정

        protected void GatheringComboData()
        {
// Example: Set ComboBox List (Column Name, Select, From, Where)
            //uniBase.UData.ComboMajorAdd("TaxPolicy", "B0004");
            //uniBase.UData.ComboCustomAdd("MSG_TYPE", "MINOR_CD , MINOR_NM ", "B_MINOR", "MAJOR_CD='A1001'");
            //uniBase.UData.ComboCustomAdd(cboSalesGrp.Name, "SALES_GRP , SALES_GRP_NM ", "B_SALES_GRP", "SALES_GRP < 'A'"); //영업그룹
            //uniBase.UData.ComboCustomAdd(cboSalesGrp.Name, "SALES_GRP , SALES_GRP_NM ", "B_SALES_GRP", "1=1 "); //영업그룹


            /* 판매계획유형*/
            //Fnc_crt_combo(this.cboSP_TYPE, "S0018", "S0018", 0);
            /* 거래구분*/
            //Fnc_crt_combo(this.cboLOC_EXP_FLAG, "S4225", "", 1);

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
            InitSpreadSheet(2);
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
                columnHeaderStyle.Font = new Font("맑은 고딕", 12);
                Grid1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                Grid1.RowHeadersVisible = false;
                Grid1.RowTemplate.Height = 35;  //기본 행높이를 설정

                //Grid1.Columns.Add(SetColumnImage(gridWRDW11_COLUMN.CHECKFLAG, "√", 40));    //이미지형태의 그리드


                Grid1.Columns.Add(SetColumnImage(grid1_COLUMN.CHECKFLAG, "√", 40));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.LOC_NO, "적치장", 0));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.LOC_NM, "적치장", 100));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.LOT_NO, "LOT_NO", 240));
                
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.INV_QTY, "재고량", 120));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.INV_UNT, "단위", 50));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.RESV_QTY, "소요량", 120));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.USE_QTY, "투입량", 120));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.USE_QTY_ORG, "투입량", 0));

                #endregion


                #region ■■ 3.1.1.2 Formatting grid information

                //uniGrid2.flagInformation("cud_flag", "rownum");
                //uniGrid2.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.No);

                Grid1.Columns[grid1_COLUMN.INV_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid1.Columns[grid1_COLUMN.INV_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태
                Grid1.Columns[grid1_COLUMN.RESV_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid1.Columns[grid1_COLUMN.RESV_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                Grid1.Columns[grid1_COLUMN.USE_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid1.Columns[grid1_COLUMN.USE_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                Grid1.Columns[grid1_COLUMN.USE_QTY_ORG].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid1.Columns[grid1_COLUMN.USE_QTY_ORG].DefaultCellStyle.Format = "N0";   //숫자표시형태

                #endregion


                #region ■■ 3.1.1.3 Setting etc grid
                // Hidden Column Setting
                Grid1.Columns[grid1_COLUMN.LOC_NO].Visible = false;
                Grid1.Columns[grid1_COLUMN.USE_QTY_ORG].Visible = false;
                Grid1.Columns[grid1_COLUMN.RESV_QTY].Visible = false;


                #endregion

            }
            #endregion

            #region ▶▶▶ 3.1.2 GRID2 설정
            if (p_GridIndex == 2)
            {
                
                #region ■■ 3.1.2.1 Pre-setting grid information



                /*** grid1
                 *  실적조회
                 * **/
                Grid2.Columns.Clear();

                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("맑은 고딕", 12);
                Grid2.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                Grid2.RowHeadersVisible = false;
                Grid1.RowTemplate.Height = 35;  //기본 행높이를 설정

                //Grid3.Columns.Add(SetColumnEdit(grid3_COLUMN.ITEM_CD, "품번", 130));
                //Grid3.Columns.Add(SetColumnEdit(grid3_COLUMN.ITEM_NM, "품명", 200));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.LOC_NO, "적치장", 0));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.LOC_NM, "적치장", 100));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.LOT_NO, "LOT NO", 240));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.INV_QTY, "재고량", 120));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.OUT_QTY, "예약량(SCAN)", 120));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.REAL_USED_QTY, "사용량", 120));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.INV_UNT, "단위", 50));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.STATE_NM, "상태", 80));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.PUBLIC_NM, "구분", 80));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.CUD_CHAR, "CUD", 0));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.PUBLIC_FLAG, "구분", 0));

                #endregion


                #region ■■ 3.1.2.2 Formatting grid information

                //uniGrid2.flagInformation("cud_flag", "rownum");
                //uniGrid2.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.No);

                Grid2.Columns[grid2_COLUMN.INV_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid2.Columns[grid2_COLUMN.INV_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                Grid2.Columns[grid2_COLUMN.OUT_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid2.Columns[grid2_COLUMN.OUT_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태
                


                #endregion


                #region ■■ 3.1.2.3 Setting etc grid
                // Hidden Column Setting
                Grid2.Columns[grid2_COLUMN.LOC_NO].Visible = false;
                Grid2.Columns[grid2_COLUMN.CUD_CHAR].Visible = false;
                Grid2.Columns[grid2_COLUMN.PUBLIC_FLAG].Visible = false;
                


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


            sLOT_SCAN_Flag = DBQuery_WorkLotScanOption(sPLANT_CD, sWC_CD); ;    //2017-06-29 이동환    생산자재 투입 시 롯트리스트에서 선택 투입 가능 작업장
            

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
            DBQuery_WORK_STOCK(sWK_ORD_NO, sFACILITY_CD, opn_ITEM_CD.Value);    //재고현황 조회 

            DBQuery_WorkLotResule(sWK_ORD_NO, sFACILITY_CD, opn_ITEM_CD.Value);    //자재LOT스캔 조회 
            
            SetScanQty();

            opn_LOT_SCAN.Focus();

            return true;
        }

        #region ▶▶▶ 자재LOT 조회
        private void DBQuery_WORK_STOCK(string p_WK_ORD_NO, string p_FACILITY_CD, string p_CHILD_ITEM_CD)//재고현황 조회
        {
            int nCnt = 0;

            try
            {
                //LoadingForm(true);


                Grid1.Rows.Clear();

                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MES_P5001P2_GET ";
                strData += "@WK_ORD_NO='" + p_WK_ORD_NO + "',";
                strData += "@FACILITY_CD='" + p_FACILITY_CD + "',";
                strData += "@CHILD_ITEM_CD='" + p_CHILD_ITEM_CD + "'";

                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);

                //string strState = TGSClass.DataBase.GetDataSql(MainForm , strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (!@strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "재고현황 조회");
                    return;
                }

                if (dtData1 != null)
                {
                    //Grid1.DataSource = dtData1;


                    for (int i = 0; i < dtData1.Rows.Count; i++)
                    {

                        Grid1.Rows.Add();

                        System.Drawing.Image imgChecked;

                        if (dtData1.Rows[i][grid1_COLUMN.LOC_NO].ToString() == "")
                        {
                            imgChecked = Properties.Resources.CheckBoxClear;
                            imgChecked.Tag = "";
                        }
                        else
                        {
                            if (dtData1.Rows[i][grid1_COLUMN.SEL_FLAG].ToString() == "Y")
                            {
                                imgChecked = Properties.Resources.CheckBoxChecked;
                                imgChecked.Tag = "Y";
                            }
                            else
                            {
                                imgChecked = Properties.Resources.CheckBoxUnChecked;
                                imgChecked.Tag = "N";
                            }
                        }
                        Grid1.Rows[i].Cells[grid1_COLUMN.CHECKFLAG].Value = imgChecked; //1.체크 


                        Grid1.Rows[i].Cells[grid1_COLUMN.LOC_NO].Value = dtData1.Rows[i][grid1_COLUMN.LOC_NO].ToString(); //적치장 
                        Grid1.Rows[i].Cells[grid1_COLUMN.LOC_NM].Value = dtData1.Rows[i][grid1_COLUMN.LOC_NM].ToString(); //적치장 
                        Grid1.Rows[i].Cells[grid1_COLUMN.LOT_NO].Value = dtData1.Rows[i][grid1_COLUMN.LOT_NO].ToString(); //LOT NO 
                        Grid1.Rows[i].Cells[grid1_COLUMN.INV_UNT].Value = dtData1.Rows[i][grid1_COLUMN.INV_UNT].ToString(); //단위

                        if (dtData1.Rows[i][grid1_COLUMN.INV_UNT].ToString().ToUpper() == "KG" || dtData1.Rows[i][grid1_COLUMN.INV_UNT].ToString() == "G")
                        {
                            Grid1.Rows[i].Cells[grid1_COLUMN.INV_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.INV_QTY].ToString()).ToString("N2"); //총재고량
                            Grid1.Rows[i].Cells[grid1_COLUMN.RESV_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.RESV_QTY].ToString()).ToString("N2"); //예약량(SCAN)
                            Grid1.Rows[i].Cells[grid1_COLUMN.USE_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.USE_QTY].ToString()).ToString("N2"); //실소모량
                        }
                        else
                        {
                            Grid1.Rows[i].Cells[grid1_COLUMN.INV_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.INV_QTY].ToString()).ToString("N0"); //총재고량
                            Grid1.Rows[i].Cells[grid1_COLUMN.RESV_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.RESV_QTY].ToString()).ToString("N0"); //예약량(SCAN)
                            Grid1.Rows[i].Cells[grid1_COLUMN.USE_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.USE_QTY].ToString()).ToString("N0"); //실소모량
                        }
                        Grid1.Rows[i].Cells[grid1_COLUMN.USE_QTY_ORG].Value = dtData1.Rows[i][grid1_COLUMN.USE_QTY_ORG].ToString(); //실소모량


                    }
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

        }
        private void DBQuery_WorkLotResule(string p_WK_ORD_NO, string p_Facility_CD, string p_CHILD_ITEM_CD)    //lot예약정보
        {

            int nCnt = 0;
            try
            {
                //LoadingForm(true);

                Grid2.Rows.Clear();

                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MES_P5001M2_GET @PLANT_CD='" + Global.workinfo.szFactoryCD + "', ";
                strData += "@WK_ORD_NO='" + p_WK_ORD_NO + "',";
                strData += "@FACILITY_CD='" + p_Facility_CD + "',";
                strData += "@CHILD_ITEM_CD='" + p_CHILD_ITEM_CD + "'";

                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);

                //string strState = TGSClass.DataBase.GetDataSql(MainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (!@strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "자재투입 조회");
                    return;
                }

                if (dtData1 != null)
                {

                    //Grid2.DataSource = dtData1;


                    for (int i = 0; i < dtData1.Rows.Count; i++)
                    {


                        Grid2.Rows.Add();

                        Grid2.Rows[i].Cells[grid2_COLUMN.LOC_NO].Value = dtData1.Rows[i][grid2_COLUMN.LOC_NO].ToString(); //적치장 
                        Grid2.Rows[i].Cells[grid2_COLUMN.LOC_NM].Value = dtData1.Rows[i][grid2_COLUMN.LOC_NM].ToString(); //적치장 
                        Grid2.Rows[i].Cells[grid2_COLUMN.LOT_NO].Value = dtData1.Rows[i][grid2_COLUMN.LOT_NO].ToString(); //LOT NO 
                        Grid2.Rows[i].Cells[grid2_COLUMN.OUT_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid2_COLUMN.OUT_QTY].ToString()).ToString("N0"); //예약량(SCAN)
                        Grid2.Rows[i].Cells[grid2_COLUMN.REAL_USED_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid2_COLUMN.REAL_USED_QTY].ToString()).ToString("N0"); //실소모량
                        Grid2.Rows[i].Cells[grid2_COLUMN.INV_UNT].Value = dtData1.Rows[i][grid2_COLUMN.INV_UNT].ToString(); //단위
                        Grid2.Rows[i].Cells[grid2_COLUMN.STATE_NM].Value = dtData1.Rows[i][grid2_COLUMN.STATE_NM].ToString(); //상태
                        Grid2.Rows[i].Cells[grid2_COLUMN.PUBLIC_NM].Value = dtData1.Rows[i][grid2_COLUMN.PUBLIC_NM].ToString(); //구분
                        Grid2.Rows[i].Cells[grid2_COLUMN.CUD_CHAR].Value = ""; //수정구분자
                        Grid2.Rows[i].Cells[grid2_COLUMN.PUBLIC_FLAG].Value = dtData1.Rows[i][grid2_COLUMN.PUBLIC_FLAG].ToString(); //구분; 


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

        #endregion ▶▶▶ 작업지시현황 정보 조회




        #region ▶▶▶ 작업장 LOT SCAN 시 롯트리스트에서 선택해서 투입가능여부 체크
        private bool DBQuery_WorkLotScanOption(string p_PLANT_CD, string p_WC_CD)    //lot scan 예약정보 유무 체크
        {

            int nCnt = 0;
            try
            {
                //LoadingForm(true);

                if (p_WC_CD == "")
                {
                    TGSControl.UsrFunction.MessageBoxErr("작업장 정보가 없습니다.", "LOT SCAN 옵션 체크");
                    return false;
                }

                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MES_P1003M1_GET_LOT_SCAN_OPTION @PLANT_CD='" + p_PLANT_CD + "', ";
                strData += "@WC_CD='" + p_WC_CD + "'";



                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);
                //string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (@strState.Equals("OK") == false)
                {

                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "LOT SCAN 옵션 체크");
                    return false;
                }

                if (dtData1 != null)
                {
                    if (dtData1.Rows.Count > 0)
                    {
                        if (dtData1.Rows[0]["LOT_LIST_USE"].ToString() == "Y")  //LOT SCAN 리스트에서 선택 기능 사용여부
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                TGSControl.UsrFunction.MessageBoxErr(e.Message, "LOT SCAN 옵션 체크");
                return false;
            }
            finally
            {
                //LoadingForm(false);
            }
            return false;
        }
        #endregion ▶▶▶ 작업장 LOT SCAN 시 롯트리스트에서 선택해서 투입가능여부 체크


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

        private void btn_Before_Click(object sender, EventArgs e)//이전버튼
        {
            if (sGrid_Current_id == 2)    //그리드 2가 활성화 상태이면 다음 버튼을 누르면 그리드2의 페이지가 변경됨
            {
                int vDisplayedRowCount = Grid2.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid2.FirstDisplayedScrollingRowIndex - vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex < 0)
                        Grid2.FirstDisplayedScrollingRowIndex = 0;
                    else
                        Grid2.FirstDisplayedScrollingRowIndex = Grid2.FirstDisplayedScrollingRowIndex - vDisplayedRowCount;
                }
            }
            else
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

        }

        private void btn_Next_Click(object sender, EventArgs e)//다음버튼
        {
            if (sGrid_Current_id == 2)    //그리드 2가 활성화 상태이면 다음 버튼을 누르면 그리드2의 페이지가 변경됨
            {
                int vDisplayedRowCount = Grid2.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid2.FirstDisplayedScrollingRowIndex + vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex >= Grid2.Rows.Count)
                        Grid2.FirstDisplayedScrollingRowIndex = Grid2.Rows.Count - 1;
                    else
                        Grid2.FirstDisplayedScrollingRowIndex = vFirstDisplayedScrollingRowIndex;
                }
            }
            else
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
        }

        private void but_OK_Click(object sender, EventArgs e)//자재 LOT 투입
        {

            if (Grid2.Rows.Count != 0)
            {
                bool SaveCheck = true;

                for (int i = 0; i < Grid2.Rows.Count; i++)
                {

                    if (Grid2.Rows[i].Cells[grid2_COLUMN.CUD_CHAR].Value.ToString() == "C" || Grid2.Rows[i].Cells[grid2_COLUMN.CUD_CHAR].Value.ToString() == "U")
                    {
                        if (tCheckBox2.ValueChar == "N")    
                        {
                            //지시건 자재투입이면
                            if (DBSave_LotScan(sWK_ORD_NO, Grid2.Rows[i].Cells[grid2_COLUMN.LOT_NO].Value.ToString(), Grid2.Rows[i].Cells[grid2_COLUMN.LOC_NO].Value.ToString(), Grid2.Rows[i].Cells[grid2_COLUMN.CUD_CHAR].Value.ToString()))
                            {
                                Grid2.Rows[i].Cells[grid2_COLUMN.CUD_CHAR].Value = "";
                            }
                            else
                            {
                                SaveCheck = false;
                            }
                        }
                        else
                        {   //공용으로 자재투입이면
                            if (DBSave_LotScan_PUBLIC(sWK_ORD_NO, sFACILITY_CD, Grid2.Rows[i].Cells[grid2_COLUMN.LOT_NO].Value.ToString(), Grid2.Rows[i].Cells[grid2_COLUMN.LOC_NO].Value.ToString(), Grid2.Rows[i].Cells[grid2_COLUMN.CUD_CHAR].Value.ToString()))
                            {
                                Grid2.Rows[i].Cells[grid2_COLUMN.CUD_CHAR].Value = "";
                            }
                            else
                            {
                                SaveCheck = false;
                            }

                        }
                    }

                    if (Grid2.Rows[i].Cells[grid2_COLUMN.CUD_CHAR].Value.ToString() == "D")
                    {
                        if (Grid2.Rows[i].Cells[grid2_COLUMN.PUBLIC_FLAG].Value.ToString() == "Y")
                        {
                            //공용으로 자재투입이면
                            if (DBSave_LotScan_PUBLIC(sWK_ORD_NO, sFACILITY_CD, Grid2.Rows[i].Cells[grid2_COLUMN.LOT_NO].Value.ToString(), Grid2.Rows[i].Cells[grid2_COLUMN.LOC_NO].Value.ToString(), Grid2.Rows[i].Cells[grid2_COLUMN.CUD_CHAR].Value.ToString()))
                            {
                                Grid2.Rows[i].Cells[grid2_COLUMN.CUD_CHAR].Value = "";
                            }
                            else
                            {
                                SaveCheck = false;
                            }
                            
                        }
                        else
                        {
                            //지시건 자재투입이면
                            if (DBSave_LotScan(sWK_ORD_NO, Grid2.Rows[i].Cells[grid2_COLUMN.LOT_NO].Value.ToString(), Grid2.Rows[i].Cells[grid2_COLUMN.LOC_NO].Value.ToString(), Grid2.Rows[i].Cells[grid2_COLUMN.CUD_CHAR].Value.ToString()))
                            {
                                Grid2.Rows[i].Cells[grid2_COLUMN.CUD_CHAR].Value = "";
                            }
                            else
                            {
                                SaveCheck = false;
                            }
                        }
                    }

                }

                if (SaveCheck)
                {


                    //DataTable dt = new DataTable("Result");
                    //dt.Columns.Add(grid1_COLUMN.SEQ);
                    //dt.Columns.Add(grid1_COLUMN.ITEM_CD);

                    //dt.Rows.Add();

                    //dt.Rows[0][grid1_COLUMN.SEQ] = Grid1.CurrentRow.Cells[grid1_COLUMN.SEQ].Value;
                    //dt.Rows[0][grid1_COLUMN.ITEM_CD] = Grid1.CurrentRow.Cells[grid1_COLUMN.ITEM_CD].Value;


                    //sResultData.Tables.Add(dt);





                    this.DialogResult = DialogResult.OK;

                }

            }
            else
            {
                TGSControl.UsrFunction.MessageBoxErr( "스캔한 롯트가 없습니다. " , "투입자재 선택");
            }
        }

        private bool DBSave_LotScan(string p_WK_ORD_NO, string p_LOT_NO, string p_LOC_NO, string p_CUD_CHAR)
        {
            try
            {
                int nCnt = 0;



                LoadingForm(true);

                

                string strData = WorkCode.WorkCd.SQLPROCEDURE ; //프로시져 형태로 호출
                strData += "DBO.XUSP_MES_P5001P2_SET_LOT_SCAN";       //프로시져 명
                strData +=  Global.COLUMNS_DIV + "N" + TGSClass.nsGlobal.Global.Separation.COLUMNS;   //조회데이타가 없을 경우 'N' = nonquery 있을 경우 'Q' = query
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

        private void btn_Cancel_Click(object sender, EventArgs e)//취소버튼
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            Panel_Doc_s1.Width = windowsForm1.Width - Panel_Doc_s1.Left - Panel_Doc_s1.Left;
            Panel_Doc_s1.Height = windowsForm1.Height - Panel_Doc_s1.Top - Panel_Doc_s1.Left;


        }
        //검색버튼을 클릭한다.
        private void btn_Query_Click(object sender, EventArgs e)
        {
            DBQuery();
        }
        

        private void opn_LOT_SCAN_EnterKeyDown(object sender, EventArgs e)
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
            
            
            //바코드 라벨 스캔 창에서 enter키를 입력 할 경우

            for (int i = 0; i < Grid1.Rows.Count; i++)
            {
                if (Grid1.Rows[i].Cells[grid1_COLUMN.LOT_NO].Value.ToString().ToUpper() == opn_LOT_SCAN.Value.ToString().ToUpper())
                {
                    System.Drawing.Image imgChecked = (Image)Grid1.Rows[i].Cells[grid1_COLUMN.CHECKFLAG].Value;

                    Grid1.Rows[i].Cells[0].Selected = true;

                    if(imgChecked.Tag.ToString() == "Y")
                    {
                        TGSControl.UsrFunction.MessageBoxErr("이미 선택된 롯트입니다.", "자재투입(롯트스캔)");

                    }
                    else
                    {
                        if (SetLotScan(i))  //그리드를 선택해서 추가한다.
                        {

                            Image vCheckImage = (Image)Grid1.CurrentRow.Cells["CHECKFLAG"].Value;
                            
                            vCheckImage = Properties.Resources.CheckBoxChecked;
                            vCheckImage.Tag = "Y";

                            Grid1.CurrentRow.Cells["CHECKFLAG"].Value = vCheckImage;
                        }
                    }

                    Grid1.FirstDisplayedScrollingRowIndex = i;
                    

                    opn_LOT_SCAN.Value = "";
                    break;
                }

            }

            
        }

        private bool SetLotScan(int pRowIndex)
        {

            //DataTable myTable = (DataTable)Grid2.DataSource;

            if (Grid1.Rows[pRowIndex].Cells[grid1_COLUMN.LOT_NO].Value.ToString() != "")
            {

                Grid2.Rows.Add();

                int i = Grid2.Rows.Count - 1;

                Grid2.Rows[i].Cells[grid2_COLUMN.LOC_NO].Value = Grid1.Rows[pRowIndex].Cells[grid1_COLUMN.LOC_NO].Value.ToString();
                Grid2.Rows[i].Cells[grid2_COLUMN.LOC_NM].Value = Grid1.Rows[pRowIndex].Cells[grid1_COLUMN.LOC_NM].Value.ToString();
                Grid2.Rows[i].Cells[grid2_COLUMN.LOT_NO].Value = Grid1.Rows[pRowIndex].Cells[grid1_COLUMN.LOT_NO].Value.ToString();
                Grid2.Rows[i].Cells[grid2_COLUMN.INV_QTY].Value = Grid1.Rows[pRowIndex].Cells[grid1_COLUMN.INV_QTY].Value;
                Grid2.Rows[i].Cells[grid2_COLUMN.INV_UNT].Value = Grid1.Rows[pRowIndex].Cells[grid1_COLUMN.INV_UNT].Value.ToString();
                Grid2.Rows[i].Cells[grid2_COLUMN.OUT_QTY].Value = Convert.ToDecimal(Grid1.Rows[pRowIndex].Cells[grid1_COLUMN.INV_QTY].Value.ToString()) - Convert.ToDecimal(Grid1.Rows[pRowIndex].Cells[grid1_COLUMN.USE_QTY].Value.ToString());
                Grid2.Rows[i].Cells[grid2_COLUMN.REAL_USED_QTY].Value = "0";
                Grid2.Rows[i].Cells[grid2_COLUMN.STATE_NM].Value = "NEW";
                Grid2.Rows[i].Cells[grid2_COLUMN.PUBLIC_NM].Value = "";
                Grid2.Rows[i].Cells[grid2_COLUMN.CUD_CHAR].Value = "C";
                Grid2.Rows[i].Cells[grid2_COLUMN.PUBLIC_FLAG].Value = "";

                Grid1.Rows[pRowIndex].Cells[grid1_COLUMN.USE_QTY].Value = Convert.ToDecimal(Grid1.Rows[pRowIndex].Cells[grid1_COLUMN.USE_QTY].Value.ToString()) + Convert.ToDecimal(Grid2.Rows[i].Cells[grid2_COLUMN.OUT_QTY].Value.ToString());


                SetScanQty();
            }

            return true;

            

        }

        private void SetScanQty()   
        {
            decimal p_use_qty = 0;

            for (int i = 0; i < Grid2.Rows.Count; i++)
            {
                p_use_qty = p_use_qty + Convert.ToDecimal(Grid2.Rows[i].Cells[grid2_COLUMN.OUT_QTY].Value);
            }

            lbl_LotScanQty.Caption = p_use_qty.ToString("N0");
        }

        private bool CancelLotScan(int pRowIndex) //총 스캔 수량을 취소한다..
        {

            //if (Convert.ToDecimal(Grid1.Rows[pRowIndex].Cells[grid1_COLUMN.USE_QTY].Value.ToString()) == Convert.ToDecimal(Grid1.Rows[pRowIndex].Cells[grid1_COLUMN.USE_QTY_ORG].Value.ToString()))
            //{
                
                //DataTable myTable = (DataTable)Grid2.DataSource;

                for (int i = 0; i < Grid2.Rows.Count; i++)
                {
                    if (Grid2.Rows[i].Cells[grid2_COLUMN.LOT_NO].Value.ToString() == Grid1.Rows[pRowIndex].Cells[grid1_COLUMN.LOT_NO].Value.ToString())
                    {
                        if (Grid2.Rows[i].Cells[grid2_COLUMN.CUD_CHAR].Value.ToString() == "C")
                        {

                            Grid1.Rows[pRowIndex].Cells[grid1_COLUMN.USE_QTY].Value = Convert.ToDecimal(Grid1.Rows[pRowIndex].Cells[grid1_COLUMN.USE_QTY].Value.ToString()) - Convert.ToDecimal(Grid2.Rows[i].Cells[grid2_COLUMN.OUT_QTY].Value.ToString());
                            
                            Grid2.Rows.Remove(Grid2.Rows[i]);

                            SetScanQty();
                            return true;
                            
                        }
                    }
                        
                }

                return false;
            //}
            //else
            //{
            //    return false;
            //}
            

        }
        private void Grid1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (Grid1.Columns[e.ColumnIndex].Name != grid1_COLUMN.CHECKFLAG) return;

            if (sLOT_SCAN_Flag == false)     //2017-06-29 이동환    생산자재 투입 시 롯트리스트에서 선택 투입 가능 작업장
            {
                TGSControl.UsrFunction.MessageBoxInfo("현 작업장은 롯트스캔으로 등록해야 합니다. ", "롯트를 스캔해서 입력하세요");
                opn_LOT_SCAN.Focus();
                return;
            }

            decimal vREV_QTY = Convert.ToDecimal(lbl_RESV_QTY.Caption.ToString());
            decimal vSCAN_QTY = Convert.ToDecimal(lbl_LotScanQty.Caption.ToString());
            bool vFlag = false;

            

            for (int i = 0; i < Grid1.Rows.Count; i++)
            {
                System.Drawing.Image imgChecked = (Image)Grid1.Rows[i].Cells[grid1_COLUMN.CHECKFLAG].Value;

                if (imgChecked.Tag.ToString() == "Y")
                {
                    vFlag = true;
                    break;
                }
            }

            if (vFlag)
            {
                for (int i = 0; i < Grid1.Rows.Count; i++)
                {
                    System.Drawing.Image imgChecked = (Image)Grid1.Rows[i].Cells[grid1_COLUMN.CHECKFLAG].Value;

                    if (imgChecked.Tag.ToString() == "Y")
                    {
                        Grid1.Rows[i].Cells["CHECKFLAG"].Selected = true;
                        Grid1_CellClick(null, null);

                    }
                }

            }
            else
            {

                if (vSCAN_QTY >= vREV_QTY) return;

                for (int i = 0; i < Grid1.Rows.Count; i++)
                {
                    Grid1.Rows[i].Cells["CHECKFLAG"].Selected = true;
                    Grid1_CellClick(null, null);

                    vSCAN_QTY = Convert.ToDecimal(lbl_LotScanQty.Caption.ToString());

                    if (vSCAN_QTY >= vREV_QTY) break;

                }
            }
        }
        private void Grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid1.CurrentRow == null) return;
            if (e == null || e.RowIndex >= 0 )
            {
                


                Image vCheckImage = (Image)Grid1.CurrentRow.Cells["CHECKFLAG"].Value;

                if (Grid1.Columns[Grid1.CurrentCell.ColumnIndex].Name == grid1_COLUMN.CHECKFLAG)
                {
                    if (sLOT_SCAN_Flag == false)     //2017-06-29 이동환    생산자재 투입 시 롯트리스트에서 선택 투입 가능 작업장
                    {
                        TGSControl.UsrFunction.MessageBoxInfo("현 작업장은 롯트스캔으로 등록해야 합니다. ", "롯트를 스캔해서 입력하세요");
                        opn_LOT_SCAN.Focus();
                        return;
                    }
                

                    if (vCheckImage.Tag.ToString() == "N") //선택되지 않은 것을 추가한다.
                    {

                        if (SetLotScan(Grid1.CurrentRow.Index))  //선택된 것을 추가한다.
                        {
                            vCheckImage = Properties.Resources.CheckBoxChecked;
                            vCheckImage.Tag = "Y";

                            Grid1.CurrentRow.Cells["CHECKFLAG"].Value = vCheckImage;

                        }
                    }
                    else if (vCheckImage.Tag.ToString() == "Y") //선택된 것을 차감한다.
                    {   //선택된것을 차감한다.

                        if (CancelLotScan(Grid1.CurrentRow.Index)) //선택된 것을 차감한다.
                        {
                            vCheckImage = Properties.Resources.CheckBoxUnChecked;
                            vCheckImage.Tag = "N";

                            Grid1.CurrentRow.Cells["CHECKFLAG"].Value = vCheckImage;

                        }

                    }
                }
            }
            opn_LOT_SCAN.Focus();
        }

        private void tLabel14_Click(object sender, EventArgs e)
        {

        }

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

            opn_LOT_SCAN.Focus();
        }

        

        private void tCheckBox1_CheckedChange(object sender, EventArgs e)
        {
            Panel_Doc_S121.SuspendLayout();

            if (tCheckBox1.Checked)
            {
                Panel_Doc_S121.ColumnStyles[0].SizeType = SizeType.Percent;
                Panel_Doc_S121.ColumnStyles[0].Width = 0;
                Panel_Doc_S121.ColumnStyles[1].SizeType = SizeType.Percent;
                Panel_Doc_S121.ColumnStyles[1].Width = 100;

            }
            else
            {
                Panel_Doc_S121.ColumnStyles[0].SizeType = SizeType.Percent;
                Panel_Doc_S121.ColumnStyles[0].Width = 100;
                Panel_Doc_S121.ColumnStyles[1].SizeType = SizeType.Percent;
                Panel_Doc_S121.ColumnStyles[1].Width = 0;

            }

            Panel_Doc_S121.PerformLayout();
            Panel_Doc_S121.ResumeLayout();
        }

        private void Grid1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Grid_RowMove((DataGridView)sender, e); //그리드 이동
        }

        private void Grid2_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Grid_RowMove((DataGridView)sender, e); //그리드 이동
        }
        ////그리드 이동처리
        //private void Grid_RowMove(DataGridView Grid, DataGridViewCellMouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        if (Grid.CurrentRow != null)
        //        {
        //            if (Grid.CurrentRow.Index > e.RowIndex)    //이전페이지
        //            {
        //                btn_Before_Click(null, null);
        //            }
        //            else if (Grid.CurrentRow.Index < e.RowIndex)   //다음페이지
        //            {
        //                btn_Next_Click(null, null);
        //            }
        //        }

        //    }

        //}

        private void POP_P1003P2_Shown(object sender, EventArgs e)
        {
            opn_LOT_SCAN.Focus();
        }

        private void opn_LOT_SCAN_Enter(object sender, EventArgs e)
        {
            opn_LOT_SCAN.BackColor = Color.Yellow;
        }

        private void opn_LOT_SCAN_Leave(object sender, EventArgs e)
        {
            opn_LOT_SCAN.BackColor = Color.White;
        }

        private void Grid1_Enter(object sender, EventArgs e)
        {
            sGrid_Current_id = 1;
        }

        private void Grid2_Enter(object sender, EventArgs e)
        {
            sGrid_Current_id = 2;
        }

        private void POP_P1003P2_Activated(object sender, EventArgs e)
        {
            windowsForm1.BorderColor = Color.DarkOrange;
        }

        private void POP_P1003P2_Deactivate(object sender, EventArgs e)
        {
            windowsForm1.BorderColor = Color.Gray;
        }

        


        

       

        

    }
}
