package com.RAAL.x00032219;
public final class GeneradorISBN {
    // Atributo
    private static int contador = 0;

    // Constructor privado
    private GeneradorISBN () {}

    // Métodos estáticos
    public static int nuevoISBN() {
        contador++;
        return contador;
    }
}