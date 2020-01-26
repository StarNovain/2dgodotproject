using Godot;
using System;

public class Bullet : KinematicBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    Vector2 vector;
    Vector2 pPos;
    const float SPEED = 250;

    void move() {

    }
 
    
    public override void _Ready()
    {
        var CombatP = (Node2D) GetParent().GetNode("CombatPlayer");
        pPos = CombatP.GetPosition();
        Random xPos = new Random();
        this.Position.Set(xPos.Next(0,960),0);
        
        vector = (pPos - this.GetPosition()).Normalized();
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        this.SetPosition(this.GetPosition()+vector*SPEED*delta);
        if(pPos.x < -32||pPos.x > 992||pPos.y > 572) {
            this.QueueFree();
        }
    }
}
