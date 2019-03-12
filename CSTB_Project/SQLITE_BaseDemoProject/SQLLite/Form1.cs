using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Finisar.SQLite;

namespace SQLLiteDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Form
	{
		private DataGrid Grid;
		private TextBox txtDesc;
		private Button btnDel;
		private Button btnAdd;
		private Button btnNew;
		private Label lblDesc;
		private Button btnEdit;
		
		private int i=0;

		
		private SQLiteConnection sql_con;
		private SQLiteCommand sql_cmd;
		private SQLiteDataAdapter DB;
		private DataSet DS = new DataSet();
		private DataTable DT = new DataTable();
		
	
		
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private Container components = null;

		public Form1()
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
			this.Grid = new System.Windows.Forms.DataGrid();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.lblDesc = new System.Windows.Forms.Label();
			this.btnEdit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
			this.SuspendLayout();
			// 
			// Grid
			// 
			this.Grid.AlternatingBackColor = System.Drawing.Color.WhiteSmoke;
			this.Grid.BackColor = System.Drawing.Color.Gainsboro;
			this.Grid.BackgroundColor = System.Drawing.Color.DarkGray;
			this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Grid.CaptionBackColor = System.Drawing.Color.DarkKhaki;
			this.Grid.CaptionFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.Grid.CaptionForeColor = System.Drawing.Color.Black;
			this.Grid.DataMember = "";
			this.Grid.FlatMode = true;
			this.Grid.Font = new System.Drawing.Font("Times New Roman", 9F);
			this.Grid.ForeColor = System.Drawing.Color.Black;
			this.Grid.GridLineColor = System.Drawing.Color.Silver;
			this.Grid.HeaderBackColor = System.Drawing.Color.Black;
			this.Grid.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.Grid.HeaderForeColor = System.Drawing.Color.White;
			this.Grid.LinkColor = System.Drawing.Color.DarkSlateBlue;
			this.Grid.Location = new System.Drawing.Point(24, 16);
			this.Grid.Name = "Grid";
			this.Grid.ParentRowsBackColor = System.Drawing.Color.LightGray;
			this.Grid.ParentRowsForeColor = System.Drawing.Color.Black;
			this.Grid.PreferredColumnWidth = 120;
			this.Grid.PreferredRowHeight = 25;
			this.Grid.ReadOnly = true;
			this.Grid.SelectionBackColor = System.Drawing.Color.Firebrick;
			this.Grid.SelectionForeColor = System.Drawing.Color.White;
			this.Grid.Size = new System.Drawing.Size(248, 160);
			this.Grid.TabIndex = 0;
			this.Grid.Click += new System.EventHandler(this.Grid_Click);
			// 
			// txtDesc
			// 
			this.txtDesc.Enabled = false;
			this.txtDesc.Location = new System.Drawing.Point(128, 184);
			this.txtDesc.Multiline = true;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(152, 48);
			this.txtDesc.TabIndex = 2;
			this.txtDesc.Text = "";
			// 
			// btnDel
			// 
			this.btnDel.Enabled = false;
			this.btnDel.Location = new System.Drawing.Point(216, 240);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(50, 23);
			this.btnDel.TabIndex = 3;
			this.btnDel.Text = "Delete";
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Enabled = false;
			this.btnAdd.Location = new System.Drawing.Point(88, 240);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(42, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(22, 240);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(42, 23);
			this.btnNew.TabIndex = 5;
			this.btnNew.Text = "New";
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// lblDesc
			// 
			this.lblDesc.Location = new System.Drawing.Point(32, 192);
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.Size = new System.Drawing.Size(88, 32);
			this.lblDesc.TabIndex = 7;
			this.lblDesc.Text = "Desc (no special chars)";
			// 
			// btnEdit
			// 
			this.btnEdit.Enabled = false;
			this.btnEdit.Location = new System.Drawing.Point(152, 240);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(42, 23);
			this.btnEdit.TabIndex = 8;
			this.btnEdit.Text = "Edit";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.lblDesc);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.txtDesc);
			this.Controls.Add(this.Grid);
			this.Name = "Form1";
			this.Text = "SQLLiteDemo";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
		private void LoadData()
		{
			SetConnection(); 
			sql_con.Open();

			sql_cmd = sql_con.CreateCommand();
			string CommandText = "select id, desc from  mains";
			DB = new SQLiteDataAdapter(CommandText,sql_con);
            DS.Reset();
			DB.Fill(DS);
			DT= DS.Tables[0];
			Grid.DataSource = DT;
			sql_con.Close();
			
		}
        private void SetConnection()
        {
			sql_con = new SQLiteConnection("Data Source=DemoT.db;Version=3;New=False;Compress=True;");
			
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
			

		    string txtSQLQuery = "insert into  mains (desc) values ('"+txtDesc.Text+"')";
		    ExecuteQuery(txtSQLQuery);
			
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
		
		Add();
        LoadData();
        btnAdd.Enabled = false;
		btnNew.Enabled = true;
		btnEdit.Enabled = false;

		txtDesc.Text = string.Empty;
		
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			btnAdd.Enabled = true;
			btnDel.Enabled = false;
			btnNew.Enabled = false;
			btnEdit.Enabled = false;
			txtDesc.Enabled = true;

			txtDesc.Text = string.Empty;
			
		}

		private void Grid_Click(object sender, EventArgs e)
		{
            i = Convert.ToInt32(DT.Rows[Grid.CurrentRowIndex]["id"]);
			
		    btnDel.Enabled = true;
			btnEdit.Enabled = true;
			txtDesc.Text = DT.Rows[Grid.CurrentRowIndex]["desc"].ToString();
		}

		private void Delete()
		{
			
			string txtSQLQuery = "delete from  mains where id ="+i;

			ExecuteQuery(txtSQLQuery);
			
			txtDesc.Text = string.Empty;
			
		}
       private void Edit()
	   {
		
		string txtSQLQuery = "update  mains set  desc =\""+txtDesc.Text+"\" where id ="+i;
		ExecuteQuery(txtSQLQuery);

	   
	   }
  		private void btnDel_Click(object sender, EventArgs e)
		{
		Delete();
	    LoadData();

		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
		
		Edit();
		LoadData();
		}

		
	}
}
