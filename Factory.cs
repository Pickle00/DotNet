using System;


public interface CreditCard{
    string GetCardType();
    int GetCreditLimit();
    int GetAnnualCharge();


}

class MoneyBack : CreditCard{
    public string GetCardType(){
        return "MoneyBack";
    }

    public int GetCreditLimit(){
        return 5000;
    }

    public int GetAnnualCharge(){
        return 100;
    }
}
class Platinum : CreditCard{
    public string GetCardType(){
        return "Platinum";
    }

    public int GetCreditLimit(){
        return 15000;
    }

    public int GetAnnualCharge(){
        return 200;
    }
}
class Titanum : CreditCard{
    public string GetCardType(){
        return "Titanum";
    }

    public int GetCreditLimit(){
        return 25000;
    }

    public int GetAnnualCharge(){
        return 500;
    }
}
  


public class CreditCardFactory
{

    public static CreditCard GetCreditCard(string cardType)
    {
        CreditCard cardDetails = null;

        if (cardType == "MoneyBack")
        {
            cardDetails = new MoneyBack();
        }
        else if (cardType == "Platinum")
        {
            cardDetails = new Platinum();
        }
        else if (cardType == "Titanum")
        {
            cardDetails = new Titanum();
        }

        return cardDetails;
    }

}


// base.cost(base.cost()+2)+2