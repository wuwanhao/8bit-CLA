using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ALU
{
    /*
     * @author: wwhao
     * 1.超前进位加法器
     * 2.内部补码运算使加减法统一
     * 3.输出显示真值
     */
    public partial class Form1_wwh : Form
    {
        public Form1_wwh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int c0 = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            int c0 = 0;
            // 输入的值
            int a0 = 0;
            int a1 = 0;
            int a2 = 0;
            int a3 = 0;
            int a4 = 0;
            int a5 = 0;
            int a6 = 0;
            int a7 = 0;
            int b0 = 0;
            int b1 = 0;
            int b2 = 0;
            int b3 = 0;
            int b4 = 0;
            int b5 = 0;
            int b6 = 0;
            int b7 = 0;

            // 确定多选框中的值
            if (checkBox_a0.Checked)
            {
                a0 = 1;
            };
            if (checkBox_a1.Checked)
            {
                a1 = 1;
            };
            if (checkBox_a2.Checked)
            {
                a2 = 1;
            };
            if (checkBox_a3.Checked)
            {
                a3 = 1;
            };
            if (checkBox_a4.Checked)
            {
                a4 = 1;
            };
            if (checkBox_a5.Checked)
            {
                a5 = 1;
            };
            if (checkBox_a6.Checked)
            {
                a7 = 1;
            };
            if (checkBox_a7.Checked)
            {
                a7 = 1;
            };

            if (checkBox_b0.Checked)
            {
                b0 = 1;
            }
            if (checkBox_b1.Checked)
            {
                b1 = 1;
            }
            if (checkBox_b2.Checked)
            {
                b2 = 1;
            }
            if (checkBox_b3.Checked)
            {
                b3 = 1;
            }
            if (checkBox_b4.Checked)
            {
                b4 = 1;
            }
            if (checkBox_b5.Checked)
            {
                b5 = 1;
            }
            if (checkBox_b6.Checked)
            {
                b6 = 1;
            }
            if (checkBox_b7.Checked)
            {
                b7 = 1;
            }


            //计算并显示传递进位
            int p0 = a0 ^ b0;   
            int p1 = a1 ^ b1;
            int p2 = a2 ^ b2;
            int p3 = a3 ^ b3;
            int p4 = a4 ^ b4;
            int p5 = a5 ^ b5;
            int p6 = a6 ^ b6;
            int p7 = a7 ^ b7;
            input_p0.Text = p0.ToString();
            input_p1.Text = p1.ToString();
            input_p2.Text = p2.ToString();
            input_p3.Text = p3.ToString();
            input_p4.Text = p4.ToString();
            input_p5.Text = p5.ToString();
            input_p6.Text = p6.ToString();
            input_p7.Text = p7.ToString();


            //计算并显示本地进位
            int g0 = a0 & b0;
            int g1 = a1 & b1;
            int g2 = a2 & b2;
            int g3 = a3 & b3;
            int g4 = a4 & b4;
            int g5 = a5 & b5;
            int g6 = a6 & b6;
            int g7 = a7 & b7;
            input_g0.Text = g0.ToString();
            input_g1.Text = g1.ToString();
            input_g2.Text = g2.ToString();
            input_g3.Text = g3.ToString();
            input_g4.Text = g4.ToString();
            input_g5.Text = g5.ToString();
            input_g6.Text = g6.ToString();
            input_g7.Text = g7.ToString();

            //计算并显示是否进位
            int c1 = g0 | p0&c0;
            int c2 = g1 | p1&g0 | p1&p0&c0;
            int c3 = g2 | p2&g1 | p2&p1&g0 | p2&p1&p0&c0;
            int c4 = g3 | p3&g2 | p3&p2&g1 | p3&p2&p1&g0 | p3&p2&p1&p0&c0;
            int c5 = g4 | p4&g3 | p4&p3&g2 | p4&p3&p2&g1 | p4&p3&p2&p1&g0 | p4&p3&p2&p1&p0&c0;
            int c6 = g5 | p5&g4 | p5&p4&g3 | p5&p4&p3&g2 | p5&p4&p3&p2&g1 | p5&p4&p3&p2&p1&g0 | p5&p4&p3&p2&p1&p0&c0;
            int c7 = g6 | p6&g5 | p6&p5&g4 | p6&p5&p4&g3 | p6&p5&p4&p3&g2 | p6&p5&p4&p3&p2&g1 | p6&p5&p4&p3&p2&p1&g0 | p6&p5&p4&p3&p2&p1&p0&c0;
            int c8 = g7 | p7&g6 | p7&p6&g5 | p7&p6&p5&g4 | p7&p6&p5&p4&g3 | p7&p6&p5&p4&p3&g2 | p7&p6&p5&p4&p3&p2&g1 | p7&p6&p5&p4&p3&p2&p1&g0 | p7&p6&p5&p4&p3&p2&p1&p0&c0;
            checkBox_c1.Checked = getBool(c1);
            checkBox_c2.Checked = getBool(c2);
            checkBox_c3.Checked = getBool(c3);
            checkBox_c4.Checked = getBool(c4);
            checkBox_c5.Checked = getBool(c5);
            checkBox_c6.Checked = getBool(c6);
            checkBox_c7.Checked = getBool(c7);
            checkBox_c8.Checked = getBool(c8);


            // 8位超前进位逻辑电路
            int s0 = (a0 ^ b0) ^ c0;
            int s1 = (a1 ^ b1) ^ ((a0 & b0) | (a0 ^ b0) & c0);
            int s2 = (a2 ^ b2) ^ ((a1 & b1) | (a1 ^ b1) & (a0 & b0) | (a1 ^ b1) & (a0 & b0) & c0);
            int s3 = (a3 ^ b3) ^ ((a2 & b2) | (a2 ^ b2) & (a1 & b1) | (a2 ^ b2) & (a1 ^ b1) & (a0 & b0) | (a2 ^ b2) & (a1 ^ b1) & (a0 & b0) & c0);
            int s4 = (a4 ^ b4) ^ ((a3 & b3) | (a3 ^ b3) & (a2 & b2) | (a3 ^ b3) & (a2 ^ b2) & (a1 & b1) | (a3 ^ b3) & (a2 ^ b2) & (a1 ^ b1) & (a0 & b0) | (a3 ^ b3) & (a2 ^ b2) & (a1 ^ b1) & (a0 ^ b0) & c0);
            int s5 = (a5 ^ b5) ^ ((a4 & b4) | (a4 ^ b4) & (a3 & b3) | (a4 ^ b4) & (a3 ^ b3) & (a2 & b2) | (a4 ^ b4) & (a3 ^ b3) & (a2 ^ b2) & (a1 & b1) | (a4 ^ b4) & (a3 ^ b3) & (a2 ^ b2) & (a1 ^ b1) & (a0 & b0) | (a4 ^ b4) & (a3 ^ b3) & (a2 ^ b2) & (a1 ^ b1) & (a0 ^ b0) & c0);
            int s6 = (a6 ^ b6) ^ ((a5 & b5) | (a5 ^ b5) & (a4 & b4) | (a5 ^ b5) & (a4 ^ b4) & (a3 & b3) | (a5 ^ b5) & (a4 ^ b4) & (a3 ^ b3) & (a2 & b2) | (a5 ^ b5) & (a4 ^ b4) & (a3 ^ b3) & (a2 ^ b2) & (a1 & b1) | (a5 ^ b5) & (a4 ^ b4) & (a3 ^ b3) & (a2 ^ b2) & (a1 ^ b1) & (a0 & b0) | (a5 ^ b5) & (a4 ^ b4) & (a3 ^ b3) & (a2 ^ b2) & (a1 ^ b1) & (a0 ^ b0) & c0);
            int s7 = (a7 ^ b7) ^ ((a6 & b6) | (a6 ^ b6) & (a5 & b5) | (a6 ^ b6) & (a5 ^ b5) & (a4 & b4) | (a6 ^ b6) & (a5 ^ b5) & (a4 ^ b4) & (a3 & b3) | (a6 ^ b6) & (a5 ^ b5) & (a4 ^ b4) & (a3 ^ b3) & (a2 & b2) | (a6 ^ b6) & (a5 ^ b5) & (a4 ^ b4) & (a3 ^ b3) & (a2 ^ b2) & (a1 & b1) | (a6 ^ b6) & (a5 ^ b5) & (a4 ^ b4) & (a3 ^ b3) & (a2 ^ b2) & (a1 ^ b1) & (a0 & b0) | (a6 ^ b6) & (a5 ^ b5) & (a4 ^ b4) & (a3 ^ b3) & (a2 ^ b2) & (a1 ^ b1) & (a0 ^ b0) & c0);
            string aa = s7.ToString() + s6.ToString() + s5.ToString() + s4.ToString() + s3.ToString() + s2.ToString() + s1.ToString() + s0.ToString();
            input_result.Text = aa;


            //电路图显示
            ic0.Text = c0.ToString();
            ia0.Text = a0.ToString();
            ib0.Text = b0.ToString();
            ia1.Text = a1.ToString();
            ib1.Text = b1.ToString();
            ia2.Text = a2.ToString();
            ib2.Text = b2.ToString();
            ia3.Text = a3.ToString();
            ib3.Text = b3.ToString();
            ip0.Text = p0.ToString();
            ig0.Text = g0.ToString();
            ip1.Text = p1.ToString();
            ig1.Text = g1.ToString();
            ip2.Text = p2.ToString();
            ig2.Text = g2.ToString();
            ip3.Text = p3.ToString();
            ig3.Text = g3.ToString();
            ic1.Text = c1.ToString();
            ic2.Text = c2.ToString();
            ic3.Text = c3.ToString();
            ic4.Text = c4.ToString();
            

        }

        private bool getBool(int k)
        { 
            if(k == 1){
                return true;
            }else{
                return false;
            }
        }


        private void b1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void a0_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void b3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

    }
}
