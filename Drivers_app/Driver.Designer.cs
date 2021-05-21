namespace Drivers_app{
    partial class Driver
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
            System.Windows.Forms.Label gUIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label passportLabel;
            System.Windows.Forms.Label postcodeLabel;
            System.Windows.Forms.Label registrationAddressLabel;
            System.Windows.Forms.Label residentialAddressLabel;
            System.Windows.Forms.Label placeOfWorkLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label mobilePhoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label commentsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Driver));
            this.driverBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDriverDataSet = new Drivers_app.DatabaseDriverDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.driverBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gUIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.postcodeTextBox = new System.Windows.Forms.TextBox();
            this.registrationAddressTextBox = new System.Windows.Forms.TextBox();
            this.residentialAddressTextBox = new System.Windows.Forms.TextBox();
            this.placeOfWorkTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.mobilePhoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.driverTableAdapter = new Drivers_app.DatabaseDriverDataSetTableAdapters.DriverTableAdapter();
            this.tableAdapterManager = new Drivers_app.DatabaseDriverDataSetTableAdapters.TableAdapterManager();
            this.licbtn = new System.Windows.Forms.Button();
            gUIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            passportLabel = new System.Windows.Forms.Label();
            postcodeLabel = new System.Windows.Forms.Label();
            registrationAddressLabel = new System.Windows.Forms.Label();
            residentialAddressLabel = new System.Windows.Forms.Label();
            placeOfWorkLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            mobilePhoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            commentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingNavigator)).BeginInit();
            this.driverBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDriverDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gUIDLabel
            // 
            gUIDLabel.AutoSize = true;
            gUIDLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            gUIDLabel.Location = new System.Drawing.Point(30, 56);
            gUIDLabel.Name = "gUIDLabel";
            gUIDLabel.Size = new System.Drawing.Size(45, 16);
            gUIDLabel.TabIndex = 1;
            gUIDLabel.Text = "GUID:";
            gUIDLabel.Click += new System.EventHandler(this.gUIDLabel_Click);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(31, 87);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(48, 16);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            surnameLabel.Location = new System.Drawing.Point(30, 117);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(69, 16);
            surnameLabel.TabIndex = 5;
            surnameLabel.Text = "Surname:";
            surnameLabel.Click += new System.EventHandler(this.surnameLabel_Click);
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            middleNameLabel.Location = new System.Drawing.Point(30, 147);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(93, 16);
            middleNameLabel.TabIndex = 7;
            middleNameLabel.Text = "Middle Name:";
            // 
            // passportLabel
            // 
            passportLabel.AutoSize = true;
            passportLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passportLabel.Location = new System.Drawing.Point(30, 177);
            passportLabel.Name = "passportLabel";
            passportLabel.Size = new System.Drawing.Size(68, 16);
            passportLabel.TabIndex = 9;
            passportLabel.Text = "Passport:";
            passportLabel.Click += new System.EventHandler(this.passportLabel_Click);
            // 
            // postcodeLabel
            // 
            postcodeLabel.AutoSize = true;
            postcodeLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            postcodeLabel.Location = new System.Drawing.Point(30, 207);
            postcodeLabel.Name = "postcodeLabel";
            postcodeLabel.Size = new System.Drawing.Size(70, 16);
            postcodeLabel.TabIndex = 11;
            postcodeLabel.Text = "postcode:";
            // 
            // registrationAddressLabel
            // 
            registrationAddressLabel.AutoSize = true;
            registrationAddressLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            registrationAddressLabel.Location = new System.Drawing.Point(30, 237);
            registrationAddressLabel.Name = "registrationAddressLabel";
            registrationAddressLabel.Size = new System.Drawing.Size(143, 16);
            registrationAddressLabel.TabIndex = 13;
            registrationAddressLabel.Text = "Registration Address:";
            registrationAddressLabel.Click += new System.EventHandler(this.registrationAddressLabel_Click);
            // 
            // residentialAddressLabel
            // 
            residentialAddressLabel.AutoSize = true;
            residentialAddressLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            residentialAddressLabel.Location = new System.Drawing.Point(30, 267);
            residentialAddressLabel.Name = "residentialAddressLabel";
            residentialAddressLabel.Size = new System.Drawing.Size(137, 16);
            residentialAddressLabel.TabIndex = 15;
            residentialAddressLabel.Text = "Residential Address:";
            // 
            // placeOfWorkLabel
            // 
            placeOfWorkLabel.AutoSize = true;
            placeOfWorkLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            placeOfWorkLabel.Location = new System.Drawing.Point(30, 297);
            placeOfWorkLabel.Name = "placeOfWorkLabel";
            placeOfWorkLabel.Size = new System.Drawing.Size(103, 16);
            placeOfWorkLabel.TabIndex = 17;
            placeOfWorkLabel.Text = "Place Of Work:";
            placeOfWorkLabel.Click += new System.EventHandler(this.placeOfWorkLabel_Click);
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            positionLabel.Location = new System.Drawing.Point(30, 324);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(62, 16);
            positionLabel.TabIndex = 19;
            positionLabel.Text = "Position:";
            // 
            // mobilePhoneLabel
            // 
            mobilePhoneLabel.AutoSize = true;
            mobilePhoneLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            mobilePhoneLabel.Location = new System.Drawing.Point(30, 357);
            mobilePhoneLabel.Name = "mobilePhoneLabel";
            mobilePhoneLabel.Size = new System.Drawing.Size(98, 16);
            mobilePhoneLabel.TabIndex = 21;
            mobilePhoneLabel.Text = "Mobile Phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emailLabel.Location = new System.Drawing.Point(30, 387);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 16);
            emailLabel.TabIndex = 23;
            emailLabel.Text = "Email:";
            emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            photoLabel.Location = new System.Drawing.Point(30, 417);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(49, 16);
            photoLabel.TabIndex = 25;
            photoLabel.Text = "Photo:";
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            commentsLabel.Location = new System.Drawing.Point(31, 447);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(79, 16);
            commentsLabel.TabIndex = 27;
            commentsLabel.Text = "Comments:";
            // 
            // driverBindingNavigator
            // 
            this.driverBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.driverBindingNavigator.BackColor = System.Drawing.SystemColors.MenuBar;
            this.driverBindingNavigator.BindingSource = this.driverBindingSource;
            this.driverBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.driverBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.driverBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.driverBindingNavigatorSaveItem,
            this.toolStripSeparator1});
            this.driverBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.driverBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.driverBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.driverBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.driverBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.driverBindingNavigator.Name = "driverBindingNavigator";
            this.driverBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.driverBindingNavigator.Size = new System.Drawing.Size(429, 25);
            this.driverBindingNavigator.TabIndex = 0;
            this.driverBindingNavigator.Text = "bindingNavigator1";
            this.driverBindingNavigator.RefreshItems += new System.EventHandler(this.driverBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "Driver";
            this.driverBindingSource.DataSource = this.databaseDriverDataSet;
            // 
            // databaseDriverDataSet
            // 
            this.databaseDriverDataSet.DataSetName = "DatabaseDriverDataSet";
            this.databaseDriverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(60, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // driverBindingNavigatorSaveItem
            // 
            this.driverBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driverBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("driverBindingNavigatorSaveItem.Image")));
            this.driverBindingNavigatorSaveItem.Name = "driverBindingNavigatorSaveItem";
            this.driverBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.driverBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.driverBindingNavigatorSaveItem.Click += new System.EventHandler(this.driverBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // gUIDTextBox
            // 
            this.gUIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "GUID", true));
            this.gUIDTextBox.Location = new System.Drawing.Point(199, 51);
            this.gUIDTextBox.Name = "gUIDTextBox";
            this.gUIDTextBox.Size = new System.Drawing.Size(214, 21);
            this.gUIDTextBox.TabIndex = 2;
            this.gUIDTextBox.TextChanged += new System.EventHandler(this.gUIDTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(198, 82);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(214, 21);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(198, 112);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(214, 21);
            this.surnameTextBox.TabIndex = 6;
            this.surnameTextBox.TextChanged += new System.EventHandler(this.surnameTextBox_TextChanged);
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "MiddleName", true));
            this.middleNameTextBox.Location = new System.Drawing.Point(198, 142);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(214, 21);
            this.middleNameTextBox.TabIndex = 8;
            this.middleNameTextBox.TextChanged += new System.EventHandler(this.middleNameTextBox_TextChanged);
            // 
            // passportTextBox
            // 
            this.passportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "Passport", true));
            this.passportTextBox.Location = new System.Drawing.Point(198, 172);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(214, 21);
            this.passportTextBox.TabIndex = 10;
            this.passportTextBox.TextChanged += new System.EventHandler(this.passportTextBox_TextChanged);
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "postcode", true));
            this.postcodeTextBox.Location = new System.Drawing.Point(198, 202);
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(214, 21);
            this.postcodeTextBox.TabIndex = 12;
            this.postcodeTextBox.TextChanged += new System.EventHandler(this.postcodeTextBox_TextChanged);
            // 
            // registrationAddressTextBox
            // 
            this.registrationAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "RegistrationAddress", true));
            this.registrationAddressTextBox.Location = new System.Drawing.Point(198, 232);
            this.registrationAddressTextBox.Name = "registrationAddressTextBox";
            this.registrationAddressTextBox.Size = new System.Drawing.Size(214, 21);
            this.registrationAddressTextBox.TabIndex = 14;
            this.registrationAddressTextBox.TextChanged += new System.EventHandler(this.registrationAddressTextBox_TextChanged);
            // 
            // residentialAddressTextBox
            // 
            this.residentialAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "ResidentialAddress", true));
            this.residentialAddressTextBox.Location = new System.Drawing.Point(198, 262);
            this.residentialAddressTextBox.Name = "residentialAddressTextBox";
            this.residentialAddressTextBox.Size = new System.Drawing.Size(214, 21);
            this.residentialAddressTextBox.TabIndex = 16;
            this.residentialAddressTextBox.TextChanged += new System.EventHandler(this.residentialAddressTextBox_TextChanged);
            // 
            // placeOfWorkTextBox
            // 
            this.placeOfWorkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "PlaceOfWork", true));
            this.placeOfWorkTextBox.Location = new System.Drawing.Point(198, 292);
            this.placeOfWorkTextBox.Name = "placeOfWorkTextBox";
            this.placeOfWorkTextBox.Size = new System.Drawing.Size(214, 21);
            this.placeOfWorkTextBox.TabIndex = 18;
            this.placeOfWorkTextBox.TextChanged += new System.EventHandler(this.placeOfWorkTextBox_TextChanged);
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "Position", true));
            this.positionTextBox.Location = new System.Drawing.Point(198, 319);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(214, 21);
            this.positionTextBox.TabIndex = 20;
            this.positionTextBox.TextChanged += new System.EventHandler(this.positionTextBox_TextChanged);
            // 
            // mobilePhoneTextBox
            // 
            this.mobilePhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "MobilePhone", true));
            this.mobilePhoneTextBox.Location = new System.Drawing.Point(198, 352);
            this.mobilePhoneTextBox.Name = "mobilePhoneTextBox";
            this.mobilePhoneTextBox.Size = new System.Drawing.Size(214, 21);
            this.mobilePhoneTextBox.TabIndex = 22;
            this.mobilePhoneTextBox.TextChanged += new System.EventHandler(this.mobilePhoneTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(198, 382);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(214, 21);
            this.emailTextBox.TabIndex = 24;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // photoTextBox
            // 
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "Photo", true));
            this.photoTextBox.Location = new System.Drawing.Point(198, 412);
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.Size = new System.Drawing.Size(214, 21);
            this.photoTextBox.TabIndex = 26;
            this.photoTextBox.TextChanged += new System.EventHandler(this.photoTextBox_TextChanged);
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "Comments", true));
            this.commentsTextBox.Location = new System.Drawing.Point(198, 442);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(214, 21);
            this.commentsTextBox.TabIndex = 28;
            this.commentsTextBox.TextChanged += new System.EventHandler(this.commentsTextBox_TextChanged);
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DriverTableAdapter = this.driverTableAdapter;
            this.tableAdapterManager.licensesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Drivers_app.DatabaseDriverDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // licbtn
            // 
            this.licbtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.licbtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.licbtn.Location = new System.Drawing.Point(198, 469);
            this.licbtn.Name = "licbtn";
            this.licbtn.Size = new System.Drawing.Size(215, 35);
            this.licbtn.TabIndex = 29;
            this.licbtn.Text = "Licences\r\n";
            this.licbtn.UseVisualStyleBackColor = true;
            this.licbtn.Click += new System.EventHandler(this.licbtn_Click);
            // 
            // Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(429, 536);
            this.Controls.Add(this.licbtn);
            this.Controls.Add(gUIDLabel);
            this.Controls.Add(this.gUIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(middleNameLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(passportLabel);
            this.Controls.Add(this.passportTextBox);
            this.Controls.Add(postcodeLabel);
            this.Controls.Add(this.postcodeTextBox);
            this.Controls.Add(registrationAddressLabel);
            this.Controls.Add(this.registrationAddressTextBox);
            this.Controls.Add(residentialAddressLabel);
            this.Controls.Add(this.residentialAddressTextBox);
            this.Controls.Add(placeOfWorkLabel);
            this.Controls.Add(this.placeOfWorkTextBox);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(mobilePhoneLabel);
            this.Controls.Add(this.mobilePhoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoTextBox);
            this.Controls.Add(commentsLabel);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.driverBindingNavigator);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Driver";
            this.Text = "Driver";
            this.Load += new System.EventHandler(this.Driver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingNavigator)).EndInit();
            this.driverBindingNavigator.ResumeLayout(false);
            this.driverBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDriverDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDriverDataSet databaseDriverDataSet;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private DatabaseDriverDataSetTableAdapters.DriverTableAdapter driverTableAdapter;
        private DatabaseDriverDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator driverBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton driverBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox gUIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.TextBox postcodeTextBox;
        private System.Windows.Forms.TextBox registrationAddressTextBox;
        private System.Windows.Forms.TextBox residentialAddressTextBox;
        private System.Windows.Forms.TextBox placeOfWorkTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox mobilePhoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Button licbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}