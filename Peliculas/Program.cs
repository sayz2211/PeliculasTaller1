// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola Bienvenido a nuestra tienda de alquier y ventas de peliculas  ");





public class Clientes {
public int Id  { get; set; }
public string ? Nombre  { get; set; } 
public string ? Cedula   { get; set; } 
public String ? Correo  { get; set; }  
public DateTime Fecha   { get; set; } 
public string? Telefono   { get; set; } 

public List<Facturas>? Facturas { get; set; }
public List<Devoluciones>? Devoluciones { get; set; }
};


public class Peliculas {
public int Id  { get; set; }
public string? Nombre  { get; set; } 
public int ?   Estreno { get; set; } 
public string? Clasi_edad { get; set; } 
public int puntuacion  { get; set; } 
public bool Disponibilidad  { get; set; } 
public List < TiposGeneros>? TiposGeneros { get; set; }
public List<Repartos>? Repartos { get; set; }
 public List<Formatos_Peliculas>? Formatos_Peliculas { get; set; }
public List<Inventarios>? Inventarios { get; set; }
 public List<Ventas_Peliculas>? Ventas_Peliculas { get; set; }
 public List<Rentas_Peliculas>? Rentas_Peliculas { get; set; }

};

public class TiposGeneros
{
    public int Id  { get; set; }

    public string ? Genero { get; set; }
     public Peliculas? Pelicula { get; set; }

}

public class Status 
{
    public int Id  { get; set; }

    public bool status  { get; set; }

}


public class Facturas
{
 public int Id  { get; set; }
public  int Codigo  { get; set; } 
public DateTime Fecha   { get; set; } 
 public int Id_Clientes  { get; set; }
 public int Id_Rentas { get; set; }
 public int Id_Ventas { get; set; }
 public int Id_Descuentos { get; set; }
 public decimal Total { get; set; } = 0.0m ;
 public Clientes? Cliente { get; set; }
 public Rentas? Renta { get; set; }
  public Ventas? Venta { get; set; }
public List<Reclamos>? Reclamos { get; set; }
public List<Devoluciones>? Devoluciones { get; set; }

}

public class Rentas 
{
public int Id  { get; set; }
public decimal Precio { get; set; } = 0.0m ;
public  int Cantidad { get; set; } 
public DateTime Fecha_Renta  { get; set; } 
public DateTime Fecha_Limite { get; set; } 
 public List<Rentas_Peliculas>? Rentas_Peliculas { get; set; }
 public List<Facturas>? Facturas { get; set; }
}


public class Ventas {
public int Id  { get; set; }
public decimal Precio { get; set; } = 0.0m ;
public  int Cantidad { get; set; } 

public List<Ventas_Peliculas>? Ventas_Peliculas { get; set; }
public List<Facturas>? Facturas { get; set; }

}

public class Actores {
public int Id  { get; set; }
public string? Nombre { get; set; }
public string? Nombre_Artistico { get; set; }
public string? Nacionalidad { get; set; }
public string? Premios { get; set; }
public  int CantidadP { get; set; } 

public List<Repartos>? Repartos { get; set; }

}


public class Repartos {
public int Id  { get; set; }
public int Id_Actores  { get; set; }
public int Id_Peliculas  { get; set; }
public string? Personaje { get; set; }
public string? Rol { get; set; }

public Actores? Actor { get; set; }
public Peliculas? Pelicula { get; set; }

}

public class Sucursales  {
    
public int Id  { get; set; }
public string? Nombre { get; set; }
public string? Ciudad { get; set; }
public string? Direccion { get; set; }
public int Telefono { get; set; }
public List<Empleados>? Empleados { get; set; }
public List<Inventarios>? Inventarios { get; set; }

}

public class Empleados  {
    
public int Id  { get; set; }
public string? Nombre { get; set; }
public string? Ciudad { get; set; }
public string? Correo { get; set; }
public int Telefono { get; set; }
public string? Cargo { get; set; }
public Sucursales? Sucursal { get; set; }

}

public class Formatos   {
    
public int Id  { get; set; }
public string? Formato { get; set; }
public string? Idioma { get; set; }
public bool Subtitulada { get; set; }
public bool Disponible  { get; set; }
 public List<Formatos_Peliculas>? Formatos_Peliculas { get; set; }

}


public class Formatos_Peliculas   {
    
public int Id  { get; set; }
public int Id_Peliculas{ get; set; }
public int Id_Fomatos { get; set; }
public int Id_Invetarios{ get; set; }
public decimal Precio { get; set; } = 0.0m ;
public Peliculas? Pelicula { get; set; }
 public Formatos? Formato { get; set; }
 public Inventarios? Inventario { get; set; }

}


public class Inventarios   {
    
public int Id  { get; set; }

public int Id_Peliculas{ get; set; }
public int Cantidad { get; set; }
public string? Id_Formatos { get; set; }
public string? Id_Sucursal { get; set; }
public Peliculas? Pelicula { get; set; }
public Formatos? Formato { get; set; }
public Sucursales? Sucursal { get; set; }

}




public class Ventas_Peliculas   {
    
public int Id  { get; set; }
public int Id_Ventas { get; set; }
public int Id_Peliculas{ get; set; }
public int Cantidad { get; set; }
public decimal Precio { get; set; } = 0.0m ;
public Ventas? Venta { get; set; }
public Peliculas? Pelicula { get; set; }
}

public class Rentas_Peliculas   {
    
public int Id  { get; set; }
public int Id_Rentas { get; set; }
public int Id_Peliculas{ get; set; }
public int Cantidad { get; set; }
public int Dias { get; set; }
public decimal Total { get; set; } = 0.0m ;
public Rentas? Renta { get; set; }
public Peliculas? Pelicula { get; set; }

}

public class Devoluciones  {
    
public int Id  { get; set; }
public int Id_Clientes  { get; set; }
public DateTime Fecha { get; set; } 
public int Id_Peliculas{ get; set; }
public int Id_Facturas { get; set; }
public string? Multa { get; set; }
public decimal Precio_Multa { get; set; } = 0.0m ;
 public Clientes? Cliente { get; set; }
 public Peliculas? Pelicula { get; set; }
 public Facturas? Factura { get; set; }

}


public class  Reclamos {
    
public int Id  { get; set; }
public int Id_Facturas { get; set; }
public string? Motivo { get; set; }
public DateTime Fecha { get; set; } 
public string? Garantia { get; set; }
public Facturas? Factura { get; set; }

}
