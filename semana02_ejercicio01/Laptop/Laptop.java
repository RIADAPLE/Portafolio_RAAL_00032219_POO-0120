package com.RAAL.x00032219;

public class Laptop {
    private String marca;
    private String usuario;
    private double space = 250.00;

    public Laptop(){
        System.out.println("Se está encendiento la compu...");
    }

    public Laptop(String pmarca, String pusuario){
        marca=pmarca;
        usuario=pusuario;
    }
    public void encender(){
        System.out.println("\nBienvenido "+ usuario+ " estás usando "+ marca);
    }

    public void espacio(){
        System.out.println(space+" GB");
    }

    public void programitas(byte xp){

        switch(xp){
            case 1: space-=0.05;
            if(space<=0){
                System.out.println("no hay espacio suficiente!");
                space+=0.05;
                break;
            }else
            break;
            case 2: space-=0.2;
                if(space<=0){
                    System.out.println("no hay espacio suficiente!");
                    space+=0.2;
                    break;
                }else
            break;
            case 3: space-=7.5;
                if(space<=0){
                    System.out.println("no hay espacio suficiente!");
                    space+=7.5;
                    break;
                }else
                    break;
            case 4: space-=30.5;
                if(space<=0){
                    System.out.println("no hay espacio suficiente!");
                    space+=30.5;
                    break;
                }else
                    break;
        }
    }
    public void formatear(){
        space=250.00;
    }
}
