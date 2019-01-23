﻿namespace Ordisoftware.HebrewLetters
{
  partial class MainForm
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if ( disposing && (components != null) )
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.Label codeLabel;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      System.Windows.Forms.Label nameLabel;
      System.Windows.Forms.Label structureLabel;
      System.Windows.Forms.Label functionLabel;
      System.Windows.Forms.Label valueSimpleLabel;
      System.Windows.Forms.Label valueFullLabel;
      System.Windows.Forms.Label label2;
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.PanelMain = new System.Windows.Forms.Panel();
      this.PanelMainOuter = new System.Windows.Forms.Panel();
      this.PanelMainInner = new System.Windows.Forms.Panel();
      this.PanelMainCenter = new System.Windows.Forms.Panel();
      this.TabControl = new System.Windows.Forms.TabControl();
      this.TabPageText = new System.Windows.Forms.TabPage();
      this.PanelViewSearch = new System.Windows.Forms.Panel();
      this.ButtonCopyToClipboard = new System.Windows.Forms.Button();
      this.EditSentence = new System.Windows.Forms.TextBox();
      this.EditSum = new System.Windows.Forms.TextBox();
      this.LabelSum = new System.Windows.Forms.Label();
      this.EditAnalyse = new System.Windows.Forms.DataGridView();
      this.ColumnLetter = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnMeaning = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.EditLetters = new Ordisoftware.HebrewLetters.LettersControl();
      this.ButtonAnalyse = new System.Windows.Forms.Button();
      this.ButtonClear = new System.Windows.Forms.Button();
      this.TabPageMonth = new System.Windows.Forms.TabPage();
      this.PanelViewSettings = new System.Windows.Forms.Panel();
      this.PanelSettingsDetails = new System.Windows.Forms.Panel();
      this.ActionDeleteMeaning = new System.Windows.Forms.Button();
      this.ActionAddMeaning = new System.Windows.Forms.Button();
      this.ActionReset = new System.Windows.Forms.LinkLabel();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.LettersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.DataSet = new Ordisoftware.HebrewLetters.Data.DataSet();
      this.EditMeanings = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.meaningsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.valueFullTextBox = new System.Windows.Forms.TextBox();
      this.valueSimpleTextBox = new System.Windows.Forms.TextBox();
      this.functionTextBox = new System.Windows.Forms.TextBox();
      this.nameTextBox = new System.Windows.Forms.TextBox();
      this.structureTextBox = new System.Windows.Forms.TextBox();
      this.PanelSepTop = new System.Windows.Forms.Panel();
      this.PanelTitle = new System.Windows.Forms.Panel();
      this.LabelTitle = new System.Windows.Forms.Label();
      this.moonPhaseImagePictureBox = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.TimerTooltip = new System.Windows.Forms.Timer(this.components);
      this.ToolStrip = new System.Windows.Forms.ToolStrip();
      this.ActionExit = new System.Windows.Forms.ToolStripButton();
      this.Sep4 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionContact = new System.Windows.Forms.ToolStripButton();
      this.ActionWebsite = new System.Windows.Forms.ToolStripButton();
      this.Sep5 = new System.Windows.Forms.ToolStripSeparator();
      this.ActionHelp = new System.Windows.Forms.ToolStripButton();
      this.ActionAbout = new System.Windows.Forms.ToolStripButton();
      this.Sep6 = new System.Windows.Forms.ToolStripSeparator();
      this.MenuSettings = new System.Windows.Forms.ToolStripDropDownButton();
      this.MenuitemScreenPosition = new System.Windows.Forms.ToolStripMenuItem();
      this.EditScreenNone = new System.Windows.Forms.ToolStripMenuItem();
      this.EditScreenTopLeft = new System.Windows.Forms.ToolStripMenuItem();
      this.EditScreenTopRight = new System.Windows.Forms.ToolStripMenuItem();
      this.EditScreenBottomLeft = new System.Windows.Forms.ToolStripMenuItem();
      this.EditScreenBottomRight = new System.Windows.Forms.ToolStripMenuItem();
      this.EditScreenCenter = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionResetWinSettings = new System.Windows.Forms.ToolStripMenuItem();
      this.Sep7 = new System.Windows.Forms.ToolStripSeparator();
      this.EditShowTips = new System.Windows.Forms.ToolStripMenuItem();
      this.EditConfirmClosing = new System.Windows.Forms.ToolStripMenuItem();
      this.ActionViewSearch = new System.Windows.Forms.ToolStripButton();
      this.ActionViewSettings = new System.Windows.Forms.ToolStripButton();
      this.LettersTableAdapter = new Ordisoftware.HebrewLetters.Data.DataSetTableAdapters.LettersTableAdapter();
      this.TableAdapterManager = new Ordisoftware.HebrewLetters.Data.DataSetTableAdapters.TableAdapterManager();
      this.MeaningsTableAdapter = new Ordisoftware.HebrewLetters.Data.DataSetTableAdapters.MeaningsTableAdapter();
      codeLabel = new System.Windows.Forms.Label();
      nameLabel = new System.Windows.Forms.Label();
      structureLabel = new System.Windows.Forms.Label();
      functionLabel = new System.Windows.Forms.Label();
      valueSimpleLabel = new System.Windows.Forms.Label();
      valueFullLabel = new System.Windows.Forms.Label();
      label2 = new System.Windows.Forms.Label();
      this.PanelMain.SuspendLayout();
      this.PanelMainOuter.SuspendLayout();
      this.PanelMainInner.SuspendLayout();
      this.PanelMainCenter.SuspendLayout();
      this.TabControl.SuspendLayout();
      this.TabPageText.SuspendLayout();
      this.PanelViewSearch.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditAnalyse)).BeginInit();
      this.TabPageMonth.SuspendLayout();
      this.PanelViewSettings.SuspendLayout();
      this.PanelSettingsDetails.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.LettersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditMeanings)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.meaningsBindingSource)).BeginInit();
      this.PanelTitle.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.moonPhaseImagePictureBox)).BeginInit();
      this.ToolStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // codeLabel
      // 
      resources.ApplyResources(codeLabel, "codeLabel");
      codeLabel.Name = "codeLabel";
      // 
      // nameLabel
      // 
      resources.ApplyResources(nameLabel, "nameLabel");
      nameLabel.Name = "nameLabel";
      // 
      // structureLabel
      // 
      resources.ApplyResources(structureLabel, "structureLabel");
      structureLabel.Name = "structureLabel";
      // 
      // functionLabel
      // 
      resources.ApplyResources(functionLabel, "functionLabel");
      functionLabel.Name = "functionLabel";
      // 
      // valueSimpleLabel
      // 
      resources.ApplyResources(valueSimpleLabel, "valueSimpleLabel");
      valueSimpleLabel.Name = "valueSimpleLabel";
      // 
      // valueFullLabel
      // 
      resources.ApplyResources(valueFullLabel, "valueFullLabel");
      valueFullLabel.Name = "valueFullLabel";
      // 
      // label2
      // 
      resources.ApplyResources(label2, "label2");
      label2.Name = "label2";
      // 
      // PanelMain
      // 
      this.PanelMain.Controls.Add(this.PanelMainOuter);
      this.PanelMain.Controls.Add(this.PanelSepTop);
      this.PanelMain.Controls.Add(this.PanelTitle);
      resources.ApplyResources(this.PanelMain, "PanelMain");
      this.PanelMain.Name = "PanelMain";
      // 
      // PanelMainOuter
      // 
      this.PanelMainOuter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.PanelMainOuter.Controls.Add(this.PanelMainInner);
      resources.ApplyResources(this.PanelMainOuter, "PanelMainOuter");
      this.PanelMainOuter.Name = "PanelMainOuter";
      // 
      // PanelMainInner
      // 
      this.PanelMainInner.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.PanelMainInner.Controls.Add(this.PanelMainCenter);
      resources.ApplyResources(this.PanelMainInner, "PanelMainInner");
      this.PanelMainInner.Name = "PanelMainInner";
      // 
      // PanelMainCenter
      // 
      this.PanelMainCenter.Controls.Add(this.TabControl);
      resources.ApplyResources(this.PanelMainCenter, "PanelMainCenter");
      this.PanelMainCenter.Name = "PanelMainCenter";
      // 
      // TabControl
      // 
      this.TabControl.Controls.Add(this.TabPageText);
      this.TabControl.Controls.Add(this.TabPageMonth);
      resources.ApplyResources(this.TabControl, "TabControl");
      this.TabControl.Name = "TabControl";
      this.TabControl.SelectedIndex = 0;
      this.TabControl.TabStop = false;
      // 
      // TabPageText
      // 
      this.TabPageText.Controls.Add(this.PanelViewSearch);
      resources.ApplyResources(this.TabPageText, "TabPageText");
      this.TabPageText.Name = "TabPageText";
      this.TabPageText.UseVisualStyleBackColor = true;
      // 
      // PanelViewSearch
      // 
      this.PanelViewSearch.BackColor = System.Drawing.SystemColors.Control;
      this.PanelViewSearch.Controls.Add(this.ButtonCopyToClipboard);
      this.PanelViewSearch.Controls.Add(this.EditSentence);
      this.PanelViewSearch.Controls.Add(this.EditSum);
      this.PanelViewSearch.Controls.Add(this.LabelSum);
      this.PanelViewSearch.Controls.Add(this.EditAnalyse);
      this.PanelViewSearch.Controls.Add(this.EditLetters);
      this.PanelViewSearch.Controls.Add(this.ButtonAnalyse);
      this.PanelViewSearch.Controls.Add(this.ButtonClear);
      resources.ApplyResources(this.PanelViewSearch, "PanelViewSearch");
      this.PanelViewSearch.Name = "PanelViewSearch";
      // 
      // ButtonCopyToClipboard
      // 
      resources.ApplyResources(this.ButtonCopyToClipboard, "ButtonCopyToClipboard");
      this.ButtonCopyToClipboard.FlatAppearance.BorderSize = 0;
      this.ButtonCopyToClipboard.Name = "ButtonCopyToClipboard";
      this.ButtonCopyToClipboard.UseVisualStyleBackColor = true;
      this.ButtonCopyToClipboard.Click += new System.EventHandler(this.ButtonCopyToClipboard_Click);
      // 
      // EditSentence
      // 
      resources.ApplyResources(this.EditSentence, "EditSentence");
      this.EditSentence.BackColor = System.Drawing.Color.Honeydew;
      this.EditSentence.Name = "EditSentence";
      // 
      // EditSum
      // 
      this.EditSum.BackColor = System.Drawing.Color.LavenderBlush;
      resources.ApplyResources(this.EditSum, "EditSum");
      this.EditSum.Name = "EditSum";
      this.EditSum.ReadOnly = true;
      // 
      // LabelSum
      // 
      resources.ApplyResources(this.LabelSum, "LabelSum");
      this.LabelSum.Name = "LabelSum";
      // 
      // EditAnalyse
      // 
      this.EditAnalyse.AllowUserToAddRows = false;
      this.EditAnalyse.AllowUserToDeleteRows = false;
      this.EditAnalyse.AllowUserToResizeColumns = false;
      this.EditAnalyse.AllowUserToResizeRows = false;
      resources.ApplyResources(this.EditAnalyse, "EditAnalyse");
      this.EditAnalyse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.EditAnalyse.ColumnHeadersVisible = false;
      this.EditAnalyse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnLetter,
            this.ColumnMeaning});
      this.EditAnalyse.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
      this.EditAnalyse.Name = "EditAnalyse";
      this.EditAnalyse.RowHeadersVisible = false;
      this.EditAnalyse.RowTemplate.Height = 32;
      this.EditAnalyse.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditAnalyse_CellEnter);
      this.EditAnalyse.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.EditAnalyse_EditingControlShowing);
      // 
      // ColumnLetter
      // 
      dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
      this.ColumnLetter.DefaultCellStyle = dataGridViewCellStyle1;
      resources.ApplyResources(this.ColumnLetter, "ColumnLetter");
      this.ColumnLetter.Name = "ColumnLetter";
      this.ColumnLetter.ReadOnly = true;
      // 
      // ColumnMeaning
      // 
      this.ColumnMeaning.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
      this.ColumnMeaning.DefaultCellStyle = dataGridViewCellStyle2;
      resources.ApplyResources(this.ColumnMeaning, "ColumnMeaning");
      this.ColumnMeaning.Name = "ColumnMeaning";
      this.ColumnMeaning.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.ColumnMeaning.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      // 
      // EditLetters
      // 
      this.EditLetters.BackColor = System.Drawing.Color.Transparent;
      this.EditLetters.InputBackground = System.Drawing.Color.AliceBlue;
      this.EditLetters.LettersBackground = System.Drawing.Color.LightYellow;
      resources.ApplyResources(this.EditLetters, "EditLetters");
      this.EditLetters.Name = "EditLetters";
      this.EditLetters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PanelLetters_KeyPress);
      // 
      // ButtonAnalyse
      // 
      resources.ApplyResources(this.ButtonAnalyse, "ButtonAnalyse");
      this.ButtonAnalyse.Name = "ButtonAnalyse";
      this.ButtonAnalyse.UseVisualStyleBackColor = true;
      this.ButtonAnalyse.Click += new System.EventHandler(this.ButtonAnalyse_Click);
      // 
      // ButtonClear
      // 
      resources.ApplyResources(this.ButtonClear, "ButtonClear");
      this.ButtonClear.Name = "ButtonClear";
      this.ButtonClear.UseVisualStyleBackColor = true;
      this.ButtonClear.Click += new System.EventHandler(this.buttonClear_Click);
      // 
      // TabPageMonth
      // 
      this.TabPageMonth.Controls.Add(this.PanelViewSettings);
      resources.ApplyResources(this.TabPageMonth, "TabPageMonth");
      this.TabPageMonth.Name = "TabPageMonth";
      this.TabPageMonth.UseVisualStyleBackColor = true;
      // 
      // PanelViewSettings
      // 
      resources.ApplyResources(this.PanelViewSettings, "PanelViewSettings");
      this.PanelViewSettings.Controls.Add(this.PanelSettingsDetails);
      this.PanelViewSettings.Name = "PanelViewSettings";
      // 
      // PanelSettingsDetails
      // 
      this.PanelSettingsDetails.BackColor = System.Drawing.SystemColors.Control;
      this.PanelSettingsDetails.Controls.Add(this.ActionDeleteMeaning);
      this.PanelSettingsDetails.Controls.Add(this.ActionAddMeaning);
      this.PanelSettingsDetails.Controls.Add(this.ActionReset);
      this.PanelSettingsDetails.Controls.Add(this.comboBox1);
      this.PanelSettingsDetails.Controls.Add(label2);
      this.PanelSettingsDetails.Controls.Add(codeLabel);
      this.PanelSettingsDetails.Controls.Add(this.EditMeanings);
      this.PanelSettingsDetails.Controls.Add(this.valueFullTextBox);
      this.PanelSettingsDetails.Controls.Add(valueFullLabel);
      this.PanelSettingsDetails.Controls.Add(this.valueSimpleTextBox);
      this.PanelSettingsDetails.Controls.Add(valueSimpleLabel);
      this.PanelSettingsDetails.Controls.Add(nameLabel);
      this.PanelSettingsDetails.Controls.Add(this.functionTextBox);
      this.PanelSettingsDetails.Controls.Add(this.nameTextBox);
      this.PanelSettingsDetails.Controls.Add(functionLabel);
      this.PanelSettingsDetails.Controls.Add(structureLabel);
      this.PanelSettingsDetails.Controls.Add(this.structureTextBox);
      resources.ApplyResources(this.PanelSettingsDetails, "PanelSettingsDetails");
      this.PanelSettingsDetails.Name = "PanelSettingsDetails";
      // 
      // ActionDeleteMeaning
      // 
      resources.ApplyResources(this.ActionDeleteMeaning, "ActionDeleteMeaning");
      this.ActionDeleteMeaning.FlatAppearance.BorderSize = 0;
      this.ActionDeleteMeaning.Name = "ActionDeleteMeaning";
      this.ActionDeleteMeaning.UseVisualStyleBackColor = true;
      this.ActionDeleteMeaning.Click += new System.EventHandler(this.ActionDeleteMeaning_Click);
      // 
      // ActionAddMeaning
      // 
      resources.ApplyResources(this.ActionAddMeaning, "ActionAddMeaning");
      this.ActionAddMeaning.FlatAppearance.BorderSize = 0;
      this.ActionAddMeaning.Name = "ActionAddMeaning";
      this.ActionAddMeaning.UseVisualStyleBackColor = true;
      this.ActionAddMeaning.Click += new System.EventHandler(this.ActionAddMeaning_Click);
      // 
      // ActionReset
      // 
      resources.ApplyResources(this.ActionReset, "ActionReset");
      this.ActionReset.Name = "ActionReset";
      this.ActionReset.TabStop = true;
      this.ActionReset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ActionReset_LinkClicked);
      // 
      // comboBox1
      // 
      this.comboBox1.DataSource = this.LettersBindingSource;
      this.comboBox1.DisplayMember = "Code";
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.comboBox1, "comboBox1");
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Name = "comboBox1";
      // 
      // LettersBindingSource
      // 
      this.LettersBindingSource.AllowNew = false;
      this.LettersBindingSource.DataMember = "Letters";
      this.LettersBindingSource.DataSource = this.DataSet;
      // 
      // DataSet
      // 
      this.DataSet.DataSetName = "DataSet";
      this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // EditMeanings
      // 
      this.EditMeanings.AllowUserToAddRows = false;
      this.EditMeanings.AllowUserToResizeColumns = false;
      this.EditMeanings.AllowUserToResizeRows = false;
      resources.ApplyResources(this.EditMeanings, "EditMeanings");
      this.EditMeanings.AutoGenerateColumns = false;
      this.EditMeanings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.EditMeanings.ColumnHeadersVisible = false;
      this.EditMeanings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
      this.EditMeanings.DataSource = this.meaningsBindingSource;
      this.EditMeanings.MultiSelect = false;
      this.EditMeanings.Name = "EditMeanings";
      this.EditMeanings.RowHeadersVisible = false;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn2.DataPropertyName = "Meaning";
      resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // meaningsBindingSource
      // 
      this.meaningsBindingSource.DataMember = "Letters_Meanings";
      this.meaningsBindingSource.DataSource = this.LettersBindingSource;
      // 
      // valueFullTextBox
      // 
      this.valueFullTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.valueFullTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LettersBindingSource, "ValueFull", true));
      resources.ApplyResources(this.valueFullTextBox, "valueFullTextBox");
      this.valueFullTextBox.Name = "valueFullTextBox";
      this.valueFullTextBox.ReadOnly = true;
      // 
      // valueSimpleTextBox
      // 
      this.valueSimpleTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.valueSimpleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LettersBindingSource, "ValueSimple", true));
      resources.ApplyResources(this.valueSimpleTextBox, "valueSimpleTextBox");
      this.valueSimpleTextBox.Name = "valueSimpleTextBox";
      this.valueSimpleTextBox.ReadOnly = true;
      // 
      // functionTextBox
      // 
      this.functionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LettersBindingSource, "Function", true));
      resources.ApplyResources(this.functionTextBox, "functionTextBox");
      this.functionTextBox.Name = "functionTextBox";
      // 
      // nameTextBox
      // 
      this.nameTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LettersBindingSource, "Name", true));
      resources.ApplyResources(this.nameTextBox, "nameTextBox");
      this.nameTextBox.Name = "nameTextBox";
      this.nameTextBox.ReadOnly = true;
      // 
      // structureTextBox
      // 
      this.structureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.LettersBindingSource, "Structure", true));
      resources.ApplyResources(this.structureTextBox, "structureTextBox");
      this.structureTextBox.Name = "structureTextBox";
      // 
      // PanelSepTop
      // 
      resources.ApplyResources(this.PanelSepTop, "PanelSepTop");
      this.PanelSepTop.Name = "PanelSepTop";
      // 
      // PanelTitle
      // 
      this.PanelTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.PanelTitle.Controls.Add(this.LabelTitle);
      resources.ApplyResources(this.PanelTitle, "PanelTitle");
      this.PanelTitle.Name = "PanelTitle";
      // 
      // LabelTitle
      // 
      this.LabelTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      resources.ApplyResources(this.LabelTitle, "LabelTitle");
      this.LabelTitle.Name = "LabelTitle";
      // 
      // moonPhaseImagePictureBox
      // 
      this.moonPhaseImagePictureBox.BackColor = System.Drawing.SystemColors.ButtonFace;
      resources.ApplyResources(this.moonPhaseImagePictureBox, "moonPhaseImagePictureBox");
      this.moonPhaseImagePictureBox.Name = "moonPhaseImagePictureBox";
      this.moonPhaseImagePictureBox.TabStop = false;
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      // 
      // TimerTooltip
      // 
      this.TimerTooltip.Interval = 500;
      this.TimerTooltip.Tick += new System.EventHandler(this.TimerTooltip_Tick);
      // 
      // ToolStrip
      // 
      resources.ApplyResources(this.ToolStrip, "ToolStrip");
      this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.ToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
      this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionExit,
            this.Sep4,
            this.ActionContact,
            this.ActionWebsite,
            this.Sep5,
            this.ActionHelp,
            this.ActionAbout,
            this.Sep6,
            this.MenuSettings,
            this.ActionViewSearch,
            this.ActionViewSettings});
      this.ToolStrip.Name = "ToolStrip";
      this.ToolStrip.ShowItemToolTips = false;
      // 
      // ActionExit
      // 
      this.ActionExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.ActionExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionExit, "ActionExit");
      this.ActionExit.Name = "ActionExit";
      this.ActionExit.Padding = new System.Windows.Forms.Padding(5);
      this.ActionExit.Click += new System.EventHandler(this.ActionExit_Click);
      this.ActionExit.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionExit.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // Sep4
      // 
      this.Sep4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.Sep4.Name = "Sep4";
      resources.ApplyResources(this.Sep4, "Sep4");
      // 
      // ActionContact
      // 
      this.ActionContact.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.ActionContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionContact, "ActionContact");
      this.ActionContact.Name = "ActionContact";
      this.ActionContact.Padding = new System.Windows.Forms.Padding(5);
      this.ActionContact.Click += new System.EventHandler(this.ActionContact_Click);
      this.ActionContact.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionContact.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // ActionWebsite
      // 
      this.ActionWebsite.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.ActionWebsite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionWebsite, "ActionWebsite");
      this.ActionWebsite.Name = "ActionWebsite";
      this.ActionWebsite.Padding = new System.Windows.Forms.Padding(5);
      this.ActionWebsite.Click += new System.EventHandler(this.ActionApplicationHome_Click);
      this.ActionWebsite.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionWebsite.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // Sep5
      // 
      this.Sep5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.Sep5.Name = "Sep5";
      resources.ApplyResources(this.Sep5, "Sep5");
      // 
      // ActionHelp
      // 
      this.ActionHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.ActionHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionHelp, "ActionHelp");
      this.ActionHelp.Name = "ActionHelp";
      this.ActionHelp.Padding = new System.Windows.Forms.Padding(5);
      this.ActionHelp.Click += new System.EventHandler(this.ActionHelp_Click);
      this.ActionHelp.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionHelp.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // ActionAbout
      // 
      this.ActionAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.ActionAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionAbout, "ActionAbout");
      this.ActionAbout.Name = "ActionAbout";
      this.ActionAbout.Padding = new System.Windows.Forms.Padding(5);
      this.ActionAbout.Click += new System.EventHandler(this.ActionAbout_Click);
      this.ActionAbout.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionAbout.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // Sep6
      // 
      this.Sep6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.Sep6.Name = "Sep6";
      resources.ApplyResources(this.Sep6, "Sep6");
      // 
      // MenuSettings
      // 
      this.MenuSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.MenuSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.MenuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuitemScreenPosition,
            this.ActionResetWinSettings,
            this.Sep7,
            this.EditShowTips,
            this.EditConfirmClosing});
      resources.ApplyResources(this.MenuSettings, "MenuSettings");
      this.MenuSettings.Name = "MenuSettings";
      // 
      // MenuitemScreenPosition
      // 
      this.MenuitemScreenPosition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditScreenNone,
            this.EditScreenTopLeft,
            this.EditScreenTopRight,
            this.EditScreenBottomLeft,
            this.EditScreenBottomRight,
            this.EditScreenCenter});
      resources.ApplyResources(this.MenuitemScreenPosition, "MenuitemScreenPosition");
      this.MenuitemScreenPosition.Name = "MenuitemScreenPosition";
      // 
      // EditScreenNone
      // 
      this.EditScreenNone.CheckOnClick = true;
      resources.ApplyResources(this.EditScreenNone, "EditScreenNone");
      this.EditScreenNone.Name = "EditScreenNone";
      this.EditScreenNone.Click += new System.EventHandler(this.EditScreenPosition_Click);
      // 
      // EditScreenTopLeft
      // 
      this.EditScreenTopLeft.CheckOnClick = true;
      resources.ApplyResources(this.EditScreenTopLeft, "EditScreenTopLeft");
      this.EditScreenTopLeft.Name = "EditScreenTopLeft";
      this.EditScreenTopLeft.Click += new System.EventHandler(this.EditScreenPosition_Click);
      // 
      // EditScreenTopRight
      // 
      this.EditScreenTopRight.CheckOnClick = true;
      resources.ApplyResources(this.EditScreenTopRight, "EditScreenTopRight");
      this.EditScreenTopRight.Name = "EditScreenTopRight";
      this.EditScreenTopRight.Click += new System.EventHandler(this.EditScreenPosition_Click);
      // 
      // EditScreenBottomLeft
      // 
      this.EditScreenBottomLeft.CheckOnClick = true;
      resources.ApplyResources(this.EditScreenBottomLeft, "EditScreenBottomLeft");
      this.EditScreenBottomLeft.Name = "EditScreenBottomLeft";
      this.EditScreenBottomLeft.Click += new System.EventHandler(this.EditScreenPosition_Click);
      // 
      // EditScreenBottomRight
      // 
      this.EditScreenBottomRight.CheckOnClick = true;
      resources.ApplyResources(this.EditScreenBottomRight, "EditScreenBottomRight");
      this.EditScreenBottomRight.Name = "EditScreenBottomRight";
      this.EditScreenBottomRight.Click += new System.EventHandler(this.EditScreenPosition_Click);
      // 
      // EditScreenCenter
      // 
      this.EditScreenCenter.CheckOnClick = true;
      resources.ApplyResources(this.EditScreenCenter, "EditScreenCenter");
      this.EditScreenCenter.Name = "EditScreenCenter";
      this.EditScreenCenter.Click += new System.EventHandler(this.EditScreenPosition_Click);
      // 
      // ActionResetWinSettings
      // 
      resources.ApplyResources(this.ActionResetWinSettings, "ActionResetWinSettings");
      this.ActionResetWinSettings.Name = "ActionResetWinSettings";
      this.ActionResetWinSettings.Click += new System.EventHandler(this.ActionResetWinSettings_Click);
      // 
      // Sep7
      // 
      this.Sep7.Name = "Sep7";
      resources.ApplyResources(this.Sep7, "Sep7");
      // 
      // EditShowTips
      // 
      this.EditShowTips.Checked = true;
      this.EditShowTips.CheckOnClick = true;
      this.EditShowTips.CheckState = System.Windows.Forms.CheckState.Checked;
      resources.ApplyResources(this.EditShowTips, "EditShowTips");
      this.EditShowTips.Name = "EditShowTips";
      // 
      // EditConfirmClosing
      // 
      resources.ApplyResources(this.EditConfirmClosing, "EditConfirmClosing");
      this.EditConfirmClosing.Checked = true;
      this.EditConfirmClosing.CheckOnClick = true;
      this.EditConfirmClosing.CheckState = System.Windows.Forms.CheckState.Checked;
      this.EditConfirmClosing.Name = "EditConfirmClosing";
      // 
      // ActionViewSearch
      // 
      this.ActionViewSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionViewSearch, "ActionViewSearch");
      this.ActionViewSearch.Name = "ActionViewSearch";
      this.ActionViewSearch.Padding = new System.Windows.Forms.Padding(5);
      this.ActionViewSearch.Click += new System.EventHandler(this.ActionViewSearch_Click);
      this.ActionViewSearch.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionViewSearch.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // ActionViewSettings
      // 
      this.ActionViewSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.ActionViewSettings, "ActionViewSettings");
      this.ActionViewSettings.Name = "ActionViewSettings";
      this.ActionViewSettings.Padding = new System.Windows.Forms.Padding(5);
      this.ActionViewSettings.Click += new System.EventHandler(this.ActionViewSettings_Click);
      this.ActionViewSettings.MouseEnter += new System.EventHandler(this.ShowToolTipOnMouseEnter);
      this.ActionViewSettings.MouseLeave += new System.EventHandler(this.ShowToolTipOnMouseLeave);
      // 
      // LettersTableAdapter
      // 
      this.LettersTableAdapter.ClearBeforeFill = true;
      // 
      // TableAdapterManager
      // 
      this.TableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.TableAdapterManager.LettersTableAdapter = this.LettersTableAdapter;
      this.TableAdapterManager.MeaningsTableAdapter = this.MeaningsTableAdapter;
      this.TableAdapterManager.UpdateOrder = Ordisoftware.HebrewLetters.Data.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // MeaningsTableAdapter
      // 
      this.MeaningsTableAdapter.ClearBeforeFill = true;
      // 
      // MainForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.PanelMain);
      this.Controls.Add(this.ToolStrip);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.Shown += new System.EventHandler(this.MainForm_Shown);
      this.PanelMain.ResumeLayout(false);
      this.PanelMainOuter.ResumeLayout(false);
      this.PanelMainInner.ResumeLayout(false);
      this.PanelMainCenter.ResumeLayout(false);
      this.TabControl.ResumeLayout(false);
      this.TabPageText.ResumeLayout(false);
      this.PanelViewSearch.ResumeLayout(false);
      this.PanelViewSearch.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditAnalyse)).EndInit();
      this.TabPageMonth.ResumeLayout(false);
      this.PanelViewSettings.ResumeLayout(false);
      this.PanelSettingsDetails.ResumeLayout(false);
      this.PanelSettingsDetails.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.LettersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.EditMeanings)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.meaningsBindingSource)).EndInit();
      this.PanelTitle.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.moonPhaseImagePictureBox)).EndInit();
      this.ToolStrip.ResumeLayout(false);
      this.ToolStrip.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ToolStrip ToolStrip;
    private System.Windows.Forms.ToolStripButton ActionWebsite;
    private System.Windows.Forms.ToolStripButton ActionContact;
    private System.Windows.Forms.ToolStripButton ActionExit;
    private System.Windows.Forms.ToolStripButton ActionAbout;
    private System.Windows.Forms.ToolStripSeparator Sep4;
    private System.Windows.Forms.ToolStripSeparator Sep5;
    private System.Windows.Forms.ToolStripDropDownButton MenuSettings;
    private System.Windows.Forms.ToolStripMenuItem MenuitemScreenPosition;
    private System.Windows.Forms.ToolStripButton ActionHelp;
    private System.Windows.Forms.ToolStripSeparator Sep7;
    internal System.Windows.Forms.ToolStripMenuItem EditScreenNone;
    internal System.Windows.Forms.ToolStripMenuItem EditScreenCenter;
    internal System.Windows.Forms.ToolStripMenuItem EditScreenTopLeft;
    internal System.Windows.Forms.ToolStripMenuItem EditScreenTopRight;
    internal System.Windows.Forms.ToolStripMenuItem EditScreenBottomLeft;
    internal System.Windows.Forms.ToolStripMenuItem EditScreenBottomRight;
    internal System.Windows.Forms.ToolStripMenuItem EditConfirmClosing;
    private System.Windows.Forms.ToolStripMenuItem ActionResetWinSettings;
    internal System.Windows.Forms.ToolStripMenuItem EditShowTips;
    private System.Windows.Forms.ToolStripSeparator Sep6;
    private System.Windows.Forms.Panel PanelMain;
    private System.Windows.Forms.Panel PanelSepTop;
    private System.Windows.Forms.Panel PanelTitle;
    private System.Windows.Forms.Label LabelTitle;
    private System.Windows.Forms.Panel PanelMainOuter;
    private System.Windows.Forms.Panel PanelMainInner;
    private System.Windows.Forms.PictureBox moonPhaseImagePictureBox;
    private System.Windows.Forms.Label label1;
    internal System.Windows.Forms.Panel PanelMainCenter;
    private System.Windows.Forms.Timer TimerTooltip;
    private System.Windows.Forms.Button ButtonClear;
    private System.Windows.Forms.Button ButtonAnalyse;
    private LettersControl EditLetters;
    private System.Windows.Forms.TabControl TabControl;
    private System.Windows.Forms.TabPage TabPageText;
    private System.Windows.Forms.Panel PanelViewSearch;
    private System.Windows.Forms.TabPage TabPageMonth;
    private System.Windows.Forms.Panel PanelViewSettings;
    private System.Windows.Forms.ToolStripButton ActionViewSearch;
    private System.Windows.Forms.ToolStripButton ActionViewSettings;
    private Data.DataSet DataSet;
    private System.Windows.Forms.BindingSource LettersBindingSource;
    private Data.DataSetTableAdapters.LettersTableAdapter LettersTableAdapter;
    private Data.DataSetTableAdapters.TableAdapterManager TableAdapterManager;
    private System.Windows.Forms.TextBox nameTextBox;
    private System.Windows.Forms.TextBox structureTextBox;
    private System.Windows.Forms.TextBox functionTextBox;
    private System.Windows.Forms.TextBox valueSimpleTextBox;
    private System.Windows.Forms.TextBox valueFullTextBox;
    private Data.DataSetTableAdapters.MeaningsTableAdapter MeaningsTableAdapter;
    private System.Windows.Forms.DataGridView EditMeanings;
    private System.Windows.Forms.BindingSource meaningsBindingSource;
    private System.Windows.Forms.Panel PanelSettingsDetails;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.LinkLabel ActionReset;
    private System.Windows.Forms.Button ActionDeleteMeaning;
    private System.Windows.Forms.Button ActionAddMeaning;
    private System.Windows.Forms.DataGridView EditAnalyse;
    private System.Windows.Forms.TextBox EditSum;
    private System.Windows.Forms.Label LabelSum;
    private System.Windows.Forms.TextBox EditSentence;
    private System.Windows.Forms.Button ButtonCopyToClipboard;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLetter;
    private System.Windows.Forms.DataGridViewComboBoxColumn ColumnMeaning;
  }
}

