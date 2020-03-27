package com.RAAL.x00032219;
import java.util.Scanner;
import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {
        ArrayList<Autor> Autorsito = new ArrayList<>();
        ArrayList<Libro> librito = new ArrayList<>();
	Scanner lib = new Scanner(System.in);
	boolean x=true;
	byte op1=0;
        do{
            menu();
            op1 = lib.nextByte(); lib.nextLine();
            switch(op1){
                case 1:
                    System.out.println("Introduzca el nombre:");
                    String nom = lib.nextLine();
                    System.out.println("Introduzca el email:");
                    String em = lib.nextLine();
                    System.out.println("Introduzca el género (m o f):");
                    char g = lib.next().charAt(0);
                    Autorsito.add(new Autor(nom,em,g));
                    break;

                case 2:
                    System.out.println("Introduzca el nombre del libro:");
                    String libro = lib.nextLine();
                    System.out.println("Introduzca el número de páginas:");
                    int paginas = lib.nextInt(); lib.nextLine();
                    librito.add(new Libro( libro, paginas));
                    break;
                case 3:
                    Autorsito.forEach(Autor -> System.out.println(Autor.toString()));
                    break;

                case 4:
                    librito.forEach(Libro -> System.out.println(Libro.toString()));
                    break;
                case 5:
                    System.out.println("Introduzca el nombre del autor, que quiere eliminar");
                    String finalautor = lib.nextLine();
                    Autorsito.removeIf(s -> s.getNombre().equals(finalautor));
                    break;
                case 6:
                    System.out.println("Introduzca el ISBN del libro que quiere eliminar");
                    int finalISBN = lib.nextInt();
                    librito.removeIf(s -> s.getISBN()==finalISBN);
                    break;
                case 0:
                    x=false;
                    break;
            }

        }while(x);

    }

    public static void menu(){
            System.out.println("¿Qué desea hacer?");
            System.out.println("1. Agregar un autor");
            System.out.println("2. Agregar un libro");
            System.out.println("3. Mostrar autores");
            System.out.println("4. Mostrar libros");
            System.out.println("5. Borrar autores");
            System.out.println("6. Borrar libros");
            System.out.println("0. Salir");
        }
    }

