namespace Graphic
{
    public class Squares
    {
        public int[,,] lwBase = null;
        public int[,,] lwUp = null;
        public int Row = 0;
        public int Column = 0;
        public Squares(int destinx, int destiny)
        {
            Row = (destinx) / 40;
            Column = (destiny) / 40;
            lwBase = new int[(destinx) / 40, (destiny) / 40, 4];
            lwUp = new int[(destinx) / 40, (destiny) / 40, 4];
            for (int i = 0; i < destinx; i = i + 40)
                for (int j = 0; j < destiny; j = j + 40)
                {
                    lwBase[i / 40, j / 40, 0] = i;
                    lwBase[i / 40, j / 40, 1] = j;
                    lwBase[i / 40, j / 40, 2] = i + 40;
                    lwBase[i / 40, j / 40, 3] = j + 40;
                    lwUp[i / 40, j / 40, 0] = i + 3;
                    lwUp[i / 40, j / 40, 1] = j + 3;
                    lwUp[i / 40, j / 40, 2] = i + 40 - 3;
                    lwUp[i / 40, j / 40, 3] = j + 40 - 3;
                }

        }
    }
}
