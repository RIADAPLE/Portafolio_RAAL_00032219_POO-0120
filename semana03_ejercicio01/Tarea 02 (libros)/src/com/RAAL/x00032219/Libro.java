package com.RAAL.x00032219;

public class Libro {
    private int ISBN;
    private String nombre;
    private int paginas;

    public Libro(String nom, int pag){
        ISBN = GeneradorISBN.nuevoISBN();
        nombre = nom;
        paginas = pag;
    }

    public int getISBN(){
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
