﻿#region Using directives
using System;
using System.ComponentModel;
using System.Windows.Forms;

using treeDiM.StackBuilder.ExcelAddIn.Properties;
#endregion

namespace treeDiM.StackBuilder.ExcelAddIn
{
    public partial class FormSettingsPerRow : Form
    {
        public FormSettingsPerRow()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            cbName.SelectedIndex = ExcelHelpers.ColumnLetterToColumnIndex(Settings.Default.ColumnLetterName) - 1;
            cbDescription.SelectedIndex = ExcelHelpers.ColumnLetterToColumnIndex(Settings.Default.ColumnLetterDescription) - 1;
            cbLength.SelectedIndex = ExcelHelpers.ColumnLetterToColumnIndex(Settings.Default.ColumnLetterLength) - 1;
            cbWidth.SelectedIndex = ExcelHelpers.ColumnLetterToColumnIndex(Settings.Default.ColumnLetterWidth) - 1;
            cbHeight.SelectedIndex = ExcelHelpers.ColumnLetterToColumnIndex(Settings.Default.ColumnLetterHeight) - 1;
            cbWeight.SelectedIndex = ExcelHelpers.ColumnLetterToColumnIndex(Settings.Default.ColumnLetterWeight) - 1;
            cbOutputStart.SelectedIndex = ExcelHelpers.ColumnLetterToColumnIndex(Settings.Default.ColumnLetterOutputStart) - 1;
            nudImageSize.Value = (decimal)Settings.Default.ImageSize;
            nudMaxCountImage.Value = (decimal)Settings.Default.StackCountMax;
            uCtrlMinDimensions.Value = Settings.Default.MinDimensions;

            chkbDescription.Checked = Settings.Default.UseDescription;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (!e.Cancel)
            {
                Settings.Default.ColumnLetterName = cbName.SelectedItem.ToString();
                Settings.Default.ColumnLetterDescription = cbDescription.SelectedItem.ToString();
                Settings.Default.ColumnLetterLength = cbLength.SelectedItem.ToString();
                Settings.Default.ColumnLetterWidth = cbWidth.SelectedItem.ToString();
                Settings.Default.ColumnLetterHeight = cbHeight.SelectedItem.ToString();
                Settings.Default.ColumnLetterWeight = cbWeight.SelectedItem.ToString();
                Settings.Default.ColumnLetterOutputStart = cbOutputStart.SelectedItem.ToString();
                Settings.Default.ImageSize = (int)nudImageSize.Value;
                Settings.Default.StackCountMax = (int)nudMaxCountImage.Value;
                Settings.Default.MinDimensions = uCtrlMinDimensions.Value;

                Settings.Default.UseDescription = chkbDescription.Checked;
            }
        }

        private void OnDescriptionChecked(object sender, EventArgs e)
        {
            cbDescription.Enabled = chkbDescription.Checked;
        }
    }
}
