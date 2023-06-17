using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Unit_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //by default selected indexes
            //weight
            whtBox1.SelectedIndex = 0;
            whtBox2.SelectedIndex = 2;
            //pressure
            prbox1.SelectedIndex = 0;
            prbox2.SelectedIndex = 1;
            //temperature
            tempbox1.SelectedIndex = 1;
            tempbox2.SelectedIndex = 0;
            //distance
            distbox1.SelectedIndex = 0;
            distbox2.SelectedIndex = 1;
            //volume
            volbox1.SelectedIndex = 0; 
            volbox2.SelectedIndex = 1;
            //energy
            ergbox1.SelectedIndex = 0;
            ergbox2.SelectedIndex = 1;
        }
        //--------------------------------------------------------------------------
        //Weight Conversion
        //0th index= kg
        //1th index=grams
        //2th index=pounds
        float num1, num2;
        private void whtClear_Click(object sender, EventArgs e)
        {
            whtinput.Clear();  //weight clear button
            wht_output.Clear();


        }
        private void whtConvert_Click(object sender, EventArgs e)
        {                           //weight convert button
            wht_output.Clear();
            num1 = float.Parse(whtinput.Text);
            if (whtBox1.SelectedIndex == 0)
            {
                if (whtBox2.SelectedIndex == 0)
                    num2 = num1; // kg to kg
                else if (whtBox2.SelectedIndex == 1)
                    num2 = num1 * 1000;    //kg to grams
                else if (whtBox2.SelectedIndex == 2)
                    num2 = num1 * 2.2046f;   //kg to pounds

            }
            else if (whtBox1.SelectedIndex == 1)
            {
                if (whtBox2.SelectedIndex == 0)
                    num2 = num1 / 1000;   //grams to kg
                else if (whtBox2.SelectedIndex == 1)
                    num2 = num1;   // grams to grams
                else if (whtBox2.SelectedIndex == 2)
                    num2 = num1 * 0.0022046f;   // grams to pounds
            }
            else if (whtBox1.SelectedIndex == 2)
            {
                if (whtBox2.SelectedIndex == 0)
                    num2 = num1 * 0.45359237f;  //pounds to kg
                else if (whtBox2.SelectedIndex == 1)
                    num2 = num1 * 453.59237f;  //pounds to grams
                else if (whtBox2.SelectedIndex == 2)
                    num2 = num1;   //pounds to pounds
            }
            wht_output.Clear();
            wht_output.Text += num2.ToString();

        }

        private void weightbtn_Click(object sender, EventArgs e)
        {
            ControlTab.SelectedTab = wtTab;
        }
        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

        //-----------------------------------------------------------------------------------------
        //Pressure conversion
        //0=pascals
        //1=psi
        float pr_num1, pr_num2;
        private void pressurebtn_Click(object sender, EventArgs e)
        {
            ControlTab.SelectedTab=prTab;
        }
        private void prclear_Click(object sender, EventArgs e)
        {
            prinput.Clear();  //pressure clear button
            proutput.Clear();
        }

        private void prconvert_Click(object sender, EventArgs e)
        {                       //pressure convert button
            proutput.Clear();
            pr_num1 = float.Parse(prinput.Text);
            if (prbox1.SelectedIndex == 0)
            {
                if (prbox2.SelectedIndex == 0)
                    pr_num2 = pr_num1; // pascals to pascals
                else if (prbox2.SelectedIndex == 1)
                    pr_num2 = pr_num1 * 0.000145038f;    //pascals to psi
            }
            else if (prbox1.SelectedIndex == 1)
            {
                if (prbox2.SelectedIndex == 0)//psi to pascals
                    pr_num2 = pr_num1 * 6894.76f;
                else if (prbox2.SelectedIndex == 1)
                    pr_num2 = pr_num1; //psi to psi
            }
            proutput.Clear();
            proutput.Text += pr_num2.ToString();
        }
        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        //---------------------------------------------------------------------
        //Energy Conversion
        // 0th index =joule
        // 1th index =Kilo-calorie
        float nm1, nm2;
       
        private void ergclearbtn_Click(object sender, EventArgs e)
        {
            ergInput.Clear();  //Energy button 
            ergOutput.Clear();
        }

        private void ergconvertbtn_Click(object sender, EventArgs e)
        {                           //energy convert button
            ergOutput.Clear();
            nm1 = float.Parse(ergInput.Text);
            if (ergbox1.SelectedIndex == 0)
            {
                if (ergbox2.SelectedIndex == 0)
                    nm2 = nm1; //joule to joule 
                else if (ergbox2.SelectedIndex == 1)
                    nm2 = nm1 * 0.000239f;  //joule to calorie

            }
            else if (ergbox1.SelectedIndex == 1)
            {
                if (ergbox2.SelectedIndex == 0)
                    nm2 = nm1 * 4184; //calorie to joule
                else if (ergbox2.SelectedIndex == 1)
                    nm2 = nm1;  //calorie to calorie
            }
            ergOutput.Text = nm2.ToString();
        }

        

        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

        //-------------------------------------------------------------------------
        //Temperature Conversion
        //0th index=Kelvin (K)
        //1th index=Celsius(C)
        //2th index=Farhenheit(F)
        float tmp1, tmp2;
        private void tempbtn_Click(object sender, EventArgs e)
        {
            ControlTab.SelectedTab = tempTab;
        }


        private void tempconvertbtn_Click(object sender, EventArgs e)
        {
            tmp1 = float.Parse(tempinput.Text);
            tempoutput.Clear();
            if (tempbox1.SelectedIndex == 0)
            {
                if (tempbox2.SelectedIndex == 0)  //Kelvin to kelvin
                    tmp2 = tmp1;
                else if (tempbox2.SelectedIndex == 1)  //kelvin to celcius
                    tmp2 = tmp1 - 273.15f;
                else if (tempbox2.SelectedIndex == 2)   //kelvin to fahrenheit
                    tmp2 = (tmp1 - 273.15f) * (9 / 5f) + 32;
            }
            else if (tempbox1.SelectedIndex == 1)
            {
                if (tempbox2.SelectedIndex == 0)    //celcius to kelvin
                    tmp2 = tmp1 + 273.15f;
                else if (tempbox2.SelectedIndex == 1)  //celcius to celcius
                    tmp2 = tmp1;
                else if (tempbox2.SelectedIndex == 2)  //celcius to fahrenheit
                    tmp2 = tmp1 * (9/5f) + 32;
            }
            else if (tempbox1.SelectedIndex == 2)
            {
                if (tempbox2.SelectedIndex == 0)  //fahrenheit to kelvin
                    tmp2 = (tmp1 - 32) * (5 / 9f) + 273.15f;
                else if (tempbox2.SelectedIndex == 1)  //fahrenheit to celcius
                    tmp2 = tmp1 * (9 / 5f) + 32;
                else if (tempbox2.SelectedIndex == 2)  //fahrenheit to fahrenheit
                    tmp2 = tmp1;
            }
            tempoutput.Clear();
            tempoutput.Text += tmp2.ToString();
        }

        private void tempclearbtn_Click(object sender, EventArgs e)
        {
            tempinput.Clear();
            tempoutput.Clear();
        }
        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

        //---------------------------------------------------------------------------------
        //Distance Conversion
        //0th index=Metres (m)
        // 1th index=feet(ft)
        //2th index=Miles(Mi)
        float dist1, dist2;

        private void distancebtn_Click(object sender, EventArgs e)
        {
            ControlTab.SelectedTab = distTab;
        }

       
        private void distconvertbtn_Click(object sender, EventArgs e)
        {
            dist1 = float.Parse(distinput.Text);
            distoutput.Clear();
            if (distbox1.SelectedIndex ==0) {
                if (distbox2.SelectedIndex == 0) //meters to meters
                    dist2 = dist1;
                if (distbox2.SelectedIndex == 1)//meters to feet
                    dist2 = dist1 * 3.2808399f;
                    if (distbox2.SelectedIndex == 2)//meters to miles
                        dist2 = dist1 * 0.00062137119f;
            }
            else if (distbox1.SelectedIndex ==1) {
                if (distbox2.SelectedIndex == 0) //feet to meters
                    dist2 =dist1 * 0.3048f;
                if (distbox2.SelectedIndex ==1) // feet to feet
                        dist2 = dist1;
                if (distbox2.SelectedIndex == 2) //feet to miles
                    dist2 = dist1 * 0.00018939f;
            }
            else if (distbox1.SelectedIndex ==2) {
                if (distbox2.SelectedIndex == 0) //miles to meters
                    dist2 = dist1 * 1609.344f;
                if (distbox2.SelectedIndex == 1) //miles to feet
                    dist2 = dist1 * 5280;
                if (distbox2.SelectedIndex == 2)  //miles to miles
                            dist2 = dist1;
            }
            distoutput.Text = dist2.ToString();
        }

        private void energybtn_Click(object sender, EventArgs e)
        {
            ControlTab.SelectedTab = ergTab;
        }

        private void distclearbtn_Click(object sender, EventArgs e)
        {
            distinput.Clear();
            distoutput.Clear();
        }
        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

        //----------------------------------------------------------------------------------
        //Volume conversion
        //0th index = Liters (L)
        //1th index = milliliters(mL)
        //2th index = cubic cm
        float vol1, vol2;
        private void volumebtn_Click(object sender, EventArgs e)
        {
            ControlTab.SelectedTab = volTab;
        }

        private void volconvertbtn_Click(object sender, EventArgs e)
        {
            vol1 = float.Parse(volinput.Text);
            if (volbox1.SelectedIndex == 0) {
                if (volbox2.SelectedIndex == 0)
                    vol2 = vol1;  //liters to  liters
                    if (volbox2.SelectedIndex == 1 || volbox2.SelectedIndex == 2)
                    vol2 = vol1*1000; //liters to milliliters & cubic cm
            }
            else if (volbox1.SelectedIndex == 1) {
                if (volbox2.SelectedIndex == 0)
                    vol2 = vol1/1000; // ml to l
                    if (volbox2.SelectedIndex == 1 || volbox2.SelectedIndex==2)
                    vol2 = vol1; // ml to ml & cubic cm
            }
            else if (volbox1.SelectedIndex == 2) {
                if (volbox2.SelectedIndex == 0)
                    vol2 = vol1/1000; //cubic cm to l
                if (volbox2.SelectedIndex == 1 || volbox2.SelectedIndex==2)
                    vol2 = vol1; //cubic cm to ml & cubic cm 
            }
        voloutput.Clear();
            voloutput.Text += vol2.ToString();

        }
        private void volclearbtn_Click(object sender, EventArgs e)
        {
            voloutput.Clear();
            volinput.Clear();
        }
        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

    }
}
