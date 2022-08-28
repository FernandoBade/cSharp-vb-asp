namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            int i = 100000;
                        byte b = (byte) i;
                        Console.WriteLine(i);*/

            try
            {
                /*                var number = "1234";
                                byte b = Convert.ToByte(number);
                                Console.WriteLine(b);*/

                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);

            }
            catch (Exception)
            {
                Console.WriteLine("O número não pode ser covertido para o tipo 'byte'.");                
            }


        }
    }
}