using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPrototype
{
    public class Level
    {
        private readonly char category;
        private IList<int> scores;

        public Level(char category, IEnumerable<int> scores)
        {
            this.category = category;
            this.scores = new List<int>(scores);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"{category}:");
            foreach (float sc in scores) sb.Append($" {sc}");
            return sb.ToString();
        }

        public void IncScores()
        {
            for (int i = 0; i < scores.Count; i++) scores[i] += 1;
        }

        /// <summary>
        /// Vai sair no teste
        /// </summary>
        /// <returns></returns>
        public Level ShallowCopy()
        {
            Level copy = MemberwiseClone() as Level;

            return copy;
        }

        /// <summary>
        /// Vai sair no teste
        /// </summary>
        /// <returns> copia dos valores da lista original</returns>
        public Level DeepCopy()
        {
            Level copy = MemberwiseClone() as Level;

            copy.scores = new List<int>(scores);

            return copy;
        }
    }
}