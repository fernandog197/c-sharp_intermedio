using System;

namespace SobrecargaOperadoresBinarios
{
    class Imaginario : IComparable
    {
        //Atributos
        private double entero;
        private double nImaginario;

        public Imaginario (double entero, double nImaginario)
        {
            this.entero = entero;
            this.nImaginario = nImaginario;
        }

        //Getters & Setters
        public double Entero { get => this.entero; set => this.entero = value; }
        public double NImaginario { get => this.nImaginario; set => this.nImaginario = value; }

        //Mostrar el numero imaginario
        public override string ToString()
        {
            if(this.nImaginario < 0)
            {
                return string.Format("<{0} {1}i>", this.entero, this.nImaginario);
            }
            else
            {
                return string.Format("<{0} + {1}i>", this.entero, this.nImaginario);
            }
        }

        //Sobrecarga de operadores binarios
        public static Imaginario operator + (Imaginario img1, Imaginario img2)
        {
            double iEnt = 0;
            double iImg = 0;

            iEnt = img1.Entero + img2.Entero;
            iImg = img1.NImaginario + img2.NImaginario;

            Imaginario aux = new Imaginario(iEnt, iImg);

            return aux;
        }

        public static Imaginario operator - (Imaginario img1, Imaginario img2)
        {
            double iEnt = 0;
            double iImg = 0;

            iEnt = img1.Entero - img2.Entero;
            iImg = img1.NImaginario - img2.NImaginario;

            Imaginario aux = new Imaginario(iEnt, iImg);

            return aux;
        }

        public static Imaginario operator * (Imaginario img1, Imaginario img2)
        {
            double iEnt = 0;
            double iImg = 0;

            iEnt = (img1.Entero * img2.Entero) - (img1.NImaginario * img2.NImaginario);
            iImg = (img1.Entero * img2.NImaginario) + (img1.NImaginario * img2.Entero);

            Imaginario aux = new Imaginario(iEnt, iImg);

            return aux;
        }

        public static Imaginario operator / (Imaginario img1, Imaginario img2)
        {
            double iEnt = 0;
            double iImg = 0;

            iEnt = ((img1.Entero * img2.Entero) + (img1.NImaginario * img2.NImaginario))/
                   ((img2.Entero * img2.Entero) + (img2.NImaginario * img2.NImaginario));
            
            iImg = ((img1.NImaginario * img2.Entero) - (img1.Entero * img2.NImaginario))/
                   ((img2.Entero * img2.Entero) + (img2.NImaginario * img2.NImaginario));

            Imaginario aux = new Imaginario(iEnt, iImg);

            return aux;
        }

        //Sobrecarga operadores unuarios
        public static Imaginario operator ++ (Imaginario img1)
        {
            Imaginario aux = new Imaginario(img1.Entero + 1, img1.NImaginario + 1);

            return aux;
        }

        public static Imaginario operator -- (Imaginario img1)
        {
            Imaginario aux = new Imaginario(img1.Entero - 1, img1.NImaginario - 1);

            return aux;
        }

        //Sobrecarga de operador de igualdad/desigualdad
        public override bool Equals(object? obj)
        {
            if(obj is Imaginario)
            {
                Imaginario aux = (Imaginario)obj;

                //Comparamos la igualdad
                if(this.nImaginario == aux.NImaginario && this.Entero == aux.Entero)
                {
                    return true;
                }

            }
            
            return false;
        }

        //ACLARACION! Si se sobrecarga el operador de igualdad ES OBLIGATORIO tambien sobrecargar el operador de desigualdad.
        public static bool operator == (Imaginario img1, Imaginario img2)
        {
            return img1.Equals(img2);
        }

        public static bool operator != (Imaginario img1, Imaginario img2)
        {
            return !(img1.Equals(img2));
        }

        //Para sobrecarga de < y > necesitamos IComparable
        public double magnitud ()
        {
            double m = 0;

            m = Math.Sqrt((this.entero * this.entero) + (this.nImaginario * this.nImaginario));

            return m;
        }

        //Seteamos CompareTo segun los parametro de nuestra clase
        public int CompareTo (object obj)
        {
            if(obj is Imaginario)
            {
                Imaginario aux = (Imaginario)obj;

                if(magnitud() > aux.magnitud())
                {
                    return 1;
                }

                if(magnitud() < aux.magnitud())
                {
                    return -1;
                }
            }

            return 0;
        }

        //Ahora si seteamos los operadores de comparacion
        public static bool operator < (Imaginario img1, Imaginario img2)
        {
            if(img1.CompareTo(img2) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator > (Imaginario img1, Imaginario img2)
        {
            if(img1.CompareTo(img2) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}