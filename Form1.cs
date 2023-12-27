using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            // button disable
            btn_2.Enabled = false;
            btn_reset.Enabled = false;
           
        }
        

      //  palyer 1
        
        
        // method
        Random rnd = new Random();


        int one = 0, two = 0, three = 0, four = 0, five = 0, six = 0;
        int counter = 0;
        int sum = 0;
        int avg = 0;
        int tot_clicks;

        private void btn_1_Click(object sender, EventArgs e)
        {

            btn_2.Enabled = true;
            btn_reset.Enabled = true;

            // dice value
            int dice = rnd.Next(1, 7);

            // counter
            counter = counter + 1;

            //s sum
            sum = sum + dice;
            lbl_sum.Text = sum.ToString();

            // tot aatempts
            tot_clicks++;
            lbl_att.Text = tot_clicks.ToString();


            // avg
            avg = sum / tot_clicks;
            lbl_avg.Text = avg.ToString();


          // game start
           
               if (dice == 1)
                {

                    one++;
                    label1.Text = one.ToString();
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;


                }
                else if (dice == 2)
                {
                    two++;
                    label2.Text = two.ToString();
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;

                }

                else if (dice == 3)
                {
                    three++;
                    label3.Text = three.ToString();
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;

                }
                else if (dice == 4)
                {
                    four++;
                    label4.Text = four.ToString();
                    pictureBox4.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;

                }
                else if (dice == 5)
                {
                    five++;
                    label5.Text = five.ToString();
                    pictureBox5.Visible = true;
                    pictureBox1.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox6.Visible = false;

                }

                else if (dice == 6)
                {
                    six++;
                    label6.Text = six.ToString();
                    pictureBox6.Visible = true;
                    pictureBox1.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox2.Visible = false;

                }
                btn_1.Enabled = false;
            }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbl_avg_Click(object sender, EventArgs e)
        {

        }

                           // palyer 2


        int one2 = 0, two2 = 0, three2 = 0, four2 = 0, five2 = 0, six2 = 0;
        int counter2 = 0;
        int sum2 = 0;
        int avg2 = 0;
        int tot_clicks2;


        
        private void btn_2_Click(object sender, EventArgs e)
        {

            btn_1.Enabled = true;
         

            // dice2 value
            int dice_2 = rnd.Next(1, 7); ;


            //counter2
            counter2 = counter2 + 1;

            // sum2
            sum2 = sum2 + dice_2;
            sum_2.Text = sum2.ToString();


            // tot attepts1
            tot_clicks2++;
            

            // avg
            avg2 = sum2 / tot_clicks2;
            avg_2.Text = avg2.ToString();



            // tot attepts1.show
            tot_clicks++;
            lbl_att.Text = tot_clicks.ToString();



         //   game2 start
            if (dice_2 == 1)
            {

                one2++;
                lbl_a.Text = one2.ToString();
                pictureBox12.Visible = true;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;


            }
            else if (dice_2 == 2)
            {
                two2++;
                lbl_b.Text = two2.ToString();
                pictureBox11.Visible = true;
                pictureBox12.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;

            }

            else if (dice_2 == 3)
            {
                three2++;
                lbl_c.Text = three2.ToString();
                pictureBox10.Visible = true;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;

            }
            else if (dice_2 == 4)
            {
                four2++;
                lbl_d.Text = four2.ToString();
                pictureBox9.Visible = true;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;

            }
            else if (dice_2 == 5)
            {
                five2++;
                lbl_e.Text = five2.ToString();
                pictureBox8.Visible = true;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;

            }

            else if (dice_2 == 6)
            {
                six2++;
                lbl_f.Text = six2.ToString();
                pictureBox7.Visible = true;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;

            }

            btn_2.Enabled = false;

            // game win

            if (tot_clicks == 10 && sum > sum2)
            {
                btn_1.Enabled = false;
                btn_2.Enabled = false;
                MessageBox.Show("Player 1 is winner");
            }


            else if (tot_clicks == 10 && sum < sum2)
            {
                btn_1.Enabled = false;
                btn_2.Enabled = false;
                MessageBox.Show("Player 2 is winner");
            }

            else if (tot_clicks == 10 && sum == sum2)
            {
                btn_1.Enabled = false;
                btn_2.Enabled = false;
                MessageBox.Show("Match Draw");
            }
        }


         // reset
        

        private void btn_reset_Click(object sender, EventArgs e)
        {

            btn_1.Enabled = true;
            btn_2.Enabled = true;
            int restart;

            restart = 0;
            label1.Text = restart.ToString();
            label2.Text = restart.ToString();

            label3.Text = restart.ToString();
            label4.Text = restart.ToString();
            label5.Text = restart.ToString();
            label6.Text = restart.ToString();
            lbl_a.Text = restart.ToString();
            lbl_b.Text = restart.ToString();
            lbl_c.Text = restart.ToString();
            lbl_d.Text = restart.ToString();
            lbl_e.Text = restart.ToString();
            lbl_f.Text = restart.ToString();
            avg_2.Text = restart.ToString();
            lbl_att.Text = restart.ToString();
            sum_2.Text  =  restart.ToString();
            lbl_avg.Text = restart.ToString();
            lbl_sum.Text = restart.ToString();

            // again start

            tot_clicks = 0;

            btn_2.Enabled = false;
            btn_reset.Enabled = false;
            
 
        }

       
    }
    
}


