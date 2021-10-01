using System;

namespace LongestSubSequence
{
    public class LongestSubSeqAPI
    {
        public static string LongestSubSeq(string inpSeq)
        {
            #region Variable initialization
            string[] arrSeq = inpSeq.Split(' '); //splitting the input array
            string outSeq = arrSeq[0]; //assigned the output string with the first element of the input incase no incrementing sub sequence is available.
            int maxLength = 1; //Assigned the maxLength to 1.
            string tempSeq = arrSeq[0]; //Temporary sequence for calculations and operations.
            #endregion

            #region Logic to traverse the input array and find the sub sequence.
            for (int i = 0; i < arrSeq.Length - 1; i++)
            {
                if (int.Parse(arrSeq[i + 1]) > int.Parse(arrSeq[i]))
                {
                    if (tempSeq.Length == 0)
                    {
                        tempSeq = arrSeq[i];
                    }
                    tempSeq = tempSeq + ' ' + arrSeq[i + 1];
                    maxLength += 1;
                }
                else
                {
                    if (outSeq.Split(' ').Length < tempSeq.Split(' ').Length)
                    {
                        outSeq = tempSeq;
                    }
                    tempSeq = string.Empty;
                    maxLength = 1;

                }
            }
            
            if (outSeq.Split(' ').Length < tempSeq.Split(' ').Length)
            {
                outSeq = tempSeq;
            }
            #endregion

            return outSeq;
        }
    }
}
