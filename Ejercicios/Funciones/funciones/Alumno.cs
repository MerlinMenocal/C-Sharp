public class Alumno {

    public int Id {get; set; }

    public string PrimerNombre {get; set; }

    public string SegundoNombre {get; set; }

    public Alumno(int, id, string primerNombre, string segundoNombre){
        Id = id;
        PrimerNombre = primerNombre;
        SegundoNombre = segundoNombre;
    }

    //funcion devuelve el primer y segundo nombre
    public string nombreCompleto(){
        return PrimerNombre + " " + SegundoNombre;
    }

}