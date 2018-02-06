using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avalara.AvaTax.Adapter.TaxService;
using log4net;

namespace SOAP_Application
{
    public partial class LoginForm : Form
    {
        public TaxSvc TaxService;
        public string ReturnValueOfLogin, StoreStatus;
        public Avalara.AvaTax.Adapter.PingResult pingResult;
        string ServiceName = "GetTax";
        public LoginForm()
        {
            TaxService = new TaxSvc();
            InitializeComponent();
        }

        private void butReset_Click(object sender, EventArgs e)
        {
            txtAccountId.Text = "";
            txtLiecenceKey.Text = "";
        }

        private void butSubmit_Click(object sender, EventArgs e)
        {
            ReturnValueOfLogin = Login(txtAccountId.Text, txtLiecenceKey.Text, ServiceName);
            if (ReturnValueOfLogin.Equals("success"))
            {
                MessageBox.Show("Login Successfully !!!");
                this.Close();
                TransactionForm tr = new TransactionForm(TaxService);
                tr.Show();
            }
            else
                MessageBox.Show("Login Unsuccessfull");
        }

        public string Login(string username, string password, string _ServiceName)
        {

            TaxService.Configuration.Security.UserName = username;
            TaxService.Configuration.Security.Password = password;
            TaxService.Configuration.Url = "https://development.avalara.net/Tax/TaxSvc.asmx?Ping";
            
            //SOAP in-bulit log settings
            TaxService.Configuration.TraceSoap = true;
            TaxService.Configuration.LogTransactions = false;
            TaxService.Configuration.LogMessages = false;
            TaxService.Configuration.LogSoap = true;
            TaxService.Configuration.LogLevel = Avalara.AvaTax.Adapter.LogLevel.DEBUG;
            TaxService.Configuration.LogFilePath = "C:\\LogFile";
            //

            try
            {
                pingResult = TaxService.Ping(_ServiceName);
                if (pingResult.ResultCode == Avalara.AvaTax.Adapter.SeverityLevel.Success)
                {
                    StoreStatus = "success";
                }
                else
                {
                    StoreStatus = "error";
                }
            }
            catch (Exception)
            {
                StoreStatus = "error";
            }

            return StoreStatus;

        }//Login()
    }//Home class
}
