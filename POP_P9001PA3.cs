﻿using System;
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
    public partial class POP_P9001PA3 : Form
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
            public const string WORKER_ID = "WORKER_ID";
            public const string OP_CD = "OP_CD";
            public const string L_OP_CD = "L_OP_CD";
            public const string M_OP_CD = "M_OP_CD";

            public const string L_OP_NM = "L_OP_NM";
            public const string M_OP_NM = "M_OP_NM";
            public const string OP_NM = "OP_NM";
            public const string UNWORK_START_DT = "UNWORK_START_DT";
            public const string UNWORK_END_DT = "UNWORK_END_DT";
            
        }
        


        #endregion

        #region ■ 1.3. Class global variables (common) //글로벌 변수 선언

        Global global = new Global();
        Form sMainForm;

        string sPLANT_CD = "";      //공장
        //string sITEM_CD = "";        //품번
        //string sITEM_NM = "";       //품명
        string sWC_MGR = "";        //대공정
        //string sWC_CD = "";         //작업장
        string sFACILITY_CD = "";   //설비번호

        //string sWK_ORD_NO = "";     //작업지시번호
        //string sRESULT_NO = "";     //생산실적번호
        string sUNWORK_NO = "";     //비가동실적번호
        string sWORKER_CD = "";     //작업자
        string sOP_CD = "";         //비가동코드
        string sL_OP_CD = "";         //비가동코드
        string sM_OP_CD = "";         //비가동코드

        DateTime sUNWORK_START_DT_ORIGINAL; //비가동 시작시각
        bool sUNWORK_END_FLAG = false; //비가동 종료여부 내역

        string sUNIT_CD = "";       //단말기번호
        
        string sUSER_ID = "POPUSER";   //사용자ID

        
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

        public POP_P9001PA3()
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
                sFACILITY_CD = sResultData.Tables["PassData"].Rows[0]["FACILITY_CD"].ToString();
                sWORKER_CD = sResultData.Tables["PassData"].Rows[0]["WORKER_CD"].ToString();


                sOP_CD = sResultData.Tables["PassData"].Rows[0]["OP_CD"].ToString();
                
                sL_OP_CD = sResultData.Tables["PassData"].Rows[0]["L_OP_CD"].ToString();
                sM_OP_CD = sResultData.Tables["PassData"].Rows[0]["M_OP_CD"].ToString();
                
                lbl_OP_GRP_NM.Value = sResultData.Tables["PassData"].Rows[0]["OP_GRP_NM"].ToString();
                lbl_OP_NM.Value = sResultData.Tables["PassData"].Rows[0]["OP_NM"].ToString();
                sUNWORK_NO = sResultData.Tables["PassData"].Rows[0]["UNWORK_NO"].ToString();
                

            }


        }

        #endregion 

        #region ■ 2.5 Gathering combo data(GatheringComboData) //콤보관련 데이타 설정

        protected void GatheringComboData()
        {


            Fnc_crt_combo(this.cboWorker, "", "WORKER", 0, "작업자", "작업자명", "작업자 선택");  //작업자정보조회

            //Fnc_crt_combo(this.cboSL_CD_FR, "", "SL_CD", 0, "창고", "재고창고명", "재고창고 선택");

            //Fnc_crt_combo(this.cboSL_CD_TO, "", "LOC_NO", -1, "창고", "이동창고명", "이동창고 선택");

            //if (sWC_MGR == "10") cboSL_CD_TO.Value = "CV00";

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
                case "WORKER":    
                     strSql = "EXEC DBO.XUSP_MES_P3101Q1_GET_WORKER ";
                    strSql += "@PLANT_CD='" + sPLANT_CD + "',";
                    strSql += "@WC_MGR='" + sWC_MGR + "'";


                    pValueMember = "USER_ID";
                    pDisplayMember = "EMP_DESC";

                    break;

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
            //    columnHeaderStyle.Font = new Font("맑은 고딕", 14);
            //    Grid1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            //    Grid1.RowHeadersVisible = false;

                

            //    //Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.CHECKFLAG, "√", 40));
            //    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.OP_CD, "비가동코드", 80));
            //    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.M_OP_NM, "구분", 200));
            //    Grid1.Columns.Add(SetColumnEdit(grid1_COLUMN.OP_NM, "비가동명", 220));


            //    #endregion


            //    #region ■■ 3.1.1.2 Formatting grid information

            //    //uniGrid2.flagInformation("cud_flag", "rownum");
            //    //uniGrid2.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.No);

            //    //Grid1.Columns[grid1_COLUMN.INV_QTY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //    //Grid1.Columns[grid1_COLUMN.INV_QTY].DefaultCellStyle.Format = "N0"; //숫자표시형태
                
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

            if (cboWorker.Value != sWORKER_CD)
            {
                cboWorker.Value = sWORKER_CD; // Global.workinfo.szOperatorCD;
            }

            if (sUNWORK_NO == "")   //신규등록
            {
                tDateTime1.Value_Datetime = Convert.ToDateTime(DBQuery_START_DT());  //시작시각 셋팅
                tDateTime2.Value_Datetime = tDateTime1.Value_Datetime;

                tLabel6.Visible = false;
                tDateTime2.Visible = false;

                opt_Start_DT1.ValueChar = "Y";  //현시각
                opt_Start_DT2.ValueChar = "N";  //최근
                opt_Start_DT3.ValueChar = "N";  //수정안함

                opt_Start_DT3.Visible = false;



                btn_Start.Text = "비가동 시작";
            }
            else
            {   //수정일때
                
                //실적번호로 비가동 내역을 조회한다.
                DBQuery_UNWORK(); //비가동정보를 조회한다.



                //조회된 내역이 완료건이면 종료시각 수정가능하게
                if (sUNWORK_END_FLAG)
                {
                    tLabel6.Visible = true;
                    tDateTime2.Visible = true;
                }
                else
                {
                    tLabel6.Visible = false;
                    tDateTime2.Visible = false;
                }

                opt_Start_DT1.ValueChar = "N";  //현시각
                opt_Start_DT2.ValueChar = "N";  //최근
                opt_Start_DT3.ValueChar = "Y";  //수정안함

                opt_Start_DT3.Visible = true;

                btn_Start.Text = "비가동 수정";

            }
            string vCheck = this.CheckingUseSMS();
            chkSendMessage.Checked = vCheck == "N" ? false : true;
            chkSendMessage.Enabled = vCheck == "N" ? false : true;

        }

        private string CheckingUseSMS()
        {
            string vRtnValue = "N"; //디폴트 N
            int nCnt = 0;
            DataTable dtData1 = new DataTable();
            string strSQL = string.Empty;

            strSQL += "SELECT UD_REFERENCE FROM B_USER_DEFINED_MINOR WHERE UD_MAJOR_CD='SMSYN'";
            string strState = TGSClass.DataBase.GetDataSql(sMainForm, strSQL, ref dtData1, ref nCnt);

            if (!strState.Equals("OK"))
            {
            }
            else
            {
                if (dtData1.Rows.Count > 0)
                {
                    vRtnValue = dtData1.Rows[0]["UD_REFERENCE"].ToString();
                }
            }
            return vRtnValue;
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

            //DBQuery_UNWORK();//비가동 조회
            return true;
        }

        #region ▶▶▶ 비가동 조회
        private bool DBQuery_UNWORK()//비가동 조회
        {
            int nCnt = 0;

            try
            {
                //LoadingForm(true);





                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MES_P0401P2_GET_UNWORK ";
                strData += "@UNWORK_NO='" + sUNWORK_NO + "'";

                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);
                //string strState = nsFuncUtil.FuncUtil.GetDataSql(MainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);



                if (!@strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "비가동 조회");
                    return false;
                }


                if (dtData1 != null)
                {
                    //Grid1.DataSource = dtData1;


                    if (dtData1.Rows.Count > 0)
                    {

                        cboWorker.Value = dtData1.Rows[0][grid1_COLUMN.WORKER_ID].ToString(); //작업자

                        sOP_CD = dtData1.Rows[0][grid1_COLUMN.OP_CD].ToString(); //비가동코드 

                        sL_OP_CD = dtData1.Rows[0][grid1_COLUMN.L_OP_CD].ToString(); //비가동코드 
                        sM_OP_CD = dtData1.Rows[0][grid1_COLUMN.M_OP_CD].ToString(); //비가동코드 

                        lbl_OP_GRP_NM.Value = dtData1.Rows[0][grid1_COLUMN.L_OP_NM].ToString() + " > " + dtData1.Rows[0][grid1_COLUMN.M_OP_NM].ToString(); //그룹
                        lbl_OP_NM.Value = dtData1.Rows[0][grid1_COLUMN.OP_NM].ToString(); //비가동명

                        tDateTime1.Value_Datetime = Convert.ToDateTime(dtData1.Rows[0][grid1_COLUMN.UNWORK_START_DT].ToString()); //비가동 시작시각
                        sUNWORK_START_DT_ORIGINAL = Convert.ToDateTime(dtData1.Rows[0][grid1_COLUMN.UNWORK_START_DT].ToString()); //비가동 시작시각

                        if (dtData1.Rows[0][grid1_COLUMN.UNWORK_END_DT].ToString() == "")
                        {
                            sUNWORK_END_FLAG = false;
                            tLabel6.Visible = false;
                            tDateTime2.Visible = false;
                        }
                        else
                        {
                            sUNWORK_END_FLAG = true;
                            tDateTime2.Value_Datetime = Convert.ToDateTime(dtData1.Rows[0][grid1_COLUMN.UNWORK_END_DT].ToString()); //비가동 시작시각
                            tLabel6.Visible = true;
                            tDateTime2.Visible = true;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }




            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "비가동 조회");
            }
            finally
            {
                LoadingForm(false);
            }
            return true;
        }
        #endregion
        #region ▶▶▶ 서버 시간 조회
        private string DBQuery_START_DT()//비가동 시작 시각을 조회
        {
            int nCnt = 0;
            string vDT = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                //LoadingForm(true);


                


                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MES_P0401P2_GET_START_TIME ";

                if (opt_Start_DT1.ValueChar == "Y")
                {
                    strData += "@FLAG='NOW',";   //현재시각
                }
                else if (opt_Start_DT2.ValueChar == "Y")
                {
                    strData += "@FLAG='LASTWKEND',"; //마지막 생산시각
                }
                else
                {
                    strData += "@FLAG='NOW',";   //현재시각
                }
                strData += "@REF_NO1='" + sPLANT_CD +"',";   //공장
                strData += "@REF_NO2='" + sFACILITY_CD + "',";   //설비
                strData += "@UNWORK_NO='" + sUNWORK_NO + "'";   //비가동번호

                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);
                //string strState = nsFuncUtil.FuncUtil.GetDataSql(MainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);



                if (!@strState.Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "시작시각 조회");
                    return vDT;
                }


                if (dtData1 != null)
                {
                    //Grid1.DataSource = dtData1;


                    if (dtData1.Rows.Count > 0)
                    {

                        vDT = dtData1.Rows[0]["DT"].ToString(); //시각반환

                    }
                    else
                    {
                        return vDT;
                    }
                }




            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "비가동 조회");
            }
            finally
            {
                LoadingForm(false);
            }
            return vDT;
        }
        #endregion


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

       
        
        private void btn_Start_ButtonClick(object sender, EventArgs e)
        {

            //비가동 시작 전 문자 메세지 팝업창 띄우기
            //ShowSendMessage();

            if (cboWorker.Value == "")
            {
                TGSControl.UsrFunction.MessageBoxInfo("작업자를 선택하세요", "비가동 등록");
                return;
            }
            if (lbl_OP_NM.Value == "")
            {
                TGSControl.UsrFunction.MessageBoxInfo("비가동 사유를 선택하세요", "비가동 등록");
                return;
            }

            //if (TGSControl.UsrFunction.MessageBoxYesNo("비가동 정보를 시작 하시겠습니까?", "비가동시작") == DialogResult.No)
            //{
            //    return;
            //}

            string v_UNWORK_START_DT = "";
            string v_UNWORK_END_DT = "";

            //시작시각
            if (opt_Start_DT1.Selected == true)   //현시각
            {
                v_UNWORK_START_DT = "";//현시각을 선택하였으면 저장 시 서버의 현 시각을 시작시각으로 함
            }
            else if (opt_Start_DT2.Selected == true)   //최신 전 실적
            {
                v_UNWORK_START_DT = tDateTime1.Value_Datetime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else if (opt_Start_DT3.Selected == true)   //수정안함
            {
                v_UNWORK_START_DT = sUNWORK_START_DT_ORIGINAL.ToString("yyyy-MM-dd HH:mm:ss");  //수정안함 최초값
            }
            else
            {
                v_UNWORK_START_DT = tDateTime1.Value_Datetime.ToString("yyyy-MM-dd HH:mm:ss");  //직접입력
            }


            //종료시각
            if (sUNWORK_END_FLAG == true)
            {
                //완료건을 수정할 때
                v_UNWORK_END_DT = tDateTime2.Value_Datetime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {   //작업중일 때
                v_UNWORK_END_DT = "";
            }

            if (v_UNWORK_START_DT != "NULL" && v_UNWORK_END_DT != "")
            {
                if (Convert.ToDateTime(v_UNWORK_START_DT) > Convert.ToDateTime(v_UNWORK_END_DT))
                {
                    TGSControl.UsrFunction.MessageBoxInfo("종료시각이 시작시각보다 빠릅니다.", "시각수정");
                    return;
                }
            }



            DataTable dt = new DataTable("Result");
            dt.Columns.Add("OP_CD");
            dt.Columns.Add("WORKER_CD");
            dt.Columns.Add("UNWORK_START_DT");
            dt.Columns.Add("UNWORK_END_DT");
            dt.Columns.Add("BOOL_SMS");

            dt.Rows.Add();

            dt.Rows[0]["OP_CD"] = sOP_CD;
            dt.Rows[0]["WORKER_CD"] = cboWorker.Value;
            dt.Rows[0]["BOOL_SMS"] = chkSendMessage.ValueChar;


            //시작시각
            dt.Rows[0]["UNWORK_START_DT"] = v_UNWORK_START_DT;

            //종료시각
            dt.Rows[0]["UNWORK_END_DT"] = v_UNWORK_END_DT;



            sResultData.Tables.Add(dt);

            this.DialogResult = DialogResult.OK;
        }


        private void btn_Close_ButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        
        private void cboWorker_SelectedValueChanged(object sender, EventArgs e)
        {
            sWORKER_CD = cboWorker.Value;
        }

        #endregion  User-defined method part

        private void opt_Start_DT1_SelectedChange(object sender, EventArgs e)
        {
            if (sUNWORK_END_FLAG == true)
            {
                TGSControl.UsrFunction.MessageBoxInfo("종료시각이 있을때는 현시각으로 설정 할 수 없습니다.", "시각수정");
                opt_Start_DT1.Value = 0;
                return;
            }
            else
            {
                opt_Start_DT1.Value = 1;
                opt_Start_DT2.Value = 0;
                opt_Start_DT3.Value = 0;
                tDateTime1.Value_Datetime = Convert.ToDateTime(DBQuery_START_DT());  //시작시각 셋팅
            }
        }

        private void opt_Start_DT2_SelectedChange(object sender, EventArgs e)
        {
            opt_Start_DT1.Value = 0;
            opt_Start_DT2.Value = 1;
            opt_Start_DT3.Value = 0;
            tDateTime1.Value_Datetime = Convert.ToDateTime(DBQuery_START_DT());  //시작시각 셋팅
        }

        private void opt_Start_DT3_SelectedChange(object sender, EventArgs e)
        {
            opt_Start_DT1.Value = 0;
            opt_Start_DT2.Value = 0;
            opt_Start_DT3.Value = 1;
            tDateTime1.Value_Datetime = sUNWORK_START_DT_ORIGINAL;  //기존 시작시각
            
        }


        private void tDateTime1_EditValue(object sender, EventArgs e)
        {   //값을 직접 수정 시
            opt_Start_DT1.Value = 0;
            opt_Start_DT2.Value = 0;
            opt_Start_DT3.Value = 0;
        }


        private void tButton1_ButtonClick(object sender, EventArgs e)
        {
            
            POP_P9001PA4 myForm = new POP_P9001PA4();

            //파라메터를 설정한다.

            DataTable dt = new DataTable("PassData");
            dt.Columns.Add("PLANT_CD");
            dt.Columns.Add("WC_MGR");
            dt.Columns.Add("OP_CD");
            dt.Columns.Add("L_OP_CD");
            dt.Columns.Add("M_OP_CD");


            dt.Rows.Add();

            dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
            dt.Rows[0]["WC_MGR"] = sWC_MGR;
            dt.Rows[0]["OP_CD"] = sOP_CD;
            dt.Rows[0]["L_OP_CD"] = sL_OP_CD;
            dt.Rows[0]["M_OP_CD"] = sM_OP_CD;


            myForm.ResultData.Tables.Add(dt); //변수전달


            myForm.MainForm = this.MainForm;


            myForm.Caption = "비가동 사유 선택";
            myForm.Start(); //시작함수를 실행한다.


            myForm.ShowDialog(); //화면에 표시

            if (myForm.DialogResult == DialogResult.OK)
            {
                sOP_CD = myForm.ResultData.Tables["Result"].Rows[0]["OP_CD"].ToString();
                sL_OP_CD = myForm.ResultData.Tables["Result"].Rows[0]["L_OP_CD"].ToString();
                sM_OP_CD = myForm.ResultData.Tables["Result"].Rows[0]["M_OP_CD"].ToString();
                lbl_OP_NM.Value = myForm.ResultData.Tables["Result"].Rows[0]["OP_NM"].ToString();
                lbl_OP_GRP_NM.Value = myForm.ResultData.Tables["Result"].Rows[0]["OP_GRP_NM"].ToString();

            }

        }

        private void POP_P0401P2_Activated(object sender, EventArgs e)
        {
            windowsForm1.BorderColor = Color.DarkOrange;
        }

        private void POP_P0401P2_Deactivate(object sender, EventArgs e)
        {
            windowsForm1.BorderColor = Color.Gray;
        }

        

        

    }
}
