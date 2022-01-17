using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APSWinForm
{
    public partial class frmWebView : Form
    {
        public string UrlAddress { get; set; }

        public frmWebView(string title, string urlAddress)
        {
            InitializeComponent();
            Name = title;
            UrlAddress = urlAddress;
        }

        private void frmWebView_Load(object sender, EventArgs e)
        {
            webView.Source = new Uri(UrlAddress);
        }
    }
}
