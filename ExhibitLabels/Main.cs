using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace ExhibitLabels
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog1;

            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();

            openFileDialog1.Filter = "Excel (*.xls) |*.xls;*.rtf|(*.txt) |*.txt|(*.*) |*.*";

        if (openFileDialog1.ShowDialog() == DialogResult.OK) 
                txtFileName.Text = openFileDialog1.FileName;
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int icol;
            int irow;
            int iCtr;
            Word.Application objWordApp;
            Word.Document objDoc;
            Word.Global objW;

            int intWorksheetNum;
            int intStartLabelRow;
            int intStartLabelCol;
            int intTemp;

            int iColArtist;
            int iColTitle;
            int iColPrice;

            string strArtist;
            string strTitle;
            string strPrice;
            string strOut;

            const string CCArtist = "ARTIST";
            const string CCTitle = "TITLE";
            const string CCPrice = "PRICE";

            objW = new Word.Global();

            iColArtist = 0;
            iColTitle = 0;
            iColPrice = 0;
            intWorksheetNum = Convert.ToInt32(Math.Round(txtWorksheetNumber.Value, 0));

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@txtFileName.Text);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[intWorksheetNum];

            icol = 0;
            var cellValue = (string)(xlWorksheet.Cells[0, icol].Value);

            while (cellValue != "")
            {

                switch (xlWorksheet.Cells[0, icol].Value.ToUpper())
                {
                    case CCArtist:
                        iColArtist = icol;
                        break;
                    case CCTitle:
                        iColTitle = icol;
                        break;
                    case CCPrice:
                        iColPrice = icol;
                        break;
                }
                icol++;
                cellValue = (string)(xlWorksheet.Cells[0, icol].Value);
            }

            objWordApp = new Word.Application();
            objWordApp.Visible = true;
            objDoc = objWordApp.Documents.Add();


            objDoc.PageSetup.TopMargin = objW.InchesToPoints((float)0.38);
            objDoc.PageSetup.BottomMargin = objW.InchesToPoints((float)0.38);
            objDoc.PageSetup.LeftMargin = objW.InchesToPoints((float)0.1875);
            objDoc.PageSetup.RightMargin = objW.InchesToPoints((float)0.1875);

            objDoc.Tables.Add(objDoc.Range(), 1, 3);
            objDoc.Tables[1].Rows.HeightRule = (Word.WdRowHeightRule)2;
            objDoc.Tables[1].Rows.Height = objW.InchesToPoints((float)0.98);
            objDoc.Tables[1].BottomPadding = objW.InchesToPoints((float)0.03);

            objWordApp.Selection.SelectRow();
            objWordApp.Selection.Cells.VerticalAlignment = (Word.WdCellVerticalAlignment)1;
            objWordApp.Selection.Font.Name = "Calibri";
            objWordApp.Selection.Font.Size = 9;
            //objWordApp.Selection.HomeKey(Unit:= 5);

            intStartLabelCol = Convert.ToInt32(Math.Round(txtStartCol.Value, 0));
            intStartLabelRow = Convert.ToInt32(Math.Round(txtStartRow.Value, 0));
            intTemp = ((intStartLabelRow - 1) * 3) + intStartLabelCol;

            //for (iCtr = 2; iCtr == intTemp; iCtr++)
            //{
            //    objWordApp.Selection.MoveRight(Unit:= 12);
            //}

            irow = 1;
            while (xlWorksheet.Cells[irow, iColArtist].value != "")
            {

                strArtist = xlWorksheet.Cells[irow, iColArtist].Value;
                strTitle = xlWorksheet.Cells[irow, iColTitle].Value;

                if (IsNumeric(xlWorksheet.Cells[irow, iColPrice].Value))
                    strPrice = xlWorksheet.Cells[irow, iColPrice].Value.ToString("{0:C}");
                else
                    strPrice = xlWorksheet.Cells[irow, iColPrice].Value;

                strOut = System.Environment.NewLine + "" + strTitle + "" + System.Environment.NewLine;
                strOut = strOut + strArtist.Trim() + System.Environment.NewLine;
                strOut = strOut + "St. James’ Camera Club" + System.Environment.NewLine;

                if (strPrice != "") {
                    strOut = strOut + strPrice + System.Environment.NewLine;
                }


                objWordApp.Selection.ParagraphFormat.LeftIndent = objW.InchesToPoints((float)0.13);
                objWordApp.Selection.ParagraphFormat.SpaceBefore = 1;
                objWordApp.Selection.ParagraphFormat.SpaceBeforeAuto = 0;
                objWordApp.Selection.ParagraphFormat.SpaceAfterAuto = 0;
                objWordApp.Selection.ParagraphFormat.SpaceAfter = 0;
                objWordApp.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                //objWordApp.Selection.TypeText(Text:= strOut);
                //objWordApp.Selection.MoveRight(Unit:= 12);


                irow++;

            }


        bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
    }
}
}
