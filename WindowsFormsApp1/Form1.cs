using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    // Clase manejar Objetos

    public class Tarea
    {
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public bool Completada { get; set; }

        // Constructor para inicializar los campos
        public Tarea(string descripcion, DateTime fecha, bool completada)
        {
            Descripcion = descripcion;
            Fecha = fecha;
            Completada = completada;
        }

        // Sobrescribimos ToString para que el ListBox muestre algo útil
        public override string ToString()
        {
            return $"{Descripcion} - {Fecha.ToString("dd/MM/yyyy")} - {(Completada ? "Completada" : "Pendiente")}";
        }
    }



    public partial class Form1 : Form
    {        
        
        //Crear una lista Vacia == guarda las tareas:

        List<Tarea> listaTareas = new List<Tarea>();


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Boton:
        private void button1_Click(object sender, EventArgs e)
        {
            // condicion que valida que el campo no este vacio y sea un string:
            if(!string.IsNullOrEmpty(Titulo.Text))
            {

                string titulo = Titulo.Text;
                bool status = statustarea.Checked;
                DateTime fecha = vencimiento.Value;

                //Objeto instanciado de la clase Tarea.
                //(Debo tener los tres atributos de la padre)
                Tarea nuevaTarea = new Tarea(titulo, fecha, status);

                //Agregar la tarea.
                listaTareas.Add(nuevaTarea);

                
                //private void ActualizarListaTareas()
                //{
                    // Limpiar el ListBox antes de actualizar

                    //listaTareas.Items.Clear();

                    // Agregar las tareas a la lista

                    
                    //foreach (Tarea tarea in listaTareas)
                    //{ 
                    // listaTareas.Items.Add(tarea.ToString());
                    //}

               // }

            }

            else
            {
                MessageBox.Show("Campos Incompletos");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
