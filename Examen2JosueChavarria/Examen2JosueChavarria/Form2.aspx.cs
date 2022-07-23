using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace Examen2JosueChavarria
{
    public partial class Form2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tservicio.Text = Clases.Cliente.Getservicio();
            rnombre.Text = Clases.Cliente.Getnombre();
            rcedula.Text = Clases.Cliente.Getcedula().ToString();
            rtelefono.Text = Clases.Cliente.Gettelefono().ToString();
            rdireccion.Text = Clases.Cliente.Getdireccion().ToString();
            rfactura.Text = Clases.Cliente.factura.ToString();
        }

        protected void bsalvar_Click(object sender, EventArgs e)
        {
            String strConnString = ConfigurationManager.ConnectionStrings["EXAMEN2DBConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            SqlCommand command = new SqlCommand("Salvar", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar).Value= rnombre.Text);
            command.Parameters.Add(new SqlParameter("@cedula", SqlDbType.Int).Value = rcedula.Text);
            command.Parameters.Add(new SqlParameter("@telefono", SqlDbType.Int).Value = rcedula.Text);
            command.Parameters.Add(new SqlParameter("@direccion", SqlDbType.VarChar).Value = rdireccion.Text);
            command.Parameters.Add(new SqlParameter("@monto", SqlDbType.Float).Value = rmonto.Text);
            command.Parameters.Add(new SqlParameter("@descuento", SqlDbType.Float).Value = rdescuento.Text);
            command.Parameters.Add(new SqlParameter("@subtotal", SqlDbType.Float).Value = rsubtotal.Text);
            command.Parameters.Add(new SqlParameter("@total", SqlDbType.Float).Value = rtotal.Text);
            command.Parameters.Add(new SqlParameter("@iva", SqlDbType.Float).Value = riva.Text);
            command.ExecuteNonQuery();
       
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert('Notification : Informacion guardada correctamente');", true);
        }

        protected void bvolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Form1.aspx");
        }

        protected void bagregar_Click(object sender, EventArgs e)
        {
            float descuento = float.Parse(tdescuento.Text);
            float monto = float.Parse(tmonto.Text);
            float subtotal = 0;
            float total = 0;
            
            const float iva = 13;
            Clases.Cliente.Setmonto(monto);
            Clases.Cliente.Setdescuento(descuento);

            if (descuento > 0)
            {
                subtotal = monto - (monto * (descuento / 100));
            }

            Clases.Cliente.Setsubtotal(subtotal);

            total = subtotal + (subtotal * (iva / 100));
            Clases.Cliente.Settotal(total);
            


            rmonto.Text = Clases.Cliente.Getmonto().ToString();
            rdescuento.Text = descuento.ToString() + "%";
            rsubtotal.Text = Clases.Cliente.Getsubtotal().ToString();
            riva.Text = "0." + iva.ToString() + "%";
            rtotal.Text = Clases.Cliente.Gettotal().ToString();


            
            




        }
        protected void tmonto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}