//Solution: T-Shirt Inventory Tracker
//Author: Joel Luthi
//Date: 10/29/2022
//Purpose: My milstone project demonstrating an inventory system.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_ShirtInventoryTracker
{
    public partial class frmMain : Form
    {

        private Shirt _ItemInEdit = null;

        public InventoryManager _InventoryManager = new InventoryManager();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Start ID's at 1000;
            txtShirtId.Text = "1000";

            LoadColorComboBox();
            LoadSizeComboBox();

            txtDescription.Select();

        }

        //Populates the Color ComboBox
        private void LoadColorComboBox()
        {
            cboColor.Items.Add("Black");
            cboColor.Items.Add("Blue");
            cboColor.Items.Add("Brown");
            cboColor.Items.Add("Green");
            cboColor.Items.Add("Orange");
            cboColor.Items.Add("Pink");
            cboColor.Items.Add("Purple");
            cboColor.Items.Add("Red");
            cboColor.Items.Add("White");
            cboColor.Items.Add("Yellow");
        }

        //Populates the Size ComboBox
        private void LoadSizeComboBox()
        {
            cboSize.Items.Add("Ex-Small");
            cboSize.Items.Add("Small");
            cboSize.Items.Add("Regular");
            cboSize.Items.Add("Large");
            cboSize.Items.Add("Ex-Large");
            cboSize.Items.Add("Ex-Ex-Large");
        }

        //Cancel the item that is edit from being edited.
        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            _ItemInEdit = null;
            txtShirtId.ReadOnly = false;

            ResetValues();


            btnCancelEdit.Enabled = false;

        }


        //Add/Edit Shirt to Inventory.
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FieldsValid())
            {
                if (_ItemInEdit == null)
                {
                    Shirt newShirt = new Shirt();

                    newShirt.ShirtID = int.Parse(txtShirtId.Text);
                    newShirt.Description = txtDescription.Text;
                    newShirt.Gender = rdbFemale.Checked ? "Female" : "Male";
                    newShirt.Color = cboColor.Text.ToString();
                    newShirt.Size = cboSize.Text.ToString();
                    newShirt.Price = decimal.Parse(txtPrice.Text);
                    newShirt.Qty = int.Parse(txtQty.Text);


                    _InventoryManager.AddShirt(newShirt);

                    MessageBox.Show("New Shirt Added");

                }
                else
                {
                    _ItemInEdit.Description = txtDescription.Text;
                    _ItemInEdit.Gender = rdbFemale.Checked ? "Female" : "Male";
                    _ItemInEdit.Color = cboColor.SelectedItem.ToString();
                    _ItemInEdit.Size = cboSize.SelectedItem.ToString();
                    _ItemInEdit.Price = decimal.Parse(txtPrice.Text);
                    _ItemInEdit.Qty = int.Parse(txtQty.Text);

                    MessageBox.Show("Existing Shirt Updated");

                    txtShirtId.ReadOnly = false;


                }

                //Refresh listbox to show changes.
                _InventoryManager.OutputInventory(lbShirts);

                ResetValues();



            }
            else
            {
                MessageBox.Show("All fields must have a value for new shirt.", "Unable to Add Shirt", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }



        //Check if fields are all populated.
        public bool FieldsValid()
        {
            //Check string fields.
            if (string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(cboColor.Text) || string.IsNullOrEmpty(cboSize.Text))
                return false;

            //Check numeric fields for value.
            if (!int.TryParse(txtPrice.Text, out _) || int.Parse(txtPrice.Text) == 0 || !int.TryParse(txtQty.Text, out _) || int.Parse(txtPrice.Text) == 0)
                return false;


            return true;
        }


        //Increments Qty TextBox by +1 when Clicked
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQty.Text, out _))
            {
                txtQty.Text = (int.Parse(txtQty.Text) + 1).ToString();
            }
        }

        //Increments Qty TextBox by +1 when Clicked
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQty.Text, out _))
            {
                txtQty.Text = (int.Parse(txtQty.Text) - 1).ToString();
            }
        }


        //Removes Shirt from Inventory.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbShirts.SelectedItem != null)
            {
                if (MessageBox.Show("Are you sure you wish to remove this shirt? \n\n" + lbShirts.SelectedItem.ToString(), "Remove Shirt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _InventoryManager.RemoveShirt((Shirt)lbShirts.SelectedItem);

                    //Update listbox control
                    _InventoryManager.OutputInventory(lbShirts);
                }

            }
            else
            {
                MessageBox.Show("Nothing Selected to Delete");
            }

        }

        //Restocks Selected Shirt in ListBox.
        private void btnRestock_Click(object sender, EventArgs e)
        {

            if (lbShirts.SelectedItem != null)
            {
                frmRestock frm = new frmRestock();
                frm.ShowDialog();

                //If user hit the restock button, get the restock amount.
                if (frm.DialogResult == DialogResult.OK)
                {
                    ((Shirt)lbShirts.SelectedItem).Qty += frm.RestockAmount;

                    //Update listbox control
                    _InventoryManager.OutputInventory(lbShirts);
                }
            }
            else
            {
                MessageBox.Show("Nothing Selected to Restock");
            }


        }

        //Finds Shirt by ShirtID or Description.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbtnSearchByDescription.Checked)
            {
                Shirt shirt = _InventoryManager.SearchShirt(txtSearch.Text);

                if (shirt != null)
                {
                    //Select shirt in ListBox for user.
                    lbShirts.SelectedItem = shirt;


                    MessageBox.Show(shirt.ToString(), "Shirt Found!");

                }
                else
                {
                    MessageBox.Show("Shirt Not Found");
                }
            }
            else
            {
                if (int.TryParse(txtSearch.Text, out _))
                {
                    Shirt shirt = _InventoryManager.SearchShirt(int.Parse(txtSearch.Text));

                    if (shirt != null)
                    {

                        //Select shirt in ListBox for user.
                        lbShirts.SelectedItem = shirt;

                        MessageBox.Show(shirt.ToString(), "Shirt Found!");

                    }
                    else
                    {
                        MessageBox.Show("Shirt Not Found");
                    }

                }
                else
                {
                    MessageBox.Show("Must be Numeric to search Shirt By ID");

                }
            }
        }

        //If user double clicks on item in ListBox, show extra detail.
        private void lbShirts_DoubleClick(object sender, EventArgs e)
        {
            if (lbShirts.SelectedItem != null)
            {
                MessageBox.Show(((Shirt)lbShirts.SelectedItem).ToStringLong(), "Selected Shirt Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        //Close program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Edit currently selected item in listbox.
        private void btnEdit_Click(object sender, EventArgs e)
        {
        
            if (lbShirts.SelectedItem != null)
            {
                _ItemInEdit = (Shirt) lbShirts.SelectedItem;

                txtShirtId.ReadOnly = true;
                txtShirtId.Text = _ItemInEdit.ShirtID.ToString();
                txtDescription.Text = _ItemInEdit.Description;
                cboColor.SelectedItem = _ItemInEdit.Color;
                cboSize.SelectedItem = _ItemInEdit.Size;
                txtPrice.Text = _ItemInEdit.Price.ToString();
                txtQty.Text = _ItemInEdit.Qty.ToString();



                //Allow user to cancel out of the edit at any time if the decide not to save changes.
                btnCancelEdit.Enabled = true;
            }
        }

      


        //Move Selection Up the ListBox.
        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (lbShirts.SelectedItems != null)
            {
                bool matchFound = false;

                for (int i = lbShirts.Items.Count - 1; i >= 0; i--)
                {
                    if (matchFound)
                    {
                        lbShirts.SelectedItem = lbShirts.Items[i];
                        break;
                    }

                    if (lbShirts.Items[i] == lbShirts.SelectedItem)
                    {
                        matchFound = true;
                    }
                }
            }

        }


        //Move Selection Down the ListBox.
        private void btnMoveDown_Click(object sender, EventArgs e)
        {

            bool matchFound = false;

            for (int i = 0; i < lbShirts.Items.Count; i++)
            {
                if (matchFound)
                {
                    lbShirts.SelectedItem = lbShirts.Items[i];
                    break;
                }

                if (lbShirts.Items[i] == lbShirts.SelectedItem)
                {
                    matchFound = true;
                }
            }
        }

      

        //Reset all selections & fields in the right pane.
        private void ResetValues()
        {
            txtShirtId.Text = String.Empty;
            txtDescription.Text = String.Empty;
            rdbMale.Checked = true;
            cboColor.SelectedItem = null;
            cboSize.SelectedItem = null;
            txtPrice.Text = "0";
            txtQty.Text = "0";


            SetNextAvailableShirtID();
        }



        //Get next available id for next shirt.
        private void SetNextAvailableShirtID()
        {
            int highestID = 0;

            foreach (var shirt in _InventoryManager.GetShirts())
            {
                if (highestID < shirt.ShirtID)
                    highestID = shirt.ShirtID;
            }

            txtShirtId.Text = (highestID + 1).ToString();
        }

        //Disable / Enable buttons depending if there is a selction in the ListBox or not.
        private void lbShirts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbShirts.SelectedIndex >= 0)
            {
                btnMoveUp.Enabled = true;
                btnMoveDown.Enabled = true;

                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnRestock.Enabled = true;
            }
            else
            {
                btnMoveUp.Enabled = false;
                btnMoveDown.Enabled = false;

                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                btnRestock.Enabled = false;
            }
        }
    }
}
