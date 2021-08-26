using System.ComponentModel;

namespace HomeQuarantine.Data.Enums
{
	public enum IProovFailCode
	{
		[Description("ambiguous_outcome")]
		AmbiguousOutcome,
		[Description("motion_too_much_movement")]
		TooMuchMovement,
		[Description("lighting_flash_reflection_too_low")]
		BrightnessTooLow,
		[Description("lighting_backlit")]
		Backlit,
		[Description("lighting_too_dark")]
		TooDark,
		[Description("lighting_face_too_bright")]
		FaceTooBright,
		[Description("motion_too_much_mouth_movement")]
		TooMuchMouthMovement
	}
}
