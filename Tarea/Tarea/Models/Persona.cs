using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea.Models
{
    class Persona
    {
        public int AlbumID { get; set; }
        public int ArtistaID { get; set; }
        public Artista Artista { get; set; }

        public string Nombre { get; set; }
        public Date Precio { get; set; }
        public int Anio { get; set; }
    }
}
