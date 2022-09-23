//Solution: Echo Echo
//Author: Joel Luthi
//Date: 9/12/2022
//Purpose: To demonstrate usage of a varity of winForm's controls.

namespace EchoEcho
{


    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        //Send user selected or typed input to the output list box.
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (cboPreGeneratedResponse.SelectedIndex > 0)
            {
                lbOutput.Items.Add(cboPreGeneratedResponse.Items[cboPreGeneratedResponse.SelectedIndex].ToString());
                cboPreGeneratedResponse.SelectedIndex = 0;
            }
            else
            {
                if (!string.IsNullOrEmpty(txtResponse.Text))
                {
                    lbOutput.Items.Add(txtResponse.Text.ToString());
                    txtResponse.Text = String.Empty;
                }
            }
        }

        //If selected value changed of combo box, react accordingly.
        private void cboPreGeneratedResponse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPreGeneratedResponse.SelectedIndex > 0)
            {
                txtResponse.Text = "<Disabled - Unselect \"Pre-Generated Repsonse\">";
                txtResponse.Enabled = false;
            }
            else
            {
                txtResponse.Text = String.Empty;
                txtResponse.Enabled = true;
            }

        }

        //Clear list box.
        private void btnClear_Click(object sender, EventArgs e)
        {
            lbOutput.Items.Clear();
        }

        //Close program.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}