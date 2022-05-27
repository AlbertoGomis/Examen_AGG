using System;





class Asignatura
{
    /// <summary>
    /// Se ha realizado encapsulamiento sobre las variables 
    /// ya que asi no pueden ser usadas por caulquiera y cambio de nombres 
    /// ya que eran nombres muy largos Tambien hemos reordenado las variables para que se declaren
    /// antes que cualquier función.
    /// Contenemos las propiedades de cod_Asignatura, nombre_Asignatura, nota_Trimestre1
    /// nota_Trimestre2, nota_Trimestre3, nota_Final
    /// Se ha realizado las tabulaciones adecuadas.
    /// <remarks>Utilizaremmos esto en vez de llamar directamente a las varables.</remarks>
    /// <return>Cada propiedad devolvera el valor de las variables anteriores.</return>
    /// </summary>
    private string cod_Asignatura;
    private string nombre_Asignatura;
    private double nota_Trimestre1;
    private double nota_Trimestre2;
    private double nota_Trimestre3;
    private double nota_Final;

    public string CodigoAsignatura
    {
        get => cod_Asignatura;
        set => cod_Asignatura = value;
    }
    public string NombreAsignatura
    {
        get => nombre_Asignatura;
        set => nombre_Asignatura = value;
    }
    public double Notatrimestre1
    {
        get => nota_Trimestre1;
        set => nota_Trimestre1 = value;
    }
    public double NotaTrimestre2
    {
        get => nota_Trimestre2;
        set => nota_Trimestre2 = value;
    }
    public double NotaTrimestre3
    {
        get => nota_Trimestre3;
        set => nota_Trimestre3 = value;
    }
    public double NotaFinal
    {
        get => nota_Final;
        set => nota_Final = value;
    }

    /// <summary>
    /// Al realizar el cambio de nombres podemos quitar los this. ya que 
    /// ahora se llaman de otra manera. Tambien hemos realizado tabulaciones para 
    /// que el codigo y se ha divido el codigo en diferentes lineas para que quede mas claro.
    /// <remarks>Usaremos este constructor para asignar valores a dichas varaibles.</remarks>
    /// </summary>
    /// <param name="CodigoAsignatura"></param>
    /// <param name="NombreAsignatura"></param>
    /// <param name="Notatrimestre1"></param>
    /// <param name="NotaTrimestre2"></param>
    /// <param name="NotaTrimestre3"></param>
    /// <param name="NotaFinal"></param>
    public Asignatura(string CodigoAsignatura, string NombreAsignatura, double Notatrimestre1, 
                        double NotaTrimestre2, double NotaTrimestre3, double NotaFinal)
    {  
        cod_Asignatura = CodigoAsignatura; 
        nombre_Asignatura = NombreAsignatura; 
        nota_Trimestre1 = Notatrimestre1; 
        nota_Trimestre2 = NotaTrimestre2;
        nota_Trimestre3 = NotaTrimestre3;
        nota_Final = NotaFinal;
    }

    
    /// <summary>
    /// en esta funcion daremos nuevo valores a las variables de cod_Asignatura y nombre_Asignatura
    /// <remarks>Usaremos esta funcion cuando queramos añadir una materia.</remarks>
    /// </summary>
    /// <param name="Cod_de_Asignatura"></param>
    /// <param name="Nombre_de_Asignatura"></param>
    public void IntroducirMateria(string Cod_de_Asignatura, string Nombre_de_Asignatura)
    {
        cod_Asignatura = Cod_de_Asignatura; 
        nombre_Asignatura = Nombre_de_Asignatura;   
    }
    /// <summary>
    /// Se han realizado espacios en blanco para que el codigo sea mas legible.
    /// <remarks>Con esta funcion podemos realizar las notas de examenes y practicas</remarks>
    /// </summary>
    /// <param name="notaExamen1"></param>
    /// <param name="notaExamen2"></param>
    /// <param name="notaExamen3"></param>
    /// <param name="notaPracticas1"></param>
    /// <param name="notaPracticas2"></param>
    /// <param name="notaPracticas3"></param>
    public void IntroducirlasNotas(double notaExamen1, double notaExamen2, double notaExamen3, 
                                   double notaPracticas1, double notaPracticas2, double notaPracticas3)
    {  
        {
            for (int i = 1; i < 4; i++)
            {   
                Console.WriteLine("Trimestre evaluado 1, 2 ó 3: ");
                var Trimestre = Console.ReadLine();

                switch (Trimestre)
                {   
                    case "1": 
                        Console.WriteLine("Nota de las prácticas: ");
                        notaPracticas1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nota del examen: ");
                        notaExamen1 = Convert.ToDouble(Console.ReadLine());
                        break;

                    case "2": 
                        Console.WriteLine("Nota de las prácticas: ");
                        notaPracticas2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nota del examen: ");
                        notaExamen2 = Convert.ToDouble(Console.ReadLine());
                        break;

                    case "3": 
                        Console.WriteLine("Nota de las prácticas: ");
                        notaPracticas3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nota del examen: ");
                        notaExamen3 = Convert.ToDouble(Console.ReadLine());
                        break;
                }
               

            }

        }
    }
    /// <summary>
    /// Se han eliminado parentesis y añadido otros para separa mejor las operaciones de cada nota.
    /// <remarks>Usaremos esta funcion para calcular la nota del primer trimestre.</remarks>
    /// </summary>
    /// <param name="notaExamen1"></param>
    /// <param name="notaPracticas1"></param>
    /// <returns> un double con la nota del primer trimestre</returns>
    public double calculoNota1(double notaExamen1, double notaPracticas1)
    {    
        nota_Trimestre1 = (notaExamen1 * 0.8) + (notaPracticas1 * 0.2);  
        return nota_Trimestre1;
    }
    /// <summary>
    /// <remarks>Usaremos esta funcion para calcular la nota del segundo trimestre</remarks>
    /// </summary>
    /// <param name="notaExamen2"></param>
    /// <param name="notaPracticas2"></param>
    /// <returns>un double con la nota del segundo trimestre</returns>
    public double calculoNota2(double notaExamen2, double notaPracticas2)
    {   
        nota_Trimestre2 = (notaExamen2  * 0.8) + (notaPracticas2 * 0.2);
        return nota_Trimestre2;
    }
    /// <summary>
    /// <remarks>Usaremos esta funcion para calcular la nota del tercer trimestre</remarks>
    /// </summary>
    /// <param name="notaExamen3"></param>
    /// <param name="notaPracticas3"></param>
    /// <returns>un double con la nota del tercer trimestre</returns>
    public double calculoNota3(double notaExamen3, double notaPracticas3)
    {   
        nota_Trimestre3 = (notaExamen3 * 0.8) + (notaPracticas3 * 0.2);
        return nota_Trimestre3;
    }
    /// <summary>
    /// En vez de llamar a cada nota convocamos a cada funcion que ya nos calcula cada nota.
    /// <remarks>Usaremos esta funcion para calcular la nota final</remarks>
    /// </summary>
    /// <returns>double de sumar los tres trimestres y dividirlos entre 3</returns>
    public double Calculomedia()
    {   
        nota_Final = (calculoNota1(5,6) + calculoNota2(6,8) + calculoNota3(9,5)) / 3; 
        return nota_Final;
    }

}
