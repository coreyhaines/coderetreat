package com.coderetreat;

public class SwitcherImpl implements Switcher {

    @Override
    public void turnOn(Point point, boolean[][] lights) {
        lights[point.getX()][point.getY()] = true;
    }

    @Override
    public void turnOff(Point point, boolean[][] lights) {
        lights[point.getX()][point.getY()] = false;
    }

    @Override
    public void toggle(Point point, boolean[][] lights) {
        lights[point.getX()][point.getY()] = !lights[point.getX()][point.getY()];
    }
}
