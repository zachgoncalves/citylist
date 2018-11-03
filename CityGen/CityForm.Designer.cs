namespace CityGen
{
    partial class CityForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnNameOK = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnEnterCity = new System.Windows.Forms.Button();
            this.btnSearchCity = new System.Windows.Forms.Button();
            this.pnlEnterCity = new System.Windows.Forms.Panel();
            this.lblCityEntry = new System.Windows.Forms.Label();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.txtCityState = new System.Windows.Forms.TextBox();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.lblKeywords = new System.Windows.Forms.Label();
            this.lblCityState = new System.Windows.Forms.Label();
            this.lblCityName = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlEnterCity.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(377, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 0;
            // 
            // btnNameOK
            // 
            this.btnNameOK.Location = new System.Drawing.Point(503, 63);
            this.btnNameOK.Name = "btnNameOK";
            this.btnNameOK.Size = new System.Drawing.Size(53, 35);
            this.btnNameOK.TabIndex = 1;
            this.btnNameOK.Text = "OK";
            this.btnNameOK.UseVisualStyleBackColor = true;
            this.btnNameOK.Click += new System.EventHandler(this.btnNameOK_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(223, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(128, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Enter your Name";
            // 
            // btnEnterCity
            // 
            this.btnEnterCity.Enabled = false;
            this.btnEnterCity.Location = new System.Drawing.Point(291, 124);
            this.btnEnterCity.Name = "btnEnterCity";
            this.btnEnterCity.Size = new System.Drawing.Size(106, 38);
            this.btnEnterCity.TabIndex = 3;
            this.btnEnterCity.Text = "Enter City";
            this.btnEnterCity.UseVisualStyleBackColor = true;
            this.btnEnterCity.Click += new System.EventHandler(this.btnEnterCity_Click);
            // 
            // btnSearchCity
            // 
            this.btnSearchCity.Enabled = false;
            this.btnSearchCity.Location = new System.Drawing.Point(426, 124);
            this.btnSearchCity.Name = "btnSearchCity";
            this.btnSearchCity.Size = new System.Drawing.Size(90, 38);
            this.btnSearchCity.TabIndex = 4;
            this.btnSearchCity.Text = "Search";
            this.btnSearchCity.UseVisualStyleBackColor = true;
            this.btnSearchCity.Click += new System.EventHandler(this.btnSearchCity_Click);
            // 
            // pnlEnterCity
            // 
            this.pnlEnterCity.Controls.Add(this.lblCityEntry);
            this.pnlEnterCity.Controls.Add(this.txtKeywords);
            this.pnlEnterCity.Controls.Add(this.txtCityState);
            this.pnlEnterCity.Controls.Add(this.txtCityName);
            this.pnlEnterCity.Controls.Add(this.lblKeywords);
            this.pnlEnterCity.Controls.Add(this.lblCityState);
            this.pnlEnterCity.Controls.Add(this.lblCityName);
            this.pnlEnterCity.Location = new System.Drawing.Point(105, 208);
            this.pnlEnterCity.Name = "pnlEnterCity";
            this.pnlEnterCity.Size = new System.Drawing.Size(272, 215);
            this.pnlEnterCity.TabIndex = 5;
            this.pnlEnterCity.Visible = false;
            // 
            // lblCityEntry
            // 
            this.lblCityEntry.AutoSize = true;
            this.lblCityEntry.Location = new System.Drawing.Point(17, 11);
            this.lblCityEntry.Name = "lblCityEntry";
            this.lblCityEntry.Size = new System.Drawing.Size(78, 20);
            this.lblCityEntry.TabIndex = 7;
            this.lblCityEntry.Text = "Enter City";
            // 
            // txtKeywords
            // 
            this.txtKeywords.Location = new System.Drawing.Point(137, 131);
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.Size = new System.Drawing.Size(100, 26);
            this.txtKeywords.TabIndex = 5;
            // 
            // txtCityState
            // 
            this.txtCityState.Location = new System.Drawing.Point(137, 92);
            this.txtCityState.Name = "txtCityState";
            this.txtCityState.Size = new System.Drawing.Size(100, 26);
            this.txtCityState.TabIndex = 4;
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(137, 50);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(100, 26);
            this.txtCityName.TabIndex = 3;
            // 
            // lblKeywords
            // 
            this.lblKeywords.AutoSize = true;
            this.lblKeywords.Location = new System.Drawing.Point(17, 134);
            this.lblKeywords.Name = "lblKeywords";
            this.lblKeywords.Size = new System.Drawing.Size(77, 20);
            this.lblKeywords.TabIndex = 2;
            this.lblKeywords.Text = "Keywords";
            // 
            // lblCityState
            // 
            this.lblCityState.AutoSize = true;
            this.lblCityState.Location = new System.Drawing.Point(17, 98);
            this.lblCityState.Name = "lblCityState";
            this.lblCityState.Size = new System.Drawing.Size(78, 20);
            this.lblCityState.TabIndex = 1;
            this.lblCityState.Text = "City State";
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Location = new System.Drawing.Point(17, 57);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(81, 20);
            this.lblCityName.TabIndex = 0;
            this.lblCityName.Text = "City Name";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lblSearchTitle);
            this.pnlSearch.Location = new System.Drawing.Point(445, 208);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(200, 215);
            this.pnlSearch.TabIndex = 6;
            this.pnlSearch.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(24, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(157, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearchTitle
            // 
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Location = new System.Drawing.Point(20, 11);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Size = new System.Drawing.Size(123, 20);
            this.lblSearchTitle.TabIndex = 0;
            this.lblSearchTitle.Text = "Search for a city";
            // 
            // btnProcess
            // 
            this.btnProcess.Enabled = false;
            this.btnProcess.Location = new System.Drawing.Point(315, 461);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(179, 49);
            this.btnProcess.TabIndex = 7;
            this.btnProcess.Text = "Process Action";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(650, 474);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 36);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 536);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlEnterCity);
            this.Controls.Add(this.btnSearchCity);
            this.Controls.Add(this.btnEnterCity);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnNameOK);
            this.Controls.Add(this.txtName);
            this.Name = "CityForm";
            this.Text = "City Searcher";
            this.pnlEnterCity.ResumeLayout(false);
            this.pnlEnterCity.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnNameOK;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnEnterCity;
        private System.Windows.Forms.Button btnSearchCity;
        private System.Windows.Forms.Panel pnlEnterCity;
        private System.Windows.Forms.Label lblCityEntry;
        private System.Windows.Forms.TextBox txtKeywords;
        private System.Windows.Forms.TextBox txtCityState;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Label lblKeywords;
        private System.Windows.Forms.Label lblCityState;
        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnExit;
    }
}

