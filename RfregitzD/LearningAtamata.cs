/******************************************************************************
 * Ramin Edjlal CopyRigth 2015.************************************************
 * Learning Autamata.**********************************************************
 * The every sum of probability is one.****************************************
 * four formula .tow for Regard regim and tow for penalty regim.***************
 * Derived Quantum Auatamata Penalt All Objects of Derived Autamata************
 * MalFunctional Reward and Penalty Detection**********************************
 * Penaly Reward Action Failure************************************************
 * Mixturing of Penalty and Regard Data in IsRegard and IsPenalty Values*******
 * No Reason For MalFunctions of Reward and Penalty Mechanism******************
 * 1395/1/2********************************************************************
 ******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningMachine
{
   
    public class LearningKrinskyAtamata
    {
        int r = 100;
        int m = 100;
        int k = 100;
        public double[] alpha;
        bool beta = true;
        double[] fi;
        bool IsReward = false;
        bool IsPenalty = false;
        public double Reward;
        public double Penalty;        
        public int Success = 0, Failer = 0;
        public int State = 0;
        //int State = 1;
        public LearningKrinskyAtamata(int r0, int m0, int k0)
        {
            if (r0 >= m0)
            {
                r = r0;
                m = m0;
                k = k0;
                alpha = new double[r];
                fi = new double[k];
                fi = new double[r];
                for (int i = 0; i < r; i++)
                    alpha[i] = 1.0 / (double)r;
                for (int i = 0; i < k; i++)
                    fi[i] = 1.0 / (double)k;

                //Reward[i] = (double)(new Random()).Next(0, 100000) / 100000.0;
                Reward = 1.0 / (double)r;
                //Penalty[i] = (double)(new Random()).Next(0, 100000) / 100000.0;
                Penalty = 1.0 / (double)r;
            }
            else
                System.Windows.Forms.MessageBox.Show("Wrong Data! Action is Less Than Learning Automata Input!");
        }
        public void Clone(ref QuantumAtamata AA)
        {
             AA.r = this.r;
            AA.m = this.m;
            AA.k = this.k;
            alpha = new double[AA.r];
            for (int i = 0; i < AA.r; i++)
                AA.alpha[i] = this.alpha[i];
            AA.beta = this.beta;
            AA.Failer = this.Failer;
            fi = new double[AA.k];
            for (int i = 0; i < AA.k; i++)
                AA.fi[i] = this.fi[i];
            AA.IsPenalty = this.IsPenalty;
            AA.IsReward = this.IsReward;
            AA.Reward = this.Reward;
            AA.Penalty = this.Penalty;
            AA.Success = this.Success;
            AA.Failer = this.Failer;
            AA.State = this.State;
        }
        public void SuccessState()
        {
            Success++;
            if (State <= r)
                State = 1;
            else
                State = r-1;
        }
        public void FailureState()
        {
            Failer++;
            if (Success < Failer)
                if (State < r-1)
                    State++;
                else
                    State--;
        }
        public int IsSecondDerivitionIsPositive()
        {
            for (int i = 0; i < r - 2; i++)
            {
                if (((alpha[i + 2] - 2 * alpha[i + 1] + alpha[i]) / (1.0 / (double)r)) < 0)
                    return -1;
            }
            return 1;
        }
        public double LearningAlgorithmRegard()
        {
            this.IsReward = true;
            this.IsReward = false;
            alpha[State] += Reward * (1 - alpha[State]);
            for (int i = 0; i < r; i++)
                if (i != State)
                    alpha[i] -= Reward * alpha[i];
            beta = false;
            return alpha[State];

        }
        public int IsRewardAction()
        {
            if (this.IsReward)
                return 1;
            return -1;

        }

        public double IsPenaltyAction()
        {
            if (this.IsPenalty)
                return 0;
            return -1;
        }
        public double LearningAlgorithmPenalty()
        {
            this.IsPenalty = true;
            this.IsReward = false;
            alpha[State] -= Penalty * alpha[State];
            for (int i = 0; i < r; i++)
                if (i != State)
                {
                    alpha[i] -= Penalty * alpha[i];
                    alpha[i] += (Penalty / (r - 1));
                }
            beta = true;
            return alpha[State];
        }
    }
}
