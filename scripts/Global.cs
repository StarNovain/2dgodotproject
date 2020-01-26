using Godot;
using System;

public class Global : Node
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    public float health {get; set;}
    public float guilt {get; set;}
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        health = 100;
        guilt = 0;
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
