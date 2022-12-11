

namespace atm_uygulamasi
{
    class KartSahibi
    {
        string cardNum;
        int pin;
        string firstName;
        string lastName;
        double balance;

        public KartSahibi(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public string getNum()
        {
            return cardNum;
        }

        public int getPin()
        {
            return pin;
        }

        public string getFirstName()
        {
            return firstName;
        }
         public string getLastName()
        {
            return lastName;
        }

         public double getBalance()
        {
            return balance;
        }

        public void setNum(String newCardNum)
        {
            cardNum = newCardNum;
        }

         public void setPin(int newPin)
        {
            pin = newPin;
        }

         public void setFirstName(String newFirstName)
        {
            firstName = newFirstName;
        }

         public void setLastName(String newLastName)
        {
            lastName = newLastName;
        }

         public void setBalance(double newBalance)
        {
            balance = newBalance;
        }
    }
}