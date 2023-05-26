namespace CursoDesignPatterns.AulaIndexadores;

    public class Indexadores
    {
        private List<Indexadores> _indexadores  =  new List<Indexadores>();
        public string  Mensagem { get; set; }

        public Indexadores(string mensagem = "")
        {
            if(!string.IsNullOrEmpty(mensagem))
                Mensagem = mensagem;
        }

        public Indexadores this[int index]
        {
            get{ return _indexadores[index];}
            set {_indexadores.Add(value);}
        }
    }



