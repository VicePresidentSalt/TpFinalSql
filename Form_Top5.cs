using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    public partial class Form_Top5 : Form
    {
        public OracleConnection conn = null;
        public Form callBackForm = null;
        private DataSet Top5DataSet = null;
        public Form_Top5()
        {
            InitializeComponent();
        }

        public string premierePos
        {
            get
            {
                return LB_1erePos.Text;
            }
            set
            {
                LB_1erePos.Text = value;
            }
        }
        public string deuxiemePos
        {
            get
            {
                return LB_2emePos.Text;
            }
            set
            {
                LB_2emePos.Text = value;
            }
        }
        public string troisiemePos
        {
            get
            {
                return LB_3emePos.Text;
            }
            set
            {
                LB_3emePos.Text = value;
            }
        }
        public string quatriemePos
        {
            get
            {
                return LB_4emePos.Text;
            }
            set
            {
                LB_4emePos.Text = value;
            }
        }
        public string cinquiemePos
        {
            get
            {
                return LB_5emePos.Text;
            }
            set
            {
                LB_5emePos.Text = value;
            }
        }


        private void Form_Top5_Load(object sender, EventArgs e)
        {
            FillTop5();
        }

        private void Form_Top5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }

        private void FillTop5()
        {
            OracleCommand oraSelect = conn.CreateCommand();
            oraSelect.CommandText = "Select * from FICHES where RowNum <=5 ";
            OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect);
            Top5DataSet = new DataSet();
            oraAdapter.Fill(Top5DataSet);
            DGV_Top5.DataSource = Top5DataSet.Tables[0];

            LB_1erePos.Text = DGV_Top5.Rows[0].Cells[1].Value.ToString() +" "+ DGV_Top5.Rows[0].Cells[0].Value.ToString();
            LB_2emePos.Text = DGV_Top5.Rows[1].Cells[1].Value.ToString() +" "+ DGV_Top5.Rows[1].Cells[0].Value.ToString();
            LB_3emePos.Text = DGV_Top5.Rows[2].Cells[1].Value.ToString() +" "+ DGV_Top5.Rows[2].Cells[0].Value.ToString();
            LB_4emePos.Text = DGV_Top5.Rows[3].Cells[1].Value.ToString() +" "+ DGV_Top5.Rows[3].Cells[0].Value.ToString();
            LB_5emePos.Text = DGV_Top5.Rows[4].Cells[1].Value.ToString() +" "+ DGV_Top5.Rows[4].Cells[0].Value.ToString();
        }
    }
}
