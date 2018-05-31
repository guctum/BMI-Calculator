/*
 * Author/Writer: Greg Uctum
 * Version: 1.1
 * Modified Date: May 30, 2018
 * Project Name: BMI Calculator
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Reset.ResetAllControls(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (radioBtnF.Checked == true)
            {
                // Input Validation
                if (string.IsNullOrWhiteSpace(txtAge.Text))
                {
                    txtAge.Focus();
                    MessageBox.Show("Error: Age needs to be between 17 and 68!");
                }
                else if (string.IsNullOrWhiteSpace(txtWaist.Text))
                {
                    txtWaist.Focus();
                    MessageBox.Show("Error: Waist needs to be between 1 and 60!");
                }
                else if (string.IsNullOrWhiteSpace(txtNeck.Text))
                {
                    txtNeck.Focus();
                    MessageBox.Show("Error: Neck needs to between 1 and 25.");
                }
                else if (string.IsNullOrWhiteSpace(txtHeight.Text))
                {
                    txtHeight.Focus();
                    MessageBox.Show("Error: Height needs to be between 1 and 85.");
                }
                else
                {
                    if (!(Convert.ToDouble(txtAge.Text) > 69) && (Convert.ToDouble(txtAge.Text) < 16))
                    {
                        txtAge.Focus();
                        MessageBox.Show("Error: Age needs to be between 17 and 68!");
                    }
                    else if (!(Convert.ToDouble(txtWaist.Text) > 0) && (Convert.ToDouble(txtWaist.Text) < 61))
                    {
                        txtWaist.Focus();
                        MessageBox.Show("Error: Waist needs to be between 1 and 60!");
                    }
                    else if (!(Convert.ToDouble(txtNeck.Text) > 0) && (Convert.ToDouble(txtNeck.Text) < 26))
                    {
                        txtNeck.Focus();
                        MessageBox.Show("Error: Waist needs to be between 1 and 25!");
                    }
                    else if (!(Convert.ToDouble(txtHeight.Text) > 0) && (Convert.ToDouble(txtHeight.Text) < 86))
                    {
                        txtHeight.Focus();
                        MessageBox.Show("Error: Height needs to be between 1 and 85!");
                    }
                    else if (!(Convert.ToDouble(txtHip.Text) > 0) && (Convert.ToDouble(txtHip.Text) < 55))
                    {
                        txtHip.Focus();
                        MessageBox.Show("Error: Hip needs to be between 1 and 54!");
                    }
                    else
                    {
                        {
                            double age = Convert.ToDouble(txtAge.Text);
                            double waist = Convert.ToDouble(txtWaist.Text);
                            double neck = Convert.ToDouble(txtNeck.Text);
                            double height = Convert.ToDouble(txtHeight.Text);
                            double hip = Convert.ToDouble(txtHip.Text);
                            string eligibility = "";

                            double femaleBF = 163.205 * Math.Log10(waist + hip - neck) - 97.684 * Math.Log10(height) - 78.387;
                            string bodyFat = femaleBF.ToString("#.##");
                            txtBodyFat.Text = bodyFat;

                            switch (age)
                            {
                                case 17:
                                case 18:
                                case 19:
                                case 20:
                                    if (Convert.ToDouble(bodyFat) <= 28)
                                    {
                                        eligibility = "Eligible";
                                        txtEligibility.Text = eligibility;
                                    }
                                    else
                                    {
                                        eligibility = "Ineligible";
                                        txtEligibility.Text = eligibility;
                                    }
                                    break;
                                case 21:
                                case 22:
                                case 23:
                                case 24:
                                case 25:
                                case 26:
                                case 27:
                                    if (Convert.ToDouble(bodyFat) <= 30)
                                    {
                                        eligibility = "Eligible";
                                        txtEligibility.Text = eligibility;
                                    }
                                    else
                                    {
                                        eligibility = "Ineligible";
                                        txtEligibility.Text = eligibility;
                                    }
                                    break;
                                case 28:
                                case 29:
                                case 30:
                                case 31:
                                case 32:
                                case 33:
                                case 34:
                                case 35:
                                case 36:
                                case 37:
                                case 38:
                                case 39:
                                    if (Convert.ToDouble(bodyFat) <= 32)
                                    {
                                        eligibility = "Eligible";
                                        txtEligibility.Text = eligibility;
                                    }
                                    else
                                    {
                                        eligibility = "Ineligible";
                                        txtEligibility.Text = eligibility;
                                    }
                                    break;
                                default:
                                    if (Convert.ToDouble(bodyFat) <= 34)
                                    {
                                        eligibility = "Eligible";
                                        txtEligibility.Text = eligibility;
                                    }
                                    else
                                    {
                                        eligibility = "Ineligible";
                                        txtEligibility.Text = eligibility;
                                    }
                                    break;
                            }
                        }
                    }
                }
            }

                    if (radioBtnM.Checked == true)
                    {
                        // Input Validation
                        if (string.IsNullOrWhiteSpace(txtAge.Text))
                        {
                            txtAge.Focus();
                            MessageBox.Show("Error: Age needs to be between 17 and 68!");
                        }
                        else if (string.IsNullOrWhiteSpace(txtWaist.Text))
                        {
                            txtWaist.Focus();
                            MessageBox.Show("Error: Waist needs to be between 1 and 60!");
                        }
                        else if (string.IsNullOrWhiteSpace(txtNeck.Text))
                        {
                            txtNeck.Focus();
                            MessageBox.Show("Error: Neck needs to between 1 and 25.");
                        }
                        else if (string.IsNullOrWhiteSpace(txtHeight.Text))
                        {
                            txtHeight.Focus();
                            MessageBox.Show("Error: Height needs to be between 1 and 85.");
                        }
                        else
                        {
                            if (!(Convert.ToDouble(txtAge.Text) > 69) && (Convert.ToDouble(txtAge.Text) < 16))
                            {
                                txtAge.Focus();
                                MessageBox.Show("Error: Age needs to be between 17 and 68!");
                            }
                            else if (!(Convert.ToDouble(txtWaist.Text) > 0) && (Convert.ToDouble(txtWaist.Text) < 61))
                            {
                                txtWaist.Focus();
                                MessageBox.Show("Error: Waist needs to be between 1 and 60!");
                            }
                            else if (!(Convert.ToDouble(txtNeck.Text) > 0) && (Convert.ToDouble(txtNeck.Text) < 26))
                            {
                                txtNeck.Focus();
                                MessageBox.Show("Error: Waist needs to be between 1 and 25!");
                            }
                            else if (!(Convert.ToDouble(txtHeight.Text) > 0) && (Convert.ToDouble(txtHeight.Text) < 86))
                            {
                                txtHeight.Focus();
                                MessageBox.Show("Error: Height needs to be between 1 and 85!");
                            }                            
                            else
                            {
                                double age = Convert.ToDouble(txtAge.Text);
                                double waist = Convert.ToDouble(txtWaist.Text);
                                double neck = Convert.ToDouble(txtNeck.Text);
                                double height = Convert.ToDouble(txtHeight.Text);
                                string eligibility = "";

                                double maleBF = 86.010 * Math.Log10(waist - neck) - 70.041 * Math.Log10(height) + 36.76;
                                string bodyFat = maleBF.ToString("#.##");
                                txtBodyFat.Text = bodyFat;

                                switch (age)
                                {
                                    case 17:
                                    case 18:
                                    case 19:
                                    case 20:
                                        if (Convert.ToDouble(bodyFat) <= 20)
                                        {
                                            eligibility = "Eligible";
                                            txtEligibility.Text = eligibility;
                                        }
                                        else
                                        {
                                            eligibility = "Ineligible";
                                            txtEligibility.Text = eligibility;
                                        }
                                        break;
                                    case 21:
                                    case 22:
                                    case 23:
                                    case 24:
                                    case 25:
                                    case 26:
                                    case 27:
                                        if (Convert.ToDouble(bodyFat) <= 22)
                                        {
                                            eligibility = "Eligible";
                                            txtEligibility.Text = eligibility;
                                        }
                                        else
                                        {
                                            eligibility = "Ineligible";
                                            txtEligibility.Text = eligibility;
                                        }
                                        break;
                                    case 28:
                                    case 29:
                                    case 30:
                                    case 31:
                                    case 32:
                                    case 33:
                                    case 34:
                                    case 35:
                                    case 36:
                                    case 37:
                                    case 38:
                                    case 39:
                                        if (Convert.ToDouble(bodyFat) <= 24)
                                        {
                                            eligibility = "Eligible";
                                            txtEligibility.Text = eligibility;
                                        }
                                        else
                                        {
                                            eligibility = "Ineligible";
                                            txtEligibility.Text = eligibility;
                                        }
                                        break;
                                    default:
                                        if (Convert.ToDouble(bodyFat) <= 26)
                                        {
                                            eligibility = "Eligible";
                                            txtEligibility.Text = eligibility;
                                        }
                                        else
                                        {
                                            eligibility = "Ineligible";
                                            txtEligibility.Text = eligibility;
                                        }
                                        break;
                                }
                            }
                        }
                    }
                }
            
        

        private void radioBtnM_CheckedChanged(object sender, EventArgs e)
        {
            lblHip.Visible = !lblHip.Visible;
            txtHip.Visible = !txtHip.Visible;
        }
    }

    public class Reset
    {
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.Checked = false;
                }
            }
        }
    }
}