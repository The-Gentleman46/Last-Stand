/// @DnDAction : YoYo Games.Instances.Destroy_Instance
/// @DnDVersion : 1
/// @DnDHash : 6697649D
instance_destroy();

/// @DnDAction : YoYo Games.Particles.Effect
/// @DnDVersion : 1
/// @DnDHash : 562D49B2
/// @DnDArgument : "x_relative" "1"
/// @DnDArgument : "y_relative" "1"
/// @DnDArgument : "type" "3"
/// @DnDArgument : "where" "1"
effect_create_above(3, x + 0, y + 0, 0, $FFFFFF & $ffffff);

/// @DnDAction : YoYo Games.Common.If_Variable
/// @DnDVersion : 1
/// @DnDHash : 3F191269
/// @DnDArgument : "var" "instance_number(Wood)"
/// @DnDArgument : "op" "1"
/// @DnDArgument : "value" "4"
if(instance_number(Wood) < 4){	/// @DnDAction : YoYo Games.Instances.Set_Instance_Var
	/// @DnDVersion : 1
	/// @DnDHash : 5FB9582A
	/// @DnDParent : 3F191269
	/// @DnDArgument : "value" "random(1000)"
	x = random(1000);

	/// @DnDAction : YoYo Games.Instances.Set_Instance_Var
	/// @DnDVersion : 1
	/// @DnDHash : 458F2801
	/// @DnDParent : 3F191269
	/// @DnDArgument : "value" "random(700)"
	/// @DnDArgument : "instvar" "1"
	y = random(700);

	/// @DnDAction : YoYo Games.Instances.Create_Instance
	/// @DnDVersion : 1
	/// @DnDHash : 5B268A3A
	/// @DnDParent : 3F191269
	/// @DnDArgument : "xpos" "x"
	/// @DnDArgument : "ypos" "y"
	/// @DnDArgument : "var" "inst"
	/// @DnDArgument : "objectid" "Wood"
	/// @DnDSaveInfo : "objectid" "Wood"
	inst = instance_create_layer(x, y, "Instances", Wood);}