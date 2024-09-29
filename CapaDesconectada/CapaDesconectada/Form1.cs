using AccesoDatos;
using CapaDesconectada.NorthwindTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDesconectada
{
    public partial class Form1 : Form
    {
        
        #region No Tipado 
        private CustomerRepositoryss customerRepository = new CustomerRepositoryss();
        private void btnObtenernoTipado_Click(object sender, EventArgs e)
        {


            GridnoTipado.DataSource = customerRepository.ObtenerTodos();
        }
        private void btnBuscarNT_Click(object sender, EventArgs e)
        {
            var cliente = customerRepository.ObtenerPorID(tbBusquedaNT.Text);
        }

        private void btnInsertarCliente_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            int insertados = customerRepository.InsertarCliente(cliente);
            MessageBox.Show($"{insertados} registrados");
        }

        private Customer CrearCliente()
        {
            var cliente = new Customer
            {
                CustomerID = txtbCustomerID.Text,
                CompanyName = textbompanyName.Text,
                ContactName = txtbContactname.Text,
                ContactTitle = txtbContacttitle.Text,
                Address = txtbAdress    .Text,
            };
            MessageBox.Show(cliente.CustomerID);
            MessageBox.Show(cliente.CompanyName);
            MessageBox.Show(cliente.ContactName);
            MessageBox.Show(cliente.ContactTitle);
            MessageBox.Show(cliente.Address);
            return cliente;
        }



        private void btnActualizarNT_Click(object sender, EventArgs e)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                var cliente = CrearCliente();
                var actulaixadas = customerRepository.ActualizarCliente(cliente);
                MessageBox.Show($"{actulaixadas} filas actulizadas");

            }
        }
        #endregion


        #region tipado  
        CustomersTableAdapter adaptador = new CustomersTableAdapter();
        private void btnObtenerTipado_Click(object sender, EventArgs e)
        {
            var customers = adaptador.GetData();
            GridTipado.DataSource = customers;
        }

        private void btnBuscarT_Click(object sender, EventArgs e)
        {
            var customer = adaptador.GetDataByCustomerID(txtBuscarT.Text);
            if (customer != null)
            {
                var objeto1 = customerRepository.ExtraerInformacionCliente(customer);
                RellenarForm(objeto1);
                Console.WriteLine(customer);
            }       
        }
        private void btnInsertarT_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            int insertados = adaptador.Insert(cliente.CustomerID, cliente.CompanyName, cliente.ContactName, cliente.ContactTitle, cliente.Address, cliente.City, cliente.Region, cliente.PostalCode, cliente.Country, cliente.Phone,
                cliente.Fax );
            MessageBox.Show($"{insertados} registrados");

        }
        private void btnActualzarT_Click(object sender, EventArgs e)
        {
            var fila = adaptador.GetDataByCustomerID(txtbCustomerID.Text);

            if (fila != null)
            {
                var datoOriginal = customerRepository.ExtraerInformacionCliente(fila);
                var datosModificados = CrearCliente();
                var filas = adaptador.Update(
                    datosModificados.CustomerID,
                    datosModificados.CompanyName,
                    datosModificados.ContactName,
                    datosModificados.ContactTitle,
                    datosModificados.Address,
                    datosModificados.City,
                    datosModificados.Region,
                    datosModificados.PostalCode,
                    datosModificados.Country,
                    datosModificados.Phone,
                    datosModificados.Fax,
                    datoOriginal.CustomerID,
                    datoOriginal.CompanyName,
                    datoOriginal.ContactName,
                    datoOriginal.ContactTitle,
                    datoOriginal.Address,
                    datoOriginal.City,
                    datoOriginal.Region,
                    datoOriginal.PostalCode,
                    datoOriginal.Country,
                    datoOriginal.Phone,
                    datoOriginal.Fax
                    );

                MessageBox.Show($"{filas} filas modificadas");
            }

        }
        private void RellenarForm(Customer cliente) 
        {
            if (cliente != null) 
            {
                txtbCustomerID.Text = cliente.CustomerID;
                textbompanyName.Text = cliente.CompanyName;
                txtbContactname.Text = cliente.ContactName;
                txtbContacttitle.Text = cliente.ContactTitle;
                txtbAdress.Text = cliente.Address;
            }

            if (cliente == null)
            {
                MessageBox.Show("objeto null ");
            }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        
    }
}
