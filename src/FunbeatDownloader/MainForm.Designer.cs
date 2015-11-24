using MK.Funbeat;

namespace FunbeatDownloader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnProcessClipboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDownload = new System.Windows.Forms.TabPage();
            this.tabDayNotes = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.grdDayNotes = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restingHeartRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kCalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bndDayNotes = new System.Windows.Forms.BindingSource(this.components);
            this.tabTrainingRaw = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdTrainingRawDatas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bndTrainingRaw = new System.Windows.Forms.BindingSource(this.components);
            this.btnFetchTrainings = new System.Windows.Forms.Button();
            this.tabTraining = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.grdTrainings = new System.Windows.Forms.DataGridView();
            this.trainingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ascentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privateCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intensityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadAvgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRAvgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectAvgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kCalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repetitionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasTimeOfDayDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.creationDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCompetitionDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.raceTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geoRegionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isChangedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bndTraining = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabDownload.SuspendLayout();
            this.tabDayNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDayNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndDayNotes)).BeginInit();
            this.tabTrainingRaw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTrainingRawDatas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndTrainingRaw)).BeginInit();
            this.tabTraining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTrainings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndTraining)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcessClipboard
            // 
            this.btnProcessClipboard.Location = new System.Drawing.Point(9, 63);
            this.btnProcessClipboard.Name = "btnProcessClipboard";
            this.btnProcessClipboard.Size = new System.Drawing.Size(239, 37);
            this.btnProcessClipboard.TabIndex = 0;
            this.btnProcessClipboard.Text = "Process clipboard content";
            this.btnProcessClipboard.UseVisualStyleBackColor = true;
            this.btnProcessClipboard.Click += new System.EventHandler(this.btnProcessClipboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDownload);
            this.tabControl1.Controls.Add(this.tabDayNotes);
            this.tabControl1.Controls.Add(this.tabTrainingRaw);
            this.tabControl1.Controls.Add(this.tabTraining);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 462);
            this.tabControl1.TabIndex = 3;
            // 
            // tabDownload
            // 
            this.tabDownload.Controls.Add(this.label1);
            this.tabDownload.Controls.Add(this.btnProcessClipboard);
            this.tabDownload.Location = new System.Drawing.Point(4, 22);
            this.tabDownload.Name = "tabDownload";
            this.tabDownload.Padding = new System.Windows.Forms.Padding(3);
            this.tabDownload.Size = new System.Drawing.Size(976, 436);
            this.tabDownload.TabIndex = 0;
            this.tabDownload.Text = "Download";
            this.tabDownload.UseVisualStyleBackColor = true;
            // 
            // tabDayNotes
            // 
            this.tabDayNotes.Controls.Add(this.label4);
            this.tabDayNotes.Controls.Add(this.grdDayNotes);
            this.tabDayNotes.Location = new System.Drawing.Point(4, 22);
            this.tabDayNotes.Name = "tabDayNotes";
            this.tabDayNotes.Padding = new System.Windows.Forms.Padding(3);
            this.tabDayNotes.Size = new System.Drawing.Size(976, 436);
            this.tabDayNotes.TabIndex = 1;
            this.tabDayNotes.Text = "Day Notes";
            this.tabDayNotes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Day notes from the calendar will appear here as soon as they are processed.";
            // 
            // grdDayNotes
            // 
            this.grdDayNotes.AllowUserToOrderColumns = true;
            this.grdDayNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDayNotes.AutoGenerateColumns = false;
            this.grdDayNotes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.grdDayNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDayNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.restingHeartRateDataGridViewTextBoxColumn,
            this.kCalDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.grdDayNotes.DataSource = this.bndDayNotes;
            this.grdDayNotes.Location = new System.Drawing.Point(9, 25);
            this.grdDayNotes.Name = "grdDayNotes";
            this.grdDayNotes.Size = new System.Drawing.Size(959, 403);
            this.grdDayNotes.TabIndex = 0;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // restingHeartRateDataGridViewTextBoxColumn
            // 
            this.restingHeartRateDataGridViewTextBoxColumn.DataPropertyName = "RestingHeartRate";
            this.restingHeartRateDataGridViewTextBoxColumn.HeaderText = "RestingHeartRate";
            this.restingHeartRateDataGridViewTextBoxColumn.Name = "restingHeartRateDataGridViewTextBoxColumn";
            // 
            // kCalDataGridViewTextBoxColumn
            // 
            this.kCalDataGridViewTextBoxColumn.DataPropertyName = "KCal";
            this.kCalDataGridViewTextBoxColumn.HeaderText = "KCal";
            this.kCalDataGridViewTextBoxColumn.Name = "kCalDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.Width = 300;
            // 
            // bndDayNotes
            // 
            this.bndDayNotes.DataSource = typeof(MK.Funbeat.DayNote);
            // 
            // tabTrainingRaw
            // 
            this.tabTrainingRaw.Controls.Add(this.label5);
            this.tabTrainingRaw.Controls.Add(this.txtPassword);
            this.tabTrainingRaw.Controls.Add(this.txtUsername);
            this.tabTrainingRaw.Controls.Add(this.label3);
            this.tabTrainingRaw.Controls.Add(this.label2);
            this.tabTrainingRaw.Controls.Add(this.grdTrainingRawDatas);
            this.tabTrainingRaw.Controls.Add(this.btnFetchTrainings);
            this.tabTrainingRaw.Location = new System.Drawing.Point(4, 22);
            this.tabTrainingRaw.Name = "tabTrainingRaw";
            this.tabTrainingRaw.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrainingRaw.Size = new System.Drawing.Size(976, 436);
            this.tabTrainingRaw.TabIndex = 3;
            this.tabTrainingRaw.Text = "Training json data";
            this.tabTrainingRaw.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(442, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter your funbeat login details in order to fetch training data from the list of" +
    " training ids below";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(115, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(170, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(115, 29);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(170, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Funbeat Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Funbeat Username";
            // 
            // grdTrainingRawDatas
            // 
            this.grdTrainingRawDatas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTrainingRawDatas.AutoGenerateColumns = false;
            this.grdTrainingRawDatas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.grdTrainingRawDatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTrainingRawDatas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.dataDataGridViewTextBoxColumn});
            this.grdTrainingRawDatas.DataSource = this.bndTrainingRaw;
            this.grdTrainingRawDatas.Location = new System.Drawing.Point(8, 83);
            this.grdTrainingRawDatas.Name = "grdTrainingRawDatas";
            this.grdTrainingRawDatas.Size = new System.Drawing.Size(959, 346);
            this.grdTrainingRawDatas.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.Width = 800;
            // 
            // bndTrainingRaw
            // 
            this.bndTrainingRaw.DataSource = typeof(MK.Funbeat.RawTraining);
            // 
            // btnFetchTrainings
            // 
            this.btnFetchTrainings.Location = new System.Drawing.Point(309, 31);
            this.btnFetchTrainings.Name = "btnFetchTrainings";
            this.btnFetchTrainings.Size = new System.Drawing.Size(171, 37);
            this.btnFetchTrainings.TabIndex = 4;
            this.btnFetchTrainings.Text = "Fetch and convert trainings";
            this.btnFetchTrainings.UseVisualStyleBackColor = true;
            this.btnFetchTrainings.Click += new System.EventHandler(this.btnFetchTrainings_Click);
            // 
            // tabTraining
            // 
            this.tabTraining.Controls.Add(this.label6);
            this.tabTraining.Controls.Add(this.grdTrainings);
            this.tabTraining.Location = new System.Drawing.Point(4, 22);
            this.tabTraining.Name = "tabTraining";
            this.tabTraining.Padding = new System.Windows.Forms.Padding(3);
            this.tabTraining.Size = new System.Drawing.Size(976, 436);
            this.tabTraining.TabIndex = 2;
            this.tabTraining.Text = "Training";
            this.tabTraining.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(453, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Select all rows and press Ctrl+C to copy. Then paste into Excel or similar for fu" +
    "rther processing. \r\nTip: Paste into Google Spreadsheet first if you have comment" +
    "s that contain multiple lines.";
            // 
            // grdTrainings
            // 
            this.grdTrainings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTrainings.AutoGenerateColumns = false;
            this.grdTrainings.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.grdTrainings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTrainings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainingIDDataGridViewTextBoxColumn,
            this.startDateTimeDataGridViewTextBoxColumn,
            this.trainingTypeNameDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.ascentDataGridViewTextBoxColumn,
            this.descentDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.privateCommentDataGridViewTextBoxColumn,
            this.intensityDataGridViewTextBoxColumn,
            this.cadAvgDataGridViewTextBoxColumn,
            this.hRAvgDataGridViewTextBoxColumn,
            this.hRMaxDataGridViewTextBoxColumn,
            this.effectAvgDataGridViewTextBoxColumn,
            this.effectMaxDataGridViewTextBoxColumn,
            this.kCalDataGridViewTextBoxColumn1,
            this.routeNameDataGridViewTextBoxColumn,
            this.setsDataGridViewTextBoxColumn,
            this.repetitionsDataGridViewTextBoxColumn,
            this.stepsDataGridViewTextBoxColumn,
            this.tEDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn1,
            this.hasTimeOfDayDataGridViewCheckBoxColumn,
            this.creationDateTimeDataGridViewTextBoxColumn,
            this.isCompetitionDataGridViewCheckBoxColumn,
            this.raceTitleDataGridViewTextBoxColumn,
            this.routeIDDataGridViewTextBoxColumn,
            this.trainingTypeIDDataGridViewTextBoxColumn,
            this.geoRegionIDDataGridViewTextBoxColumn,
            this.isChangedDataGridViewCheckBoxColumn});
            this.grdTrainings.DataSource = this.bndTraining;
            this.grdTrainings.Location = new System.Drawing.Point(9, 41);
            this.grdTrainings.Name = "grdTrainings";
            this.grdTrainings.Size = new System.Drawing.Size(959, 388);
            this.grdTrainings.TabIndex = 2;
            // 
            // trainingIDDataGridViewTextBoxColumn
            // 
            this.trainingIDDataGridViewTextBoxColumn.DataPropertyName = "TrainingID";
            this.trainingIDDataGridViewTextBoxColumn.HeaderText = "TrainingID";
            this.trainingIDDataGridViewTextBoxColumn.Name = "trainingIDDataGridViewTextBoxColumn";
            // 
            // startDateTimeDataGridViewTextBoxColumn
            // 
            this.startDateTimeDataGridViewTextBoxColumn.DataPropertyName = "StartDateTime";
            this.startDateTimeDataGridViewTextBoxColumn.HeaderText = "StartDateTime";
            this.startDateTimeDataGridViewTextBoxColumn.Name = "startDateTimeDataGridViewTextBoxColumn";
            // 
            // trainingTypeNameDataGridViewTextBoxColumn
            // 
            this.trainingTypeNameDataGridViewTextBoxColumn.DataPropertyName = "TrainingTypeName";
            this.trainingTypeNameDataGridViewTextBoxColumn.HeaderText = "TrainingTypeName";
            this.trainingTypeNameDataGridViewTextBoxColumn.Name = "trainingTypeNameDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            // 
            // ascentDataGridViewTextBoxColumn
            // 
            this.ascentDataGridViewTextBoxColumn.DataPropertyName = "Ascent";
            this.ascentDataGridViewTextBoxColumn.HeaderText = "Ascent";
            this.ascentDataGridViewTextBoxColumn.Name = "ascentDataGridViewTextBoxColumn";
            // 
            // descentDataGridViewTextBoxColumn
            // 
            this.descentDataGridViewTextBoxColumn.DataPropertyName = "Descent";
            this.descentDataGridViewTextBoxColumn.HeaderText = "Descent";
            this.descentDataGridViewTextBoxColumn.Name = "descentDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // privateCommentDataGridViewTextBoxColumn
            // 
            this.privateCommentDataGridViewTextBoxColumn.DataPropertyName = "PrivateComment";
            this.privateCommentDataGridViewTextBoxColumn.HeaderText = "PrivateComment";
            this.privateCommentDataGridViewTextBoxColumn.Name = "privateCommentDataGridViewTextBoxColumn";
            // 
            // intensityDataGridViewTextBoxColumn
            // 
            this.intensityDataGridViewTextBoxColumn.DataPropertyName = "Intensity";
            this.intensityDataGridViewTextBoxColumn.HeaderText = "Intensity";
            this.intensityDataGridViewTextBoxColumn.Name = "intensityDataGridViewTextBoxColumn";
            // 
            // cadAvgDataGridViewTextBoxColumn
            // 
            this.cadAvgDataGridViewTextBoxColumn.DataPropertyName = "CadAvg";
            this.cadAvgDataGridViewTextBoxColumn.HeaderText = "CadAvg";
            this.cadAvgDataGridViewTextBoxColumn.Name = "cadAvgDataGridViewTextBoxColumn";
            // 
            // hRAvgDataGridViewTextBoxColumn
            // 
            this.hRAvgDataGridViewTextBoxColumn.DataPropertyName = "HRAvg";
            this.hRAvgDataGridViewTextBoxColumn.HeaderText = "HRAvg";
            this.hRAvgDataGridViewTextBoxColumn.Name = "hRAvgDataGridViewTextBoxColumn";
            // 
            // hRMaxDataGridViewTextBoxColumn
            // 
            this.hRMaxDataGridViewTextBoxColumn.DataPropertyName = "HRMax";
            this.hRMaxDataGridViewTextBoxColumn.HeaderText = "HRMax";
            this.hRMaxDataGridViewTextBoxColumn.Name = "hRMaxDataGridViewTextBoxColumn";
            // 
            // effectAvgDataGridViewTextBoxColumn
            // 
            this.effectAvgDataGridViewTextBoxColumn.DataPropertyName = "EffectAvg";
            this.effectAvgDataGridViewTextBoxColumn.HeaderText = "EffectAvg";
            this.effectAvgDataGridViewTextBoxColumn.Name = "effectAvgDataGridViewTextBoxColumn";
            // 
            // effectMaxDataGridViewTextBoxColumn
            // 
            this.effectMaxDataGridViewTextBoxColumn.DataPropertyName = "EffectMax";
            this.effectMaxDataGridViewTextBoxColumn.HeaderText = "EffectMax";
            this.effectMaxDataGridViewTextBoxColumn.Name = "effectMaxDataGridViewTextBoxColumn";
            // 
            // kCalDataGridViewTextBoxColumn1
            // 
            this.kCalDataGridViewTextBoxColumn1.DataPropertyName = "KCal";
            this.kCalDataGridViewTextBoxColumn1.HeaderText = "KCal";
            this.kCalDataGridViewTextBoxColumn1.Name = "kCalDataGridViewTextBoxColumn1";
            // 
            // routeNameDataGridViewTextBoxColumn
            // 
            this.routeNameDataGridViewTextBoxColumn.DataPropertyName = "RouteName";
            this.routeNameDataGridViewTextBoxColumn.HeaderText = "RouteName";
            this.routeNameDataGridViewTextBoxColumn.Name = "routeNameDataGridViewTextBoxColumn";
            // 
            // setsDataGridViewTextBoxColumn
            // 
            this.setsDataGridViewTextBoxColumn.DataPropertyName = "Sets";
            this.setsDataGridViewTextBoxColumn.HeaderText = "Sets";
            this.setsDataGridViewTextBoxColumn.Name = "setsDataGridViewTextBoxColumn";
            // 
            // repetitionsDataGridViewTextBoxColumn
            // 
            this.repetitionsDataGridViewTextBoxColumn.DataPropertyName = "Repetitions";
            this.repetitionsDataGridViewTextBoxColumn.HeaderText = "Repetitions";
            this.repetitionsDataGridViewTextBoxColumn.Name = "repetitionsDataGridViewTextBoxColumn";
            // 
            // stepsDataGridViewTextBoxColumn
            // 
            this.stepsDataGridViewTextBoxColumn.DataPropertyName = "Steps";
            this.stepsDataGridViewTextBoxColumn.HeaderText = "Steps";
            this.stepsDataGridViewTextBoxColumn.Name = "stepsDataGridViewTextBoxColumn";
            // 
            // tEDataGridViewTextBoxColumn
            // 
            this.tEDataGridViewTextBoxColumn.DataPropertyName = "TE";
            this.tEDataGridViewTextBoxColumn.HeaderText = "TE";
            this.tEDataGridViewTextBoxColumn.Name = "tEDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn1
            // 
            this.weightDataGridViewTextBoxColumn1.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn1.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn1.Name = "weightDataGridViewTextBoxColumn1";
            // 
            // hasTimeOfDayDataGridViewCheckBoxColumn
            // 
            this.hasTimeOfDayDataGridViewCheckBoxColumn.DataPropertyName = "HasTimeOfDay";
            this.hasTimeOfDayDataGridViewCheckBoxColumn.HeaderText = "HasTimeOfDay";
            this.hasTimeOfDayDataGridViewCheckBoxColumn.Name = "hasTimeOfDayDataGridViewCheckBoxColumn";
            // 
            // creationDateTimeDataGridViewTextBoxColumn
            // 
            this.creationDateTimeDataGridViewTextBoxColumn.DataPropertyName = "CreationDateTime";
            this.creationDateTimeDataGridViewTextBoxColumn.HeaderText = "CreationDateTime";
            this.creationDateTimeDataGridViewTextBoxColumn.Name = "creationDateTimeDataGridViewTextBoxColumn";
            // 
            // isCompetitionDataGridViewCheckBoxColumn
            // 
            this.isCompetitionDataGridViewCheckBoxColumn.DataPropertyName = "isCompetition";
            this.isCompetitionDataGridViewCheckBoxColumn.HeaderText = "isCompetition";
            this.isCompetitionDataGridViewCheckBoxColumn.Name = "isCompetitionDataGridViewCheckBoxColumn";
            // 
            // raceTitleDataGridViewTextBoxColumn
            // 
            this.raceTitleDataGridViewTextBoxColumn.DataPropertyName = "RaceTitle";
            this.raceTitleDataGridViewTextBoxColumn.HeaderText = "RaceTitle";
            this.raceTitleDataGridViewTextBoxColumn.Name = "raceTitleDataGridViewTextBoxColumn";
            // 
            // routeIDDataGridViewTextBoxColumn
            // 
            this.routeIDDataGridViewTextBoxColumn.DataPropertyName = "RouteID";
            this.routeIDDataGridViewTextBoxColumn.HeaderText = "RouteID";
            this.routeIDDataGridViewTextBoxColumn.Name = "routeIDDataGridViewTextBoxColumn";
            // 
            // trainingTypeIDDataGridViewTextBoxColumn
            // 
            this.trainingTypeIDDataGridViewTextBoxColumn.DataPropertyName = "TrainingTypeID";
            this.trainingTypeIDDataGridViewTextBoxColumn.HeaderText = "TrainingTypeID";
            this.trainingTypeIDDataGridViewTextBoxColumn.Name = "trainingTypeIDDataGridViewTextBoxColumn";
            // 
            // geoRegionIDDataGridViewTextBoxColumn
            // 
            this.geoRegionIDDataGridViewTextBoxColumn.DataPropertyName = "GeoRegionID";
            this.geoRegionIDDataGridViewTextBoxColumn.HeaderText = "GeoRegionID";
            this.geoRegionIDDataGridViewTextBoxColumn.Name = "geoRegionIDDataGridViewTextBoxColumn";
            // 
            // isChangedDataGridViewCheckBoxColumn
            // 
            this.isChangedDataGridViewCheckBoxColumn.DataPropertyName = "IsChanged";
            this.isChangedDataGridViewCheckBoxColumn.HeaderText = "IsChanged";
            this.isChangedDataGridViewCheckBoxColumn.Name = "isChangedDataGridViewCheckBoxColumn";
            // 
            // bndTraining
            // 
            this.bndTraining.DataSource = typeof(MK.Funbeat.Training);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Funbeat Downloader by Markus Kvist";
            this.tabControl1.ResumeLayout(false);
            this.tabDownload.ResumeLayout(false);
            this.tabDownload.PerformLayout();
            this.tabDayNotes.ResumeLayout(false);
            this.tabDayNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDayNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndDayNotes)).EndInit();
            this.tabTrainingRaw.ResumeLayout(false);
            this.tabTrainingRaw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTrainingRawDatas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndTrainingRaw)).EndInit();
            this.tabTraining.ResumeLayout(false);
            this.tabTraining.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTrainings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndTraining)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcessClipboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDownload;
        private System.Windows.Forms.TabPage tabDayNotes;
        private System.Windows.Forms.DataGridView grdDayNotes;
        private System.Windows.Forms.BindingSource bndDayNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restingHeartRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kCalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabTraining;
        private System.Windows.Forms.DataGridView grdTrainings;
        private System.Windows.Forms.BindingSource bndTraining;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgHeartRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabTrainingRaw;
        private System.Windows.Forms.DataGridView grdTrainingRawDatas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource bndTrainingRaw;
        private System.Windows.Forms.Button btnFetchTrainings;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ascentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privateCommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intensityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadAvgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hRAvgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hRMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectAvgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kCalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repetitionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasTimeOfDayDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCompetitionDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geoRegionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isChangedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label6;
    }
}

