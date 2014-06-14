using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CreateKankouJittusekiTableApp
{
    public partial class CreateKankouJittusekiTableAppForm : Form
    {
        public CreateKankouJittusekiTableAppForm()
        {
            InitializeComponent();
        }

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            string folderPass = null;

            if (selectFolderFBD.ShowDialog() == DialogResult.OK)
            {
                folderPass = selectFolderFBD.SelectedPath;
            }
            else
            {
                return;
            }
            SelectFolderTextBox.Text = folderPass;
        }

        private void SelectCreateFolderButton_Click(object sender, EventArgs e)
        {
            string folderPass = null;

            if (selectCreateFolderFBD.ShowDialog() == DialogResult.OK)
            {
                folderPass = selectCreateFolderFBD.SelectedPath;
            }
            else
            {
                return;
            }
            SelectCreateFolderTextBox.Text = folderPass;
        }

        private void CreateTableButton_Click(object sender, EventArgs e)
        {
            string selectFolderPass = SelectCreateFolderTextBox.Text;
            string xlBookName = "テスト完工実績表.xlsx"; 
            string fileNames = selectFolderPass + xlBookName; //パスを含んだファイル名
            string sheetName = "A"; //パスを含んだファイル名

            SheetA sheetA = new SheetA();
            sheetA.CreateSheet(fileNames, sheetName);
        }
    }
}
