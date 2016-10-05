using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accenture
{
    public class Repeat
    {
        public string FindDuplicatedStrRemoved(int charCountInput, string sentence)
        {
            if (charCountInput == -1)
            {
                Console.WriteLine("Not a number");
                Console.WriteLine(Environment.NewLine);
            }
            else
            {
                var results = sentence.ToCharArray()
                                       .GroupBy(c => c)
                                       .Where(g => g.Count() > 1)
                                       .Select(g => new { Letter = g.First(), Count = g.Count() });

                var replacedChars = results.Where(w => w.Count >= charCountInput && w.Letter != ' ').ToList();

                foreach (var replacedCharIndex in replacedChars)
                {
                    var result = sentence.Select((b, i) => b.Equals(replacedCharIndex.Letter) ? i : -1).Where(i => i != -1);
                    var serieses = result.Aggregate(
                        new List<Tuple<int, int>>(),
                        (l, i) =>
                        {
                            var last = l.LastOrDefault();
                            if (last == null ||
                                last.Item1 + last.Item2 != i)
                            {
                                l.Add(new Tuple<int, int>(i, 1));
                            }
                            else if (last.Item1 + last.Item2 == i)
                            {
                                l.RemoveAt(l.Count - 1);
                                l.Add(new Tuple<int, int>(last.Item1, last.Item2 + 1));
                            }

                            return l;
                        },
                        l => l);

                    var repIndexList = serieses.Where(q => q.Item2 >= charCountInput).ToList();
                    if (repIndexList.Count() != 0)
                    {
                        foreach (var repIndex in repIndexList)
                        {
                            sentence = sentence.Remove(Convert.ToInt32(repIndex.Item1.ToString()), Convert.ToInt32(repIndex.Item2.ToString()));
                            for (int i = 0; i < repIndex.Item2; i++)
                                sentence = sentence.Insert(Convert.ToInt32(repIndex.Item1.ToString()) + i, "*");
                        }
                    }
                }
            }

            return sentence;
        }
    }
}
