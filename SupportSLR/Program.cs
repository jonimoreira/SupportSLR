﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportSLR
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmSpringer());
            //Application.Run(new frmDataSource());
            //Application.Run(new frmQueryDataSourceRound());
            //Application.Run(new frmScienceDirect());
            //Application.Run(new frmGoogleScholar());
            //Application.Run(new frmScopus());
            Application.Run(new frmWiley());

        }
    }
}
