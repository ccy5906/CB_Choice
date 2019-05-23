using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CB_Choice
{
    public partial class Form1 : Form
    {
        // 초기 콤보박스 데이터 설정
       string[] SList = new string[]{"김밥", "샐러드김밥", "야채김밥", "소고기김밥" ,"계란김밥", "라볶이"};
        string orgStr = ""; // 선택 결과 저장

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0; i<this.SList.Length;i++)
            {
                this.cbList.Items.Add(this.SList[i]);
            }
            this.orgStr = this.lblResult.Text;
            if(this.SList.Length > 0)
            {
                this.cbList.SelectedIndex = 0;

            }
            
           

        }

        private void CbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblResult.Text = this.orgStr + this.cbList.Text;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CheckInput();
        }

        private bool CheckInput()
        {
            if (this.txtList.Text == "")
            {
                MessageBox.Show("추가할 항목을 입력해주세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtList.Focus();
                return false;
            }
            else
            {
                this.cbList.Items.Add(this.txtList.Text);
                //버튼 클릭으로 메뉴 추가 후 txtbox를 빈칸으로 만들어줌 
                this.txtList.Text = "";
                this.cbList.SelectedIndex = this.cbList.Items.Count - 1;
                this.txtList.Focus();
                return true;
            }
            
        }

        private void TxtList_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //입력하는 곳에서 엔터 클릭시
            if (e.KeyChar == 13)
            {
                CheckInput();
            }
        }
    }
}
