extends Control


# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.
	print("Hello!")


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	pass

func tab_interaction(tab):
	if tab == 0:
		pass
	elif tab == 1:
		pass
	elif tab == 2:
		pass
	elif tab == 3:
		pass
	elif tab == 4:
		pass
	elif tab == 5:
		$MainPagePart.visible = false
		$SignInUp.visible = true
	else:
		print("Nothing picked!")
