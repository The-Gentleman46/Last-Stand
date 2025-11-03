/// @DnDAction : YoYo Games.Mouse & Keyboard.If_Key_Down
/// @DnDVersion : 1
/// @DnDHash : 703F75E5
/// @DnDArgument : "key" "vk_left"
var l703F75E5_0;l703F75E5_0 = keyboard_check(vk_left);if (l703F75E5_0){	/// @DnDAction : YoYo Games.Instances.Set_Sprite
	/// @DnDVersion : 1
	/// @DnDHash : 31C23BF0
	/// @DnDParent : 703F75E5
	/// @DnDArgument : "imageind_relative" "1"
	/// @DnDArgument : "spriteind" "spr_JoeBodham_walk"
	/// @DnDSaveInfo : "spriteind" "spr_JoeBodham_walk"
	sprite_index = spr_JoeBodham_walk;
	image_index += 0;

	/// @DnDAction : YoYo Games.Instances.Set_Instance_Var
	/// @DnDVersion : 1
	/// @DnDHash : 74F44DD8
	/// @DnDParent : 703F75E5
	/// @DnDArgument : "value" "-5"
	/// @DnDArgument : "value_relative" "1"
	x += -5;}

/// @DnDAction : YoYo Games.Mouse & Keyboard.If_Key_Released
/// @DnDVersion : 1
/// @DnDHash : 65446982
/// @DnDArgument : "key" "vk_left"
var l65446982_0;l65446982_0 = keyboard_check_released(vk_left);if (l65446982_0){	/// @DnDAction : YoYo Games.Instances.Set_Sprite
	/// @DnDVersion : 1
	/// @DnDHash : 3A01D58E
	/// @DnDParent : 65446982
	/// @DnDArgument : "imageind_relative" "1"
	/// @DnDArgument : "spriteind" "spr_JoeBodham"
	/// @DnDSaveInfo : "spriteind" "spr_JoeBodham"
	sprite_index = spr_JoeBodham;
	image_index += 0;}

