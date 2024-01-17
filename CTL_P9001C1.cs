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
using static TGSClass.nsGlobal.Global;

namespace MES_APP_P90
{
    public partial class CTL_P9001C1 : UserControl
    {
        public CTL_P9001C1()
        {
            InitializeComponent();

        }

        DateTime sSTART_DT;
        DateTime sSERVER_DT;
        TimeSpan sTimeDiff;

        Form sMainForm;
        Global global = new Global();
        object sObject;

        string sPLANT_CD = "";
        string sWC_MGR = "";
        string sFACILITY_CD = "";
        string sWC_CD = "";
        string sWORKER_CD = "";

        int sTimerCount = 0;

        string sOP_CD = ""; //비가동 코드
        string sUNWORK_NO = ""; //비가동 실적번호

        string sL_OP_CD = ""; //비가동 대분류 코드
        string sM_OP_CD = ""; //비가동 중분류 코드

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

        public object Object_Enable    //활성화 / 비활성화 할 오브젝트
        {
            get
            {
                return sObject;
            }
            set
            {
                sObject = value;
            }
        }

        public string OP_NM
        {
            set
            {
                

                lbl_UNWORK_NM.Text = value;  //비가동 사유

                if (value == "")
                {
                    

                    timer1.Enabled = false;
                    if (this.Parent != null)
                    {
                        this.Parent.Visible = false;
                    }

                    if (sObject != null)
                    {
                        TabPage myTabPage = new TabPage();
                        if (sObject.GetType() == myTabPage.GetType())
                        {
                            myTabPage = (TabPage)sObject;
                            myTabPage.Enabled = true;
                        }
                    }

                }
                else
                {
                    //timer1.Enabled = true;
                    if (this.Parent != null)
                    {
                        this.Parent.Visible = true;
                    }
                    
                    if (sObject != null)
                    {
                        TabPage myTabPage = new TabPage();
                        if (sObject.GetType() == myTabPage.GetType())
                        {
                            myTabPage = (TabPage)sObject;
                            myTabPage.Enabled = false;
                        }
                    }
                }
            }
        }

        public string START_DT
        {
            set
            {
                if (value.Length == 19)
                {
                    sSTART_DT = Convert.ToDateTime(value);  //비가동 시간
                    if (lbl_UNWORK_NM.Text == "")
                    {
                        timer1.Enabled = false;
                    }
                    else
                    {
                        timer1.Enabled = true;
                    }
                }
                
            }
        }
        public string SERVER_DT //서버시간
        {
            set
            {
                if (value.Length == 19)
                {
                    sSERVER_DT = Convert.ToDateTime(value);  //서버 시간

                    sTimeDiff = DateTime.Now - sSERVER_DT;
                }

            }
        }
        public string UNWORK_NO
        {
            
            get
            {
                return sUNWORK_NO;
            }
        }
        public string OP_CD
        {
            
            get
            {
                return sOP_CD;
            }
            set
            {
                if (value != sOP_CD && value != "")
                {
                    if (DBQuery_UNWORK_COUNT(value))
                    {
                        tButton1.Visible = true;
                    }
                    else
                    {
                        tButton1.Visible = false;
                    }
                }
                sOP_CD = value;
            }
        }
        public string L_OP_CD
        {

            get
            {
                return sL_OP_CD;
            }
            set
            {
                sL_OP_CD = value;
            }
        }
        public string M_OP_CD
        {

            get
            {
                return sM_OP_CD;
            }
            set
            {
                sM_OP_CD = value;
            }
        }

        public string FACILITY_CD
        {
            set
            {
                sFACILITY_CD = value;
            }
            get
            {
                return sFACILITY_CD;
            }
        }
        public string WC_CD
        {
            set
            {
                sWC_CD = value;
            }
            get
            {
                return sWC_CD;
            }
        }
        public string WORKER_CD
        {
            set
            {
                sWORKER_CD = value;
            }
            get
            {
                return sWORKER_CD;
            }
        }

