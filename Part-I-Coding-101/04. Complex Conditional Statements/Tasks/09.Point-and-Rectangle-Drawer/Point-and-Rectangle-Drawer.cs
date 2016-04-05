namespace Point_and_Rectangle_Drawer
{
    using System;
    using System.Windows.Forms;

    public static class PointAndRectangleDrawer
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PointAndRectangleDrawerForm());
        }
    }
}
