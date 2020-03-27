package com.RAAL.x00032219;


public class Autor {
    private String nombre;
    private String email;
    private char genero;

    public Autor(String nom, String em, char g){
        nombre = nom;
        email = em;
        genero = g;
    }

    public String getNombre(){
        return nombre;
    }

    public String getEmail(){
        return email;
    }

    public void setEmail(String x){
        email = x;
    }

    public char getGenero(){
        return genero;
    }
    @Override
    public String toString() {
        return "\nAutor:" +
                "\nnombre = " + nombre +
                "\nemail = " + email +
                "\ngénero = " + genero +
                "\n";
    }
}
