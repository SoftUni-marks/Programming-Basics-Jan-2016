﻿namespace BGN_to_EUR_Converter
{
    using System;
    using System.Windows.Forms;

    public static class BGNtoEURConverter
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormConverter());
        }
    }
}