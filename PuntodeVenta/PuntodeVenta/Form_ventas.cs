using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta
{
    public partial class Form_ventas : Form
    {
        public Form_ventas()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string cadena = "Select * from CotizacionTB where RFC ='" + combocliente.Text + "' ";

            OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
            OleDbCommand comando = new OleDbCommand(cadena, cnn);
            cnn.Open();

            OleDbDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                //MessageBox.Show("El registro se a encontrado");

                txt_nombre.Text = leer["Nombre"].ToString();
                txt_rfc.Text = leer["RFC"].ToString();
                txt_direccion.Text = leer["Direccion"].ToString();
                txt_telefono.Text = leer["Telefono"].ToString();
                txt_email.Text = leer["Email"].ToString();
                this.datefechaventa.Text = leer["Fecha"].ToString();
                comboproducto.Text = leer["Producto"].ToString();
                txt_conCant.Text = leer["Cantidad"].ToString();
                txt_PU.Text = leer["PrecioUnitario"].ToString();
                //txt_subtotal.Text = leer["SubTotal"].ToString();

                lbl_con.Text = leer["IdCo"].ToString();

                //comInfo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //comInfo.AutoCompleteSource = AutoCompleteSource.ListItems; 

            }
            else
            {
                //MessageBox.Show("No se encontro");

                txt_nombre.Text = "";
                txt_rfc.Text = "";
                txt_direccion.Text = "";
                txt_telefono.Text = "";
                txt_email.Text = "";
                this.datefechaventa.Text = "";
                comboproducto.Text = "";

                txt_PU.Text = "";

            }
            cnn.Close();
        }

        private void Form_ventas_Load(object sender, EventArgs e)
        {
            ConexionItem cliente = new ConexionItem();
            cliente.ItemCotizacion(combocliente);

            cliente.ItemProducto(comboproducto);
            /*  try
              {
                  OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
                  string query;

                  if (cnn.State == ConnectionState.Closed)
                  {
                      cnn.Open();
                  }
                  query = "select max(Folio) from Ventas";
                  //com = new OleDbCommand(str, connection);
                  OleDbCommand comando = new OleDbCommand(query, cnn);
                  comando.CommandType = CommandType.Text;
                  Int32 max = (Int32)comando.ExecuteScalar();
                  txt_folio.Text = (max + 1).ToString();
                  cnn.Close();
              }
              catch (Exception ex)
              {
                  //cnn.Close();
                  MessageBox.Show("error " + ex);
              } */

            panelcolor.BackColor = Color.FromArgb(90, Color.Black);

            groupFormadepago.BackColor = Color.FromArgb(50, Color.LimeGreen);

        }

        private void comboproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* string cadena = "Select * from ProductoTB where Producto ='" + comboproducto.Text + "' ";

             OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
             OleDbCommand comando = new OleDbCommand(cadena, cnn);
             cnn.Open();

             OleDbDataReader leer = comando.ExecuteReader();
             if (leer.Read() == true)
             {
                 //MessageBox.Show("El registro se a encontrado");

                 //txt_nombre.Text = leer["Nombre"].ToString();
                 lbl_conCant.Text = leer["Cantidad"].ToString();
                 txt_PU.Text = leer["Precio"].ToString();
                 //txt_telefono.Text = leer["Telefono"].ToString();
                 //txt_email.Text = leer["Email"].ToString();
                 //this.datefechacliente.Text = leer["FechaCliente"].ToString();
                 //lbl_conCant.Text = leer["@id"].ToString();

                 //comInfo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                 //comInfo.AutoCompleteSource = AutoCompleteSource.ListItems; 

             }
             else
             {
                 //MessageBox.Show("No se encontro");

                 //txt_nombre.Text = "";
                 lbl_conCant.Text = "...";
                 txt_PU.Text = "";
                 //txt_telefono.Text = "";
                 //txt_email.Text = "";
             }
             cnn.Close(); */
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand com = new OleDbCommand();
                OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
                cnn.Open();
                com.Connection = cnn;
                com.CommandText = "insert into VentasTemporalesTB (Producto, Cantidad, Precio) VALUES ('" + comboproducto.Text + "','" + txt_conCant.Text + "','" + txt_PU.Text + "')";
                com.ExecuteNonQuery();
                //MessageBox.Show("Cliente guardado exitosamente");
                cnn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo guardar " + ex);
            }

            try
            {
                OleDbCommand com = new OleDbCommand();
                OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
                cnn.Open();
                com.Connection = cnn;
                string query = "select Producto, Cantidad, Precio from VentasTemporalesTB";
                com.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataMostrarInfo.DataSource = dt;
                com.Clone();
                cnn.Close();
            }
            catch (Exception ex)
            {
                //connection.Close();
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }

            try
            {
                OleDbCommand com = new OleDbCommand();
                OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PuntodeVentaBD.accdb");
                cnn.Open();
                com.Connection = cnn;
                //string IdProducto = Convert.ToString(txtIdProducto.Text);
                com.CommandText = "insert into DetalleVentaTB (Cantidad, Precio) VALUES ('" + txt_conCant.Text + "','" + txt_PU.Text + "')";
                com.ExecuteNonQuery();
                MessageBox.Show("Venta guardada exitosamente");
                cnn.Close();
            }
            catch (Exception ex)
            {
                //connection.Close();
                MessageBox.Show("error " + ex);
            }

            double subtotal = 0;
            double iva = 0;

            foreach (DataGridViewRow row in dataMostrarInfo.Rows)
            {
                subtotal += Convert.ToDouble(row.Cells["Precio"].Value);
            }
            txt_subtotal.Text = Convert.ToString(subtotal);

            if (checkB_iva.Checked == true)
            {
                iva += Convert.ToDouble(subtotal * 0.16);
                txt_total.Text = Convert.ToString(iva + subtotal);
            }
            else
            {
                txt_total.Text = Convert.ToString(subtotal);
            }
        }

        private void checkB_iva_CheckedChanged(object sender, EventArgs e)
        {
            if (checkB_iva.Checked == false)
            {
                double subtotal = Convert.ToDouble(txt_subtotal.Text);
                txt_iva.Text = "0";
                txt_total.Text = Convert.ToString(subtotal);
            }
            else if (txt_subtotal.Text != "")
            {
                double subtotal = Convert.ToDouble(txt_subtotal.Text);
                double iva = 0;
                txt_iva.Text = "16";
                iva += Convert.ToDouble(subtotal * 0.16);
                txt_total.Text = Convert.ToString(iva + subtotal);
            }
            else
            {
                txt_iva.Text = "16";
            }
        }

        private void numericCantidad_ValueChanged(object sender, EventArgs e)
        {
            /* double Precio = Convert.ToDouble(txt_Precio.Text);
             int Cantidad = Convert.ToInt32(txt_conCant.Text);
             double P_unitario = Convert.ToDouble(txt_PU.Text);

             txt_conCant.Text = Convert.ToString(numericCantidad.Value);

             Cantidad = Cantidad + 1;

             if (numericCantidad.Value < Cantidad)
             {
                 P_unitario = P_unitario - Precio;
                 txt_PU.Text = Convert.ToString(P_unitario);
             }
             else if (numericCantidad.Value > 1)
             {
                 P_unitario = P_unitario + Precio;
                 txt_PU.Text = Convert.ToString(P_unitario);
                 Cantidad = Cantidad - 1;
             }  */
        }

        private void btn_venta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por su compra...imprimiendo reporte");

            PdF();
        }
        private void PdF()
        {
            Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:";
            saveFileDialog1.Title = "Guardar Reporte";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            string filename = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
            }

            if (filename.Trim() != "")
            {

                FileStream file = new FileStream(filename,
                FileMode.OpenOrCreate,
                FileAccess.ReadWrite,
                FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();
                string remito = "Autorizo: Juanelc197";
                string envio = "Fecha:" + DateTime.Now.ToString();

                Chunk chunk = new Chunk("Reporte de General Usuarios", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
                doc.Add(new Paragraph(chunk));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph("N.L"));
                doc.Add(new Paragraph(remito));
                doc.Add(new Paragraph(envio));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                GenerarDocumento(doc);
                doc.AddCreationDate();
                doc.Add(new Paragraph("______________________________________________", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
                doc.Add(new Paragraph("Firma", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
                doc.Close();
                Process.Start(filename);//Esta parte se puede omitir, si solo se desea guardar el archivo, y que este no se ejecute al instante
            }
        }

        public void GenerarDocumento(Document document)
        {
            int i, j;
            PdfPTable datatable = new PdfPTable(dataMostrarInfo.ColumnCount);
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetTamañoColumnas(dataMostrarInfo);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (i = 0; i < dataMostrarInfo.ColumnCount; i++)
            {
                datatable.AddCell(dataMostrarInfo.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            for (i = 0; i < dataMostrarInfo.Rows.Count; i++)
            {
                for (j = 0; j < dataMostrarInfo.Columns.Count; j++)
                {
                    if (dataMostrarInfo[j, i].Value != null)
                    {
                        datatable.AddCell(new Phrase(dataMostrarInfo[j, i].Value.ToString()));//En esta parte, se esta agregando un renglon por cada registro en el datagrid
                    }
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }

        public float[] GetTamañoColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Frm_Menu from = new Frm_Menu();
            from.Show();
            this.Close();
        }
    }
}
