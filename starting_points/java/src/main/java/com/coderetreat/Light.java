package com.coderetreat;

public class Light {
    private static int brightness = 0;

    public Light(int brightness) {
        this.brightness = brightness;
    }

    public int getBrightness() {
        return brightness;
    }

    public void setBrightness(int brightness) {
        this.brightness = brightness;
    }
}
