using System;
using HomeQuarantine.Data.Models.Enums;
using HomeQuarantine.Data.Resources.Languages;

namespace HomeQuarantine.Extensions
{
	public static class SymptomExtension
	{
		public static string GetDescription(this SymptomType symptomType)
		{
			return symptomType switch
			{
				SymptomType.Fever => Resources.SymptomType_Fever, 
				SymptomType.Cough => Resources.SymptomType_Cough, 
				SymptomType.ShortnessOfBreath => Resources.SymptomType_ShortnessOfBreath, 
				SymptomType.SoreThroat => Resources.SymptomType_SoreThroat, 
				SymptomType.RunnyNose => Resources.SymptomType_RunnyNose, 
				SymptomType.LossOfSmell => Resources.SymptomType_LossOfSmell, 
				SymptomType.LossOfTaste => Resources.SymptomType_LossOfTaste, 
				SymptomType.Other => Resources.SymptomType_Other, 
				_ => throw new InvalidOperationException("Unknown symptom type"), 
			};
		}
	}
}
