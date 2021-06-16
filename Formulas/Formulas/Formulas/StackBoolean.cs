namespace Formulas
{
    class StackBoolean
    {
        bool[] Stack = new bool[100];
        int Top = 99;
        public void Push(bool A)
        {
            if (isFull())
                return;
            Stack[Top] = A;
            Top--;

        }
        public bool Pop()
        {
            if (isEmpty())
                return false;
            Top++;
            return Stack[Top];

        }
        bool isEmpty()
        {
            if (Top == 99)
                return true;
            return false;
        }
        bool isFull()
        {
            if (Top == 0)
                return true;
            return false;
        }
    }
}


