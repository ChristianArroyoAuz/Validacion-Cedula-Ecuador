using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Validacion_Cedula
{
    public partial class Validacion_Cedula : Form
    {
        List<Usuario> listaUsuarios = new List<Usuario>();
        int x = 1;
        int y = 2;
        string validacion;
        string aprobacion;

        public Validacion_Cedula()
        {
            InitializeComponent();
        }

        private void Validacion_Cedula_Load(object sender, EventArgs e)
        {
            Inicio();
        }

        public void Inicio()
        {
            etiquetaCedula.Enabled = false;
            etiquetaNombre.Enabled = false;
            etiquetaId.Enabled = false;
            Cedulatxt.Enabled = false;
            Nombretxt.Enabled = false;
            Idtxt.Enabled = false;
            lista_de_Cedulas.Enabled = false;
            botonEliminar.Enabled = false;
            botonValidar.Enabled = false;
            botonNuevo.Enabled = true;
        }

        public void Validar()
        {
            etiquetaCedula.Enabled = true;
            etiquetaNombre.Enabled = true;
            etiquetaId.Enabled = true;
            Cedulatxt.Enabled = true;
            Nombretxt.Enabled = true;
            Idtxt.Enabled = true;
            lista_de_Cedulas.Enabled = true;
            botonEliminar.Enabled = true;
            botonValidar.Enabled = true;
            botonNuevo.Enabled = false;
        }

        public bool ValidarLongitud()
        {
            if(Cedulatxt.Text.Length < 10 || Cedulatxt.Text.Length > 10)
            {
                MessageBox.Show("La Cedula Ingresada es Incorrecta, es demasiada larga o corta. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                string cedula = Cedulatxt.Text;
                char[] vector = cedula.ToArray();
                int sumatotal = 0;
                
                for (int i = 0; i < vector.Length - 1; i++)
                {
                    int numero = Convert.ToInt32(vector[i].ToString());
                    if ((i + 1) % 2 == 1)
                    {
                        numero = Convert.ToInt32(vector[i].ToString()) * 2;
                        if (numero > 9)
                        {
                            numero = numero - 9;
                        }
                    }
                    sumatotal += numero;
                }
                sumatotal = 10 - (sumatotal % 10);
                if (sumatotal > 9)
                {
                    validacion = "0";
                }
                else
                {
                    validacion =Convert.ToString(sumatotal);
                }

                if (Convert.ToString(vector[0]) == "0" && Convert.ToString(vector[1]) == "1" ||
                    Convert.ToString(vector[0]) == "0" && Convert.ToString(vector[1]) == "2" ||
                    Convert.ToString(vector[0]) == "0" && Convert.ToString(vector[1]) == "3" ||
                    Convert.ToString(vector[0]) == "0" && Convert.ToString(vector[1]) == "4" ||
                    Convert.ToString(vector[0]) == "0" && Convert.ToString(vector[1]) == "5" ||
                    Convert.ToString(vector[0]) == "0" && Convert.ToString(vector[1]) == "6" ||
                    Convert.ToString(vector[0]) == "0" && Convert.ToString(vector[1]) == "7" ||
                    Convert.ToString(vector[0]) == "0" && Convert.ToString(vector[1]) == "8" ||
                    Convert.ToString(vector[0]) == "0" && Convert.ToString(vector[1]) == "9" ||
                    Convert.ToString(vector[0]) == "1" && Convert.ToString(vector[1]) == "0" ||
                    Convert.ToString(vector[0]) == "1" && Convert.ToString(vector[1]) == "1" ||
                    Convert.ToString(vector[0]) == "1" && Convert.ToString(vector[1]) == "2" ||
                    Convert.ToString(vector[0]) == "1" && Convert.ToString(vector[1]) == "3" ||
                    Convert.ToString(vector[0]) == "1" && Convert.ToString(vector[1]) == "4" ||
                    Convert.ToString(vector[0]) == "1" && Convert.ToString(vector[1]) == "5" ||
                    Convert.ToString(vector[0]) == "1" && Convert.ToString(vector[1]) == "6" ||
                    Convert.ToString(vector[0]) == "1" && Convert.ToString(vector[1]) == "7" ||
                    Convert.ToString(vector[0]) == "1" && Convert.ToString(vector[1]) == "8" ||
                    Convert.ToString(vector[0]) == "1" && Convert.ToString(vector[1]) == "9" ||
                    Convert.ToString(vector[0]) == "2" && Convert.ToString(vector[1]) == "0" ||
                    Convert.ToString(vector[0]) == "2" && Convert.ToString(vector[1]) == "1" ||
                    Convert.ToString(vector[0]) == "2" && Convert.ToString(vector[1]) == "2" ||
                    Convert.ToString(vector[0]) == "2" && Convert.ToString(vector[1]) == "3" ||
                    Convert.ToString(vector[0]) == "2" && Convert.ToString(vector[1]) == "4" )
                {
                    if (Convert.ToString(vector[2]) == "0" || Convert.ToString(vector[2]) == "1" || 
                        Convert.ToString(vector[2]) == "2" || Convert.ToString(vector[2]) == "3" || 
                        Convert.ToString(vector[2]) == "4" || Convert.ToString(vector[2]) == "5")
                    {
                        if (Convert.ToString(vector[9]) == validacion)
                        {
                            MessageBox.Show("Datos Guardados con Exito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            aprobacion = "Cedula Correcta";
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Cedula Incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            aprobacion = "Cedula Incorrecta";
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cedula Incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        aprobacion = "Cedula Incorrecta";
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Cedula Incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    aprobacion = "Cedula Incorrecta";
                    return false;
                }
            }
        }

        public void Eliminar()
        {
            if(lista_de_Cedulas.Items.Count > 0)
            {
                botonEliminar.Enabled = true;
            }
            else
            {
                botonEliminar.Enabled = false;
            }
        }

        public void Limpiar()
        {
            Nombretxt.Clear();
            Cedulatxt.Clear();
            lista_de_Cedulas.Items.Clear();
        }

        public void Guardar()
        {
            foreach(var usuarios in listaUsuarios)
            {
                lista_de_Cedulas.Items.Add(usuarios);
            }
        }

        private void Nombretxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                        MessageBox.Show("Introducir solo letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
            catch (Exception)
            {
            }
        }

        private void Cedulatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                        MessageBox.Show("Introducir solo numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
            catch (Exception)
            {
            }
        }

        private void Nombretxt_LostFocus(object sender, EventArgs e)
        {
            if(Nombretxt.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Cedulatxt_LostFocus(object sender, EventArgs e)
        {
            if (Cedulatxt.Text == "")
            {
                MessageBox.Show("Debe ingresar la cedula", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void botonNuevo_Click(object sender, EventArgs e)
        {
            Validar();
            Eliminar();
        }
        
        private void botonValidar_Click(object sender, EventArgs e)
        {
            if (Nombretxt.Text == "" || Cedulatxt.Text == "")
            {
                MessageBox.Show("Debe llenar todos los espacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                if (ValidarLongitud() == true)
                {
                    Usuario validarUsuario = new Usuario(x++, Nombretxt.Text, Convert.ToInt64(Cedulatxt.Text), aprobacion);
                    listaUsuarios.Add(validarUsuario);
                    Idtxt.Text = Convert.ToString(y++);
                    Limpiar();
                    Guardar();
                    Inicio();
                }
            }       
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro desea borrar el Usuario", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resultado == DialogResult.Yes )
            {
                Usuario borrar = (Usuario)lista_de_Cedulas.SelectedItem;
                lista_de_Cedulas.Items.Remove(borrar);
                listaUsuarios.Remove(borrar);
                Eliminar();
            }
            else
            {
                return;
            }
        }

        private void lista_de_Cedulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Usuario user in lista_de_Cedulas.SelectedItems)
            {
                Idtxt.Text = Convert.ToString(user.Id);
                Nombretxt.Text = user.Nombre;
                Cedulatxt.Text = Convert.ToString(user.Cedula);
            }
        }
    }
}
