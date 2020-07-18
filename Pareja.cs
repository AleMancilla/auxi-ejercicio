using System;

class Pareja <W>{
    public string NombreMujer{get; set;}
    public string NombreVaron{get; set;}
    public string Musica{get; set;}
    public int NC {get; set;}

    Calf<W>[] Calif = new Calf<W>[30];

    public Pareja(string nombreMujer, string nombreVaron, string musica){
        this.NombreMujer = nombreMujer;
        this.NombreVaron = nombreVaron;
        this.Musica = musica;
        this.NC = 0;
    }

    public void agregarCalificacion(Calf<W> calificacion){
        this.Calif[NC] = calificacion;
        this.NC++;
    }

    public void pesimos(){
        for(int i = 0 ; i<NC; i++){
            Calf<W> calif = Calif[i];
            if(calif.preguntaPesimo())
            {
                Console.WriteLine("El Jurado {0} dio la calificacion {1}",calif.NombreJurado, calif.ptje);
            }
        }
    }

    public void eliminarPareja(string varon, string mujer){
        if(this.NombreVaron ==  varon && this.NombreMujer == mujer){
            this.NombreMujer ="";
            this.NombreVaron = "";
        }
    }

}