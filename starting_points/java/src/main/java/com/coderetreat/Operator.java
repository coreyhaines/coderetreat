package com.coderetreat;

public class Operator {
    private static Light lights[][] = new Light[999][999];
    private static Switcher switcher = new SwitcherImpl();
    public static void operateThrough(Point p1, Point p2 , String operation){
        for(int i = p1.x ; i <= p2.x ;i++){
            for(int j = p1.y; j <= p2.y; j++){
                switch (operation){
                    case "on":
                        switcher.turnOn(new Point(i,j),lights);
                        break;
                    case "off":
                        switcher.turnOff(new Point(i,j),lights);
                        break;
                    case "toggle":
                        switcher.toggle(new Point(i,j),lights);
                        break;
                    default:
                        break;
                }
            }
        }
    }
    public static int BrightnessCounter(){
        int brightness = 0;
        for(int i = 0 ; i <= 999 ; i++){
            for(int j = 0 ; j <= 999 ; j++){
                brightness =+ lights[i][j].getBrightness();
            }
        }
        return brightness;
    }

}
