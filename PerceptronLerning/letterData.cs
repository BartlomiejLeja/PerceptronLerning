namespace PerceptronLerning
{
    class LetterData
    {
        private double[,] _letterPattern;
        private double _letterResult;

        public LetterData(double[,] letterPattern, double letterResult)
        {
            _letterPattern = letterPattern;
            _letterResult = letterResult;
        }

        public double[,] LetterPattern { get=> _letterPattern; set=> _letterPattern = value; }
        public double LetterResult { get=> _letterResult; set=> _letterResult=value; }
    }
}
