namespace FileManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPlates = new System.Windows.Forms.TabPage();
            this.btnOpenDXFsNotFound = new System.Windows.Forms.Button();
            this.btnOpenDRs = new System.Windows.Forms.Button();
            this.btnOpenStiffeners = new System.Windows.Forms.Button();
            this.lblDXFsNotFound = new System.Windows.Forms.Label();
            this.lblDRsFound = new System.Windows.Forms.Label();
            this.dgvDXFsNotFound = new System.Windows.Forms.DataGridView();
            this.dgvDRsFound = new System.Windows.Forms.DataGridView();
            this.lblStiffenersFound = new System.Windows.Forms.Label();
            this.dgvStiffenersFound = new System.Windows.Forms.DataGridView();
            this.lblComplete = new System.Windows.Forms.Label();
            this.btnSortPlates = new System.Windows.Forms.Button();
            this.lblPlateSearchFolder = new System.Windows.Forms.Label();
            this.chkAutoPlateSearch = new System.Windows.Forms.CheckBox();
            this.btnSelectMasterDXFsFolder = new System.Windows.Forms.Button();
            this.tabAngles = new System.Windows.Forms.TabPage();
            this.btnOpenAngleLayoutPDFs = new System.Windows.Forms.Button();
            this.labelLayoutMarksNeeded = new System.Windows.Forms.Label();
            this.dgvLayoutMarksNeeded = new System.Windows.Forms.DataGridView();
            this.lblSlotAdjustments = new System.Windows.Forms.Label();
            this.dgvSlotAdjustments = new System.Windows.Forms.DataGridView();
            this.lblAnglesDSTVsNotFoundInJob = new System.Windows.Forms.Label();
            this.dgvNotFoundAngles = new System.Windows.Forms.DataGridView();
            this.lblAnglesHeaderLengthChanges = new System.Windows.Forms.Label();
            this.dgvAnglesLengthChanges = new System.Windows.Forms.DataGridView();
            this.lblCNCAnglesFolderCreated = new System.Windows.Forms.Label();
            this.btnGenerateCNCAnglesBatch = new System.Windows.Forms.Button();
            this.tabBeams = new System.Windows.Forms.TabPage();
            this.btnFullPenPrep = new System.Windows.Forms.Button();
            this.btnOpenWTDrawings = new System.Windows.Forms.Button();
            this.lblWTsFound = new System.Windows.Forms.Label();
            this.dgvWTsFound = new System.Windows.Forms.DataGridView();
            this.lblBeamsHeaderLengthChanges = new System.Windows.Forms.Label();
            this.dgvBeamsLengthChanges = new System.Windows.Forms.DataGridView();
            this.lblDSTVsNotExportedToPython = new System.Windows.Forms.Label();
            this.lblBeamsDSTVsNotFoundInJob = new System.Windows.Forms.Label();
            this.dgvNotVerifiedBeams = new System.Windows.Forms.DataGridView();
            this.dgvNotFoundBeams = new System.Windows.Forms.DataGridView();
            this.lblVerifiedPythonJobs = new System.Windows.Forms.Label();
            this.btnVerifyPythonBatch = new System.Windows.Forms.Button();
            this.lblCNCBeamsFolderCreated = new System.Windows.Forms.Label();
            this.btnGenerateCNCBeamsBatch = new System.Windows.Forms.Button();
            this.tabShopPrints = new System.Windows.Forms.TabPage();
            this.btnPrint = new System.Windows.Forms.Button();
            this.chckAutoPDFOutputDirectory = new System.Windows.Forms.CheckBox();
            this.chckAutoPDFsDirectory = new System.Windows.Forms.CheckBox();
            this.lblDone = new System.Windows.Forms.Label();
            this.lblPDFOutputDirectory = new System.Windows.Forms.Label();
            this.lblPDFDirectory = new System.Windows.Forms.Label();
            this.seqLabel = new System.Windows.Forms.Label();
            this.txtSequence = new System.Windows.Forms.TextBox();
            this.btnSelectPDFOutputDirectory = new System.Windows.Forms.Button();
            this.btnSelectPDFsDirectory = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.txtSequenceColor = new System.Windows.Forms.TextBox();
            this.txtBatchDescription = new System.Windows.Forms.TextBox();
            this.btnGenerateShopPrints = new System.Windows.Forms.Button();
            this.btnChangeBatch = new System.Windows.Forms.Button();
            this.dgvMainList = new System.Windows.Forms.DataGridView();
            this.lblBatchHeading = new System.Windows.Forms.Label();
            this.openReports = new System.Windows.Forms.OpenFileDialog();
            this.openMaster = new System.Windows.Forms.FolderBrowserDialog();
            this.openPDFsDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.openPDFOutputDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.openMissingPDF = new System.Windows.Forms.OpenFileDialog();
            this.lblMachine = new System.Windows.Forms.Label();
            this.btnChangeMachine = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnOpenShopPrints = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPlates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDXFsNotFound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDRsFound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStiffenersFound)).BeginInit();
            this.tabAngles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayoutMarksNeeded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlotAdjustments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotFoundAngles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnglesLengthChanges)).BeginInit();
            this.tabBeams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWTsFound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeamsLengthChanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotVerifiedBeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotFoundBeams)).BeginInit();
            this.tabShopPrints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPlates);
            this.tabControl1.Controls.Add(this.tabAngles);
            this.tabControl1.Controls.Add(this.tabBeams);
            this.tabControl1.Controls.Add(this.tabShopPrints);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(480, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 519);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Visible = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabChanged);
            // 
            // tabPlates
            // 
            this.tabPlates.Controls.Add(this.btnOpenDXFsNotFound);
            this.tabPlates.Controls.Add(this.btnOpenDRs);
            this.tabPlates.Controls.Add(this.btnOpenStiffeners);
            this.tabPlates.Controls.Add(this.lblDXFsNotFound);
            this.tabPlates.Controls.Add(this.lblDRsFound);
            this.tabPlates.Controls.Add(this.dgvDXFsNotFound);
            this.tabPlates.Controls.Add(this.dgvDRsFound);
            this.tabPlates.Controls.Add(this.lblStiffenersFound);
            this.tabPlates.Controls.Add(this.dgvStiffenersFound);
            this.tabPlates.Controls.Add(this.lblComplete);
            this.tabPlates.Controls.Add(this.btnSortPlates);
            this.tabPlates.Controls.Add(this.lblPlateSearchFolder);
            this.tabPlates.Controls.Add(this.chkAutoPlateSearch);
            this.tabPlates.Controls.Add(this.btnSelectMasterDXFsFolder);
            this.tabPlates.Location = new System.Drawing.Point(4, 22);
            this.tabPlates.Name = "tabPlates";
            this.tabPlates.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlates.Size = new System.Drawing.Size(645, 493);
            this.tabPlates.TabIndex = 0;
            this.tabPlates.Text = "Plates";
            this.tabPlates.UseVisualStyleBackColor = true;
            // 
            // btnOpenDXFsNotFound
            // 
            this.btnOpenDXFsNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenDXFsNotFound.Location = new System.Drawing.Point(404, 5);
            this.btnOpenDXFsNotFound.Name = "btnOpenDXFsNotFound";
            this.btnOpenDXFsNotFound.Size = new System.Drawing.Size(39, 21);
            this.btnOpenDXFsNotFound.TabIndex = 43;
            this.btnOpenDXFsNotFound.Text = "open";
            this.btnOpenDXFsNotFound.UseVisualStyleBackColor = true;
            this.btnOpenDXFsNotFound.Visible = false;
            this.btnOpenDXFsNotFound.Click += new System.EventHandler(this.OpenDXFsNotFound);
            // 
            // btnOpenDRs
            // 
            this.btnOpenDRs.Location = new System.Drawing.Point(380, 249);
            this.btnOpenDRs.Name = "btnOpenDRs";
            this.btnOpenDRs.Size = new System.Drawing.Size(40, 22);
            this.btnOpenDRs.TabIndex = 42;
            this.btnOpenDRs.Text = "open";
            this.btnOpenDRs.UseVisualStyleBackColor = true;
            this.btnOpenDRs.Visible = false;
            this.btnOpenDRs.Click += new System.EventHandler(this.OpenDRs);
            // 
            // btnOpenStiffeners
            // 
            this.btnOpenStiffeners.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenStiffeners.Location = new System.Drawing.Point(65, 249);
            this.btnOpenStiffeners.Name = "btnOpenStiffeners";
            this.btnOpenStiffeners.Size = new System.Drawing.Size(39, 21);
            this.btnOpenStiffeners.TabIndex = 41;
            this.btnOpenStiffeners.Text = "open";
            this.btnOpenStiffeners.UseVisualStyleBackColor = true;
            this.btnOpenStiffeners.Visible = false;
            this.btnOpenStiffeners.Click += new System.EventHandler(this.OpenStiffeners);
            // 
            // lblDXFsNotFound
            // 
            this.lblDXFsNotFound.AutoSize = true;
            this.lblDXFsNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDXFsNotFound.Location = new System.Drawing.Point(312, 13);
            this.lblDXFsNotFound.Name = "lblDXFsNotFound";
            this.lblDXFsNotFound.Size = new System.Drawing.Size(86, 13);
            this.lblDXFsNotFound.TabIndex = 40;
            this.lblDXFsNotFound.Text = "DXFs Not Found";
            this.lblDXFsNotFound.Visible = false;
            // 
            // lblDRsFound
            // 
            this.lblDRsFound.AutoSize = true;
            this.lblDRsFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDRsFound.Location = new System.Drawing.Point(312, 257);
            this.lblDRsFound.Name = "lblDRsFound";
            this.lblDRsFound.Size = new System.Drawing.Size(62, 13);
            this.lblDRsFound.TabIndex = 39;
            this.lblDRsFound.Text = "Drain Holes";
            this.lblDRsFound.Visible = false;
            // 
            // dgvDXFsNotFound
            // 
            this.dgvDXFsNotFound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDXFsNotFound.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDXFsNotFound.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDXFsNotFound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDXFsNotFound.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDXFsNotFound.Location = new System.Drawing.Point(315, 29);
            this.dgvDXFsNotFound.Name = "dgvDXFsNotFound";
            this.dgvDXFsNotFound.Size = new System.Drawing.Size(327, 214);
            this.dgvDXFsNotFound.TabIndex = 38;
            this.dgvDXFsNotFound.Visible = false;
            // 
            // dgvDRsFound
            // 
            this.dgvDRsFound.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDRsFound.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDRsFound.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDRsFound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDRsFound.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDRsFound.Location = new System.Drawing.Point(315, 273);
            this.dgvDRsFound.Name = "dgvDRsFound";
            this.dgvDRsFound.Size = new System.Drawing.Size(330, 214);
            this.dgvDRsFound.TabIndex = 37;
            this.dgvDRsFound.Visible = false;
            // 
            // lblStiffenersFound
            // 
            this.lblStiffenersFound.AutoSize = true;
            this.lblStiffenersFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStiffenersFound.Location = new System.Drawing.Point(8, 257);
            this.lblStiffenersFound.Name = "lblStiffenersFound";
            this.lblStiffenersFound.Size = new System.Drawing.Size(51, 13);
            this.lblStiffenersFound.TabIndex = 36;
            this.lblStiffenersFound.Text = "Stiffeners";
            this.lblStiffenersFound.Visible = false;
            // 
            // dgvStiffenersFound
            // 
            this.dgvStiffenersFound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvStiffenersFound.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStiffenersFound.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStiffenersFound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStiffenersFound.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStiffenersFound.Location = new System.Drawing.Point(3, 273);
            this.dgvStiffenersFound.Name = "dgvStiffenersFound";
            this.dgvStiffenersFound.Size = new System.Drawing.Size(306, 214);
            this.dgvStiffenersFound.TabIndex = 34;
            this.dgvStiffenersFound.Visible = false;
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.Location = new System.Drawing.Point(8, 114);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(0, 13);
            this.lblComplete.TabIndex = 32;
            this.lblComplete.Visible = false;
            // 
            // btnSortPlates
            // 
            this.btnSortPlates.Enabled = false;
            this.btnSortPlates.Location = new System.Drawing.Point(6, 81);
            this.btnSortPlates.Name = "btnSortPlates";
            this.btnSortPlates.Size = new System.Drawing.Size(75, 25);
            this.btnSortPlates.TabIndex = 31;
            this.btnSortPlates.Text = "Sort Plates";
            this.btnSortPlates.UseVisualStyleBackColor = true;
            this.btnSortPlates.Click += new System.EventHandler(this.SortPlates);
            // 
            // lblPlateSearchFolder
            // 
            this.lblPlateSearchFolder.AutoSize = true;
            this.lblPlateSearchFolder.Location = new System.Drawing.Point(8, 55);
            this.lblPlateSearchFolder.Name = "lblPlateSearchFolder";
            this.lblPlateSearchFolder.Size = new System.Drawing.Size(0, 13);
            this.lblPlateSearchFolder.TabIndex = 26;
            // 
            // chkAutoPlateSearch
            // 
            this.chkAutoPlateSearch.AutoSize = true;
            this.chkAutoPlateSearch.Checked = true;
            this.chkAutoPlateSearch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoPlateSearch.Enabled = false;
            this.chkAutoPlateSearch.Location = new System.Drawing.Point(6, 6);
            this.chkAutoPlateSearch.Name = "chkAutoPlateSearch";
            this.chkAutoPlateSearch.Size = new System.Drawing.Size(68, 17);
            this.chkAutoPlateSearch.TabIndex = 25;
            this.chkAutoPlateSearch.Text = "AutoFind";
            this.chkAutoPlateSearch.UseVisualStyleBackColor = true;
            this.chkAutoPlateSearch.CheckStateChanged += new System.EventHandler(this.chkAutoMasterDXFsFolderChanged);
            // 
            // btnSelectMasterDXFsFolder
            // 
            this.btnSelectMasterDXFsFolder.Enabled = false;
            this.btnSelectMasterDXFsFolder.Location = new System.Drawing.Point(6, 29);
            this.btnSelectMasterDXFsFolder.Name = "btnSelectMasterDXFsFolder";
            this.btnSelectMasterDXFsFolder.Size = new System.Drawing.Size(120, 23);
            this.btnSelectMasterDXFsFolder.TabIndex = 24;
            this.btnSelectMasterDXFsFolder.Text = "Select Search Folder";
            this.btnSelectMasterDXFsFolder.UseVisualStyleBackColor = true;
            this.btnSelectMasterDXFsFolder.Click += new System.EventHandler(this.SelectMasterDXFsPath);
            // 
            // tabAngles
            // 
            this.tabAngles.Controls.Add(this.btnOpenAngleLayoutPDFs);
            this.tabAngles.Controls.Add(this.labelLayoutMarksNeeded);
            this.tabAngles.Controls.Add(this.dgvLayoutMarksNeeded);
            this.tabAngles.Controls.Add(this.lblSlotAdjustments);
            this.tabAngles.Controls.Add(this.dgvSlotAdjustments);
            this.tabAngles.Controls.Add(this.lblAnglesDSTVsNotFoundInJob);
            this.tabAngles.Controls.Add(this.dgvNotFoundAngles);
            this.tabAngles.Controls.Add(this.lblAnglesHeaderLengthChanges);
            this.tabAngles.Controls.Add(this.dgvAnglesLengthChanges);
            this.tabAngles.Controls.Add(this.lblCNCAnglesFolderCreated);
            this.tabAngles.Controls.Add(this.btnGenerateCNCAnglesBatch);
            this.tabAngles.Location = new System.Drawing.Point(4, 22);
            this.tabAngles.Name = "tabAngles";
            this.tabAngles.Padding = new System.Windows.Forms.Padding(3);
            this.tabAngles.Size = new System.Drawing.Size(645, 493);
            this.tabAngles.TabIndex = 1;
            this.tabAngles.Text = "Angles";
            this.tabAngles.UseVisualStyleBackColor = true;
            // 
            // btnOpenAngleLayoutPDFs
            // 
            this.btnOpenAngleLayoutPDFs.Location = new System.Drawing.Point(201, 50);
            this.btnOpenAngleLayoutPDFs.Name = "btnOpenAngleLayoutPDFs";
            this.btnOpenAngleLayoutPDFs.Size = new System.Drawing.Size(112, 23);
            this.btnOpenAngleLayoutPDFs.TabIndex = 20;
            this.btnOpenAngleLayoutPDFs.Text = "Open PDFs";
            this.btnOpenAngleLayoutPDFs.UseVisualStyleBackColor = true;
            this.btnOpenAngleLayoutPDFs.Visible = false;
            this.btnOpenAngleLayoutPDFs.Click += new System.EventHandler(this.OpenAngleLayoutMarkPDFs);
            // 
            // labelLayoutMarksNeeded
            // 
            this.labelLayoutMarksNeeded.AutoSize = true;
            this.labelLayoutMarksNeeded.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLayoutMarksNeeded.Location = new System.Drawing.Point(3, 60);
            this.labelLayoutMarksNeeded.Name = "labelLayoutMarksNeeded";
            this.labelLayoutMarksNeeded.Size = new System.Drawing.Size(112, 13);
            this.labelLayoutMarksNeeded.TabIndex = 19;
            this.labelLayoutMarksNeeded.Text = "Layout Marks Needed";
            this.labelLayoutMarksNeeded.Visible = false;
            // 
            // dgvLayoutMarksNeeded
            // 
            this.dgvLayoutMarksNeeded.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLayoutMarksNeeded.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvLayoutMarksNeeded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLayoutMarksNeeded.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLayoutMarksNeeded.Location = new System.Drawing.Point(0, 76);
            this.dgvLayoutMarksNeeded.Name = "dgvLayoutMarksNeeded";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLayoutMarksNeeded.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvLayoutMarksNeeded.Size = new System.Drawing.Size(313, 237);
            this.dgvLayoutMarksNeeded.TabIndex = 18;
            this.dgvLayoutMarksNeeded.Visible = false;
            // 
            // lblSlotAdjustments
            // 
            this.lblSlotAdjustments.AutoSize = true;
            this.lblSlotAdjustments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlotAdjustments.Location = new System.Drawing.Point(6, 316);
            this.lblSlotAdjustments.Name = "lblSlotAdjustments";
            this.lblSlotAdjustments.Size = new System.Drawing.Size(85, 13);
            this.lblSlotAdjustments.TabIndex = 17;
            this.lblSlotAdjustments.Text = "Slot Adjustments";
            this.lblSlotAdjustments.Visible = false;
            // 
            // dgvSlotAdjustments
            // 
            this.dgvSlotAdjustments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSlotAdjustments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSlotAdjustments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSlotAdjustments.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSlotAdjustments.Location = new System.Drawing.Point(3, 332);
            this.dgvSlotAdjustments.Name = "dgvSlotAdjustments";
            this.dgvSlotAdjustments.Size = new System.Drawing.Size(313, 155);
            this.dgvSlotAdjustments.TabIndex = 16;
            this.dgvSlotAdjustments.Visible = false;
            // 
            // lblAnglesDSTVsNotFoundInJob
            // 
            this.lblAnglesDSTVsNotFoundInJob.AutoSize = true;
            this.lblAnglesDSTVsNotFoundInJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnglesDSTVsNotFoundInJob.Location = new System.Drawing.Point(321, 196);
            this.lblAnglesDSTVsNotFoundInJob.Name = "lblAnglesDSTVsNotFoundInJob";
            this.lblAnglesDSTVsNotFoundInJob.Size = new System.Drawing.Size(118, 13);
            this.lblAnglesDSTVsNotFoundInJob.TabIndex = 15;
            this.lblAnglesDSTVsNotFoundInJob.Text = "NC1s Not Found In Job";
            this.lblAnglesDSTVsNotFoundInJob.Visible = false;
            // 
            // dgvNotFoundAngles
            // 
            this.dgvNotFoundAngles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotFoundAngles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvNotFoundAngles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotFoundAngles.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvNotFoundAngles.Location = new System.Drawing.Point(322, 212);
            this.dgvNotFoundAngles.Name = "dgvNotFoundAngles";
            this.dgvNotFoundAngles.Size = new System.Drawing.Size(317, 275);
            this.dgvNotFoundAngles.TabIndex = 14;
            this.dgvNotFoundAngles.Visible = false;
            // 
            // lblAnglesHeaderLengthChanges
            // 
            this.lblAnglesHeaderLengthChanges.AutoSize = true;
            this.lblAnglesHeaderLengthChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnglesHeaderLengthChanges.Location = new System.Drawing.Point(321, 16);
            this.lblAnglesHeaderLengthChanges.Name = "lblAnglesHeaderLengthChanges";
            this.lblAnglesHeaderLengthChanges.Size = new System.Drawing.Size(123, 13);
            this.lblAnglesHeaderLengthChanges.TabIndex = 13;
            this.lblAnglesHeaderLengthChanges.Text = "Header Length Changes";
            this.lblAnglesHeaderLengthChanges.Visible = false;
            // 
            // dgvAnglesLengthChanges
            // 
            this.dgvAnglesLengthChanges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnglesLengthChanges.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvAnglesLengthChanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAnglesLengthChanges.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvAnglesLengthChanges.Location = new System.Drawing.Point(322, 32);
            this.dgvAnglesLengthChanges.Name = "dgvAnglesLengthChanges";
            this.dgvAnglesLengthChanges.Size = new System.Drawing.Size(319, 158);
            this.dgvAnglesLengthChanges.TabIndex = 12;
            this.dgvAnglesLengthChanges.Visible = false;
            // 
            // lblCNCAnglesFolderCreated
            // 
            this.lblCNCAnglesFolderCreated.AutoSize = true;
            this.lblCNCAnglesFolderCreated.Location = new System.Drawing.Point(4, 32);
            this.lblCNCAnglesFolderCreated.Name = "lblCNCAnglesFolderCreated";
            this.lblCNCAnglesFolderCreated.Size = new System.Drawing.Size(163, 13);
            this.lblCNCAnglesFolderCreated.TabIndex = 11;
            this.lblCNCAnglesFolderCreated.Text = "Batch folder created successfully";
            this.lblCNCAnglesFolderCreated.Visible = false;
            // 
            // btnGenerateCNCAnglesBatch
            // 
            this.btnGenerateCNCAnglesBatch.Location = new System.Drawing.Point(6, 6);
            this.btnGenerateCNCAnglesBatch.Name = "btnGenerateCNCAnglesBatch";
            this.btnGenerateCNCAnglesBatch.Size = new System.Drawing.Size(130, 23);
            this.btnGenerateCNCAnglesBatch.TabIndex = 10;
            this.btnGenerateCNCAnglesBatch.Text = "Generate Batch Folder";
            this.btnGenerateCNCAnglesBatch.UseVisualStyleBackColor = true;
            this.btnGenerateCNCAnglesBatch.Click += new System.EventHandler(this.GenerateCNCAnglesBatch);
            // 
            // tabBeams
            // 
            this.tabBeams.Controls.Add(this.btnFullPenPrep);
            this.tabBeams.Controls.Add(this.btnOpenWTDrawings);
            this.tabBeams.Controls.Add(this.lblWTsFound);
            this.tabBeams.Controls.Add(this.dgvWTsFound);
            this.tabBeams.Controls.Add(this.lblBeamsHeaderLengthChanges);
            this.tabBeams.Controls.Add(this.dgvBeamsLengthChanges);
            this.tabBeams.Controls.Add(this.lblDSTVsNotExportedToPython);
            this.tabBeams.Controls.Add(this.lblBeamsDSTVsNotFoundInJob);
            this.tabBeams.Controls.Add(this.dgvNotVerifiedBeams);
            this.tabBeams.Controls.Add(this.dgvNotFoundBeams);
            this.tabBeams.Controls.Add(this.lblVerifiedPythonJobs);
            this.tabBeams.Controls.Add(this.btnVerifyPythonBatch);
            this.tabBeams.Controls.Add(this.lblCNCBeamsFolderCreated);
            this.tabBeams.Controls.Add(this.btnGenerateCNCBeamsBatch);
            this.tabBeams.Location = new System.Drawing.Point(4, 22);
            this.tabBeams.Name = "tabBeams";
            this.tabBeams.Size = new System.Drawing.Size(645, 493);
            this.tabBeams.TabIndex = 2;
            this.tabBeams.Text = "Beams";
            this.tabBeams.UseVisualStyleBackColor = true;
            // 
            // btnFullPenPrep
            // 
            this.btnFullPenPrep.Location = new System.Drawing.Point(184, 9);
            this.btnFullPenPrep.Name = "btnFullPenPrep";
            this.btnFullPenPrep.Size = new System.Drawing.Size(115, 40);
            this.btnFullPenPrep.TabIndex = 43;
            this.btnFullPenPrep.Text = "Standard Full Pen Prep";
            this.btnFullPenPrep.UseVisualStyleBackColor = true;
            this.btnFullPenPrep.Click += new System.EventHandler(this.StandardFullPenPrep);
            // 
            // btnOpenWTDrawings
            // 
            this.btnOpenWTDrawings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenWTDrawings.Location = new System.Drawing.Point(69, 92);
            this.btnOpenWTDrawings.Name = "btnOpenWTDrawings";
            this.btnOpenWTDrawings.Size = new System.Drawing.Size(39, 21);
            this.btnOpenWTDrawings.TabIndex = 42;
            this.btnOpenWTDrawings.Text = "open";
            this.btnOpenWTDrawings.UseVisualStyleBackColor = true;
            this.btnOpenWTDrawings.Visible = false;
            this.btnOpenWTDrawings.Click += new System.EventHandler(this.OpenWTDrawings);
            // 
            // lblWTsFound
            // 
            this.lblWTsFound.AutoSize = true;
            this.lblWTsFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWTsFound.Location = new System.Drawing.Point(0, 100);
            this.lblWTsFound.Name = "lblWTsFound";
            this.lblWTsFound.Size = new System.Drawing.Size(63, 13);
            this.lblWTsFound.TabIndex = 11;
            this.lblWTsFound.Text = "WTs Found";
            this.lblWTsFound.Visible = false;
            // 
            // dgvWTsFound
            // 
            this.dgvWTsFound.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWTsFound.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvWTsFound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWTsFound.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvWTsFound.Location = new System.Drawing.Point(3, 116);
            this.dgvWTsFound.Name = "dgvWTsFound";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWTsFound.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvWTsFound.Size = new System.Drawing.Size(312, 141);
            this.dgvWTsFound.TabIndex = 10;
            this.dgvWTsFound.Visible = false;
            // 
            // lblBeamsHeaderLengthChanges
            // 
            this.lblBeamsHeaderLengthChanges.AutoSize = true;
            this.lblBeamsHeaderLengthChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeamsHeaderLengthChanges.Location = new System.Drawing.Point(318, 32);
            this.lblBeamsHeaderLengthChanges.Name = "lblBeamsHeaderLengthChanges";
            this.lblBeamsHeaderLengthChanges.Size = new System.Drawing.Size(123, 13);
            this.lblBeamsHeaderLengthChanges.TabIndex = 9;
            this.lblBeamsHeaderLengthChanges.Text = "Header Length Changes";
            this.lblBeamsHeaderLengthChanges.Visible = false;
            // 
            // dgvBeamsLengthChanges
            // 
            this.dgvBeamsLengthChanges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBeamsLengthChanges.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvBeamsLengthChanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBeamsLengthChanges.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvBeamsLengthChanges.Location = new System.Drawing.Point(321, 48);
            this.dgvBeamsLengthChanges.Name = "dgvBeamsLengthChanges";
            this.dgvBeamsLengthChanges.Size = new System.Drawing.Size(319, 153);
            this.dgvBeamsLengthChanges.TabIndex = 8;
            this.dgvBeamsLengthChanges.Visible = false;
            // 
            // lblDSTVsNotExportedToPython
            // 
            this.lblDSTVsNotExportedToPython.AutoSize = true;
            this.lblDSTVsNotExportedToPython.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSTVsNotExportedToPython.Location = new System.Drawing.Point(318, 215);
            this.lblDSTVsNotExportedToPython.Name = "lblDSTVsNotExportedToPython";
            this.lblDSTVsNotExportedToPython.Size = new System.Drawing.Size(168, 13);
            this.lblDSTVsNotExportedToPython.TabIndex = 7;
            this.lblDSTVsNotExportedToPython.Text = "NC1s Not Located In Python Jobs";
            this.lblDSTVsNotExportedToPython.Visible = false;
            // 
            // lblBeamsDSTVsNotFoundInJob
            // 
            this.lblBeamsDSTVsNotFoundInJob.AutoSize = true;
            this.lblBeamsDSTVsNotFoundInJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeamsDSTVsNotFoundInJob.Location = new System.Drawing.Point(3, 269);
            this.lblBeamsDSTVsNotFoundInJob.Name = "lblBeamsDSTVsNotFoundInJob";
            this.lblBeamsDSTVsNotFoundInJob.Size = new System.Drawing.Size(118, 13);
            this.lblBeamsDSTVsNotFoundInJob.TabIndex = 6;
            this.lblBeamsDSTVsNotFoundInJob.Text = "NC1s Not Found In Job";
            this.lblBeamsDSTVsNotFoundInJob.Visible = false;
            // 
            // dgvNotVerifiedBeams
            // 
            this.dgvNotVerifiedBeams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotVerifiedBeams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvNotVerifiedBeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotVerifiedBeams.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgvNotVerifiedBeams.Location = new System.Drawing.Point(321, 232);
            this.dgvNotVerifiedBeams.Name = "dgvNotVerifiedBeams";
            this.dgvNotVerifiedBeams.Size = new System.Drawing.Size(321, 258);
            this.dgvNotVerifiedBeams.TabIndex = 5;
            this.dgvNotVerifiedBeams.Visible = false;
            // 
            // dgvNotFoundBeams
            // 
            this.dgvNotFoundBeams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotFoundBeams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvNotFoundBeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotFoundBeams.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvNotFoundBeams.Location = new System.Drawing.Point(3, 285);
            this.dgvNotFoundBeams.Name = "dgvNotFoundBeams";
            this.dgvNotFoundBeams.Size = new System.Drawing.Size(312, 205);
            this.dgvNotFoundBeams.TabIndex = 4;
            this.dgvNotFoundBeams.Visible = false;
            // 
            // lblVerifiedPythonJobs
            // 
            this.lblVerifiedPythonJobs.AutoSize = true;
            this.lblVerifiedPythonJobs.Location = new System.Drawing.Point(10, 79);
            this.lblVerifiedPythonJobs.Name = "lblVerifiedPythonJobs";
            this.lblVerifiedPythonJobs.Size = new System.Drawing.Size(149, 13);
            this.lblVerifiedPythonJobs.TabIndex = 3;
            this.lblVerifiedPythonJobs.Text = "All files located in Python Jobs";
            this.lblVerifiedPythonJobs.Visible = false;
            // 
            // btnVerifyPythonBatch
            // 
            this.btnVerifyPythonBatch.Enabled = false;
            this.btnVerifyPythonBatch.Location = new System.Drawing.Point(10, 52);
            this.btnVerifyPythonBatch.Name = "btnVerifyPythonBatch";
            this.btnVerifyPythonBatch.Size = new System.Drawing.Size(115, 24);
            this.btnVerifyPythonBatch.TabIndex = 2;
            this.btnVerifyPythonBatch.Text = "Verify Python Parts";
            this.btnVerifyPythonBatch.UseVisualStyleBackColor = true;
            this.btnVerifyPythonBatch.Click += new System.EventHandler(this.VerifyPythonBatch);
            // 
            // lblCNCBeamsFolderCreated
            // 
            this.lblCNCBeamsFolderCreated.AutoSize = true;
            this.lblCNCBeamsFolderCreated.Location = new System.Drawing.Point(8, 36);
            this.lblCNCBeamsFolderCreated.Name = "lblCNCBeamsFolderCreated";
            this.lblCNCBeamsFolderCreated.Size = new System.Drawing.Size(163, 13);
            this.lblCNCBeamsFolderCreated.TabIndex = 1;
            this.lblCNCBeamsFolderCreated.Text = "Batch folder created successfully";
            this.lblCNCBeamsFolderCreated.Visible = false;
            // 
            // btnGenerateCNCBeamsBatch
            // 
            this.btnGenerateCNCBeamsBatch.Location = new System.Drawing.Point(10, 10);
            this.btnGenerateCNCBeamsBatch.Name = "btnGenerateCNCBeamsBatch";
            this.btnGenerateCNCBeamsBatch.Size = new System.Drawing.Size(133, 23);
            this.btnGenerateCNCBeamsBatch.TabIndex = 0;
            this.btnGenerateCNCBeamsBatch.Text = "Generate Batch Folder";
            this.btnGenerateCNCBeamsBatch.UseVisualStyleBackColor = true;
            this.btnGenerateCNCBeamsBatch.Click += new System.EventHandler(this.GenerateCNCBeamsBatch);
            // 
            // tabShopPrints
            // 
            this.tabShopPrints.Controls.Add(this.btnOpenShopPrints);
            this.tabShopPrints.Controls.Add(this.btnPrint);
            this.tabShopPrints.Controls.Add(this.chckAutoPDFOutputDirectory);
            this.tabShopPrints.Controls.Add(this.chckAutoPDFsDirectory);
            this.tabShopPrints.Controls.Add(this.lblDone);
            this.tabShopPrints.Controls.Add(this.lblPDFOutputDirectory);
            this.tabShopPrints.Controls.Add(this.lblPDFDirectory);
            this.tabShopPrints.Controls.Add(this.seqLabel);
            this.tabShopPrints.Controls.Add(this.txtSequence);
            this.tabShopPrints.Controls.Add(this.btnSelectPDFOutputDirectory);
            this.tabShopPrints.Controls.Add(this.btnSelectPDFsDirectory);
            this.tabShopPrints.Controls.Add(this.colorLabel);
            this.tabShopPrints.Controls.Add(this.notesLabel);
            this.tabShopPrints.Controls.Add(this.txtSequenceColor);
            this.tabShopPrints.Controls.Add(this.txtBatchDescription);
            this.tabShopPrints.Controls.Add(this.btnGenerateShopPrints);
            this.tabShopPrints.Location = new System.Drawing.Point(4, 22);
            this.tabShopPrints.Name = "tabShopPrints";
            this.tabShopPrints.Size = new System.Drawing.Size(645, 493);
            this.tabShopPrints.TabIndex = 3;
            this.tabShopPrints.Text = "Shop Prints";
            this.tabShopPrints.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(6, 312);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(64, 21);
            this.btnPrint.TabIndex = 28;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.PrintPDF);
            // 
            // chckAutoPDFOutputDirectory
            // 
            this.chckAutoPDFOutputDirectory.AutoSize = true;
            this.chckAutoPDFOutputDirectory.Checked = true;
            this.chckAutoPDFOutputDirectory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckAutoPDFOutputDirectory.Location = new System.Drawing.Point(3, 73);
            this.chckAutoPDFOutputDirectory.Name = "chckAutoPDFOutputDirectory";
            this.chckAutoPDFOutputDirectory.Size = new System.Drawing.Size(83, 17);
            this.chckAutoPDFOutputDirectory.TabIndex = 27;
            this.chckAutoPDFOutputDirectory.Text = "Auto Detect";
            this.chckAutoPDFOutputDirectory.UseVisualStyleBackColor = true;
            this.chckAutoPDFOutputDirectory.CheckStateChanged += new System.EventHandler(this.AutoPDFOutputDirectoryChecked);
            // 
            // chckAutoPDFsDirectory
            // 
            this.chckAutoPDFsDirectory.AutoSize = true;
            this.chckAutoPDFsDirectory.Checked = true;
            this.chckAutoPDFsDirectory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckAutoPDFsDirectory.Location = new System.Drawing.Point(3, 3);
            this.chckAutoPDFsDirectory.Name = "chckAutoPDFsDirectory";
            this.chckAutoPDFsDirectory.Size = new System.Drawing.Size(80, 17);
            this.chckAutoPDFsDirectory.TabIndex = 26;
            this.chckAutoPDFsDirectory.Text = "AutoDetect";
            this.chckAutoPDFsDirectory.UseVisualStyleBackColor = true;
            this.chckAutoPDFsDirectory.CheckStateChanged += new System.EventHandler(this.AutoPDFsDirectoryChecked);
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Location = new System.Drawing.Point(9, 279);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(0, 13);
            this.lblDone.TabIndex = 25;
            // 
            // lblPDFOutputDirectory
            // 
            this.lblPDFOutputDirectory.AutoSize = true;
            this.lblPDFOutputDirectory.Location = new System.Drawing.Point(143, 101);
            this.lblPDFOutputDirectory.Name = "lblPDFOutputDirectory";
            this.lblPDFOutputDirectory.Size = new System.Drawing.Size(0, 13);
            this.lblPDFOutputDirectory.TabIndex = 24;
            // 
            // lblPDFDirectory
            // 
            this.lblPDFDirectory.AutoSize = true;
            this.lblPDFDirectory.Location = new System.Drawing.Point(143, 31);
            this.lblPDFDirectory.Name = "lblPDFDirectory";
            this.lblPDFDirectory.Size = new System.Drawing.Size(0, 13);
            this.lblPDFDirectory.TabIndex = 23;
            // 
            // seqLabel
            // 
            this.seqLabel.AutoSize = true;
            this.seqLabel.Location = new System.Drawing.Point(46, 164);
            this.seqLabel.Name = "seqLabel";
            this.seqLabel.Size = new System.Drawing.Size(59, 13);
            this.seqLabel.TabIndex = 22;
            this.seqLabel.Text = "Sequence:";
            // 
            // txtSequence
            // 
            this.txtSequence.Location = new System.Drawing.Point(111, 164);
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.Size = new System.Drawing.Size(227, 20);
            this.txtSequence.TabIndex = 17;
            // 
            // btnSelectPDFOutputDirectory
            // 
            this.btnSelectPDFOutputDirectory.Location = new System.Drawing.Point(2, 96);
            this.btnSelectPDFOutputDirectory.Name = "btnSelectPDFOutputDirectory";
            this.btnSelectPDFOutputDirectory.Size = new System.Drawing.Size(135, 23);
            this.btnSelectPDFOutputDirectory.TabIndex = 15;
            this.btnSelectPDFOutputDirectory.Text = "Select Output Directory";
            this.btnSelectPDFOutputDirectory.UseVisualStyleBackColor = true;
            this.btnSelectPDFOutputDirectory.Click += new System.EventHandler(this.SelectPDFOutputDirectory);
            // 
            // btnSelectPDFsDirectory
            // 
            this.btnSelectPDFsDirectory.Location = new System.Drawing.Point(2, 26);
            this.btnSelectPDFsDirectory.Name = "btnSelectPDFsDirectory";
            this.btnSelectPDFsDirectory.Size = new System.Drawing.Size(81, 23);
            this.btnSelectPDFsDirectory.TabIndex = 14;
            this.btnSelectPDFsDirectory.Text = "Select PDFs Directory";
            this.btnSelectPDFsDirectory.UseVisualStyleBackColor = true;
            this.btnSelectPDFsDirectory.Click += new System.EventHandler(this.SelectPDFsDirectory);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(11, 193);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(86, 13);
            this.colorLabel.TabIndex = 19;
            this.colorLabel.Text = "Sequence Color:";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(11, 140);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(94, 13);
            this.notesLabel.TabIndex = 18;
            this.notesLabel.Text = "Batch Description:";
            // 
            // txtSequenceColor
            // 
            this.txtSequenceColor.Location = new System.Drawing.Point(111, 190);
            this.txtSequenceColor.Name = "txtSequenceColor";
            this.txtSequenceColor.Size = new System.Drawing.Size(227, 20);
            this.txtSequenceColor.TabIndex = 20;
            // 
            // txtBatchDescription
            // 
            this.txtBatchDescription.Location = new System.Drawing.Point(111, 137);
            this.txtBatchDescription.Name = "txtBatchDescription";
            this.txtBatchDescription.Size = new System.Drawing.Size(227, 20);
            this.txtBatchDescription.TabIndex = 16;
            // 
            // btnGenerateShopPrints
            // 
            this.btnGenerateShopPrints.Enabled = false;
            this.btnGenerateShopPrints.Location = new System.Drawing.Point(2, 248);
            this.btnGenerateShopPrints.Name = "btnGenerateShopPrints";
            this.btnGenerateShopPrints.Size = new System.Drawing.Size(135, 23);
            this.btnGenerateShopPrints.TabIndex = 21;
            this.btnGenerateShopPrints.Text = "Generate Shop Print";
            this.btnGenerateShopPrints.UseVisualStyleBackColor = true;
            this.btnGenerateShopPrints.Click += new System.EventHandler(this.GenerateShopPrints);
            // 
            // btnChangeBatch
            // 
            this.btnChangeBatch.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeBatch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangeBatch.BackgroundImage")));
            this.btnChangeBatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangeBatch.FlatAppearance.BorderSize = 0;
            this.btnChangeBatch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChangeBatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChangeBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeBatch.Location = new System.Drawing.Point(12, 37);
            this.btnChangeBatch.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangeBatch.Name = "btnChangeBatch";
            this.btnChangeBatch.Size = new System.Drawing.Size(35, 35);
            this.btnChangeBatch.TabIndex = 27;
            this.btnChangeBatch.UseVisualStyleBackColor = false;
            this.btnChangeBatch.Click += new System.EventHandler(this.ChangeBatch);
            // 
            // dgvMainList
            // 
            this.dgvMainList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMainList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMainList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMainList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainList.Location = new System.Drawing.Point(12, 73);
            this.dgvMainList.Name = "dgvMainList";
            this.dgvMainList.Size = new System.Drawing.Size(462, 519);
            this.dgvMainList.TabIndex = 30;
            this.dgvMainList.Visible = false;
            // 
            // lblBatchHeading
            // 
            this.lblBatchHeading.AutoSize = true;
            this.lblBatchHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblBatchHeading.Font = new System.Drawing.Font("BankGothic Md BT", 17F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchHeading.ForeColor = System.Drawing.Color.Snow;
            this.lblBatchHeading.Location = new System.Drawing.Point(67, 40);
            this.lblBatchHeading.Name = "lblBatchHeading";
            this.lblBatchHeading.Size = new System.Drawing.Size(268, 24);
            this.lblBatchHeading.TabIndex = 31;
            this.lblBatchHeading.Text = "Select two reports";
            // 
            // openReports
            // 
            this.openReports.FileName = "openFileDialog1";
            this.openReports.Multiselect = true;
            // 
            // openMaster
            // 
            this.openMaster.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // openMissingPDF
            // 
            this.openMissingPDF.FileName = "openFileDialog1";
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.BackColor = System.Drawing.Color.Transparent;
            this.lblMachine.Font = new System.Drawing.Font("BankGothic Md BT", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachine.ForeColor = System.Drawing.Color.Snow;
            this.lblMachine.Location = new System.Drawing.Point(536, 40);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(0, 24);
            this.lblMachine.TabIndex = 32;
            // 
            // btnChangeMachine
            // 
            this.btnChangeMachine.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeMachine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangeMachine.BackgroundImage")));
            this.btnChangeMachine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangeMachine.FlatAppearance.BorderSize = 0;
            this.btnChangeMachine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChangeMachine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChangeMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeMachine.Location = new System.Drawing.Point(505, 37);
            this.btnChangeMachine.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangeMachine.Name = "btnChangeMachine";
            this.btnChangeMachine.Size = new System.Drawing.Size(35, 35);
            this.btnChangeMachine.TabIndex = 33;
            this.btnChangeMachine.UseVisualStyleBackColor = false;
            this.btnChangeMachine.Visible = false;
            this.btnChangeMachine.Click += new System.EventHandler(this.ChangeMachine);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(426, 13);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 34;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.NextBatch);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(319, 12);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 35;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.PreviousBatch);
            // 
            // btnOpenShopPrints
            // 
            this.btnOpenShopPrints.Location = new System.Drawing.Point(156, 247);
            this.btnOpenShopPrints.Name = "btnOpenShopPrints";
            this.btnOpenShopPrints.Size = new System.Drawing.Size(75, 23);
            this.btnOpenShopPrints.TabIndex = 29;
            this.btnOpenShopPrints.Text = "Open";
            this.btnOpenShopPrints.UseVisualStyleBackColor = true;
            this.btnOpenShopPrints.Click += new System.EventHandler(this.OpenShopPrints);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1136, 604);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnChangeMachine);
            this.Controls.Add(this.lblMachine);
            this.Controls.Add(this.lblBatchHeading);
            this.Controls.Add(this.dgvMainList);
            this.Controls.Add(this.btnChangeBatch);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CNC-Z";
            this.tabControl1.ResumeLayout(false);
            this.tabPlates.ResumeLayout(false);
            this.tabPlates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDXFsNotFound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDRsFound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStiffenersFound)).EndInit();
            this.tabAngles.ResumeLayout(false);
            this.tabAngles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayoutMarksNeeded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlotAdjustments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotFoundAngles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnglesLengthChanges)).EndInit();
            this.tabBeams.ResumeLayout(false);
            this.tabBeams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWTsFound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeamsLengthChanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotVerifiedBeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotFoundBeams)).EndInit();
            this.tabShopPrints.ResumeLayout(false);
            this.tabShopPrints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPlates;
        private System.Windows.Forms.TabPage tabAngles;
        private System.Windows.Forms.TabPage tabBeams;
        private System.Windows.Forms.TabPage tabShopPrints;
        private System.Windows.Forms.CheckBox chckAutoPDFOutputDirectory;
        private System.Windows.Forms.CheckBox chckAutoPDFsDirectory;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Label lblPDFOutputDirectory;
        private System.Windows.Forms.Label lblPDFDirectory;
        private System.Windows.Forms.Label seqLabel;
        private System.Windows.Forms.TextBox txtSequence;
        private System.Windows.Forms.Button btnSelectPDFOutputDirectory;
        private System.Windows.Forms.Button btnSelectPDFsDirectory;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox txtSequenceColor;
        private System.Windows.Forms.TextBox txtBatchDescription;
        private System.Windows.Forms.Button btnGenerateShopPrints;
        private System.Windows.Forms.Button btnChangeBatch;
        private System.Windows.Forms.DataGridView dgvMainList;
        private System.Windows.Forms.Label lblBatchHeading;
        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.Button btnSortPlates;
        private System.Windows.Forms.Label lblPlateSearchFolder;
        private System.Windows.Forms.CheckBox chkAutoPlateSearch;
        private System.Windows.Forms.Button btnSelectMasterDXFsFolder;
        private System.Windows.Forms.Button btnOpenDRs;
        private System.Windows.Forms.Button btnOpenStiffeners;
        private System.Windows.Forms.Label lblDXFsNotFound;
        private System.Windows.Forms.Label lblDRsFound;
        private System.Windows.Forms.DataGridView dgvDXFsNotFound;
        private System.Windows.Forms.DataGridView dgvDRsFound;
        private System.Windows.Forms.Label lblStiffenersFound;
        private System.Windows.Forms.DataGridView dgvStiffenersFound;
        private System.Windows.Forms.OpenFileDialog openReports;
        private System.Windows.Forms.FolderBrowserDialog openMaster;
        private System.Windows.Forms.FolderBrowserDialog openPDFsDirectory;
        private System.Windows.Forms.FolderBrowserDialog openPDFOutputDirectory;
        private System.Windows.Forms.OpenFileDialog openMissingPDF;
        private System.Windows.Forms.Button btnGenerateCNCBeamsBatch;
        private System.Windows.Forms.Button btnVerifyPythonBatch;
        private System.Windows.Forms.Label lblCNCBeamsFolderCreated;
        private System.Windows.Forms.Label lblVerifiedPythonJobs;
        private System.Windows.Forms.DataGridView dgvNotFoundBeams;
        private System.Windows.Forms.DataGridView dgvNotVerifiedBeams;
        private System.Windows.Forms.Label lblDSTVsNotExportedToPython;
        private System.Windows.Forms.Label lblBeamsDSTVsNotFoundInJob;
        private System.Windows.Forms.Label lblBeamsHeaderLengthChanges;
        private System.Windows.Forms.DataGridView dgvBeamsLengthChanges;
        private System.Windows.Forms.Label lblAnglesHeaderLengthChanges;
        private System.Windows.Forms.DataGridView dgvAnglesLengthChanges;
        private System.Windows.Forms.Label lblCNCAnglesFolderCreated;
        private System.Windows.Forms.Button btnGenerateCNCAnglesBatch;
        private System.Windows.Forms.Label lblAnglesDSTVsNotFoundInJob;
        private System.Windows.Forms.DataGridView dgvNotFoundAngles;
        private System.Windows.Forms.Label lblSlotAdjustments;
        private System.Windows.Forms.DataGridView dgvSlotAdjustments;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Button btnOpenDXFsNotFound;
        private System.Windows.Forms.Label lblWTsFound;
        private System.Windows.Forms.DataGridView dgvWTsFound;
        private System.Windows.Forms.Button btnChangeMachine;
        private System.Windows.Forms.Button btnOpenWTDrawings;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnOpenAngleLayoutPDFs;
        private System.Windows.Forms.Label labelLayoutMarksNeeded;
        private System.Windows.Forms.DataGridView dgvLayoutMarksNeeded;
        private System.Windows.Forms.Button btnFullPenPrep;
        private System.Windows.Forms.Button btnOpenShopPrints;
    }
}

