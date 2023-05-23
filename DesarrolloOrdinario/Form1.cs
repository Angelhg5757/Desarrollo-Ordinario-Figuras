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

namespace DesarrolloOrdinario
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=LAPTOP-36NNJN45\ANGELSERVER;Initial Catalog=desarrollo;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            areas area = new areas();
            area.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            volumenes volumen = new volumenes();
            volumen.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'desarrolloDataSet.puntajes' Puede moverla o quitarla según sea necesario.
            this.puntajesTableAdapter.Fill(this.desarrolloDataSet.puntajes);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta para verificar si el campo "total" está vacío
                    string selectQuery = "SELECT total FROM puntajes WHERE id = (SELECT MAX(id) FROM puntajes)";

                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                    {
                        object total = selectCommand.ExecuteScalar();

                        if (total == DBNull.Value)
                        {
                            // El campo "total" está vacío, se puede realizar la actualización
                            // Realiza la suma de puntajeAreas y puntajeVolumenes y actualiza el campo "total"
                            string updateQuery = "UPDATE puntajes SET total = puntajeAreas + puntajeVolumenes WHERE id = (SELECT MAX(id) FROM puntajes)";

                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.ExecuteNonQuery();
                            }
                            this.Refresh();
                            puntajesTableAdapter.Fill(this.desarrolloDataSet.puntajes);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nombreUsuario = textBox1.Text;

            if (!string.IsNullOrEmpty(nombreUsuario))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "INSERT INTO puntajes (nombre) VALUES (@nombre)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@nombre", nombreUsuario);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Usuario registrado", "Agregado");
                    puntajesTableAdapter.Fill(this.desarrolloDataSet.puntajes);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el usuario: " + ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de usuario", "Error");
            }
            this.Refresh();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar todos los registros?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Eliminar los registros de la base de datos
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "DELETE FROM puntajes";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }

                    // Refrescar el DataGridView
                    puntajesTableAdapter.Fill(this.desarrolloDataSet.puntajes);

                    // Mostrar un MessageBox de éxito
                    MessageBox.Show("Registros eliminados correctamente", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Mostrar un MessageBox de error en caso de fallo
                    MessageBox.Show("Error al eliminar los registros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}