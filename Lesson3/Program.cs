namespace Lesson_3
{
    internal class Program
    {
        //151-166,
        //211-280,
        //281-310,
        //333-356

        static void Main(string[] args)
        {
            //21-36

            int[] abcArr = new int[3] { 9, 16, 5 };
            int maxVal = 0;
            int minVal = abcArr[0];
            int maxValueIndex = 0;
            int minValueIndex = 0;
            bool contestOne = false;


            //21
            for (int i = 0; i < abcArr.Length; i++)
            {
                if (maxVal < abcArr[i])
                {
                    maxVal = abcArr[i];
                    maxValueIndex = i;
                }
            }
            Console.WriteLine("21. - " + maxVal);


            //22
            for (int i = 0; i < abcArr.Length; i++)
            {
                if (minVal >= abcArr[i])
                {
                    minVal = abcArr[i];
                    minValueIndex = i;
                }
            }
            Console.WriteLine("22. - " + minVal);


            //23
            for (int i = 0; i < abcArr.Length; i++)
            {
                if (abcArr[i] == 1)
                {
                    contestOne = true;
                }
            }
            Console.WriteLine("23. - " + contestOne);


            //24
            if (abcArr[0] == 2 && abcArr[1] == 2 || abcArr[0] == 2 && abcArr[2] == 2 || abcArr[1] == 2 && abcArr[2] == 2)
            {
                Console.WriteLine("24. - true");
            }
            else
            {
                Console.WriteLine("24. - false");
            }


            //25
            if (abcArr[0] + abcArr[1] < 16)
            {
                Console.WriteLine("25. - y=1");
            }
            else
            {
                Console.WriteLine("25. - y=2");
            }


            //26
            bool isOdd = false;
            for (int i = 0; i < abcArr.Length; i++)
            {
                if (abcArr[i] % 2 == 0)
                {
                    Console.WriteLine("26. - 1");
                    isOdd = true;
                }
            }
            if (isOdd != true)
            {
                Console.WriteLine("26. - 2");
            }


            //27
            if (abcArr[2] - abcArr[1] == abcArr[1] - abcArr[0])
            {
                Console.WriteLine("27. - true");
            }
            else
            {
                Console.WriteLine("27. - false");
            }


            //28
            if (abcArr[2] / abcArr[1] == abcArr[1] / abcArr[0])
            {
                Console.WriteLine("28. - true");
            }
            else
            {
                Console.WriteLine("28. - false");
            }


            //29-30

            int middlevalue = 0;
            for (int i = 0; i < abcArr.Length - 1; i++)
            {
                if (i != maxValueIndex && i != minValueIndex)
                {
                    middlevalue = i;
                    break;
                }
            }
            Console.WriteLine(abcArr[minValueIndex] + "  " + abcArr[middlevalue] + "  " + abcArr[maxValueIndex]);
            Console.WriteLine(abcArr[maxValueIndex] + "  " + abcArr[middlevalue] + "  " + abcArr[minValueIndex]);


            //կամ էլ եթե Array-ը մեծ ա սենց կարանք սորտավորենք

            //Console.Write("29. - ");
            //int prop;
            //for (int i = 0; i < abcArr.Length; i++)
            //{
            //    for (int j = 0; j < abcArr.Length; j++)
            //    {
            //        if (abcArr[i]> abcArr[j])
            //        {
            //            prop = abcArr[i];
            //            abcArr[i] = abcArr[j];
            //            abcArr[j] = prop;
            //        }
            //    }
            //}
            //for (int i = 0; i < abcArr.Length; i++)
            //{
            //    Console.Write(abcArr[i]+",");
            //}

            ////30
            //Console.Write("\n"+"30. - ");
            //prop = 0;
            //for (int i = 0; i < abcArr.Length; i++)
            //{
            //    for (int j = 0; j < abcArr.Length; j++)
            //    {
            //        if (abcArr[i] < abcArr[j])
            //        {
            //            prop = abcArr[i];
            //            abcArr[i] = abcArr[j];
            //            abcArr[j] = prop;
            //        }
            //    }
            //}
            //for (int i = 0; i < abcArr.Length; i++)
            //{
            //    Console.Write(abcArr[i] + ",");
            //}




            //34
            Console.Write("\n\n" + "34. ");
            int[] abcdArr = new int[4] { 41, 59, 4, 202 };
            int[] abcdArrСheck = new int[4];
            bool checkSum = false;

            int j = 0;
            for (int i = 0; i < abcdArr.Length - 1; i++)
            {
                for (j = i + 1; j < abcdArr.Length; j++)
                {
                    Console.Write((abcdArr[i] + abcdArr[j]) + ",");
                    abcdArrСheck[i] = (abcdArr[i] + abcdArr[j]);
                }
            };

            int k = 0;
            for (int i = 0; i < abcdArrСheck.Length - 1; i++)
            {

                for (k = i + 1; k < abcdArrСheck.Length; k++)
                {
                    if (abcdArrСheck[i] == abcdArrСheck[k])
                    {
                        checkSum = true;
                    }
                }
            };
            Console.WriteLine("\n" + checkSum);
            checkSum = false;
            //36
            Console.Write("\n\n" + "36.");
            for (int i = 0; i < abcdArr.Length - 1; i++)
            {
                for (j = i + 1; j < abcdArr.Length; j++)
                {
                    if (abcdArr[i] % 2 != 0 && abcdArr[j] % 2 != 0)
                    {
                        checkSum = true;

                    }

                }
            };
            Console.Write(checkSum);



            //51
            Console.Write("\n\n" + "51.");

            int tripleNum = 459;
            int tripleNum2 = tripleNum;
            int first = 0;


            bool t = false;
            for (; tripleNum > tripleNum2 / 100 + 1;)
            {
                tripleNum = tripleNum / 10;
                first = tripleNum;
            }
            if (tripleNum + tripleNum2 % 100 / 10 == tripleNum2 % 10)
            {
                t = true;
            }
            Console.Write(t);



            //52

            Console.Write("\n\n" + "52.");
            t = false;
            int second = tripleNum2 % 100 / 10;
            int last = tripleNum2 % 10;

            if (first == second || first == last || second == last)
            {
                t = true;
            }
            Console.Write(t);
            Console.WriteLine(" " + first + " " + second + " " + last);


            //211
            Console.Write("\n\n" + "211. ");
            int[] mAndPlus = new int[50];

            for (int i = 0; i < mAndPlus.Length; i++)
            {
                Random rnd = new Random();
                mAndPlus[i] = rnd.Next(-150, 150);
            }
            int sum = 0;
            int incr = 1;
            int howMany = 0;
            for (int i = 0; i < mAndPlus.Length; i++)
            {
                if (mAndPlus[i] > 0)
                {
                    sum = sum + mAndPlus[i];
                    incr = incr * mAndPlus[i];
                    howMany++;
                }
            }
            Console.Write(sum / howMany);

            //212
            Console.Write("\n\n" + "211. ");
            Console.Write(Convert.ToInt64(Math.Sqrt(sum / howMany)));



            //215
            Console.Write("\n\n" + "215. ");
            int sum2 = 0;
            for (int i = 0; i < mAndPlus.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum2 = sum + mAndPlus[i];
                }
            }
            Console.Write(sum2);


        }
    }
}