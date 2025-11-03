/// @DnDAction : YoYo Games.Instances.Destroy_Instance
/// @DnDVersion : 1
/// @DnDHash : 6A3D11A9
instance_destroy();

/// @DnDAction : YoYo Games.Particles.Effect
/// @DnDVersion : 1
/// @DnDHash : 50719665
/// @DnDArgument : "x_relative" "1"
/// @DnDArgument : "y_relative" "1"
/// @DnDArgument : "type" "3"
/// @DnDArgument : "where" "1"
/// @DnDArgument : "size" "1"
effect_create_above(3, x + 0, y + 0, 1, $FFFFFF & $ffffff);

/// @DnDAction : YoYo Games.Common.If_Variable
/// @DnDVersion : 1
/// @DnDHash : 2A1C13A3
/// @DnDArgument : "var" "instance_number(Metal)"
/// @DnDArgument : "op" "1"
/// @DnDArgument : "value" "1"
if(instance_number(Metal) < 1){	/// @DnDAction : YoYo Games.Instances.Set_Instance_Var
	/// @DnDVersion : 1
	/// @DnDHash : 65FCF3B3
	/// @DnDParent : 2A1C13A3
	/// @DnDArgument : "value" "random(1000)"
	x = random(1000);

	/// @DnDAction : YoYo Games.Instances.Set_Instance_Var
	/// @DnDVersion : 1
	/// @DnDHash : 585D2CB3
	/// @DnDParent : 2A1C13A3
	/// @DnDArgument : "value" "random(700)"
	/// @DnDArgument : "instvar" "1"
	y = random(700);

	/// @DnDAction : YoYo Games.Instances.Create_Instance
	/// @DnDVersion : 1
	/// @DnDHash : 46ABB729
	/// @DnDParent : 2A1C13A3
	/// @DnDArgument : "xpos" "x"
	/// @DnDArgument : "ypos" "y"
	/// @DnDArgument : "var" "inst"
	/// @DnDArgument : "objectid" "Metal"
	/// @DnDSaveInfo : "objectid" "Metal"
	inst = instance_create_layer(x, y, "Instances", Metal);}