namespace eBookManager
{
    partial class eBookManager
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eBookManager));
            this.gbVirtualStorageSpaces = new System.Windows.Forms.GroupBox();
            this.lstStorageSpaces = new System.Windows.Forms.ListView();
            this.gbEbooksInVirtualStorageSpace = new System.Windows.Forms.GroupBox();
            this.lstBooks = new System.Windows.Forms.ListView();
            this.gbeBookInfo = new System.Windows.Forms.GroupBox();
            this.gbVirtualStorageSpaceInfo = new System.Windows.Forms.GroupBox();
            this.txtStorageSpaceDescription = new System.Windows.Forms.TextBox();
            this.gbBookDetails = new System.Windows.Forms.GroupBox();
            this.btnReadEbook = new System.Windows.Forms.Button();
            this.dlClassification = new System.Windows.Forms.ComboBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.dtDatePublished = new System.Windows.Forms.DateTimePicker();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblClassification = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbFileDetails = new System.Windows.Forms.GroupBox();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.dtCreated = new System.Windows.Forms.DateTimePicker();
            this.lblSize = new System.Windows.Forms.Label();
            this.dtLastAccessed = new System.Windows.Forms.DateTimePicker();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblCreated = new System.Windows.Forms.Label();
            this.lblFileExtension = new System.Windows.Forms.Label();
            this.lblLastAccessed = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbVirtualStorageSpaces.SuspendLayout();
            this.gbEbooksInVirtualStorageSpace.SuspendLayout();
            this.gbeBookInfo.SuspendLayout();
            this.gbVirtualStorageSpaceInfo.SuspendLayout();
            this.gbBookDetails.SuspendLayout();
            this.gbFileDetails.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVirtualStorageSpaces
            // 
            this.gbVirtualStorageSpaces.Controls.Add(this.lstStorageSpaces);
            this.gbVirtualStorageSpaces.Location = new System.Drawing.Point(12, 30);
            this.gbVirtualStorageSpaces.Name = "gbVirtualStorageSpaces";
            this.gbVirtualStorageSpaces.Size = new System.Drawing.Size(304, 672);
            this.gbVirtualStorageSpaces.TabIndex = 1;
            this.gbVirtualStorageSpaces.TabStop = false;
            this.gbVirtualStorageSpaces.Text = "Virtual Storage Spaces";
            // 
            // lstStorageSpaces
            // 
            this.lstStorageSpaces.HideSelection = false;
            this.lstStorageSpaces.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstStorageSpaces.Location = new System.Drawing.Point(6, 22);
            this.lstStorageSpaces.Name = "lstStorageSpaces";
            this.lstStorageSpaces.Size = new System.Drawing.Size(292, 644);
            this.lstStorageSpaces.TabIndex = 0;
            this.lstStorageSpaces.UseCompatibleStateImageBehavior = false;
            this.lstStorageSpaces.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstStorageSpaces_MouseClick_1);
            // 
            // gbEbooksInVirtualStorageSpace
            // 
            this.gbEbooksInVirtualStorageSpace.Controls.Add(this.lstBooks);
            this.gbEbooksInVirtualStorageSpace.Location = new System.Drawing.Point(322, 30);
            this.gbEbooksInVirtualStorageSpace.Name = "gbEbooksInVirtualStorageSpace";
            this.gbEbooksInVirtualStorageSpace.Size = new System.Drawing.Size(490, 672);
            this.gbEbooksInVirtualStorageSpace.TabIndex = 2;
            this.gbEbooksInVirtualStorageSpace.TabStop = false;
            this.gbEbooksInVirtualStorageSpace.Text = "eBooks in Virtual Storage Space";
            // 
            // lstBooks
            // 
            this.lstBooks.HideSelection = false;
            this.lstBooks.Location = new System.Drawing.Point(7, 23);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(477, 643);
            this.lstBooks.TabIndex = 0;
            this.lstBooks.UseCompatibleStateImageBehavior = false;
            this.lstBooks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstBooks_MouseClick);
            // 
            // gbeBookInfo
            // 
            this.gbeBookInfo.Controls.Add(this.gbVirtualStorageSpaceInfo);
            this.gbeBookInfo.Controls.Add(this.gbBookDetails);
            this.gbeBookInfo.Controls.Add(this.gbFileDetails);
            this.gbeBookInfo.Location = new System.Drawing.Point(819, 30);
            this.gbeBookInfo.Name = "gbeBookInfo";
            this.gbeBookInfo.Size = new System.Drawing.Size(410, 672);
            this.gbeBookInfo.TabIndex = 3;
            this.gbeBookInfo.TabStop = false;
            this.gbeBookInfo.Text = "eBook Info";
            // 
            // gbVirtualStorageSpaceInfo
            // 
            this.gbVirtualStorageSpaceInfo.Controls.Add(this.txtStorageSpaceDescription);
            this.gbVirtualStorageSpaceInfo.Location = new System.Drawing.Point(7, 544);
            this.gbVirtualStorageSpaceInfo.Name = "gbVirtualStorageSpaceInfo";
            this.gbVirtualStorageSpaceInfo.Size = new System.Drawing.Size(397, 122);
            this.gbVirtualStorageSpaceInfo.TabIndex = 2;
            this.gbVirtualStorageSpaceInfo.TabStop = false;
            this.gbVirtualStorageSpaceInfo.Text = "Virtual Storage Space Info";
            // 
            // txtStorageSpaceDescription
            // 
            this.txtStorageSpaceDescription.BackColor = System.Drawing.SystemColors.Menu;
            this.txtStorageSpaceDescription.Location = new System.Drawing.Point(7, 23);
            this.txtStorageSpaceDescription.Multiline = true;
            this.txtStorageSpaceDescription.Name = "txtStorageSpaceDescription";
            this.txtStorageSpaceDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStorageSpaceDescription.Size = new System.Drawing.Size(384, 93);
            this.txtStorageSpaceDescription.TabIndex = 0;
            // 
            // gbBookDetails
            // 
            this.gbBookDetails.Controls.Add(this.btnReadEbook);
            this.gbBookDetails.Controls.Add(this.dlClassification);
            this.gbBookDetails.Controls.Add(this.txtCategory);
            this.gbBookDetails.Controls.Add(this.dtDatePublished);
            this.gbBookDetails.Controls.Add(this.txtISBN);
            this.gbBookDetails.Controls.Add(this.txtPrice);
            this.gbBookDetails.Controls.Add(this.txtPublisher);
            this.gbBookDetails.Controls.Add(this.txtAuthor);
            this.gbBookDetails.Controls.Add(this.txtTitle);
            this.gbBookDetails.Controls.Add(this.lblClassification);
            this.gbBookDetails.Controls.Add(this.lblCategory);
            this.gbBookDetails.Controls.Add(this.lblDatePublished);
            this.gbBookDetails.Controls.Add(this.lblISBN);
            this.gbBookDetails.Controls.Add(this.lblPrice);
            this.gbBookDetails.Controls.Add(this.lblPublisher);
            this.gbBookDetails.Controls.Add(this.lblAuthor);
            this.gbBookDetails.Controls.Add(this.lblTitle);
            this.gbBookDetails.Location = new System.Drawing.Point(7, 233);
            this.gbBookDetails.Name = "gbBookDetails";
            this.gbBookDetails.Size = new System.Drawing.Size(397, 305);
            this.gbBookDetails.TabIndex = 1;
            this.gbBookDetails.TabStop = false;
            this.gbBookDetails.Text = "Book Details";
            // 
            // btnReadEbook
            // 
            this.btnReadEbook.Image = ((System.Drawing.Image)(resources.GetObject("btnReadEbook.Image")));
            this.btnReadEbook.Location = new System.Drawing.Point(110, 255);
            this.btnReadEbook.Name = "btnReadEbook";
            this.btnReadEbook.Size = new System.Drawing.Size(37, 39);
            this.btnReadEbook.TabIndex = 9;
            this.btnReadEbook.UseVisualStyleBackColor = true;
            this.btnReadEbook.Click += new System.EventHandler(this.btnReadEbook_Click);
            // 
            // dlClassification
            // 
            this.dlClassification.FormattingEnabled = true;
            this.dlClassification.Location = new System.Drawing.Point(110, 226);
            this.dlClassification.Name = "dlClassification";
            this.dlClassification.Size = new System.Drawing.Size(281, 23);
            this.dlClassification.TabIndex = 8;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(110, 196);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(281, 23);
            this.txtCategory.TabIndex = 6;
            // 
            // dtDatePublished
            // 
            this.dtDatePublished.CustomFormat = "MMM dd, yyyy";
            this.dtDatePublished.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDatePublished.Location = new System.Drawing.Point(110, 167);
            this.dtDatePublished.Name = "dtDatePublished";
            this.dtDatePublished.Size = new System.Drawing.Size(281, 23);
            this.dtDatePublished.TabIndex = 7;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(110, 138);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(281, 23);
            this.txtISBN.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(110, 109);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(281, 23);
            this.txtPrice.TabIndex = 6;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(110, 80);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(281, 23);
            this.txtPublisher.TabIndex = 6;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(110, 51);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(281, 23);
            this.txtAuthor.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(110, 22);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(281, 23);
            this.txtTitle.TabIndex = 6;
            // 
            // lblClassification
            // 
            this.lblClassification.AutoSize = true;
            this.lblClassification.Location = new System.Drawing.Point(18, 229);
            this.lblClassification.Name = "lblClassification";
            this.lblClassification.Size = new System.Drawing.Size(80, 15);
            this.lblClassification.TabIndex = 0;
            this.lblClassification.Text = "Classification:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(18, 199);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 15);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category:";
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.Location = new System.Drawing.Point(18, 173);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(89, 15);
            this.lblDatePublished.TabIndex = 0;
            this.lblDatePublished.Text = "Date Published:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(18, 141);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 15);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(18, 112);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 15);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(18, 83);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(59, 15);
            this.lblPublisher.TabIndex = 0;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(18, 54);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(47, 15);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Author:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(18, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(32, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // gbFileDetails
            // 
            this.gbFileDetails.Controls.Add(this.txtFileSize);
            this.gbFileDetails.Controls.Add(this.txtFilePath);
            this.gbFileDetails.Controls.Add(this.dtCreated);
            this.gbFileDetails.Controls.Add(this.lblSize);
            this.gbFileDetails.Controls.Add(this.dtLastAccessed);
            this.gbFileDetails.Controls.Add(this.txtExtension);
            this.gbFileDetails.Controls.Add(this.lblFilePath);
            this.gbFileDetails.Controls.Add(this.txtFileName);
            this.gbFileDetails.Controls.Add(this.lblFileName);
            this.gbFileDetails.Controls.Add(this.lblCreated);
            this.gbFileDetails.Controls.Add(this.lblFileExtension);
            this.gbFileDetails.Controls.Add(this.lblLastAccessed);
            this.gbFileDetails.Location = new System.Drawing.Point(7, 23);
            this.gbFileDetails.Name = "gbFileDetails";
            this.gbFileDetails.Size = new System.Drawing.Size(397, 204);
            this.gbFileDetails.TabIndex = 0;
            this.gbFileDetails.TabStop = false;
            this.gbFileDetails.Text = "File Details";
            // 
            // txtFileSize
            // 
            this.txtFileSize.Location = new System.Drawing.Point(110, 167);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.Size = new System.Drawing.Size(281, 23);
            this.txtFileSize.TabIndex = 6;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(110, 138);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(281, 23);
            this.txtFilePath.TabIndex = 6;
            // 
            // dtCreated
            // 
            this.dtCreated.CustomFormat = "MMM dd, yyyy";
            this.dtCreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCreated.Location = new System.Drawing.Point(110, 109);
            this.dtCreated.Name = "dtCreated";
            this.dtCreated.Size = new System.Drawing.Size(281, 23);
            this.dtCreated.TabIndex = 7;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(18, 170);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 15);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Size:";
            // 
            // dtLastAccessed
            // 
            this.dtLastAccessed.CustomFormat = "MMM dd, yyyy";
            this.dtLastAccessed.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLastAccessed.Location = new System.Drawing.Point(110, 80);
            this.dtLastAccessed.Name = "dtLastAccessed";
            this.dtLastAccessed.Size = new System.Drawing.Size(281, 23);
            this.dtLastAccessed.TabIndex = 7;
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(110, 51);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(281, 23);
            this.txtExtension.TabIndex = 6;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(18, 141);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(55, 15);
            this.lblFilePath.TabIndex = 4;
            this.lblFilePath.Text = "File Path:";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(110, 22);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(281, 23);
            this.txtFileName.TabIndex = 6;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(18, 25);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(63, 15);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "File Name:";
            // 
            // lblCreated
            // 
            this.lblCreated.AutoSize = true;
            this.lblCreated.Location = new System.Drawing.Point(18, 115);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(51, 15);
            this.lblCreated.TabIndex = 3;
            this.lblCreated.Text = "Created:";
            // 
            // lblFileExtension
            // 
            this.lblFileExtension.AutoSize = true;
            this.lblFileExtension.Location = new System.Drawing.Point(18, 54);
            this.lblFileExtension.Name = "lblFileExtension";
            this.lblFileExtension.Size = new System.Drawing.Size(82, 15);
            this.lblFileExtension.TabIndex = 1;
            this.lblFileExtension.Text = "File Extension:";
            // 
            // lblLastAccessed
            // 
            this.lblLastAccessed.AutoSize = true;
            this.lblLastAccessed.Location = new System.Drawing.Point(18, 86);
            this.lblLastAccessed.Name = "lblLastAccessed";
            this.lblLastAccessed.Size = new System.Drawing.Size(83, 15);
            this.lblLastAccessed.TabIndex = 2;
            this.lblLastAccessed.Text = "Last Accessed:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1241, 24);
            this.menuStrip1.TabIndex = 4;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(96, 20);
            this.toolStripMenuItem2.Text = "Import eBooks";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // eBookManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 714);
            this.Controls.Add(this.gbeBookInfo);
            this.Controls.Add(this.gbEbooksInVirtualStorageSpace);
            this.Controls.Add(this.gbVirtualStorageSpaces);
            this.Controls.Add(this.menuStrip1);
            this.Name = "eBookManager";
            this.Text = "eBook Manager";
            this.Load += new System.EventHandler(this.eBookManager_Load);
            this.gbVirtualStorageSpaces.ResumeLayout(false);
            this.gbEbooksInVirtualStorageSpace.ResumeLayout(false);
            this.gbeBookInfo.ResumeLayout(false);
            this.gbVirtualStorageSpaceInfo.ResumeLayout(false);
            this.gbVirtualStorageSpaceInfo.PerformLayout();
            this.gbBookDetails.ResumeLayout(false);
            this.gbBookDetails.PerformLayout();
            this.gbFileDetails.ResumeLayout(false);
            this.gbFileDetails.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbVirtualStorageSpaces;
        private System.Windows.Forms.ListView lstStorageSpaces;
        private System.Windows.Forms.GroupBox gbEbooksInVirtualStorageSpace;
        private System.Windows.Forms.ListView lstBooks;
        private System.Windows.Forms.GroupBox gbeBookInfo;
        private System.Windows.Forms.GroupBox gbVirtualStorageSpaceInfo;
        private System.Windows.Forms.GroupBox gbBookDetails;
        private System.Windows.Forms.Label lblClassification;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDatePublished;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbFileDetails;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.Label lblLastAccessed;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnReadEbook;
        private System.Windows.Forms.ComboBox dlClassification;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.DateTimePicker dtDatePublished;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.DateTimePicker dtCreated;
        private System.Windows.Forms.DateTimePicker dtLastAccessed;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileExtension;
        private System.Windows.Forms.TextBox txtStorageSpaceDescription;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}