﻿#region Using directives
using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

using log4net;

using treeDiM.StackBuilder.Desktop.Properties;
#endregion

namespace treeDiM.StackBuilder.Desktop
{
    public partial class OptionPanelDebugging : GLib.Options.OptionsPanel
    {
        #region Constructor
        public OptionPanelDebugging()
        {
            InitializeComponent();

            CategoryPath = Properties.Resources.ID_OPTIONSDEBUGGING;
            DisplayName = Properties.Resources.ID_DISPLAYDEBUGGING;
        }
        #endregion

        #region Handlers
        private void ChkShowLogConsole_CheckedChanged(object sender, EventArgs e)
        {
            // force setting
            Settings.Default.ShowLogConsole = chkShowLogConsole.Checked;
            // show or hide log console
            FormMain form = FormMain.GetInstance();
            form.ShowLogConsole();
        }

        private void OnShowApplicationFolder(object sender, EventArgs e)
        {
            try
            {   Process.Start(Path.GetDirectoryName(Application.ExecutablePath)); }
            catch (Exception ex)
            { _log.Error(ex.Message); }
        }
        private void OnResetDefaultSettings(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Reset();
            }
            catch (Exception ex)
            { _log.Error(ex.Message); }
        }
        #endregion

        #region Data members
        static ILog _log = LogManager.GetLogger(typeof(OptionPanelDebugging));
        #endregion
    }
}