        public bool DBQuery(string pPLANT_CD, string pFACILITY_CD, string pWC_MGR, string pWC_CD, string pWORKER_CD)
        {

            

            sWC_MGR = pWC_MGR;
            sWC_CD = pWC_CD;
            sWORKER_CD = pWORKER_CD;
            
            bool vbool = DBQuery(pPLANT_CD, pFACILITY_CD);
            
            return vbool;

        }

        public bool DBQuery(string pPLANT_CD, string pFACILITY_CD ) //UNIT에 설정되어 있는 설비리스트를 가져온다.   //매트릭스 버튼 안에 조회해서 캡션이 나올수 있더록 하는부분 비가동코드 대분류 조회 쿼리 넣을것!
        {

            sPLANT_CD = pPLANT_CD;
            sFACILITY_CD = pFACILITY_CD;


            int nCnt = 0;
            bool vReturn = false;

            try
            {

                if (Global.workinfo.szServerIP == null || Global.workinfo.szServerIP == "")
                {
                    global.ConfigFileReadAll();
                }

                //LoadingForm(true);

                string strData = "";
                //strData = WorkCode.WorkCd.STOPWORK_FAC_INFO;
                
                ////strData += "EXEC DBO.XUSP_MES_P0401M1_GET_OP_CD ";
                //strData += pPLANT_CD + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //strData += pFACILITY_CD;

                strData = "";
             strData += "EXEC DBO.XUSP_MESSVR_SW_FAC_INFO_GET ";
                strData += " @PLANT_CD='" + pPLANT_CD + "',";  //공장
                strData += " @FACILITY_CD='" + pFACILITY_CD + "'";  //설비코드


                DataTable dtData1 = null;
                dtData1 = new DataTable();


                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);


                //string strState = nsFuncUtil.FuncUtil.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);
                if (@strState.Equals("OK") == false)
                {
                    //TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "설비 비가동");
                    vReturn = false;
                }

                if (dtData1 != null)
                {

                    if (dtData1.Rows[0]["OP_NM"].ToString() != "")
                    {
                        if (this.Parent != null)
                        {
                            this.Parent.Top = (sMainForm.Height - this.Parent.Height) / 2;
                            this.Parent.Left = (sMainForm.Width - this.Parent.Width) / 2;
                        }
                        this.OP_NM = dtData1.Rows[0]["OP_NM"].ToString();  //비가동 명

                        lbl_UNWORK_NM.Left = (this.Width - this.lbl_UNWORK_NM.Width) / 2;

                        this.SERVER_DT = dtData1.Rows[0]["SERVER_DT"].ToString();  //서버시각
                        this.START_DT = dtData1.Rows[0]["START_DT"].ToString();  //시작일자
                        sUNWORK_NO = dtData1.Rows[0]["UNWORK_NO"].ToString();  //비가동실적번호
                        this.OP_CD = dtData1.Rows[0]["OP_CD"].ToString();  //비가동코드
                        //this.L_OP_CD = dtData1.Rows[0]["L_OP_CD"].ToString();  //비가동대코드
                        //this.M_OP_CD = dtData1.Rows[0]["M_OP_CD"].ToString();  //비가동중코드
                        if (this.Parent != null)
                        {
                            this.Parent.Visible = true;
                        }
                        vReturn = true;
                        btn_End.Visible = true;
                    }
                    else
                    {
                        this.OP_NM = "";
                        sUNWORK_NO = "";
                        this.OP_CD = "";
                        if (this.Parent != null)
                        {
                            this.Parent.Visible = false;
                        }
                        vReturn = false;
                    }
                        
                   
                }


            }
            catch (Exception e)
            {
                TGSControl.UsrFunction.MessageBoxErr(e.Message, "설비 비가동 조회");
                vReturn = false;
            }
            finally
            {
                //LoadingForm(false);
            }
            return vReturn;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - sSTART_DT; // = local시간 - (서버차이시간) - 시작시간
            ts = ts - sTimeDiff;
            
