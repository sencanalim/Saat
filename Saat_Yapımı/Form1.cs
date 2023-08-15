using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saat_Yapımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        int saat, dakika, saniye = 0;

        
        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yy";
            dateTimePicker1.Visible = false;
            label5.Visible = true;
            label5.Text = dateTimePicker1.Text.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // ++ ile += aynı olayı verir.
            saniye +=1 ;
            label4.Text = saniye.ToString("00");

            if (saniye == 60) {
               
                label4.Text = "00 :";
                saniye = 0;
                dakika++;
                label3.Text = dakika.ToString("00") + " :";
                

            if (dakika == 60) {


                    

                    label3.Text = "00 :";
                    dakika = 0;
                    saat +=1;
                    label2.Text = saat.ToString("00") + " :";
                    

                }
            
            if (saat == 25) {

                     label2.Text = "00 :";
                     
                    dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
                    label5.Text = dateTimePicker1.Text.ToString();
                    saat = 0;
                    dakika = 0;
                    saniye = 0;
                
                
                }
            
            }









        }
    }
}
