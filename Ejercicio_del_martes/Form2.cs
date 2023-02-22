using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Xml.Linq;
using System.IO;
using System.Reflection;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace Practica
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void clearFind()
        {
            txtautor.Text=String.Empty;
            txtisbn.Text=String.Empty;
            txtpag.Text=String.Empty;
            txttitulo.Text=String.Empty;
            txtCantAlma.Text=String.Empty;
            txtpre.Text=String.Empty;


            txtisbn.Focus();
        }
        public void clearFind2()
        {
            txtautor.Text=String.Empty ;
            txtisbn.Text = String.Empty;
            txtpag.Text = String.Empty;
            cboLibro.SelectedIndex = -1;
            lblpre.Text = String.Empty;
            txtCantAlma.Text = String.Empty;
            txtisbn.Focus();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Libro lb=new Libro();
            lb.ISBN1 = int.Parse(txtisbn.Text);
            lb.Autor = txttitulo.Text;
            lb.Titulo = txtautor.Text;
            lb.NPag1 = int.Parse(txtpag.Text);
            lb.Precio = double.Parse(txtpre.Text);
            lb.CantAlmac1 = int.Parse(txtCantAlma.Text);

            if (txtautor.Text == "" || txtisbn.Text == "" || txtpag.Text == "" || txttitulo.Text == "")
            {
                MessageBox.Show("Verifique los campos en Blanco...");
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (txtisbn.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {

                        MessageBox.Show("Codigo repetido");
                        txtisbn.Clear();
                        return;

                    }
                }
              
                string[] datos = new string[6];

                datos[0] = lb.ISBN1.ToString();
                datos[1] = lb.Titulo ;
                datos[2] = lb.Autor;
                datos[3] = lb.CantAlmac1.ToString();
                datos[4] = lb.Precio.ToString();
                datos[5] = lb.NPag1.ToString();

                dataGridView1.Rows.Add(datos);
                clearFind();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            clearFind();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            /*foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                String strFila = Row.Index.ToString();
               string valor = Convert.ToString(Row.Cells["ISBN"].Value);

                if (valor == this.txtbuscar.Text)
                {
                    dataGridView1.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.Yellow;
                    
                    
                }
            }
            */
        }
        int strFila =0;
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtbuscar.Text == "")
            {
                dataGridView1.DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                foreach (DataGridViewRow Row in dataGridView1.Rows)
                {


                    strFila = Convert.ToInt32(Row.Index.ToString());
                    string valor = Convert.ToString(Row.Cells["ISBN"].Value);
                    string valor2 = Convert.ToString(Row.Cells["Producto"].Value);
                    if (valor == this.txtbuscar.Text || valor2 == this.txtbuscar.Text)
                    {
                        this.dataGridView1.CurrentCell = null;

                        int f = dataGridView1.RowCount;
                        for (int i = f - 1; i >= 0; i--)
                        {
                            this.dataGridView1.CurrentCell = null;
                            this.dataGridView1.Rows[i].Visible = false;
                            this.dataGridView1.Rows[strFila].Visible = true;
                        }
                        dataGridView1.Rows[strFila].DefaultCellStyle.BackColor = Color.Green;
                        chBuscar.Checked = false;
                        txtbuscar.Text = String.Empty;
                        txtbuscar.Enabled = false;
                    }
                }
            }
        }
        public void clean()
        {
            int f = dataGridView1.RowCount;
            for (int i = f - 1; i >= 0; i--)
            {
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
            for (int i = f - 1; i >= 0; i--)
            {
                this.dataGridView1.CurrentCell = null;
                this.dataGridView1.Rows[i].Visible = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("𝓔𝓢𝓣𝓐 𝓢𝓔𝓖𝓤𝓡𝓞 𝓓𝓔 𝓢𝓐𝓛𝓘𝓡?",
                            "Registro Libros",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Libro ob = new Libro();
            ob.CantAlmac1 = int.Parse(txtCantAlma.Text);
            ob.Autor = txttitulo.Text;
            ob.Precio = preci;
            ob.Titulo = cboLibro.Text;
            ob.NPag1 = int.Parse(txtpag.Text);
            double co = double.Parse(txtisbn.Text);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (txtisbn.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
                {

                    MessageBox.Show("Codigo repetido");
                    txtisbn.Clear();
                    return;

                }
            }
            string[] dato = new string[7];
            dato[0] = co.ToString();
            dato[1] = ob.Titulo;
            dato[2] = ob.Autor;
            dato[3] = ob.CantAlmac1.ToString();
            dato[4] = ob.Precio.ToString();
            dato[5] = ob.NPag1.ToString();

            dataGridView1.Rows.Add(dato);
          //  clearFind2();



        }
        
        
        private void cboLibro_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
        }
        int preci = 0;


        private void cboLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string producto = cboLibro.Text;
            if (producto.Equals("Don Quijote de la Mancha")) preci = 1027;
            if (producto.Equals("Historias de dos Cuidades")) preci = 7020;
            if (producto.Equals("El Señor de los Anillos")) preci = 628;
            if (producto.Equals("El Principito")) preci = 726;
            if (producto.Equals("El Hobbit")) preci = 830;
            if (producto.Equals("Sueño en el pabellon Rojo")) preci = 505;
            if (producto.Equals("EL leon,la Bruja y el Armario")) preci = 1900;
            lblpre.Text = preci.ToString("C");

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            dataGridView1.AllowUserToAddRows = false;
            txtbuscar.Enabled = false;
            txtP.Enabled = false;
            txtC.Enabled = false;
            txtPreciooo.Enabled = false;
            txtPAgo.Enabled = false;
            RegistroDatos2.AllowUserToAddRows = false;
            dateTimePicker1.Visible = false;
            txtCDispo.Enabled = false;
            txtProducto.Enabled = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Libro met = new Libro();
            Calculos cal = new Calculos();

            string fecha;
            double cantidad, precio;
            fecha = dateTimePicker1.Text;
            met.Cliente = txtCliente.Text;
            met.Producto1 = txtProducto.Text;
            cantidad = Convert.ToDouble(txtCantidad.Text);
            met.Pago = double.Parse(txtPAgo.Text);
            met.Total = int.Parse(lblTotal.Text);
            int CantAvender = int.Parse(txtCantidad.Text);
            int cantidadDisponible = int.Parse(txtCDispo.Text);

            precio = Convert.ToDouble(lblPrecio.Text);
            lblTotal.Text = cal.TotalPrecio(precio, cantidad).ToString();


            if (CantAvender > cantidadDisponible)
            {
                MessageBox.Show("No hay suficiente cantidad disponible para la venta.", "Error de venta");
                // cboProducto.SelectedIndex = -1;
                txtCantidad.Clear();
                cboTipoDpago.SelectedIndex = -1;
                return;
            }
           
            string[] fac = new string[11];

            fac[0] = met.Cliente.ToString();
            fac[1] = txtCedula.Text;
            fac[2] = txtProducto.Text;
            fac[3] = Convert.ToString(cantidad);
            fac[4] = cboTipoDpago.Text;
            fac[5] = met.Pago.ToString();
            fac[6] = Convert.ToString(precio);
            fac[7] = lblTotal.Text;
            fac[8] = fecha;

            RegistroDatos2.Rows.Add(fac);
            clearFind2();

            txtCliente.Enabled = true;
         
            txtCantidad.Enabled = true;
            cboTipoDpago.Enabled = true;
            RegistroDatos2.Enabled = true;
            dateTimePicker1.Visible = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["titulo"].Value.ToString() == met.Producto1)
                {
                    row.Cells["CantidadAlmacen"].Value = cantidadDisponible - CantAvender;
                    break;
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtP.Text = dataGridView1.Rows[e.RowIndex].Cells["titulo"].Value.ToString();
            txtC.Text = dataGridView1.Rows[e.RowIndex].Cells["CantidadAlmacen"].Value.ToString();
            txtPreciooo.Text = dataGridView1.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
            txtProducto.Text = dataGridView1.Rows[e.RowIndex].Cells["titulo"].Value.ToString();
            lblPrecio.Text = dataGridView1.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
            txtCDispo.Text = dataGridView1.Rows[e.RowIndex].Cells["CantidadAlmacen"].Value.ToString();

            txtCliente.Enabled = true;
            
            txtCantidad.Enabled = true;
            cboTipoDpago.Enabled = true;
            RegistroDatos2.Enabled = true;
            dateTimePicker1.Visible = true;
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));



            //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", txtCliente.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CEDULA", txtCedula.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in RegistroDatos2.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Produ"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantid"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["TipoDpago"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PAgo"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioUNi"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["Total"].Value.ToString());
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());



            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //Agregamos la imagen del banner al documento
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.digital_library_logo_design_1c96fa, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    //pdfDoc.Add(new Phrase("Hola Mundo"));
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

            }
        }

        private void chBuscar_CheckedChanged(object sender, EventArgs e)
        {
            if (chBuscar.Checked == true)
            {
                txtbuscar.Enabled = true;
            }
        }

        private void btnLimpiarBusque_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void cboTipoDpago_SelectedIndexChanged(object sender, EventArgs e)
        {
            Libro metodos = new Libro();
            Calculos cal = new Calculos();

            double total;

            if (cboTipoDpago.SelectedIndex == 0)
            {
                txtPAgo.Enabled = true;
                txtPAgo.Text = "";
            }
            else
            {
                txtPAgo.Enabled = false;
                total = cal.Paago(Convert.ToDouble(lblTotal.Text));
                txtPAgo.Text = Convert.ToString(total);
              
                btnRegistrar.Enabled = true;
                btnFacturar.Enabled = true; 

            }
        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                lblTotal.Text = "0";
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (txtCantidad.Text == "")
                {
                    MessageBox.Show("Debe ingresar una cantidad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {


                    Calculos cal = new Calculos();

                    double cantidad, precio, total, cantidadn, nueva;
                    cantidadn = Convert.ToDouble(txtC.Text);
                    cantidad = Convert.ToDouble(txtCantidad.Text);
                    precio = Convert.ToDouble(lblPrecio.Text);
                    total = cal.Cambio(cantidad, precio);
                    lblTotal.Text = total.ToString();

                    nueva = cal.CantidadNueva(cantidadn, cantidad);
                    txtC.Text = Convert.ToString(nueva);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Libro mos = new Libro();
            double pag = Convert.ToDouble(txtpag.Text);
            txtDetalle.Text = mos.Mostrar(txtautor.Text, txtisbn.Text, txttitulo.Text, pag.ToString());
        }
    }
}
