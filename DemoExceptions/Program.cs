namespace DemoExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // return;             -- wenn try nicht ausgefuehrt wird, auch kein finally
            try
            {
                // return;         // -- wenn try ausgefuehrt wird, dann auch ein finally
                Method_A();
            }
            catch (MyException ex)  //  keine Behandlung, zum naechsten catch
            {

            }
            catch (Exception ex)    // Exception wird behandelt, daher wuerden auch keine weiteren catch's mehr behandelt
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
            finally
            {
                Console.WriteLine("Hello World");
            }
            Console.WriteLine("Nach dem try und catch");
        }

        static void Method_A()
        {
            ThrowAnException("Aufruf einer Methode ohne Handling");
        }

        static void ThrowAnException(string text)
        {
            throw new MyException(10, text);
        }
    }
}
