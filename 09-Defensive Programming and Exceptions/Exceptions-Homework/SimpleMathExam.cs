namespace Exceptions_Homework
{
    using System;

    public class SimpleMathExam : Exam
    {
        private const int MinProblemSolved = 0;
        private const int MaxProblemSolved = 10;
        private const int BadResult = 2;
        private const int AverageResult = 4;
        private const int VeryGoodResult = 6;
        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                if (this.problemsSolved < MinProblemSolved)
                {
                    return MinProblemSolved;
                }
                else if (this.problemsSolved > MaxProblemSolved)
                {
                    return MaxProblemSolved;
                }
                else
                {
                    return this.problemsSolved;
                }
            }

            private set
            {
                this.problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            if (this.ProblemsSolved == 0)
            {
                return new ExamResult(BadResult, BadResult, VeryGoodResult, "Bad result: nothing done.");
            }
            else if (this.ProblemsSolved == 1)
            {
                return new ExamResult(AverageResult, BadResult, VeryGoodResult, "Average result: nothing done.");
            }
            else if (this.ProblemsSolved == 2)
            {
                return new ExamResult(VeryGoodResult, BadResult, VeryGoodResult, "Average result: nothing done.");
            }

            return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
        }
    }
}