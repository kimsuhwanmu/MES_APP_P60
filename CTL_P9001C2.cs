using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MES_APP_P90
{
    public partial class CTL_P9001C2 : UserControl
    {
        public CTL_P9001C2()
        {
            InitializeComponent();
        }

        DateTime sSTART_DT;
        DateTime sSERVER_DT;
        TimeSpan sTimeDiff;
        //Form sMainForm;
        //Global global = new Global();



        public string OP_NM
        {
            set
            {
                lbl_UNWORK_NM.Text = value;  //비가동 사유

                if (value == "")
                {
                    lbl_UNWORK_TIME.Text = "경과시간 : 0초";
                    timer1.Enabled = false;
                    this.Parent.Visible = false;
                }
                else
                {
                    this.Parent.Visible = true;
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
        public string UnworkNo { get;  set; }
        public string sLOP_CD { get; set; }
        public string sMOP_CD { get; set; }
        public string sOP_CD { get; set; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lbl_UNWORK_NM.Text = "비가동내역:"; // +  this.UnworkNo.ToString();
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
            WindowsResize();
        }

        private void CTL_P0401C2_Resize(object sender, EventArgs e)
        {
            WindowsResize();
        }

        private void WindowsResize()
        {
            lbl_UNWORK_NM.Left = (this.Width - this.lbl_UNWORK_NM.Width) / 2;
            lbl_UNWORK_NM.Top = (this.Height - (this.Height / 3) - lbl_UNWORK_NM.Height) / 2;

            lbl_UNWORK_TIME.Left = (this.Width - this.lbl_UNWORK_TIME.Width) / 2;
            lbl_UNWORK_TIME.Top = (this.Height - (this.Height / 3) - (((this.Height / 3) - lbl_UNWORK_TIME.Height) / 2));


        }


    }
}
