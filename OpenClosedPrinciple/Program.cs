/* Open/Closed Principle-->  The principle says that "software entities {classes, module, function etc.} should be open for extesnion but closed for modification"
                       which means you should be able to extend class behaviour without modifying it.

ex-> you have class called PaymentProcessor that process payments for an online store. Initiall, the payment processor class only support creditcard.
      However you want to extend its functionality to aslo support processing payment using paypal.
     Insted of modifying the exisgint payment process class to add paypal support, you can create a new class class PaypalPaymentProcessor, that 
    extends the payment processor class. This way PaymentProcessor class remain closded for modification but open for extension.
*/


using System;

namespace OpenClosedPrinciple
{
    public abstract class PaymentProcessor
    {
        public abstract void ProcessPayment(double amount);
    }

    public class CreditPaymentProcessor : PaymentProcessor
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine("Processing credit card payment of " + amount);
        }
    }

    public class PaypalPaymentProcessor : PaymentProcessor
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount}");
        }
    }

    class Program
    {
        static void ProcessPayment(PaymentProcessor processor, double amount)
        {
            processor.ProcessPayment(amount);
        }

        static void Main(string[] args)
        {
            CreditPaymentProcessor cpp = new CreditPaymentProcessor();
            PaypalPaymentProcessor ppp = new PaypalPaymentProcessor();

            ProcessPayment(cpp, 100.00);
            ProcessPayment(ppp, 150.00);

            Console.ReadLine();
        }
    }
}