            if (ts.Hours > 0)
            {
                if (ts.Days > 0)
                {
                    lbl_UNWORK_TIME.Text = "경과시간 : " + ts.Days.ToString() + "일" + ts.Hours.ToString() + "시간" + ts.Minutes.ToString() + "분";
                }
                else
                {
                    lbl_UNWORK_TIME.Text = "경과시간 : " + ts.Hours.ToString() + "시간" + ts.Minutes.ToString() + "분" + ts.Seconds.ToString() + "초";
                }
            }
            else
            {
                if (ts.Minutes > 0)
                {
                    lbl_UNWORK_TIME.Text = "경과시간 : " + ts.Minutes.ToString() + "분 " + ts.Seconds.ToString() + "초";
                }
                else
                {
                    lbl_UNWORK_TIME.Text = "경과시간 : " + ts.Seconds.ToString() + "초";
                }
            }

            if (sTimerCount > 100)
            {
                sTimerCount = 0;
                DBQuery(sPLANT_CD, sFACILITY_CD);
            }
            else
            {
                sTimerCount = sTimerCount + 1;
            }

        }

        private void btn_End_ButtonClick(object sender, EventArgs e)
        {
            if (TGSControl.UsrFunction.MessageBoxYesNo("비가동 정보를 종료하시겠습니까?", "비가동종료") == DialogResult.No)
            {
                return;
            }

            DBSave_UNWORK_END();
        }

