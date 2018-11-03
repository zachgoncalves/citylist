/* Author: Zach Goncalves
 * Temple University / October 10 2018 / CIS 3309 / Mid Term Exam
 * Form: CityForm
 */
using System;
using System.Windows.Forms;
using CityGen.Classes; 

namespace CityGen
{
    public partial class CityForm : Form
    {
        string name;
        int selectedAction;
        City newCity;
        CityList listOfCities = new CityList();

        public CityForm()
        {
            InitializeComponent();
        }

        // Ensures user inputs non-blank name and enabled city action buttons
        private void btnNameOK_Click(object sender, EventArgs e)
        {
            try
            {
                name = txtName.Text.ToString();
                btnEnterCity.Enabled = true;
                btnSearchCity.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Please enter a name.", "Error");
            }
        }

        // Enables enter city info panel
        private void btnEnterCity_Click(object sender, EventArgs e)
        {
            pnlEnterCity.Visible = true;
            btnSearchCity.Enabled = false;
            btnProcess.Enabled = true;
            selectedAction = 1;
        }
        
        // Enables search city panel
        private void btnSearchCity_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = true;
            btnEnterCity.Enabled = false;
            btnProcess.Enabled = true; 
            selectedAction = 2;
        }

        // Processes action selected by user and resets form.
        private void btnProcess_Click(object sender, EventArgs e)
        {
            if(selectedAction == 1)
            {
                try
                {
                    newCity = new City(txtCityName.Text.ToString(), txtCityState.Text.ToString(), txtKeywords.Text.ToString());
                    listOfCities.addCity(newCity);
                }
                catch
                {

                }
            }
            else if (selectedAction == 2)
            {
                bool isFound = false;
                string cityReturn = listOfCities.searchList(txtSearch.Text.ToString(), ref isFound);
                if(isFound)
                {
                    MessageBox.Show(cityReturn, "Success!");
                }
                else
                {
                    MessageBox.Show("No match was found, please try again","Failed");
                }
            }
            pnlEnterCity.Visible = false;
            pnlSearch.Visible = false;
            btnProcess.Enabled = false;
            btnSearchCity.Enabled = true;
            btnEnterCity.Enabled = true;
            txtSearch.Text = "";
            txtCityName.Text = "";
            txtCityState.Text = "";
            txtKeywords.Text = "";
        }

        // Shows information about what user entered. Writes out form. Closes form.
        private void btnExit_Click(object sender, EventArgs e)
        {
            string outputInfo = "Number of Cities: " + listOfCities.getNumCities() + "\n" + 
                listOfCities.getNumSearches() + "\n" + "\n" +  "List of all Cities:" + "\n" + listOfCities.getAllCities(); 
            MessageBox.Show(outputInfo, "Program Completed");
            listOfCities.writeOutCities();
            Close();
        }
    }
}
