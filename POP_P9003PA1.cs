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
    public partial class POP_P9003PA1 : Form
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


        
        public struct Pass_COLUMN
        {
            public const string PLANT_CD = "PLANT_CD";
            public const string WC_MGR = "WC_MGR";
            public const string FACILITY_CD = "FACILITY_CD";
            public const string WC_CD = "WC_CD";
          
        }

        //public struct Result_COLUMN
        //{
        //    public const string PLANT_CD = "PLANT_CD";
            
        //}


        public struct grid1_COLUMN  //불량실적
        {
            public const string WK_DT = "WK_DT";
            public const string ITEM_CD = "ITEM_CD";  //품번
            public const string ITEM_NM = "ITEM_NM";  //품목
            public const string BAD_QTY = "BAD_QTY";              //불량품수량
            public const string REASON_NM = "REASON_NM";

        }

        #endregion

        #region ■ 1.3. Class global variables (common) //글로벌 변수 선언

        Global global = new Global();
        Form sMainForm;

        string sPLANT_CD = "";      //공장
        string sWC_MGR = "";
        string sFACILITY_CD = "";
        string sWC_CD = "";
        

        DataSet sResultData = new DataSet();
        
        DataTable sResultDataTable = new DataTable("Result");


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

        public POP_P9003PA1()
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
            InitSpreadSheet(1);     //스프레드시트 초기화
            

            //string WC_NM = "";
            //ProcessInform_Review(sFACILITY_CD, ref sWC_CD, ref WC_NM, false);   //선택된 설비의 작업장 정보

        }

        public void Start() //시작
        {

            initControl(); //컨트롤 초기화

            InitData();    //초기값 설정

            
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

                sPLANT_CD = sResultData.Tables["PassData"].Rows[0][Pass_COLUMN.PLANT_CD].ToString();
                sWC_MGR = sResultData.Tables["PassData"].Rows[0][Pass_COLUMN.WC_MGR].ToString();
                sFACILITY_CD = sResultData.Tables["PassData"].Rows[0][Pass_COLUMN.FACILITY_CD].ToString();
                sWC_CD = sResultData.Tables["PassData"].Rows[0][Pass_COLUMN.WC_CD].ToString();
                
            }

            
            ////반환할 값을 저장할 테이블 정의를 한다.
            //sResultDataTable.Columns.Add(Result_COLUMN.PLANT_CD);
            //sResultDataTable.Columns.Add(Result_COLUMN.RESULT_NO);

            //sResultDataTable.Columns.Add(Result_COLUMN.CAVITY);
            //sResultDataTable.Columns.Add(Result_COLUMN.NOW_SHOT_CNT);
            //sResultDataTable.Columns.Add(Result_COLUMN.NOW_SHOT_REV_CNT);
            //sResultDataTable.Columns.Add(Result_COLUMN.NOW_WORK_QTY);
            //sResultDataTable.Columns.Add(Result_COLUMN.TOT_SHOT_CNT);
            //sResultDataTable.Columns.Add(Result_COLUMN.TOT_SHOT_REV_CNT);
            //sResultDataTable.Columns.Add(Result_COLUMN.NOW_RESULT_QTY);
            //sResultDataTable.Columns.Add(Result_COLUMN.RESULT_QTY);
            //sResultDataTable.Columns.Add(Result_COLUMN.PROD_QTY);
            //sResultDataTable.Columns.Add(Result_COLUMN.GOOD_QTY);
            //sResultDataTable.Columns.Add(Result_COLUMN.BAD_QTY);
            //sResultDataTable.Columns.Add(Result_COLUMN.LOT_DEEP);
            

            //if (sResultDataTable.Rows.Count == 0) sResultDataTable.Rows.Add();

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


            /* 설비*/
            Fnc_crt_combo(this.cboFacility, "", "FACILITY", -1, "설비", "설비명", "설비선택");
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
                case "FACILITY":    // 설비
                    strSql = "EXEC DBO.XUSP_MESSVR_GET_FACILITY "
                           + " @PLANT_CD='" + sPLANT_CD + "',"
                           + " @WC_MGR='" + sWC_MGR + "',"
                           + " @WC_CD='" + sWC_CD + "',"
                           + " @JOB_CD='" + "" + "'";  //Mixing의 JobCode자리


                    pValueMember = "FACILITY_CD";
                    pDisplayMember = "FACILITY_NM";
                    this.cboFacility.DisplayCaption = "설비명";
                    this.cboFacility.ValueCaption = "설비코드";
                    this.cboFacility.Caption = "설비정보조회";

                    break;
                //case "WORKER":    // 재고이동(출고) 작업자 최근 1개월 이동작업을 많이 하는 사람이 가장 위에 표시
                //    strSql = "EXEC DBO.XUSP_MES_P1004P1_GET_MOVE_WORKER ";
                //    strSql += "@PLANT_CD='" + sPLANT_CD + "',";
                //    strSql += "@WC_MGR='" + sWC_MGR + "'";


                //    pValueMember = "USER_ID";
                //    pDisplayMember = "EMP_DESC";

                //    break;

                //case "SL_CD":    // 보내주는 창고
                //    strSql = "EXEC DBO.XUSP_MES_P1004P1_GET_SL_FR ";
                //    strSql += "@PLANT_CD='" + sPLANT_CD + "',";
                //    strSql += "@WC_MGR='" + sWC_MGR + "'";


                //    pValueMember = "SL_CD";
                //    pDisplayMember = "SL_NM";

                //    break;

                //case "LOC_NO":    // 받는 적치장
                //    strSql = "EXEC DBO.XUSP_MES_P1004P1_GET_LOC ";
                //    strSql += "@PLANT_CD='" + sPLANT_CD + "'";


                //    pValueMember = "LOC_NO";
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
                //    break;
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



            #region ■■ 3.1.1 Pre-setting grid information

            if (p_GridIndex == 1)
            {

                /*** grid1
                 *  실적조회
                 * **/
                Grid1.Columns.Clear();

                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Beige;
                //columnHeaderStyle.BackColor = Color.FromArgb(192, 255, 255);
                columnHeaderStyle.Font = new Font("맑은 고딕", 11);
                Grid1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                Grid1.RowHeadersVisible = false;
                Grid1.AllowUserToResizeRows = false;  //행높이 변경
                Grid1.RowTemplate.Height = 30;  //기본 행높이를 설정

                //Grid1.Columns.Add(SetColumnImage(gridWRDW11_COLUMN.CHECKFLAG, "√", 40));    //이미지형태의 그리드

                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.WK_DT, "일자", 110));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.ITEM_CD, "품번", 160));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.ITEM_NM, "품명", 180));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.REASON_NM, "불량사유", 140));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.BAD_QTY, "불량", 100));
                

            }

            #endregion
            
            
            #region ■■ 3.1.2 Formatting grid information
            if (p_GridIndex == 1)
            {
                //uniGrid2.flagInformation("cud_flag", "rownum");
                //uniGrid2.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.No);

                Grid1.Columns[grid1_COLUMN.WK_DT].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                Grid1.Columns[grid1_COLUMN.BAD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid1.Columns[grid1_COLUMN.BAD_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태
                

                

            }
            #endregion


            #region ■■ 3.1.3 Setting etc grid
            if (p_GridIndex == 1)
            {
                // Hidden Column Setting

                //Grid1.Columns[grid1_COLUMN.WK_CNT].Visible = false;
            }
            #endregion

            TGSClass.Util.Grid_Resize(Grid1);
        }


        #endregion

        #region ■ 3.2 InitData

        private void InitData()
        {
            // TO-DO: 컨트롤을 초기화(또는 초기값)할때 할일 
            // SetDefaultVal과의 차이점은 전자는 Form_Load 시점에 콘트롤에 초기값을 세팅하는것이고
            // 후자는 특정 시점(조회후 또는 행추가후 등 특정이벤트)에서 초기값을 셋팅한다.

            tDateTerm1.ValueFrom_Datetime = DateTime.Today;
            tDateTerm1.ValueTo_Datetime = DateTime.Today;

            this.cboFacility.Value = sFACILITY_CD;
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
            DBQuery_BadResult();   //불량실적 정보 조회

            return true;
        }

        

        //SQL QUERY를 직접실행하는 구문 예제 , SQL QUERY 또는 프로시저를 TEXT 형태로 넘겨서 실행할 경우
        private void DBQuery_BadResult() //품목의 거래처별 포장대기자재 조회
        {
            int nCnt = 0;
            try
            {
                //LoadingForm(true);




                string strSql = "";
                //strSql = WorkCode.WorkCd.SQLQUERY;
                strSql += "EXEC DBO.XUSP_MES_P3101P1_GET ";
                strSql += "@PLANT_CD='" + sPLANT_CD + "', ";
                strSql += "@WC_MGR='" + sWC_MGR + "', ";
                strSql += "@FACILITY_CD='" + cboFacility.Value + "', ";
                strSql += "@WK_DT_FR = '" + tDateTerm1.ValueFrom + "', ";
                strSql += "@WK_DT_TO = '" + tDateTerm1.ValueTo + "' ";



                DataTable dtData1 = null;
                dtData1 = new DataTable();


                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strSql, ref dtData1, ref nCnt);
                //string strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (@strState.Equals("OK") == false)
                {
                    MessageBox.Show((strState.Substring(2)));

                    //nsUsrFunction.UsrFunction.MessageBoxErr(strState.Substring(2), "불량실적 조회");
                    return;
                }

                
                Grid1.Rows.Clear();

                if (dtData1 != null)
                {


                    for (int i = 0; i < dtData1.Rows.Count; i++)
                    {

                        Grid1.Rows.Add();


                        Grid1.Rows[i].Cells[grid1_COLUMN.WK_DT].Value = dtData1.Rows[i][grid1_COLUMN.WK_DT].ToString(); //일자 
                        Grid1.Rows[i].Cells[grid1_COLUMN.ITEM_CD].Value = dtData1.Rows[i][grid1_COLUMN.ITEM_CD].ToString(); //품번
                        Grid1.Rows[i].Cells[grid1_COLUMN.ITEM_NM].Value = dtData1.Rows[i][grid1_COLUMN.ITEM_NM].ToString(); //품명
                        Grid1.Rows[i].Cells[grid1_COLUMN.REASON_NM].Value = dtData1.Rows[i][grid1_COLUMN.REASON_NM].ToString(); //사유
                        Grid1.Rows[i].Cells[grid1_COLUMN.BAD_QTY].Value = Convert.ToDecimal(dtData1.Rows[i][grid1_COLUMN.BAD_QTY].ToString()).ToString("N0"); //불량
                        

                    }


                }
                TGSClass.Util.Grid_Resize(Grid1);
                                

            }
            catch (Exception e)
            {
                TGSControl.UsrFunction.MessageBoxErr(e.Message, "성형작업 설비별 조회");
            }
            finally
            {
                //LoadingForm(false);
            }
        }
        #endregion 불량실적 조회


        #endregion

        #region ■■ 4.4.2 DBDelete(Single)

        private bool DBDelete()
        {
            //try
            //{
            //    //wsMyBizFL.Service wsDelete = new wsMyBizFL.Service();
            //    //wsDelete.DeleteWebMethod(CommonVariable.gStrGlobalCollection, dsAnyName);

            //    DBSave_CAST("");    //설정된 금형을 제거한다.
            //}
            //catch (Exception ex)
            //{
            //    //bool reThrow = ExceptionControler.AutoProcessException(ex);
            //    //if (reThrow)
            //    //    throw;
            //    return false;
            //}

            return true;
        }

        #endregion

        #region ■■ 4.4.3 DBSave(Common)

        private bool DBSave()
        {

            bool vFlag = false;
            


            return vFlag;

        }


        #endregion  ■■ 4.4.3 DBSave(Common)



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


        private void Form_Resize(object sender, EventArgs e)
        {
            Panel_Doc_s1.Width = windowsForm1.Width - Panel_Doc_s1.Left - Panel_Doc_s1.Left;
            Panel_Doc_s1.Height = windowsForm1.Height - Panel_Doc_s1.Top - Panel_Doc_s1.Left;


        }

        ////생산수량을 증가할 경우
        //private void btn_Qty_Add_ButtonClick(object sender, EventArgs e)
        //{
        //    sEDIT_QTY = sEDIT_QTY + 1;
        //    lbl_EditQty.Value = sEDIT_QTY.ToString("###,###,##0");
        //}
        ////생산수량을 감소할 경우
        //private void btn_Qty_Minus_ButtonClick(object sender, EventArgs e)
        //{
        //    if (sEDIT_QTY > 0)
        //    {
        //        sEDIT_QTY = sEDIT_QTY - 1;
        //        lbl_EditQty.Value = sEDIT_QTY.ToString("###,###,##0");
        //    }
        //}

        

        private void btn_Cancel_ButtonClick(object sender, EventArgs e)//취소버튼
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void btn_Before_Click(object sender, EventArgs e)//이전버튼
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

        private void btn_Next_Click(object sender, EventArgs e)//다음버튼
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

        private void cboFacility_SelectedValueChanged(object sender, EventArgs e)
        {
            DBQuery();
        }

        private void tDateTerm1_EditValue_To(object sender, EventArgs e)
        {
            DBQuery();
        }

        private void btn_Query_ButtonClick(object sender, EventArgs e)
        {
            DBQuery();
        }

        
    }
}
