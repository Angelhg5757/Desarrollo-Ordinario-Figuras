using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesarrolloOrdinario
{
    public partial class volumenes : Form
    {
        private int lado = 2;
        private int lado2 = 12;
        private int volumenTotal;
        private decimal volumenTotal2;
        private decimal volumenTotal3;
        private decimal volumenTotal4;
        public int puntaje;
        public int contadorPreguntas = 5;
        public int lado_1;
        public int lado_2;
        public volumenes()
        {
            InitializeComponent();
            // Genera un número aleatorio para el lado del cuadrado
            //Random rand = new Random();
            //lado = rand.Next(1, 8);
            //lado2 = rand.Next(9, 15);
            lado_1 = lado;
            lado_2 = lado2;
            volumenTotal = lado * lado * lado;
            volumenTotal2 = (decimal)((Math.PI * lado * lado) * lado2);
            volumenTotal2 = Math.Round(volumenTotal2, 2);

            volumenTotal3 = (decimal)((4.0 / 3.0) * Math.PI * Math.Pow(lado, 3));
            volumenTotal3 = Math.Round(volumenTotal3, 2);

            volumenTotal4 = (decimal)((Math.PI * lado * lado * lado2) / 3.0);
            volumenTotal4 = Math.Round(volumenTotal4, 2);

            label8.Text = "Calcula el volumen de un cubo de " + lado_1 + " cm de lado.";
            label6.Text = lado_1 + " cm";

            label13.Text = "Calcula el volumen de un cilindro con radio " + lado_1 + " cm" + " y con altura de "
                + lado_2 + " cm." + "\nRedondear el resultado final a dos decimales y utilizar el valor completo de π.";
            label15.Text = lado_2 + " cm";
            label16.Text = lado_1 + " cm";

            label22.Text = "Calcula el volumen de una esfera con radio " + lado_1 + " cm" 
                + "\nRedondear el resultado final a dos decimales y utilizar el valor completo de π.";
            label19.Text = lado_1 + " cm";

            label30.Text = "Calcula el volumen de un cono con radio " + lado_1 + " cm" + " y con altura de "
                + lado_2 + " cm." 
                + "\nRedondear el resultado final a dos decimales y utilizar el valor completo de π.";
            label32.Text = lado_2 + " cm";
            label24.Text = lado_1 + " cm";
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            int respuesta;

            // Intenta convertir el texto en el cuadro de texto en un número entero
            if (int.TryParse(txtCubo.Text, out respuesta))
            {
                // Comprueba si la respuesta es correcta
                if (respuesta == volumenTotal)
                {
                    MessageBox.Show("Respuesta correcta", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label10.Text = "V = " + lado_1 + " x " + lado_1 + " x " + lado_1 + " = " + volumenTotal;
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
                        string updateQuery = "UPDATE puntajes SET puntajeVolumenes = @puntaje WHERE id = (SELECT MAX(id) FROM puntajes)";

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
                    Console.WriteLine(contadorPreguntas);
                    btnReiniciar_Click(sender, e);
                    if (contadorPreguntas == 0)
                    {
                        MessageBox.Show("¡Ha obtenido su puntaje! \nPuntaje obtenido: " + puntaje);

                        string connectionString = @"Data Source=LAPTOP-36NNJN45\ANGELSERVER;Initial Catalog=desarrollo;Integrated Security=True;";

                        // Consulta para actualizar el puntaje en la última fila de la tabla
                        string updateQuery = "UPDATE puntajes SET puntajeVolumenes = @puntaje WHERE id = (SELECT MAX(id) FROM puntajes)";

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
            volumenTotal = lado * lado * lado;

            label8.Text = "Calcula el volumen de un cubo de " + lado_1 + " cm de lado.";
            label6.Text = lado_1 + " cm";

            txtCubo.Text = string.Empty;
            label10.Visible = false;
        }

        private void volumenes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal respuesta;
            if (decimal.TryParse(txtCilindro.Text, out respuesta))
            {
                respuesta = Math.Round(respuesta, 2);
                if (respuesta == volumenTotal2)
                {
                    MessageBox.Show("Respuesta correcta", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label11.Text = "V = " + "π x "+ lado_1 + "² " + "x " + lado_2 + " = " + volumenTotal2.ToString("0.##");
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
                        string updateQuery = "UPDATE puntajes SET puntajeVolumenes = @puntaje WHERE id = (SELECT MAX(id) FROM puntajes)";

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
                    Console.WriteLine(contadorPreguntas);
                    button1_Click(sender, e);
                    if (contadorPreguntas == 0)
                    {
                        MessageBox.Show("¡Ha obtenido su puntaje! \nPuntaje obtenido: " + puntaje);

                        string connectionString = @"Data Source=LAPTOP-36NNJN45\ANGELSERVER;Initial Catalog=desarrollo;Integrated Security=True;";

                        // Consulta para actualizar el puntaje en la última fila de la tabla
                        string updateQuery = "UPDATE puntajes SET puntajeVolumenes = @puntaje WHERE id = (SELECT MAX(id) FROM puntajes)";

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

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            lado = rand.Next(1, 8);
            lado2 = rand.Next(9, 15);
            lado_1 = lado;
            lado_2 = lado2;
            volumenTotal2 = (decimal)((Math.PI * lado * lado) * lado2);
            volumenTotal2 = Math.Round(volumenTotal2, 2);

            label13.Text = "Calcula el volumen de un cilindro con radio " + lado_1 + " cm" + " y con altura de "
                + lado_2 + " cm." + "\nRedondear el resultado final a dos decimales y utilizar el valor completo de π.";
            label15.Text = lado_2 + " cm";
            label16.Text = lado_1 + " cm";

            txtCilindro.Text = string.Empty;
            label11.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal respuesta;
            Console.WriteLine(volumenTotal3);
            if (decimal.TryParse(txtEsfera.Text, out respuesta))
            {
                respuesta = Math.Round(respuesta, 2);
                if (respuesta == volumenTotal3)
                {
                    MessageBox.Show("Respuesta correcta", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label20.Text = "V = " + "4/3 x π x " + lado_1 + "³ = " + volumenTotal3.ToString("0.##");
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
                    Console.WriteLine(contadorPreguntas);
                    button3_Click(sender, e);
                    if (contadorPreguntas == 0)
                    {
                        MessageBox.Show("¡Ha obtenido su puntaje! \nPuntaje obtenido: " + puntaje);

                        string connectionString = @"Data Source=LAPTOP-36NNJN45\ANGELSERVER;Initial Catalog=desarrollo;Integrated Security=True;";

                        // Consulta para actualizar el puntaje en la última fila de la tabla
                        string updateQuery = "UPDATE puntajes SET puntajeVolumenes = @puntaje WHERE id = (SELECT MAX(id) FROM puntajes)";

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
            lado_1 = lado;
            volumenTotal3 = (decimal)((4.0 / 3.0) * Math.PI * Math.Pow(lado, 3));
            volumenTotal3 = Math.Round(volumenTotal3, 2);
            label22.Text = "Calcula el volumen de una esfera con radio " + lado_1 + " cm"
                + "\nRedondear el resultado final a dos decimales y utilizar el valor completo de π.";
            label19.Text = lado_1 + " cm";

            txtEsfera.Text = string.Empty;
            label20.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            decimal respuesta;
            Console.WriteLine(volumenTotal4);
            if (decimal.TryParse(txtCono.Text, out respuesta))
            {
                respuesta = Math.Round(respuesta, 2);
                if (respuesta == volumenTotal4)
                {
                    MessageBox.Show("Respuesta correcta", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label28.Text = "V = " + "(π x  " + lado_1 + "² x" + lado_2+ ") / 3" + " = " 
                        + volumenTotal4.ToString("0.##");
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
                        string updateQuery = "UPDATE puntajes SET puntajeVolumenes = @puntaje WHERE id = (SELECT MAX(id) FROM puntajes)";

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
                    Console.WriteLine(contadorPreguntas);
                    button5_Click(sender, e);
                    if (contadorPreguntas == 0)
                    {
                        MessageBox.Show("¡Ha obtenido su puntaje! \nPuntaje obtenido: " + puntaje);

                        string connectionString = @"Data Source=LAPTOP-36NNJN45\ANGELSERVER;Initial Catalog=desarrollo;Integrated Security=True;";

                        // Consulta para actualizar el puntaje en la última fila de la tabla
                        string updateQuery = "UPDATE puntajes SET puntajeVolumenes = @puntaje WHERE id = (SELECT MAX(id) FROM puntajes)";

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
            lado2 = rand.Next(9, 15);
            lado_1 = lado;
            lado_2 = lado2;
            volumenTotal4 = (decimal)((Math.PI * lado * lado * lado2) / 3.0);
            volumenTotal4 = Math.Round(volumenTotal4, 2);

            label30.Text = "Calcula el volumen de un cono con radio " + lado_1 + " cm" + " y con altura de "
                + lado_2 + " cm."
                + "\nRedondear el resultado final a dos decimales y utilizar el valor completo de π.";
            label32.Text = lado_2 + " cm";
            label24.Text = lado_1 + " cm";

            txtCono.Text = string.Empty;
            label28.Visible = false;
        }
    }
}