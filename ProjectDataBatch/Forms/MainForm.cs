﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDataBatch
{
    public partial class MainForm : Form
    {
        private ISportsAPI api;

        public MainForm()
        {
            InitializeComponent();
            api = new SportAPI();
            var urlList = api.GetURLList();
            urlListBox.DataSource = GetNameFromURLList(urlList);

        }

        private List<string> GetNameFromURLList(List<URLModel> urlList)
        {
            List<string> nameList = new List<string>();

            foreach(URLModel url in urlList)
            {
                nameList.Add(url.Get);
            }
            return nameList;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            runDataCollection();
        }

        private void runDataCollection()
        {
            ISportsAPI api = new SportAPI();
        }

        private void RunSelectButton_Click(object sender, EventArgs e)
        {
           bool successful = api.RunAPI(urlListBox.SelectedItem.ToString());
            
        }
    }
}
