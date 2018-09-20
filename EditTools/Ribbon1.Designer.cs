﻿namespace EditTools
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EditingTools = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.lbl_Version = this.Factory.CreateRibbonLabel();
            this.btn_Help = this.Factory.CreateRibbonButton();
            this.lbl_Spacer1 = this.Factory.CreateRibbonLabel();
            this.btn_Settings = this.Factory.CreateRibbonButton();
            this.btn_Export = this.Factory.CreateRibbonButton();
            this.btn_Import = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.dd_Langs = this.Factory.CreateRibbonDropDown();
            this.btn_FixLang = this.Factory.CreateRibbonButton();
            this.btn_SingData = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.btn_WordList = this.Factory.CreateRibbonButton();
            this.btn_WordFreq = this.Factory.CreateRibbonButton();
            this.btn_ProperNouns = this.Factory.CreateRibbonButton();
            this.edit_MinPhraseLen = this.Factory.CreateRibbonEditBox();
            this.edit_MaxPhraseLen = this.Factory.CreateRibbonEditBox();
            this.btn_PhraseFrequency = this.Factory.CreateRibbonButton();
            this.grp_Finishing = this.Factory.CreateRibbonGroup();
            this.btn_AcceptFormatting = this.Factory.CreateRibbonButton();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.dd_Boilerplate = this.Factory.CreateRibbonDropDown();
            this.btn_ApplyBoilerplate = this.Factory.CreateRibbonButton();
            this.EditingTools.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.grp_Finishing.SuspendLayout();
            this.group4.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditingTools
            // 
            this.EditingTools.Groups.Add(this.group1);
            this.EditingTools.Groups.Add(this.group2);
            this.EditingTools.Groups.Add(this.group3);
            this.EditingTools.Groups.Add(this.grp_Finishing);
            this.EditingTools.Groups.Add(this.group4);
            this.EditingTools.Label = "Editing Tools";
            this.EditingTools.Name = "EditingTools";
            // 
            // group1
            // 
            this.group1.Items.Add(this.lbl_Version);
            this.group1.Items.Add(this.btn_Help);
            this.group1.Items.Add(this.lbl_Spacer1);
            this.group1.Items.Add(this.btn_Settings);
            this.group1.Items.Add(this.btn_Export);
            this.group1.Items.Add(this.btn_Import);
            this.group1.Label = "Settings";
            this.group1.Name = "group1";
            // 
            // lbl_Version
            // 
            this.lbl_Version.Label = "Version 1.4.0";
            this.lbl_Version.Name = "lbl_Version";
            // 
            // btn_Help
            // 
            this.btn_Help.Label = "Help!";
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_Help_Click);
            // 
            // lbl_Spacer1
            // 
            this.lbl_Spacer1.Label = " ";
            this.lbl_Spacer1.Name = "lbl_Spacer1";
            // 
            // btn_Settings
            // 
            this.btn_Settings.Label = "Settings";
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.ScreenTip = "Add/remove/edit boilerplate and configure the edit distance for the proper noun c" +
    "hecker";
            this.btn_Settings.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_Settings_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Label = "Export";
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.ScreenTip = "Save your boilerplate to an XML file you can back up or share";
            this.btn_Export.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_Export_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.Label = "Import";
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.ScreenTip = "Import a boilerplate XML file";
            this.btn_Import.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.dd_Langs);
            this.group2.Items.Add(this.btn_FixLang);
            this.group2.Items.Add(this.btn_SingData);
            this.group2.Label = "Editing";
            this.group2.Name = "group2";
            // 
            // dd_Langs
            // 
            this.dd_Langs.Label = "Languages";
            this.dd_Langs.Name = "dd_Langs";
            this.dd_Langs.ScreenTip = "Apply selected language to the entire  document, including notes, headers and foo" +
    "ters";
            this.dd_Langs.ShowLabel = false;
            this.dd_Langs.SizeString = "WWWWWWWWWWWWWWW";
            // 
            // btn_FixLang
            // 
            this.btn_FixLang.Label = "Apply Language";
            this.btn_FixLang.Name = "btn_FixLang";
            this.btn_FixLang.ScreenTip = "Apply selected language to the entire  document, including notes, headers and foo" +
    "ters";
            this.btn_FixLang.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_FixLang_Click);
            // 
            // btn_SingData
            // 
            this.btn_SingData.Label = "Find Singular Data";
            this.btn_SingData.Name = "btn_SingData";
            this.btn_SingData.ScreenTip = "Find \"data\" used as a singular noun";
            this.btn_SingData.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_SingData_Click);
            // 
            // group3
            // 
            this.group3.Items.Add(this.btn_WordList);
            this.group3.Items.Add(this.btn_WordFreq);
            this.group3.Items.Add(this.btn_ProperNouns);
            this.group3.Items.Add(this.edit_MinPhraseLen);
            this.group3.Items.Add(this.edit_MaxPhraseLen);
            this.group3.Items.Add(this.btn_PhraseFrequency);
            this.group3.Label = "Proofing";
            this.group3.Name = "group3";
            // 
            // btn_WordList
            // 
            this.btn_WordList.Label = "Word List";
            this.btn_WordList.Name = "btn_WordList";
            this.btn_WordList.ScreenTip = "Generate a list of all the unique words in the document";
            this.btn_WordList.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_WordList_Click);
            // 
            // btn_WordFreq
            // 
            this.btn_WordFreq.Label = "Word Frequency List";
            this.btn_WordFreq.Name = "btn_WordFreq";
            this.btn_WordFreq.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_WordFreq_Click);
            // 
            // btn_ProperNouns
            // 
            this.btn_ProperNouns.Label = "Check Proper Nouns";
            this.btn_ProperNouns.Name = "btn_ProperNouns";
            this.btn_ProperNouns.ScreenTip = "Find proper nouns that sound alike or that differ by a configurable edit distance" +
    "";
            this.btn_ProperNouns.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_ProperNouns_Click);
            // 
            // edit_MinPhraseLen
            // 
            this.edit_MinPhraseLen.Label = "Min. Phrase Length";
            this.edit_MinPhraseLen.Name = "edit_MinPhraseLen";
            this.edit_MinPhraseLen.Text = null;
            // 
            // edit_MaxPhraseLen
            // 
            this.edit_MaxPhraseLen.Label = "Max. Phrase Length";
            this.edit_MaxPhraseLen.Name = "edit_MaxPhraseLen";
            this.edit_MaxPhraseLen.Text = null;
            // 
            // btn_PhraseFrequency
            // 
            this.btn_PhraseFrequency.Label = "Phrase Frequency List";
            this.btn_PhraseFrequency.Name = "btn_PhraseFrequency";
            this.btn_PhraseFrequency.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_PhraseFrequency_Click);
            // 
            // grp_Finishing
            // 
            this.grp_Finishing.Items.Add(this.btn_AcceptFormatting);
            this.grp_Finishing.Label = "Finishing";
            this.grp_Finishing.Name = "grp_Finishing";
            // 
            // btn_AcceptFormatting
            // 
            this.btn_AcceptFormatting.Label = "Accept Formatting Changes";
            this.btn_AcceptFormatting.Name = "btn_AcceptFormatting";
            this.btn_AcceptFormatting.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_AcceptFormatting_Click);
            // 
            // group4
            // 
            this.group4.Items.Add(this.dd_Boilerplate);
            this.group4.Items.Add(this.btn_ApplyBoilerplate);
            this.group4.Label = "Boilerplate";
            this.group4.Name = "group4";
            // 
            // dd_Boilerplate
            // 
            this.dd_Boilerplate.Label = "Comments";
            this.dd_Boilerplate.Name = "dd_Boilerplate";
            this.dd_Boilerplate.ScreenTip = "Use the \"Settings\" button to add/remove/edit boilerplate";
            this.dd_Boilerplate.ShowLabel = false;
            this.dd_Boilerplate.SizeString = "WWWWWWWWWWWWWWW";
            // 
            // btn_ApplyBoilerplate
            // 
            this.btn_ApplyBoilerplate.Label = "Apply Comment";
            this.btn_ApplyBoilerplate.Name = "btn_ApplyBoilerplate";
            this.btn_ApplyBoilerplate.ScreenTip = "Click to apply selected comment to the selected text; Use the \"Settings\" button t" +
    "o add/remove/edit boilerplate";
            this.btn_ApplyBoilerplate.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_ApplyBoilerplate_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.EditingTools);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.EditingTools.ResumeLayout(false);
            this.EditingTools.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.grp_Finishing.ResumeLayout(false);
            this.grp_Finishing.PerformLayout();
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab EditingTools;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_Settings;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_Export;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_Import;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_FixLang;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_WordList;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_ProperNouns;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dd_Boilerplate;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_ApplyBoilerplate;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dd_Langs;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_SingData;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grp_Finishing;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_AcceptFormatting;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_WordFreq;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel lbl_Version;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_Help;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel lbl_Spacer1;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox edit_MinPhraseLen;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_PhraseFrequency;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox edit_MaxPhraseLen;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
