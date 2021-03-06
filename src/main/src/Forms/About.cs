﻿using System;
using System.Windows.Forms;

namespace Regata.Desktop.WinForms.Measurements
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            Text = $"Информация о программе | Regata Measurements UI - {LoginForm.CurrentVersion}";

            linkLabel1.Click += GoToManual;
            linkLabel2.Click += GoToMonitor;
        }

        private void GoToManual(object sender, EventArgs eventArgs)
        {
            System.Diagnostics.Process.Start("https://github.com/regata-jinr/MeasurementsUI/blob/master/README.md");
        }

        private void GoToMonitor(object sender, EventArgs eventArgs)
        {
            System.Diagnostics.Process.Start("http://regata.jinr.ru/monitor/");
        }
    }
}
