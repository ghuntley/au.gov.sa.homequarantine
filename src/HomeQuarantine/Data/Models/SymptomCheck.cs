using System.Collections.Generic;

namespace HomeQuarantine.Data.Models
{
	public class SymptomCheck
	{
		public bool HasNoSymptomsChecked { get; set; }

		public ICollection<Symptom> Symptoms { get; set; } = new List<Symptom>();


		public string DescriptionOthers { get; set; }
	}
}
