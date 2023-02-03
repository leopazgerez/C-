namespace Test.MiniComponente
{
    public class MiniComponente
    {
        Mp3 mp3;
        Cd cd;
        BaseMedia current;

        public MiniComponente()
        {
            mp3 = new Mp3();
            cd = new Cd();
            current = mp3;
        }

        public void Play()
        {
            current.Play();
        }

        public void SetMp3()
        {
            current = mp3;
        }

        public void SetCd()
        {
            current = cd;
        }
    }
}
