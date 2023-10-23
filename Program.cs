namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How Many Laptops Will There Be : ");
            int countController = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if(countController > 0)
            {
                Notebook[] noteBooksArray = new Notebook[countController];
                for (int i = 0; i < noteBooksArray.Length; i++)
                {
                    Console.Write("Enter Laptops Count : ");
                    int laptopsCount = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Laptops Price : ");
                    int laptopsPrice = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Laptops Model : ");
                    string laptopsModel = Console.ReadLine();

                    noteBooksArray[i] = new Notebook(laptopsCount, laptopsPrice, laptopsModel)
                    {
                        Brand = Console.ReadLine(),
                        Ram = Convert.ToByte(Console.ReadLine()),
                        Storage = Convert.ToInt32(Console.ReadLine())

                    };
                }
            }
            else
            {
                Console.WriteLine("Say Menfi Ola Bilmez");
            }

            

        }
    }
}