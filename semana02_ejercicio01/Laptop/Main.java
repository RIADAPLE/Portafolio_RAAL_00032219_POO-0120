package com.RAAL.x00032219;
import java.util.Scanner;
import com.RAAL.x00032219.Laptop;

public class Main {

    public static void main(String[] args) {
        Scanner lap = new Scanner(System.in);
        System.out.println("---Laptop---");
        Laptop uso = new Laptop();
        System.out.println("\nIntroduzca la marca de su computadora:");
        String marquita = lap.nextLine();
        System.out.println("Introduzca su nombre:");
        String usuarito = lap.nextLine();
        Laptop uso1 = new Laptop(marquita,usuarito);
        uso1.encender();
        byte op1=0;
        boolean x=true;
        do{
            menu(); op1 = lap.nextByte(); lap.nextLine();
            switch(op1){
                case 1:
                    uso1.espacio();
                    break;
                case 2:
                    programas();
                    Byte xp = lap.nextByte();
                    lap.nextLine();
                    if(xp<1 || xp>4){
                        System.out.println("Opcion erronea!");
                        break;
                    }
                    uso1.programitas(xp);
                    break;
                case 3:
                    uso1.formatear();
                    break;
                case 0:
                    x=false;
                    break;
                default:
                    System.out.println("Opcion erronea!");
            }
        }while(x);
    }
    static void menu(){
        System.out.println("Qué desea hacer?");
        System.out.println("1. Ver el espacio del disco duro");
        System.out.println("2. Agregar un programa");
        System.out.println("3. Borrar todos los programas");
        System.out.println("0. salir");
    }

    static void programas(){
        System.out.println("Qué desea añadir?");
        System.out.println("1. Archivo de word");
        System.out.println("2. Vídeo");
        System.out.println("3. Juego ligero");
        System.out.println("4. Juego pesado");

    }
}
