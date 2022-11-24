using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KC__Steam_Manager
{
    public partial class MainUI : Form
    {
        /// DATABASE PATH WILL BE IN THE EXECUTING DIRECTORY
        string dbPath = (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Database.txt");

        struct UserAccounts
        {
            public UserAccounts(string username, string password)
            {
                user = username;
                pass = password;
            }
            public string user { get; }
            public string pass { get; }
        }

        List<UserAccounts> AccountList = new List<UserAccounts>();

        public MainUI()
        {
            InitializeComponent();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            MainUI_NotifyIcon.Visible = true;
            MainUI_NotifyIcon.ShowBalloonTip(3500, "Dev Team: Nightfye & ØNI", " How To Use \nInput your STEAM Username/Password & click Add New Account, after select account and press LOGIN! \n Next boot account will be saved in drop down list!", ToolTipIcon.None);
            /// CHECK IF DATABSE FILE EXISTS
            if (!File.Exists(dbPath))
            {
                
                StreamWriter sw = File.CreateText(dbPath);
                sw.Flush();
                sw.Dispose();
                return;
            }
            

            /// READ DATABASE CONTENTS
            List<string> lines = File.ReadAllLines(dbPath).ToList();

            /// CHECK IF FIRST LINE IS EMPTY (prevents crash)
            if (lines.Count == 0 || lines[0] == "")
            {
                //MainUI_NotifyIcon.ShowBalloonTip(2300, "How To Use:", "Input a steam Username/Password, click ADD NEW ACCOUNT, Click on the DropDown Selection, choose User, press login! Enjoy!", ToolTipIcon.None);
                StreamWriter sw = File.CreateText(dbPath);
                sw.Flush();
                sw.Dispose();
                return;
            }

            /// OBTAINS ACCOUNTS AND POPULATES COMBOBOX
            foreach (var line in lines)
            {
                string[] entries = line.Split(',');
                UserAccounts newUser = new UserAccounts(entries[0], entries[1]);
                Accounts_ComboBox.Items.Add(entries[0]);
                AccountList.Add(newUser);
            }
        }

        private void AddAccount_Btn_Click(object sender, EventArgs e)
        {
            /// RETURN IF TEXTBOX ENTRIES ARE NULL
            if (Username_TB.Text == "" || Password_TB.Text == "")
            {
                // Clear textbox entries
                MainUI_NotifyIcon.ShowBalloonTip(300, "Steam Account", "No Saved Accounts Found!, Setting Accounts to Null!", ToolTipIcon.None);
                Username_TB.Clear();
                Password_TB.Clear();
                return;
            }
            List<string> lines = File.ReadAllLines(dbPath).ToList();                        //  Read Contents
            var User = new UserAccounts(Username_TB.Text, Password_TB.Text);      //  Initialize User Variable
            AccountList.Add(User);                                                          //  Add User to Account List
            lines.Add(User.user + "," + User.pass);                                         //  Parse String with Seperator
            File.WriteAllLines(dbPath, lines);                                              //  Write contents to file

            /// CLEAR BUFFERS
            Username_TB.Clear();
            Password_TB.Clear();
            Accounts_ComboBox.Items.Clear();

            /// ADD ACCOUNT TO DATABASE
            foreach (UserAccounts v in AccountList)
                Accounts_ComboBox.Items.Add(v.user);
                MainUI_NotifyIcon.ShowBalloonTip(300, "Steam Account", "Added To Saved List!", ToolTipIcon.None);
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            /// CHECK IF STEAM IS RUNNING
            foreach (var process in Process.GetProcessesByName("steam"))
                process.Kill(); //  Kill Process

            ProcessStartInfo startInfo = new ProcessStartInfo();
            MainUI_NotifyIcon.ShowBalloonTip(300, "Steam Account", "Logging In!", ToolTipIcon.None);//  Initialize Variable
            startInfo.FileName = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Valve\Steam", "SteamExe", "null");                                              //  Get Process Information to Start
            startInfo.Arguments = $" -noreactlogin -login {AccountList[Accounts_ComboBox.SelectedIndex].user} {AccountList[Accounts_ComboBox.SelectedIndex].pass}";     //  Assign Process Launch Arguments
            Process.Start(startInfo);
        }

        private void Logout_Btn_Click(object sender, EventArgs e)
        {
            /// CHECK IF STEAM IS RUNNING
            foreach (var process in Process.GetProcessesByName("steam"))
                process.Kill(); //  Kill Process

            ProcessStartInfo startInfo = new ProcessStartInfo();
            //  Initialize Variable
            MainUI_NotifyIcon.ShowBalloonTip(300, "Steam Account", "Logging Out!", ToolTipIcon.None);
            startInfo.FileName = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Valve\Steam", "SteamExe", "null");                                              //  Get Process Information to Start
            startInfo.Arguments = $" -noreactlogin -logoff ";                                                                                                           //  Assign Process Launch Arguments
            Process.Start(startInfo);
        }
    }
}
