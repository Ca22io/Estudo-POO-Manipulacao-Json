namespace App.Models
{
    public abstract class MidiaBase
    {
        protected MidiaBase(string titulo)
        {
            this.Titulo = titulo;
        }
        
        public int Id { get; protected set; }

        public string? Titulo { get; set; }

        public static class IdGenerator
        {
            private static int _last = 0;
            public static int Next() => Interlocked.Increment(ref _last);
        }
    }
}