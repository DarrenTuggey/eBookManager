namespace eBookManager
{
    partial class ImportBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportBooks));
            this.gbFileDetails = new System.Windows.Forms.GroupBox();
            this.dtCreated = new System.Windows.Forms.DateTimePicker();
            this.dtLastAccessed = new System.Windows.Forms.DateTimePicker();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblCreated = new System.Windows.Forms.Label();
            this.lblLastAccessed = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.gbBookDetails = new System.Windows.Forms.GroupBox();
            this.dlClassification = new System.Windows.Forms.ComboBox();
            this.btnAddBookToStorageSpace = new System.Windows.Forms.Button();
            this.dtDatePublished = new System.Windows.Forms.DateTimePicker();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblClassification = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnSelectSourceFolder = new System.Windows.Forms.Button();
            this.tvFoundBooks = new System.Windows.Forms.TreeView();
            this.gbVirtualStorageSpaces = new System.Windows.Forms.GroupBox();
            this.txtStorageSpaceDescription = new System.Windows.Forms.TextBox();
            this.lblStorageSpaceDescription = new System.Windows.Forms.Label();
            this.lblEbookCount = new System.Windows.Forms.Label();
            this.btnCancelNewStorageSpaceSave = new System.Windows.Forms.Button();
            this.btnSaveNewStorageSpace = new System.Windows.Forms.Button();
            this.txtNewStorageSpaceName = new System.Windows.Forms.TextBox();
            this.btnAddNewStorageSpace = new System.Windows.Forms.Button();
            this.dlVirtualStorageSpaces = new System.Windows.Forms.ComboBox();
            this.gbFileDetails.SuspendLayout();
            this.gbBookDetails.SuspendLayout();
            this.gbVirtualStorageSpaces.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFileDetails
            // 
            this.gbFileDetails.Controls.Add(this.dtCreated);
            this.gbFileDetails.Controls.Add(this.dtLastAccessed);
            this.gbFileDetails.Controls.Add(this.txtFileSize);
            this.gbFileDetails.Controls.Add(this.txtFilePath);
            this.gbFileDetails.Controls.Add(this.txtExtension);
            this.gbFileDetails.Controls.Add(this.txtFileName);
            this.gbFileDetails.Controls.Add(this.lblFileSize);
            this.gbFileDetails.Controls.Add(this.lblFilePath);
            this.gbFileDetails.Controls.Add(this.lblCreated);
            this.gbFileDetails.Controls.Add(this.lblLastAccessed);
            this.gbFileDetails.Controls.Add(this.lblExtension);
            this.gbFileDetails.Controls.Add(this.lblFileName);
            this.gbFileDetails.Location = new System.Drawing.Point(542, 42);
            this.gbFileDetails.Name = "gbFileDetails";
            this.gbFileDetails.Size = new System.Drawing.Size(323, 207);
            this.gbFileDetails.TabIndex = 0;
            this.gbFileDetails.TabStop = false;
            this.gbFileDetails.Text = "File Details";
            // 
            // dtCreated
            // 
            this.dtCreated.CustomFormat = "MMM dd, yyyy";
            this.dtCreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCreated.Location = new System.Drawing.Point(102, 111);
            this.dtCreated.Name = "dtCreated";
            this.dtCreated.Size = new System.Drawing.Size(215, 23);
            this.dtCreated.TabIndex = 3;
            // 
            // dtLastAccessed
            // 
            this.dtLastAccessed.CustomFormat = "MMM dd, yyyy";
            this.dtLastAccessed.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLastAccessed.Location = new System.Drawing.Point(102, 81);
            this.dtLastAccessed.Name = "dtLastAccessed";
            this.dtLastAccessed.Size = new System.Drawing.Size(215, 23);
            this.dtLastAccessed.TabIndex = 2;
            // 
            // txtFileSize
            // 
            this.txtFileSize.Location = new System.Drawing.Point(102, 169);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.Size = new System.Drawing.Size(215, 23);
            this.txtFileSize.TabIndex = 1;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(102, 140);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(215, 23);
            this.txtFilePath.TabIndex = 1;
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(102, 51);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(215, 23);
            this.txtExtension.TabIndex = 1;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(102, 22);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(215, 23);
            this.txtFileName.TabIndex = 1;
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(6, 172);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(30, 15);
            this.lblFileSize.TabIndex = 0;
            this.lblFileSize.Text = "Size:";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(6, 143);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(55, 15);
            this.lblFilePath.TabIndex = 0;
            this.lblFilePath.Text = "File Path:";
            // 
            // lblCreated
            // 
            this.lblCreated.AutoSize = true;
            this.lblCreated.Location = new System.Drawing.Point(6, 117);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(51, 15);
            this.lblCreated.TabIndex = 0;
            this.lblCreated.Text = "Created:";
            // 
            // lblLastAccessed
            // 
            this.lblLastAccessed.AutoSize = true;
            this.lblLastAccessed.Location = new System.Drawing.Point(6, 87);
            this.lblLastAccessed.Name = "lblLastAccessed";
            this.lblLastAccessed.Size = new System.Drawing.Size(83, 15);
            this.lblLastAccessed.TabIndex = 0;
            this.lblLastAccessed.Text = "Last Accessed:";
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(6, 54);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(82, 15);
            this.lblExtension.TabIndex = 0;
            this.lblExtension.Text = "File Extension:";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(6, 25);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(63, 15);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "File Name:";
            // 
            // gbBookDetails
            // 
            this.gbBookDetails.Controls.Add(this.dlClassification);
            this.gbBookDetails.Controls.Add(this.btnAddBookToStorageSpace);
            this.gbBookDetails.Controls.Add(this.dtDatePublished);
            this.gbBookDetails.Controls.Add(this.txtISBN);
            this.gbBookDetails.Controls.Add(this.txtCategory);
            this.gbBookDetails.Controls.Add(this.txtPrice);
            this.gbBookDetails.Controls.Add(this.txtPublisher);
            this.gbBookDetails.Controls.Add(this.txtAuthor);
            this.gbBookDetails.Controls.Add(this.lblTitle);
            this.gbBookDetails.Controls.Add(this.txtTitle);
            this.gbBookDetails.Controls.Add(this.lblClassification);
            this.gbBookDetails.Controls.Add(this.lblCategory);
            this.gbBookDetails.Controls.Add(this.lblAuthor);
            this.gbBookDetails.Controls.Add(this.lblDatePublished);
            this.gbBookDetails.Controls.Add(this.lblPublisher);
            this.gbBookDetails.Controls.Add(this.lblISBN);
            this.gbBookDetails.Controls.Add(this.lblPrice);
            this.gbBookDetails.Location = new System.Drawing.Point(543, 255);
            this.gbBookDetails.Name = "gbBookDetails";
            this.gbBookDetails.Size = new System.Drawing.Size(322, 289);
            this.gbBookDetails.TabIndex = 1;
            this.gbBookDetails.TabStop = false;
            this.gbBookDetails.Text = "Book Details";
            // 
            // dlClassification
            // 
            this.dlClassification.FormattingEnabled = true;
            this.dlClassification.Location = new System.Drawing.Point(101, 226);
            this.dlClassification.Name = "dlClassification";
            this.dlClassification.Size = new System.Drawing.Size(215, 23);
            this.dlClassification.TabIndex = 4;
            // 
            // btnAddBookToStorageSpace
            // 
            this.btnAddBookToStorageSpace.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBookToStorageSpace.Image")));
            this.btnAddBookToStorageSpace.Location = new System.Drawing.Point(123, 256);
            this.btnAddBookToStorageSpace.Name = "btnAddBookToStorageSpace";
            this.btnAddBookToStorageSpace.Size = new System.Drawing.Size(26, 23);
            this.btnAddBookToStorageSpace.TabIndex = 3;
            this.btnAddBookToStorageSpace.UseVisualStyleBackColor = true;
            this.btnAddBookToStorageSpace.Click += new System.EventHandler(this.btnAddBookToStorageSpace_Click);
            // 
            // dtDatePublished
            // 
            this.dtDatePublished.CustomFormat = "MMM dd, yyyy";
            this.dtDatePublished.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDatePublished.Location = new System.Drawing.Point(101, 168);
            this.dtDatePublished.Name = "dtDatePublished";
            this.dtDatePublished.Size = new System.Drawing.Size(215, 23);
            this.dtDatePublished.TabIndex = 2;
            this.dtDatePublished.Value = new System.DateTime(2020, 5, 10, 16, 30, 9, 0);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(101, 138);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(215, 23);
            this.txtISBN.TabIndex = 1;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(101, 197);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(215, 23);
            this.txtCategory.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(101, 109);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(215, 23);
            this.txtPrice.TabIndex = 1;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(101, 80);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(215, 23);
            this.txtPublisher.TabIndex = 1;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(101, 51);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(215, 23);
            this.txtAuthor.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(32, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(101, 22);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(215, 23);
            this.txtTitle.TabIndex = 1;
            // 
            // lblClassification
            // 
            this.lblClassification.AutoSize = true;
            this.lblClassification.Location = new System.Drawing.Point(6, 229);
            this.lblClassification.Name = "lblClassification";
            this.lblClassification.Size = new System.Drawing.Size(80, 15);
            this.lblClassification.TabIndex = 0;
            this.lblClassification.Text = "Classification:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 200);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 15);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(6, 54);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(47, 15);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Author:";
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.Location = new System.Drawing.Point(6, 174);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(89, 15);
            this.lblDatePublished.TabIndex = 0;
            this.lblDatePublished.Text = "Date Published:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(6, 83);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(59, 15);
            this.lblPublisher.TabIndex = 0;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(6, 141);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 15);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 112);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 15);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price:";
            // 
            // btnSelectSourceFolder
            // 
            this.btnSelectSourceFolder.Location = new System.Drawing.Point(12, 12);
            this.btnSelectSourceFolder.Name = "btnSelectSourceFolder";
            this.btnSelectSourceFolder.Size = new System.Drawing.Size(129, 23);
            this.btnSelectSourceFolder.TabIndex = 2;
            this.btnSelectSourceFolder.Text = "Select Source Folder";
            this.btnSelectSourceFolder.UseVisualStyleBackColor = true;
            this.btnSelectSourceFolder.Click += new System.EventHandler(this.btnSelectSourceFolder_Click);
            // 
            // tvFoundBooks
            // 
            this.tvFoundBooks.Location = new System.Drawing.Point(12, 42);
            this.tvFoundBooks.Name = "tvFoundBooks";
            this.tvFoundBooks.Size = new System.Drawing.Size(524, 263);
            this.tvFoundBooks.TabIndex = 3;
            this.tvFoundBooks.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFoundBooks_AfterSelect);
            // 
            // gbVirtualStorageSpaces
            // 
            this.gbVirtualStorageSpaces.Controls.Add(this.txtStorageSpaceDescription);
            this.gbVirtualStorageSpaces.Controls.Add(this.lblStorageSpaceDescription);
            this.gbVirtualStorageSpaces.Controls.Add(this.lblEbookCount);
            this.gbVirtualStorageSpaces.Controls.Add(this.btnCancelNewStorageSpaceSave);
            this.gbVirtualStorageSpaces.Controls.Add(this.btnSaveNewStorageSpace);
            this.gbVirtualStorageSpaces.Controls.Add(this.txtNewStorageSpaceName);
            this.gbVirtualStorageSpaces.Controls.Add(this.btnAddNewStorageSpace);
            this.gbVirtualStorageSpaces.Controls.Add(this.dlVirtualStorageSpaces);
            this.gbVirtualStorageSpaces.Location = new System.Drawing.Point(12, 311);
            this.gbVirtualStorageSpaces.Name = "gbVirtualStorageSpaces";
            this.gbVirtualStorageSpaces.Size = new System.Drawing.Size(523, 233);
            this.gbVirtualStorageSpaces.TabIndex = 4;
            this.gbVirtualStorageSpaces.TabStop = false;
            this.gbVirtualStorageSpaces.Text = "Virtual Storage Spaces";
            // 
            // txtStorageSpaceDescription
            // 
            this.txtStorageSpaceDescription.Location = new System.Drawing.Point(239, 79);
            this.txtStorageSpaceDescription.Multiline = true;
            this.txtStorageSpaceDescription.Name = "txtStorageSpaceDescription";
            this.txtStorageSpaceDescription.Size = new System.Drawing.Size(278, 144);
            this.txtStorageSpaceDescription.TabIndex = 7;
            // 
            // lblStorageSpaceDescription
            // 
            this.lblStorageSpaceDescription.AutoSize = true;
            this.lblStorageSpaceDescription.Location = new System.Drawing.Point(239, 61);
            this.lblStorageSpaceDescription.Name = "lblStorageSpaceDescription";
            this.lblStorageSpaceDescription.Size = new System.Drawing.Size(147, 15);
            this.lblStorageSpaceDescription.TabIndex = 6;
            this.lblStorageSpaceDescription.Text = "Storage Space Description:";
            // 
            // lblEbookCount
            // 
            this.lblEbookCount.AutoSize = true;
            this.lblEbookCount.Location = new System.Drawing.Point(7, 61);
            this.lblEbookCount.Name = "lblEbookCount";
            this.lblEbookCount.Size = new System.Drawing.Size(92, 15);
            this.lblEbookCount.TabIndex = 5;
            this.lblEbookCount.Text = "Idle Book Count";
            // 
            // btnCancelNewStorageSpaceSave
            // 
            this.btnCancelNewStorageSpaceSave.Location = new System.Drawing.Point(453, 23);
            this.btnCancelNewStorageSpaceSave.Name = "btnCancelNewStorageSpaceSave";
            this.btnCancelNewStorageSpaceSave.Size = new System.Drawing.Size(64, 23);
            this.btnCancelNewStorageSpaceSave.TabIndex = 4;
            this.btnCancelNewStorageSpaceSave.Text = "Cancel";
            this.btnCancelNewStorageSpaceSave.UseVisualStyleBackColor = true;
            this.btnCancelNewStorageSpaceSave.Click += new System.EventHandler(this.btnCancelNewStorageSpaceSave_Click);
            // 
            // btnSaveNewStorageSpace
            // 
            this.btnSaveNewStorageSpace.Location = new System.Drawing.Point(383, 23);
            this.btnSaveNewStorageSpace.Name = "btnSaveNewStorageSpace";
            this.btnSaveNewStorageSpace.Size = new System.Drawing.Size(64, 23);
            this.btnSaveNewStorageSpace.TabIndex = 3;
            this.btnSaveNewStorageSpace.Text = "Save";
            this.btnSaveNewStorageSpace.UseVisualStyleBackColor = true;
            this.btnSaveNewStorageSpace.Click += new System.EventHandler(this.btnSaveNewStorageSpace_Click);
            // 
            // txtNewStorageSpaceName
            // 
            this.txtNewStorageSpaceName.Location = new System.Drawing.Point(239, 23);
            this.txtNewStorageSpaceName.Name = "txtNewStorageSpaceName";
            this.txtNewStorageSpaceName.Size = new System.Drawing.Size(138, 23);
            this.txtNewStorageSpaceName.TabIndex = 2;
            // 
            // btnAddNewStorageSpace
            // 
            this.btnAddNewStorageSpace.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewStorageSpace.Image")));
            this.btnAddNewStorageSpace.Location = new System.Drawing.Point(207, 23);
            this.btnAddNewStorageSpace.Name = "btnAddNewStorageSpace";
            this.btnAddNewStorageSpace.Size = new System.Drawing.Size(25, 23);
            this.btnAddNewStorageSpace.TabIndex = 1;
            this.btnAddNewStorageSpace.UseVisualStyleBackColor = true;
            this.btnAddNewStorageSpace.Click += new System.EventHandler(this.btnAddNewStorageSpace_Click);
            // 
            // dlVirtualStorageSpaces
            // 
            this.dlVirtualStorageSpaces.FormattingEnabled = true;
            this.dlVirtualStorageSpaces.Location = new System.Drawing.Point(7, 23);
            this.dlVirtualStorageSpaces.Name = "dlVirtualStorageSpaces";
            this.dlVirtualStorageSpaces.Size = new System.Drawing.Size(193, 23);
            this.dlVirtualStorageSpaces.TabIndex = 0;
            this.dlVirtualStorageSpaces.SelectedIndexChanged += new System.EventHandler(this.dlVirtualStorageSpaces_SelectedIndexChanged);
            // 
            // ImportBooks
            // 
            this.ClientSize = new System.Drawing.Size(880, 555);
            this.Controls.Add(this.gbVirtualStorageSpaces);
            this.Controls.Add(this.tvFoundBooks);
            this.Controls.Add(this.btnSelectSourceFolder);
            this.Controls.Add(this.gbBookDetails);
            this.Controls.Add(this.gbFileDetails);
            this.Name = "ImportBooks";
            this.Text = "Import eBooks";
            this.Load += new System.EventHandler(this.ImportBooks_Load);
            this.gbFileDetails.ResumeLayout(false);
            this.gbFileDetails.PerformLayout();
            this.gbBookDetails.ResumeLayout(false);
            this.gbBookDetails.PerformLayout();
            this.gbVirtualStorageSpaces.ResumeLayout(false);
            this.gbVirtualStorageSpaces.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFileDetails;
        private System.Windows.Forms.DateTimePicker dtCreated;
        private System.Windows.Forms.DateTimePicker dtLastAccessed;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.Label lblLastAccessed;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.GroupBox gbBookDetails;
        private System.Windows.Forms.DateTimePicker dtDatePublished;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblClassification;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblDatePublished;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAddBookToStorageSpace;
        private System.Windows.Forms.Button btnSelectSourceFolder;
        private System.Windows.Forms.TreeView tvFoundBooks;
        private System.Windows.Forms.GroupBox gbVirtualStorageSpaces;
        private System.Windows.Forms.TextBox txtStorageSpaceDescription;
        private System.Windows.Forms.Label lblStorageSpaceDescription;
        private System.Windows.Forms.Label lblEbookCount;
        private System.Windows.Forms.Button btnCancelNewStorageSpaceSave;
        private System.Windows.Forms.Button btnSaveNewStorageSpace;
        private System.Windows.Forms.TextBox txtNewStorageSpaceName;
        private System.Windows.Forms.Button btnAddNewStorageSpace;
        private System.Windows.Forms.ComboBox dlVirtualStorageSpaces;
        private System.Windows.Forms.ComboBox dlClassification;
    }
}