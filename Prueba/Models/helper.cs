using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using MyApp;


namespace LectorCSV
{
    
    public class HelperCsv
    {
        //usar este

        /* public void EscribirLinea( List<Alumno> ListadoElementos,string ruta)
        {
           
                using TextWriter streamWriter = File.AppendText(ruta );
                foreach (Alumno elemento in ListadoElementos)
                    {
                        Console.WriteLine(elemento);
                        
                        
                        streamWriter.WriteLine(elemento.Apellido+", "+elemento.Nombre+", " +elemento.Dni+", " + elemento.Id );
                       
                        
                    }
                
            
            
            
        } */
        public List<Cliente> LeerCsvCliente( string nombreDeArchivo)
        {
            FileStream MiArchivo = new FileStream(nombreDeArchivo, FileMode.Open);
            StreamReader StrReader = new StreamReader(MiArchivo);

            string Linea = "";
            List<Cliente> LecturaDelArchivo = new List<Cliente>();

            while ((Linea = StrReader.ReadLine()) != null)
            {
                string[] Fila = Linea.Split(',');
                Cliente nuevo= new Cliente(Convert.ToInt32(Fila[0]),Fila[1],Fila[2],Convert.ToInt32(Fila[3]),Fila[4]);
                LecturaDelArchivo.Add(nuevo);
            }

            return LecturaDelArchivo;
        }
        public List<Cadete> LeerCsvCadete( string nombreDeArchivo)
        {
            FileStream MiArchivo = new FileStream(nombreDeArchivo, FileMode.Open);
            StreamReader StrReader = new StreamReader(MiArchivo);

            string Linea = "";
            List<Cadete> LecturaDelArchivo = new List<Cadete>();

            while ((Linea = StrReader.ReadLine()) != null)
            {
                string[] Fila = Linea.Split(',');
                Cadete nuevo= new Cadete(Convert.ToInt32(Fila[0]),Fila[1],Fila[2],Convert.ToInt32(Fila[3]));
                LecturaDelArchivo.Add(nuevo);
            }

            return LecturaDelArchivo;
        }

        /* public void archivoCSV (List<Alumno> ListadoElementos, string NombreArchivo){
        

            if(!File.Exists(NombreArchivo)){
                File.Create(NombreArchivo);
                
            }
                FileStream filestream = new FileStream(NombreArchivo, FileMode.Open);
                StreamWriter streamWriter = new StreamWriter(filestream);

                foreach (Alumno elemento in ListadoElementos)
                    {
                        Console.WriteLine(elemento);
                        
                        
                        streamWriter.WriteLine(elemento.Apellido+", "+elemento.Nombre+", " +elemento.Dni+", " + elemento.Id );
                       
                        
                    }

                streamWriter.Close();    //importante
                filestream.Close();
    } */

        public static string[] nombreYextencion(string ruta){
        string[] subs = ruta.Split(@"\");
        int total = subs.Count();
        string[] nombre = subs[total-1].Split('.'); 
        return nombre;
    }

    }

   /*  public static void LeerArchivo(string ruta)
    {
        if (!File.Exists(ruta))
        {
            Logger.Info("El archivo que se desea leer no existe");
        }

        try
        {
            using TextReader streamReader = new StreamReader(ruta + ExtensionCsv);
            var textoEnArchivo = streamReader.ReadToEnd();
            textoEnArchivo = textoEnArchivo.Replace(";", " ");
            Console.WriteLine(textoEnArchivo);
        }
        catch (Exception e)
        {
            Logger.Error(e, "Excepción al tratar de escribir en el archivo");
        }
        
        Logger.Debug("Se leyó correctamente el archivo: " + ruta);
    } */
}
