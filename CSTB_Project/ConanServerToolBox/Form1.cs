using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;
//using Finisar.SQLite;

namespace ConanServerToolBox
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : Form
	{
		private DataGrid Grid;
		
		//private int i=0;

		
		private SQLiteConnection sql_con;
		private SQLiteCommand sql_cmd;
		private SQLiteDataAdapter DB;
		private DataSet DS = new DataSet();
		private DataTable DT = new DataTable();
        private TabPage tabEventLogs;
        private Button btnRunInactiveCleanout;
        private TabPage tabNPCSection;
        private TabPage tabStructureSection;
        private TabPage tabPlayerSection;
        private TabControl tabUserControlTab;
        private Button btnRunViewInstall;
        private Button btnPetLocations;
        private Button btnThrallLocations;
        private Button btnViewStorageInventories;
        private Button btnViewStructureLocations;
        private Button btnPlaceableItemLocations;
        private Button btnDetailedPlayerInfo;
        private Label playerinventorylabel;
        private TextBox playerNametxtBox;
        private Label playerstatslabel;
        private Button btnDetailedPlayerStats;
        private TextBox playerinventorytextbox;
        private Label playerNamelabel;
        private TextBox playerstatstxtBox;
        private Button btnDetailedPlayerInventory;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textNewClanName_namechange;
        private TextBox textPlayerNewName_namechange;
        private Button btnChangePlayerName;
        private TextBox textClanID_namechange;
        private TextBox textPlayerSteamID_namechange;
        private Button btnChangeClanName;
        private Button btnFreshWipe;
        private TextBox textBaseLocations;
        private TextBox textStructureInventories;
        private TextBox textPlaceableLocations;
        private TextBox textPetLocations;
        private TextBox textThrallLocations;
        private Label label5;
        private Button textGameEventsLog;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label13;
        private Label label12;
        private Label label15;
        private Label label14;
        private Button btnGameItemList;
        private Label label23;
        private TextBox textFamilyShareCheck_SteamID;
        private Button btnCheckFamilyShare;
        private Label label18;
        private TextBox Text_GameEvents_VictimID;
        private Label label24;
        private TextBox Text_GameEvents_EventType;
        private TextBox Text_GameEvents_AttackingClanID;
        private TextBox Text_GameEvents_AttackerID;
        private TextBox Text_GameEvents_VictimClanID;
        private Label label20;
        private Label label19;
        private Label label17;
        private Label label16;
        private TabPage tabAboutSection;
        private Label label21;
        private Label label6;
        private Button btn_donate;
        private Label label25;
        private Label label22;
        private Label label26;
        private TabPage tabMaint;
        private Label label33;
        private Label label37;
        private Label label36;
        private Label label35;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private TabPage tabPippiSection;
        private Label label34;
        private Button btn_MerchantInfo;
        private TextBox txt_MerchantInfo;
        private Label label38;




        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Container components = null;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

		

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Grid = new System.Windows.Forms.DataGrid();
            this.tabEventLogs = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Text_GameEvents_AttackingClanID = new System.Windows.Forms.TextBox();
            this.Text_GameEvents_AttackerID = new System.Windows.Forms.TextBox();
            this.Text_GameEvents_VictimClanID = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.Text_GameEvents_EventType = new System.Windows.Forms.TextBox();
            this.textGameEventsLog = new System.Windows.Forms.Button();
            this.Text_GameEvents_VictimID = new System.Windows.Forms.TextBox();
            this.btnFreshWipe = new System.Windows.Forms.Button();
            this.btnRunInactiveCleanout = new System.Windows.Forms.Button();
            this.btnGameItemList = new System.Windows.Forms.Button();
            this.btnRunViewInstall = new System.Windows.Forms.Button();
            this.tabNPCSection = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textPetLocations = new System.Windows.Forms.TextBox();
            this.textThrallLocations = new System.Windows.Forms.TextBox();
            this.btnPetLocations = new System.Windows.Forms.Button();
            this.btnThrallLocations = new System.Windows.Forms.Button();
            this.tabStructureSection = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBaseLocations = new System.Windows.Forms.TextBox();
            this.textStructureInventories = new System.Windows.Forms.TextBox();
            this.textPlaceableLocations = new System.Windows.Forms.TextBox();
            this.btnViewStorageInventories = new System.Windows.Forms.Button();
            this.btnViewStructureLocations = new System.Windows.Forms.Button();
            this.btnPlaceableItemLocations = new System.Windows.Forms.Button();
            this.tabPlayerSection = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textFamilyShareCheck_SteamID = new System.Windows.Forms.TextBox();
            this.btnCheckFamilyShare = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNewClanName_namechange = new System.Windows.Forms.TextBox();
            this.textPlayerNewName_namechange = new System.Windows.Forms.TextBox();
            this.btnChangePlayerName = new System.Windows.Forms.Button();
            this.textClanID_namechange = new System.Windows.Forms.TextBox();
            this.textPlayerSteamID_namechange = new System.Windows.Forms.TextBox();
            this.btnChangeClanName = new System.Windows.Forms.Button();
            this.btnDetailedPlayerInfo = new System.Windows.Forms.Button();
            this.playerinventorylabel = new System.Windows.Forms.Label();
            this.playerNametxtBox = new System.Windows.Forms.TextBox();
            this.playerstatslabel = new System.Windows.Forms.Label();
            this.btnDetailedPlayerStats = new System.Windows.Forms.Button();
            this.playerinventorytextbox = new System.Windows.Forms.TextBox();
            this.playerNamelabel = new System.Windows.Forms.Label();
            this.playerstatstxtBox = new System.Windows.Forms.TextBox();
            this.btnDetailedPlayerInventory = new System.Windows.Forms.Button();
            this.tabUserControlTab = new System.Windows.Forms.TabControl();
            this.tabPippiSection = new System.Windows.Forms.TabPage();
            this.label34 = new System.Windows.Forms.Label();
            this.tabMaint = new System.Windows.Forms.TabPage();
            this.tabAboutSection = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btn_donate = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_MerchantInfo = new System.Windows.Forms.Button();
            this.txt_MerchantInfo = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.tabEventLogs.SuspendLayout();
            this.tabNPCSection.SuspendLayout();
            this.tabStructureSection.SuspendLayout();
            this.tabPlayerSection.SuspendLayout();
            this.tabUserControlTab.SuspendLayout();
            this.tabPippiSection.SuspendLayout();
            this.tabMaint.SuspendLayout();
            this.tabAboutSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AlternatingBackColor = System.Drawing.Color.Gainsboro;
            this.Grid.BackColor = System.Drawing.Color.Gainsboro;
            this.Grid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Grid.CaptionBackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.Grid, "Grid");
            this.Grid.CaptionForeColor = System.Drawing.Color.Black;
            this.Grid.DataMember = "";
            this.Grid.FlatMode = true;
            this.Grid.ForeColor = System.Drawing.Color.Black;
            this.Grid.GridLineColor = System.Drawing.Color.Black;
            this.Grid.HeaderBackColor = System.Drawing.Color.LightGray;
            this.Grid.HeaderFont = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.Grid.HeaderForeColor = System.Drawing.Color.Black;
            this.Grid.LinkColor = System.Drawing.Color.White;
            this.Grid.Name = "Grid";
            this.Grid.ParentRowsBackColor = System.Drawing.Color.White;
            this.Grid.ParentRowsForeColor = System.Drawing.Color.Black;
            this.Grid.PreferredColumnWidth = 120;
            this.Grid.PreferredRowHeight = 25;
            this.Grid.ReadOnly = true;
            this.Grid.SelectionBackColor = System.Drawing.Color.White;
            this.Grid.SelectionForeColor = System.Drawing.Color.White;
            this.Grid.Click += new System.EventHandler(this.Grid_Click);
            // 
            // tabEventLogs
            // 
            this.tabEventLogs.BackColor = System.Drawing.Color.LightGray;
            this.tabEventLogs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabEventLogs.Controls.Add(this.label33);
            this.tabEventLogs.Controls.Add(this.label37);
            this.tabEventLogs.Controls.Add(this.label36);
            this.tabEventLogs.Controls.Add(this.label35);
            this.tabEventLogs.Controls.Add(this.label32);
            this.tabEventLogs.Controls.Add(this.label31);
            this.tabEventLogs.Controls.Add(this.label30);
            this.tabEventLogs.Controls.Add(this.label29);
            this.tabEventLogs.Controls.Add(this.label28);
            this.tabEventLogs.Controls.Add(this.label27);
            this.tabEventLogs.Controls.Add(this.label26);
            this.tabEventLogs.Controls.Add(this.label20);
            this.tabEventLogs.Controls.Add(this.label19);
            this.tabEventLogs.Controls.Add(this.label17);
            this.tabEventLogs.Controls.Add(this.label16);
            this.tabEventLogs.Controls.Add(this.Text_GameEvents_AttackingClanID);
            this.tabEventLogs.Controls.Add(this.Text_GameEvents_AttackerID);
            this.tabEventLogs.Controls.Add(this.Text_GameEvents_VictimClanID);
            this.tabEventLogs.Controls.Add(this.label24);
            this.tabEventLogs.Controls.Add(this.Text_GameEvents_EventType);
            this.tabEventLogs.Controls.Add(this.textGameEventsLog);
            this.tabEventLogs.Controls.Add(this.Text_GameEvents_VictimID);
            resources.ApplyResources(this.tabEventLogs, "tabEventLogs");
            this.tabEventLogs.Name = "tabEventLogs";
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // label37
            // 
            resources.ApplyResources(this.label37, "label37");
            this.label37.Name = "label37";
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.Name = "label36";
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.Name = "label35";
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.Name = "label32";
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.Name = "label31";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // Text_GameEvents_AttackingClanID
            // 
            this.Text_GameEvents_AttackingClanID.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.Text_GameEvents_AttackingClanID, "Text_GameEvents_AttackingClanID");
            this.Text_GameEvents_AttackingClanID.Name = "Text_GameEvents_AttackingClanID";
            this.Text_GameEvents_AttackingClanID.TextChanged += new System.EventHandler(this.Text_GameEvents_AttackingClanID_TextChanged);
            // 
            // Text_GameEvents_AttackerID
            // 
            this.Text_GameEvents_AttackerID.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.Text_GameEvents_AttackerID, "Text_GameEvents_AttackerID");
            this.Text_GameEvents_AttackerID.Name = "Text_GameEvents_AttackerID";
            this.Text_GameEvents_AttackerID.TextChanged += new System.EventHandler(this.Text_GameEvents_AttackerID_TextChanged);
            // 
            // Text_GameEvents_VictimClanID
            // 
            this.Text_GameEvents_VictimClanID.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.Text_GameEvents_VictimClanID, "Text_GameEvents_VictimClanID");
            this.Text_GameEvents_VictimClanID.Name = "Text_GameEvents_VictimClanID";
            this.Text_GameEvents_VictimClanID.TextChanged += new System.EventHandler(this.Text_GameEvents_VictimClanID_TextChanged);
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // Text_GameEvents_EventType
            // 
            this.Text_GameEvents_EventType.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.Text_GameEvents_EventType, "Text_GameEvents_EventType");
            this.Text_GameEvents_EventType.Name = "Text_GameEvents_EventType";
            this.Text_GameEvents_EventType.TextChanged += new System.EventHandler(this.Text_GameEvents_EventType_TextChanged);
            // 
            // textGameEventsLog
            // 
            this.textGameEventsLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textGameEventsLog.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.textGameEventsLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.textGameEventsLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.textGameEventsLog, "textGameEventsLog");
            this.textGameEventsLog.Name = "textGameEventsLog";
            this.textGameEventsLog.UseVisualStyleBackColor = false;
            this.textGameEventsLog.Click += new System.EventHandler(this.textGameEventsLog_Click);
            // 
            // Text_GameEvents_VictimID
            // 
            this.Text_GameEvents_VictimID.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.Text_GameEvents_VictimID, "Text_GameEvents_VictimID");
            this.Text_GameEvents_VictimID.Name = "Text_GameEvents_VictimID";
            this.Text_GameEvents_VictimID.TextChanged += new System.EventHandler(this.Text_GameEvents_VictimID_TextChanged);
            // 
            // btnFreshWipe
            // 
            this.btnFreshWipe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFreshWipe.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFreshWipe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnFreshWipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btnFreshWipe, "btnFreshWipe");
            this.btnFreshWipe.Name = "btnFreshWipe";
            this.btnFreshWipe.UseVisualStyleBackColor = false;
            this.btnFreshWipe.Click += new System.EventHandler(this.btnFreshWipe_Click);
            // 
            // btnRunInactiveCleanout
            // 
            this.btnRunInactiveCleanout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRunInactiveCleanout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRunInactiveCleanout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRunInactiveCleanout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btnRunInactiveCleanout, "btnRunInactiveCleanout");
            this.btnRunInactiveCleanout.Name = "btnRunInactiveCleanout";
            this.btnRunInactiveCleanout.UseVisualStyleBackColor = false;
            this.btnRunInactiveCleanout.Click += new System.EventHandler(this.btnRunInactiveCleanout_Click);
            // 
            // btnGameItemList
            // 
            this.btnGameItemList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGameItemList.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGameItemList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnGameItemList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btnGameItemList, "btnGameItemList");
            this.btnGameItemList.Name = "btnGameItemList";
            this.btnGameItemList.UseVisualStyleBackColor = false;
            this.btnGameItemList.Click += new System.EventHandler(this.btnGameItemList_Click);
            // 
            // btnRunViewInstall
            // 
            this.btnRunViewInstall.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRunViewInstall.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRunViewInstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRunViewInstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btnRunViewInstall, "btnRunViewInstall");
            this.btnRunViewInstall.Name = "btnRunViewInstall";
            this.btnRunViewInstall.UseVisualStyleBackColor = false;
            this.btnRunViewInstall.Click += new System.EventHandler(this.btnRunViewInstall_Click_1);
            // 
            // tabNPCSection
            // 
            this.tabNPCSection.BackColor = System.Drawing.Color.LightGray;
            this.tabNPCSection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabNPCSection.Controls.Add(this.label13);
            this.tabNPCSection.Controls.Add(this.label12);
            this.tabNPCSection.Controls.Add(this.textPetLocations);
            this.tabNPCSection.Controls.Add(this.textThrallLocations);
            this.tabNPCSection.Controls.Add(this.btnPetLocations);
            this.tabNPCSection.Controls.Add(this.btnThrallLocations);
            resources.ApplyResources(this.tabNPCSection, "tabNPCSection");
            this.tabNPCSection.Name = "tabNPCSection";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // textPetLocations
            // 
            this.textPetLocations.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.textPetLocations, "textPetLocations");
            this.textPetLocations.Name = "textPetLocations";
            this.textPetLocations.TextChanged += new System.EventHandler(this.textPetLocations_TextChanged);
            // 
            // textThrallLocations
            // 
            this.textThrallLocations.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.textThrallLocations, "textThrallLocations");
            this.textThrallLocations.Name = "textThrallLocations";
            this.textThrallLocations.TextChanged += new System.EventHandler(this.textThrallLocations_TextChanged);
            // 
            // btnPetLocations
            // 
            this.btnPetLocations.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPetLocations.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPetLocations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnPetLocations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btnPetLocations, "btnPetLocations");
            this.btnPetLocations.Name = "btnPetLocations";
            this.btnPetLocations.UseVisualStyleBackColor = false;
            this.btnPetLocations.Click += new System.EventHandler(this.btnPetLocations_Click_1);
            // 
            // btnThrallLocations
            // 
            this.btnThrallLocations.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThrallLocations.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnThrallLocations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnThrallLocations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btnThrallLocations, "btnThrallLocations");
            this.btnThrallLocations.Name = "btnThrallLocations";
            this.btnThrallLocations.UseVisualStyleBackColor = false;
            this.btnThrallLocations.Click += new System.EventHandler(this.btnThrallLocations_Click_1);
            // 
            // tabStructureSection
            // 
            resources.ApplyResources(this.tabStructureSection, "tabStructureSection");
            this.tabStructureSection.BackColor = System.Drawing.Color.LightGray;
            this.tabStructureSection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabStructureSection.Controls.Add(this.label10);
            this.tabStructureSection.Controls.Add(this.label11);
            this.tabStructureSection.Controls.Add(this.label9);
            this.tabStructureSection.Controls.Add(this.textBaseLocations);
            this.tabStructureSection.Controls.Add(this.textStructureInventories);
            this.tabStructureSection.Controls.Add(this.textPlaceableLocations);
            this.tabStructureSection.Controls.Add(this.btnViewStorageInventories);
            this.tabStructureSection.Controls.Add(this.btnViewStructureLocations);
            this.tabStructureSection.Controls.Add(this.btnPlaceableItemLocations);
            this.tabStructureSection.Name = "tabStructureSection";
            this.tabStructureSection.Click += new System.EventHandler(this.tabStructureSection_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // textBaseLocations
            // 
            this.textBaseLocations.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.textBaseLocations, "textBaseLocations");
            this.textBaseLocations.Name = "textBaseLocations";
            this.textBaseLocations.TextChanged += new System.EventHandler(this.textBaseLocations_TextChanged);
            // 
            // textStructureInventories
            // 
            this.textStructureInventories.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.textStructureInventories, "textStructureInventories");
            this.textStructureInventories.Name = "textStructureInventories";
            this.textStructureInventories.TextChanged += new System.EventHandler(this.textStructureInventories_TextChanged);
            // 
            // textPlaceableLocations
            // 
            this.textPlaceableLocations.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.textPlaceableLocations, "textPlaceableLocations");
            this.textPlaceableLocations.Name = "textPlaceableLocations";
            this.textPlaceableLocations.TextChanged += new System.EventHandler(this.textPlaceableLocations_TextChanged);
            // 
            // btnViewStorageInventories
            // 
            this.btnViewStorageInventories.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewStorageInventories.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewStorageInventories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnViewStorageInventories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btnViewStorageInventories, "btnViewStorageInventories");
            this.btnViewStorageInventories.Name = "btnViewStorageInventories";
            this.btnViewStorageInventories.UseVisualStyleBackColor = false;
            this.btnViewStorageInventories.Click += new System.EventHandler(this.btnViewStorageInventories_Click);
            // 
            // btnViewStructureLocations
            // 
            this.btnViewStructureLocations.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewStructureLocations.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewStructureLocations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnViewStructureLocations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btnViewStructureLocations, "btnViewStructureLocations");
            this.btnViewStructureLocations.Name = "btnViewStructureLocations";
            this.btnViewStructureLocations.UseVisualStyleBackColor = false;
            this.btnViewStructureLocations.Click += new System.EventHandler(this.btnViewStructureLocations_Click_1);
            // 
            // btnPlaceableItemLocations
            // 
            this.btnPlaceableItemLocations.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlaceableItemLocations.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPlaceableItemLocations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnPlaceableItemLocations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btnPlaceableItemLocations, "btnPlaceableItemLocations");
            this.btnPlaceableItemLocations.Name = "btnPlaceableItemLocations";
            this.btnPlaceableItemLocations.UseVisualStyleBackColor = false;
            this.btnPlaceableItemLocations.Click += new System.EventHandler(this.btnPlaceableItemLocations_Click_1);
            // 
            // tabPlayerSection
            // 
            this.tabPlayerSection.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.tabPlayerSection, "tabPlayerSection");
            this.tabPlayerSection.Controls.Add(this.label18);
            this.tabPlayerSection.Controls.Add(this.label23);
            this.tabPlayerSection.Controls.Add(this.textFamilyShareCheck_SteamID);
            this.tabPlayerSection.Controls.Add(this.btnCheckFamilyShare);
            this.tabPlayerSection.Controls.Add(this.label15);
            this.tabPlayerSection.Controls.Add(this.label14);
            this.tabPlayerSection.Controls.Add(this.btnGameItemList);
            this.tabPlayerSection.Controls.Add(this.label8);
            this.tabPlayerSection.Controls.Add(this.label7);
            this.tabPlayerSection.Controls.Add(this.label5);
            this.tabPlayerSection.Controls.Add(this.label4);
            this.tabPlayerSection.Controls.Add(this.label3);
            this.tabPlayerSection.Controls.Add(this.label2);
            this.tabPlayerSection.Controls.Add(this.label1);
            this.tabPlayerSection.Controls.Add(this.textNewClanName_namechange);
            this.tabPlayerSection.Controls.Add(this.textPlayerNewName_namechange);
            this.tabPlayerSection.Controls.Add(this.btnChangePlayerName);
            this.tabPlayerSection.Controls.Add(this.textClanID_namechange);
            this.tabPlayerSection.Controls.Add(this.textPlayerSteamID_namechange);
            this.tabPlayerSection.Controls.Add(this.btnChangeClanName);
            this.tabPlayerSection.Controls.Add(this.btnRunViewInstall);
            this.tabPlayerSection.Controls.Add(this.btnDetailedPlayerInfo);
            this.tabPlayerSection.Controls.Add(this.playerinventorylabel);
            this.tabPlayerSection.Controls.Add(this.playerNametxtBox);
            this.tabPlayerSection.Controls.Add(this.playerstatslabel);
            this.tabPlayerSection.Controls.Add(this.btnDetailedPlayerStats);
            this.tabPlayerSection.Controls.Add(this.playerinventorytextbox);
            this.tabPlayerSection.Controls.Add(this.playerNamelabel);
            this.tabPlayerSection.Controls.Add(this.playerstatstxtBox);
            this.tabPlayerSection.Controls.Add(this.btnDetailedPlayerInventory);
            this.tabPlayerSection.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPlayerSection.Name = "tabPlayerSection";
            this.tabPlayerSection.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // textFamilyShareCheck_SteamID
            // 
            this.textFamilyShareCheck_SteamID.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.textFamilyShareCheck_SteamID, "textFamilyShareCheck_SteamID");
            this.textFamilyShareCheck_SteamID.Name = "textFamilyShareCheck_SteamID";
            this.textFamilyShareCheck_SteamID.TextChanged += new System.EventHandler(this.textFamilyShareCheck_SteamID_TextChanged);
            // 
            // btnCheckFamilyShare
            // 
            this.btnCheckFamilyShare.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheckFamilyShare.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCheckFamilyShare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCheckFamilyShare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btnCheckFamilyShare, "btnCheckFamilyShare");
            this.btnCheckFamilyShare.Name = "btnCheckFamilyShare";
            this.btnCheckFamilyShare.UseVisualStyleBackColor = false;
            this.btnCheckFamilyShare.Click += new System.EventHandler(this.btnFamilyShareCheck_Click);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textNewClanName_namechange
            // 
            this.textNewClanName_namechange.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.textNewClanName_namechange, "textNewClanName_namechange");
            this.textNewClanName_namechange.Name = "textNewClanName_namechange";
            this.textNewClanName_namechange.TextChanged += new System.EventHandler(this.textNewClanName_namechange_TextChanged);
            // 
            // textPlayerNewName_namechange
            // 
            this.textPlayerNewName_namechange.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.textPlayerNewName_namechange, "textPlayerNewName_namechange");
            this.textPlayerNewName_namechange.Name = "textPlayerNewName_namechange";
            this.textPlayerNewName_namechange.TextChanged += new System.EventHandler(this.textPlayerNewName_namechange_TextChanged);
            // 
            // btnChangePlayerName
            // 
            this.btnChangePlayerName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnChangePlayerName.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChangePlayerName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnChangePlayerName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btnChangePlayerName, "btnChangePlayerName");
            this.btnChangePlayerName.Name = "btnChangePlayerName";
            this.btnChangePlayerName.UseVisualStyleBackColor = false;
            this.btnChangePlayerName.Click += new System.EventHandler(this.btnChangePlayerName_Click);
            // 
            // textClanID_namechange
            // 
            this.textClanID_namechange.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.textClanID_namechange, "textClanID_namechange");
            this.textClanID_namechange.Name = "textClanID_namechange";
            this.textClanID_namechange.TextChanged += new System.EventHandler(this.textClanID_namechange_TextChanged);
            // 
            // textPlayerSteamID_namechange
            // 
            this.textPlayerSteamID_namechange.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.textPlayerSteamID_namechange, "textPlayerSteamID_namechange");
            this.textPlayerSteamID_namechange.Name = "textPlayerSteamID_namechange";
            this.textPlayerSteamID_namechange.TextChanged += new System.EventHandler(this.textPlayerSteamID_namechange_TextChanged);
            // 
            // btnChangeClanName
            // 
            this.btnChangeClanName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnChangeClanName.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChangeClanName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnChangeClanName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btnChangeClanName, "btnChangeClanName");
            this.btnChangeClanName.Name = "btnChangeClanName";
            this.btnChangeClanName.UseVisualStyleBackColor = false;
            this.btnChangeClanName.Click += new System.EventHandler(this.btnChangeClanName_Click);
            // 
            // btnDetailedPlayerInfo
            // 
            this.btnDetailedPlayerInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnDetailedPlayerInfo, "btnDetailedPlayerInfo");
            this.btnDetailedPlayerInfo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDetailedPlayerInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnDetailedPlayerInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnDetailedPlayerInfo.Name = "btnDetailedPlayerInfo";
            this.btnDetailedPlayerInfo.UseVisualStyleBackColor = false;
            this.btnDetailedPlayerInfo.Click += new System.EventHandler(this.btnDetailedPlayerInfo_Click_1);
            // 
            // playerinventorylabel
            // 
            resources.ApplyResources(this.playerinventorylabel, "playerinventorylabel");
            this.playerinventorylabel.Name = "playerinventorylabel";
            // 
            // playerNametxtBox
            // 
            this.playerNametxtBox.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.playerNametxtBox, "playerNametxtBox");
            this.playerNametxtBox.Name = "playerNametxtBox";
            this.playerNametxtBox.TextChanged += new System.EventHandler(this.playerNametxtBox_TextChanged);
            // 
            // playerstatslabel
            // 
            resources.ApplyResources(this.playerstatslabel, "playerstatslabel");
            this.playerstatslabel.Name = "playerstatslabel";
            this.playerstatslabel.Click += new System.EventHandler(this.playerstatslabel_Click_1);
            // 
            // btnDetailedPlayerStats
            // 
            this.btnDetailedPlayerStats.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDetailedPlayerStats.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDetailedPlayerStats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnDetailedPlayerStats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btnDetailedPlayerStats, "btnDetailedPlayerStats");
            this.btnDetailedPlayerStats.Name = "btnDetailedPlayerStats";
            this.btnDetailedPlayerStats.UseVisualStyleBackColor = false;
            this.btnDetailedPlayerStats.Click += new System.EventHandler(this.btnDetailedPlayerStats_Click_1);
            // 
            // playerinventorytextbox
            // 
            this.playerinventorytextbox.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.playerinventorytextbox, "playerinventorytextbox");
            this.playerinventorytextbox.Name = "playerinventorytextbox";
            this.playerinventorytextbox.TextChanged += new System.EventHandler(this.playerinventorytextbox_TextChanged_1);
            // 
            // playerNamelabel
            // 
            resources.ApplyResources(this.playerNamelabel, "playerNamelabel");
            this.playerNamelabel.Name = "playerNamelabel";
            // 
            // playerstatstxtBox
            // 
            this.playerstatstxtBox.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.playerstatstxtBox, "playerstatstxtBox");
            this.playerstatstxtBox.Name = "playerstatstxtBox";
            this.playerstatstxtBox.TextChanged += new System.EventHandler(this.playerstatstxtBox_TextChanged);
            // 
            // btnDetailedPlayerInventory
            // 
            this.btnDetailedPlayerInventory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDetailedPlayerInventory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDetailedPlayerInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnDetailedPlayerInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btnDetailedPlayerInventory, "btnDetailedPlayerInventory");
            this.btnDetailedPlayerInventory.Name = "btnDetailedPlayerInventory";
            this.btnDetailedPlayerInventory.UseVisualStyleBackColor = false;
            this.btnDetailedPlayerInventory.Click += new System.EventHandler(this.btnDetailedPlayerInventory_Click_1);
            // 
            // tabUserControlTab
            // 
            resources.ApplyResources(this.tabUserControlTab, "tabUserControlTab");
            this.tabUserControlTab.Controls.Add(this.tabPlayerSection);
            this.tabUserControlTab.Controls.Add(this.tabStructureSection);
            this.tabUserControlTab.Controls.Add(this.tabNPCSection);
            this.tabUserControlTab.Controls.Add(this.tabPippiSection);
            this.tabUserControlTab.Controls.Add(this.tabEventLogs);
            this.tabUserControlTab.Controls.Add(this.tabMaint);
            this.tabUserControlTab.Controls.Add(this.tabAboutSection);
            this.tabUserControlTab.Multiline = true;
            this.tabUserControlTab.Name = "tabUserControlTab";
            this.tabUserControlTab.SelectedIndex = 0;
            this.tabUserControlTab.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            // 
            // tabPippiSection
            // 
            this.tabPippiSection.BackColor = System.Drawing.Color.LightGray;
            this.tabPippiSection.Controls.Add(this.btn_MerchantInfo);
            this.tabPippiSection.Controls.Add(this.txt_MerchantInfo);
            this.tabPippiSection.Controls.Add(this.label38);
            this.tabPippiSection.Controls.Add(this.label34);
            resources.ApplyResources(this.tabPippiSection, "tabPippiSection");
            this.tabPippiSection.Name = "tabPippiSection";
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label34, "label34");
            this.label34.Name = "label34";
            // 
            // tabMaint
            // 
            this.tabMaint.BackColor = System.Drawing.Color.LightGray;
            this.tabMaint.Controls.Add(this.btnFreshWipe);
            this.tabMaint.Controls.Add(this.btnRunInactiveCleanout);
            resources.ApplyResources(this.tabMaint, "tabMaint");
            this.tabMaint.Name = "tabMaint";
            // 
            // tabAboutSection
            // 
            this.tabAboutSection.BackColor = System.Drawing.Color.LightGray;
            this.tabAboutSection.Controls.Add(this.label25);
            this.tabAboutSection.Controls.Add(this.label22);
            this.tabAboutSection.Controls.Add(this.btn_donate);
            this.tabAboutSection.Controls.Add(this.label21);
            this.tabAboutSection.Controls.Add(this.label6);
            resources.ApplyResources(this.tabAboutSection, "tabAboutSection");
            this.tabAboutSection.Name = "tabAboutSection";
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // btn_donate
            // 
            resources.ApplyResources(this.btn_donate, "btn_donate");
            this.btn_donate.Name = "btn_donate";
            this.btn_donate.UseVisualStyleBackColor = true;
            this.btn_donate.Click += new System.EventHandler(this.btn_donate_Click);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // btn_MerchantInfo
            // 
            this.btn_MerchantInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btn_MerchantInfo, "btn_MerchantInfo");
            this.btn_MerchantInfo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_MerchantInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_MerchantInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_MerchantInfo.Name = "btn_MerchantInfo";
            this.btn_MerchantInfo.UseVisualStyleBackColor = false;
            this.btn_MerchantInfo.Click += new System.EventHandler(this.btn_MerchantInfo_Click);
            // 
            // txt_MerchantInfo
            // 
            this.txt_MerchantInfo.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.txt_MerchantInfo, "txt_MerchantInfo");
            this.txt_MerchantInfo.Name = "txt_MerchantInfo";
            this.txt_MerchantInfo.TextChanged += new System.EventHandler(this.txt_MerchantInfo_TextChanged);
            // 
            // label38
            // 
            resources.ApplyResources(this.label38, "label38");
            this.label38.Name = "label38";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tabUserControlTab);
            this.Controls.Add(this.Grid);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.tabEventLogs.ResumeLayout(false);
            this.tabEventLogs.PerformLayout();
            this.tabNPCSection.ResumeLayout(false);
            this.tabNPCSection.PerformLayout();
            this.tabStructureSection.ResumeLayout(false);
            this.tabStructureSection.PerformLayout();
            this.tabPlayerSection.ResumeLayout(false);
            this.tabPlayerSection.PerformLayout();
            this.tabUserControlTab.ResumeLayout(false);
            this.tabPippiSection.ResumeLayout(false);
            this.tabPippiSection.PerformLayout();
            this.tabMaint.ResumeLayout(false);
            this.tabAboutSection.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}
        private System.Diagnostics.Process InactiveCleanoutProcess;
        private void LoadData()
		{
            
		}
        private void SetConnection()
        {
			sql_con = new SQLiteConnection("Data Source=game.db;Version=3;New=False;Compress=True;");
			
        }
		private void ExecuteQuery(string txtQuery)
		{
			SetConnection();
			sql_con.Open();
          
			sql_cmd = sql_con.CreateCommand();
			sql_cmd.CommandText=txtQuery;
		
			sql_cmd.ExecuteNonQuery();
			sql_con.Close();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void Add()
		{
			

		    //string txtSQLQuery = "insert into  mains (desc) values ('"+playerNametxtBox.Text+"')";
		    //ExecuteQuery(txtSQLQuery);
			
		}

		private void btnViewStructureLocations_Click(object sender, EventArgs e)
		{

            SetConnection();
            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();
            string CommandText = "Select * From Structure_Locations";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            sql_con.Close();
            

        }

		private void btnDetailedPlayerStats_Click(object sender, EventArgs e)
		{
            SetConnection();
            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from detailed_player_stats where player_id like ('%"+playerstatstxtBox.Text+"%') OR player_name like('%"+playerstatstxtBox.Text+"%')";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            sql_con.Close();
            
        }

		private void Grid_Click(object sender, EventArgs e)
		{
            //i = Convert.ToInt32(DT.Rows[Grid.CurrentRowIndex]["id"]);
			
		    btnRunInactiveCleanout.Enabled = true;
			btnDetailedPlayerInfo.Enabled = true;
			//playerNametxtBox.Text = DT.Rows[Grid.CurrentRowIndex]["desc"].ToString();
		}

		private void Delete()
		{
			
			//string txtSQLQuery = "delete from  mains where id ="+i;

			//ExecuteQuery(txtSQLQuery);
			
			//playerNametxtBox.Text = string.Empty;
			
		}
       private void Edit()
	   {
		
		//string txtSQLQuery = "update  mains set  desc =\""+playerNametxtBox.Text+"\" where id ="+i;
		//ExecuteQuery(txtSQLQuery);

	   
	   }
        
        private void btnRunInactiveCleanout_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"InactiveCleanout.bat";
            InactiveCleanoutProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    this.btnRunInactiveCleanout.Click += new EventHandler(btnRunInactiveCleanout_Click);
        //}

        private void btnDetailedPlayerInfo_Click(object sender, EventArgs e)
		{

            SetConnection();
            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();
            //searchplayername
            string CommandText = "Select * From detailed_player_info where name like ('%"+playerNametxtBox.Text+"%') OR guild like ('%"+playerNametxtBox.Text+"%') OR playerid like ('%"+ playerNametxtBox.Text+"%') OR DBid like ('%"+playerNametxtBox.Text+"%') OR Guildid like ('%"+playerNametxtBox.Text+"%')";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            sql_con.Close();
        }

        private void PlayerNameTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void PlayerNameTextBox(object sender, EventArgs e)
        {

        }
        private void ClanNameTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void ClanNameTextBox(object sender, EventArgs e)
        {

        }

        private void btnDetailedPlayerInventory_Click(object sender, EventArgs e)
        {

            SetConnection();
            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();
            //searchplayername
            string CommandText = "Select * From detailed_player_inventory where player_name like ('%"+playerinventorytextbox.Text+"%') OR item_name like ('%"+playerinventorytextbox.Text+"%') OR Player_Id like ('%"+playerinventorytextbox.Text+"%')";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            sql_con.Close();

        }

        private void btnDetailedStructureInventory_Click(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();
            string CommandText = "Select * From detailed_structure_inventory";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            sql_con.Close();
        }

        private void btnPetLocations_Click(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();
            string CommandText = "Select * From Pets_Placed_In_World";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            sql_con.Close();

        }

        private void btnThrallLocations_Click(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();
            string CommandText = "Select * From Thralls_Placed_In_World";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            sql_con.Close();

        }

        private void playerstatslabel_Click(object sender, EventArgs e)
        {

        }

        private void playerinventorylabel_Click(object sender, EventArgs e)
        {

        }

        private void playerstatstextBox(object sender, EventArgs e)
        {

        }

        private void playerinventorytextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnPlaceableItemLocations_Click(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from Placeable_Item_Locations";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            sql_con.Close();
        }

        private void btnEditInactiveCleanout_Click(object sender, EventArgs e)
        {

        }

        private void btnRunViewInstall_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"InstallCustomViews.bat";
            InactiveCleanoutProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void tabStructureSection_Click(object sender, EventArgs e)
        {

        }

        private void btnDetailedPlayerInfo_Click_1(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "Select * From detailed_player_info where name like ('%"+playerNametxtBox.Text+"%') OR guild like ('%"+playerNametxtBox.Text+"%') OR playerid like ('%"+playerNametxtBox.Text+"%') OR DBid like ('%"+playerNametxtBox.Text+"%') OR Guildid like ('%"+playerNametxtBox.Text+"%')";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            sql_con.Close();

        }

        private void btnDetailedPlayerStats_Click_1(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from detailed_player_stats where player_id like ('%"+playerstatstxtBox.Text+"%') OR player_name like('%"+playerstatstxtBox.Text+"%')";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            sql_con.Close();
        }

        private void btnDetailedPlayerInventory_Click_1(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();
            //searchplayername
            string CommandText = "Select * From detailed_player_inventory where player_name like ('%"+playerinventorytextbox.Text+"%') OR item_name like ('%"+playerinventorytextbox.Text+"%') OR Player_Id like ('%"+playerinventorytextbox.Text+"%')";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            sql_con.Close();
        }

        private void playerNametxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void playerstatstxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void playerinventorytextbox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnViewStructureLocations_Click_1(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();
            
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "Select * From Structure_Locations where owner like ('%"+textBaseLocations.Text+"%') ";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            sql_con.Close();
        }

        private void btnPlaceableItemLocations_Click_1(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();
            string CommandText = "Select * From Placeable_Item_Locations where owner like ('%"+textPlaceableLocations.Text+"%') OR type like ('%"+textPlaceableLocations.Text+"%')";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            sql_con.Close();
        }

        private void btnViewStorageInventories_Click(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();
            string CommandText = "Select * From Detailed_Structure_Inventory where owner_id like ('%"+textStructureInventories.Text+"%') OR itemname like ('%"+textStructureInventories.Text+"%')";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            sql_con.Close();
        }

        private void btnPetLocations_Click_1(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();
            string CommandText = "Select * From Pets_Placed_In_World where pet_class like ('%"+textPetLocations.Text+"%') OR pet_id like ('%"+textPetLocations.Text+"%') ";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            sql_con.Close();
        }

        private void btnThrallLocations_Click_1(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();
            string CommandText = "Select * From Thralls_Placed_In_World where Thrall_class like ('%"+textThrallLocations.Text+"%') OR thrall_id like ('%"+textThrallLocations.Text+"%') ";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            sql_con.Close();
        }

        private void btnRunViewInstall_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"InstallCustomViews.bat";
            InactiveCleanoutProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void playerstatslabel_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFreshWipe_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo myBatStartInfo = new System.Diagnostics.ProcessStartInfo();
            myBatStartInfo.UseShellExecute = true;  // needed since bat is not an executable
            myBatStartInfo.FileName = @"FreshWipe.bat";
            InactiveCleanoutProcess = System.Diagnostics.Process.Start(myBatStartInfo);
        }

        private void textBaseLocations_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPlaceableLocations_TextChanged(object sender, EventArgs e)
        {

        }

        private void textStructureInventories_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChangePlayerName_Click(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();
            string txtSQLQuery = "UPDATE `characters` SET `char_name`= '" + textPlayerNewName_namechange.Text + "' WHERE `playerId`= '" + textPlayerSteamID_namechange.Text + "'";
            ExecuteQuery(txtSQLQuery);
            sql_con.Close();
        }

        private void textPlayerSteamID_namechange_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPlayerNewName_namechange_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChangeClanName_Click(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();
            string txtSQLQuery = "UPDATE `guilds` SET `name`= '" + textNewClanName_namechange.Text + "' WHERE `guildId`= '" + textClanID_namechange.Text + "'";
            ExecuteQuery(txtSQLQuery);
            sql_con.Close();
        }

        private void textClanID_namechange_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNewClanName_namechange_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPetLocations_TextChanged(object sender, EventArgs e)
        {

        }

        private void textThrallLocations_TextChanged(object sender, EventArgs e)
        {

        }

        private void textGameEventsLog_Click(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();
            string CommandText = "Select * From detailed_game_events where EventType LIKE ('%"+Text_GameEvents_EventType.Text+"%') AND VictimPlayerId LIKE ('%"+Text_GameEvents_VictimID.Text+"%') AND VictimGuildID LIKE ('%"+Text_GameEvents_VictimClanID.Text+"%') AND AttackingPlayerID LIKE ('%"+Text_GameEvents_AttackerID.Text+"%') AND AttackingGuildID LIKE ('%"+Text_GameEvents_AttackingClanID.Text+"%')";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            sql_con.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnGameItemList_Click(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();
            string CommandText = "Select * From cust_item_xref";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            sql_con.Close();
        }

        private void btnFamilyShareCheck_Click(object sender, EventArgs e)
        {
            //48F44ECDECF5821848570F8AD1DD54DA - WWG Web API Key
            try
            {
                //Mouse.OverrideCursor = Cursors.AppStarting;
                Process.Start("http://api.steampowered.com/IPlayerService/IsPlayingSharedGame/v0001/?key=48F44ECDECF5821848570F8AD1DD54DA&steamid=" + textFamilyShareCheck_SteamID.Text + "&appid_playing=440900&format=json");
                //System.Diagnostics.Process.Start("http://www.google.com/").

            }
            catch (Exception)
            {
            }
            finally
            {
                //Mouse.OverrideCursor = null;
            }
        }

        private void textSteamAPIKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFamilyShareCheck_SteamID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Text_GameEvents_VictimID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Text_GameEvents_EventType_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_game_event_description_Click(object sender, EventArgs e)
        {

        }

        private void Text_GameEvents_VictimClanID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Text_GameEvents_AttackerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Text_GameEvents_AttackingClanID_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btn_donate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.powr.io/plugins/paypal-button/view/18787150?mode=page");
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void btn_MerchantInfo_Click(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();
            string CommandText = "Select * From Pippi_Merchants_Placed_In_World where merchant_id like ('%"+txt_MerchantInfo.Text+"%') OR pippi_class like ('%"+txt_MerchantInfo.Text+"%')";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            sql_con.Close();
        }

        private void txt_MerchantInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}