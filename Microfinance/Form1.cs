using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Microfinance
{
    public partial class frmHome : Form
    {
        
       
        public frmHome()
        {
            InitializeComponent();
        }
        OpenFileDialog dlg = new OpenFileDialog();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupbx_Registration_Enter(object sender, EventArgs e)
        {

        }

        private void groupbx_Registration_Enter_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void groupbx_Deposit_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        
      
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void panel_Home_Click(object sender, EventArgs e)
        {

        }

        private void accPicBox_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_UpdateDeposit_Click(object sender, EventArgs e)
        {

        }

        private void accPicBox_Click_1(object sender, EventArgs e)
        {

        }

        private void groupbx_Registration_Enter_2(object sender, EventArgs e)
        {

        }

       
        private void panelAccRegistration_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProceed_Click_1(object sender, EventArgs e)
        {
            

            Acc_RegOutputForm accReg_OutPutForm = new Acc_RegOutputForm();
            this.Hide();


            accReg_OutPutForm.lbl_LastNameDisplay.Text = acctxtbox_LName.Text.ToString();
            accReg_OutPutForm.lbl_MiddleNameDisplay.Text = acctxtbox_MName.Text.ToString();
            accReg_OutPutForm.lbl_FirstNameDisplay.Text = acctxtbox_FName.Text.ToString();
            accReg_OutPutForm.lbl_GenderDisplay.Text = acccombobx_Gender.Text.ToString();
            accReg_OutPutForm.labelbl_AddressDisplay.Text = acctxtbox_Address.Text.ToString();
            accReg_OutPutForm.lbl_EmailDisplay.Text = acctxtbox_Email.Text.ToString();
            accReg_OutPutForm.lbl_PhoneDisplay.Text = acctxtbox_Phone.Text.ToString();
            accReg_OutPutForm.lbl_DateOfBirthDisplay.Text = accdtimepicker_DOB.Text.ToString();
            accReg_OutPutForm.lbl_AccountTypeDisplay.Text = acccombobx_AccountType.Text.ToString();
            accReg_OutPutForm.lbl_SavingAccDisplay.Text = acctxtbox_SavingAmt.Text.ToString();
            accReg_OutPutForm.lbl_CurrancyDisplay.Text = acccombobx_Currency.Text.ToString();
            accReg_OutPutForm.lbl_BeneficiaryNameDisplay.Text = acctxtbox_BeneficiaryFullName.Text.ToString();
            accReg_OutPutForm.lbl_BeneficiaryPhoneDispay.Text = acctxtbox_BeneficiaryPhone.Text.ToString();
            accReg_OutPutForm.lbl_BeneficiaryAddressDisplay.Text = acctxtbox_BeneficiaryAddress.Text.ToString();
            accReg_OutPutForm.lbl_RegistrationDateDisplay.Text = accdtimePicker_RegDate.Text.ToString();

            accReg_OutPutForm.pictureBoxDisplay.Image = Image.FromFile(dlg.FileName);
            MemoryStream mstream1 = new MemoryStream();
            accReg_OutPutForm.pictureBoxDisplay.Image.Save(mstream1, System.Drawing.Imaging.ImageFormat.Jpeg);

            accReg_OutPutForm.Show();
        }

        private void btnUploadPhoto_Click_1(object sender, EventArgs e)
        {
            pictureBoxDisplay.SizeMode = PictureBoxSizeMode.Normal;
            dlg.Filter = " image files| *.jpg; *.png; *.gif; *.icon; .*;";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBoxDisplay.Image = new Bitmap(dlg.OpenFile());
            }


            dlg.Dispose();
        }

        private void panelAccRegistration_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxDisplay_Click(object sender, EventArgs e)
        {

        }

        private void statusBar_warning_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }

        private void groupbx_Registration_Enter_3(object sender, EventArgs e)
        {

        }

        private void acctxtbox_LName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void acctxtbox_LName_Enter(object sender, EventArgs e)
        {
            statusBarWarning.Text = "Please Enter customer's Last Name";  
            
        }

        private void acctxtbox_MName_Enter(object sender, EventArgs e)
        {
            statusBarWarning.Text = "Please Enter customer's Middle Name"; 
        }

        private void acctxtbox_FName_Enter(object sender, EventArgs e)
        {
            statusBarWarning.Text = "Please Enter customer's First Name"; 
        }

        private void statusStripWarning_Enter(object sender, EventArgs e)
        {

        }

        private void acccombobx_Gender_Enter(object sender, EventArgs e)
        {
            statusBarWarning.Text = "Please select customer's gender"; 
        }

        private void acctxtbox_Address_Enter(object sender, EventArgs e)
        {
            statusBarWarning.Text = "Please Enter customer's Residential Address"; 
        }

        private void acctxtbox_Email_Enter(object sender, EventArgs e)
        {
            statusBarWarning.Text = "Please Enter customer's email address"; 
        }

        private void acctxtbox_Phone_Enter(object sender, EventArgs e)
        {
            statusBarWarning.Text = "Please Enter customer's Phone number"; 
        }

        private void accdtimepicker_DOB_Enter(object sender, EventArgs e)
        {
            statusBarWarning.Text = "Please Enter customer's date of birth"; 

        }

        private void acccombobx_AccountType_Enter(object sender, EventArgs e)
        {
            statusBarWarning.Text = "Please select the type of account from the drop down menu"; 

        }

        private void acctxtbox_SavingAmt_Enter(object sender, EventArgs e)
        {
            statusBarWarning.Text = "Please Enter customer's saving amount"; 

        }

        private void acccombobx_Currency_Enter(object sender, EventArgs e)
        {
            statusBarWarning.Text = "Please select the currency the customer is transacting with"; 

        }

        private void acctxtbox_BeneficiaryFullName_Enter(object sender, EventArgs e)
        {
            statusBarWarning.Text = "Please Enter customer's beneficiary full name"; 

        }

        private void acctxtbox_BeneficiaryPhone_Enter(object sender, EventArgs e)
        {
            statusBarWarning.Text = "Please Enter customer's beneficiary phone number"; 

        }

        private void acctxtbox_BeneficiaryAddress_Enter(object sender, EventArgs e)
        {
            statusBarWarning.Text = "Please Enter customer's beneficiary residential address"; 

        }

        private void accdtimePicker_RegDate_Enter(object sender, EventArgs e)
        {
            statusBarWarning.Text = "Please Enter the registration date of the customer"; 

        }

        private void statusBar1_Enter(object sender, EventArgs e)
        {

        }

        private void statusBarWarning_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }
    }

}


