using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;

namespace Controladora.SISTFLOTA.Strategy
{
    public class DOCStrategy : IStrategy
    {
        public void GenerarReporteGastos()
        {
            /*
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();

            ExcelApp.Application.Workbooks.Add(Type.Missing);

            ExcelApp.Columns.ColumnWidth = 20;
            

            for (int i = 1; i < dgvDatos.Columns.Count + 1; i++)
            {

                ExcelApp.Cells[1, i] = dgvDatos.Columns[i - 1].HeaderText;

            }
            for (int i = 0; i < dgvDatos.Rows.Count; i++)
            {

                for (int j = 0; j < dgvDatos.Columns.Count; j++)
                {

                    ExcelApp.Cells[i + 2, j + 1] = dgvDatos.Rows[i].Cells[j].Value.ToString();

                }

            }

            ExcelApp.ActiveWorkbook.SaveCopyAs("test.xls");
            ExcelApp.ActiveWorkbook.Saved = true;
            ExcelApp.ActiveWorkbook.WebPagePreview();

            ExcelApp.Quit();
            */
        }

        public void GenerarReporteVehiculosActivos()
        {
            /*
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();

            ExcelApp.Application.Workbooks.Add(Type.Missing);

            ExcelApp.Columns.ColumnWidth = 20;
            

            for (int i = 1; i < dgvDatos.Columns.Count + 1; i++)
            {

                ExcelApp.Cells[1, i] = dgvDatos.Columns[i - 1].HeaderText;

            }
            for (int i = 0; i < dgvDatos.Rows.Count; i++)
            {

                for (int j = 0; j < dgvDatos.Columns.Count; j++)
                {

                    ExcelApp.Cells[i + 2, j + 1] = dgvDatos.Rows[i].Cells[j].Value.ToString();

                }

            }

            ExcelApp.ActiveWorkbook.SaveCopyAs("test.xls");
            ExcelApp.ActiveWorkbook.Saved = true;
            ExcelApp.ActiveWorkbook.WebPagePreview();

            ExcelApp.Quit();
            */
        }
    
    }
}
