package com.RAAL.x00032219;
import java.util.Scanner;
import com.RAAL.x00032219.Laptop;

public class Main {

    public static void main(String[] args) {
        //EMPIEZA LA LAPTOP
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
        }while(x);//TERMINA LA LAPTOP

        //EMPIEZA EJERCICIO CREATIVO
        System.out.println("\n---Creativo---\n");

        Scanner per = new Scanner(System.in);
        System.out.println("Jimmy necesita ponerse fuerte!");
        System.out.println("\nDecide que actividades hará jimmy para ponerse fuerte, mientras mas intensiva la actividad\n" +
                " mas fuerte se hará jimmy, pero si su energía llega a 0, jimmmy morirá de cansancio D:!\n\n"+
                "Para evitar esto, jimmy tendrá que descansar, que empiece el entrenamiento!");
        boolean t=true;
        System.out.println("Introduzca su nombre: ");
        String coachito = per.nextLine();
        Persona perso = new Persona(coachito);
        do{x=perso.fuerte();
            if (x==false){
                break;
            }
            permenu();
            byte xp = per.nextByte(); per.nextLine();
            switch(xp){
                case 1:
                    perso.estado();
                    break;
                case 2:
                    ejermenu();
                    byte xqc = per.nextByte();
                    t=perso.ejercitar(xqc);
                    break;
                case 3:
                    t=perso.descansar();
                    break;
                case 0:
                    System.out.println(":c");
                    t=false;
                    break;
                default:
                    System.out.println("Opción errónea!");
            }

        } while(t==true);

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

    public static void permenu(){
        System.out.println("\n1. Verificar el estado de jimmy");
        System.out.println("2. Ejercitar");
        System.out.println("3. Descansar");
        System.out.println("0. Rendirse");
    }

    public static void ejermenu(){
        System.out.println("1. Mancuernas, 5 Lb");
        System.out.println("2. Martillo 10 Lb");
        System.out.println("3. Deadlift 15 Lb");
        System.out.println("4. Bench press 20 LB");
    }
}
