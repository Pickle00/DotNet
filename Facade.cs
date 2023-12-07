class ProductSystem{
    public void GetProductDetails(){
        Console.WriteLine("Fetching Product Details");
    }
}


class PaymentSystem{
    public void MakePayment(){
        Console.WriteLine("Payment Done Successfully");
    }
}

class InvoiceSystem{
    public void Invoice(){
        Console.WriteLine("Invoice Recieved");
    }
}


class OrderFacade{
    private ProductSystem product;
    private PaymentSystem payment;
    private InvoiceSystem invoice;


    public OrderFacade(){
        product = new ProductSystem();
        payment = new PaymentSystem();
        invoice = new InvoiceSystem();
    }

    public void placeOrder(){
        product.GetProductDetails();
        payment.MakePayment();
        invoice.Invoice();
    }
    
}

// class Client{
//     static void Main(string[] args){
//         OrderFacade orderFacade = new OrderFacade();
//         orderFacade.placeOrder();
//     }
// }