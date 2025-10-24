namespace App.Models
{
    public abstract class MidiaBase
    {
        protected MidiaBase(string titulo)
        {
            this.Titulo = titulo;
        }
        
        public int Id { get; private set; }

        public string? Titulo { get; private set; }
    }
}