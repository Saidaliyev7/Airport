namespace Airport
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Companycb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Countrycb = new System.Windows.Forms.ComboBox();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportDataSet = new Airport.AirportDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.Citycb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.arivalbtn = new System.Windows.Forms.RadioButton();
            this.departurebtn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.Runwaycb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Gatecb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FlightDate = new System.Windows.Forms.DateTimePicker();
            this.AddFlightbtn = new System.Windows.Forms.Button();
            this.Flightdgv = new System.Windows.Forms.DataGridView();
            this.airportDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.citiesTableAdapter = new Airport.AirportDataSetTableAdapters.CitiesTableAdapter();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flightdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Companycb
            // 
            this.Companycb.FormattingEnabled = true;
            this.Companycb.Location = new System.Drawing.Point(51, 61);
            this.Companycb.Name = "Companycb";
            this.Companycb.Size = new System.Drawing.Size(173, 24);
            this.Companycb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Country";
            // 
            // Countrycb
            // 
            this.Countrycb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.citiesBindingSource, "Name", true));
            this.Countrycb.FormattingEnabled = true;
            this.Countrycb.Location = new System.Drawing.Point(51, 157);
            this.Countrycb.Name = "Countrycb";
            this.Countrycb.Size = new System.Drawing.Size(173, 24);
            this.Countrycb.TabIndex = 2;
            this.Countrycb.SelectedIndexChanged += new System.EventHandler(this.Countrycb_SelectedIndexChanged);
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.airportDataSet;
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "City";
            // 
            // Citycb
            // 
            this.Citycb.FormattingEnabled = true;
            this.Citycb.Location = new System.Drawing.Point(51, 259);
            this.Citycb.Name = "Citycb";
            this.Citycb.Size = new System.Drawing.Size(173, 24);
            this.Citycb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type";
            // 
            // arivalbtn
            // 
            this.arivalbtn.AutoSize = true;
            this.arivalbtn.Location = new System.Drawing.Point(395, 63);
            this.arivalbtn.Name = "arivalbtn";
            this.arivalbtn.Size = new System.Drawing.Size(69, 21);
            this.arivalbtn.TabIndex = 8;
            this.arivalbtn.Text = "Arrival";
            this.arivalbtn.UseVisualStyleBackColor = true;
            // 
            // departurebtn
            // 
            this.departurebtn.AutoSize = true;
            this.departurebtn.Location = new System.Drawing.Point(480, 64);
            this.departurebtn.Name = "departurebtn";
            this.departurebtn.Size = new System.Drawing.Size(93, 21);
            this.departurebtn.TabIndex = 9;
            this.departurebtn.TabStop = true;
            this.departurebtn.Text = "Departure";
            this.departurebtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Runway";
            // 
            // Runwaycb
            // 
            this.Runwaycb.FormattingEnabled = true;
            this.Runwaycb.Location = new System.Drawing.Point(395, 259);
            this.Runwaycb.Name = "Runwaycb";
            this.Runwaycb.Size = new System.Drawing.Size(173, 24);
            this.Runwaycb.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gate";
            // 
            // Gatecb
            // 
            this.Gatecb.FormattingEnabled = true;
            this.Gatecb.Location = new System.Drawing.Point(395, 157);
            this.Gatecb.Name = "Gatecb";
            this.Gatecb.Size = new System.Drawing.Size(173, 24);
            this.Gatecb.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(788, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date";
            // 
            // FlightDate
            // 
            this.FlightDate.Location = new System.Drawing.Point(716, 64);
            this.FlightDate.Name = "FlightDate";
            this.FlightDate.Size = new System.Drawing.Size(230, 22);
            this.FlightDate.TabIndex = 15;
            // 
            // AddFlightbtn
            // 
            this.AddFlightbtn.Location = new System.Drawing.Point(716, 195);
            this.AddFlightbtn.Name = "AddFlightbtn";
            this.AddFlightbtn.Size = new System.Drawing.Size(252, 47);
            this.AddFlightbtn.TabIndex = 16;
            this.AddFlightbtn.Text = "Add Flight";
            this.AddFlightbtn.UseVisualStyleBackColor = true;
            this.AddFlightbtn.Click += new System.EventHandler(this.AddFlightbtn_Click);
            // 
            // Flightdgv
            // 
            this.Flightdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Flightdgv.Location = new System.Drawing.Point(12, 357);
            this.Flightdgv.Name = "Flightdgv";
            this.Flightdgv.RowTemplate.Height = 24;
            this.Flightdgv.Size = new System.Drawing.Size(1149, 334);
            this.Flightdgv.TabIndex = 17;
            this.Flightdgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Flightdgv_RowHeaderMouseDoubleClick);
            // 
            // airportDataSetBindingSource
            // 
            this.airportDataSetBindingSource.DataSource = this.airportDataSet;
            this.airportDataSetBindingSource.Position = 0;
            // 
            // airportDataSetBindingSource1
            // 
            this.airportDataSetBindingSource1.DataSource = this.airportDataSet;
            this.airportDataSetBindingSource1.Position = 0;
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(716, 136);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(252, 45);
            this.Deletebtn.TabIndex = 18;
            this.Deletebtn.Text = "Remove Flight";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Visible = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(716, 259);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(252, 45);
            this.Updatebtn.TabIndex = 19;
            this.Updatebtn.Text = "Update Flight";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Visible = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 703);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Flightdgv);
            this.Controls.Add(this.AddFlightbtn);
            this.Controls.Add(this.FlightDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Runwaycb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Gatecb);
            this.Controls.Add(this.departurebtn);
            this.Controls.Add(this.arivalbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Citycb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Countrycb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Companycb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flightdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Companycb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Countrycb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Citycb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton arivalbtn;
        private System.Windows.Forms.RadioButton departurebtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Runwaycb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Gatecb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker FlightDate;
        private System.Windows.Forms.Button AddFlightbtn;
        private System.Windows.Forms.DataGridView Flightdgv;
        private System.Windows.Forms.BindingSource airportDataSetBindingSource1;
        private AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource airportDataSetBindingSource;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private AirportDataSetTableAdapters.CitiesTableAdapter citiesTableAdapter;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Updatebtn;
    }
}

