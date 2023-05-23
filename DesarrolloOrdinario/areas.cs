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
    public partial class areas : Form
    {
        private int lado = 2;
        private int lado2 = 12;
        private int areaTotal;
        private int areaTotal2;
        private decimal areaTotal3;
        private decimal areaTotal4;
        public int puntaje;
        public int contadorPreguntas = 5;
        public int lado_1;
        public int lado_2;
        public areas()
        {
            InitializeComponent();

            // Genera un número aleatorio para el lado del cuadrado
            //Random rand = new Random();
            //lado = rand.Next(1, 8);
            //lado2 = rand.Next(9, 15);
            lado_1 = lado;
            lado_2 = lado2;
            Console.WriteLine("lado1" + lado_1);
            Console.WriteLine("lado2" + lado_2);
            areaTotal = lado * lado;
            areaTotal2 = lado * lado2;
            areaTotal3 = (decimal)(lado * lado2) / 2;
            areaTotal4 = (decimal)(Math.PI * lado * lado);
            areaTotal4 = Math.Round(areaTotal4, 2);

            label8.Text = "Calcula el área de un cuadrado de " + lado_1 + " cm de lado.";
            label6.Text = lado_1 + " cm";

            label13.Text = "Calcula el área de un rectángulo de base " + lado_2 + " cm" + " y con altura de " 
                + lado_1 + " cm.";
            label15.Text = lado_1 + " cm";
            label16.Text = lado_2 + " cm";

            label22.Text = "Calcula el área de un triángulo de base " + lado_1 + " cm" + " y con altura de "
                + lado_2 + " cm. \nOcupe un decimal después del punto.";
            label19.Text = lado_1 + " cm";
            label24.Text = lado_2 + " cm";

            label30.Text = "Calcula el área de un circulo con radio de " + lado_1 
                + " cm. \nRedondea el resultado a dos decimales. Utiliza el valor completo de π";
            label32.Text = lado_1 + " cm";
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            int respuesta;

            // Intenta convertir el texto en el cuadro de texto en un número entero
            if (int.TryParse(txtCuadrado.Text, out respuesta))
            {
                // Comprueba si la respuesta es correcta
                if (respuesta == areaTotal)
                {
                    MessageBox.Show("Respuesta correcta");
                    label10.Text = "A = " + lado_1 + " x " + lado_1 + " = " + areaTotal;
                    label10.Visible = true;
                    contadorPreguntas--;
                    puntaje += 10;
                    Console.WriteLine(puntaje);
                    Console.WriteLine(contadorPreguntas);
                    if (contadorPreguntas == 0)
                    {
                        MessageBox.Show("¡Ha obtenido su puntaje! \nPuntaje obtenido: " + puntaje);

                        string connectionString = @"Data Source=LAPTOP-36NNJN45\ANGELSERVER;Initial Catalog=desarrollo;Integrated Security=True;";

                        // Consulta para actualizar el puntaje en la última fila de la tabla
                        string updateQuery = "UPDATE puntajes SET puntajeAreas = @puntaje WHERE id = (SELECT MAX(id) FROM puntajes)";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            // Crear el comando SQL
                            using (SqlCommand command = new SqlCommand(updateQuery, connection))
                            {
                                // Pasar el valor del puntaje como parámetro
                                command.Parameters.AddWithValue("@puntaje", puntaje);

                                // Ejecutar la consulta
                                command.ExecuteNonQuery();
                            }
                        }

                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Respuesta incorrecta, intente nuevamente", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    contadorPreguntas--;
                    Console.WriteLine(puntaje);
                    Console.WriteLine(contadorPreguntas);
                    btnReiniciar_Click(sender, e);
                    if (contadorPreguntas == 0)
                    {
                        MessageBox.Show("¡Ha obtenido su puntaje! \nPuntaje obtenido: " + puntaje);

                        string connectionString = @"Data Source=LAPTOP-36NNJN45\ANGELSERVER;Initial Catalog=desarrollo;Integrated Security=True;";

                        // Consulta para actualizar el puntaje en la última fila de la tabla
                        string updateQuery = "UPDATE puntajes SET puntajeAreas = @puntaje WHERE id = (SELECT MAX(id) FROM puntajes)";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            // Crear el comando SQL
                            using (SqlCommand command = new SqlCommand(updateQuery, connection))
                            {
                                // Pasar el valor del puntaje como parámetro
                                command.Parameters.AddWithValue("@puntaje", puntaje);

                                // Ejecutar la consulta
                                command.ExecuteNonQuery();
                            }
                        }

                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar un valor numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            // Genera un nuevo número aleatorio para el lado del cuadrado
            Random rand = new Random();
            lado = rand.Next(1, 10);
            lado_1 = lado;
            areaTotal = lado * lado;

            label8.Text = "Calcula el área de un cuadrado de " + lado_1 + " cm de lado.";
            label6.Text = lado_1 + " cm";

            txtCuadrado.Text = string.Empty;
            label10.Visible = false;
        }

        private void areas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int respuesta2;

            // Intenta convertir el texto en el cuadro de texto en un número entero
            if (int.TryParse(txtRectangulo.Text, out respuesta2))
            {
                // Comprueba si la respuesta es correcta
                if (respuesta2 == areaTotal2)
                {
                    MessageBox.Show("Respuesta correcta", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label11.Text = "A = " + lado_1 + " x " + lado_2 + " = " + areaTotal2;
                    label11.Visible = true;
                    contadorPreguntas--;
                    puntaje += 10;
                    Console.WriteLine(puntaje);
                    Console.WriteLine(contadorPreguntas);
                    if (contadorPreguntas == 0)
                    {
                        MessageBox.Show("¡Ha obtenido su puntaje! \nPuntaje obtenido: " + puntaje);

                        string connectionString = @"Data Source=LAPTOP-36NNJN45\ANGELSERVER;Initial Catalog=desarrollo;Integrated Security=True;";

                        // Consulta para actualizar el puntaje en la última fila de la tabla
                        string updateQuery = "UPDATE puntajes SET puntajeAreas = @puntaje WHERE id = (SELECT MAX(id) FROM puntajes)";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            // Crear el comando SQL
                            using (SqlCommand command = new SqlCommand(updateQuery, connection))
                            {
                                // Pasar el valor del puntaje como parámetro
                                command.Parameters.AddWithValue("@puntaje", puntaje);

                                // Ejecutar la consulta
                                command.ExecuteNonQuery();
                            }
                        }

                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Respuesta incorrecta, intente nuevamente", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    contadorPreguntas--;
                    button1_Click(sender, e);
                    if (contadorPreguntas == 0)
                    {
                        MessageBox.Show("¡Ha obtenido su puntaje! \nPuntaje obtenido: " + puntaje);

                        string connectionString = @"Data Source=LAPTOP-36NNJN45\ANGELSERVER;Initial Catalog=desarrollo;Integrated Security=True;";

                        // Consulta para actualizar el puntaje en la última fila de la tabla
                        string updateQuery = "UPDATE puntajes SET puntajeAreas = @puntaje WHERE id = (SELECT MAX(id) FROM puntajes)";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            // Crear el comando SQL
                            using (SqlCommand command = new SqlCommand(updateQuery, connection))
                            {
                                // Pasar el valor del puntaje como parámetro
                                command.Parameters.AddWithValue("@puntaje", puntaje);

                                // Ejecutar la consulta
                                command.ExecuteNonQuery();
                            }
                        }

                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar un valor numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            lado = rand.Next(1, 8);
            lado2 = rand.Next(9, 15);
            lado_1 = lado;
            lado_2 = lado2;
            areaTotal2 = lado * lado2;

            label13.Text = "Calcula el área de un rectángulo de base " + lado2 + " cm" + " y con altura de "
                + lado + " cm";
            label15.Text = lado + " cm";
            label16.Text = lado2 + " cm";

            txtRectangulo.Text = string.Empty;
            label11.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal respuesta;
            if (decimal.TryParse(txtTriangulo.Text, out respuesta))
            {
                respuesta = Math.Round(respuesta, 2);
                if (respuesta == areaTotal3)
                {
                    MessageBox.Show("Respuesta correcta", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label20.Text = "A = (" + lado_1 + "x" + lado_2 + ") / 2 = " + areaTotal3.ToString("0.##");
                    label20.Visible = true;
                    contadorPreguntas--;
                    puntaje += 10;
                    Console.WriteLine(puntaje);
                    Console.WriteLine(contadorPreguntas);
                    if (contadorPreguntas == 0)
                    {
                        MessageBox.Show("¡Ha obtenido su puntaje! \nPuntaje obtenido: " + puntaje);

                        string connectionString = @"Data Source=LAPTOP-36NNJN45\ANGELSERVER;Initial Catalog=desarrollo;Integrated Security=True;";

                        // Consulta para actualizar el puntaje en la última fila de la tabla
                        string updateQuery = "UPDATE puntajes SET puntajeAreas = @puntaje WHERE id = (SELECT MAX(id) FROM puntajes)";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            // Crear el comando SQL
                            using (SqlCommand command = new SqlCommand(updateQuery, connection))
                            {
                                // Pasar el valor del puntaje como parámetro
                                command.Parameters.AddWithValue("@puntaje", puntaje);

                                // Ejecutar la consulta
                                command.ExecuteNonQuery();
                            }
                        }

                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Respuesta incorrecta, intente nuevamente", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    contadorPreguntas--;
                    Console.WriteLine(puntaje);
                    Console.WriteLine(contadorPreguntas);
                    button3_Click(sender, e);
                    if (contadorPreguntas == 0)
                    {
                        MessageBox.Show("¡Ha obtenido su puntaje! \nPuntaje obtenido: " + puntaje);

                        string connectionString = @"Data Source=LAPTOP-36NNJN45\ANGELSERVER;Initial Catalog=desarrollo;Integrated Security=True;";

                        // Consulta para actualizar el puntaje en la última fila de la tabla
                        string updateQuery = "UPDATE puntajes SET puntajeAreas = @puntaje WHERE id = (SELECT MAX(id) FROM puntajes)";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            // Crear el comando SQL
                            using (SqlCommand command = new SqlCommand(updateQuery, connection))
                            {
                                // Pasar el valor del puntaje como parámetro
                                command.Parameters.AddWithValue("@puntaje", puntaje);

                                // Ejecutar la consulta
                                command.ExecuteNonQuery();
                            }
                        }

                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un número decimal con dos dígitos después del punto.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            lado = rand.Next(1, 8);
            lado2 = rand.Next(9, 15);
            lado_1 = lado;
            lado_2 = lado2;
            areaTotal3 = (decimal)(lado * lado2) / 2;

            label22.Text = "Calcula el área de un triángulo de base " + lado_1 + " cm" + " y con altura de "
                + lado_2 + " cm.\nOcupe un decimal después del punto.";

            label19.Text = lado_1 + " cm";
            label24.Text = lado_2 + " cm";

            txtTriangulo.Text = string.Empty;
            label20.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            decimal respuesta;
            if (decimal.TryParse(txtCirculo.Text, out respuesta))
            {
                respuesta = Math.Round(respuesta, 2);
                if (respuesta == areaTotal4)
                {
                    MessageBox.Show("Respuesta correcta", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label28.Text = "A = " + "π x " + lado_1 + "²" + " = "+ areaTotal4.ToString("0.##");
                    label28.Visible = true;
                    contadorPreguntas--;
                    puntaje += 10;
                    Console.WriteLine(puntaje);
                    Console.WriteLine(contadorPreguntas);
                    if (contadorPreguntas == 0)
                    {
                        MessageBox.Show("¡Ha obtenido su puntaje! \nPuntaje obtenido: " + puntaje);

                        string connectionString = @"Data Source=LAPTOP-36NNJN45\ANGELSERVER;Initial Catalog=desarrollo;Integrated Security=True;";

                        // Consulta para actualizar el puntaje en la última fila de la tabla
                        string updateQuery = "UPDATE puntajes SET puntajeAreas = @puntaje WHERE id = (SELECT MAX(id) FROM puntajes)";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            // Crear el comando SQL
                            using (SqlCommand command = new SqlCommand(updateQuery, connection))
                            {
                                // Pasar el valor del puntaje como parámetro
                                command.Parameters.AddWithValue("@puntaje", puntaje);

                                // Ejecutar la consulta
                                command.ExecuteNonQuery();
                            }
                        }

                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Respuesta incorrecta", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    contadorPreguntas--;
                    Console.WriteLine(puntaje);
                    Console.WriteLine(contadorPreguntas);
                    button5_Click(sender, e);
                    if (contadorPreguntas == 0)
                    {
                        MessageBox.Show("¡Ha obtenido su puntaje! \nPuntaje obtenido: " + puntaje);

                        string connectionString = @"Data Source=LAPTOP-36NNJN45\ANGELSERVER;Initial Catalog=desarrollo;Integrated Security=True;";

                        // Consulta para actualizar el puntaje en la última fila de la tabla
                        string updateQuery = "UPDATE puntajes SET puntajeAreas = @puntaje WHERE id = (SELECT MAX(id) FROM puntajes)";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            // Crear el comando SQL
                            using (SqlCommand command = new SqlCommand(updateQuery, connection))
                            {
                                // Pasar el valor del puntaje como parámetro
                                command.Parameters.AddWithValue("@puntaje", puntaje);

                                // Ejecutar la consulta
                                command.ExecuteNonQuery();
                            }
                        }

                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un número decimal con dos dígitos después del punto.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            lado = rand.Next(1, 8);
            lado_1 = lado;
            areaTotal4 = (decimal)(Math.PI * lado * lado);
            areaTotal4 = Math.Round(areaTotal4, 2);

            label30.Text = "Calcula el área de un circulo con radio de " + lado_1
                + " cm. \nRedondea el resultado a dos decimales. Utiliza el valor completo de π";
            label32.Text = lado_1 + " cm";

            txtCirculo.Text = string.Empty;
            label28.Visible = false;
        }
    }
}