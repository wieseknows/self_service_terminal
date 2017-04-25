namespace Self_ServiceTerminal
{
    public class CardOwner
    {
        public string cardNumber;
        public string cardOwnerName;
        public int cardCurrentBalance;
        public byte cardValidMonth;
        public byte cardValidYear;
        public string cardPassword;
        public bool cardBlocked;
        
        public string lastMobileNumber;
        public string lastMobileOperator;

        public string lastWebmoneyPurse;

        public string lastCreditNumber;
        public string lastBank;
        public string lastBankBranch;

        public void setLastMobileCommunication(string mobileNumber, string mobileOperator)
        {
            lastMobileNumber = mobileNumber;
            lastMobileOperator = mobileOperator;
        }

        public void setLastWebmoneyOperation(string webmoneyPurse)
        {
            lastWebmoneyPurse = webmoneyPurse;
        }

        public void setLastCreditOperation(string creditNumber, string bank, string bankBranch)
        {
            lastBank = bank;
            lastCreditNumber = creditNumber;
            lastBankBranch = bankBranch;
        }
    }
}
