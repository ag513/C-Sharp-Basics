    class Member
    {
        protected int annualFee;
        private string name;
        private int memberID;
        private int memberSince;

        public override string ToString()
        {
            return "\nName: " + name + "\nMember ID: " + memberID +
                    "\nMember Since: " + memberSince + "\nTotal Annual Fee: " +
                    annualFee;

        }

        public Member()
        {
            Console.WriteLine("parent constructor with no parameter");
        }
        public Member(string pName, int pMemberID, int pMemberSince)
        {
            Console.WriteLine("parent constructor with 3 parameters");

            name = pName;
            memberID = pMemberID;
            memberSince = pMemberSince;
        }

        public virtual void CalculateAnnualFee()
        {
            annualFee = 0;
        }
    }

    class NormalMember : Member
    {
        public NormalMember()
        {
            Console.WriteLine("Child constructor with no parameter");
        }



        public NormalMember(string remarks,string name,int memberID,int memberSince) : base(name, memberID,memberSince)
        {
            Console.WriteLine("Child Constructor with 4 parameters");
            Console.WriteLine("Remarks = {0}", remarks);
        }

        public override void CalculateAnnualFee()
        {
            annualFee = 100 + 12 * 30;
        }
    }

    class VIPMember : Member
    {
        public VIPMember(string name, int memberID, int memberSince) : base(name, memberID, memberSince)
        {
            Console.WriteLine("Child Constructor with 3 parameters");
        }

        public override void CalculateAnnualFee()
        {
            annualFee = 1200;
        }

    }
}
