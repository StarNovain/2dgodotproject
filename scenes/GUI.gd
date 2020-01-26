extends Control

# Declare member variables here. Examples:
# var a = 2
# var b = "text"

# Called when the node enters the scene tree for the first time.
onready var global = get_node("/root/Global")
func _ready():
	pass # Replace with function body.

# Called every frame. 'delta' is the elapsed time since the previous frame.
#func _process(delta):
#	pass
func update(): 
    var amount = global.health
    if (amount < 0): amount = 0
    if(amount > 100): amount = 100
    $"HealthBar/HealthFill".region_rect = Rect2(0,0,(amount * 1.13),12)

func _on_CombatPlayer_UpdateHealth():
	update()
	pass # Replace with function body.
