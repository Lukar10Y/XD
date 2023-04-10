using Newtonsoft.Json;
using System;
using System.Data;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenDockUp;

namespace DatosEmpresa
{
    public partial class FormGestionDatosEmpresa : Form
    {
        private string _pathDatos = "";
        private string _pathEmpleados = "";
        private int aux = 0;
        private List<Usuario> _datosEmpleado = new List<Usuario>();
        private List<string> _datosEmpresa = new List<string>();

        FormAgregarVendedor Agregar = new FormAgregarVendedor();
        public FormGestionDatosEmpresa()
        {
            InitializeComponent();
        }
        public string PathEmpleados { set { _pathEmpleados = value;} get { return _pathEmpleados; } }
        public string PathDatos { set { _pathDatos = value; } get { return _pathDatos; } }
        public List<string> DatosEmpresa { set { _datosEmpresa = value; } get { return _datosEmpresa; } }
        public List<Usuario> Empleados { get { return _datosEmpleado;} set { _datosEmpleado = value; } }

        private void GuardarEmpleados()
        {
            string empleadosJson = JsonConvert.SerializeObject(_datosEmpleado.ToArray(), Formatting.Indented);
            File.WriteAllText(_pathEmpleados, empleadosJson);
            MessageBox.Show("Guardado Exitosamente");
        }
        private void LlenarTablaEmpleados()
        {
            if (_datosEmpleado.Count > 0)
            {
                for (int i = 1; i < _datosEmpleado.Count; i++)
                {
                    if (_datosEmpleado[i].NombreUsuario != "AdminS")
                    {
                        for (int j = 0; j < dtgvEmpleados.Columns.Count; j++)
                        {
                            if (j == 0) dtgvEmpleados[j, i-1].Value = _datosEmpleado[i].Nombre;
                            else if (j == 1) dtgvEmpleados[j, i-1].Value = _datosEmpleado[i].Apellido;
                            else if (j == 2) dtgvEmpleados[j, i-1].Value = _datosEmpleado[i].Cedula;
                        }
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            dtgvEmpleados.Rows.Clear();

            if(_datosEmpleado.Count > 1) dtgvEmpleados.Rows.Add(_datosEmpleado.Count-1);

            LlenarTablaEmpleados();

        }
        private void btnAgregarVen_Click(object sender, EventArgs e)
        {
            Agregar.PathEmpleados = _pathEmpleados;
            Agregar.ListaEmpleados = _datosEmpleado;

            Agregar.ShowDialog();

            dtgvEmpleados.Rows.Clear();

            if (_datosEmpleado.Count > 1) dtgvEmpleados.Rows.Add(_datosEmpleado.Count-1);

            LlenarTablaEmpleados();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _datosEmpresa.Clear();
            _datosEmpresa.Add(txtNomEmpresa.Text);
            _datosEmpresa.Add(txtRif.Text);
            _datosEmpresa.Add(txtDireccion.Text);
            _datosEmpresa.Add(txtCorreo.Text);
            string DatosEmpresaJson = JsonConvert.SerializeObject(_datosEmpresa.ToArray(), Formatting.Indented);
            File.WriteAllText(_pathDatos, DatosEmpresaJson);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (aux != -1 && dtgvEmpleados.Rows.Count > 0 && _datosEmpleado[aux+1].Cargo != "Administrador")
                {
                    dtgvEmpleados.Rows.RemoveAt(aux);
                    _datosEmpleado.RemoveAt(aux+1);
                    GuardarEmpleados();
                }
                else if(_datosEmpleado[aux].Cargo == "Administrador")
                {
                    throw new Exception("El Administrador No puede Ser Eliminado");
                }
                else
                {
                    throw new Exception("No se pueden eliminar más artículos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*private void lblEliminarCelda_Click(object sender, EventArgs e)
        {
            try
            {
                if (aux != -1 && dtgvEmpleados.Rows.Count > 0)
                {
                    dtgvEmpleados.Rows.RemoveAt(aux);
                }
                else
                {
                    throw new Exception("No se pueden eliminar más artículos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
        private void dtgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aux = e.RowIndex;
        }
    }
}