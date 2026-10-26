using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.IO;
using System.Linq;

namespace BitLogic_App_Escritorio
{
    internal class ClienteRepositorio
    {
        private const string Archivo = "Usuario.xml";

        public ClienteRepositorio()
        {
            if (!File.Exists(Archivo))
            {
                XDocument doc = new XDocument(new XElement("usuarios"));
                doc.Save(Archivo);
            }
        }

        public XElement BuscarPorCorreo(string correo)
        {
            // 2. carga el doc y devuelve el resultado de FirstOrDefault
            XDocument doc = XDocument.Load(Archivo);
          return  doc.Root.Elements("usuario").FirstOrDefault(x => (string)x.Element("correo") == correo);
        }

        public bool Existe(string correo)
        {
            // 3. una línea: ¿qué debe cumplir el resultado de BuscarPorDni?
            if (BuscarPorCorreo(correo) == null)return false;else return true;;

        }
        public int GenerarId()
        {
            // cargar doc
            XDocument doc = XDocument.Load(Archivo);
            int maximo = doc.Root.Elements("usuario").Select(x => (int)x.Element("id")).DefaultIfEmpty(0).Max();
            return maximo + 1;
        
            // devolver máximo + 1
        }
        public int Agregar(string correo, string nombre, string apellido, string telefono)
        {
            int id = GenerarId();
            // 4. carga, crea el XElement, añade al Root, guarda
            XDocument doc = XDocument.Load(Archivo);

            XElement usua = new XElement("usuario");
            usua.Add(new XElement("id", id));
            usua.Add(new XElement("correo", correo.Trim()));
            usua.Add(new XElement("nombre", nombre.Trim()));
            usua.Add(new XElement("apellido", apellido.Trim()));
            usua.Add(new XElement("telefono", telefono.Trim()));
            usua.Add(new XElement("visitas", 1));
            usua.Add(new XElement("ultimaBusqueda", DateTime.Today.ToString("yyyy-MM-dd")));

            doc.Root.Add(usua);
            doc.Save(Archivo);
            return id;

        }
        private Cliente ConvertirACliente(XElement x)
        {
            // new Cliente con cada propiedad rellena desde x
            return new Cliente
            {
                // (int)x.Element("id"), (string)x.Element("nombre"), ...
                Id = (int)x.Element("id"),
                Nombre = (string)x.Element("nombre"),
                Apellido = (string)x.Element("apellido"),
                Correo = (string)x.Element("correo"),
                Telefono = (string)x.Element("telefono"),
                Visitas = (int)x.Element("visitas"),
                // fecha: (DateTime?)x.Element("ultimaBusqueda")
                UltimaVisita = (DateTime?)x.Element("ultimaBusqueda")

            };
        }

        public Cliente BuscarPorId(int id)
        {
            XDocument doc = XDocument.Load(Archivo);
            XElement elemento = doc.Root.Elements("usuario").FirstOrDefault(x => (int)x.Element("id") == id);
            if (elemento == null) return null;
            return ConvertirACliente(elemento);/* ConvertirACliente(¿qué variable?) */;
        }
        public List<Cliente> BuscarPorApellido(string texto)
        {
            XDocument doc = XDocument.Load(Archivo);
            return doc.Root.Elements("usuario")
                .Where(/* condición con ToLower y Contains */(string)x.Element("apellido")).ToLower().Contains(texto.ToLower())
                .Select(/* convertir cada XElement a Cliente */)
                .ToList();
        }
    }
}
    