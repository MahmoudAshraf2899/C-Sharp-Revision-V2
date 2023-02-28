namespace ProjectOne
{
    public partial class Program
    {
        public class IPAddress
        {
            private int[] segmants = new int[4];
            //segmants should be from 1 to 255
            public IPAddress(int segmants1, int segmants2, int segmants3, int segmants4)
            {
                segmants[0] = segmants1;
                segmants[1] = segmants2;
                segmants[2] = segmants3;
                segmants[3] = segmants4;
            }
            public string Address => string.Join(".", segmants);
        }
    }
}