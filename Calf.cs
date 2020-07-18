class Calf <W> {
    public string NombreJurado;
    public W ptje;

    public Calf(string NombreJurado , W puntaje){
        this.NombreJurado = NombreJurado;
        this.ptje = puntaje; 
    }

    public bool preguntaPesimo(){

        if(ptje is string){
            string pal = ptje.ToString();
            if(pal == "Pesimo"){
                return true;
            }
        }
        return false;
    }
}