namespace Hospital_system
{
    public class MedicalJournal
    {
        public List<string> Diagnoses { get; set; }
        public List<string> Treatments { get; set; }
        public string PreviousVisits { get; set; }
        public string NextVisit { get; set; }

        public MedicalJournal()
        {
            Diagnoses = new List<string>();
            Treatments = new List<string>();
        }

        public void AddDiagnosis(string diagnosis)
        {
            Diagnoses.Add(diagnosis);
        }

        public void AddTreatment(string treatment)
        {
            Treatments.Add(treatment);
        }

        public void AddPreviousVisit(string visit)
        {
            PreviousVisits = visit;
        }

        public void AddNextVisit(string visit)
        {
            NextVisit = visit;
        }

        public override string ToString()
        {
            return $"Diagnoses: {string.Join(", ", Diagnoses)}, Treatments: {string.Join(", ", Treatments)}, Previous Visits: {PreviousVisits}, Next Visit: {NextVisit}";
        }
    }
}
