using Godot;
using System;

public class Bullet : KinematicBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    void move() {

    }
    
    public override void _Ready()
    {
        var CombatP = (Node2D) GetNode("CombatPlayer");
        var pPos = CombatP.GetPosition();

        this.Position.Set(0,0);
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  //public override void _Process(float delta)
//  {
//
//  }
}
