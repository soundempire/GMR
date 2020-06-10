namespace GMR.BLL
{
    public class PotentialContractorModel : ContractorModel
    {
        public string Error { set; get; }

        public bool IsValid => string.IsNullOrEmpty(Error);
    }
}
