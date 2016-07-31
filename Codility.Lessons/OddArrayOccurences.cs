﻿using System;

namespace Codility.Lessons
{
    public class OddArrayOccurences
    {
        public const int Duplicate = 0;

        public int solution(int[] A)
        {
            return FindUnpaired(A);
        }

        public int FindUnpaired(int[] array)
        {
            if (array.Length % 2 == 0)
            {
                throw new ArgumentException();
            }

            // TODO: This should be O(n) in the worst case
            for (int i = 0; i < array.Length; i++)
            {
                int currentItem = array[i];
                if (currentItem == Duplicate)
                    continue;

                bool isFound = false;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (currentItem == array[j])
                    {
                        isFound = true;
                        array[j] = Duplicate;
                        break;
                    }
                }

                if (!isFound)
                {
                    return currentItem;
                }
            }

            return array[0];
        }
    }
}
