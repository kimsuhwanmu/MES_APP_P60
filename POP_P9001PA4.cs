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
    public partial class POP_P9001PA4 : Form
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


        public struct grid1_COLUMN
        {
            //public const string CHECKFLAG = "CHKFLAG";          
            public const string L_OP_CD = "L_OP_CD";            //대분류
            public const string M_OP_CD = "M_OP_CD";            //중분류
            public const string M_OP_NM = "M_OP_NM";            //분류명
        }


        public struct grid2_COLUMN
        {
            //public const string CHECKFLAG = "CHKFLAG";
            public const string OP_CD = "OP_CD";
            public const string OP_NM = "OP_NM";
        }


        #endregion

        #region ■ 1.3. Class global variables (common) //글로벌 변수 선언

        Global global = new Global();
        Form sMainForm;

        string sPLANT_CD = "";      //공장
        string sITEM_CD = "";        //품번
        string sITEM_NM = "";       //품명
        string sWC_MGR = "";        //대공정
        string sWC_CD = "";         //작업장
        String sFACILITY_CD = "";   //설비번호

        //string sWK_ORD_NO = "";     //작업지시번호
        //string sRESULT_NO = "";     //생산실적번호
        string sWORKER_CD = "";     //작업자

        string sUNIT_CD = "";       //단말기번호
        
        string sUSER_ID = "POPUSER";   //사용자ID

        string sOP_CD = "";         //비가동코드
        string sL_OP_CD = "";         //비가동코드
        string sM_OP_CD = "";         //비가동코드


        DataSet sResultData = new DataSet();

        int sGrid_Current_id = 1;


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

        public POP_P9001PA4()
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
                //sWC_CD = sResultData.Tables["PassData"].Rows[0]["WC_CD"].ToString();
                sPLANT_CD = sResultData.Tables["PassData"].Rows[0]["PLANT_CD"].ToString();
                sWC_MGR = sResultData.Tables["PassData"].Rows[0]["WC_MGR"].ToString();
                //sFACILITY_CD = sResultData.Tables["PassData"].Rows[0]["FACILITY_CD"].ToString();
                //sWORKER_CD = sResultData.Tables["PassData"].Rows[0]["WORKER_CD"].ToString();

                sL_OP_CD = sResultData.Tables["PassData"].Rows[0]["L_OP_CD"].ToString();
                sM_OP_CD = sResultData.Tables["PassData"].Rows[0]["M_OP_CD"].ToString();
                sOP_CD = sResultData.Tables["PassData"].Rows[0]["OP_CD"].ToString();

                


            }


        }

        #endregion

        #region ■ 2.5 Gathering combo data(GatheringComboData) //콤보관련 데이타 설정

        protected void GatheringComboData()
        {

            DBQuery_unWORK_GET_OP_CD();     //매트릭스 버튼 비가동 대분류 정보조회

            
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
                
        //        case "WORKER":    // 작업자 
        //            strSql = "EXEC DBO.XUSP_MES_P3101Q1_GET_WORKER ";
        //            strSql += "@PLANT_CD='" + sPLANT_CD + "',";
        //            strSql += "@WC_MGR='" + sWC_MGR + "'";


        //            pValueMember = "USER_ID";
        //            pDisplayMember = "EMP_DESC";

        //            break;
        //        //case "UD_MAJOR_CD":    // 사용자정의-공통코드..
        //        //    strSql = " SELECT DISTINCT RTRIM(AA.code) AS code, RTRIM(AA.name) AS name ";
        //        //    strSql += " FROM ( ";
        //        //    strSql += " SELECT  '1' AS LVL, '' AS code, '' AS name ";
        //        //    strSql += " UNION ALL ";
        //        //    strSql += " SELECT '2' AS LVL, RTRIM(AA.UD_MINOR_CD) AS code, RTRIM(AA.UD_MINOR_NM) AS name ";
        //        //    strSql += " FROM B_USER_DEFINED_MINOR AA (NOLOCK) ";
        //        //    strSql += " WHERE RTRIM(AA.UD_MAJOR_CD) = RTRIM('" + @MAJOR_CD + "')  ) AA ";
        //        //    strSql += " WHERE AA.LVL = '2' ";
        //        //    break;


        //        //default:    // 공통코드..
        //        //    strSql = " SELECT DISTINCT RTRIM(AA.code) AS code, RTRIM(AA.name) AS name ";
        //        //    strSql += " FROM ( ";
        //        //    strSql += " SELECT  '1' AS LVL, '' AS code, '' AS name ";
        //        //    strSql += " UNION ALL ";
        //        //    strSql += " SELECT '2' AS LVL, RTRIM(AA.MINOR_CD) AS code, RTRIM(AA.MINOR_NM) AS name ";
        //        //    strSql += " FROM B_MINOR AA (NOLOCK) ";
        //        //    strSql += " WHERE RTRIM(AA.MAJOR_CD) = RTRIM('" + @MAJOR_CD + "')  ) AA ";
        //        //    break;
        //    }
        //    try
        //    {
        //        int nCnt = 0;
        //        string strState = TGSClass.DataBase.GetDataSql(sMainForm, strSql, ref dtData1, ref nCnt);

        //        //strSql = WorkCode.WorkCd.SQLQUERY + strSql;
        //        //string strState = nsFuncUtil.FuncUtil.GetDataSql(this.MainForm, strSql, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);

        //    }
        //    catch (Exception ex)
        //    {
        //        //TGSControl.UsrFunction.MessageBoxErr(ex.Message, "기준정보조회");

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
            InitSpreadSheet(2);
        }

        private void InitSpreadSheet(int p_GridIndex)   //선택된 스프레드시트를 초기화 한다.
        {




            

            #region ▶▶▶ 3.1.1 GRID2 설정

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

                //Grid1.Columns.Add(SetColumnImage(Grid1_COLUMN.CHECKFLAG, "√", 40));    //이미지형태의 그리드


                //Grid1.Columns.Add(SetColumnImage(grid1_COLUMN.CHECKFLAG, "√", 40));
                //Grid1.Columns.Add(SetColumnEdit(Grid1_COLUMN.CHECK_DT, "점검일", 100));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.L_OP_CD, "대분류", 100));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.M_OP_CD, "중분류", 100));
                Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.M_OP_NM, "분류명", 180));

                #endregion


                #region ■■ 3.1.1.2 Formatting grid information
                //Grid1.Columns[Grid1_COLUMN.WK_DT].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //Grid1.Columns[Grid1_COLUMN.WK_ORD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[Grid1_COLUMN.PROD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid1.Columns[Grid1_COLUMN.WK_ORD_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태
                //Grid1.Columns[Grid1_COLUMN.PROD_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태


                #endregion


                #region ■■ 3.1.1.3 Setting etc grid

                // Hidden Column Setting
                //Grid1.Columns[Grid1_COLUMN.SEQ].Visible = false;
                //Grid1.Columns[Grid1_COLUMN.PRODT_ORDER_NO].Visible = false;


                #endregion

            }

            #endregion

            #region ▶▶▶ 3.1.2 GRID2 설정

            if (p_GridIndex == 2)
            {
                #region ■■ 3.1.2.1 Pre-setting grid information

                /*** grid2
                     *  실적조회
                     * **/
                Grid2.Columns.Clear();


                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Beige;
                columnHeaderStyle.Font = new Font("맑은 고딕", 14);
                Grid2.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                Grid2.RowHeadersVisible = false;

                //Grid2.Columns.Add(SetColumnImage(Grid2_COLUMN.CHECKFLAG, "√", 40));    //이미지형태의 그리드


                //Grid2.Columns.Add(SetColumnImage(grid2_COLUMN.CHECKFLAG, "√", 40));
                //Grid2.Columns.Add(SetColumnEdit(Grid2_COLUMN.CHECK_DT, "점검일", 100));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.OP_CD, "소분류", 100));
                Grid2.Columns.Add(SetColumnEdit(grid2_COLUMN.OP_NM, "분류명", 280));


                #endregion


                #region ■■ 3.1.2.2 Formatting grid information
                //Grid2.Columns[Grid2_COLUMN.WK_DT].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //Grid2.Columns[Grid2_COLUMN.WK_ORD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid2.Columns[Grid2_COLUMN.PROD_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //Grid2.Columns[Grid2_COLUMN.WK_ORD_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태
                //Grid2.Columns[Grid2_COLUMN.PROD_QTY].DefaultCellStyle.Format = "N0";   //숫자표시형태


                #endregion


                #region ■■ 3.1.2.3 Setting etc grid

                // Hidden Column Setting
                //Grid2.Columns[Grid2_COLUMN.SEQ].Visible = false;
                //Grid2.Columns[Grid2_COLUMN.PRODT_ORDER_NO].Visible = false;

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

            if (sL_OP_CD != "")
            {
                tMatrixButtonV1.Value = sL_OP_CD;
                tMatrixButtonV1_ButtonClick(null, null);


                for (int i = 0; i < Grid1.Rows.Count; i++)
                {
                    if (Grid1.Rows[i].Cells[grid1_COLUMN.M_OP_CD].Value.ToString() == sM_OP_CD)
                    {
                        Grid1.Rows[i].Selected = true;
                        Grid1.Rows[i].Cells[grid1_COLUMN.M_OP_NM].Selected = true;
                        Grid1_CellClick(null, null);

                        for (int j = 0; j < Grid2.Rows.Count; j++)
                        {
                            if (Grid2.Rows[j].Cells[grid2_COLUMN.OP_CD].Value.ToString() == sOP_CD)
                            {
                                Grid2.Rows[j].Selected = true;
                                Grid2.Rows[j].Cells[grid2_COLUMN.OP_CD].Selected = true;
                                break;
                            }
                        }
                        break;

                    }

                }

            }

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

        ////그리드 버튼 컬럼 생성
        //private DataGridViewColumn SetColumnButton(string ColumnName, string HeaderText, int Width) //그리드 버튼 생성한다.
        //{
        //    DataGridViewButtonColumn myCol = new DataGridViewButtonColumn();

        //    //DataGridViewComboBoxColumn


        //    myCol.Name = ColumnName; myCol.HeaderText = HeaderText; myCol.Width = Width;


        //    DataGridViewButtonCell myCell = new DataGridViewButtonCell();
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
            

            return true;
        }



        private void DBQuery_unWORK_GET_OP_CD() //UNIT에 설정되어 있는 설비리스트를 가져온다.   //매트릭스 버튼 안에 조회해서 캡션이 나올수 있더럭 하는부분 비가동코드 대분류 조회 쿼리 넣을것!
        {
            int nCnt = 0;
            try
            {
                //LoadingForm(true);

                string strSql = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strSql += "EXEC DBO.XUSP_MES_P0401M1_GET_OP_CD ";

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
                        int te = dsTmp.Tables[0].Rows.Count;
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

                //string strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (@strState.Equals("OK") == false)
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "비가동 대분류 버튼");
                    return;
                }



                if (dtData1 != null)
                {
                    tMatrixButtonV1.Clear();

                    for (int i = 0; i < dtData1.Rows.Count; i++)
                    {
                        if (dtData1.Rows[i]["UD_MINOR_CD"].ToString() != "")
                        {

                            tMatrixButtonV1.AddItem(dtData1.Rows[i]["UD_MINOR_CD"].ToString(),  //대분류 코드
                                                    dtData1.Rows[i]["UD_MINOR_NM"].ToString()  //비가동 대분류 명

                                                    );

                        }
                        //else
                        //{
                        //    tMatrixButtonV1.AddItem(dtData1.Rows[i]["WC_CD"].ToString(),        //설비번호 = 작업장
                        //                            dtData1.Rows[i]["WC_NM"].ToString(),        //설비명   = 작업장명
                        //                            dtData1.Rows[i]["WC_CD"].ToString(),        //작업장
                        //                            dtData1.Rows[i]["WC_NM"].ToString(),        //작업장명
                        //                            ""                                          //작업자
                        //                            );
                        //}

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
                TGSControl.UsrFunction.MessageBoxErr(e.Message, "비가동 대분류 버튼 조회");
            }
            finally
            {
                //LoadingForm(false);

            }
        }

        //매트릭스 버튼 클릭시
        private void tMatrixButtonV1_ButtonClick(object sender, EventArgs e)
        {
            if (tMatrixButtonV1.Value == "") return;

            int nCnt = 0;

            try
            {

                LoadingForm(true);

                FuncL_OP(tMatrixButtonV1.Value.ToString());

                //nsGridUtil.GridUtil.SetGridClear(Grid2);
                //nsGridUtil.GridUtil.SetGridClear(Grid3);
                Grid1.Rows.Clear();
                Grid2.Rows.Clear();
                btn_Start.Enabled = false;

                string strData = "";
                //strData = WorkCode.WorkCd.STOPWORK_M_REVIEW;
                //strData += sPLANT_CD + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //strData += sWC_MGR + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //strData += tMatrixButtonV1.Value.ToString();

                strData = ""
                            + "SELECT T1.L_OP_CD,T1.M_OP_CD, T2.UD_MINOR_NM AS M_OP_NM  "
                            + " FROM MES_P_OP_CD_M  AS T1 (NOLOCK) "
                            + " LEFT OUTER JOIN B_USER_DEFINED_MINOR AS T2 (NOLOCK) ON T2.UD_MAJOR_CD = 'PD102' AND T1.M_OP_CD = T2.UD_MINOR_CD "
                            + " WHERE T1.PLANT_CD = '" + sPLANT_CD + " '"
                            + "  AND WC_MGR = '" + sWC_MGR + "'"
                            + "  AND T1.L_OP_CD  = '" + tMatrixButtonV1.Value.ToString() + "'"  // --@L_OP_CD
                            + "  AND T1.WORK_YN  = 'Y'"
                            + "  AND T1.USE_YN   = 'Y'";


                DataTable dtData1 = null;
                dtData1 = new DataTable();


                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);



                //string strState = nsFuncUtil.FuncUtil.GetDataSql(this.sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (!strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "중분류조회");
                    return;
                }

                //if (dtData1 == null || dtData1.Rows.Count <= 0)
                //{
                //    LoadingForm(false);
                //    TGSControl.UsrFunction.MessageBoxErr("조회할 데이타가 존재하지 않습니다.", "중분류조회");
                //    return;
                //}

                //System.Drawing.Image imgChecked = Properties.Resources.CheckBoxUnChecked;
                //imgChecked.Tag = "N";

                for (int i = 0; i < dtData1.Rows.Count; i++)
                {
                    this.Grid1.Rows.Add();

                    //Grid1.SetCellImage(Grid2.Rows.Fixed + i, Grid2.Cols.Fixed + 0, imgChecked);  //1.체크 

                    Grid1.Rows[i].Cells[grid1_COLUMN.L_OP_CD].Value = dtData1.Rows[i][grid1_COLUMN.L_OP_CD].ToString();             //대분류
                    Grid1.Rows[i].Cells[grid1_COLUMN.M_OP_CD].Value = dtData1.Rows[i][grid1_COLUMN.M_OP_CD].ToString();              //중분류    
                    Grid1.Rows[i].Cells[grid1_COLUMN.M_OP_NM].Value = dtData1.Rows[i][grid1_COLUMN.M_OP_NM].ToString();          //중분류명

                }
            }
            catch (Exception se)
            {
            }
            finally
            {
                LoadingForm(false);
            }

        }

        private void FuncL_OP(string szLOP)
        {
            tMatrixButtonV1.BackColor = Color.Transparent;
            switch (szLOP)
            {
                //case "01": tMatrixButtonV1.RowIndex = Color.Red; break;
                //case "02": btnTroubleStop.BackColor = Color.Red; break;
                //case "03": btnQulityProblem.BackColor = Color.Red; break;
                //case "04": btnPreparatoryDelay.BackColor = Color.Red; break;
                //case "05": btnSample.BackColor = Color.Red; break;
                //case "06": btnWorkerShortSupply.BackColor = Color.Red; break;
            }
        }


        private void Grid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DBQuery_StopWork_S_RetriveData();
        }


        private void DBQuery_StopWork_S_RetriveData()       //grid1에서 셀을 선택했을때 소분류 조회 하는 쿼리
        {
            int nCnt = 0;
            try
            {

                if (Grid1.CurrentRow == null)
                {
                    TGSControl.UsrFunction.MessageBoxErr("중분류를 선택 하세요.", "소분류조회");
                    return;
                }


                LoadingForm(true);


                //nsGridUtil.GridUtil.SetGridClear(gridS_OP);
                Grid2.Rows.Clear();
                btn_Start.Enabled = false;


                string strData = "";
                //strData = WorkCode.WorkCd.STOPWORK_S_REVIEW;
                //strData += sPLANT_CD + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //strData += sWC_MGR + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //strData += Grid2.CurrentRow.Cells[grid2_COLUMN.L_OP_CD].Value.ToString() + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //strData += Grid2.CurrentRow.Cells[grid2_COLUMN.M_OP_CD].Value.ToString();

                strData = ""
                            + "SELECT T1.OP_CD,"
                            + "        T3.UD_MINOR_NM AS OP_NM"
                            + " FROM MES_P_OP_CD AS T1 (NOLOCK)"
                            + " LEFT OUTER JOIN B_USER_DEFINED_MINOR AS T3 (NOLOCK) ON T3.UD_MAJOR_CD = 'PD101' AND T1.OP_CD = T3.UD_MINOR_CD"
                            + " LEFT OUTER JOIN MES_P_OP_CD_M  AS T2 (NOLOCK)"
                            + "   ON T1.PLANT_CD= T2.PLANT_CD"
                            + "  AND T1.WC_MGR= T2.WC_MGR"
                            + "  AND T1.L_OP_CD= T2.L_OP_CD"
                            + "  AND T1.M_OP_CD= T2.M_OP_CD"
                            + "  AND T2.WORK_YN= 'Y'"
                            + "  AND T2.USE_YN= 'Y'"
                            + " WHERE T1.PLANT_CD = '" + sPLANT_CD + "'"
                            + "  AND T1.WC_MGR= '" + sWC_MGR + "'" //--@WC_MGR
                            + "  AND T1.L_OP_CD= '" + Grid1.CurrentRow.Cells[grid1_COLUMN.L_OP_CD].Value.ToString() + "'" //--@L_OP_CD
                            + "  AND T1.M_OP_CD= '" + Grid1.CurrentRow.Cells[grid1_COLUMN.M_OP_CD].Value.ToString() + "'"  //--@M_OP_CD
                            + "  AND T2.WORK_YN= 'Y'"
                            + "  AND T2.USE_YN= 'Y'"
                            + " ORDER BY T1.OP_CD";


                DataTable dtData1 = null;
                dtData1 = new DataTable();


                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);


                //string strState = nsFuncUtil.FuncUtil.GetDataSql(this.sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);

                if (!strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "소분류조회");
                    return;
                }

                //if (dtData1 == null || dtData1.Rows.Count <= 0)
                //{
                //    LoadingForm(false);
                //    TGSControl.UsrFunction.MessageBoxErr("조회할 데이타가 존재하지 않습니다.", "소분류조회");
                //    return;
                //}

                //System.Drawing.Image imgChecked = Properties.Resources.CheckBoxUnChecked;
                //imgChecked.Tag = "N";
                if (dtData1.Rows.Count > 0)
                {
                    for (int i = 0; i < dtData1.Rows.Count; i++)
                    {
                        this.Grid2.Rows.Add();

                        //gridS_OP.SetCellImage(gridS_OP.Rows.Fixed + i, gridS_OP.Cols.Fixed + 0, imgChecked);  //1.체크 

                        Grid2.Rows[i].Cells[grid2_COLUMN.OP_CD].Value = dtData1.Rows[i][grid2_COLUMN.OP_CD].ToString();             //소분류
                        Grid2.Rows[i].Cells[grid2_COLUMN.OP_NM].Value = dtData1.Rows[i][grid2_COLUMN.OP_NM].ToString();              //소분류명   
                    }

                    btn_Start.Enabled = true;
                }


            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "소분류조회");
            }
            finally
            {
                LoadingForm(false);
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

       
        


        #endregion  User-defined method part

        private void btn_Start_ButtonClick(object sender, EventArgs e)
        {
            
            if (Grid2.CurrentRow == null)
            {
                TGSControl.UsrFunction.MessageBoxInfo("비가동 사유를 선택하세요", "비가동 등록");
                return;
            }

            //if (TGSControl.UsrFunction.MessageBoxYesNo("비가동 정보를 시작 하시겠습니까?", "비가동시작") == DialogResult.No)
            //{
            //    return;
            //}


            DataTable dt = new DataTable("Result");
            dt.Columns.Add("OP_CD");
            dt.Columns.Add("L_OP_CD");
            dt.Columns.Add("M_OP_CD");
            dt.Columns.Add("OP_NM");
            dt.Columns.Add("OP_GRP_NM");

            dt.Rows.Add();

            dt.Rows[0]["OP_CD"] = Grid2.CurrentRow.Cells[grid2_COLUMN.OP_CD].Value.ToString(); ;
            dt.Rows[0]["L_OP_CD"] = Grid1.CurrentRow.Cells[grid1_COLUMN.L_OP_CD].Value.ToString();
            dt.Rows[0]["M_OP_CD"] = Grid1.CurrentRow.Cells[grid1_COLUMN.M_OP_CD].Value.ToString();
            dt.Rows[0]["OP_NM"] = Grid2.CurrentRow.Cells[grid2_COLUMN.OP_NM].Value.ToString();
            dt.Rows[0]["OP_GRP_NM"] = tMatrixButtonV1.ValueName + " > " + Grid1.CurrentRow.Cells[grid1_COLUMN.M_OP_NM].Value.ToString(); ;
            


            sResultData.Tables.Add(dt);

            this.DialogResult = DialogResult.OK;
        }



        //행의 첫 시작 위치를 선택할 때 row위치가 visible = false 이면 오류 발생함으로 visible 여부를 체크 함
        private int GetFirstRowIndex(int pRowIndex)
        {
            int i = 0;

            for (i = pRowIndex; i < Grid1.Rows.Count; i++)
            {
                if (Grid1.Rows[i].Visible == true)
                {
                    break;
                }
            }

            return i;
        }

        private void btn_Before_ButtonClick(object sender, EventArgs e)
        {
            if (sGrid_Current_id == 1)
            {
                int vDisplayedRowCount = Grid1.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid1.FirstDisplayedScrollingRowIndex - vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex <= 0)
                        Grid1.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(0);
                    else
                        Grid1.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid1.FirstDisplayedScrollingRowIndex - vDisplayedRowCount);
                }
            }
            if (sGrid_Current_id == 2)
            {
                int vDisplayedRowCount = Grid2.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid2.FirstDisplayedScrollingRowIndex - vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex <= 0)
                        Grid2.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(0);
                    else
                        Grid2.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid2.FirstDisplayedScrollingRowIndex - vDisplayedRowCount);
                }
            }
        }

        private void btn_Next_ButtonClick(object sender, EventArgs e)
        {
            if (sGrid_Current_id == 1)
            {
                int vDisplayedRowCount = Grid1.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid1.FirstDisplayedScrollingRowIndex + vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex >= Grid1.Rows.Count)
                        Grid1.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid1.Rows.Count - 1);
                    else
                        Grid1.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(vFirstDisplayedScrollingRowIndex);
                }
            }
            if (sGrid_Current_id == 2)
            {
                int vDisplayedRowCount = Grid2.DisplayedRowCount(false);
                if (vDisplayedRowCount > 0)
                {
                    int vFirstDisplayedScrollingRowIndex = Grid2.FirstDisplayedScrollingRowIndex + vDisplayedRowCount;

                    if (vFirstDisplayedScrollingRowIndex >= Grid2.Rows.Count)
                        Grid2.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(Grid2.Rows.Count - 1);
                    else
                        Grid2.FirstDisplayedScrollingRowIndex = GetFirstRowIndex(vFirstDisplayedScrollingRowIndex);
                }
            }
        }

        private void Grid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Start.Enabled = true;
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
