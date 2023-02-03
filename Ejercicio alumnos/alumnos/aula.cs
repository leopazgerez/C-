namespace alumnos
{
    class aula
    {
        public Robot a1;
        public Robot a2;
        public Robot a3;
        public Persona a4;
        public Persona a5;

        public aula()
        {
            a1 = new Robot();
            a2 = new Robot();
            a3 = new Robot();
            a4 = new Persona();
            a5 = new Persona();
        }
        public void PasarAlFrente(IHablar alumno)
        {
            alumno.hablar();
        }
    }
}
