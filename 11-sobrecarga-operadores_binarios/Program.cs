namespace SobrecargaOperadoresBinarios
{
    class Program
    {
        public static void Main ()
        {
            Imaginario img1 = new Imaginario(1, 2);
            Imaginario img2 = new Imaginario(3, 4);
            Imaginario img3 = new Imaginario(1, 2);
            Imaginario resImg;

            //Operadores de igualdad
            if(img1 == img3)
            {
                Console.WriteLine("{0} y {1} son iguales!", img1, img3);
            }

            if(img1 != img2)
            {
                Console.WriteLine("{0} y {1} son distintos!", img1, img2);
            }

            //Suma
            resImg = img1 + img2;
            Console.WriteLine("{0} + {1} = {2}", img1, img2, resImg);

            //Resta
            resImg = img1 - img2;
            Console.WriteLine("{0} - {1} = {2}", img1, img2, resImg);

            //Multiplicacion
            resImg = img1 * img2;
            Console.WriteLine("{0} * {1} = {2}", img1, img2, resImg);

            //Division
            resImg = img1 / img2;
            Console.WriteLine("{0} / {1} = {2}", img1, img2, resImg);

            //++
            Console.WriteLine("{0}++ = {1}", img1, img1++);

            //--
            Console.WriteLine("{0}-- = {1}", img1, img1--);

            //+=
            Console.WriteLine("{0} += {1} => {2}", img1, img2, img1 += img2);

            //-=
            Console.WriteLine("{0} -= {1} => {2}", img1, img2, img1 -= img2);

            //<
            if(img1 < img2)
            {
                Console.WriteLine("Es mayor!");
            }

            if(img2 > img1)
            {
                Console.WriteLine("Es menor!");
            }
        }
    }
}