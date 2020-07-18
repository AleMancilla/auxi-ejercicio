using System;

class Presentacion<W> : Evento {
    string fecha {get; set;}
    int Np {get; set;}
    Pareja<W>[] P = new Pareja<W>[30];

    public Presentacion(string lugar, string fecha){
        this.lugar = lugar;
        this.fecha = fecha;
        this.Np = 0;
    }

    public void agregarPareja(Pareja<W> pareja){
        this.P[Np] = pareja;
        this.Np++;
    }

    public void mostrarParejas(){
        for(int i = 0; i<Np ; i++){
            Pareja<W> pareja = P[i];
            Console.WriteLine("La Pareja consiste en {0} y {1} y bailaran {2}",pareja.NombreVaron, pareja.NombreMujer, pareja.Musica);
        }
    }
    public void mostrarPesimos(){
        for(int i = 0; i<Np ; i++){
            Pareja<W> pareja = P[i];
            Console.WriteLine("La Pareja consiste en {0} y {1} y bailaran {2}",pareja.NombreVaron, pareja.NombreMujer, pareja.Musica);
            pareja.pesimos();
        }
    }

    public void eliminarPareja(string varon, string mujer , string fecha){
        if(fecha == this.fecha){
            for(int i = 0; i<Np ; i++){
                Pareja<W> pareja = P[i];
                //Console.WriteLine("La Pareja consiste en {0} y {1} y bailaran {2}",pareja.NombreVaron, pareja.NombreMujer, pareja.Musica);
                pareja.eliminarPareja(varon, mujer);
            }
        }
    }
}