namespace SerializacionComposicion
{
    [Serializable]
    class CMotor
    {
        private int cilindros;
        private int hp;

        public int Cilindros { get => this.cilindros; set => this.cilindros = value; }
        public int Hp { get => this.hp; set => this.hp = value; }

        public CMotor ()
        {
            this.cilindros = 4;
            this.hp = 200;
        }

        public void MostrarMotor ()
        {
            Console.WriteLine("=== Cilindros: {0}, HP: {1}", this.cilindros, this.hp);
        }
    }
}