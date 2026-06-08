using System;
using System.Collections.Generic;
using System.Text;

namespace SplienSpace
{
    class Spline
    {
        private float[] S = null;
        private float[] SKx = null;
        private float[] SPrinKx = null;
        private float[] SSegondKx = null;
        private float[] Mk = null;
        private float[] Hk = null;
        private float[] Dk = null;
        private float[] Uk = null;
        

        //Len :Lengh of Time
        //S   :Array of S(t).
        //x   :dimension.
        //N   :Lengh of s(t)-converted form byte to float-.
        //constructor.Create a 3 Degree natural spline 
        public Spline(int Len,float[] St,float x,int N)
        { 
            //Defintion Elements.
            S=St;
            SKx = new float[Len];
            SPrinKx = new float[Len];
            SSegondKx = new float[Len];
            Mk = new float[Len+1]; 
            Hk = new float[Len]; 
            Dk = new float[Len]; 
            Uk = new float[Len];
            Mk = new float[Len];

            

            
            //insertion in proper location.
            int k=0;
            while(k<N)
            {
                Hk[k]=1;
                SKx[(int)(x*k)] = S[k];
                k++;
            }

            this.DKFind(N);
            this.UKFind(N);
            this.MkFind(N - 1, N);

            //we should find proper value.            
            //in here the Array will be completed.
            k = 0;
            int index=0;
            while (k < Len)
            { 
                
                for (int i = k; i < (int)(x * k); i++)
                    SKx[i] = this.GetSkx(i, k,(float)(x * k), SKx[k], SKx[(int)(x * k)], index);
                index++;
                k=(int)(x*k);
            }

            
        }
        private void DKFind(int N)
        {            
            for(int i=0;i<N-1;i++)
                Dk[i]=(S[i+1]-S[i])/Hk[i];
        }
        private void UKFind(int N)
        { 
            for(int i=0;i<N-1;i++)
               Uk[i]=6*(Dk[i]-Dk[i-1]);        
        }
        //In first set i is equal to N-1
        //the array Length is N+1
        private float MkFind(int i,int N)
        {
            if (i == 0) 
            {
                Mk[i] = 0;
                return Mk[i];
            }
            if (i == N-1)
                Mk[N] = 0;            
          Mk[i]=(Uk[i-1]-(Hk[i-2]*this.MkFind(i-2,N))
              -(2*(Hk[i-2]+Hk[i-1])*this.MkFind(i-1,N)))/Hk[i-1];
          return Mk[i];
        }
        private float GetSkx(float x, float xk, float xk1, float yk,float yk1,int k)
        {
            float Sum = 0;
            Sum =(float) (Mk[k] * (System.Math.Pow(xk1 - x, 3)) / (6 * Hk[k]) +
                (Mk[k + 1] * System.Math.Pow(x - xk, 3)) / (6 * Hk[k]) +
                ((yk / Hk[k]) - (Mk[k] / 6)) * (xk1 - x) +
                ((yk1 / Hk[k]) - (Mk[k + 1] * Hk[k] / 6)) * (x - xk));
            return Sum;
        }
    }
}
