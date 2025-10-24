namespace App.Models
{
    public abstract class MidiaBase
    {
        protected MidiaBase( string titulo)
        {
            this.Titulo = titulo;
        }

        public string? Titulo { get; private set; }
    }
}