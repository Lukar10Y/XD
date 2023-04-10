using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenDockUp
{
    public partial class FormAgregarVendedor : Form
    {
        /*private Usuario _empleadoAgregado = new Usuario();*/
        private List<Usuario> _listaEmpleados = new List<Usuario>();
        private string _pathEmpleados = "";

        public string PathEmpleados { set { _pathEmpleados = value; } get { return _pathEmpleados; } }
        public List<Usuario> ListaEmpleados { set { _listaEmpleados = value; } get { return _listaEmpleados; } }
        public FormAgregarVendedor()
        {
            InitializeComponent();
        }
        private bool CedulaRepetida()
        {
            bool Repetido = false;
            for (int i = 0; i < _listaEmpleados.Count; i++)
            {
                if (_listaEmpleados[i].Cedula == txtCI.Text)
                {
                    Repetido = true;
                    break;
                }
            }
            return Repetido;
        }
        private bool DatoRepetido()
        {
            //Se recorre La Lista de Usuarios, y si el Nombre de usuario llegase a repetirse se retorna un True

            bool Repetido = false;
            for (int i = 0; i < ListaEmpleados.Count; i++)
            {
                if (ListaEmpleados[i].NombreUsuario == txtCI.Text) Repetido = true;
            }
            return Repetido;
        }
        private void GuardarEmpleados()
        {
            string empleadosJson = JsonConvert.SerializeObject(ListaEmpleados.ToArray(), Formatting.Indented);
            File.WriteAllText(_pathEmpleados, empleadosJson);
            MessageBox.Show("Guardado Exitosamente");
        }
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (CedulaRepetida()) MessageBox.Show("La Cedula Introducida ya esta registrada en la base de Datos");
            else if(DatoRepetido()) MessageBox.Show("Nombre de Usuario ya registrado en la base de Datos");
            else
            {
                _listaEmpleados.Add(new Usuario(txtNombre.Text,txtApellido.Text,txtCI.Text));
                GuardarEmpleados();
                Close();
            }
        }

       /* private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CedulaRepetida()) MessageBox.Show("La Cedula Introducida ya esta registrada en la base de Datos");
            else
            {
                _empleadoAgregado.Nombre = txtNombre.Text;
                _empleadoAgregado.Apellido = txtApellido.Text;
                _empleadoAgregado.Cedula = txtCI.Text;
                _listaEmpleados.Add(_empleadoAgregado);
                GuardarEmpleados();
            }
            Close();
        }*/
    }
}
