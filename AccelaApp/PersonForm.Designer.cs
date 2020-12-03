
namespace AccelaApp
{
    partial class PersonForm
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.AddressPersonIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.StateTexBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnListPersons = new System.Windows.Forms.Button();
            this.btnCountPersons = new System.Windows.Forms.Button();
            this.PersonCountTextBox = new System.Windows.Forms.TextBox();
            this.lblDeleteAddress = new System.Windows.Forms.Label();
            this.DeleteAddressTextBox = new System.Windows.Forms.TextBox();
            this.btnDeleteAddress = new System.Windows.Forms.Button();
            this.PersonListView = new System.Windows.Forms.ListView();
            this.EditAddressPostalCodeTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EditAddressStateTextbox = new System.Windows.Forms.TextBox();
            this.EditAddressCityTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditAddress = new System.Windows.Forms.Button();
            this.EditAddressStreetTextbox = new System.Windows.Forms.TextBox();
            this.EditAddressIdTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAddressID = new System.Windows.Forms.Label();
            this.btnEditPerson = new System.Windows.Forms.Button();
            this.LastNameEditTextbox = new System.Windows.Forms.TextBox();
            this.FirstNameEditTextbox = new System.Windows.Forms.TextBox();
            this.lblEditLastName = new System.Windows.Forms.Label();
            this.lblFirstNameEdit = new System.Windows.Forms.Label();
            this.lblEditTitle = new System.Windows.Forms.Label();
            this.EditPersonIDTextbox = new System.Windows.Forms.TextBox();
            this.lblPersonIDEdit = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.XMLReadTextBox = new System.Windows.Forms.TextBox();
            this.btnReadXML = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pERSONIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLPERSONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(21, 121);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(21, 155);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(88, 118);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(88, 151);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTextBox.TabIndex = 2;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(205, 137);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 23);
            this.btnAddPerson.TabIndex = 3;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(524, 116);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Person";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(381, 121);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(418, 118);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 10;
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(195, 275);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(75, 23);
            this.btnAddAddress.TabIndex = 9;
            this.btnAddAddress.Text = "Add Address";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(88, 249);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(100, 20);
            this.StreetTextBox.TabIndex = 5;
            // 
            // AddressPersonIDTextBox
            // 
            this.AddressPersonIDTextBox.Location = new System.Drawing.Point(89, 223);
            this.AddressPersonIDTextBox.Name = "AddressPersonIDTextBox";
            this.AddressPersonIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddressPersonIDTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Street:";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Location = new System.Drawing.Point(21, 226);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(57, 13);
            this.lblPersonID.TabIndex = 8;
            this.lblPersonID.Text = "Person ID:";
            // 
            // StateTexBox
            // 
            this.StateTexBox.Location = new System.Drawing.Point(88, 303);
            this.StateTexBox.Name = "StateTexBox";
            this.StateTexBox.Size = new System.Drawing.Size(100, 20);
            this.StateTexBox.TabIndex = 7;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(88, 277);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(100, 20);
            this.CityTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "State:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "City:";
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.Location = new System.Drawing.Point(88, 329);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.PostalCodeTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Postal Code:";
            // 
            // btnListPersons
            // 
            this.btnListPersons.Location = new System.Drawing.Point(452, 324);
            this.btnListPersons.Name = "btnListPersons";
            this.btnListPersons.Size = new System.Drawing.Size(100, 23);
            this.btnListPersons.TabIndex = 15;
            this.btnListPersons.Text = "List Persons";
            this.btnListPersons.UseVisualStyleBackColor = true;
            this.btnListPersons.Click += new System.EventHandler(this.btnListPersons_Click);
            // 
            // btnCountPersons
            // 
            this.btnCountPersons.Location = new System.Drawing.Point(688, 181);
            this.btnCountPersons.Name = "btnCountPersons";
            this.btnCountPersons.Size = new System.Drawing.Size(100, 23);
            this.btnCountPersons.TabIndex = 21;
            this.btnCountPersons.Text = "Count Persons";
            this.btnCountPersons.UseVisualStyleBackColor = true;
            this.btnCountPersons.Click += new System.EventHandler(this.btnCountPersons_Click);
            // 
            // PersonCountTextBox
            // 
            this.PersonCountTextBox.Location = new System.Drawing.Point(688, 155);
            this.PersonCountTextBox.Name = "PersonCountTextBox";
            this.PersonCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.PersonCountTextBox.TabIndex = 22;
            // 
            // lblDeleteAddress
            // 
            this.lblDeleteAddress.AutoSize = true;
            this.lblDeleteAddress.Location = new System.Drawing.Point(381, 150);
            this.lblDeleteAddress.Name = "lblDeleteAddress";
            this.lblDeleteAddress.Size = new System.Drawing.Size(21, 13);
            this.lblDeleteAddress.TabIndex = 23;
            this.lblDeleteAddress.Text = "ID:";
            // 
            // DeleteAddressTextBox
            // 
            this.DeleteAddressTextBox.Location = new System.Drawing.Point(418, 147);
            this.DeleteAddressTextBox.Name = "DeleteAddressTextBox";
            this.DeleteAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.DeleteAddressTextBox.TabIndex = 12;
            // 
            // btnDeleteAddress
            // 
            this.btnDeleteAddress.Location = new System.Drawing.Point(524, 145);
            this.btnDeleteAddress.Name = "btnDeleteAddress";
            this.btnDeleteAddress.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteAddress.TabIndex = 13;
            this.btnDeleteAddress.Text = "Delete Address";
            this.btnDeleteAddress.UseVisualStyleBackColor = true;
            this.btnDeleteAddress.Click += new System.EventHandler(this.btnDeleteAddress_Click);
            // 
            // PersonListView
            // 
            this.PersonListView.HideSelection = false;
            this.PersonListView.Location = new System.Drawing.Point(350, 200);
            this.PersonListView.Name = "PersonListView";
            this.PersonListView.Size = new System.Drawing.Size(305, 97);
            this.PersonListView.TabIndex = 14;
            this.PersonListView.UseCompatibleStateImageBehavior = false;
            // 
            // EditAddressPostalCodeTextbox
            // 
            this.EditAddressPostalCodeTextbox.Location = new System.Drawing.Point(178, 521);
            this.EditAddressPostalCodeTextbox.Name = "EditAddressPostalCodeTextbox";
            this.EditAddressPostalCodeTextbox.Size = new System.Drawing.Size(100, 20);
            this.EditAddressPostalCodeTextbox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Postal Code:";
            // 
            // EditAddressStateTextbox
            // 
            this.EditAddressStateTextbox.Location = new System.Drawing.Point(178, 495);
            this.EditAddressStateTextbox.Name = "EditAddressStateTextbox";
            this.EditAddressStateTextbox.Size = new System.Drawing.Size(100, 20);
            this.EditAddressStateTextbox.TabIndex = 19;
            // 
            // EditAddressCityTextbox
            // 
            this.EditAddressCityTextbox.Location = new System.Drawing.Point(178, 469);
            this.EditAddressCityTextbox.Name = "EditAddressCityTextbox";
            this.EditAddressCityTextbox.Size = new System.Drawing.Size(100, 20);
            this.EditAddressCityTextbox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "State:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "City:";
            // 
            // btnEditAddress
            // 
            this.btnEditAddress.Location = new System.Drawing.Point(285, 467);
            this.btnEditAddress.Name = "btnEditAddress";
            this.btnEditAddress.Size = new System.Drawing.Size(75, 23);
            this.btnEditAddress.TabIndex = 21;
            this.btnEditAddress.Text = "Edit Address";
            this.btnEditAddress.UseVisualStyleBackColor = true;
            this.btnEditAddress.Click += new System.EventHandler(this.btnEditAddress_Click);
            // 
            // EditAddressStreetTextbox
            // 
            this.EditAddressStreetTextbox.Location = new System.Drawing.Point(178, 441);
            this.EditAddressStreetTextbox.Name = "EditAddressStreetTextbox";
            this.EditAddressStreetTextbox.Size = new System.Drawing.Size(100, 20);
            this.EditAddressStreetTextbox.TabIndex = 17;
            // 
            // EditAddressIdTextbox
            // 
            this.EditAddressIdTextbox.Location = new System.Drawing.Point(179, 415);
            this.EditAddressIdTextbox.Name = "EditAddressIdTextbox";
            this.EditAddressIdTextbox.Size = new System.Drawing.Size(100, 20);
            this.EditAddressIdTextbox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Street:";
            // 
            // lblAddressID
            // 
            this.lblAddressID.AutoSize = true;
            this.lblAddressID.Location = new System.Drawing.Point(111, 418);
            this.lblAddressID.Name = "lblAddressID";
            this.lblAddressID.Size = new System.Drawing.Size(62, 13);
            this.lblAddressID.TabIndex = 34;
            this.lblAddressID.Text = "Address ID:";
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Location = new System.Drawing.Point(628, 466);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(75, 23);
            this.btnEditPerson.TabIndex = 25;
            this.btnEditPerson.Text = "Edit Person";
            this.btnEditPerson.UseVisualStyleBackColor = true;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // LastNameEditTextbox
            // 
            this.LastNameEditTextbox.Location = new System.Drawing.Point(505, 499);
            this.LastNameEditTextbox.Name = "LastNameEditTextbox";
            this.LastNameEditTextbox.Size = new System.Drawing.Size(100, 20);
            this.LastNameEditTextbox.TabIndex = 24;
            // 
            // FirstNameEditTextbox
            // 
            this.FirstNameEditTextbox.Location = new System.Drawing.Point(505, 466);
            this.FirstNameEditTextbox.Name = "FirstNameEditTextbox";
            this.FirstNameEditTextbox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameEditTextbox.TabIndex = 23;
            // 
            // lblEditLastName
            // 
            this.lblEditLastName.AutoSize = true;
            this.lblEditLastName.Location = new System.Drawing.Point(438, 503);
            this.lblEditLastName.Name = "lblEditLastName";
            this.lblEditLastName.Size = new System.Drawing.Size(61, 13);
            this.lblEditLastName.TabIndex = 26;
            this.lblEditLastName.Text = "Last Name:";
            // 
            // lblFirstNameEdit
            // 
            this.lblFirstNameEdit.AutoSize = true;
            this.lblFirstNameEdit.Location = new System.Drawing.Point(438, 469);
            this.lblFirstNameEdit.Name = "lblFirstNameEdit";
            this.lblFirstNameEdit.Size = new System.Drawing.Size(60, 13);
            this.lblFirstNameEdit.TabIndex = 24;
            this.lblFirstNameEdit.Text = "First Name:";
            // 
            // lblEditTitle
            // 
            this.lblEditTitle.AutoSize = true;
            this.lblEditTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTitle.Location = new System.Drawing.Point(274, 371);
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new System.Drawing.Size(221, 25);
            this.lblEditTitle.TabIndex = 40;
            this.lblEditTitle.Text = "EDIT FUNCTIONALITY";
            // 
            // EditPersonIDTextbox
            // 
            this.EditPersonIDTextbox.Location = new System.Drawing.Point(505, 432);
            this.EditPersonIDTextbox.Name = "EditPersonIDTextbox";
            this.EditPersonIDTextbox.Size = new System.Drawing.Size(100, 20);
            this.EditPersonIDTextbox.TabIndex = 22;
            // 
            // lblPersonIDEdit
            // 
            this.lblPersonIDEdit.AutoSize = true;
            this.lblPersonIDEdit.Location = new System.Drawing.Point(438, 435);
            this.lblPersonIDEdit.Name = "lblPersonIDEdit";
            this.lblPersonIDEdit.Size = new System.Drawing.Size(57, 13);
            this.lblPersonIDEdit.TabIndex = 41;
            this.lblPersonIDEdit.Text = "Person ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 25);
            this.label9.TabIndex = 42;
            this.label9.Text = "ADD FUNCTIONALITY";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(354, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(380, 25);
            this.label10.TabIndex = 43;
            this.label10.Text = "DELETE/COUNT/LIST FUNCTIONALITY";
            // 
            // XMLReadTextBox
            // 
            this.XMLReadTextBox.Location = new System.Drawing.Point(280, 567);
            this.XMLReadTextBox.Name = "XMLReadTextBox";
            this.XMLReadTextBox.Size = new System.Drawing.Size(132, 20);
            this.XMLReadTextBox.TabIndex = 44;
            // 
            // btnReadXML
            // 
            this.btnReadXML.Location = new System.Drawing.Point(418, 565);
            this.btnReadXML.Name = "btnReadXML";
            this.btnReadXML.Size = new System.Drawing.Size(64, 23);
            this.btnReadXML.TabIndex = 45;
            this.btnReadXML.Text = "XML";
            this.btnReadXML.UseVisualStyleBackColor = true;
            this.btnReadXML.Click += new System.EventHandler(this.btnReadXML_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pERSONIDDataGridViewTextBoxColumn,
            this.fIRSTNAMEDataGridViewTextBoxColumn,
            this.lASTNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLPERSONBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(179, 638);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(396, 150);
            this.dataGridView1.TabIndex = 46;
            // 
            // pERSONIDDataGridViewTextBoxColumn
            // 
            this.pERSONIDDataGridViewTextBoxColumn.DataPropertyName = "PERSON_ID";
            this.pERSONIDDataGridViewTextBoxColumn.HeaderText = "PERSON_ID";
            this.pERSONIDDataGridViewTextBoxColumn.Name = "pERSONIDDataGridViewTextBoxColumn";
            this.pERSONIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.fIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST_NAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRST_NAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.Name = "fIRSTNAMEDataGridViewTextBoxColumn";
            // 
            // lASTNAMEDataGridViewTextBoxColumn
            // 
            this.lASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST_NAME";
            this.lASTNAMEDataGridViewTextBoxColumn.HeaderText = "LAST_NAME";
            this.lASTNAMEDataGridViewTextBoxColumn.Name = "lASTNAMEDataGridViewTextBoxColumn";
            // 
            // tBLPERSONBindingSource
            // 
            this.tBLPERSONBindingSource.DataMember = "TBL_PERSON";
            // 
            // accelaDataSet
            // 
            // 
            // tBL_PERSONTableAdapter
            // 
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 860);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReadXML);
            this.Controls.Add(this.XMLReadTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EditPersonIDTextbox);
            this.Controls.Add(this.lblPersonIDEdit);
            this.Controls.Add(this.lblEditTitle);
            this.Controls.Add(this.EditAddressPostalCodeTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditAddressStateTextbox);
            this.Controls.Add(this.EditAddressCityTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEditAddress);
            this.Controls.Add(this.EditAddressStreetTextbox);
            this.Controls.Add(this.EditAddressIdTextbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblAddressID);
            this.Controls.Add(this.btnEditPerson);
            this.Controls.Add(this.LastNameEditTextbox);
            this.Controls.Add(this.FirstNameEditTextbox);
            this.Controls.Add(this.lblEditLastName);
            this.Controls.Add(this.lblFirstNameEdit);
            this.Controls.Add(this.PersonListView);
            this.Controls.Add(this.btnDeleteAddress);
            this.Controls.Add(this.DeleteAddressTextBox);
            this.Controls.Add(this.lblDeleteAddress);
            this.Controls.Add(this.PersonCountTextBox);
            this.Controls.Add(this.btnCountPersons);
            this.Controls.Add(this.btnListPersons);
            this.Controls.Add(this.PostalCodeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StateTexBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddAddress);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.AddressPersonIDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "PersonForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PersonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox AddressPersonIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.TextBox StateTexBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PostalCodeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnListPersons;
        private System.Windows.Forms.Button btnCountPersons;
        private System.Windows.Forms.TextBox PersonCountTextBox;
        private System.Windows.Forms.Label lblDeleteAddress;
        private System.Windows.Forms.TextBox DeleteAddressTextBox;
        private System.Windows.Forms.Button btnDeleteAddress;
        private System.Windows.Forms.ListView PersonListView;
        private System.Windows.Forms.TextBox EditAddressPostalCodeTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EditAddressStateTextbox;
        private System.Windows.Forms.TextBox EditAddressCityTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEditAddress;
        private System.Windows.Forms.TextBox EditAddressStreetTextbox;
        private System.Windows.Forms.TextBox EditAddressIdTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAddressID;
        private System.Windows.Forms.Button btnEditPerson;
        private System.Windows.Forms.TextBox LastNameEditTextbox;
        private System.Windows.Forms.TextBox FirstNameEditTextbox;
        private System.Windows.Forms.Label lblEditLastName;
        private System.Windows.Forms.Label lblFirstNameEdit;
        private System.Windows.Forms.Label lblEditTitle;
        private System.Windows.Forms.TextBox EditPersonIDTextbox;
        private System.Windows.Forms.Label lblPersonIDEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox XMLReadTextBox;
        private System.Windows.Forms.Button btnReadXML;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tBLPERSONBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTNAMEDataGridViewTextBoxColumn;
    }
}

