namespace GMR.BLL
{
    public class PotentialContractorModel : ContractorModel
    {
        public string Error { set; get; }

        public bool IsValid => string.IsNullOrEmpty(Error);

        public override bool Equals(object obj)
        {
            if (obj is PotentialContractorModel contractor)
            {
                if (ReferenceEquals(this, contractor))
                    return true;

                return ContractorID == contractor.ContractorID &&
                       Name == contractor.Name;
            }

            return base.Equals(obj);
        }
    }
}
