using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiboLink
{
    public partial class frmLink : Form
    {
        public frmLink()
        {
            InitializeComponent();
        }
        private bool isRun = false;
        private void frmLink_Load(object sender, EventArgs e)
        {
            ArrayList arlistA = readFile("siteA.txt");
            ArrayList arlistB = readFile("siteB.txt");
            for (int i = 0; i < arlistA.Count; i++) 
            {
                cbSiteA.Items.Add(arlistA[i]);
            }

            for (int i = 0; i < arlistB.Count; i++)
            {
                cbSiteB.Items.Add(arlistB[i]);
            }

        }
        private ArrayList readFile(String site) 
        {
            ArrayList arlist = new ArrayList();
            using (StreamReader file = new StreamReader(site))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    arlist.Add(ln);
                    counter++;
                }
                file.Close();
            }
            return arlist;
        }

        private bool makeRequestCreate(string site, string data) {          
            try
            {
                string url = site + "/wp-json/monita/addshortlink";
                HttpClient client = new HttpClient();
                RequestData requestData = new RequestData();
                requestData.data = data;
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(requestData);
                var dataPost = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");
                var result = client.PostAsync(url, dataPost).Result;
                if (result.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
           
            return false;



        }
        private void btRun_Click(object sender, EventArgs e)
        {
            
            int totalSuccess = 0;
            string domainA = cbSiteA.Text;
            string domainB = cbSiteB.Text;

            if (domainA.Trim().Length == 0 || domainB.Trim().Length == 0){
                MessageBox.Show("Please select Domain A and Domain B");
                return;
            }
            isRun = !isRun;
            if (isRun == true)
            {
                btRun.Text = "Stop";
            }
            else
            {
                btRun.Text = "Run";
            }
            int numberLink = txtInput.Lines.Length;
            for (int i = 0; i < numberLink; i++)
            {
                string linkData = txtInput.Lines[i];
                string keyCode = linkData.Split('|')[1];
                bool checkSiteA = makeRequestCreate(domainA, linkData);
                bool checkSiteB = false;
                if (checkSiteA) {
                    string linkDataSiteB = domainA + "/" + keyCode +"|" + keyCode;
                    checkSiteB = makeRequestCreate(domainB, linkDataSiteB);
                }
                if (checkSiteA && checkSiteB)
                {
                    totalSuccess += 1;
                    lbResult.Text = totalSuccess + "/" + numberLink;
                    lbResult.Update();

                }
                else {
                    txtLog.AppendText(linkData);                    
                }
                if (!isRun) {
                    break;
                }
            }
            MessageBox.Show("Done..........");
            btRun.Text = "Run";
            isRun = false;

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            int numberLink = txtInput.Lines.Length;
            lbResult.Text =  "0/" + numberLink;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
