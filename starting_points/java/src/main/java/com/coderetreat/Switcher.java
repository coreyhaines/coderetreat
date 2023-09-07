package com.coderetreat;

public interface Switcher {
    public void turnOn(Point point, Light[][] lights);
    public void turnOff(Point point, Light[][] lights);
    public void toggle(Point point, Light[][] lights);
}
