using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2JosueChavarria
{
    public partial class Form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Clases.Cliente.factura = Clases.Cliente.factura + 1;

            Clases.Cliente.Setnombre(tnombre.Text);
            Clases.Cliente.Setcedula(Int32.Parse(tcedula.Text));
            Clases.Cliente.Settelefono(Int32.Parse(ttelefono.Text));
            Clases.Cliente.Setdireccion(Tdireccion.Text);


            String s = System.Configuration.ConfigurationManager.ConnectionStrings["EXAMEN2DBConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select nombre, cedula, telefono, direccion from cliente where nombre = '" + Clases.Cliente.Getnombre() + "' cedula = '" + Clases.Cliente.Getcedula() + "' telefono = '" + Clases.Cliente.Gettelefono() + "' and direccion = '" + Clases.Cliente.Getdireccion() + "'", conexion);
            Clases.Cliente.Setservicio("Cable");
            Response.Redirect("Form2.aspx");

            conexion.Close();

        }

        protected void Iagua_Click(object sender, ImageClickEventArgs e)
        {
            Clases.Cliente.factura = Clases.Cliente.factura + 1;
            Clases.Cliente.Setnombre(tnombre.Text);
            Clases.Cliente.Setcedula(Int32.Parse(tcedula.Text));
            Clases.Cliente.Settelefono(Int32.Parse(ttelefono.Text));
            Clases.Cliente.Setdireccion(Tdireccion.Text);


            String s = System.Configuration.ConfigurationManager.ConnectionStrings["EXAMEN2DBConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select nombre, cedula, telefono, direccion from cliente where nombre = '" + Clases.Cliente.Getnombre() + "' cedula = '" + Clases.Cliente.Getcedula() + "' telefono = '" + Clases.Cliente.Gettelefono() + "' and direccion = '" + Clases.Cliente.Getdireccion() + "'", conexion);
            Clases.Cliente.Setservicio("Agua");
            Response.Redirect("Form2.aspx");

            conexion.Close();



        }

        protected void Ielectricidad_Click(object sender, ImageClickEventArgs e)
        {
            Clases.Cliente.factura = Clases.Cliente.factura + 1;
            Clases.Cliente.Setnombre(tnombre.Text);
            Clases.Cliente.Setcedula(Int32.Parse(tcedula.Text));
            Clases.Cliente.Settelefono(Int32.Parse(ttelefono.Text));
            Clases.Cliente.Setdireccion(Tdireccion.Text);


            String s = System.Configuration.ConfigurationManager.ConnectionStrings["EXAMEN2DBConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select nombre, cedula, telefono, direccion from cliente where nombre = '" + Clases.Cliente.Getnombre() + "' cedula = '" + Clases.Cliente.Getcedula() + "' telefono = '" + Clases.Cliente.Gettelefono() + "' and direccion = '" + Clases.Cliente.Getdireccion() + "'", conexion);
            Clases.Cliente.Setservicio("Electricidad");
            Response.Redirect("Form2.aspx");

            conexion.Close();
            
        }

        protected void Itelefono_Click(object sender, ImageClickEventArgs e)
        {
            Clases.Cliente.factura = Clases.Cliente.factura + 1;

            Clases.Cliente.Setnombre(tnombre.Text);
            Clases.Cliente.Setcedula(Int32.Parse(tcedula.Text));
            Clases.Cliente.Settelefono(Int32.Parse(ttelefono.Text));
            Clases.Cliente.Setdireccion(Tdireccion.Text);


            String s = System.Configuration.ConfigurationManager.ConnectionStrings["EXAMEN2DBConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select nombre, cedula, telefono, direccion from cliente where nombre = '" + Clases.Cliente.Getnombre() + "' cedula = '" + Clases.Cliente.Getcedula() + "' telefono = '" + Clases.Cliente.Gettelefono() + "' and direccion = '" + Clases.Cliente.Getdireccion() + "'", conexion);
            Clases.Cliente.Setservicio("Telefono");
            Response.Redirect("Form2.aspx");

            conexion.Close();
        }

        protected void Icable_Click(object sender, ImageClickEventArgs e)
        {
          
        }

        protected void tcedula_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tdireccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}