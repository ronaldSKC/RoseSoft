﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoseSoft
{
    public partial class registrarCliente : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        ValidarSoloLetrasSoloNumeros validar = new ValidarSoloLetrasSoloNumeros();
        public registrarCliente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void registrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdentificacion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtNacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validar.VerificarCedula(txtIdentificacion.Text) == true)
            {
                string consutar = bd.selectstring("select cedula from CLIENTEN WHERE cedula =" + txtIdentificacion.Text + "");
                string agregar = "INSERT INTO CLIENTEN (cedula, nombres, apellidos, nacionalidad, paisCN, ciudadCN, direccionCN, telefonoCN, emailCN ) VALUES ('" + txtIdentificacion.Text + "','" + txtNombre.Text + "','" + txtApellidos.Text + "','" + txtNacionalidad.Text + "','" + txtPais.Text + "','" + txtCiudad.Text + "','" + txtDireccion.Text + "','" + txtTelefono.Text + "','" + txtEmail.Text + "')";

                if (txtNombre.Text.Equals("") || txtIdentificacion.Text.Equals("") || txtNacionalidad.Text.Equals("") || txtEmail.Text.Equals("")||
                txtApellidos.Text.Equals("") || txtPais.Text.Equals("") || txtCiudad.Text.Equals("") || txtDireccion.Text.Equals("") || txtTelefono.Text.Equals(""))
                {
                    MessageBox.Show("Error uno o mas campos vacios");
                }

                else
                {
                    if (consutar == txtIdentificacion.Text)
                    {

                        MessageBox.Show("DATOS YA REGISTRADOS");
                    }
                    else
                    {
                        if (bd.executecommand(agregar))
                        {
                            
                            string strDate = DateTime.Now.ToString("yyyy-MM-dd");
                            MessageBox.Show("Registrado");
                            txtIdentificacion.Text = "";
                            txtApellidos.Text = "";
                            txtNombre.Text = "";
                            txtCiudad.Text = "";
                            txtDireccion.Text = "";
                            txtNacionalidad.Text = "";
                            txtPais.Text = "";
                            txtTelefono.Text = "";
                            txtEmail.Text = "";
                            string nuevo = bd.selectstring(" INSERT INTO CLIENTENUEVO (fechaEmision) VALUES  ('" + strDate + "')");


                        }
                        else
                        {

                            MessageBox.Show("Error al agregar");

                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("cedula de identidad no valida");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Text = "";
            txtApellidos.Text = "";
            txtNombre.Text = "";
            txtCiudad.Text = "";
            txtDireccion.Text = "";
            txtNacionalidad.Text = "";
            txtPais.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
