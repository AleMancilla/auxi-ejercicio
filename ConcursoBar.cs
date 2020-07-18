using System;

class ConcursoBar <W> {
    int Np = 0;
    Presentacion<W>[] P = new Presentacion<W>[30];

    public void agregarPresentacion(Presentacion<W> presentacion){
        this.P[Np] = presentacion;
        this.Np++;
    }

    public void mostrarPresentacion(){
        for(int i =0; i<Np; i++){
            Presentacion<W> presentacion = P[i];
            presentacion.mostrarParejas();
        }
    }

    public void mostrarPesimos(){
        Console.WriteLine("LAS SIGUIENTES CALIFICACIONES SON LAS PESIMAS");
        for(int i =0; i<Np; i++){
            Presentacion<W> presentacion = P[i];
            presentacion.mostrarPesimos();
        }
    }

    public void eliminarPareja(string varon, string mujer , string fecha){
        Console.WriteLine("Pareja eliminada");
        for(int i =0; i<Np; i++){
            Presentacion<W> presentacion = P[i];
            presentacion.eliminarPareja( varon,  mujer ,  fecha);
        }
    }
}