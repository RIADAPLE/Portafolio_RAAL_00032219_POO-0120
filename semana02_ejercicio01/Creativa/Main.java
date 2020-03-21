package com.RAAL.x00032219;
import com.RAAL.x00032219.Persona;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner per = new Scanner(System.in);
        System.out.println("Jimmy necesita ponerse fuerte!");
        System.out.println("\nDecide que actividades hará jimmy para ponerse fuerte, mientras mas intensiva la actividad\n" +
                " mas fuerte se hará jimmy, pero si su energía llega a 0, jimmmy morirá de cansancio D:!\n\n"+
        "Para evitar esto, jimmy tendrá que descansar, que empiece el entrenamiento!");
        boolean x=true;
        System.out.println("Introduzca su nombre: ");
        String coachito = per.nextLine();
        Persona perso = new Persona(coachito);
        do{x=perso.fuerte();
        if (x==false){
            break;
        }
            menu();
        byte xp = per.nextByte(); per.nextLine();
        switch(xp){
            case 1:
                perso.estado();
                break;
            case 2:
                ejermenu();
                byte xqc = per.nextByte();
                x=perso.ejercitar(xqc);
                break;
            case 3:
                x=perso.descansar();
                break;
            case 0:
                System.out.println(":c");
                x=false;
                break;
            default:
                System.out.println("Opción errónea!");
        }

        } while(x==true);

    }
    public static void menu(){
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