/// @DnDAction : YoYo Games.Common.Else
/// @DnDVersion : 1
/// @DnDHash : 295F4F23
else{	/// @DnDAction : YoYo Games.Mouse & Keyboard.If_Key_Down
	/// @DnDVersion : 1
	/// @DnDHash : 5CBB1FB6
	/// @DnDParent : 295F4F23
	/// @DnDArgument : "key" "vk_up"
	var l5CBB1FB6_0;l5CBB1FB6_0 = keyboard_check(vk_up);if (l5CBB1FB6_0){	/// @DnDAction : YoYo Games.Instances.Set_Sprite
		/// @DnDVersion : 1
		/// @DnDHash : 64CF71B5
		/// @DnDParent : 5CBB1FB6
		/// @DnDArgument : "imageind_relative" "1"
		/// @DnDArgument : "spriteind" "spr_JoeBodham_walk"
		/// @DnDSaveInfo : "spriteind" "spr_JoeBodham_walk"
		sprite_index = spr_JoeBodham_walk;
		image_index += 0;
	
		/// @DnDAction : YoYo Games.Instances.Set_Instance_Var
		/// @DnDVersion : 1
		/// @DnDHash : 1CA17896
		/// @DnDParent : 5CBB1FB6
		/// @DnDArgument : "value" "-5"
		/// @DnDArgument : "value_relative" "1"
		/// @DnDArgument : "instvar" "1"
		y += -5;}

	/// @DnDAction : YoYo Games.Mouse & Keyboard.If_Key_Released
	/// @DnDVersion : 1
	/// @DnDHash : 0B6030A9
	/// @DnDParent : 295F4F23
	/// @DnDArgument : "key" "vk_up"
	var l0B6030A9_0;l0B6030A9_0 = keyboard_check_released(vk_up);if (l0B6030A9_0){	/// @DnDAction : YoYo Games.Instances.Set_Sprite
		/// @DnDVersion : 1
		/// @DnDHash : 07D46C35
		/// @DnDParent : 0B6030A9
		/// @DnDArgument : "imageind_relative" "1"
		/// @DnDArgument : "spriteind" "spr_JoeBodham"
		/// @DnDSaveInfo : "spriteind" "spr_JoeBodham"
		sprite_index = spr_JoeBodham;
		image_index += 0;}

	/// @DnDAction : YoYo Games.Common.Else
	/// @DnDVersion : 1
	/// @DnDHash : 1167A5A9
	/// @DnDParent : 295F4F23
	else{	/// @DnDAction : YoYo Games.Mouse & Keyboard.If_Key_Down
		/// @DnDVersion : 1
		/// @DnDHash : 3A732359
		/// @DnDParent : 1167A5A9
		/// @DnDArgument : "key" "vk_right"
		var l3A732359_0;l3A732359_0 = keyboard_check(vk_right);if (l3A732359_0){	/// @DnDAction : YoYo Games.Instances.Set_Sprite
			/// @DnDVersion : 1
			/// @DnDHash : 61BA67A0
			/// @DnDParent : 3A732359
			/// @DnDArgument : "imageind_relative" "1"
			/// @DnDArgument : "spriteind" "spr_JoeBodham_walk"
			/// @DnDSaveInfo : "spriteind" "spr_JoeBodham_walk"
			sprite_index = spr_JoeBodham_walk;
			image_index += 0;
		
			/// @DnDAction : YoYo Games.Instances.Set_Instance_Var
			/// @DnDVersion : 1
			/// @DnDHash : 0306330F
			/// @DnDParent : 3A732359
			/// @DnDArgument : "value" "5"
			/// @DnDArgument : "value_relative" "1"
			x += 5;}
	
		/// @DnDAction : YoYo Games.Mouse & Keyboard.If_Key_Released
		/// @DnDVersion : 1
		/// @DnDHash : 377E0D8D
		/// @DnDParent : 1167A5A9
		/// @DnDArgument : "key" "vk_right"
		var l377E0D8D_0;l377E0D8D_0 = keyboard_check_released(vk_right);if (l377E0D8D_0){	/// @DnDAction : YoYo Games.Instances.Set_Sprite
			/// @DnDVersion : 1
			/// @DnDHash : 122C187A
			/// @DnDParent : 377E0D8D
			/// @DnDArgument : "imageind_relative" "1"
			/// @DnDArgument : "spriteind" "spr_JoeBodham"
			/// @DnDSaveInfo : "spriteind" "spr_JoeBodham"
			sprite_index = spr_JoeBodham;
			image_index += 0;}
	
		/// @DnDAction : YoYo Games.Common.Else
		/// @DnDVersion : 1
		/// @DnDHash : 24577800
		/// @DnDParent : 1167A5A9
		else{	/// @DnDAction : YoYo Games.Mouse & Keyboard.If_Key_Down
			/// @DnDVersion : 1
			/// @DnDHash : 7C424888
			/// @DnDParent : 24577800
			/// @DnDArgument : "key" "vk_down"
			var l7C424888_0;l7C424888_0 = keyboard_check(vk_down);if (l7C424888_0){	/// @DnDAction : YoYo Games.Instances.Set_Sprite
				/// @DnDVersion : 1
				/// @DnDHash : 38E8712B
				/// @DnDParent : 7C424888
				/// @DnDArgument : "imageind_relative" "1"
				/// @DnDArgument : "spriteind" "spr_JoeBodham_walk"
				/// @DnDSaveInfo : "spriteind" "spr_JoeBodham_walk"
				sprite_index = spr_JoeBodham_walk;
				image_index += 0;
			
				/// @DnDAction : YoYo Games.Instances.Set_Instance_Var
				/// @DnDVersion : 1
				/// @DnDHash : 5001F529
				/// @DnDParent : 7C424888
				/// @DnDArgument : "value" "5"
				/// @DnDArgument : "value_relative" "1"
				/// @DnDArgument : "instvar" "1"
				y += 5;}
		
			/// @DnDAction : YoYo Games.Mouse & Keyboard.If_Key_Released
			/// @DnDVersion : 1
			/// @DnDHash : 339DA9EA
			/// @DnDParent : 24577800
			/// @DnDArgument : "key" "vk_down"
			var l339DA9EA_0;l339DA9EA_0 = keyboard_check_released(vk_down);if (l339DA9EA_0){	/// @DnDAction : YoYo Games.Instances.Set_Sprite
				/// @DnDVersion : 1
				/// @DnDHash : 2D706D05
				/// @DnDParent : 339DA9EA
				/// @DnDArgument : "imageind_relative" "1"
				/// @DnDArgument : "spriteind" "spr_JoeBodham"
				/// @DnDSaveInfo : "spriteind" "spr_JoeBodham"
				sprite_index = spr_JoeBodham;
				image_index += 0;}}}}