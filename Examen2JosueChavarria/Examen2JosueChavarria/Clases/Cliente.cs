using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen2JosueChavarria.Clases
{
    public class Cliente
    {
        //Atributos

        public static int factura = 100000;
        private static int cedula { get; set; }
        private static string nombre { get; set; }
        private static int telefono { get; set; }
        private static string direccion { get; set; }
        private static float monto { get; set; }
        private static float total { get; set; }


        private static float descuento { get; set; }
        private static float subtotal { get; set; }
        private static string servicio { get; set; }

        //-------------------------------getter and setter------------------------------------------- 

        //cedula
        public static int Getcedula()
        {
            return cedula;

        }

        public static void Setcedula(int id)
        {
            cedula = id;

        }

        //nombre 
        public static string Getnombre()
        {
            return nombre;

        }

        public static void Setnombre(string name)
        {
            nombre = name;

        }

        //telefono

        public static int Gettelefono()
        {
            return telefono;

        }

        public static void Settelefono(int tel)
        {
            telefono = tel;

        }

        //direccion
        public static string Getdireccion()
        {
            return direccion;

        }

        public static void Setdireccion(string adress)
        {
            direccion = adress;

        }

        //monto
        public static float Getmonto()
        {
            return monto;

        }

        public static void Setmonto(float mont)
        {
            monto = mont;

        }

        //descuento
        public static float Getdescuento()
        {
            return descuento;

        }

        public static void Setdescuento(float desc)
        {
            descuento = desc;

        }
        public static float Gettotal()
        {
            return total;

        }

        public static void Settotal(float tol)
        {
            total = tol;

        }

        public static float Getsubtotal()
        {
            return subtotal;

        }

        public static void Setsubtotal(float sub)
        {
            subtotal = sub;

        }

        public static int Getfactura()
        {
            return factura;

        }

        public static void Setfactura(int fac)
        {
            factura = fac;

        }
        public static string Getservicio()
        {
            return servicio;

        }

        public static void Setservicio(string serv)
        {
            servicio = serv;

        }

    }
}