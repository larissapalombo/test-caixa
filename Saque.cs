using System;
namespace gama_xp_test_larissa
{
    public class Saque
    {
        public int id { get; set; }

        public int _value { get; set; }

        public Saque(int value)
        {
            _value = value;
            realizarSaque(value);
        }

        public Saque salvar()
        {
            return this;
        }

        public void realizarSaque(int _saqueValor)
        {
            try
            {

                int saqueValor = _saqueValor;
                Nota currentNote = Nota.NotaCem;
                int QtdNota = 0;

                while (true)
                {
                    if (saqueValor >= (int)currentNote)
                    {
                        saqueValor -= (int)currentNote;
                        QtdNota += 1;
                        Console.WriteLine($"R${(int)currentNote}");
                    }
               

                    if(saqueValor == 0 || saqueValor < 5)
                    {
                        break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Não pode sacar esse valor");
            }
        }

    }
}
