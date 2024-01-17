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
    public partial class POP_P9001PA1 : Form
    {
       


        #region ▶ 1. Declaration part  //선언부

        #region ■ 1.1 Program information      //프로그램 정보 및 수정 이력 정보 
        /// <TemplateVersion>0.0.1.0</TemplateVersion>
        /// <NameSpace>①namespace</NameSpace>
        /// <Module>②module name</Module>
        /// <Class>③class name</Class>
        /// <Desc>④
        ///   재고이동 등록을 하는 프로그램 품목 재고리스트에서 품목선택 또는 바코드 lot스캔으로 처리 함
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




        #endregion

        #region ■ 1.3. Class global variables (common) //글로벌 변수 선언

        Global global = new Global();
        Form sMainForm;

        string sPLANT_CD = "";      //공장
        string sITEM_CD = "";        //품번
        string sITEM_NM = "";       //품명
        string sWC_MGR = "";        //대공정
        string sWC_CD = "";         //작업장
        //String sFACILITY_CD = "";   //설비번호

        //string sWK_ORD_NO = "";     //작업지시번호
        //string sRESULT_NO = "";     //생산실적번호
        
        String sUSER_ID = "POPUSER";   //사용자ID

        string sREPORT_SERVER_IP = "";  //리포트 서버 주소
        
        DataSet sResultData = new DataSet();

        #endregion


        #region ■ 1.4. Class global property (common) //컨트롤 변수 선언

        [Category("시작변수"), Description("파라메터 전달 및 결과값 반환을 위해 사용합니다.")]
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

        [Category("시작변수"), Description("폼 이름을 설정 및 반환을 위해 사용합니다.")]
        public String Caption
        {
            get
            {
                return windowsForm1.Caption;
            }
            set
            {
                windowsForm1.Caption = value;
            }
        }

        #endregion

        #endregion

        #region ▶ 2. Initialization part

        #region ■ 2.1 Constructor(common)      //생성자

        public POP_P9001PA1()
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

            //DBQuery();     //조회
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
                sITEM_CD = sResultData.Tables["PassData"].Rows[0]["ITEM_CD"].ToString();
                sITEM_NM = sResultData.Tables["PassData"].Rows[0]["ITEM_NM"].ToString();
                sPLANT_CD = sResultData.Tables["PassData"].Rows[0]["PLANT_CD"].ToString();
                //sFACILITY_CD = sResultData.Tables["PassData"].Rows[0]["FACILITY_CD"].ToString();
                sWC_MGR = sResultData.Tables["PassData"].Rows[0]["WC_MGR"].ToString();
                sWC_CD = sResultData.Tables["PassData"].Rows[0]["WC_CD"].ToString();

            }


        }

        #endregion

        #region ■ 2.5 Gathering combo data(GatheringComboData) //콤보관련 데이타 설정

        protected void GatheringComboData()
        {


            //Fnc_crt_combo(this.cboWorker, "", "WORKER", 0, "작업자", "작업자명", "작업자 선택");  //작업자정보조회

            //Fnc_crt_combo(this.cboSL_CD_FR, "", "SL_CD", 0, "창고", "재고창고명", "재고창고 선택");

            //Fnc_crt_combo(this.cboSL_CD_TO, "", "LOC_NO", -1, "창고", "이동창고명", "이동창고 선택");

            //if (sWC_MGR == "10") cboSL_CD_TO.Value = "CV00";

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
        //        case "WORKER":    // 재고이동(출고) 작업자 최근 1개월 이동작업을 많이 하는 사람이 가장 위에 표시
        //            strSql = "EXEC DBO.XUSP_MES_P1004P1_GET_MOVE_WORKER ";
        //            strSql += "@PLANT_CD='" + sPLANT_CD + "',";
        //            strSql += "@WC_MGR='" + sWC_MGR + "'";


        //            pValueMember = "USER_ID";
        //            pDisplayMember = "EMP_DESC";

        //            break;

        //        case "SL_CD":    // 보내주는 창고
        //            strSql = "EXEC DBO.XUSP_MES_P1004P1_GET_SL_FR ";
        //            strSql += "@PLANT_CD='" + sPLANT_CD + "',";
        //            strSql += "@WC_MGR='" + sWC_MGR + "'";


        //            pValueMember = "SL_CD";
        //            pDisplayMember = "SL_NM";

        //            break;

        //        case "LOC_NO":    // 받는 적치장
        //            strSql = "EXEC DBO.XUSP_MES_P1004P1_GET_LOC ";
        //            strSql += "@PLANT_CD='" + sPLANT_CD + "'";
              

        //            pValueMember = "LOC_NO";
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
        //        string strState = nsFuncUtil.FuncUtil.GetDataSql(this.MainForm, strSql, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);

        //    }
        //    catch (Exception ex)
        //    {
        //        nsUsrFunction.UsrFunction.MessageBoxErr(ex.Message, "기준정보조회");

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
            //InitSpreadSheet(1);
        }

        private void InitSpreadSheet(int p_GridIndex)   //선택된 스프레드시트를 초기화 한다.
        {


            //#region ▶▶▶ 3.1.1 GRID1 설정

            //if (p_GridIndex == 1)
            //{
            //    #region ■■ 3.1.1.1 Pre-setting grid information

            //    /*** grid1
            //     *  재고조회
            //     * **/
            //    Grid1.Columns.Clear();

            //    DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            //    columnHeaderStyle.BackColor = Color.Beige;
            //    columnHeaderStyle.Font = new Font("맑은 고딕", 12);
            //    Grid1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            //    Grid1.RowHeadersVisible = false;

            //    Grid1.Columns.Add(SetColumnImage(grid1_COLUMN.CHECKFLAG, "√", 40));    //이미지형태의 그리드

            //    //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.CHECKFLAG, "√", 40));
            //    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.ITEM_CD, "품번", 180));
            //    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.ITEM_NM, "품명", 200));
            //    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.LOC_NO, "적치장", 80));
            //    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.LOT_NO, "LOT_NO", 230));
            //    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.INV_QTY, "재고량", 100));
            //    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.INV_UNIT, "단위", 50));


            //    #endregion


            //    #region ■■ 3.1.1.2 Formatting grid information

            //    //uniGrid2.flagInformation("cud_flag", "rownum");
            //    //uniGrid2.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.No);

            //    Grid1.Columns[grid1_COLUMN.INV_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //    Grid1.Columns[grid1_COLUMN.INV_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태
                
            //    #endregion


            //    #region ■■ 3.1.1.3 Setting etc grid
            //    // Hidden Column Setting
            //    //Grid1.Columns[grid1_COLUMN.USE_QTY_ORG].Visible = false;


            //    #endregion

            //}
            //#endregion

            //#region ▶▶▶ 3.1.2 GRID2 설정
            //if (p_GridIndex == 2)
            //{
                
            //    #region ■■ 3.1.2.1 Pre-setting grid information



            //    /*** grid1
            //     *  실적조회
            //     * **/
            //    Grid2.Columns.Clear();

            //    DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            //    columnHeaderStyle.BackColor = Color.Beige;
            //    columnHeaderStyle.Font = new Font("맑은 고딕", 12);
            //    Grid2.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            //    Grid2.RowHeadersVisible = false;

            //    Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.ITEM_CD, "품번", 130));
            //    Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.ITEM_NM, "품명", 200));
            //    Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.LOC_NO, "적치장", 130));
            //    Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.LOT_NO, "LOT NO", 130));
            //    Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.INV_QTY, "이동량", 90));
            //    Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.INV_UNT, "단위", 50));
                

            //    #endregion


            //    #region ■■ 3.1.2.2 Formatting grid information

            //    //uniGrid2.flagInformation("cud_flag", "rownum");
            //    //uniGrid2.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.No);

            //    Grid2.Columns[grid2_COLUMN.INV_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //    Grid2.Columns[grid2_COLUMN.INV_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태
                


            //    #endregion


            //    #region ■■ 3.1.2.3 Setting etc grid
            //    // Hidden Column Setting
            //    //Grid2.Columns[grid2_COLUMN.CUD_CHAR].Visible = false;
                


            //    #endregion

            //}
            //#endregion
            
        }


        #endregion

        #region ■ 3.2 InitData

        private void InitData()
        {
            // TO-DO: 컨트롤을 초기화(또는 초기값)할때 할일 
            // SetDefaultVal과의 차이점은 전자는 Form_Load 시점에 콘트롤에 초기값을 세팅하는것이고
            // 후자는 특정 시점(조회후 또는 행추가후 등 특정이벤트)에서 초기값을 셋팅한다.

            opn_ITEM_CD.Value = sITEM_CD;
            opn_ITEM_CD.ValueName = sITEM_NM;

                
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
            DBQuery_WorkStandardSheet(sITEM_CD);

            return true;
        }


        #region ▶▶▶ 작업표준서 조회
        private bool DBQuery_WorkStandardSheet(string p_Item_CD)
        {


            if (p_Item_CD == "")
            {
                //nsUsrFunction.UsrFunction.MessageBoxErr("선택된 항목이 없습니다.", "작업표준서");
                return false;
            }

            string vReportServer = DBQuery_GetReportServer(Global.workinfo.szServerIP);
            if (vReportServer == "") vReportServer = Global.workinfo.szServerIP;


            if (sWC_MGR == Global.Process.COMPLETE)
            {
                Uri url = new Uri(@"http://" + vReportServer + "/OZReport/reportcall_mes.asp?doc=MES_P_W&runvar=dbAliasName|unierp5|"
                                + "PLANT_CD|" + sPLANT_CD + "|"
                                + "ITEM_CD|" + p_Item_CD + "|"
                                + "WC_CD|" + sWC_CD );
                                //+ "WC_CD|" + sWC_CD + "|"
                                //+ "&DDLanguage=ko/KR&VDName=OZReport");

                webBrowser1.Url = url;
            }
            if (sWC_MGR == Global.Process.ASSEMBLY)
            {
                Uri url = new Uri(@"http://" + vReportServer + "/OZReport/reportcall_mes.asp?doc=MES_P_W&runvar=dbAliasName|unierp5|"
                                + "PLANT_CD|" + sPLANT_CD + "|"
                                + "ITEM_CD|" + p_Item_CD + "|"
                                + "WC_CD|" + sWC_CD);
                                //+ "WC_CD|" + sWC_CD + "|"
                                //+ "&DDLanguage=ko/KR&VDName=OZReport");

                webBrowser1.Url = url;
            }
            else if (sWC_MGR == Global.Process.FORMING)
            {
                Uri url = new Uri(@"http://" + vReportServer + "/OZReport/reportcall_mes.asp?doc=MES_P_J&runvar=dbAliasName|unierp5|"
                                + "PLANT_CD|" + sPLANT_CD + "|"
                                + "ITEM_CD|" + p_Item_CD);
                                //+ "ITEM_CD|" + p_Item_CD + "|"
                                //+ "&DDLanguage=ko/KR&VDName=OZReport");
                webBrowser1.Url = url;
            }

            else if (sWC_MGR == Global.Process.PREPARE)
            {
                Uri url = new Uri(@"http://" + vReportServer + "/OZReport/reportcall_mes.asp?doc=MES_P_S&runvar=dbAliasName|unierp5|"
                                + "PLANT_CD|" + sPLANT_CD + "|"
                                + "ITEM_CD|" + p_Item_CD);
                                //+ "ITEM_CD|" + p_Item_CD + "|"
                                //+ "&DDLanguage=ko/KR&VDName=OZReport");
                webBrowser1.Url = url;
            }



            return true;
        }
        
        #endregion ▶▶▶ 작업표준서 조회


        #region ▶▶▶ 오즈리포트 연결정보 값을 조회
        private string DBQuery_GetReportServer(string pServerIP)
        {
            int nCnt = 0;
            string vREPORT_STR = "";
            try
            {


                string strData = "";
                strData = "EXEC DBO.XUSP_MES_B_REPORT_SVR ";
                strData += "@CLIENT_IP='" + pServerIP + "'";

                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);

                //string strState = nsFuncUtil.FuncUtil.GetDataSql(this, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (@strState.Equals("OK") == false)
                {
                    //nsUsrFunction.UsrFunction.MessageBoxErr(strState.Substring(2), "DB 환경설정 조회");
                    return vREPORT_STR;
                }

                if (dtData1 != null)
                {
                    if (dtData1.Rows.Count > 0)
                    {
                        vREPORT_STR = dtData1.Rows[0]["REPORT_STR"].ToString(); //항목값

                    }
                }

            }
            catch (Exception e)
            {
                //nsUsrFunction.UsrFunction.MessageBoxErr(e.Message, "DB 환경설정 조회");

            }
            finally
            {
                //LoadingForm(false);

            }

            return vREPORT_STR;


        }
        #endregion ▶▶▶ 오즈리포트 연결정보 값을 조회

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

        //#region ▶▶▶ 재고이동 처리
        ////private bool DBSave_Move_Save() //재고이동 처리 함
        ////{


        ////    string p_LOT_NO = "";
        ////    string p_LOC_NO = "";
        ////    try
        ////    {
        ////        LoadingForm(true);


        ////        for (int i = 0; i < Grid1.Rows.Count; i++)
        ////        {
        ////            Image myCheck = (Image)Grid1.Rows[i].Cells[grid1_COLUMN.CHECKFLAG].Value;

        ////            if (myCheck.Tag.ToString() == "Y")
        ////            {
        ////                p_LOT_NO = Grid1.Rows[i].Cells[grid1_COLUMN.LOT_NO].Value.ToString();
        ////                p_LOC_NO = cboSL_CD_TO.Value.ToString();
                        
                        
        ////                string strData = WorkCode.WorkCd.SQLPROCEDURE; //프로시져 형태로 호출
        ////                strData += "DBO.USP_MES_M_INV_MAST_MOVE";       //프로시져 명
        ////                strData += Global.COLUMNS_DIV + "N" + Global.Separation.COLUMNS;   //조회데이타가 없을 경우 'N' = nonquery 있을 경우 'Q' = query
        ////                //일반변수 리스트
        ////                strData += "@PLANT_CD" + Global.COLUMNS_DIV;
        ////                strData += "@SCAN_NO1" + Global.COLUMNS_DIV;
        ////                strData += "@SCAN_NO2" + Global.COLUMNS_DIV;
        ////                strData += "@USER_ID" + Global.Separation.COLUMNS;


        ////                //일반변수 리스트의 형식
        ////                strData += Global.DBVarType.VarChar + "(4)" + Global.COLUMNS_DIV;
        ////                strData += Global.DBVarType.VarChar + "(20)" + Global.COLUMNS_DIV;
        ////                strData += Global.DBVarType.VarChar + "(10)" + Global.COLUMNS_DIV;
        ////                strData += Global.DBVarType.VarChar + "(10)" + Global.Separation.COLUMNS;

        ////                //일반변수값 리스트
        ////                strData += sPLANT_CD + Global.COLUMNS_DIV;
        ////                strData += p_LOT_NO + Global.COLUMNS_DIV;
        ////                strData += p_LOC_NO + Global.COLUMNS_DIV;
        ////                strData += sUSER_ID + Global.Separation.COLUMNS;
                        

        ////                //OUTPUT변수 리스트 
        ////                //strData += "@RESULT_NO" + Global.COLUMNS_DIV;
        ////                strData += "@RTN_MSG";
        ////                strData += nsWinUtilGlobal.Global.Separation.COLUMNS;
        ////                //OUTPUT변수 리스트 형식
        ////                //strData += Global.DBVarType.VarChar + "(20)" + Global.COLUMNS_DIV;
        ////                strData += Global.DBVarType.VarChar + "(200)" + Global.Separation.COLUMNS;
        ////                //OUTPUT변수값 리스트
        ////                //strData += "" + Global.COLUMNS_DIV;
        ////                strData += ""; // +nsWinUtilGlobal.Global.Separation.COLUMNS;


        ////                string strState = nsFuncUtil.FuncUtil.ExcuteSql(MainForm, strData, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
        ////                if (!strState.Equals("OK"))
        ////                {

        ////                    myCheck = Properties.Resources.CheckBoxFalse;
        ////                    myCheck.Tag = "F";
        ////                    Grid1.Rows[i].Cells[grid1_COLUMN.CHECKFLAG].Value = myCheck;
        ////                    Grid1.Rows[i].Cells[grid1_COLUMN.ITEM_CD].Selected = true;
        ////                    Grid1.FirstDisplayedScrollingRowIndex = i;

        ////                    nsUsrFunction.UsrFunction.MessageBoxErr(strState.Substring(2), "이동 자재 저장 에러");
        ////                    LoadingForm(false);
        ////                    return false;
        ////                }

        ////                myCheck = Properties.Resources.CheckBoxOK;
        ////                myCheck.Tag = "O";
        ////                Grid1.Rows[i].Cells[grid1_COLUMN.CHECKFLAG].Value = myCheck;

        ////            }

        ////        }




        ////        nsUsrFunction.UsrFunction.MessageBoxInfo("이동 저장 되었습니다.", "저장완료");
        ////    }
        ////    catch (Exception se)
        ////    {
        ////        nsUsrFunction.UsrFunction.MessageBoxInfo(se.Message, "이동처리 저장 중 에러");
        ////        LoadingForm(false);
        ////        return false;
        ////    }
        ////    finally
        ////    {
        ////        LoadingForm(false);
        ////    }

        ////    return true;
        ////}
        //#endregion

        #endregion

        #endregion


        #region ■ 7. User-defined method part

        private void LoadingForm(bool bVisible)
        {
            Cursor.Current = (bVisible == true) ? Cursors.WaitCursor : Cursors.Default;
            //waitLoading.Visible = bVisible;
            Application.DoEvents();
        }




        





        private void windowsForm1_CloseClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void windowsForm1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
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
                sITEM_CD = myPopupForm.ResultData.Tables["Result"].Rows[0]["ITEM_CD"].ToString();
                sITEM_NM = myPopupForm.ResultData.Tables["Result"].Rows[0]["ITEM_NM"].ToString();

                opn_ITEM_CD.Value = sITEM_CD;
                opn_ITEM_CD.ValueName = sITEM_NM;
                                

                DBQuery();

            }

            myPopupForm.Dispose();

            
        }

        

        private void POP_P1005P1_Resize(object sender, EventArgs e)
        {
            this.SuspendLayout();

            webBrowser1.Width = this.Width - webBrowser1.Left - webBrowser1.Left;
            webBrowser1.Height = this.Height - webBrowser1.Top - webBrowser1.Left;

            this.ResumeLayout(false);

        }


        #endregion  User-defined method part

        





    }
}
