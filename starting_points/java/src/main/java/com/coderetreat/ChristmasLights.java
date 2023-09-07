package com.coderetreat;

import static com.coderetreat.Operator.BrightnessCounter;
import static com.coderetreat.Operator.operateThrough;

class ChristmasLights{

    public static void main(String s[]){
        Point p1,p2;
        // 1  turn on 887,9 through 959,629
        p1 = new Point(887,9);
        p2 = new Point(959,629);
        operateThrough(p1, p2, "on");
        //2  turn on 454,398 through 844,448
        p1 = new Point(454,398);
        p2 = new Point(844,448);
        operateThrough(p1, p2, "on");
        //3 turn off 539,243 through 559,965
        p1 = new Point(539,243);
        p2 = new Point(559,965);
        operateThrough(p1, p2, "off");
        //4 turn off 370,819 through 676,868
        p1 = new Point(370,819);
        p2 = new Point(676,868);
        operateThrough(p1, p2, "off");
        //5 turn off 145,40 through 370,997
        p1 = new Point(145,40);
        p2 = new Point(844,448);
        operateThrough(p1, p2, "off");
        //6 turn off 301,3 through 808,453
        p1 = new Point(454,398);
        p2 = new Point(844,448);
        operateThrough(p1, p2, "off");
        //7  turn on 351,678 through 951,908
        p1 = new Point(454,398);
        p2 = new Point(844,448);
        operateThrough(p1, p2, "on");
        //8   toggle 720,196 through 897,994
        p1 = new Point(454,398);
        p2 = new Point(844,448);
        operateThrough(p1, p2, "toggle");
        //9  toggle 831,394 through 904,860
        p1 = new Point(454,398);
        p2 = new Point(844,448);
        operateThrough(p1, p2, "toggle");

        System.out.println(BrightnessCounter());

    }


}
