using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenezniDenik
{
    public partial class New : Form
    {
        Main main_form;
        float dph = 0;
        float cenaBDPH = 0;
        float celkovaCena = 0;
        float dphZceny = 0;
        String typListku = "";

        public New(Main f)
        {
            main_form = f;
            InitializeComponent();
            comboBoxTypDokladu.SelectedIndex = 0;
            comboBoxTypPlatby.SelectedIndex = 1;
        }

        private void New_Load(object sender, EventArgs e)
        {

        }
        private void New_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        { 
        
        }

        private void textBoxDPH_TextChanged(object sender, EventArgs e)
        { 
            try
                {
                    float.Parse(textBoxDPH.Text, CultureInfo.InvariantCulture.NumberFormat);
                    if (this.textBoxDPH.Text != "" && this.textBoxCenabBDPH.Text != "")
                    {
                        getPrise();
                    }
                }
               catch(Exception ee){
                   if (this.textBoxDPH.Text != "")
                   this.textBoxDPH.Text = textBoxDPH.Text.Substring(0, textBoxDPH.Text.Length - 1);
                
               }
           

        }

        private void textBoxCenabBDPH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(textBoxCenabBDPH.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (this.textBoxDPH.Text != "" && this.textBoxCenabBDPH.Text != "")
                    {
                       getPrise();
                    }
            }
            catch (Exception ee)
            {
               if( this.textBoxCenabBDPH.Text != "")
                this.textBoxCenabBDPH.Text = textBoxCenabBDPH.Text.Substring(0, textBoxCenabBDPH.Text.Length - 1);
            }
          

        }

      private void getPrise(){
          dph = float.Parse(textBoxDPH.Text, CultureInfo.InvariantCulture.NumberFormat);
          cenaBDPH = float.Parse(textBoxCenabBDPH.Text, CultureInfo.InvariantCulture.NumberFormat);
          dphZceny = (dph / 100 * cenaBDPH);
          celkovaCena = cenaBDPH + dphZceny;
          this.textBoxDPHzc.Text = dphZceny.ToString("R");
          this.textBoxCelemKC.Text = celkovaCena.ToString("R");
      }

      private void textBoxTyp_SelectedIndexChanged(object sender, EventArgs e)
      {

      }

      private void textBox1_Enter(object sender, EventArgs e)
      {
          this.textBoxUcelP.Clear();
      }

      private void textBox2_Enter(object sender, EventArgs e)
      {
          this.textBoxSlovy.Clear();
      }

  

    

     

    
     
    }
}
