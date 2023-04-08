namespace BatallaNaval
{
    internal class Program
    {
        public const string seaCharacter = "~ ";
        public const string boatCell = "Y ";
        public const string wrongLocation = "X ";
        public const string correctLocation = "0 ";

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("BIENVENIDO A ASTUCIA NAVAL");
            int num1 = int.Parse(Console.ReadLine());

            int jugador1 = 1;
            int jugador2 = 2;
            string turno = "Primer Jugador";
            int[] filas = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] columnas = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            int fila, columna, cont = 0;

            Console.WriteLine("Ingrese la posicion del barco en el plano, ingrese su coordenada ---> x,y");
            string boatPosition = Console.ReadLine();
            string[] coordinates = boatPosition.Split(',');

            int[,] multidimensionalArray = new int[10, 10];

            var rows = multidimensionalArray.GetLength(0);
            var columns = multidimensionalArray.GetLength (1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 1; j < columns; j++);
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(seaCharacter);
                }
                Console.WriteLine();
            }

        }
    }
}