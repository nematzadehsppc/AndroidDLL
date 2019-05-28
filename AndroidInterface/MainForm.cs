using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidInterface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            CustomerInterface.CustomerInfo customerInfo = new CustomerInterface.CustomerInfo();

            customerInfo.IP = new InArgument<string>("130.185.76.7");
            customerInfo.Port = new InArgument<int>(9020);
            customerInfo.Database = new InArgument<string>("TEST");
            customerInfo.Version = new InArgument<string>("V3.0");
            customerInfo.UserId = new InArgument<int>(9);
            customerInfo.FPId = new InArgument<int>(1);
            customerInfo.ServiceKey = new InArgument<string>("1234");
            WorkflowInvoker.Invoke<string>(customerInfo);
        }
    }
}