        private bool DBSave_UNWORK_END()
        {
            try
            {

                

                LoadingForm(true);



                //string szSendData = WorkCode.WorkCd.STOPWORK_END;
                //szSendData += sPLANT_CD + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //szSendData += sWC_MGR + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //szSendData += sFACILITY_CD + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //szSendData += sWORKER_CD + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //szSendData += "" + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //szSendData += "" + nsWinUtilGlobal.Global.Separation.COLUMNS;

                //szSendData += sUNWORK_NO + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //szSendData += sOP_CD + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //szSendData += sSTART_DT.ToString("yyyy-MM-dd HH:mm:ss") + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //szSendData += sWC_CD + nsWinUtilGlobal.Global.Separation.COLUMNS;


                //string strState = nsFuncUtil.FuncUtil.ExcuteSql(this.sMainForm, szSendData, Global.workinfo.szServerIP, Global.workinfo.szPortNo);


                string strData = "";
                strData += "dbo.USP_MES_P_UNWORK_SAVE";       //프로시져 명
                strData += Global.COLUMNS_DIV + "N" + Global.Separation.COLUMNS;   //조회데이타가 없을 경우 'N' = nonquery 있을 경우 'Q' = query
                //일반변수 리스트
                strData += "@SAVE_FLAG" + Global.COLUMNS_DIV;
                strData += "@PLANT_CD" + Global.COLUMNS_DIV;
                strData += "@UNWORK_NO" + Global.COLUMNS_DIV;
                strData += "@UNWORK_START_DT" + Global.COLUMNS_DIV;
                strData += "@UNWORK_END_DT" + Global.COLUMNS_DIV;

                strData += "@WC_MGR" + Global.COLUMNS_DIV;
                strData += "@WC_CD" + Global.COLUMNS_DIV;
                strData += "@FACILITY_CD" + Global.COLUMNS_DIV;
                strData += "@OP_CD" + Global.COLUMNS_DIV;

                strData += "@UNWORK_MIN" + Global.COLUMNS_DIV;
                strData += "@WK_ORD_NO" + Global.COLUMNS_DIV;
                strData += "@RESULT_NO" + Global.COLUMNS_DIV;
                strData += "@USER_ID" + Global.COLUMNS_DIV;
                strData += "@NEW_UNWORK_NO" + Global.COLUMNS_DIV;

                strData += "@RTN_MSG" + Global.Separation.COLUMNS;
                //strData += "@RESOURCE_TYPE" + Global.Separation.COLUMNS;

                //일반변수 리스트의 형식
                strData += Global.DBVarType.VarChar + "(1)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(4)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(30)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.Datetime + "" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.Datetime + "" + Global.COLUMNS_DIV;

                strData += Global.DBVarType.VarChar + "(7)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(7)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(18)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(7)" + Global.COLUMNS_DIV;

                strData += Global.DBVarType.Numeric + "(18,2)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(30)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(20)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(10)" + Global.COLUMNS_DIV;

                strData += Global.DBVarType.VarChar + "(30) OUTPUT" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(200) OUTPUT" + Global.Separation.COLUMNS;
                //strData += Global.DBVarType.VarChar + "(7)" + Global.Separation.COLUMNS;

                //일반변수값 리스트
                strData += "U" + Global.COLUMNS_DIV;        //저장구분
                strData += sPLANT_CD + Global.COLUMNS_DIV;  //공장
                strData += sUNWORK_NO + Global.COLUMNS_DIV;         //실적번호
                strData += sSTART_DT.ToString("yyyy-MM-dd HH:mm:ss") + Global.COLUMNS_DIV;   //비가동 시작시각
                string vEND_DT = DBQuery_SERVER_TIME();
                strData += vEND_DT + Global.COLUMNS_DIV;     //비가동 종료시각

                strData += sWC_MGR + Global.COLUMNS_DIV;    //공정그룹
                strData += sWC_CD + Global.COLUMNS_DIV;     //작업장
                strData += sFACILITY_CD + Global.COLUMNS_DIV;   //설비
                strData += sOP_CD + Global.COLUMNS_DIV;         //비가동코드

                TimeSpan ts = DateTime.Parse(vEND_DT).Subtract(sSTART_DT);

                strData += ts.Minutes.ToString() + Global.COLUMNS_DIV;            //비가동 시간
                strData += "" + Global.COLUMNS_DIV;//작업자
                strData += "" + Global.COLUMNS_DIV;     //생산실적번호
                strData += sWORKER_CD + Global.COLUMNS_DIV;     //작업자

                strData += "" + Global.COLUMNS_DIV;             //비가동번호 반환
                strData += "" + Global.Separation.COLUMNS;             //RTN MSG 반환
                //strData += "" + Global.Separation.COLUMNS;      //RESOURCE_TYPE


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
                strData += ""; // +nsWinUtilGlobal.Global.Separation.COLUMNS;


                //string strState = nsFuncUtil.FuncUtil.ExcuteSql(MainForm, strData, Global.workinfo.szServerIP, Global.workinfo.szPortNo); //반환테이블이 없을 경우
                DataTable dtData1 = new DataTable();
                int nCnt = 0;

                string strState = TGSClass.DataBase.GetDataSqlProcedur(MainForm, strData, ref dtData1, ref nCnt); //TGS Class 사용
                //string strState = nsFuncUtil.FuncUtil.GetDataSql(MainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);//반환테이블이있을 경우



                if (!strState.Equals("OK"))
                {
                    //TGSControl.UsrFunction.MessageBoxErr("저장중 오류가 발생하였습다.", "비가동종료");
                    TGSControl.UsrFunction.MessageBoxErr(strState.Substring(2), "파라메터 비가동종료");
                    return false;
                }

                //비가동 종료 메시지 처리
                if (DBQuery_UnworkEventCheck(sUNWORK_NO))   //종료안된 비가동 sms이벤트가 있으면
                {
                    //임시구문 주석
                    //MES_APP_Z10.C_SMS.ShowSendMessage("OP", sPLANT_CD, sWC_MGR, sUNWORK_NO, "CL", sL_OP_CD, sM_OP_CD, sOP_CD, sWORKER_CD, sFACILITY_CD, sWC_CD, this.MainForm); //비가동 메시지 전달
                }

                return true;


            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "비가동종료");
                return false;
            }
            finally
            {
                DBQuery(sPLANT_CD, sFACILITY_CD);   //비가동 상태를 다시 조회한다.
                LoadingForm(false);
            }
        }
        //비가동 SMS 메시지 개수를 조회한다.
        private bool DBQuery_UnworkEventCheck(string pEventNo)
        {
            string strSQL = string.Empty;
            strSQL += "SELECT TOP 1	MSG_EVENT_ID ";
            strSQL += "FROM	ZZ_Z_SMS_EVENT_HEADER AS A (NOLOCK) ";
            strSQL += "WHERE REF_CD ='" + pEventNo + "'";
            strSQL += " AND STATUS_TYPE != 'CL'";
            
            int nCnt = 0;
            DataTable dt = new DataTable();
            string strState = TGSClass.DataBase.GetDataSql(sMainForm, strSQL, ref dt, ref nCnt);

            if (dt.Rows.Count == 0)
                return false;
            else
                return true;
        }

        private bool DBSave_UNWORK_START(string pOP_CD, string pWORKER_CD)
        {
            try
            {

                LoadingForm(true);

                
                //string szSendData = WorkCode.WorkCd.STOPWORK_START;
                //szSendData += sPLANT_CD + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //szSendData += sWC_MGR + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //szSendData += sFACILITY_CD + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //szSendData += pWORKER_CD + nsWinUtilGlobal.Global.Separation.COLUMNS;
                //szSendData += "" + nsWinUtilGlobal.Global.Separation.COLUMNS;   //sWK_ORD_NO
                //szSendData += "" + nsWinUtilGlobal.Global.Separation.COLUMNS;   //sRESULT_NO

                //szSendData += pOP_CD + nsWinUtilGlobal.Global.Separation.COLUMNS;

                //szSendData += sWC_CD + nsWinUtilGlobal.Global.Separation.COLUMNS;   //sWC_CD

                //string strState = string.Empty;
                //strState = nsFuncUtil.FuncUtil.ExcuteSql(sMainForm, szSendData, Global.workinfo.szServerIP, Global.workinfo.szPortNo);


                //string strData = WorkCode.WorkCd.SQLPROCEDURE; //프로시져 형태로 호출
                string strData = "";
                strData += "dbo.USP_MES_P_UNWORK_SAVE";       //프로시져 명
                strData += Global.COLUMNS_DIV + "N" + Global.Separation.COLUMNS;   //조회데이타가 없을 경우 'N' = nonquery 있을 경우 'Q' = query
                //일반변수 리스트
                strData += "@SAVE_FLAG" + Global.COLUMNS_DIV;
                strData += "@PLANT_CD" + Global.COLUMNS_DIV;
                strData += "@UNWORK_NO" + Global.COLUMNS_DIV;
                strData += "@UNWORK_START_DT" + Global.COLUMNS_DIV;
                strData += "@UNWORK_END_DT" + Global.COLUMNS_DIV;

                strData += "@WC_MGR" + Global.COLUMNS_DIV;
                strData += "@WC_CD" + Global.COLUMNS_DIV;
                strData += "@FACILITY_CD" + Global.COLUMNS_DIV;
                strData += "@OP_CD" + Global.COLUMNS_DIV;

                strData += "@UNWORK_MIN" + Global.COLUMNS_DIV;
                strData += "@WK_ORD_NO" + Global.COLUMNS_DIV;
                strData += "@RESULT_NO" + Global.COLUMNS_DIV;
                strData += "@USER_ID" + Global.COLUMNS_DIV;
                strData += "@NEW_UNWORK_NO" + Global.COLUMNS_DIV;

                strData += "@RTN_MSG" + Global.Separation.COLUMNS;


                //일반변수 리스트의 형식
                strData += Global.DBVarType.VarChar + "(1)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(4)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(30)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.Datetime + "" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.Datetime + "" + Global.COLUMNS_DIV;

                strData += Global.DBVarType.VarChar + "(7)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(7)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(18)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(7)" + Global.COLUMNS_DIV;

                strData += Global.DBVarType.Numeric + "(18,2)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(30)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(20)" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(10)" + Global.COLUMNS_DIV;

                strData += Global.DBVarType.VarChar + "(30) OUTPUT" + Global.COLUMNS_DIV;
                strData += Global.DBVarType.VarChar + "(200) OUTPUT" + Global.Separation.COLUMNS;

                //일반변수값 리스트
                strData += "I" + Global.COLUMNS_DIV;        //저장구분
                strData += sPLANT_CD + Global.COLUMNS_DIV;  //공장
                strData += "" + Global.COLUMNS_DIV;         //실적번호
                strData += DBQuery_SERVER_TIME() + Global.COLUMNS_DIV;   //비가동 시작시각
                strData += "NULL" + Global.COLUMNS_DIV;     //비가동 종료시각

                strData += sWC_MGR + Global.COLUMNS_DIV;    //공정그룹
                strData += sWC_CD + Global.COLUMNS_DIV;     //작업장
                strData += sFACILITY_CD + Global.COLUMNS_DIV;   //설비
                strData += pOP_CD + Global.COLUMNS_DIV;         //비가동코드

                strData += "0" + Global.COLUMNS_DIV;            //비가동 시간
                strData += "" + Global.COLUMNS_DIV;//작업자
                strData += "" + Global.COLUMNS_DIV;     //생산실적번호
                strData += pWORKER_CD + Global.COLUMNS_DIV;     //작업자

                strData += "" + Global.COLUMNS_DIV;             //비가동번호 반환
                strData += "" + Global.Separation.COLUMNS;      //RTN MSG 반환


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
                strData += ""; // +nsWinUtilGlobal.Global.Separation.COLUMNS;


                //string strState = nsFuncUtil.FuncUtil.ExcuteSql(MainForm, strData, Global.workinfo.szServerIP, Global.workinfo.szPortNo); //반환테이블이 없을 경우
                DataTable dtData1 = new DataTable();
                int nCnt = 0;

                string strState = TGSClass.DataBase.GetDataSqlProcedur(MainForm, strData, ref dtData1, ref nCnt); //TGS Class 사용
                //string strState = nsFuncUtil.FuncUtil.GetDataSql(MainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);//반환테이블이있을 경우




                if (!strState.Substring(0, 2).Equals("OK"))
                {
                    TGSControl.UsrFunction.MessageBoxErr("저장중 오류가 발생하였습다.", "비가동시작");
                    LoadingForm(false);
                    return false;
                }

                

            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "비가동종료");
                return false;
            }
            finally
            {
                DBQuery(sPLANT_CD, sFACILITY_CD);   //비가동 상태를 다시 조회한다.
                LoadingForm(false);
            }
            return true;
        }

        #region ▶▶▶ 비가동 조회
        private bool DBQuery_UNWORK_COUNT(string pOP_CD)//비가동 조회
        {
            int nCnt = 0;

            try
            {
                //LoadingForm(true);





                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "EXEC DBO.XUSP_MES_P0402P1_GET ";
                strData += "@PLANT_CD='" + sPLANT_CD + "',";
                strData += "@WC_MGR='" + sWC_MGR + "',";
                strData += "@OP_CD='" + pOP_CD + "'";

                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);

                //string strState = nsFuncUtil.FuncUtil.GetDataSql(MainForm, strData, ref dtData1, ref nCnt, Global.workinfo.szServerIP, Global.workinfo.szPortNo);

                
                if (!@strState.Equals("OK"))
                {
                    return false;
                }


                if (dtData1 != null)
                {
                    if (dtData1.Rows.Count > 0)
                        return true;
                    else
                        return false;

                }
                return false;



            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "비가동 조회");
                return false;
            }
            finally
            {
                LoadingForm(false);
                
            }
            //return true;

        }
        #endregion
        #region ▶▶▶ 서버시간조회
        private string DBQuery_SERVER_TIME()//비가동 조회
        {
            int nCnt = 0;

            try
            {
                //LoadingForm(true);





                string strData = "";
                //strData = WorkCode.WorkCd.SQLQUERY;
                strData += "SELECT CONVERT(NVARCHAR(19), GETDATE(), 121) SERVER_TIME ";
                
                DataTable dtData1 = null;
                dtData1 = new DataTable();

                string strState = TGSClass.DataBase.GetDataSql(sMainForm, strData, ref dtData1, ref nCnt);

                
                if (!@strState.Equals("OK"))
                {
                    return "";
                }


                if (dtData1 != null)
                {
                    if (dtData1.Rows.Count > 0)
                        return dtData1.Rows[0]["SERVER_TIME"].ToString();
                    else
                        return "";

                }
                return "";



            }
            catch (Exception se)
            {
                TGSControl.UsrFunction.MessageBoxErr(se.Message, "서버시각 조회");
                return "";
            }
            finally
            {
                LoadingForm(false);

            }
            //return true;

        }
        #endregion

        private void LoadingForm(bool bVisible)
        {
            Cursor.Current = (bVisible == true) ? Cursors.WaitCursor : Cursors.Default;
            //waitLoading.Visible = bVisible;
            Application.DoEvents();
        }

        private void tButton1_ButtonClick(object sender, EventArgs e)
        {

            POP_P9001PA5 myForm = new POP_P9001PA5();

            //파라메터를 설정한다.

            DataTable dt = new DataTable("PassData");
            dt.Columns.Add("PLANT_CD");
            dt.Columns.Add("WC_MGR");
            dt.Columns.Add("OP_CD");
            dt.Columns.Add("WORKER_CD");


            dt.Rows.Add();

            dt.Rows[0]["PLANT_CD"] = sPLANT_CD;
            dt.Rows[0]["WC_MGR"] = sWC_MGR;
            dt.Rows[0]["OP_CD"] = sOP_CD;
            dt.Rows[0]["WORKER_CD"] = sWORKER_CD;


            myForm.ResultData.Tables.Add(dt); //변수전달


            myForm.MainForm = this.MainForm;


            myForm.Caption = "비가동 전환";
            myForm.Start(); //시작함수를 실행한다.
            myForm.OnFncQuery(); //조회함

            myForm.ShowDialog(); //화면에 표시

            if (myForm.DialogResult == DialogResult.OK)
            {
                string vOP_CD = myForm.ResultData.Tables["Result"].Rows[0]["OP_CD"].ToString();
                string vWORKER_CD = myForm.ResultData.Tables["Result"].Rows[0]["WORKER_CD"].ToString();


                //기존 비가동을 종료한다.
                if (DBSave_UNWORK_END())
                {
                    //신규 비가동을 시작한다.
                    DBSave_UNWORK_START(vOP_CD, vWORKER_CD);

                    sWORKER_CD = vWORKER_CD;

                }
            }

            DBQuery(sPLANT_CD, sFACILITY_CD);//비가동 상태를 다시 조회


        }

        private void btn_ING_ButtonClick(object sender, EventArgs e)
        {
            //비가동 점검 메시지 처리
            if (DBQuery_UnworkEventCheck(sUNWORK_NO))   //종료안된 비가동 sms이벤트가 있으면
            {
                //임시주석구문
                //MES_APP_Z10.C_SMS.ShowSendMessage("OP", sPLANT_CD, sWC_MGR, sUNWORK_NO, "ING", sL_OP_CD, sM_OP_CD, sOP_CD, sWORKER_CD, sFACILITY_CD, sWC_CD, this.MainForm); //비가동 메시지 전달
            }
        }

        private void windowsForm1_CloseClick(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Parent.Visible = false;
            }
        }
    }
}
