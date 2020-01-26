using Godot;
using System;

public class HealthBar : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    Global global;
    Sprite fill;
    private void update(){
        float amount = global.health;
        if (amount < 0) amount = 0;
        if(amount > 100) amount = 100;
        fill.RegionRect = new Rect2(0,0,((float) amount * (float) 1.13),12);
    }
    public override void _Ready()
    {
        global = (Global)GetNode("/root/Global");
        fill = (Sprite)GetNode("HealthFill");
        update();
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
}
