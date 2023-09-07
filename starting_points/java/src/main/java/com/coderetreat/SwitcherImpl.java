package com.coderetreat;

public class SwitcherImpl implements Switcher {

    @Override
    public void turnOn(Point point, Light[][] lights) {
        lights[point.getX()][point.getY()].setBrightness(lights[point.getX()][point.getY()].getBrightness() + 1);
    }

    @Override
    public void turnOff(Point point, Light[][] lights) {
        if(lights[point.getX()][point.getY()].getBrightness() != 0)
            lights[point.getX()][point.getY()].setBrightness(lights[point.getX()][point.getY()].getBrightness() - 1);

    }

    @Override
    public void toggle(Point point, Light[][] lights) {
        lights[point.getX()][point.getY()].setBrightness(lights[point.getX()][point.getY()].getBrightness() + 2);
    }
}
