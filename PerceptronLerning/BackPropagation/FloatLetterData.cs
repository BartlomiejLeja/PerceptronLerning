
namespace PerceptronLerning
{
    class FloatLetterData
    {
        private float[] _letterPattern;
        private float[] _letterResult;

        public FloatLetterData(float[] letterPattern, float[] letterResult)
        {
            _letterPattern = letterPattern;
            _letterResult = letterResult;
        }

        public float[] LetterPattern { get => _letterPattern; set => _letterPattern = value; }
        public float[] LetterResult { get => _letterResult; set => _letterResult = value; }
    }
}

