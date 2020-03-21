package com.RAAL.x00032219;

public class Persona {
    private byte energia=10;
    private byte fuerza=0;
    private String coach;
    public Persona(String Pcoach){
        System.out.println("Entrenador "+Pcoach+"!");
        coach = Pcoach;
    }

    public void estado(){
        System.out.println("Jimmy tiene: ");
        System.out.println(energia+" de energía y "+fuerza+ " de fuerza (necesita 10)");
    }

    public boolean fuerte(){
        if(fuerza>=10){
            System.out.println("Jimmy está cholo!\nhas ganado!");
            return false;
        }
        return true;
    }

    public boolean descansar(){
        if(energia>=14){
            System.out.println("Jimmy murió de hueva");
            return false;
        }
        else
            energia+=4;
        return true;
    }

    public boolean ejercitar(byte xqc){
        switch(xqc){
            case 1:
                fuerza+=1;
                energia-=2;
                if (energia<=0){
                    System.out.println("Se murió :c");
                    return false;
                }else
                    return true;
            case 2:
                fuerza+=2;
                energia-=4;
                if (energia<=0){
                    System.out.println("Se murió :c");
                    return false;
                }else
                    return true;
            case 3:
                fuerza+=3;
                energia-=5;
                if (energia<=0){
                    System.out.println("Se murió :c");
                return false;
                }else
                return true;
            case 4:
                fuerza+=6;
                energia-=7;
                if (energia<=0){
                    System.out.println("Se murió :c");
                    return false;
                }else
                    return true;
            default:
                System.out.println("Opción erronea!");
                return true;
        }
    }
}
