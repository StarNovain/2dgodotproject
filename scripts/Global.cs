using Godot;
using System;

public class Global : Node
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    public int health {get; set;}
    public int guilt {get; set;}
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        health = 100;
        guilt = 100;
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
