package com.coderetreat;

public interface Switcher {
    public void turnOn(Point point, boolean lights[][]);
    public void turnOff(Point point, boolean lights[][]);
    public void toggle(Point point, boolean lights[][]);
}
