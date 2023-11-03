using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using RestSharp;
using Newtonsoft.Json;
using System.Diagnostics;

namespace GameApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            comboBox1.SelectedItem = comboBox1.Items[0];
            MakeRequest();

            //code bellow calls comboBox1_SelectedIndexChanged which makes the request
            //comboBox1.SelectedItem = comboBox1.Items[0];
        }


        string Url = "https://www.cheapshark.com/api/1.0/deals?";
        string StoreFilter = "";
        int PageNumber = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            PageNumber = 0;
            MakeRequest();
        }
        public void MakeRequest()
        {
            string Queries = $"sortBy={comboBox1.SelectedItem.ToString().Replace(" ", "%20")}&desc={(comboBox1.SelectedItem.ToString() == "Price" ? Convert.ToInt32(!radioButton1.Checked) : Convert.ToInt32(radioButton1.Checked))}&lowerPrice={MinPriceNumericUpDown.Value}&upperPrice={MaxPriceNumericUpDown.Value}&title={textBox1.Text.Replace("?", "").Replace("\\", "").Replace("&", "").Trim()}{(StoreFilter != "" ? $"&storeID={StoreFilter}" : "")}&pageNumber={PageNumber}";
            Debug.WriteLine(Url + Queries);
            List<APIResponseModel.root> ResponseObj = GetRequest<List<APIResponseModel.root>>(Url + Queries);
            if (!(ResponseObj is null))
            {
                label5.Text = $"Page number: {PageNumber + 1}";
                flowLayoutPanel1.Controls.Clear();
                if (ResponseObj.Count == 0)
                {
                    MessageBox.Show("No results found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                Cursor = Cursors.WaitCursor;
                AddGames(ResponseObj);
                Cursor = Cursors.Default;
            }
        }
        void AddGames(List<APIResponseModel.root> ResponseObj)
        {
            foreach (APIResponseModel.root GamePanel in ResponseObj)
            {
                UserControl1 Game = new UserControl1(GamePanel.title,
                                                     GamePanel.thumb,
                                                     GamePanel.savings,
                                                     GamePanel.normalPrice,
                                                     GamePanel.salePrice,
                                                     GamePanel.storeID,
                                                     GamePanel.dealRating,
                                                     GamePanel.dealID);
                flowLayoutPanel1.Controls.Add(Game);
            }
        }
        T GetRequest<T>(string Url)
        {
            try
            {
                RestClient Client = new RestClient();
                RestRequest Request = new RestRequest(Url);
                string JsonData = Client.Get(Request).Content;
                T Response = JsonConvert.DeserializeObject<T>(JsonData);
                Client.Dispose();
                return Response;
            }
            catch (Exception) {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return default(T);
            }
        }

        private void MinPriceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (MinPriceNumericUpDown.Value >= MaxPriceNumericUpDown.Value)
            {
                MinPriceNumericUpDown.Value = MaxPriceNumericUpDown.Value;
            }
        }

        private void MaxPriceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (MaxPriceNumericUpDown.Value < MinPriceNumericUpDown.Value)
            {
                MaxPriceNumericUpDown.Value = MinPriceNumericUpDown.Value;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 FilterForm = new Form2();
            StoreFilter = "";
            FilterForm.ShowDialog();
            foreach (CheckBox box in FilterForm.Controls.OfType<CheckBox>())
            {
                if (box.Checked == true)
                {
                    StoreFilter += (box.TabIndex + 1).ToString() + ",";
                }
            }
            if (StoreFilter != "")
            {
                StoreFilter = StoreFilter.Remove(StoreFilter.Length - 1, 1);
            }
            PageNumber = 0;
            MakeRequest();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count != 0)
            {
                PageNumber++;
                MakeRequest();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PageNumber >= 1)
            {
                PageNumber--;
                MakeRequest();
            }
        }
    }
}