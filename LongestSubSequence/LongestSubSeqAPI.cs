using System;

namespace LongestSubSequence
{
    public class LongestSubSeqAPI
    {
        public static string LongestSubSeq(string inpSeq)
        {
            string[] arrSeq = inpSeq.Split(' ');
            string outSeq = arrSeq[0];
            int maxLength = 1;
            string tempSeq = arrSeq[0];

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
            return outSeq;
        }
    }
}
