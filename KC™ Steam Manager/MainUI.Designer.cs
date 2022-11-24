namespace KC__Steam_Manager
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.MainUI_BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.MainUI_HeaderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.MainUI_LBL = new System.Windows.Forms.Label();
            this.MainUI_Icon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.MainUI_Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MainUI_Exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MainUI_HeaderSeparator = new Guna.UI2.WinForms.Guna2Separator();
            this.AddNewAct_GB = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2VSeparator3 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.Password_LBL = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.AddAccount_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.Username_RSeparator = new Guna.UI2.WinForms.Guna2VSeparator();
            this.Username_LSeparator = new Guna.UI2.WinForms.Guna2VSeparator();
            this.Username_LBL = new System.Windows.Forms.Label();
            this.Username_HSeparator = new Guna.UI2.WinForms.Guna2Separator();
            this.Username_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.Password_TB = new Guna.UI2.WinForms.Guna2TextBox();
            this.ChooseAct_GB = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Logout_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.Login_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.Accounts_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.MainUI_DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.MainUI_Header_DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.AddAcct_DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ChooseAct_DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.MainUI_LBL_DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.MainUI_NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MainUI_HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainUI_Icon)).BeginInit();
            this.AddNewAct_GB.SuspendLayout();
            this.ChooseAct_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainUI_BorderlessForm
            // 
            this.MainUI_BorderlessForm.BorderRadius = 1;
            this.MainUI_BorderlessForm.ContainerControl = this;
            this.MainUI_BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.MainUI_BorderlessForm.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.MainUI_BorderlessForm.TransparentWhileDrag = true;
            // 
            // MainUI_HeaderPanel
            // 
            this.MainUI_HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.MainUI_HeaderPanel.Controls.Add(this.MainUI_LBL);
            this.MainUI_HeaderPanel.Controls.Add(this.MainUI_Icon);
            this.MainUI_HeaderPanel.Controls.Add(this.MainUI_Minimize);
            this.MainUI_HeaderPanel.Controls.Add(this.MainUI_Exit);
            this.MainUI_HeaderPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainUI_HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainUI_HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.MainUI_HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.MainUI_HeaderPanel.Name = "MainUI_HeaderPanel";
            this.MainUI_HeaderPanel.Size = new System.Drawing.Size(382, 24);
            this.MainUI_HeaderPanel.TabIndex = 0;
            // 
            // MainUI_LBL
            // 
            this.MainUI_LBL.AutoSize = true;
            this.MainUI_LBL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainUI_LBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.MainUI_LBL.Location = new System.Drawing.Point(30, 5);
            this.MainUI_LBL.Name = "MainUI_LBL";
            this.MainUI_LBL.Size = new System.Drawing.Size(213, 17);
            this.MainUI_LBL.TabIndex = 3;
            this.MainUI_LBL.Text = "KC™ STEAM ACCOUNT MANAGER";
            this.MainUI_LBL.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // MainUI_Icon
            // 
            this.MainUI_Icon.BackColor = System.Drawing.Color.Transparent;
            this.MainUI_Icon.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainUI_Icon.FillColor = System.Drawing.Color.Transparent;
            this.MainUI_Icon.Image = global::KC__Steam_Manager.Properties.Resources.Steam;
            this.MainUI_Icon.ImageRotate = 0F;
            this.MainUI_Icon.Location = new System.Drawing.Point(0, 0);
            this.MainUI_Icon.Name = "MainUI_Icon";
            this.MainUI_Icon.Size = new System.Drawing.Size(25, 24);
            this.MainUI_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainUI_Icon.TabIndex = 2;
            this.MainUI_Icon.TabStop = false;
            // 
            // MainUI_Minimize
            // 
            this.MainUI_Minimize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.MainUI_Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MainUI_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainUI_Minimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.MainUI_Minimize.ForeColor = System.Drawing.Color.White;
            this.MainUI_Minimize.IconColor = System.Drawing.Color.White;
            this.MainUI_Minimize.Location = new System.Drawing.Point(340, 0);
            this.MainUI_Minimize.Name = "MainUI_Minimize";
            this.MainUI_Minimize.Size = new System.Drawing.Size(21, 24);
            this.MainUI_Minimize.TabIndex = 6;
            // 
            // MainUI_Exit
            // 
            this.MainUI_Exit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.MainUI_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainUI_Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.MainUI_Exit.ForeColor = System.Drawing.Color.White;
            this.MainUI_Exit.IconColor = System.Drawing.Color.White;
            this.MainUI_Exit.Location = new System.Drawing.Point(361, 0);
            this.MainUI_Exit.Name = "MainUI_Exit";
            this.MainUI_Exit.Size = new System.Drawing.Size(21, 24);
            this.MainUI_Exit.TabIndex = 7;
            // 
            // MainUI_HeaderSeparator
            // 
            this.MainUI_HeaderSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.MainUI_HeaderSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainUI_HeaderSeparator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.MainUI_HeaderSeparator.Location = new System.Drawing.Point(0, 24);
            this.MainUI_HeaderSeparator.Name = "MainUI_HeaderSeparator";
            this.MainUI_HeaderSeparator.Size = new System.Drawing.Size(382, 10);
            this.MainUI_HeaderSeparator.TabIndex = 1;
            // 
            // AddNewAct_GB
            // 
            this.AddNewAct_GB.BackColor = System.Drawing.Color.Transparent;
            this.AddNewAct_GB.BorderColor = System.Drawing.Color.Transparent;
            this.AddNewAct_GB.Controls.Add(this.guna2VSeparator3);
            this.AddNewAct_GB.Controls.Add(this.Password_LBL);
            this.AddNewAct_GB.Controls.Add(this.guna2VSeparator1);
            this.AddNewAct_GB.Controls.Add(this.AddAccount_Btn);
            this.AddNewAct_GB.Controls.Add(this.Username_RSeparator);
            this.AddNewAct_GB.Controls.Add(this.Username_LSeparator);
            this.AddNewAct_GB.Controls.Add(this.Username_LBL);
            this.AddNewAct_GB.Controls.Add(this.Username_HSeparator);
            this.AddNewAct_GB.Controls.Add(this.Username_TB);
            this.AddNewAct_GB.Controls.Add(this.guna2VSeparator2);
            this.AddNewAct_GB.Controls.Add(this.guna2Separator3);
            this.AddNewAct_GB.Controls.Add(this.Password_TB);
            this.AddNewAct_GB.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.AddNewAct_GB.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddNewAct_GB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.AddNewAct_GB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewAct_GB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.AddNewAct_GB.Location = new System.Drawing.Point(0, 34);
            this.AddNewAct_GB.Name = "AddNewAct_GB";
            this.AddNewAct_GB.Size = new System.Drawing.Size(179, 168);
            this.AddNewAct_GB.TabIndex = 3;
            this.AddNewAct_GB.Text = "ADD NEW ACCOUNT";
            this.AddNewAct_GB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2VSeparator3
            // 
            this.guna2VSeparator3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.guna2VSeparator3.Location = new System.Drawing.Point(-6, 106);
            this.guna2VSeparator3.Name = "guna2VSeparator3";
            this.guna2VSeparator3.Size = new System.Drawing.Size(10, 20);
            this.guna2VSeparator3.TabIndex = 19;
            // 
            // Password_LBL
            // 
            this.Password_LBL.AutoSize = true;
            this.Password_LBL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_LBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.Password_LBL.Location = new System.Drawing.Point(3, 86);
            this.Password_LBL.Name = "Password_LBL";
            this.Password_LBL.Size = new System.Drawing.Size(81, 17);
            this.Password_LBL.TabIndex = 16;
            this.Password_LBL.Text = "PASSWORD:";
            this.Password_LBL.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.guna2VSeparator1.Location = new System.Drawing.Point(172, 40);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 130);
            this.guna2VSeparator1.TabIndex = 15;
            // 
            // AddAccount_Btn
            // 
            this.AddAccount_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddAccount_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddAccount_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddAccount_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddAccount_Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.AddAccount_Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAccount_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.AddAccount_Btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.AddAccount_Btn.Location = new System.Drawing.Point(3, 132);
            this.AddAccount_Btn.Name = "AddAccount_Btn";
            this.AddAccount_Btn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.AddAccount_Btn.Size = new System.Drawing.Size(173, 33);
            this.AddAccount_Btn.TabIndex = 2;
            this.AddAccount_Btn.Text = "ADD NEW ACCOUNT";
            this.AddAccount_Btn.Click += new System.EventHandler(this.AddAccount_Btn_Click);
            // 
            // Username_RSeparator
            // 
            this.Username_RSeparator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Username_RSeparator.Location = new System.Drawing.Point(175, 58);
            this.Username_RSeparator.Name = "Username_RSeparator";
            this.Username_RSeparator.Size = new System.Drawing.Size(10, 20);
            this.Username_RSeparator.TabIndex = 8;
            // 
            // Username_LSeparator
            // 
            this.Username_LSeparator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Username_LSeparator.Location = new System.Drawing.Point(-6, 58);
            this.Username_LSeparator.Name = "Username_LSeparator";
            this.Username_LSeparator.Size = new System.Drawing.Size(10, 20);
            this.Username_LSeparator.TabIndex = 7;
            // 
            // Username_LBL
            // 
            this.Username_LBL.AutoSize = true;
            this.Username_LBL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_LBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.Username_LBL.Location = new System.Drawing.Point(3, 38);
            this.Username_LBL.Name = "Username_LBL";
            this.Username_LBL.Size = new System.Drawing.Size(80, 17);
            this.Username_LBL.TabIndex = 4;
            this.Username_LBL.Text = "USERNAME:";
            this.Username_LBL.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Username_HSeparator
            // 
            this.Username_HSeparator.FillColor = System.Drawing.Color.Transparent;
            this.Username_HSeparator.Location = new System.Drawing.Point(1, 48);
            this.Username_HSeparator.Name = "Username_HSeparator";
            this.Username_HSeparator.Size = new System.Drawing.Size(178, 10);
            this.Username_HSeparator.TabIndex = 6;
            // 
            // Username_TB
            // 
            this.Username_TB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.Username_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username_TB.DefaultText = "";
            this.Username_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Username_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Username_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username_TB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.Username_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.Username_TB.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.Username_TB.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.Username_TB.FocusedState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Username_TB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_TB.ForeColor = System.Drawing.Color.DimGray;
            this.Username_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.Username_TB.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.Username_TB.HoverState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Username_TB.Location = new System.Drawing.Point(3, 57);
            this.Username_TB.Name = "Username_TB";
            this.Username_TB.PasswordChar = '\0';
            this.Username_TB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Username_TB.PlaceholderText = "";
            this.Username_TB.SelectedText = "";
            this.Username_TB.Size = new System.Drawing.Size(173, 21);
            this.Username_TB.TabIndex = 0;
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.guna2VSeparator2.Location = new System.Drawing.Point(175, 106);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(10, 20);
            this.guna2VSeparator2.TabIndex = 20;
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Separator3.Location = new System.Drawing.Point(1, 96);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(178, 10);
            this.guna2Separator3.TabIndex = 18;
            // 
            // Password_TB
            // 
            this.Password_TB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.Password_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_TB.DefaultText = "";
            this.Password_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_TB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.Password_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.Password_TB.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.Password_TB.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.Password_TB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.Password_TB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.Password_TB.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.Password_TB.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.Password_TB.Location = new System.Drawing.Point(3, 105);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.PasswordChar = '*';
            this.Password_TB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Password_TB.PlaceholderText = "";
            this.Password_TB.SelectedText = "";
            this.Password_TB.Size = new System.Drawing.Size(173, 21);
            this.Password_TB.TabIndex = 1;
            // 
            // ChooseAct_GB
            // 
            this.ChooseAct_GB.BackColor = System.Drawing.Color.Transparent;
            this.ChooseAct_GB.BorderColor = System.Drawing.Color.Transparent;
            this.ChooseAct_GB.Controls.Add(this.Logout_Btn);
            this.ChooseAct_GB.Controls.Add(this.Login_Btn);
            this.ChooseAct_GB.Controls.Add(this.Accounts_ComboBox);
            this.ChooseAct_GB.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.ChooseAct_GB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChooseAct_GB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.ChooseAct_GB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseAct_GB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.ChooseAct_GB.Location = new System.Drawing.Point(179, 34);
            this.ChooseAct_GB.Name = "ChooseAct_GB";
            this.ChooseAct_GB.Size = new System.Drawing.Size(203, 168);
            this.ChooseAct_GB.TabIndex = 4;
            this.ChooseAct_GB.Text = "CHOOSE SAVED ACCOUNT";
            this.ChooseAct_GB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Logout_Btn
            // 
            this.Logout_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Logout_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Logout_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Logout_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Logout_Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.Logout_Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.Logout_Btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.Logout_Btn.Location = new System.Drawing.Point(5, 132);
            this.Logout_Btn.Name = "Logout_Btn";
            this.Logout_Btn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Logout_Btn.Size = new System.Drawing.Size(194, 36);
            this.Logout_Btn.TabIndex = 5;
            this.Logout_Btn.Text = "LOGOUT FROM ACCOUNT";
            this.Logout_Btn.Click += new System.EventHandler(this.Logout_Btn_Click);
            // 
            // Login_Btn
            // 
            this.Login_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Login_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Login_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Login_Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.Login_Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.Login_Btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.Login_Btn.Location = new System.Drawing.Point(5, 85);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Login_Btn.Size = new System.Drawing.Size(194, 36);
            this.Login_Btn.TabIndex = 4;
            this.Login_Btn.Text = "LOGIN";
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // Accounts_ComboBox
            // 
            this.Accounts_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.Accounts_ComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.Accounts_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Accounts_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Accounts_ComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.Accounts_ComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.Accounts_ComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.Accounts_ComboBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.Accounts_ComboBox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.Accounts_ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Accounts_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.Accounts_ComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(218)))));
            this.Accounts_ComboBox.ItemHeight = 30;
            this.Accounts_ComboBox.Location = new System.Drawing.Point(4, 44);
            this.Accounts_ComboBox.Name = "Accounts_ComboBox";
            this.Accounts_ComboBox.Size = new System.Drawing.Size(197, 36);
            this.Accounts_ComboBox.TabIndex = 3;
            // 
            // MainUI_DragControl
            // 
            this.MainUI_DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.MainUI_DragControl.TargetControl = this;
            this.MainUI_DragControl.UseTransparentDrag = true;
            // 
            // MainUI_Header_DragControl
            // 
            this.MainUI_Header_DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.MainUI_Header_DragControl.TargetControl = this.MainUI_HeaderPanel;
            this.MainUI_Header_DragControl.UseTransparentDrag = true;
            // 
            // AddAcct_DragControl
            // 
            this.AddAcct_DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.AddAcct_DragControl.TargetControl = this.AddNewAct_GB;
            this.AddAcct_DragControl.UseTransparentDrag = true;
            // 
            // ChooseAct_DragControl
            // 
            this.ChooseAct_DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.ChooseAct_DragControl.TargetControl = this.ChooseAct_GB;
            this.ChooseAct_DragControl.UseTransparentDrag = true;
            // 
            // MainUI_LBL_DragControl
            // 
            this.MainUI_LBL_DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.MainUI_LBL_DragControl.TargetControl = this.MainUI_LBL;
            this.MainUI_LBL_DragControl.UseTransparentDrag = true;
            // 
            // MainUI_NotifyIcon
            // 
            this.MainUI_NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MainUI_NotifyIcon.Icon")));
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(382, 202);
            this.Controls.Add(this.ChooseAct_GB);
            this.Controls.Add(this.AddNewAct_GB);
            this.Controls.Add(this.MainUI_HeaderSeparator);
            this.Controls.Add(this.MainUI_HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KC™ STEAM ACCOUNT MANAGER";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.MainUI_HeaderPanel.ResumeLayout(false);
            this.MainUI_HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainUI_Icon)).EndInit();
            this.AddNewAct_GB.ResumeLayout(false);
            this.AddNewAct_GB.PerformLayout();
            this.ChooseAct_GB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm MainUI_BorderlessForm;
        private Guna.UI2.WinForms.Guna2Panel MainUI_HeaderPanel;
        private Guna.UI2.WinForms.Guna2PictureBox MainUI_Icon;
        private Guna.UI2.WinForms.Guna2ControlBox MainUI_Minimize;
        private Guna.UI2.WinForms.Guna2ControlBox MainUI_Exit;
        private Guna.UI2.WinForms.Guna2GroupBox ChooseAct_GB;
        private Guna.UI2.WinForms.Guna2GroupBox AddNewAct_GB;
        private Guna.UI2.WinForms.Guna2TextBox Username_TB;
        private System.Windows.Forms.Label Username_LBL;
        private Guna.UI2.WinForms.Guna2Separator MainUI_HeaderSeparator;
        private System.Windows.Forms.Label MainUI_LBL;
        private Guna.UI2.WinForms.Guna2ComboBox Accounts_ComboBox;
        private Guna.UI2.WinForms.Guna2Button AddAccount_Btn;
        private Guna.UI2.WinForms.Guna2VSeparator Username_RSeparator;
        private Guna.UI2.WinForms.Guna2VSeparator Username_LSeparator;
        private Guna.UI2.WinForms.Guna2Separator Username_HSeparator;
        private Guna.UI2.WinForms.Guna2Button Logout_Btn;
        private Guna.UI2.WinForms.Guna2Button Login_Btn;
        private Guna.UI2.WinForms.Guna2DragControl MainUI_DragControl;
        private Guna.UI2.WinForms.Guna2DragControl MainUI_Header_DragControl;
        private Guna.UI2.WinForms.Guna2DragControl AddAcct_DragControl;
        private Guna.UI2.WinForms.Guna2DragControl ChooseAct_DragControl;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator3;
        private System.Windows.Forms.Label Password_LBL;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2TextBox Password_TB;
        private Guna.UI2.WinForms.Guna2DragControl MainUI_LBL_DragControl;
        private System.Windows.Forms.NotifyIcon MainUI_NotifyIcon;
    }
}

