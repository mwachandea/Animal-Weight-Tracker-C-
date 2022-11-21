namespace Alexander_Mwachande_ADI
{
    partial class Tracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void 
            Dispose(bool disposing)
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
            System.Windows.Forms.Label lblAnimal;
            System.Windows.Forms.Label lblEditAnim;
            System.Windows.Forms.Label lblModifyMeal;
            System.Windows.Forms.Label lblAddMeal;
            System.Windows.Forms.Label lblModifyExercise;
            System.Windows.Forms.Label lblAddExercise;
            System.Windows.Forms.Label lblEditReading;
            System.Windows.Forms.Label lblAddReading;
            System.Windows.Forms.Label lblTracking;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabAnimal = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.AddAnimal = new MaterialSkin.Controls.MaterialButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAnimalSpecie = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblAnimalName = new System.Windows.Forms.Label();
            this.radAddFemale = new System.Windows.Forms.RadioButton();
            this.radAddMale = new System.Windows.Forms.RadioButton();
            this.txtAddAge = new System.Windows.Forms.TextBox();
            this.txtAddAnimalSpecie = new System.Windows.Forms.TextBox();
            this.txtAddAnimalName = new System.Windows.Forms.TextBox();
            this.btnDeleteAnimal = new MaterialSkin.Controls.MaterialButton();
            this.lblEditAnimal = new MaterialSkin.Controls.MaterialLabel();
            this.btnEditAnimal = new MaterialSkin.Controls.MaterialButton();
            this.lblEditGender = new System.Windows.Forms.Label();
            this.lblEditAnimalSpecie = new System.Windows.Forms.Label();
            this.lblEditAge = new System.Windows.Forms.Label();
            this.lblEditAnimalName = new System.Windows.Forms.Label();
            this.radEditFemale = new System.Windows.Forms.RadioButton();
            this.radEditMale = new System.Windows.Forms.RadioButton();
            this.txtEditAge = new System.Windows.Forms.TextBox();
            this.txtEditAnimalSpecie = new System.Windows.Forms.TextBox();
            this.txtEditAnimalName = new System.Windows.Forms.TextBox();
            this.dataGridViewAnimal = new System.Windows.Forms.DataGridView();
            this.tabMeal = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnAddMeal = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteMeal = new MaterialSkin.Controls.MaterialButton();
            this.btnEditMeal = new MaterialSkin.Controls.MaterialButton();
            this.lblCaloric = new System.Windows.Forms.Label();
            this.lblMeal = new System.Windows.Forms.Label();
            this.txtCaloric = new System.Windows.Forms.TextBox();
            this.txtMeal = new System.Windows.Forms.TextBox();
            this.lblEditMeal = new MaterialSkin.Controls.MaterialLabel();
            this.datePickerMeal = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewMeal1 = new System.Windows.Forms.DataGridView();
            this.btnAddSelectedMeal = new MaterialSkin.Controls.MaterialButton();
            this.lblMealDate = new System.Windows.Forms.Label();
            this.lblGram = new System.Windows.Forms.Label();
            this.txtGram = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewMeal2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewMeal3 = new System.Windows.Forms.DataGridView();
            this.tabExercise = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.btnAddExercise = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteExercise = new MaterialSkin.Controls.MaterialButton();
            this.btnEditExercise = new MaterialSkin.Controls.MaterialButton();
            this.lblCaloricBurn = new System.Windows.Forms.Label();
            this.lblExercise = new System.Windows.Forms.Label();
            this.txtCaloricBurn = new System.Windows.Forms.TextBox();
            this.txtExercise = new System.Windows.Forms.TextBox();
            this.lblEditExercise = new MaterialSkin.Controls.MaterialLabel();
            this.datePickerExercise = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewExercise1 = new System.Windows.Forms.DataGridView();
            this.btnAddSelectedExercise = new MaterialSkin.Controls.MaterialButton();
            this.lblExerciseDate = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewExercise2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewExercise3 = new System.Windows.Forms.DataGridView();
            this.tabReading = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.lblSelectReading = new System.Windows.Forms.Label();
            this.dataGridViewReading1 = new System.Windows.Forms.DataGridView();
            this.cmbActivity = new System.Windows.Forms.ComboBox();
            this.lblDaytime = new System.Windows.Forms.Label();
            this.lblReadingDate = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.datePickerReading = new System.Windows.Forms.DateTimePicker();
            this.lblWaist = new System.Windows.Forms.Label();
            this.txtAddWaist = new System.Windows.Forms.TextBox();
            this.radEvening = new System.Windows.Forms.RadioButton();
            this.radMorning = new System.Windows.Forms.RadioButton();
            this.btnReading = new MaterialSkin.Controls.MaterialButton();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtAddWeight = new System.Windows.Forms.TextBox();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.cmbEditActivity = new System.Windows.Forms.ComboBox();
            this.btnDeleteReading = new MaterialSkin.Controls.MaterialButton();
            this.lblEditWaistMorning = new System.Windows.Forms.Label();
            this.txtEditWaistMorning = new System.Windows.Forms.TextBox();
            this.lblEditWeightMorning = new System.Windows.Forms.Label();
            this.txtEditWeightMorning = new System.Windows.Forms.TextBox();
            this.lblEditReadingDate = new System.Windows.Forms.Label();
            this.lblEditActivity = new System.Windows.Forms.Label();
            this.datePickerEditReading = new System.Windows.Forms.DateTimePicker();
            this.lblEditWaistEvening = new System.Windows.Forms.Label();
            this.txtEditWaistEvening = new System.Windows.Forms.TextBox();
            this.btnEditReading = new MaterialSkin.Controls.MaterialButton();
            this.lblEditWeightEvening = new System.Windows.Forms.Label();
            this.txtEditWeightEvening = new System.Windows.Forms.TextBox();
            this.dataGridViewReading2 = new System.Windows.Forms.DataGridView();
            this.tabTracking = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.datePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblSelectTracking = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridViewTracking1 = new System.Windows.Forms.DataGridView();
            this.datePickerUntilDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnTrackHistory = new MaterialSkin.Controls.MaterialButton();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblChartWeight = new MaterialSkin.Controls.MaterialLabel();
            this.lblAverageWeight = new System.Windows.Forms.Label();
            this.lblChangeWeight = new System.Windows.Forms.Label();
            this.txtAverageWeight = new System.Windows.Forms.TextBox();
            this.txtChangeWeight = new System.Windows.Forms.TextBox();
            this.chartWeight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewTracking2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTracking3 = new System.Windows.Forms.DataGridView();
            lblAnimal = new System.Windows.Forms.Label();
            lblEditAnim = new System.Windows.Forms.Label();
            lblModifyMeal = new System.Windows.Forms.Label();
            lblAddMeal = new System.Windows.Forms.Label();
            lblModifyExercise = new System.Windows.Forms.Label();
            lblAddExercise = new System.Windows.Forms.Label();
            lblEditReading = new System.Windows.Forms.Label();
            lblAddReading = new System.Windows.Forms.Label();
            lblTracking = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.tabAnimal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimal)).BeginInit();
            this.tabMeal.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeal3)).BeginInit();
            this.tabExercise.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercise1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercise2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercise3)).BeginInit();
            this.tabReading.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReading1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReading2)).BeginInit();
            this.tabTracking.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracking1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).BeginInit();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracking2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracking3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnimal
            // 
            lblAnimal.AutoSize = true;
            lblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAnimal.Location = new System.Drawing.Point(148, 9);
            lblAnimal.Name = "lblAnimal";
            lblAnimal.Size = new System.Drawing.Size(108, 24);
            lblAnimal.TabIndex = 9;
            lblAnimal.Text = "Add Animal";
            // 
            // lblEditAnim
            // 
            lblEditAnim.AutoSize = true;
            lblEditAnim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEditAnim.Location = new System.Drawing.Point(188, 9);
            lblEditAnim.Name = "lblEditAnim";
            lblEditAnim.Size = new System.Drawing.Size(105, 24);
            lblEditAnim.TabIndex = 10;
            lblEditAnim.Text = "Edit Animal";
            // 
            // lblModifyMeal
            // 
            lblModifyMeal.AutoSize = true;
            lblModifyMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblModifyMeal.Location = new System.Drawing.Point(118, 7);
            lblModifyMeal.Name = "lblModifyMeal";
            lblModifyMeal.Size = new System.Drawing.Size(111, 24);
            lblModifyMeal.TabIndex = 14;
            lblModifyMeal.Text = "Modify Meal";
            // 
            // lblAddMeal
            // 
            lblAddMeal.AutoSize = true;
            lblAddMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAddMeal.Location = new System.Drawing.Point(274, 7);
            lblAddMeal.Name = "lblAddMeal";
            lblAddMeal.Size = new System.Drawing.Size(91, 24);
            lblAddMeal.TabIndex = 14;
            lblAddMeal.Text = "Add Meal";
            // 
            // lblModifyExercise
            // 
            lblModifyExercise.AutoSize = true;
            lblModifyExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblModifyExercise.Location = new System.Drawing.Point(118, 7);
            lblModifyExercise.Name = "lblModifyExercise";
            lblModifyExercise.Size = new System.Drawing.Size(144, 24);
            lblModifyExercise.TabIndex = 14;
            lblModifyExercise.Text = "Modify Exercise";
            // 
            // lblAddExercise
            // 
            lblAddExercise.AutoSize = true;
            lblAddExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAddExercise.Location = new System.Drawing.Point(253, 7);
            lblAddExercise.Name = "lblAddExercise";
            lblAddExercise.Size = new System.Drawing.Size(124, 24);
            lblAddExercise.TabIndex = 14;
            lblAddExercise.Text = "Add Exercise";
            // 
            // lblEditReading
            // 
            lblEditReading.AutoSize = true;
            lblEditReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEditReading.Location = new System.Drawing.Point(113, 16);
            lblEditReading.Name = "lblEditReading";
            lblEditReading.Size = new System.Drawing.Size(118, 24);
            lblEditReading.TabIndex = 19;
            lblEditReading.Text = "Edit Reading";
            // 
            // lblAddReading
            // 
            lblAddReading.AutoSize = true;
            lblAddReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAddReading.Location = new System.Drawing.Point(210, 11);
            lblAddReading.Name = "lblAddReading";
            lblAddReading.Size = new System.Drawing.Size(121, 24);
            lblAddReading.TabIndex = 22;
            lblAddReading.Text = "Add Reading";
            // 
            // lblTracking
            // 
            lblTracking.AutoSize = true;
            lblTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTracking.Location = new System.Drawing.Point(235, 6);
            lblTracking.Name = "lblTracking";
            lblTracking.Size = new System.Drawing.Size(182, 24);
            lblTracking.TabIndex = 14;
            lblTracking.Text = "Track Animal History";
            // 
            // TabSelector
            // 
            this.TabSelector.BaseTabControl = this.TabControl;
            this.TabSelector.Depth = 0;
            this.TabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TabSelector.Location = new System.Drawing.Point(2, 65);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Size = new System.Drawing.Size(914, 35);
            this.TabSelector.TabIndex = 0;
            this.TabSelector.Text = "materialTabSelector1";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabAnimal);
            this.TabControl.Controls.Add(this.tabMeal);
            this.TabControl.Controls.Add(this.tabExercise);
            this.TabControl.Controls.Add(this.tabReading);
            this.TabControl.Controls.Add(this.tabTracking);
            this.TabControl.Depth = 0;
            this.TabControl.Location = new System.Drawing.Point(4, 99);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(912, 459);
            this.TabControl.TabIndex = 1;
            // 
            // tabAnimal
            // 
            this.tabAnimal.Controls.Add(this.tableLayoutPanel1);
            this.tabAnimal.Location = new System.Drawing.Point(4, 22);
            this.tabAnimal.Name = "tabAnimal";
            this.tabAnimal.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnimal.Size = new System.Drawing.Size(904, 433);
            this.tabAnimal.TabIndex = 0;
            this.tabAnimal.Text = "Animal";
            this.tabAnimal.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewAnimal, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 431);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AddAnimal);
            this.splitContainer1.Panel1.Controls.Add(lblAnimal);
            this.splitContainer1.Panel1.Controls.Add(this.lblGender);
            this.splitContainer1.Panel1.Controls.Add(this.lblAnimalSpecie);
            this.splitContainer1.Panel1.Controls.Add(this.lblAge);
            this.splitContainer1.Panel1.Controls.Add(this.lblAnimalName);
            this.splitContainer1.Panel1.Controls.Add(this.radAddFemale);
            this.splitContainer1.Panel1.Controls.Add(this.radAddMale);
            this.splitContainer1.Panel1.Controls.Add(this.txtAddAge);
            this.splitContainer1.Panel1.Controls.Add(this.txtAddAnimalSpecie);
            this.splitContainer1.Panel1.Controls.Add(this.txtAddAnimalName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnDeleteAnimal);
            this.splitContainer1.Panel2.Controls.Add(this.lblEditAnimal);
            this.splitContainer1.Panel2.Controls.Add(this.btnEditAnimal);
            this.splitContainer1.Panel2.Controls.Add(this.lblEditGender);
            this.splitContainer1.Panel2.Controls.Add(this.lblEditAnimalSpecie);
            this.splitContainer1.Panel2.Controls.Add(this.lblEditAge);
            this.splitContainer1.Panel2.Controls.Add(this.lblEditAnimalName);
            this.splitContainer1.Panel2.Controls.Add(this.radEditFemale);
            this.splitContainer1.Panel2.Controls.Add(this.radEditMale);
            this.splitContainer1.Panel2.Controls.Add(this.txtEditAge);
            this.splitContainer1.Panel2.Controls.Add(this.txtEditAnimalSpecie);
            this.splitContainer1.Panel2.Controls.Add(this.txtEditAnimalName);
            this.splitContainer1.Panel2.Controls.Add(lblEditAnim);
            this.splitContainer1.Size = new System.Drawing.Size(896, 209);
            this.splitContainer1.SplitterDistance = 424;
            this.splitContainer1.TabIndex = 0;
            // 
            // AddAnimal
            // 
            this.AddAnimal.AutoSize = false;
            this.AddAnimal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddAnimal.Depth = 0;
            this.AddAnimal.DrawShadows = true;
            this.AddAnimal.HighEmphasis = true;
            this.AddAnimal.Icon = null;
            this.AddAnimal.Location = new System.Drawing.Point(261, 142);
            this.AddAnimal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddAnimal.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddAnimal.Name = "AddAnimal";
            this.AddAnimal.Size = new System.Drawing.Size(109, 36);
            this.AddAnimal.TabIndex = 10;
            this.AddAnimal.Text = "Add";
            this.AddAnimal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddAnimal.UseAccentColor = false;
            this.AddAnimal.UseVisualStyleBackColor = true;
            this.AddAnimal.Click += new System.EventHandler(this.AddAnimal_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(258, 51);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Gender";
            // 
            // lblAnimalSpecie
            // 
            this.lblAnimalSpecie.AutoSize = true;
            this.lblAnimalSpecie.Location = new System.Drawing.Point(54, 92);
            this.lblAnimalSpecie.Name = "lblAnimalSpecie";
            this.lblAnimalSpecie.Size = new System.Drawing.Size(74, 13);
            this.lblAnimalSpecie.TabIndex = 7;
            this.lblAnimalSpecie.Text = "Animal Specie";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(54, 142);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age";
            // 
            // lblAnimalName
            // 
            this.lblAnimalName.AutoSize = true;
            this.lblAnimalName.Location = new System.Drawing.Point(54, 45);
            this.lblAnimalName.Name = "lblAnimalName";
            this.lblAnimalName.Size = new System.Drawing.Size(35, 13);
            this.lblAnimalName.TabIndex = 5;
            this.lblAnimalName.Text = "Name";
            // 
            // radAddFemale
            // 
            this.radAddFemale.AutoSize = true;
            this.radAddFemale.Location = new System.Drawing.Point(261, 88);
            this.radAddFemale.Name = "radAddFemale";
            this.radAddFemale.Size = new System.Drawing.Size(59, 17);
            this.radAddFemale.TabIndex = 4;
            this.radAddFemale.TabStop = true;
            this.radAddFemale.Text = "Female";
            this.radAddFemale.UseVisualStyleBackColor = true;
            // 
            // radAddMale
            // 
            this.radAddMale.AutoSize = true;
            this.radAddMale.Location = new System.Drawing.Point(261, 67);
            this.radAddMale.Name = "radAddMale";
            this.radAddMale.Size = new System.Drawing.Size(48, 17);
            this.radAddMale.TabIndex = 3;
            this.radAddMale.TabStop = true;
            this.radAddMale.Text = "Male";
            this.radAddMale.UseVisualStyleBackColor = true;
            // 
            // txtAddAge
            // 
            this.txtAddAge.Location = new System.Drawing.Point(52, 158);
            this.txtAddAge.Name = "txtAddAge";
            this.txtAddAge.Size = new System.Drawing.Size(100, 20);
            this.txtAddAge.TabIndex = 2;
            // 
            // txtAddAnimalSpecie
            // 
            this.txtAddAnimalSpecie.Location = new System.Drawing.Point(52, 108);
            this.txtAddAnimalSpecie.Name = "txtAddAnimalSpecie";
            this.txtAddAnimalSpecie.Size = new System.Drawing.Size(100, 20);
            this.txtAddAnimalSpecie.TabIndex = 1;
            // 
            // txtAddAnimalName
            // 
            this.txtAddAnimalName.Location = new System.Drawing.Point(52, 61);
            this.txtAddAnimalName.Name = "txtAddAnimalName";
            this.txtAddAnimalName.Size = new System.Drawing.Size(100, 20);
            this.txtAddAnimalName.TabIndex = 0;
            // 
            // btnDeleteAnimal
            // 
            this.btnDeleteAnimal.AutoSize = false;
            this.btnDeleteAnimal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteAnimal.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAnimal.Depth = 0;
            this.btnDeleteAnimal.DrawShadows = true;
            this.btnDeleteAnimal.HighEmphasis = true;
            this.btnDeleteAnimal.Icon = null;
            this.btnDeleteAnimal.Location = new System.Drawing.Point(320, 142);
            this.btnDeleteAnimal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteAnimal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteAnimal.Name = "btnDeleteAnimal";
            this.btnDeleteAnimal.Size = new System.Drawing.Size(109, 36);
            this.btnDeleteAnimal.TabIndex = 21;
            this.btnDeleteAnimal.Text = "Delete";
            this.btnDeleteAnimal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteAnimal.UseAccentColor = false;
            this.btnDeleteAnimal.UseVisualStyleBackColor = false;
            this.btnDeleteAnimal.Click += new System.EventHandler(this.BtnDeleteAnimal_Click);
            // 
            // lblEditAnimal
            // 
            this.lblEditAnimal.AutoSize = true;
            this.lblEditAnimal.Depth = 0;
            this.lblEditAnimal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEditAnimal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEditAnimal.Location = new System.Drawing.Point(3, 190);
            this.lblEditAnimal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEditAnimal.Name = "lblEditAnimal";
            this.lblEditAnimal.Size = new System.Drawing.Size(222, 19);
            this.lblEditAnimal.TabIndex = 20;
            this.lblEditAnimal.Text = "Select An Animal To Edit Below";
            // 
            // btnEditAnimal
            // 
            this.btnEditAnimal.AutoSize = false;
            this.btnEditAnimal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditAnimal.BackColor = System.Drawing.Color.Transparent;
            this.btnEditAnimal.Depth = 0;
            this.btnEditAnimal.DrawShadows = true;
            this.btnEditAnimal.HighEmphasis = true;
            this.btnEditAnimal.Icon = null;
            this.btnEditAnimal.Location = new System.Drawing.Point(192, 142);
            this.btnEditAnimal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditAnimal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditAnimal.Name = "btnEditAnimal";
            this.btnEditAnimal.Size = new System.Drawing.Size(109, 36);
            this.btnEditAnimal.TabIndex = 11;
            this.btnEditAnimal.Text = "Edit";
            this.btnEditAnimal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditAnimal.UseAccentColor = false;
            this.btnEditAnimal.UseVisualStyleBackColor = false;
            this.btnEditAnimal.Click += new System.EventHandler(this.BtnEditAnimal_Click);
            // 
            // lblEditGender
            // 
            this.lblEditGender.AutoSize = true;
            this.lblEditGender.Location = new System.Drawing.Point(211, 51);
            this.lblEditGender.Name = "lblEditGender";
            this.lblEditGender.Size = new System.Drawing.Size(42, 13);
            this.lblEditGender.TabIndex = 19;
            this.lblEditGender.Text = "Gender";
            // 
            // lblEditAnimalSpecie
            // 
            this.lblEditAnimalSpecie.AutoSize = true;
            this.lblEditAnimalSpecie.Location = new System.Drawing.Point(55, 92);
            this.lblEditAnimalSpecie.Name = "lblEditAnimalSpecie";
            this.lblEditAnimalSpecie.Size = new System.Drawing.Size(74, 13);
            this.lblEditAnimalSpecie.TabIndex = 18;
            this.lblEditAnimalSpecie.Text = "Animal Specie";
            // 
            // lblEditAge
            // 
            this.lblEditAge.AutoSize = true;
            this.lblEditAge.Location = new System.Drawing.Point(55, 142);
            this.lblEditAge.Name = "lblEditAge";
            this.lblEditAge.Size = new System.Drawing.Size(26, 13);
            this.lblEditAge.TabIndex = 17;
            this.lblEditAge.Text = "Age";
            // 
            // lblEditAnimalName
            // 
            this.lblEditAnimalName.AutoSize = true;
            this.lblEditAnimalName.Location = new System.Drawing.Point(55, 45);
            this.lblEditAnimalName.Name = "lblEditAnimalName";
            this.lblEditAnimalName.Size = new System.Drawing.Size(35, 13);
            this.lblEditAnimalName.TabIndex = 16;
            this.lblEditAnimalName.Text = "Name";
            // 
            // radEditFemale
            // 
            this.radEditFemale.AutoSize = true;
            this.radEditFemale.Location = new System.Drawing.Point(214, 88);
            this.radEditFemale.Name = "radEditFemale";
            this.radEditFemale.Size = new System.Drawing.Size(59, 17);
            this.radEditFemale.TabIndex = 15;
            this.radEditFemale.TabStop = true;
            this.radEditFemale.Text = "Female";
            this.radEditFemale.UseVisualStyleBackColor = true;
            // 
            // radEditMale
            // 
            this.radEditMale.AutoSize = true;
            this.radEditMale.Location = new System.Drawing.Point(214, 67);
            this.radEditMale.Name = "radEditMale";
            this.radEditMale.Size = new System.Drawing.Size(48, 17);
            this.radEditMale.TabIndex = 14;
            this.radEditMale.TabStop = true;
            this.radEditMale.Text = "Male";
            this.radEditMale.UseVisualStyleBackColor = true;
            // 
            // txtEditAge
            // 
            this.txtEditAge.Location = new System.Drawing.Point(53, 158);
            this.txtEditAge.Name = "txtEditAge";
            this.txtEditAge.Size = new System.Drawing.Size(100, 20);
            this.txtEditAge.TabIndex = 13;
            // 
            // txtEditAnimalSpecie
            // 
            this.txtEditAnimalSpecie.Location = new System.Drawing.Point(53, 108);
            this.txtEditAnimalSpecie.Name = "txtEditAnimalSpecie";
            this.txtEditAnimalSpecie.Size = new System.Drawing.Size(100, 20);
            this.txtEditAnimalSpecie.TabIndex = 12;
            // 
            // txtEditAnimalName
            // 
            this.txtEditAnimalName.Location = new System.Drawing.Point(53, 61);
            this.txtEditAnimalName.Name = "txtEditAnimalName";
            this.txtEditAnimalName.Size = new System.Drawing.Size(100, 20);
            this.txtEditAnimalName.TabIndex = 11;
            // 
            // dataGridViewAnimal
            // 
            this.dataGridViewAnimal.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimal.Location = new System.Drawing.Point(3, 218);
            this.dataGridViewAnimal.Name = "dataGridViewAnimal";
            this.dataGridViewAnimal.Size = new System.Drawing.Size(894, 205);
            this.dataGridViewAnimal.TabIndex = 1;
            this.dataGridViewAnimal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAnimal_CellClick);
            // 
            // tabMeal
            // 
            this.tabMeal.Controls.Add(this.tableLayoutPanel2);
            this.tabMeal.Location = new System.Drawing.Point(4, 22);
            this.tabMeal.Name = "tabMeal";
            this.tabMeal.Padding = new System.Windows.Forms.Padding(3);
            this.tabMeal.Size = new System.Drawing.Size(904, 433);
            this.tabMeal.TabIndex = 1;
            this.tabMeal.Text = "Meal";
            this.tabMeal.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.splitContainer2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.splitContainer3, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(898, 420);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnAddMeal);
            this.splitContainer2.Panel1.Controls.Add(this.btnDeleteMeal);
            this.splitContainer2.Panel1.Controls.Add(this.btnEditMeal);
            this.splitContainer2.Panel1.Controls.Add(lblModifyMeal);
            this.splitContainer2.Panel1.Controls.Add(this.lblCaloric);
            this.splitContainer2.Panel1.Controls.Add(this.lblMeal);
            this.splitContainer2.Panel1.Controls.Add(this.txtCaloric);
            this.splitContainer2.Panel1.Controls.Add(this.txtMeal);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lblEditMeal);
            this.splitContainer2.Panel2.Controls.Add(this.datePickerMeal);
            this.splitContainer2.Panel2.Controls.Add(this.dataGridViewMeal1);
            this.splitContainer2.Panel2.Controls.Add(this.btnAddSelectedMeal);
            this.splitContainer2.Panel2.Controls.Add(lblAddMeal);
            this.splitContainer2.Panel2.Controls.Add(this.lblMealDate);
            this.splitContainer2.Panel2.Controls.Add(this.lblGram);
            this.splitContainer2.Panel2.Controls.Add(this.txtGram);
            this.splitContainer2.Size = new System.Drawing.Size(892, 204);
            this.splitContainer2.SplitterDistance = 339;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.AutoSize = false;
            this.btnAddMeal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddMeal.Depth = 0;
            this.btnAddMeal.DrawShadows = true;
            this.btnAddMeal.HighEmphasis = true;
            this.btnAddMeal.Icon = null;
            this.btnAddMeal.Location = new System.Drawing.Point(22, 153);
            this.btnAddMeal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddMeal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(109, 36);
            this.btnAddMeal.TabIndex = 17;
            this.btnAddMeal.Text = "Add";
            this.btnAddMeal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddMeal.UseAccentColor = false;
            this.btnAddMeal.UseVisualStyleBackColor = true;
            this.btnAddMeal.Click += new System.EventHandler(this.BtnAddMeal_Click);
            // 
            // btnDeleteMeal
            // 
            this.btnDeleteMeal.AutoSize = false;
            this.btnDeleteMeal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteMeal.Depth = 0;
            this.btnDeleteMeal.DrawShadows = true;
            this.btnDeleteMeal.HighEmphasis = true;
            this.btnDeleteMeal.Icon = null;
            this.btnDeleteMeal.Location = new System.Drawing.Point(204, 153);
            this.btnDeleteMeal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteMeal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteMeal.Name = "btnDeleteMeal";
            this.btnDeleteMeal.Size = new System.Drawing.Size(109, 36);
            this.btnDeleteMeal.TabIndex = 16;
            this.btnDeleteMeal.Text = "Delete";
            this.btnDeleteMeal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteMeal.UseAccentColor = false;
            this.btnDeleteMeal.UseVisualStyleBackColor = true;
            this.btnDeleteMeal.Click += new System.EventHandler(this.BtnDeleteMeal_Click);
            // 
            // btnEditMeal
            // 
            this.btnEditMeal.AutoSize = false;
            this.btnEditMeal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditMeal.Depth = 0;
            this.btnEditMeal.DrawShadows = true;
            this.btnEditMeal.HighEmphasis = true;
            this.btnEditMeal.Icon = null;
            this.btnEditMeal.Location = new System.Drawing.Point(204, 90);
            this.btnEditMeal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditMeal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditMeal.Name = "btnEditMeal";
            this.btnEditMeal.Size = new System.Drawing.Size(109, 36);
            this.btnEditMeal.TabIndex = 15;
            this.btnEditMeal.Text = "Edit";
            this.btnEditMeal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditMeal.UseAccentColor = false;
            this.btnEditMeal.UseVisualStyleBackColor = true;
            this.btnEditMeal.Click += new System.EventHandler(this.BtnEditMeal_Click);
            // 
            // lblCaloric
            // 
            this.lblCaloric.AutoSize = true;
            this.lblCaloric.Location = new System.Drawing.Point(24, 90);
            this.lblCaloric.Name = "lblCaloric";
            this.lblCaloric.Size = new System.Drawing.Size(69, 13);
            this.lblCaloric.TabIndex = 13;
            this.lblCaloric.Text = "Caloric Value";
            // 
            // lblMeal
            // 
            this.lblMeal.AutoSize = true;
            this.lblMeal.Location = new System.Drawing.Point(24, 43);
            this.lblMeal.Name = "lblMeal";
            this.lblMeal.Size = new System.Drawing.Size(35, 13);
            this.lblMeal.TabIndex = 12;
            this.lblMeal.Text = "Name";
            // 
            // txtCaloric
            // 
            this.txtCaloric.Location = new System.Drawing.Point(22, 106);
            this.txtCaloric.Name = "txtCaloric";
            this.txtCaloric.Size = new System.Drawing.Size(109, 20);
            this.txtCaloric.TabIndex = 11;
            // 
            // txtMeal
            // 
            this.txtMeal.Location = new System.Drawing.Point(22, 59);
            this.txtMeal.Name = "txtMeal";
            this.txtMeal.Size = new System.Drawing.Size(164, 20);
            this.txtMeal.TabIndex = 10;
            // 
            // lblEditMeal
            // 
            this.lblEditMeal.AutoSize = true;
            this.lblEditMeal.Depth = 0;
            this.lblEditMeal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEditMeal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEditMeal.Location = new System.Drawing.Point(18, 21);
            this.lblEditMeal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEditMeal.Name = "lblEditMeal";
            this.lblEditMeal.Size = new System.Drawing.Size(151, 19);
            this.lblEditMeal.TabIndex = 18;
            this.lblEditMeal.Text = "Select A Meal To Edit";
            // 
            // datePickerMeal
            // 
            this.datePickerMeal.Location = new System.Drawing.Point(337, 112);
            this.datePickerMeal.Name = "datePickerMeal";
            this.datePickerMeal.Size = new System.Drawing.Size(200, 20);
            this.datePickerMeal.TabIndex = 17;
            // 
            // dataGridViewMeal1
            // 
            this.dataGridViewMeal1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeal1.Location = new System.Drawing.Point(21, 43);
            this.dataGridViewMeal1.Name = "dataGridViewMeal1";
            this.dataGridViewMeal1.Size = new System.Drawing.Size(307, 150);
            this.dataGridViewMeal1.TabIndex = 16;
            this.dataGridViewMeal1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMeal1_CellClick);
            // 
            // btnAddSelectedMeal
            // 
            this.btnAddSelectedMeal.AutoSize = false;
            this.btnAddSelectedMeal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddSelectedMeal.Depth = 0;
            this.btnAddSelectedMeal.DrawShadows = true;
            this.btnAddSelectedMeal.HighEmphasis = true;
            this.btnAddSelectedMeal.Icon = null;
            this.btnAddSelectedMeal.Location = new System.Drawing.Point(335, 153);
            this.btnAddSelectedMeal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddSelectedMeal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddSelectedMeal.Name = "btnAddSelectedMeal";
            this.btnAddSelectedMeal.Size = new System.Drawing.Size(109, 36);
            this.btnAddSelectedMeal.TabIndex = 15;
            this.btnAddSelectedMeal.Text = "Add";
            this.btnAddSelectedMeal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddSelectedMeal.UseAccentColor = false;
            this.btnAddSelectedMeal.UseVisualStyleBackColor = true;
            this.btnAddSelectedMeal.Click += new System.EventHandler(this.BtnAddSelectedMeal_Click);
            // 
            // lblMealDate
            // 
            this.lblMealDate.AutoSize = true;
            this.lblMealDate.Location = new System.Drawing.Point(334, 90);
            this.lblMealDate.Name = "lblMealDate";
            this.lblMealDate.Size = new System.Drawing.Size(63, 13);
            this.lblMealDate.TabIndex = 13;
            this.lblMealDate.Text = "Select Date";
            // 
            // lblGram
            // 
            this.lblGram.AutoSize = true;
            this.lblGram.Location = new System.Drawing.Point(333, 43);
            this.lblGram.Name = "lblGram";
            this.lblGram.Size = new System.Drawing.Size(32, 13);
            this.lblGram.TabIndex = 12;
            this.lblGram.Text = "Gram";
            // 
            // txtGram
            // 
            this.txtGram.Location = new System.Drawing.Point(335, 59);
            this.txtGram.Name = "txtGram";
            this.txtGram.Size = new System.Drawing.Size(100, 20);
            this.txtGram.TabIndex = 10;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 213);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dataGridViewMeal2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridViewMeal3);
            this.splitContainer3.Size = new System.Drawing.Size(892, 204);
            this.splitContainer3.SplitterDistance = 420;
            this.splitContainer3.TabIndex = 1;
            // 
            // dataGridViewMeal2
            // 
            this.dataGridViewMeal2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeal2.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMeal2.Name = "dataGridViewMeal2";
            this.dataGridViewMeal2.Size = new System.Drawing.Size(414, 198);
            this.dataGridViewMeal2.TabIndex = 0;
            this.dataGridViewMeal2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMeal2_CellClick);
            // 
            // dataGridViewMeal3
            // 
            this.dataGridViewMeal3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeal3.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMeal3.Name = "dataGridViewMeal3";
            this.dataGridViewMeal3.Size = new System.Drawing.Size(462, 198);
            this.dataGridViewMeal3.TabIndex = 0;
            this.dataGridViewMeal3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMeal3_CellClick);
            // 
            // tabExercise
            // 
            this.tabExercise.Controls.Add(this.tableLayoutPanel3);
            this.tabExercise.Location = new System.Drawing.Point(4, 22);
            this.tabExercise.Name = "tabExercise";
            this.tabExercise.Size = new System.Drawing.Size(904, 433);
            this.tabExercise.TabIndex = 2;
            this.tabExercise.Text = "Exercise";
            this.tabExercise.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.splitContainer4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.splitContainer5, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(898, 420);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.btnAddExercise);
            this.splitContainer4.Panel1.Controls.Add(this.btnDeleteExercise);
            this.splitContainer4.Panel1.Controls.Add(this.btnEditExercise);
            this.splitContainer4.Panel1.Controls.Add(lblModifyExercise);
            this.splitContainer4.Panel1.Controls.Add(this.lblCaloricBurn);
            this.splitContainer4.Panel1.Controls.Add(this.lblExercise);
            this.splitContainer4.Panel1.Controls.Add(this.txtCaloricBurn);
            this.splitContainer4.Panel1.Controls.Add(this.txtExercise);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.lblEditExercise);
            this.splitContainer4.Panel2.Controls.Add(this.datePickerExercise);
            this.splitContainer4.Panel2.Controls.Add(this.dataGridViewExercise1);
            this.splitContainer4.Panel2.Controls.Add(this.btnAddSelectedExercise);
            this.splitContainer4.Panel2.Controls.Add(lblAddExercise);
            this.splitContainer4.Panel2.Controls.Add(this.lblExerciseDate);
            this.splitContainer4.Panel2.Controls.Add(this.lblMinute);
            this.splitContainer4.Panel2.Controls.Add(this.txtMinute);
            this.splitContainer4.Size = new System.Drawing.Size(892, 204);
            this.splitContainer4.SplitterDistance = 339;
            this.splitContainer4.TabIndex = 0;
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.AutoSize = false;
            this.btnAddExercise.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddExercise.Depth = 0;
            this.btnAddExercise.DrawShadows = true;
            this.btnAddExercise.HighEmphasis = true;
            this.btnAddExercise.Icon = null;
            this.btnAddExercise.Location = new System.Drawing.Point(22, 153);
            this.btnAddExercise.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddExercise.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(109, 36);
            this.btnAddExercise.TabIndex = 17;
            this.btnAddExercise.Text = "Add";
            this.btnAddExercise.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddExercise.UseAccentColor = false;
            this.btnAddExercise.UseVisualStyleBackColor = true;
            this.btnAddExercise.Click += new System.EventHandler(this.BtnAddExercise_Click);
            // 
            // btnDeleteExercise
            // 
            this.btnDeleteExercise.AutoSize = false;
            this.btnDeleteExercise.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteExercise.Depth = 0;
            this.btnDeleteExercise.DrawShadows = true;
            this.btnDeleteExercise.HighEmphasis = true;
            this.btnDeleteExercise.Icon = null;
            this.btnDeleteExercise.Location = new System.Drawing.Point(204, 153);
            this.btnDeleteExercise.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteExercise.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteExercise.Name = "btnDeleteExercise";
            this.btnDeleteExercise.Size = new System.Drawing.Size(109, 36);
            this.btnDeleteExercise.TabIndex = 16;
            this.btnDeleteExercise.Text = "Delete";
            this.btnDeleteExercise.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteExercise.UseAccentColor = false;
            this.btnDeleteExercise.UseVisualStyleBackColor = true;
            this.btnDeleteExercise.Click += new System.EventHandler(this.BtnDeleteExercise_Click);
            // 
            // btnEditExercise
            // 
            this.btnEditExercise.AutoSize = false;
            this.btnEditExercise.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditExercise.Depth = 0;
            this.btnEditExercise.DrawShadows = true;
            this.btnEditExercise.HighEmphasis = true;
            this.btnEditExercise.Icon = null;
            this.btnEditExercise.Location = new System.Drawing.Point(204, 90);
            this.btnEditExercise.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditExercise.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditExercise.Name = "btnEditExercise";
            this.btnEditExercise.Size = new System.Drawing.Size(109, 36);
            this.btnEditExercise.TabIndex = 15;
            this.btnEditExercise.Text = "Edit";
            this.btnEditExercise.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditExercise.UseAccentColor = false;
            this.btnEditExercise.UseVisualStyleBackColor = true;
            this.btnEditExercise.Click += new System.EventHandler(this.BtnEditExercise_Click);
            // 
            // lblCaloricBurn
            // 
            this.lblCaloricBurn.AutoSize = true;
            this.lblCaloricBurn.Location = new System.Drawing.Point(24, 90);
            this.lblCaloricBurn.Name = "lblCaloricBurn";
            this.lblCaloricBurn.Size = new System.Drawing.Size(64, 13);
            this.lblCaloricBurn.TabIndex = 13;
            this.lblCaloricBurn.Text = "Caloric Burn";
            // 
            // lblExercise
            // 
            this.lblExercise.AutoSize = true;
            this.lblExercise.Location = new System.Drawing.Point(24, 43);
            this.lblExercise.Name = "lblExercise";
            this.lblExercise.Size = new System.Drawing.Size(35, 13);
            this.lblExercise.TabIndex = 12;
            this.lblExercise.Text = "Name";
            // 
            // txtCaloricBurn
            // 
            this.txtCaloricBurn.Location = new System.Drawing.Point(22, 106);
            this.txtCaloricBurn.Name = "txtCaloricBurn";
            this.txtCaloricBurn.Size = new System.Drawing.Size(109, 20);
            this.txtCaloricBurn.TabIndex = 11;
            // 
            // txtExercise
            // 
            this.txtExercise.Location = new System.Drawing.Point(22, 59);
            this.txtExercise.Name = "txtExercise";
            this.txtExercise.Size = new System.Drawing.Size(164, 20);
            this.txtExercise.TabIndex = 10;
            // 
            // lblEditExercise
            // 
            this.lblEditExercise.AutoSize = true;
            this.lblEditExercise.Depth = 0;
            this.lblEditExercise.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEditExercise.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEditExercise.Location = new System.Drawing.Point(18, 21);
            this.lblEditExercise.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEditExercise.Name = "lblEditExercise";
            this.lblEditExercise.Size = new System.Drawing.Size(174, 19);
            this.lblEditExercise.TabIndex = 18;
            this.lblEditExercise.Text = "Select A Exercise To Edit";
            // 
            // datePickerExercise
            // 
            this.datePickerExercise.Location = new System.Drawing.Point(337, 112);
            this.datePickerExercise.Name = "datePickerExercise";
            this.datePickerExercise.Size = new System.Drawing.Size(200, 20);
            this.datePickerExercise.TabIndex = 17;
            // 
            // dataGridViewExercise1
            // 
            this.dataGridViewExercise1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExercise1.Location = new System.Drawing.Point(21, 43);
            this.dataGridViewExercise1.Name = "dataGridViewExercise1";
            this.dataGridViewExercise1.Size = new System.Drawing.Size(307, 150);
            this.dataGridViewExercise1.TabIndex = 16;
            this.dataGridViewExercise1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewExercise1_CellClick);
            // 
            // btnAddSelectedExercise
            // 
            this.btnAddSelectedExercise.AutoSize = false;
            this.btnAddSelectedExercise.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddSelectedExercise.Depth = 0;
            this.btnAddSelectedExercise.DrawShadows = true;
            this.btnAddSelectedExercise.HighEmphasis = true;
            this.btnAddSelectedExercise.Icon = null;
            this.btnAddSelectedExercise.Location = new System.Drawing.Point(335, 153);
            this.btnAddSelectedExercise.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddSelectedExercise.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddSelectedExercise.Name = "btnAddSelectedExercise";
            this.btnAddSelectedExercise.Size = new System.Drawing.Size(109, 36);
            this.btnAddSelectedExercise.TabIndex = 15;
            this.btnAddSelectedExercise.Text = "Add";
            this.btnAddSelectedExercise.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddSelectedExercise.UseAccentColor = false;
            this.btnAddSelectedExercise.UseVisualStyleBackColor = true;
            this.btnAddSelectedExercise.Click += new System.EventHandler(this.BtnAddSelectedExercise_Click);
            // 
            // lblExerciseDate
            // 
            this.lblExerciseDate.AutoSize = true;
            this.lblExerciseDate.Location = new System.Drawing.Point(334, 90);
            this.lblExerciseDate.Name = "lblExerciseDate";
            this.lblExerciseDate.Size = new System.Drawing.Size(63, 13);
            this.lblExerciseDate.TabIndex = 13;
            this.lblExerciseDate.Text = "Select Date";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(333, 43);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(44, 13);
            this.lblMinute.TabIndex = 12;
            this.lblMinute.Text = "Minutes";
            // 
            // txtMinute
            // 
            this.txtMinute.Location = new System.Drawing.Point(335, 59);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(100, 20);
            this.txtMinute.TabIndex = 10;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 213);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.dataGridViewExercise2);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.dataGridViewExercise3);
            this.splitContainer5.Size = new System.Drawing.Size(892, 204);
            this.splitContainer5.SplitterDistance = 420;
            this.splitContainer5.TabIndex = 1;
            // 
            // dataGridViewExercise2
            // 
            this.dataGridViewExercise2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExercise2.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewExercise2.Name = "dataGridViewExercise2";
            this.dataGridViewExercise2.Size = new System.Drawing.Size(414, 198);
            this.dataGridViewExercise2.TabIndex = 0;
            this.dataGridViewExercise2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewExercise2_CellClick);
            // 
            // dataGridViewExercise3
            // 
            this.dataGridViewExercise3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExercise3.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewExercise3.Name = "dataGridViewExercise3";
            this.dataGridViewExercise3.Size = new System.Drawing.Size(462, 198);
            this.dataGridViewExercise3.TabIndex = 0;
            this.dataGridViewExercise3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewExercise3_CellClick);
            // 
            // tabReading
            // 
            this.tabReading.Controls.Add(this.tableLayoutPanel4);
            this.tabReading.Location = new System.Drawing.Point(4, 22);
            this.tabReading.Name = "tabReading";
            this.tabReading.Size = new System.Drawing.Size(904, 433);
            this.tabReading.TabIndex = 3;
            this.tabReading.Text = "Reading";
            this.tabReading.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.splitContainer6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.splitContainer7, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(898, 420);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(3, 3);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.lblSelectReading);
            this.splitContainer6.Panel1.Controls.Add(this.dataGridViewReading1);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.cmbActivity);
            this.splitContainer6.Panel2.Controls.Add(this.lblDaytime);
            this.splitContainer6.Panel2.Controls.Add(this.lblReadingDate);
            this.splitContainer6.Panel2.Controls.Add(this.lblActivity);
            this.splitContainer6.Panel2.Controls.Add(this.datePickerReading);
            this.splitContainer6.Panel2.Controls.Add(this.lblWaist);
            this.splitContainer6.Panel2.Controls.Add(this.txtAddWaist);
            this.splitContainer6.Panel2.Controls.Add(this.radEvening);
            this.splitContainer6.Panel2.Controls.Add(this.radMorning);
            this.splitContainer6.Panel2.Controls.Add(this.btnReading);
            this.splitContainer6.Panel2.Controls.Add(lblAddReading);
            this.splitContainer6.Panel2.Controls.Add(this.lblWeight);
            this.splitContainer6.Panel2.Controls.Add(this.txtAddWeight);
            this.splitContainer6.Size = new System.Drawing.Size(892, 204);
            this.splitContainer6.SplitterDistance = 420;
            this.splitContainer6.TabIndex = 0;
            // 
            // lblSelectReading
            // 
            this.lblSelectReading.AutoSize = true;
            this.lblSelectReading.Location = new System.Drawing.Point(3, 3);
            this.lblSelectReading.Name = "lblSelectReading";
            this.lblSelectReading.Size = new System.Drawing.Size(71, 13);
            this.lblSelectReading.TabIndex = 2;
            this.lblSelectReading.Text = "Select Animal";
            // 
            // dataGridViewReading1
            // 
            this.dataGridViewReading1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReading1.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewReading1.Name = "dataGridViewReading1";
            this.dataGridViewReading1.Size = new System.Drawing.Size(414, 198);
            this.dataGridViewReading1.TabIndex = 1;
            this.dataGridViewReading1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewReading1_CellClick);
            // 
            // cmbActivity
            // 
            this.cmbActivity.FormattingEnabled = true;
            this.cmbActivity.Items.AddRange(new object[] {
            "Light",
            "Moderate",
            "Heavy"});
            this.cmbActivity.Location = new System.Drawing.Point(168, 107);
            this.cmbActivity.Name = "cmbActivity";
            this.cmbActivity.Size = new System.Drawing.Size(100, 21);
            this.cmbActivity.TabIndex = 32;
            // 
            // lblDaytime
            // 
            this.lblDaytime.AutoSize = true;
            this.lblDaytime.Location = new System.Drawing.Point(13, 45);
            this.lblDaytime.Name = "lblDaytime";
            this.lblDaytime.Size = new System.Drawing.Size(64, 13);
            this.lblDaytime.TabIndex = 31;
            this.lblDaytime.Text = "Time of Day";
            // 
            // lblReadingDate
            // 
            this.lblReadingDate.AutoSize = true;
            this.lblReadingDate.Location = new System.Drawing.Point(309, 92);
            this.lblReadingDate.Name = "lblReadingDate";
            this.lblReadingDate.Size = new System.Drawing.Size(63, 13);
            this.lblReadingDate.TabIndex = 30;
            this.lblReadingDate.Text = "Select Date";
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Location = new System.Drawing.Point(165, 92);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(41, 13);
            this.lblActivity.TabIndex = 29;
            this.lblActivity.Text = "Activity";
            // 
            // datePickerReading
            // 
            this.datePickerReading.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerReading.Location = new System.Drawing.Point(312, 108);
            this.datePickerReading.Name = "datePickerReading";
            this.datePickerReading.Size = new System.Drawing.Size(109, 20);
            this.datePickerReading.TabIndex = 28;
            // 
            // lblWaist
            // 
            this.lblWaist.AutoSize = true;
            this.lblWaist.Location = new System.Drawing.Point(314, 45);
            this.lblWaist.Name = "lblWaist";
            this.lblWaist.Size = new System.Drawing.Size(34, 13);
            this.lblWaist.TabIndex = 27;
            this.lblWaist.Text = "Waist";
            // 
            // txtAddWaist
            // 
            this.txtAddWaist.Location = new System.Drawing.Point(312, 61);
            this.txtAddWaist.Name = "txtAddWaist";
            this.txtAddWaist.Size = new System.Drawing.Size(109, 20);
            this.txtAddWaist.TabIndex = 26;
            // 
            // radEvening
            // 
            this.radEvening.AutoSize = true;
            this.radEvening.Location = new System.Drawing.Point(16, 111);
            this.radEvening.Name = "radEvening";
            this.radEvening.Size = new System.Drawing.Size(64, 17);
            this.radEvening.TabIndex = 25;
            this.radEvening.TabStop = true;
            this.radEvening.Text = "Evening";
            this.radEvening.UseVisualStyleBackColor = true;
            // 
            // radMorning
            // 
            this.radMorning.AutoSize = true;
            this.radMorning.Location = new System.Drawing.Point(16, 75);
            this.radMorning.Name = "radMorning";
            this.radMorning.Size = new System.Drawing.Size(63, 17);
            this.radMorning.TabIndex = 24;
            this.radMorning.TabStop = true;
            this.radMorning.Text = "Morning";
            this.radMorning.UseVisualStyleBackColor = true;
            this.radMorning.CheckedChanged += new System.EventHandler(this.RadMorning_CheckedChanged);
            // 
            // btnReading
            // 
            this.btnReading.AutoSize = false;
            this.btnReading.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReading.Depth = 0;
            this.btnReading.DrawShadows = true;
            this.btnReading.HighEmphasis = true;
            this.btnReading.Icon = null;
            this.btnReading.Location = new System.Drawing.Point(245, 137);
            this.btnReading.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReading.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReading.Name = "btnReading";
            this.btnReading.Size = new System.Drawing.Size(109, 36);
            this.btnReading.TabIndex = 23;
            this.btnReading.Text = "Add";
            this.btnReading.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReading.UseAccentColor = false;
            this.btnReading.UseVisualStyleBackColor = true;
            this.btnReading.Click += new System.EventHandler(this.BtnReading_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(165, 45);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 21;
            this.lblWeight.Text = "Weight";
            // 
            // txtAddWeight
            // 
            this.txtAddWeight.Location = new System.Drawing.Point(168, 61);
            this.txtAddWeight.Name = "txtAddWeight";
            this.txtAddWeight.Size = new System.Drawing.Size(100, 20);
            this.txtAddWeight.TabIndex = 19;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(3, 213);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.cmbEditActivity);
            this.splitContainer7.Panel1.Controls.Add(this.btnDeleteReading);
            this.splitContainer7.Panel1.Controls.Add(this.lblEditWaistMorning);
            this.splitContainer7.Panel1.Controls.Add(this.txtEditWaistMorning);
            this.splitContainer7.Panel1.Controls.Add(this.lblEditWeightMorning);
            this.splitContainer7.Panel1.Controls.Add(this.txtEditWeightMorning);
            this.splitContainer7.Panel1.Controls.Add(this.lblEditReadingDate);
            this.splitContainer7.Panel1.Controls.Add(this.lblEditActivity);
            this.splitContainer7.Panel1.Controls.Add(this.datePickerEditReading);
            this.splitContainer7.Panel1.Controls.Add(this.lblEditWaistEvening);
            this.splitContainer7.Panel1.Controls.Add(this.txtEditWaistEvening);
            this.splitContainer7.Panel1.Controls.Add(this.btnEditReading);
            this.splitContainer7.Panel1.Controls.Add(this.lblEditWeightEvening);
            this.splitContainer7.Panel1.Controls.Add(this.txtEditWeightEvening);
            this.splitContainer7.Panel1.Controls.Add(lblEditReading);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.dataGridViewReading2);
            this.splitContainer7.Size = new System.Drawing.Size(892, 204);
            this.splitContainer7.SplitterDistance = 420;
            this.splitContainer7.TabIndex = 1;
            // 
            // cmbEditActivity
            // 
            this.cmbEditActivity.FormattingEnabled = true;
            this.cmbEditActivity.Items.AddRange(new object[] {
            "Light",
            "Moderate",
            "Heavy"});
            this.cmbEditActivity.Location = new System.Drawing.Point(17, 171);
            this.cmbEditActivity.Name = "cmbEditActivity";
            this.cmbEditActivity.Size = new System.Drawing.Size(100, 21);
            this.cmbEditActivity.TabIndex = 45;
            // 
            // btnDeleteReading
            // 
            this.btnDeleteReading.AutoSize = false;
            this.btnDeleteReading.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteReading.Depth = 0;
            this.btnDeleteReading.DrawShadows = true;
            this.btnDeleteReading.HighEmphasis = true;
            this.btnDeleteReading.Icon = null;
            this.btnDeleteReading.Location = new System.Drawing.Point(294, 144);
            this.btnDeleteReading.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteReading.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteReading.Name = "btnDeleteReading";
            this.btnDeleteReading.Size = new System.Drawing.Size(109, 36);
            this.btnDeleteReading.TabIndex = 44;
            this.btnDeleteReading.Text = "Delete";
            this.btnDeleteReading.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteReading.UseAccentColor = false;
            this.btnDeleteReading.UseVisualStyleBackColor = true;
            this.btnDeleteReading.Click += new System.EventHandler(this.BtnDeleteReading_Click);
            // 
            // lblEditWaistMorning
            // 
            this.lblEditWaistMorning.AutoSize = true;
            this.lblEditWaistMorning.Location = new System.Drawing.Point(163, 57);
            this.lblEditWaistMorning.Name = "lblEditWaistMorning";
            this.lblEditWaistMorning.Size = new System.Drawing.Size(75, 13);
            this.lblEditWaistMorning.TabIndex = 43;
            this.lblEditWaistMorning.Text = "Morning Waist";
            // 
            // txtEditWaistMorning
            // 
            this.txtEditWaistMorning.Location = new System.Drawing.Point(161, 73);
            this.txtEditWaistMorning.Name = "txtEditWaistMorning";
            this.txtEditWaistMorning.Size = new System.Drawing.Size(109, 20);
            this.txtEditWaistMorning.TabIndex = 42;
            // 
            // lblEditWeightMorning
            // 
            this.lblEditWeightMorning.AutoSize = true;
            this.lblEditWeightMorning.Location = new System.Drawing.Point(14, 57);
            this.lblEditWeightMorning.Name = "lblEditWeightMorning";
            this.lblEditWeightMorning.Size = new System.Drawing.Size(82, 13);
            this.lblEditWeightMorning.TabIndex = 41;
            this.lblEditWeightMorning.Text = "Morning Weight";
            // 
            // txtEditWeightMorning
            // 
            this.txtEditWeightMorning.Location = new System.Drawing.Point(17, 73);
            this.txtEditWeightMorning.Name = "txtEditWeightMorning";
            this.txtEditWeightMorning.Size = new System.Drawing.Size(100, 20);
            this.txtEditWeightMorning.TabIndex = 40;
            // 
            // lblEditReadingDate
            // 
            this.lblEditReadingDate.AutoSize = true;
            this.lblEditReadingDate.Location = new System.Drawing.Point(158, 156);
            this.lblEditReadingDate.Name = "lblEditReadingDate";
            this.lblEditReadingDate.Size = new System.Drawing.Size(70, 13);
            this.lblEditReadingDate.TabIndex = 39;
            this.lblEditReadingDate.Text = "Change Date";
            // 
            // lblEditActivity
            // 
            this.lblEditActivity.AutoSize = true;
            this.lblEditActivity.Location = new System.Drawing.Point(14, 156);
            this.lblEditActivity.Name = "lblEditActivity";
            this.lblEditActivity.Size = new System.Drawing.Size(41, 13);
            this.lblEditActivity.TabIndex = 38;
            this.lblEditActivity.Text = "Activity";
            // 
            // datePickerEditReading
            // 
            this.datePickerEditReading.Enabled = false;
            this.datePickerEditReading.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerEditReading.Location = new System.Drawing.Point(161, 172);
            this.datePickerEditReading.Name = "datePickerEditReading";
            this.datePickerEditReading.Size = new System.Drawing.Size(109, 20);
            this.datePickerEditReading.TabIndex = 37;
            // 
            // lblEditWaistEvening
            // 
            this.lblEditWaistEvening.AutoSize = true;
            this.lblEditWaistEvening.Location = new System.Drawing.Point(163, 109);
            this.lblEditWaistEvening.Name = "lblEditWaistEvening";
            this.lblEditWaistEvening.Size = new System.Drawing.Size(76, 13);
            this.lblEditWaistEvening.TabIndex = 36;
            this.lblEditWaistEvening.Text = "Evening Waist";
            // 
            // txtEditWaistEvening
            // 
            this.txtEditWaistEvening.Location = new System.Drawing.Point(161, 125);
            this.txtEditWaistEvening.Name = "txtEditWaistEvening";
            this.txtEditWaistEvening.Size = new System.Drawing.Size(109, 20);
            this.txtEditWaistEvening.TabIndex = 35;
            // 
            // btnEditReading
            // 
            this.btnEditReading.AutoSize = false;
            this.btnEditReading.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditReading.Depth = 0;
            this.btnEditReading.DrawShadows = true;
            this.btnEditReading.HighEmphasis = true;
            this.btnEditReading.Icon = null;
            this.btnEditReading.Location = new System.Drawing.Point(294, 86);
            this.btnEditReading.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditReading.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditReading.Name = "btnEditReading";
            this.btnEditReading.Size = new System.Drawing.Size(109, 36);
            this.btnEditReading.TabIndex = 34;
            this.btnEditReading.Text = "Edit";
            this.btnEditReading.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditReading.UseAccentColor = false;
            this.btnEditReading.UseVisualStyleBackColor = true;
            this.btnEditReading.Click += new System.EventHandler(this.BtnEditReading_Click);
            // 
            // lblEditWeightEvening
            // 
            this.lblEditWeightEvening.AutoSize = true;
            this.lblEditWeightEvening.Location = new System.Drawing.Point(14, 109);
            this.lblEditWeightEvening.Name = "lblEditWeightEvening";
            this.lblEditWeightEvening.Size = new System.Drawing.Size(83, 13);
            this.lblEditWeightEvening.TabIndex = 33;
            this.lblEditWeightEvening.Text = "Evening Weight";
            // 
            // txtEditWeightEvening
            // 
            this.txtEditWeightEvening.Location = new System.Drawing.Point(17, 125);
            this.txtEditWeightEvening.Name = "txtEditWeightEvening";
            this.txtEditWeightEvening.Size = new System.Drawing.Size(100, 20);
            this.txtEditWeightEvening.TabIndex = 32;
            // 
            // dataGridViewReading2
            // 
            this.dataGridViewReading2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReading2.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewReading2.Name = "dataGridViewReading2";
            this.dataGridViewReading2.Size = new System.Drawing.Size(462, 198);
            this.dataGridViewReading2.TabIndex = 0;
            this.dataGridViewReading2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewReading2_CellClick);
            // 
            // tabTracking
            // 
            this.tabTracking.Controls.Add(this.tableLayoutPanel5);
            this.tabTracking.Location = new System.Drawing.Point(4, 22);
            this.tabTracking.Name = "tabTracking";
            this.tabTracking.Size = new System.Drawing.Size(904, 433);
            this.tabTracking.TabIndex = 4;
            this.tabTracking.Text = "Tracking";
            this.tabTracking.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.splitContainer8, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.splitContainer9, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(898, 420);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(3, 3);
            this.splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.datePickerStartDate);
            this.splitContainer8.Panel1.Controls.Add(this.lblSelectTracking);
            this.splitContainer8.Panel1.Controls.Add(this.dataGridViewTracking1);
            this.splitContainer8.Panel1.Controls.Add(this.datePickerUntilDate);
            this.splitContainer8.Panel1.Controls.Add(this.lblStartDate);
            this.splitContainer8.Panel1.Controls.Add(this.btnTrackHistory);
            this.splitContainer8.Panel1.Controls.Add(this.lblEndDate);
            this.splitContainer8.Panel1.Controls.Add(lblTracking);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.lblChartWeight);
            this.splitContainer8.Panel2.Controls.Add(this.lblAverageWeight);
            this.splitContainer8.Panel2.Controls.Add(this.lblChangeWeight);
            this.splitContainer8.Panel2.Controls.Add(this.txtAverageWeight);
            this.splitContainer8.Panel2.Controls.Add(this.txtChangeWeight);
            this.splitContainer8.Panel2.Controls.Add(this.chartWeight);
            this.splitContainer8.Size = new System.Drawing.Size(892, 204);
            this.splitContainer8.SplitterDistance = 524;
            this.splitContainer8.TabIndex = 0;
            // 
            // datePickerStartDate
            // 
            this.datePickerStartDate.Location = new System.Drawing.Point(319, 58);
            this.datePickerStartDate.Name = "datePickerStartDate";
            this.datePickerStartDate.Size = new System.Drawing.Size(197, 20);
            this.datePickerStartDate.TabIndex = 19;
            // 
            // lblSelectTracking
            // 
            this.lblSelectTracking.AutoSize = true;
            this.lblSelectTracking.Depth = 0;
            this.lblSelectTracking.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSelectTracking.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSelectTracking.Location = new System.Drawing.Point(0, 20);
            this.lblSelectTracking.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSelectTracking.Name = "lblSelectTracking";
            this.lblSelectTracking.Size = new System.Drawing.Size(165, 19);
            this.lblSelectTracking.TabIndex = 18;
            this.lblSelectTracking.Text = "Select Animal To Track";
            // 
            // dataGridViewTracking1
            // 
            this.dataGridViewTracking1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTracking1.Location = new System.Drawing.Point(3, 42);
            this.dataGridViewTracking1.Name = "dataGridViewTracking1";
            this.dataGridViewTracking1.Size = new System.Drawing.Size(307, 150);
            this.dataGridViewTracking1.TabIndex = 16;
            this.dataGridViewTracking1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTracking1_CellClick);
            // 
            // datePickerUntilDate
            // 
            this.datePickerUntilDate.Location = new System.Drawing.Point(319, 111);
            this.datePickerUntilDate.Name = "datePickerUntilDate";
            this.datePickerUntilDate.Size = new System.Drawing.Size(200, 20);
            this.datePickerUntilDate.TabIndex = 17;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(315, 42);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 12;
            this.lblStartDate.Text = "Start Date";
            // 
            // btnTrackHistory
            // 
            this.btnTrackHistory.AutoSize = false;
            this.btnTrackHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTrackHistory.Depth = 0;
            this.btnTrackHistory.DrawShadows = true;
            this.btnTrackHistory.HighEmphasis = true;
            this.btnTrackHistory.Icon = null;
            this.btnTrackHistory.Location = new System.Drawing.Point(339, 156);
            this.btnTrackHistory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTrackHistory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTrackHistory.Name = "btnTrackHistory";
            this.btnTrackHistory.Size = new System.Drawing.Size(149, 36);
            this.btnTrackHistory.TabIndex = 15;
            this.btnTrackHistory.Text = "Track History";
            this.btnTrackHistory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTrackHistory.UseAccentColor = false;
            this.btnTrackHistory.UseVisualStyleBackColor = true;
            this.btnTrackHistory.Click += new System.EventHandler(this.BtnTrackHistory_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(316, 89);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 13;
            this.lblEndDate.Text = "End Date";
            // 
            // lblChartWeight
            // 
            this.lblChartWeight.AutoSize = true;
            this.lblChartWeight.Depth = 0;
            this.lblChartWeight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblChartWeight.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblChartWeight.Location = new System.Drawing.Point(3, 6);
            this.lblChartWeight.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblChartWeight.Name = "lblChartWeight";
            this.lblChartWeight.Size = new System.Drawing.Size(92, 19);
            this.lblChartWeight.TabIndex = 15;
            this.lblChartWeight.Text = "Weight Chart";
            // 
            // lblAverageWeight
            // 
            this.lblAverageWeight.AutoSize = true;
            this.lblAverageWeight.Location = new System.Drawing.Point(258, 70);
            this.lblAverageWeight.Name = "lblAverageWeight";
            this.lblAverageWeight.Size = new System.Drawing.Size(84, 13);
            this.lblAverageWeight.TabIndex = 14;
            this.lblAverageWeight.Text = "Average Weight";
            // 
            // lblChangeWeight
            // 
            this.lblChangeWeight.AutoSize = true;
            this.lblChangeWeight.Location = new System.Drawing.Point(258, 136);
            this.lblChangeWeight.Name = "lblChangeWeight";
            this.lblChangeWeight.Size = new System.Drawing.Size(81, 13);
            this.lblChangeWeight.TabIndex = 13;
            this.lblChangeWeight.Text = "Weight Change";
            // 
            // txtAverageWeight
            // 
            this.txtAverageWeight.Location = new System.Drawing.Point(261, 86);
            this.txtAverageWeight.Name = "txtAverageWeight";
            this.txtAverageWeight.Size = new System.Drawing.Size(100, 20);
            this.txtAverageWeight.TabIndex = 2;
            // 
            // txtChangeWeight
            // 
            this.txtChangeWeight.Location = new System.Drawing.Point(261, 152);
            this.txtChangeWeight.Name = "txtChangeWeight";
            this.txtChangeWeight.Size = new System.Drawing.Size(100, 20);
            this.txtChangeWeight.TabIndex = 1;
            // 
            // chartWeight
            // 
            chartArea1.Name = "ChartArea1";
            this.chartWeight.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartWeight.Legends.Add(legend1);
            this.chartWeight.Location = new System.Drawing.Point(3, 22);
            this.chartWeight.Name = "chartWeight";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Weight";
            this.chartWeight.Series.Add(series1);
            this.chartWeight.Size = new System.Drawing.Size(252, 170);
            this.chartWeight.TabIndex = 0;
            this.chartWeight.Text = "WeightChart";
            // 
            // splitContainer9
            // 
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.Location = new System.Drawing.Point(3, 213);
            this.splitContainer9.Name = "splitContainer9";
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.Controls.Add(this.dataGridViewTracking2);
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.dataGridViewTracking3);
            this.splitContainer9.Size = new System.Drawing.Size(892, 204);
            this.splitContainer9.SplitterDistance = 420;
            this.splitContainer9.TabIndex = 1;
            // 
            // dataGridViewTracking2
            // 
            this.dataGridViewTracking2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTracking2.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTracking2.Name = "dataGridViewTracking2";
            this.dataGridViewTracking2.Size = new System.Drawing.Size(414, 198);
            this.dataGridViewTracking2.TabIndex = 0;
            // 
            // dataGridViewTracking3
            // 
            this.dataGridViewTracking3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTracking3.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTracking3.Name = "dataGridViewTracking3";
            this.dataGridViewTracking3.Size = new System.Drawing.Size(462, 198);
            this.dataGridViewTracking3.TabIndex = 0;
            // 
            // Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(916, 559);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.TabSelector);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Tracker";
            this.Text = "Animal Weight Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.tabAnimal.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimal)).EndInit();
            this.tabMeal.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeal1)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeal3)).EndInit();
            this.tabExercise.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercise1)).EndInit();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercise2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercise3)).EndInit();
            this.tabReading.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReading1)).EndInit();
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReading2)).EndInit();
            this.tabTracking.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel1.PerformLayout();
            this.splitContainer8.Panel2.ResumeLayout(false);
            this.splitContainer8.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracking1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeight)).EndInit();
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).EndInit();
            this.splitContainer9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracking2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracking3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage tabAnimal;
        private System.Windows.Forms.TabPage tabMeal;
        private System.Windows.Forms.TabPage tabExercise;
        private System.Windows.Forms.TabPage tabReading;
        private System.Windows.Forms.TabPage tabTracking;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewAnimal;
        private MaterialSkin.Controls.MaterialButton AddAnimal;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAnimalSpecie;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblAnimalName;
        private System.Windows.Forms.RadioButton radAddFemale;
        private System.Windows.Forms.RadioButton radAddMale;
        private System.Windows.Forms.TextBox txtAddAge;
        private System.Windows.Forms.TextBox txtAddAnimalSpecie;
        private System.Windows.Forms.TextBox txtAddAnimalName;
        private MaterialSkin.Controls.MaterialButton btnEditAnimal;
        private System.Windows.Forms.Label lblEditGender;
        private System.Windows.Forms.Label lblEditAnimalSpecie;
        private System.Windows.Forms.Label lblEditAge;
        private System.Windows.Forms.Label lblEditAnimalName;
        private System.Windows.Forms.RadioButton radEditFemale;
        private System.Windows.Forms.RadioButton radEditMale;
        private System.Windows.Forms.TextBox txtEditAge;
        private System.Windows.Forms.TextBox txtEditAnimalSpecie;
        private System.Windows.Forms.TextBox txtEditAnimalName;
        private MaterialSkin.Controls.MaterialLabel lblEditAnimal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private MaterialSkin.Controls.MaterialButton btnEditMeal;
        private System.Windows.Forms.Label lblCaloric;
        private System.Windows.Forms.Label lblMeal;
        private System.Windows.Forms.TextBox txtCaloric;
        private System.Windows.Forms.TextBox txtMeal;
        private MaterialSkin.Controls.MaterialButton btnAddSelectedMeal;
        private System.Windows.Forms.Label lblMealDate;
        private System.Windows.Forms.Label lblGram;
        private System.Windows.Forms.TextBox txtGram;
        private System.Windows.Forms.DataGridView dataGridViewMeal1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private MaterialSkin.Controls.MaterialButton btnAddMeal;
        private MaterialSkin.Controls.MaterialButton btnDeleteMeal;
        private System.Windows.Forms.DateTimePicker datePickerMeal;
        private System.Windows.Forms.DataGridView dataGridViewMeal2;
        private System.Windows.Forms.DataGridView dataGridViewMeal3;
        private MaterialSkin.Controls.MaterialLabel lblEditMeal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private MaterialSkin.Controls.MaterialButton btnAddExercise;
        private MaterialSkin.Controls.MaterialButton btnDeleteExercise;
        private MaterialSkin.Controls.MaterialButton btnEditExercise;
        private System.Windows.Forms.Label lblCaloricBurn;
        private System.Windows.Forms.Label lblExercise;
        private System.Windows.Forms.TextBox txtCaloricBurn;
        private System.Windows.Forms.TextBox txtExercise;
        private MaterialSkin.Controls.MaterialLabel lblEditExercise;
        private System.Windows.Forms.DateTimePicker datePickerExercise;
        private System.Windows.Forms.DataGridView dataGridViewExercise1;
        private MaterialSkin.Controls.MaterialButton btnAddSelectedExercise;
        private System.Windows.Forms.Label lblExerciseDate;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.DataGridView dataGridViewExercise2;
        private System.Windows.Forms.DataGridView dataGridViewExercise3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.DataGridView dataGridViewReading1;
        private MaterialSkin.Controls.MaterialButton btnReading;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtAddWeight;
        private System.Windows.Forms.DataGridView dataGridViewReading2;
        private System.Windows.Forms.RadioButton radEvening;
        private System.Windows.Forms.RadioButton radMorning;
        private System.Windows.Forms.DateTimePicker datePickerReading;
        private System.Windows.Forms.Label lblWaist;
        private System.Windows.Forms.TextBox txtAddWaist;
        private System.Windows.Forms.Label lblSelectReading;
        private System.Windows.Forms.Label lblDaytime;
        private System.Windows.Forms.Label lblReadingDate;
        private System.Windows.Forms.Label lblActivity;
        private MaterialSkin.Controls.MaterialButton btnDeleteReading;
        private System.Windows.Forms.Label lblEditWaistMorning;
        private System.Windows.Forms.TextBox txtEditWaistMorning;
        private System.Windows.Forms.Label lblEditWeightMorning;
        private System.Windows.Forms.TextBox txtEditWeightMorning;
        private System.Windows.Forms.Label lblEditReadingDate;
        private System.Windows.Forms.Label lblEditActivity;
        private System.Windows.Forms.DateTimePicker datePickerEditReading;
        private System.Windows.Forms.Label lblEditWaistEvening;
        private System.Windows.Forms.TextBox txtEditWaistEvening;
        private MaterialSkin.Controls.MaterialButton btnEditReading;
        private System.Windows.Forms.Label lblEditWeightEvening;
        private System.Windows.Forms.TextBox txtEditWeightEvening;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.DateTimePicker datePickerStartDate;
        private MaterialSkin.Controls.MaterialLabel lblSelectTracking;
        private System.Windows.Forms.DataGridView dataGridViewTracking1;
        private System.Windows.Forms.DateTimePicker datePickerUntilDate;
        private System.Windows.Forms.Label lblStartDate;
        private MaterialSkin.Controls.MaterialButton btnTrackHistory;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblAverageWeight;
        private System.Windows.Forms.Label lblChangeWeight;
        private System.Windows.Forms.TextBox txtAverageWeight;
        private System.Windows.Forms.TextBox txtChangeWeight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeight;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private System.Windows.Forms.DataGridView dataGridViewTracking2;
        private System.Windows.Forms.DataGridView dataGridViewTracking3;
        private MaterialSkin.Controls.MaterialLabel lblChartWeight;
        private System.Windows.Forms.ComboBox cmbActivity;
        private System.Windows.Forms.ComboBox cmbEditActivity;
        private MaterialSkin.Controls.MaterialButton btnDeleteAnimal;
    }
}

