package com.RAAL.x00032219;

public class Libro {
    private String ISBN;
    private String nombre;
    private int paginas;

    public Libro(String nom, String ISB, int pag){
        ISBN = ISB;
        nombre = nom;
        paginas = pag;
    }

    public String getISBN(){
        return ISBN;
    }

    public String getNombreL(){
        return nombre;
    }

    public int getPaginas(){
        return paginas;
    }
    @Override
    public String toString() {
        return "\nLibro" +
                "\nnombre = " + nombre +
                "\nPáginas = " + paginas +
                "\nISBN = " + ISBN +
                "\n";
    }
}
