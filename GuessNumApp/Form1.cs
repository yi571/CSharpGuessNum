using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GuessNumApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        int[] ansNumArr = new int[4];  //答案陣列

        private void newGameButton_Click(object sender, EventArgs e) {
            ansListTextBox.Clear();  //清除textbox
            int[] orgNumArr = Enumerable.Range(0, 10).ToArray();  //產生0~9陣列
            Random numR = new Random();


            //打亂orgNumArr順序
            for (int i = 0; i<1000; i++) {
                int starNum = numR.Next(0, orgNumArr.Length);
                int endNum = numR.Next(0, orgNumArr.Length);
                int a = orgNumArr[starNum];


                orgNumArr[starNum] = orgNumArr[endNum];
                orgNumArr[endNum] = a;
            }

            //取前四個
            Array.Copy(orgNumArr, ansNumArr, 4);

            ansListTextBox.AppendText("遊戲開始！\r\n");

        }

        private void guessNumButton_Click(object sender, EventArgs e) {
            int aNum = 0;
            int bNum = 0;
            int j = 0;

            //正則算式排除數字重複、英文及空格
            Regex rgx = new Regex(@".*?(\d).*?\1.*?$|[a-zA-Z]+|\s"); 
            string playerAnsStr = playerAnsTextBox.Text;

            if (rgx.IsMatch(playerAnsStr)) {
                MessageBox.Show("只能輸入數字且不能重複！");
            }
            else if(playerAnsStr.Length <4) {   //排除字串不足四的狀況
                MessageBox.Show("必須有4個數字！");
            }
            else {
                foreach (int i in ansNumArr) {
                    if (i == int.Parse(playerAnsStr.Substring(j, 1))) {
                        aNum++;   //計算A
                    }
                    for (int k = 0; k < 4; k++) {
                        if (i == int.Parse(playerAnsStr.Substring(k, 1))) {
                            bNum++;
                        }
                    }

                    j++;
                }
                bNum = bNum - aNum;  //計算B
                ansListTextBox.AppendText(playerAnsTextBox.Text + " | " + aNum.ToString() + "A" + bNum.ToString() + "B\r\n");
                if (aNum == 4) {
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show(playerAnsStr + "\r\n猜中了");
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void GuessNumForm_DoubleClick(object sender, EventArgs e) {
            string str = "";
            foreach (int j in ansNumArr) {
                str += (j.ToString());
            }
            ansListTextBox.AppendText("Ans:" + str + "\r\n"); //視窗DoubleClick輸出答案
        }


        //Enter輸入
        private void playerAnsTextBox_KeyUp(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                guessNumButton.Focus();
                guessNumButton_Click(sender, e);
                playerAnsTextBox.Focus();
                playerAnsTextBox.SelectAll();
            }
        }
    }
}
