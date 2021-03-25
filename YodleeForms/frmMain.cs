using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yodlee;

namespace YodleeForms
{
    public partial class frmMain : Form
    {
        private Dictionary<string, string> userDict = new Dictionary<string, string>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string line;

            using (StreamReader file = new System.IO.StreamReader(@"c:\Yodlee\users.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    var fields = line.Split(',');
                    userDict.Add(fields[0], fields[1]);
                    cboxUserList.Items.Add(fields[0]);
                }
            }
        }

        private async void btnGetAccounts_Click(object sender, EventArgs e)
        {
            var userSelected = userDict[cboxUserList.SelectedItem.ToString()];

            var accountList = await GetAllAccounts(userSelected);

            LoadAccountGrid(accountList);

            var list = new BindingList<Account>(accountList.account);

        }

        private void LoadAccountGrid(Accounts accountList)
        {
            grdViewAccounts.Columns.Clear();

            grdViewAccounts.Columns.Add("accountType", "Type");
            grdViewAccounts.Columns.Add("accountName", "Name");
            grdViewAccounts.Columns.Add("accountStatus", "Status");
            grdViewAccounts.Columns.Add("accountNumber", "Number");
            for (int i=0; i<accountList.account.Count; i++)
            {
                grdViewAccounts.Rows.Add(accountList.account[i].accountType, accountList.account[i].accountName, accountList.account[i].accountStatus, accountList.account[i].accountNumber);
            }
        }

        private async  Task<Accounts> GetAllAccounts(string userSelected)
        {
            TokenManager tokenManager = new TokenManager();
            var token = await tokenManager.CreateAuthToken(userSelected);

            AccountManager accountManager = new AccountManager();
            var accounts = await accountManager.GetAccounts(token);

            return accounts;

        }
    }
}
