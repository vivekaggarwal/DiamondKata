using System.Text;

namespace DiamondKata
{
    public class Diamond
    {
        private const char PaddingChar = ' ';
        private const char FirstLetter = 'A';

        private char _upToLetter;
        private int _maxWidth;
        private IEnumerable<int> _outerPaddings;
        private IEnumerable<int> _innerPaddings;

        public Diamond(char upToLetter)
        {
            _upToLetter = char.ToUpper(upToLetter);

            _maxWidth = _upToLetter - 64;
            _outerPaddings = Enumerable.Range(0, _maxWidth)
                                       .Reverse();
            _innerPaddings = Enumerable.Range(0, _maxWidth)
                                       .Select(n => n > 1 ? n * 2 - 1 : n);
        }

        public string Crystalise()
        {
            if (_upToLetter.Equals(FirstLetter))
            {
                return "A";
            }

            var topHalfOfDiamond = BuildTopHalf();
            var bottomHalfOfDiamond = topHalfOfDiamond.Take(_maxWidth - 1).Reverse();
            var fullDiamond = topHalfOfDiamond.Concat(bottomHalfOfDiamond);
            var result = string.Join("\n", fullDiamond);
            return result;
        }

        private IEnumerable<string> BuildTopHalf()
        {
            var topHalfOfDiamond = new List<string>();
            var counter = 0;

            for (char letter = FirstLetter; letter <= Char.ToUpper(_upToLetter); letter++)
            {
                var diamondLayer = new StringBuilder();
                diamondLayer.Append(string.Empty.PadLeft(_outerPaddings.ToArray()[counter], PaddingChar));
                diamondLayer.Append(letter);

                if (letter != FirstLetter)
                {
                    diamondLayer.Append(string.Empty.PadLeft(_innerPaddings.ToArray()[counter], PaddingChar));
                    diamondLayer.Append(letter);
                }

                topHalfOfDiamond.Add(diamondLayer.ToString());
                counter++;
            }

            return topHalfOfDiamond;
        }
    }
}
